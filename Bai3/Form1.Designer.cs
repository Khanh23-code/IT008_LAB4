namespace Bai3
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.grbTime = new System.Windows.Forms.GroupBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuiFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuiFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.wmpMain = new AxWMPLib.AxWindowsMediaPlayer();
            this.grbTime.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wmpMain)).BeginInit();
            this.SuspendLayout();
            // 
            // grbTime
            // 
            this.grbTime.Controls.Add(this.lblTime);
            this.grbTime.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grbTime.Location = new System.Drawing.Point(0, 357);
            this.grbTime.Name = "grbTime";
            this.grbTime.Size = new System.Drawing.Size(553, 24);
            this.grbTime.TabIndex = 2;
            this.grbTime.TabStop = false;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(0, 11);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(0, 13);
            this.lblTime.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuiFile});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(553, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuiFile
            // 
            this.mnuiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuiFileOpen,
            this.mnuiFileExit});
            this.mnuiFile.Name = "mnuiFile";
            this.mnuiFile.Size = new System.Drawing.Size(37, 20);
            this.mnuiFile.Text = "File";
            // 
            // mnuiFileOpen
            // 
            this.mnuiFileOpen.Name = "mnuiFileOpen";
            this.mnuiFileOpen.Size = new System.Drawing.Size(103, 22);
            this.mnuiFileOpen.Text = "Open";
            this.mnuiFileOpen.Click += new System.EventHandler(this.mnuiFileOpen_Click);
            // 
            // mnuiFileExit
            // 
            this.mnuiFileExit.Name = "mnuiFileExit";
            this.mnuiFileExit.Size = new System.Drawing.Size(103, 22);
            this.mnuiFileExit.Text = "Exit";
            this.mnuiFileExit.Click += new System.EventHandler(this.mnuiFileExit_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // wmpMain
            // 
            this.wmpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wmpMain.Enabled = true;
            this.wmpMain.Location = new System.Drawing.Point(0, 24);
            this.wmpMain.Name = "wmpMain";
            this.wmpMain.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpMain.OcxState")));
            this.wmpMain.Size = new System.Drawing.Size(553, 333);
            this.wmpMain.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 381);
            this.Controls.Add(this.wmpMain);
            this.Controls.Add(this.grbTime);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chương trình Windows Media";
            this.grbTime.ResumeLayout(false);
            this.grbTime.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wmpMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grbTime;
        private AxWMPLib.AxWindowsMediaPlayer wmpMain;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuiFile;
        private System.Windows.Forms.ToolStripMenuItem mnuiFileOpen;
        private System.Windows.Forms.ToolStripMenuItem mnuiFileExit;
        private System.Windows.Forms.Timer timer1;
    }
}

