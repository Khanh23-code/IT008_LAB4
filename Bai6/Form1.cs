using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using System.Windows.Forms;
using System.IO;

namespace Bai6
{
    public partial class Form1 : Form
    {
        private string sourcePath;
        private string destinationPath;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSource_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == DialogResult.OK )
            {
                sourcePath = fbd.SelectedPath;
                txtSource.Text = sourcePath;
            }
        }

        private void btnDes_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                destinationPath = fbd.SelectedPath;
                txtDes.Text = destinationPath;
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(sourcePath) || !Directory.Exists(destinationPath)) 
            {
                MessageBox.Show("Đường dẫn không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string[] files = Directory.GetFiles(sourcePath);

            pgbMain.Value = 0;
            pgbMain.Maximum = files.Length;

            foreach (string file in files)
            {
                lblInfo.Text = "Đang sao chép: " + file;
                lblInfo.Update();

                string fileName = Path.GetFileName(file);
                string desFile = Path.Combine(destinationPath, fileName);
                File.Copy(file, desFile, true);

                ttProgress.SetToolTip(pgbMain, lblInfo.Text);
                ttProgress.SetToolTip(btnCopy, "Sao chép tệp tin từ: " + sourcePath + " đến " + destinationPath);

                pgbMain.Value++;
                pgbMain.Update();
            }

            MessageBox.Show("Sao chép thành công!");
        }

        private void txtDes_TextChanged(object sender, EventArgs e)
        {
            if (txtSource.Text != "" && txtDes.Text != "")
                ttProgress.SetToolTip(btnCopy, "Sao chép tệp tin từ: " + sourcePath + " đến " + destinationPath);
        }

        private void lblInfo_TextChanged(object sender, EventArgs e)
        {
            ttProgress.SetToolTip(lblInfo, lblInfo.Text);
        }
    }
}
