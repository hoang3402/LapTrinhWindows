namespace LTWindows
{
	partial class Bai2
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtbA = new System.Windows.Forms.TextBox();
			this.txtbB = new System.Windows.Forms.TextBox();
			this.txtbC = new System.Windows.Forms.TextBox();
			this.lblResultX = new System.Windows.Forms.Label();
			this.lblResultY = new System.Windows.Forms.Label();
			this.btnGiai = new System.Windows.Forms.Button();
			this.btnReset = new System.Windows.Forms.Button();
			this.btnReturnPrev = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(124, 52);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(34, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "x  +";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label2.Location = new System.Drawing.Point(134, 43);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(15, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "2";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(199, 51);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(30, 20);
			this.label3.TabIndex = 2;
			this.label3.Text = "x +";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(273, 52);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(31, 20);
			this.label4.TabIndex = 3;
			this.label4.Text = "= 0";
			// 
			// txtbA
			// 
			this.txtbA.AcceptsTab = true;
			this.txtbA.Location = new System.Drawing.Point(85, 48);
			this.txtbA.Name = "txtbA";
			this.txtbA.PlaceholderText = "A";
			this.txtbA.Size = new System.Drawing.Size(37, 27);
			this.txtbA.TabIndex = 4;
			this.txtbA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtb_KeyPress);
			// 
			// txtbB
			// 
			this.txtbB.AcceptsTab = true;
			this.txtbB.Location = new System.Drawing.Point(160, 48);
			this.txtbB.Name = "txtbB";
			this.txtbB.PlaceholderText = "B";
			this.txtbB.Size = new System.Drawing.Size(37, 27);
			this.txtbB.TabIndex = 5;
			this.txtbB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtb_KeyPress);
			// 
			// txtbC
			// 
			this.txtbC.AcceptsTab = true;
			this.txtbC.Location = new System.Drawing.Point(230, 48);
			this.txtbC.Name = "txtbC";
			this.txtbC.PlaceholderText = "C";
			this.txtbC.Size = new System.Drawing.Size(45, 27);
			this.txtbC.TabIndex = 6;
			this.txtbC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtb_KeyPress);
			// 
			// lblResultX
			// 
			this.lblResultX.AutoSize = true;
			this.lblResultX.Location = new System.Drawing.Point(99, 106);
			this.lblResultX.Name = "lblResultX";
			this.lblResultX.Size = new System.Drawing.Size(0, 20);
			this.lblResultX.TabIndex = 7;
			// 
			// lblResultY
			// 
			this.lblResultY.AutoSize = true;
			this.lblResultY.Location = new System.Drawing.Point(99, 146);
			this.lblResultY.Name = "lblResultY";
			this.lblResultY.Size = new System.Drawing.Size(0, 20);
			this.lblResultY.TabIndex = 8;
			// 
			// btnGiai
			// 
			this.btnGiai.Location = new System.Drawing.Point(81, 223);
			this.btnGiai.Name = "btnGiai";
			this.btnGiai.Size = new System.Drawing.Size(94, 29);
			this.btnGiai.TabIndex = 9;
			this.btnGiai.Text = "Giải";
			this.btnGiai.UseVisualStyleBackColor = true;
			this.btnGiai.Click += new System.EventHandler(this.btnGiai_Click);
			// 
			// btnReset
			// 
			this.btnReset.Location = new System.Drawing.Point(199, 223);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(94, 29);
			this.btnReset.TabIndex = 10;
			this.btnReset.Text = "Reset";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
			// 
			// btnReturnPrev
			// 
			this.btnReturnPrev.Location = new System.Drawing.Point(135, 258);
			this.btnReturnPrev.Name = "btnReturnPrev";
			this.btnReturnPrev.Size = new System.Drawing.Size(94, 29);
			this.btnReturnPrev.TabIndex = 11;
			this.btnReturnPrev.Text = "Quay lại";
			this.btnReturnPrev.UseVisualStyleBackColor = true;
			this.btnReturnPrev.Click += new System.EventHandler(this.btnReturnPrev_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 9);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(271, 20);
			this.label5.TabIndex = 12;
			this.label5.Text = "Để trống chương trình sẽ tự hiểu là số 0";
			// 
			// Bai2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(386, 349);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.btnReturnPrev);
			this.Controls.Add(this.btnReset);
			this.Controls.Add(this.btnGiai);
			this.Controls.Add(this.lblResultY);
			this.Controls.Add(this.lblResultX);
			this.Controls.Add(this.txtbC);
			this.Controls.Add(this.txtbB);
			this.Controls.Add(this.txtbA);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Bai2";
			this.Text = "Bài 2 Giải phương trình bậc 2 (ax2+ bx + c = 0)";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Bai2_FormClosing);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private TextBox txtbA;
		private TextBox txtbB;
		private TextBox txtbC;
		private Label lblResultX;
		private Label lblResultY;
		private Button btnGiai;
		private Button btnReset;
		private Button btnReturnPrev;
		private Label label5;
	}
}