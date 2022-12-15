namespace LTWindows
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.chương1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Bai1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Bai2 = new System.Windows.Forms.ToolStripMenuItem();
            this.Bai3 = new System.Windows.Forms.ToolStripMenuItem();
            this.Bai4 = new System.Windows.Forms.ToolStripMenuItem();
            this.Info = new System.Windows.Forms.ToolStripMenuItem();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chương1ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(465, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // chương1ToolStripMenuItem
            // 
            this.chương1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Bai1,
            this.Bai2,
            this.Bai3,
            this.Bai4,
            this.Info});
            this.chương1ToolStripMenuItem.Name = "chương1ToolStripMenuItem";
            this.chương1ToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.chương1ToolStripMenuItem.Text = "Chương 1";
            // 
            // Bai1
            // 
            this.Bai1.Name = "Bai1";
            this.Bai1.Size = new System.Drawing.Size(257, 26);
            this.Bai1.Text = "1. Giải PT bậc 1";
            this.Bai1.Click += new System.EventHandler(this.ClickEvent);
            // 
            // Bai2
            // 
            this.Bai2.Name = "Bai2";
            this.Bai2.Size = new System.Drawing.Size(257, 26);
            this.Bai2.Text = "2. Giải PT bậc 2";
            this.Bai2.Click += new System.EventHandler(this.ClickEvent);
            // 
            // Bai3
            // 
            this.Bai3.Name = "Bai3";
            this.Bai3.Size = new System.Drawing.Size(257, 26);
            this.Bai3.Text = "3. Tính chu vi và diện tích";
            this.Bai3.Click += new System.EventHandler(this.ClickEvent);
            // 
            // Bai4
            // 
            this.Bai4.Name = "Bai4";
            this.Bai4.Size = new System.Drawing.Size(257, 26);
            this.Bai4.Text = "4. In ra bảng cửu chương";
            this.Bai4.Click += new System.EventHandler(this.ClickEvent);
            // 
            // Info
            // 
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(257, 26);
            this.Info.Text = "5. Thông tin tác giả";
            this.Info.Click += new System.EventHandler(this.Info_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(312, 61);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(94, 29);
            this.btnReturn.TabIndex = 1;
            this.btnReturn.Text = "Quay về";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(312, 148);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 29);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(465, 239);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Lab 5 - Nguyễn Văn Hoàng - 12101005";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem chương1ToolStripMenuItem;
        private ToolStripMenuItem Bai1;
        private ToolStripMenuItem Bai2;
        private ToolStripMenuItem Bai3;
        private ToolStripMenuItem Bai4;
        private ToolStripMenuItem Info;
        private Button btnReturn;
        private Button btnExit;
    }
}