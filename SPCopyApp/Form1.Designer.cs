namespace SPCopyApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tb_originPath = new System.Windows.Forms.TextBox();
            this.tb_targetPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_threads = new System.Windows.Forms.ComboBox();
            this.btn_start = new System.Windows.Forms.Button();
            this.pb_copyProgress = new System.Windows.Forms.ProgressBar();
            this.ofd_originPath = new System.Windows.Forms.OpenFileDialog();
            this.btn_openFile = new System.Windows.Forms.Button();
            this.btn_saveFile = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Путь к исходному файлу:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tb_originPath
            // 
            this.tb_originPath.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_originPath.Location = new System.Drawing.Point(12, 39);
            this.tb_originPath.Name = "tb_originPath";
            this.tb_originPath.Size = new System.Drawing.Size(741, 29);
            this.tb_originPath.TabIndex = 1;
            // 
            // tb_targetPath
            // 
            this.tb_targetPath.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_targetPath.Location = new System.Drawing.Point(12, 101);
            this.tb_targetPath.Name = "tb_targetPath";
            this.tb_targetPath.Size = new System.Drawing.Size(741, 29);
            this.tb_targetPath.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Путь к копируемому файлу:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(350, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Количество потоков для копирования:";
            // 
            // cb_threads
            // 
            this.cb_threads.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_threads.FormattingEnabled = true;
            this.cb_threads.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cb_threads.Location = new System.Drawing.Point(12, 161);
            this.cb_threads.Name = "cb_threads";
            this.cb_threads.Size = new System.Drawing.Size(776, 29);
            this.cb_threads.TabIndex = 5;
            this.cb_threads.Text = "1";
            // 
            // btn_start
            // 
            this.btn_start.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_start.Location = new System.Drawing.Point(312, 196);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(157, 47);
            this.btn_start.TabIndex = 6;
            this.btn_start.Text = "Старт";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // pb_copyProgress
            // 
            this.pb_copyProgress.Location = new System.Drawing.Point(12, 415);
            this.pb_copyProgress.Name = "pb_copyProgress";
            this.pb_copyProgress.Size = new System.Drawing.Size(776, 23);
            this.pb_copyProgress.TabIndex = 7;
            // 
            // ofd_originPath
            // 
            this.ofd_originPath.FileName = "openFileDialog1";
            // 
            // btn_openFile
            // 
            this.btn_openFile.Location = new System.Drawing.Point(760, 39);
            this.btn_openFile.Name = "btn_openFile";
            this.btn_openFile.Size = new System.Drawing.Size(28, 29);
            this.btn_openFile.TabIndex = 8;
            this.btn_openFile.Text = "...";
            this.btn_openFile.UseVisualStyleBackColor = true;
            this.btn_openFile.Click += new System.EventHandler(this.btn_openFile_Click);
            // 
            // btn_saveFile
            // 
            this.btn_saveFile.Location = new System.Drawing.Point(760, 101);
            this.btn_saveFile.Name = "btn_saveFile";
            this.btn_saveFile.Size = new System.Drawing.Size(28, 29);
            this.btn_saveFile.TabIndex = 9;
            this.btn_saveFile.Text = "...";
            this.btn_saveFile.UseVisualStyleBackColor = true;
            this.btn_saveFile.Click += new System.EventHandler(this.btn_saveFile_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(20, 259);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(768, 150);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btn_saveFile);
            this.Controls.Add(this.btn_openFile);
            this.Controls.Add(this.pb_copyProgress);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.cb_threads);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_targetPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_originPath);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox tb_originPath;
        private TextBox tb_targetPath;
        private Label label2;
        private Label label3;
        private ComboBox cb_threads;
        private Button btn_start;
        private ProgressBar pb_copyProgress;
        private OpenFileDialog ofd_originPath;
        private Button btn_openFile;
        private Button btn_saveFile;
        private RichTextBox richTextBox1;
    }
}