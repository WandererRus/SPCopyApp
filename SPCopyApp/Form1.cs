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
            tb_originPath.Text = Directory.GetCurrentDirectory();
            tb_targetPath.Text = Directory.GetCurrentDirectory();
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
            byte[] data = new byte[5];
            fsopen.Read(data, 0, 5);
            fsopen.Close();
            FileStream fswrite = new FileStream(tb_targetPath.Text, FileMode.OpenOrCreate);
            fswrite.Write(data, 0, 5);
            fswrite.Close();
        }
    }
}