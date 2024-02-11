namespace HW_CopyFileInThread
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_pathFile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.b_openFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tb_savePath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.b_savePath = new System.Windows.Forms.Button();
            this.numUpDown_threads = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.pgBar = new System.Windows.Forms.ProgressBar();
            this.b_startCopy = new System.Windows.Forms.Button();
            this.b_copySleep = new System.Windows.Forms.Button();
            this.b_copyStop = new System.Windows.Forms.Button();
            this.rb_file = new System.Windows.Forms.RadioButton();
            this.rb_directory = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_threads)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_pathFile
            // 
            this.tb_pathFile.Location = new System.Drawing.Point(12, 36);
            this.tb_pathFile.Name = "tb_pathFile";
            this.tb_pathFile.Size = new System.Drawing.Size(238, 20);
            this.tb_pathFile.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Путь к файлу";
            // 
            // b_openFile
            // 
            this.b_openFile.Location = new System.Drawing.Point(124, 8);
            this.b_openFile.Name = "b_openFile";
            this.b_openFile.Size = new System.Drawing.Size(126, 23);
            this.b_openFile.TabIndex = 2;
            this.b_openFile.Text = "Выбрать файл";
            this.b_openFile.UseVisualStyleBackColor = true;
            this.b_openFile.Click += new System.EventHandler(this.b_openFile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tb_savePath
            // 
            this.tb_savePath.Location = new System.Drawing.Point(12, 187);
            this.tb_savePath.Name = "tb_savePath";
            this.tb_savePath.Size = new System.Drawing.Size(238, 20);
            this.tb_savePath.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Новый путь";
            // 
            // b_savePath
            // 
            this.b_savePath.Location = new System.Drawing.Point(124, 158);
            this.b_savePath.Name = "b_savePath";
            this.b_savePath.Size = new System.Drawing.Size(126, 23);
            this.b_savePath.TabIndex = 2;
            this.b_savePath.Text = "Выбрать файл";
            this.b_savePath.UseVisualStyleBackColor = true;
            this.b_savePath.Click += new System.EventHandler(this.b_savePath_Click);
            // 
            // numUpDown_threads
            // 
            this.numUpDown_threads.Location = new System.Drawing.Point(130, 62);
            this.numUpDown_threads.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numUpDown_threads.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDown_threads.Name = "numUpDown_threads";
            this.numUpDown_threads.Size = new System.Drawing.Size(120, 20);
            this.numUpDown_threads.TabIndex = 3;
            this.numUpDown_threads.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Количество потоков";
            // 
            // pgBar
            // 
            this.pgBar.Location = new System.Drawing.Point(12, 227);
            this.pgBar.Name = "pgBar";
            this.pgBar.Size = new System.Drawing.Size(238, 23);
            this.pgBar.Step = 5;
            this.pgBar.TabIndex = 5;
            // 
            // b_startCopy
            // 
            this.b_startCopy.Location = new System.Drawing.Point(99, 274);
            this.b_startCopy.Name = "b_startCopy";
            this.b_startCopy.Size = new System.Drawing.Size(75, 23);
            this.b_startCopy.TabIndex = 6;
            this.b_startCopy.Text = "Копировать";
            this.b_startCopy.UseVisualStyleBackColor = true;
            this.b_startCopy.Click += new System.EventHandler(this.b_startCopy_Click);
            // 
            // b_copySleep
            // 
            this.b_copySleep.Location = new System.Drawing.Point(99, 303);
            this.b_copySleep.Name = "b_copySleep";
            this.b_copySleep.Size = new System.Drawing.Size(75, 23);
            this.b_copySleep.TabIndex = 6;
            this.b_copySleep.Text = "Остановить";
            this.b_copySleep.UseVisualStyleBackColor = true;
            this.b_copySleep.Click += new System.EventHandler(this.b_copySleep_Click);
            // 
            // b_copyStop
            // 
            this.b_copyStop.Location = new System.Drawing.Point(99, 332);
            this.b_copyStop.Name = "b_copyStop";
            this.b_copyStop.Size = new System.Drawing.Size(75, 23);
            this.b_copyStop.TabIndex = 6;
            this.b_copyStop.Text = "Прервать";
            this.b_copyStop.UseVisualStyleBackColor = true;
            this.b_copyStop.Click += new System.EventHandler(this.b_copyStop_Click);
            // 
            // rb_file
            // 
            this.rb_file.AutoSize = true;
            this.rb_file.Location = new System.Drawing.Point(15, 104);
            this.rb_file.Name = "rb_file";
            this.rb_file.Size = new System.Drawing.Size(54, 17);
            this.rb_file.TabIndex = 7;
            this.rb_file.TabStop = true;
            this.rb_file.Text = "Файл";
            this.rb_file.UseVisualStyleBackColor = true;
            // 
            // rb_directory
            // 
            this.rb_directory.AutoSize = true;
            this.rb_directory.Location = new System.Drawing.Point(99, 104);
            this.rb_directory.Name = "rb_directory";
            this.rb_directory.Size = new System.Drawing.Size(57, 17);
            this.rb_directory.TabIndex = 7;
            this.rb_directory.TabStop = true;
            this.rb_directory.Text = "Папка";
            this.rb_directory.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 369);
            this.Controls.Add(this.rb_directory);
            this.Controls.Add(this.rb_file);
            this.Controls.Add(this.b_copyStop);
            this.Controls.Add(this.b_copySleep);
            this.Controls.Add(this.b_startCopy);
            this.Controls.Add(this.pgBar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numUpDown_threads);
            this.Controls.Add(this.b_savePath);
            this.Controls.Add(this.b_openFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_savePath);
            this.Controls.Add(this.tb_pathFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "CopyMaster";
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_threads)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_pathFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button b_openFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox tb_savePath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button b_savePath;
        private System.Windows.Forms.NumericUpDown numUpDown_threads;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar pgBar;
        private System.Windows.Forms.Button b_startCopy;
        private System.Windows.Forms.Button b_copySleep;
        private System.Windows.Forms.Button b_copyStop;
        private System.Windows.Forms.RadioButton rb_file;
        private System.Windows.Forms.RadioButton rb_directory;
    }
}

