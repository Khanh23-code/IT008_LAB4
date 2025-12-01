using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            lblTime.Text = "Hôm nay là ngày " + DateTime.Now.ToString("dd/MM/yyyy") + " - Bây giờ là " + DateTime.Now.ToString("hh:mm:ss tt");

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = "Hôm nay là ngày " + DateTime.Now.ToString("dd/MM/yyyy") + " - Bây giờ là " + DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void mnuiFileExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuiFileOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            //ofd.Filter = "Media Files|*.mp3;*.mp4;*.wav;*.avi;*.mpeg;*.midi|All Files|*.*";
            ofd.Filter = "" +
                "AVI Files|*.avi|" +
                "MPEG Files|*.mpeg|" +
                "WAV Files|*.wav|" +
                "MIDI Files|*.midi|" +
                "MP4 Files|*.mp4|" +
                "MP3 Files|*.mp3|" +
                "All Files|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                wmpMain.URL = ofd.FileName;
                //wmpMain.Ctlcontrols.play();
            }
        }
    }
}
