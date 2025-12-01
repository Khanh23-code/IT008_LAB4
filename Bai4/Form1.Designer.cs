namespace Bai4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsBtnNew = new System.Windows.Forms.ToolStripButton();
            this.tsBtnOpen = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsCbbFont = new System.Windows.Forms.ToolStripComboBox();
            this.tsCbbSize = new System.Windows.Forms.ToolStripComboBox();
            this.tsBtnBold = new System.Windows.Forms.ToolStripButton();
            this.tsBtnItalic = new System.Windows.Forms.ToolStripButton();
            this.tsBtnUnderline = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuiSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuiSystemNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuiSystemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuiSystemSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuiSystemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuiFormat = new System.Windows.Forms.ToolStripMenuItem();
            this.rtbMain = new System.Windows.Forms.RichTextBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnNew,
            this.tsBtnOpen,
            this.toolStripSeparator2,
            this.tsCbbFont,
            this.tsCbbSize,
            this.tsBtnBold,
            this.tsBtnItalic,
            this.tsBtnUnderline});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(609, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsBtnNew
            // 
            this.tsBtnNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnNew.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnNew.Image")));
            this.tsBtnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnNew.Name = "tsBtnNew";
            this.tsBtnNew.Size = new System.Drawing.Size(23, 22);
            this.tsBtnNew.Text = "Văn bản mới";
            this.tsBtnNew.Click += new System.EventHandler(this.tsBtnNew_Click);
            // 
            // tsBtnOpen
            // 
            this.tsBtnOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnOpen.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnOpen.Image")));
            this.tsBtnOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnOpen.Name = "tsBtnOpen";
            this.tsBtnOpen.Size = new System.Drawing.Size(23, 22);
            this.tsBtnOpen.Text = "Mở tập tin";
            this.tsBtnOpen.Click += new System.EventHandler(this.tsBtnOpen_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsCbbFont
            // 
            this.tsCbbFont.AutoSize = false;
            this.tsCbbFont.Name = "tsCbbFont";
            this.tsCbbFont.Size = new System.Drawing.Size(200, 23);
            this.tsCbbFont.SelectedIndexChanged += new System.EventHandler(this.tsCbbFont_SelectedIndexChanged);
            // 
            // tsCbbSize
            // 
            this.tsCbbSize.Name = "tsCbbSize";
            this.tsCbbSize.Size = new System.Drawing.Size(121, 25);
            this.tsCbbSize.SelectedIndexChanged += new System.EventHandler(this.tsCbbSize_SelectedIndexChanged);
            // 
            // tsBtnBold
            // 
            this.tsBtnBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnBold.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnBold.Image")));
            this.tsBtnBold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnBold.Name = "tsBtnBold";
            this.tsBtnBold.Size = new System.Drawing.Size(23, 22);
            this.tsBtnBold.Text = "Chữ đậm";
            this.tsBtnBold.Click += new System.EventHandler(this.tsBtnBold_Click);
            // 
            // tsBtnItalic
            // 
            this.tsBtnItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnItalic.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnItalic.Image")));
            this.tsBtnItalic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnItalic.Name = "tsBtnItalic";
            this.tsBtnItalic.Size = new System.Drawing.Size(23, 22);
            this.tsBtnItalic.Text = "Chữ nghiêng";
            this.tsBtnItalic.Click += new System.EventHandler(this.tsBtnItalic_Click);
            // 
            // tsBtnUnderline
            // 
            this.tsBtnUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnUnderline.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnUnderline.Image")));
            this.tsBtnUnderline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnUnderline.Name = "tsBtnUnderline";
            this.tsBtnUnderline.Size = new System.Drawing.Size(23, 22);
            this.tsBtnUnderline.Text = "Gạch chân";
            this.tsBtnUnderline.Click += new System.EventHandler(this.tsBtnUnderline_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuiSystem,
            this.mnuiFormat});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(609, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuiSystem
            // 
            this.mnuiSystem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuiSystemNew,
            this.mnuiSystemOpen,
            this.toolStripSeparator1,
            this.mnuiSystemSave,
            this.mnuiSystemExit});
            this.mnuiSystem.Name = "mnuiSystem";
            this.mnuiSystem.Size = new System.Drawing.Size(69, 20);
            this.mnuiSystem.Text = "Hệ thống";
            // 
            // mnuiSystemNew
            // 
            this.mnuiSystemNew.Image = ((System.Drawing.Image)(resources.GetObject("mnuiSystemNew.Image")));
            this.mnuiSystemNew.Name = "mnuiSystemNew";
            this.mnuiSystemNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mnuiSystemNew.Size = new System.Drawing.Size(230, 22);
            this.mnuiSystemNew.Text = "Tạo văn bản mới";
            this.mnuiSystemNew.Click += new System.EventHandler(this.mnuiSystemNew_Click);
            // 
            // mnuiSystemOpen
            // 
            this.mnuiSystemOpen.Image = ((System.Drawing.Image)(resources.GetObject("mnuiSystemOpen.Image")));
            this.mnuiSystemOpen.Name = "mnuiSystemOpen";
            this.mnuiSystemOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mnuiSystemOpen.Size = new System.Drawing.Size(230, 22);
            this.mnuiSystemOpen.Text = "Mở tập tin";
            this.mnuiSystemOpen.Click += new System.EventHandler(this.mnuiSystemOpen_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(227, 6);
            // 
            // mnuiSystemSave
            // 
            this.mnuiSystemSave.Image = ((System.Drawing.Image)(resources.GetObject("mnuiSystemSave.Image")));
            this.mnuiSystemSave.Name = "mnuiSystemSave";
            this.mnuiSystemSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mnuiSystemSave.Size = new System.Drawing.Size(230, 22);
            this.mnuiSystemSave.Text = "Lưu nội dung văn bản";
            this.mnuiSystemSave.Click += new System.EventHandler(this.mnuiSystemSave_Click);
            // 
            // mnuiSystemExit
            // 
            this.mnuiSystemExit.Name = "mnuiSystemExit";
            this.mnuiSystemExit.Size = new System.Drawing.Size(230, 22);
            this.mnuiSystemExit.Text = "Thoát";
            this.mnuiSystemExit.Click += new System.EventHandler(this.mnuiSystemExit_Click);
            // 
            // mnuiFormat
            // 
            this.mnuiFormat.Name = "mnuiFormat";
            this.mnuiFormat.Size = new System.Drawing.Size(74, 20);
            this.mnuiFormat.Text = "Định dạng";
            this.mnuiFormat.Click += new System.EventHandler(this.mnuiFormat_Click);
            // 
            // rtbMain
            // 
            this.rtbMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbMain.Location = new System.Drawing.Point(0, 49);
            this.rtbMain.Name = "rtbMain";
            this.rtbMain.Size = new System.Drawing.Size(609, 314);
            this.rtbMain.TabIndex = 2;
            this.rtbMain.Text = resources.GetString("rtbMain.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 363);
            this.Controls.Add(this.rtbMain);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Soạn thảo văn bản";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsBtnNew;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuiSystem;
        private System.Windows.Forms.ToolStripMenuItem mnuiSystemNew;
        private System.Windows.Forms.ToolStripMenuItem mnuiSystemOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuiSystemSave;
        private System.Windows.Forms.ToolStripMenuItem mnuiSystemExit;
        private System.Windows.Forms.ToolStripMenuItem mnuiFormat;
        private System.Windows.Forms.ToolStripButton tsBtnOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripComboBox tsCbbFont;
        private System.Windows.Forms.ToolStripComboBox tsCbbSize;
        private System.Windows.Forms.RichTextBox rtbMain;
        private System.Windows.Forms.ToolStripButton tsBtnBold;
        private System.Windows.Forms.ToolStripButton tsBtnItalic;
        private System.Windows.Forms.ToolStripButton tsBtnUnderline;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}

