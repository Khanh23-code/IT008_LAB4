namespace Bai6
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
            this.grbFolders = new System.Windows.Forms.GroupBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnDes = new System.Windows.Forms.Button();
            this.btnSource = new System.Windows.Forms.Button();
            this.txtDes = new System.Windows.Forms.TextBox();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.lblDes = new System.Windows.Forms.Label();
            this.lblSource = new System.Windows.Forms.Label();
            this.gtbProgress = new System.Windows.Forms.GroupBox();
            this.pgbMain = new System.Windows.Forms.ProgressBar();
            this.grbInfo = new System.Windows.Forms.GroupBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.ttProgress = new System.Windows.Forms.ToolTip(this.components);
            this.grbFolders.SuspendLayout();
            this.gtbProgress.SuspendLayout();
            this.grbInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbFolders
            // 
            this.grbFolders.Controls.Add(this.btnCopy);
            this.grbFolders.Controls.Add(this.btnDes);
            this.grbFolders.Controls.Add(this.btnSource);
            this.grbFolders.Controls.Add(this.txtDes);
            this.grbFolders.Controls.Add(this.txtSource);
            this.grbFolders.Controls.Add(this.lblDes);
            this.grbFolders.Controls.Add(this.lblSource);
            this.grbFolders.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbFolders.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.grbFolders.Location = new System.Drawing.Point(24, 24);
            this.grbFolders.Name = "grbFolders";
            this.grbFolders.Size = new System.Drawing.Size(571, 179);
            this.grbFolders.TabIndex = 0;
            this.grbFolders.TabStop = false;
            this.grbFolders.Text = "Sao chép tập tin";
            // 
            // btnCopy
            // 
            this.btnCopy.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnCopy.Location = new System.Drawing.Point(217, 131);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(188, 31);
            this.btnCopy.TabIndex = 3;
            this.btnCopy.Text = "Sao Chép";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnDes
            // 
            this.btnDes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDes.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnDes.Location = new System.Drawing.Point(509, 92);
            this.btnDes.Name = "btnDes";
            this.btnDes.Size = new System.Drawing.Size(45, 23);
            this.btnDes.TabIndex = 2;
            this.btnDes.Text = "...";
            this.btnDes.UseVisualStyleBackColor = true;
            this.btnDes.Click += new System.EventHandler(this.btnDes_Click);
            // 
            // btnSource
            // 
            this.btnSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSource.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnSource.Location = new System.Drawing.Point(509, 41);
            this.btnSource.Name = "btnSource";
            this.btnSource.Size = new System.Drawing.Size(45, 23);
            this.btnSource.TabIndex = 1;
            this.btnSource.Text = "...";
            this.btnSource.UseVisualStyleBackColor = true;
            this.btnSource.Click += new System.EventHandler(this.btnSource_Click);
            // 
            // txtDes
            // 
            this.txtDes.Location = new System.Drawing.Point(217, 93);
            this.txtDes.Name = "txtDes";
            this.txtDes.ReadOnly = true;
            this.txtDes.Size = new System.Drawing.Size(268, 22);
            this.txtDes.TabIndex = 0;
            this.txtDes.TextChanged += new System.EventHandler(this.txtDes_TextChanged);
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(217, 42);
            this.txtSource.Name = "txtSource";
            this.txtSource.ReadOnly = true;
            this.txtSource.Size = new System.Drawing.Size(268, 22);
            this.txtSource.TabIndex = 0;
            // 
            // lblDes
            // 
            this.lblDes.AutoSize = true;
            this.lblDes.ForeColor = System.Drawing.Color.Black;
            this.lblDes.Location = new System.Drawing.Point(41, 95);
            this.lblDes.Name = "lblDes";
            this.lblDes.Size = new System.Drawing.Size(157, 16);
            this.lblDes.TabIndex = 0;
            this.lblDes.Text = "Đường Dẫn Thư Mục Đích";
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.ForeColor = System.Drawing.Color.Black;
            this.lblSource.Location = new System.Drawing.Point(27, 44);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(171, 16);
            this.lblSource.TabIndex = 0;
            this.lblSource.Text = "Đường Dẫn Thư Mục Nguồn";
            // 
            // gtbProgress
            // 
            this.gtbProgress.Controls.Add(this.pgbMain);
            this.gtbProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gtbProgress.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.gtbProgress.Location = new System.Drawing.Point(24, 226);
            this.gtbProgress.Name = "gtbProgress";
            this.gtbProgress.Size = new System.Drawing.Size(571, 66);
            this.gtbProgress.TabIndex = 1;
            this.gtbProgress.TabStop = false;
            this.gtbProgress.Text = "Tiến trình sao chép";
            // 
            // pgbMain
            // 
            this.pgbMain.Location = new System.Drawing.Point(30, 27);
            this.pgbMain.Name = "pgbMain";
            this.pgbMain.Size = new System.Drawing.Size(524, 23);
            this.pgbMain.TabIndex = 0;
            // 
            // grbInfo
            // 
            this.grbInfo.Controls.Add(this.lblInfo);
            this.grbInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grbInfo.Location = new System.Drawing.Point(0, 309);
            this.grbInfo.Name = "grbInfo";
            this.grbInfo.Size = new System.Drawing.Size(631, 32);
            this.grbInfo.TabIndex = 2;
            this.grbInfo.TabStop = false;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(6, 11);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(86, 13);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Đang Sao Chép:";
            this.ttProgress.SetToolTip(this.lblInfo, "Đang Sao Chép:");
            this.lblInfo.TextChanged += new System.EventHandler(this.lblInfo_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 341);
            this.Controls.Add(this.grbInfo);
            this.Controls.Add(this.gtbProgress);
            this.Controls.Add(this.grbFolders);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sao chép tập tin";
            this.grbFolders.ResumeLayout(false);
            this.grbFolders.PerformLayout();
            this.gtbProgress.ResumeLayout(false);
            this.grbInfo.ResumeLayout(false);
            this.grbInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbFolders;
        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.Label lblDes;
        private System.Windows.Forms.Button btnDes;
        private System.Windows.Forms.Button btnSource;
        private System.Windows.Forms.TextBox txtDes;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.GroupBox gtbProgress;
        private System.Windows.Forms.GroupBox grbInfo;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.ProgressBar pgbMain;
        private System.Windows.Forms.ToolTip ttProgress;
    }
}

