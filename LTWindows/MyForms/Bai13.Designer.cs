namespace LTWindows.MyForms
{
	partial class Bai13
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
            this.tabControlViewMatrix = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnTotal = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbDong = new System.Windows.Forms.TextBox();
            this.checkBoxMatrixSquare = new System.Windows.Forms.CheckBox();
            this.txtbCot = new System.Windows.Forms.TextBox();
            this.btnCreateMatrix = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabControlViewMatrix.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlViewMatrix
            // 
            this.tabControlViewMatrix.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlViewMatrix.Controls.Add(this.tabPage1);
            this.tabControlViewMatrix.Controls.Add(this.tabPage2);
            this.tabControlViewMatrix.Location = new System.Drawing.Point(1, 12);
            this.tabControlViewMatrix.Name = "tabControlViewMatrix";
            this.tabControlViewMatrix.SelectedIndex = 0;
            this.tabControlViewMatrix.Size = new System.Drawing.Size(780, 459);
            this.tabControlViewMatrix.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnTotal);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtbDong);
            this.tabPage1.Controls.Add(this.checkBoxMatrixSquare);
            this.tabPage1.Controls.Add(this.txtbCot);
            this.tabPage1.Controls.Add(this.btnCreateMatrix);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(772, 426);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nhập ma trận";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnTotal
            // 
            this.btnTotal.Location = new System.Drawing.Point(126, 168);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(138, 29);
            this.btnTotal.TabIndex = 6;
            this.btnTotal.Text = "Tổng đường chéo";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Số dòng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Số cột";
            // 
            // txtbDong
            // 
            this.txtbDong.Location = new System.Drawing.Point(126, 78);
            this.txtbDong.Name = "txtbDong";
            this.txtbDong.Size = new System.Drawing.Size(138, 27);
            this.txtbDong.TabIndex = 3;
            // 
            // checkBoxMatrixSquare
            // 
            this.checkBoxMatrixSquare.AutoSize = true;
            this.checkBoxMatrixSquare.Location = new System.Drawing.Point(467, 45);
            this.checkBoxMatrixSquare.Name = "checkBoxMatrixSquare";
            this.checkBoxMatrixSquare.Size = new System.Drawing.Size(127, 24);
            this.checkBoxMatrixSquare.TabIndex = 2;
            this.checkBoxMatrixSquare.Text = "Ma trận vuông";
            this.checkBoxMatrixSquare.UseVisualStyleBackColor = true;
            this.checkBoxMatrixSquare.CheckedChanged += new System.EventHandler(this.checkBoxMatrixSquare_CheckedChanged);
            // 
            // txtbCot
            // 
            this.txtbCot.Location = new System.Drawing.Point(126, 45);
            this.txtbCot.Name = "txtbCot";
            this.txtbCot.Size = new System.Drawing.Size(138, 27);
            this.txtbCot.TabIndex = 1;
            // 
            // btnCreateMatrix
            // 
            this.btnCreateMatrix.Location = new System.Drawing.Point(126, 133);
            this.btnCreateMatrix.Name = "btnCreateMatrix";
            this.btnCreateMatrix.Size = new System.Drawing.Size(138, 29);
            this.btnCreateMatrix.TabIndex = 0;
            this.btnCreateMatrix.Text = "Tạo ma trận";
            this.btnCreateMatrix.UseVisualStyleBackColor = true;
            this.btnCreateMatrix.Click += new System.EventHandler(this.btnCreateMatrix_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(772, 426);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ma trận";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Bai13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 476);
            this.Controls.Add(this.tabControlViewMatrix);
            this.Name = "Bai13";
            this.Text = "Bài 13, 14 Ma trận";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Bai13_FormClosing);
            this.tabControlViewMatrix.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private TabControl tabControlViewMatrix;
		private TabPage tabPage1;
		private CheckBox checkBoxMatrixSquare;
		private TextBox txtbCot;
		private Button btnCreateMatrix;
		private TabPage tabPage2;
		private Label label2;
		private Label label1;
		private TextBox txtbDong;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private Button btnTotal;
	}
}