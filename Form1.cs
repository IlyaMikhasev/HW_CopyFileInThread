using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HW_CopyFileInThread
{
    public partial class Form1 : Form
    {
        CopyFileInThread copyFile;

        object _lock = new object();
        public Form1()
        {
            InitializeComponent();
            
        }
        
        private string FormatFile(string path) {
            return path.Substring(path.LastIndexOf('.'));
        }

        private void b_openFile_Click(object sender, EventArgs e)
        {
            if (rb_file.Checked)
            {
                if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                    return;
                // получаем путь к фалу
                tb_pathFile.Text = openFileDialog1.FileName;
            }
            if (rb_directory.Checked)
            {
                using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
                {
                    if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                    {
                        tb_pathFile.Text = folderBrowserDialog.SelectedPath;
                    }
                }
            }
        }

        private void b_savePath_Click(object sender, EventArgs e)
        {
            if (rb_file.Checked)
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем путь для копирования
            tb_savePath.Text = saveFileDialog1.FileName + FormatFile(tb_pathFile.Text);
            }
            if (rb_directory.Checked)
            {
                using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
                {
                    if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                    {
                        tb_savePath.Text = folderBrowserDialog.SelectedPath;
                    }
                }
            }
        }

        private void b_startCopy_Click(object sender, EventArgs e)
        {
            copyFile.path_copy += upProgressBar;
            if (rb_file.Checked) { 
                copyFile = new CopyFileInThread(tb_pathFile.Text, tb_savePath.Text, Convert.ToInt32(numUpDown_threads.Value));
               
                copyFile.CopyFile();
            }
            if (rb_directory.Checked) {
                copyFile = new CopyFileInThread(tb_pathFile.Text, tb_savePath.Text, Convert.ToInt32(numUpDown_threads.Value));
                
                copyFile.CopyDir();
            }
        }
        private void upProgressBar(int step) {
            lock (_lock) {
                Invoke((MethodInvoker)(() => { pgBar.Value += step; }));
            }
        }
        private void b_copySleep_Click(object sender, EventArgs e)
        {

        }

        private void b_copyStop_Click(object sender, EventArgs e)
        {

        }
    }
}
