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

        private void btn_start_Click(object sender, EventArgs e)
        {
            FileStream fsopen = new FileStream(tb_originPath.Text, FileMode.Open);
            FileStream fswrite = new FileStream(tb_targetPath.Text, FileMode.OpenOrCreate);
            int b;
            long lengthfile = fsopen.Length;
            int countOperation = 3;
            int[] partsfilelength = new int[countOperation];            
            for (int i = 0; i < countOperation; i++)
            {
                partsfilelength[i] = (int)lengthfile / countOperation;
                if( i == countOperation - 1)
                    partsfilelength[i] += (int)lengthfile % countOperation;
            }

            while ((b = fsopen.ReadByte()) != -1)
            {
                fswrite.WriteByte((byte)b);
            }            
            fsopen.Close();            
            fswrite.Close();
        }
    }
}