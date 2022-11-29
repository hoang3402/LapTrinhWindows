namespace LTWindows
{
	partial class Bai3
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
			this.lblA = new System.Windows.Forms.Label();
			this.lblB = new System.Windows.Forms.Label();
			this.txtbA = new System.Windows.Forms.TextBox();
			this.txtbB = new System.Windows.Forms.TextBox();
			this.btnGiai = new System.Windows.Forms.Button();
			this.btnReset = new System.Windows.Forms.Button();
			this.lblUCLN = new System.Windows.Forms.Label();
			this.lblBCNN = new System.Windows.Forms.Label();
			this.btnReturn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblA
			// 
			this.lblA.AutoSize = true;
			this.lblA.Location = new System.Drawing.Point(176, 71);
			this.lblA.Name = "lblA";
			this.lblA.Size = new System.Drawing.Size(33, 20);
			this.lblA.TabIndex = 0;
			this.lblA.Text = "A =";
			// 
			// lblB
			// 
			this.lblB.AutoSize = true;
			this.lblB.Location = new System.Drawing.Point(176, 120);
			this.lblB.Name = "lblB";
			this.lblB.Size = new System.Drawing.Size(32, 20);
			this.lblB.TabIndex = 1;
			this.lblB.Text = "B =";
			// 
			// txtbA
			// 
			this.txtbA.Location = new System.Drawing.Point(215, 68);
			this.txtbA.Name = "txtbA";
			this.txtbA.Size = new System.Drawing.Size(163, 27);
			this.txtbA.TabIndex = 2;
			this.txtbA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Bai3_KeyPress);
			// 
			// txtbB
			// 
			this.txtbB.Location = new System.Drawing.Point(215, 117);
			this.txtbB.Name = "txtbB";
			this.txtbB.Size = new System.Drawing.Size(163, 27);
			this.txtbB.TabIndex = 3;
			this.txtbB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Bai3_KeyPress);
			// 
			// btnGiai
			// 
			this.btnGiai.Location = new System.Drawing.Point(176, 284);
			this.btnGiai.Name = "btnGiai";
			this.btnGiai.Size = new System.Drawing.Size(94, 29);
			this.btnGiai.TabIndex = 4;
			this.btnGiai.Text = "Giải";
			this.btnGiai.UseVisualStyleBackColor = true;
			this.btnGiai.Click += new System.EventHandler(this.btnGiai_Click);
			// 
			// btnReset
			// 
			this.btnReset.Location = new System.Drawing.Point(284, 284);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(94, 29);
			this.btnReset.TabIndex = 5;
			this.btnReset.Text = "Reset";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
			// 
			// lblUCLN
			// 
			this.lblUCLN.AutoSize = true;
			this.lblUCLN.Location = new System.Drawing.Point(176, 180);
			this.lblUCLN.Name = "lblUCLN";
			this.lblUCLN.Size = new System.Drawing.Size(0, 20);
			this.lblUCLN.TabIndex = 6;
			// 
			// lblBCNN
			// 
			this.lblBCNN.AutoSize = true;
			this.lblBCNN.Location = new System.Drawing.Point(176, 215);
			this.lblBCNN.Name = "lblBCNN";
			this.lblBCNN.Size = new System.Drawing.Size(0, 20);
			this.lblBCNN.TabIndex = 7;
			// 
			// btnReturn
			// 
			this.btnReturn.Location = new System.Drawing.Point(228, 332);
			this.btnReturn.Name = "btnReturn";
			this.btnReturn.Size = new System.Drawing.Size(94, 29);
			this.btnReturn.TabIndex = 8;
			this.btnReturn.Text = "Quay lại";
			this.btnReturn.UseVisualStyleBackColor = true;
			this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
			// 
			// Bai3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(600, 450);
			this.Controls.Add(this.btnReturn);
			this.Controls.Add(this.lblBCNN);
			this.Controls.Add(this.lblUCLN);
			this.Controls.Add(this.btnReset);
			this.Controls.Add(this.btnGiai);
			this.Controls.Add(this.txtbB);
			this.Controls.Add(this.txtbA);
			this.Controls.Add(this.lblB);
			this.Controls.Add(this.lblA);
			this.Name = "Bai3";
			this.Text = "Bài 3 Tìm ước chung lớn nhất và bội chung nhỏ nhất của hai số ";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Bai3_FormClosing);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Bai3_KeyPress);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Label lblA;
		private Label lblB;
		private TextBox txtbA;
		private TextBox txtbB;
		private Button btnGiai;
		private Button btnReset;
		private Label lblUCLN;
		private Label lblBCNN;
		private Button btnReturn;
	}
}