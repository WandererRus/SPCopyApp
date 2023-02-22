namespace SPCopyApp
{
    public partial class Form1 : Form
    {
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

        private async void btn_start_Click(object sender, EventArgs e)
        {
            /* Объявления переменных и открытие потоков */
            FileStream fsopen = new FileStream(tb_originPath.Text, FileMode.Open, FileAccess.Read, FileShare.Read, 100, FileOptions.Asynchronous);
            FileStream fswrite = new FileStream(tb_targetPath.Text, FileMode.OpenOrCreate);
            byte[] b;
            long lengthfile = fsopen.Length;    

            //  Устанавливаем начальные значения прогресс бара         
            pb_copyProgress.Maximum = 1000;
            pb_copyProgress.Minimum = 0;

            // создаем массив чтения файла из countOperation частей
            int countOperation = 100000;
            long[] partsfilelength = new long[countOperation];
            for (int i = 0; i < countOperation; i++)
            {
                partsfilelength[i] = lengthfile / countOperation;
                if( i == countOperation - 1)
                    partsfilelength[i] += lengthfile % countOperation;
            }
            //  Устанавливаем значения прогресс бара    
            long pbvalue = 1;
            if (lengthfile > 1000)
                pbvalue = lengthfile / 1000;

            b = new byte[partsfilelength[0]];
            IAsyncResult result;
            result = fsopen.BeginRead(b, 0, b.Length, null , null);

            /*while (!result.IsCompleted) // проверка выполнения fsopen.BeginRead. 
             // Асинхронная операция не возвращает готовый результат, пока не выполнит все операции.
             // А запрос к результатам мы можем попробовать сделать раньше выполнения и это вызовет ошибку.
            {
                richTextBox1.Text = "Еще не готово";
            }*/




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
            fswrite.Close();
        }
        
    }
}