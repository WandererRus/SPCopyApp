using System.Text;

namespace SPCopyApp
{
    public partial class Form1 : Form
    {
        byte[] data;
        long lengthfile;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tb_originPath.Text = @"D:\text.txt";
            tb_targetPath.Text = @"D:\textcopy.txt";
        }

        private void btn_openFile_Click(object sender, EventArgs e)
        {
            ofd_originPath.FileName = Directory.GetCurrentDirectory();
            if (ofd_originPath.ShowDialog() == DialogResult.OK)
            {
                tb_originPath.Text = ofd_originPath.FileName;
                tb_targetPath.Text = ofd_originPath.FileName;
            }
        }

        private void btn_saveFile_Click(object sender, EventArgs e)
        {

        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            /* Объявления переменных и открытие потоков */
            FileStream fsopen = new FileStream(tb_originPath.Text, FileMode.Open, FileAccess.Read, FileShare.Read, 100, FileOptions.Asynchronous);
            lengthfile = fsopen.Length;               
            

            // создаем массив чтения файла из countOperation частей
            int countOperation = Int32.Parse(cb_threads.Items[cb_threads.SelectedIndex].ToString()); // количество частей на которые разбивается длина файла

            //  Устанавливаем начальные значения прогресс бара         
            pb_copyProgress.Maximum = countOperation;
            pb_copyProgress.Minimum = 0;

            long[] partsfilelength = new long[countOperation];
            for (int i = 0; i < countOperation; i++)
            {
                partsfilelength[i] = lengthfile / countOperation;
                if( i == countOperation - 1)
                    partsfilelength[i] += lengthfile % countOperation;
            }
            //  Устанавливаем значения прогресс бара      
            TestDel test = testing;

            for (int i = 0; i < countOperation; i++)
            {                
                data = new byte[partsfilelength[i]];
                int pos = data.Length * i;
                fsopen.BeginRead(data, 0, data.Length, MessageBoxPrint, new MyStateObject(data,fsopen, tb_targetPath.Text, pos));

                pb_copyProgress.EndInvoke(pb_copyProgress.BeginInvoke(testing));
                
            }


            /*IAsyncResult result; Примеры не эффективной обработки асинхронных запросов              
            result = fsopen.BeginRead(b, 0, b.Length, null , null);
            /*while (!result.IsCompleted) // проверка выполнения fsopen.BeginRead. 
             // Асинхронная операция не возвращает готовый результат, пока не выполнит все операции.
             // А запрос к результатам мы можем попробовать сделать раньше выполнения и это вызовет ошибку.
            {
                richTextBox1.Text = "Еще не готово";
                Thread.Sleep(20);
            }*/
            /*while (!result.AsyncWaitHandle.WaitOne(20))
            {
                richTextBox1.Text = "Еще не готово";
            }*/
            //fsopen.EndRead(result);*/
            /*foreach (byte bt in b)
            {
                richTextBox1.Text += bt;
            }*/

            /* foreach (long i in partsfilelength)
             {
                 b = new byte[i];
                 fsopen.BeginRead(b, 0, b.Length, null, null);

                 //fsopen.Read(b, 0, b.Length);
                 //fswrite.Write(b, 0, b.Length);                
                 //pb_copyProgress.Value = (int)(lengthfile / pbvalue); 
             }      */
            fsopen.Close();            
        }


        void MessageBoxPrint(IAsyncResult asyncResult)
        {
            MyStateObject mystate = (MyStateObject)asyncResult.AsyncState;
            mystate.EndRead(asyncResult);
            mystate.Write();
        }


        delegate void TestDel();


        void testing() 
        {
            pb_copyProgress.Value++;
        }
    }


    class MyStateObject
    {
        byte[] _bytes;
        FileStream _fs;
        FileStream _fswrite;

        public MyStateObject(byte[] bytes, FileStream fs, string path, int position) 
        {
            _bytes = bytes; 
            _fs = fs;
            _fswrite = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write, FileShare.Write, 100, FileOptions.Asynchronous);
            _fswrite.Position = position;
        }
        public void EndRead(IAsyncResult asyncResult)
        {
            _fs.EndRead(asyncResult);
        }

        public void Write()
        {
            _fswrite.BeginWrite(_bytes, 0, _bytes.Length, CloseWrite, _fswrite);

        }

        private void CloseWrite(IAsyncResult asyncResult) 
        {
            FileStream stream = (FileStream)asyncResult.AsyncState;
            stream.EndWrite(asyncResult);
            
            _fswrite.Close();
        }
    }
}