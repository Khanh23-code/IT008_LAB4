namespace Bai5
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuiOption = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuiOptionNew = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuiOptionExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsBtnNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsLblSearch = new System.Windows.Forms.ToolStripLabel();
            this.tsTxtSearch = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.clmNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMajor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmGPA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuiOption});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(618, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuiOption
            // 
            this.mnuiOption.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuiOptionNew,
            this.toolStripSeparator1,
            this.mnuiOptionExit});
            this.mnuiOption.Name = "mnuiOption";
            this.mnuiOption.Size = new System.Drawing.Size(79, 20);
            this.mnuiOption.Text = "Chức Năng";
            // 
            // mnuiOptionNew
            // 
            this.mnuiOptionNew.Image = ((System.Drawing.Image)(resources.GetObject("mnuiOptionNew.Image")));
            this.mnuiOptionNew.Name = "mnuiOptionNew";
            this.mnuiOptionNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mnuiOptionNew.Size = new System.Drawing.Size(180, 22);
            this.mnuiOptionNew.Text = "Thêm Mới";
            this.mnuiOptionNew.Click += new System.EventHandler(this.mnuiOptionNew_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // mnuiOptionExit
            // 
            this.mnuiOptionExit.Image = ((System.Drawing.Image)(resources.GetObject("mnuiOptionExit.Image")));
            this.mnuiOptionExit.Name = "mnuiOptionExit";
            this.mnuiOptionExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.mnuiOptionExit.Size = new System.Drawing.Size(180, 22);
            this.mnuiOptionExit.Text = "Thoát";
            this.mnuiOptionExit.Click += new System.EventHandler(this.mnuiOptionExit_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnNew,
            this.toolStripSeparator2,
            this.tsLblSearch,
            this.tsTxtSearch,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(618, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsBtnNew
            // 
            this.tsBtnNew.AutoSize = false;
            this.tsBtnNew.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnNew.Image")));
            this.tsBtnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnNew.Name = "tsBtnNew";
            this.tsBtnNew.Size = new System.Drawing.Size(150, 22);
            this.tsBtnNew.Text = "Thêm Mới";
            this.tsBtnNew.Click += new System.EventHandler(this.tsBtnNew_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsLblSearch
            // 
            this.tsLblSearch.Name = "tsLblSearch";
            this.tsLblSearch.Size = new System.Drawing.Size(110, 22);
            this.tsLblSearch.Text = "Tìm Kiếm Theo Tên";
            // 
            // tsTxtSearch
            // 
            this.tsTxtSearch.AutoSize = false;
            this.tsTxtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tsTxtSearch.Name = "tsTxtSearch";
            this.tsTxtSearch.Size = new System.Drawing.Size(200, 25);
            this.tsTxtSearch.TextChanged += new System.EventHandler(this.tsTxtSearch_TextChanged);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(0, 22);
            // 
            // dgvMain
            // 
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmNumber,
            this.clmStudentID,
            this.clmName,
            this.clmMajor,
            this.clmGPA});
            this.dgvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMain.Location = new System.Drawing.Point(0, 49);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.ReadOnly = true;
            this.dgvMain.Size = new System.Drawing.Size(618, 273);
            this.dgvMain.TabIndex = 2;
            // 
            // clmNumber
            // 
            this.clmNumber.HeaderText = "Số TT";
            this.clmNumber.Name = "clmNumber";
            this.clmNumber.ReadOnly = true;
            this.clmNumber.Width = 75;
            // 
            // clmStudentID
            // 
            this.clmStudentID.HeaderText = "Mã Số SV";
            this.clmStudentID.Name = "clmStudentID";
            this.clmStudentID.ReadOnly = true;
            // 
            // clmName
            // 
            this.clmName.HeaderText = "Tên Sinh Viên";
            this.clmName.Name = "clmName";
            this.clmName.ReadOnly = true;
            this.clmName.Width = 150;
            // 
            // clmMajor
            // 
            this.clmMajor.HeaderText = "Khoa";
            this.clmMajor.Name = "clmMajor";
            this.clmMajor.ReadOnly = true;
            this.clmMajor.Width = 150;
            // 
            // clmGPA
            // 
            this.clmGPA.HeaderText = "Điểm TB";
            this.clmGPA.Name = "clmGPA";
            this.clmGPA.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 322);
            this.Controls.Add(this.dgvMain);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Sinh Viên";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuiOption;
        private System.Windows.Forms.ToolStripMenuItem mnuiOptionNew;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuiOptionExit;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsBtnNew;
        private System.Windows.Forms.ToolStripTextBox tsTxtSearch;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel tsLblSearch;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMajor;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmGPA;
    }
}

