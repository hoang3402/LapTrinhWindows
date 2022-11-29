namespace LTWindows
{
	partial class Bai4
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
			this.txtbA = new System.Windows.Forms.TextBox();
			this.txtbB = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnGiai = new System.Windows.Forms.Button();
			this.lbl1 = new System.Windows.Forms.Label();
			this.lbl2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.lblError = new System.Windows.Forms.Label();
			this.lblResultTong = new System.Windows.Forms.Label();
			this.lblResultHieu = new System.Windows.Forms.Label();
			this.lblResultThuong = new System.Windows.Forms.Label();
			this.lblResultTich = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(272, 59);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(33, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "A =";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(273, 102);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(32, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "B =";
			// 
			// txtbA
			// 
			this.txtbA.Location = new System.Drawing.Point(311, 56);
			this.txtbA.Name = "txtbA";
			this.txtbA.Size = new System.Drawing.Size(79, 27);
			this.txtbA.TabIndex = 2;
			this.txtbA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
			// 
			// txtbB
			// 
			this.txtbB.Location = new System.Drawing.Point(311, 99);
			this.txtbB.Name = "txtbB";
			this.txtbB.Size = new System.Drawing.Size(79, 27);
			this.txtbB.TabIndex = 3;
			this.txtbB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label3.Location = new System.Drawing.Point(12, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(650, 20);
			this.label3.TabIndex = 4;
			this.label3.Text = "Hãy nhập A, B theo dạng Tử / Mẫu (Nếu Mấu không nhập phần mềm sẽ tự hiểu là Mẫu =" +
    " 1)";
			// 
			// btnGiai
			// 
			this.btnGiai.Location = new System.Drawing.Point(296, 352);
			this.btnGiai.Name = "btnGiai";
			this.btnGiai.Size = new System.Drawing.Size(94, 29);
			this.btnGiai.TabIndex = 6;
			this.btnGiai.Text = "Giải";
			this.btnGiai.UseVisualStyleBackColor = true;
			this.btnGiai.Click += new System.EventHandler(this.btnGiai_Click);
			// 
			// lbl1
			// 
			this.lbl1.AutoSize = true;
			this.lbl1.Location = new System.Drawing.Point(73, 195);
			this.lbl1.Name = "lbl1";
			this.lbl1.Size = new System.Drawing.Size(43, 20);
			this.lbl1.TabIndex = 5;
			this.lbl1.Text = "Tổng";
			// 
			// lbl2
			// 
			this.lbl2.AutoSize = true;
			this.lbl2.Location = new System.Drawing.Point(73, 228);
			this.lbl2.Name = "lbl2";
			this.lbl2.Size = new System.Drawing.Size(40, 20);
			this.lbl2.TabIndex = 7;
			this.lbl2.Text = "Hiệu";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(73, 261);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(36, 20);
			this.label4.TabIndex = 8;
			this.label4.Text = "Tích";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(73, 294);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(60, 20);
			this.label5.TabIndex = 9;
			this.label5.Text = "Thương";
			// 
			// lblError
			// 
			this.lblError.AutoSize = true;
			this.lblError.Location = new System.Drawing.Point(227, 147);
			this.lblError.Name = "lblError";
			this.lblError.Size = new System.Drawing.Size(0, 20);
			this.lblError.TabIndex = 10;
			// 
			// lblResultTong
			// 
			this.lblResultTong.AutoSize = true;
			this.lblResultTong.Location = new System.Drawing.Point(227, 195);
			this.lblResultTong.Name = "lblResultTong";
			this.lblResultTong.Size = new System.Drawing.Size(0, 20);
			this.lblResultTong.TabIndex = 11;
			// 
			// lblResultHieu
			// 
			this.lblResultHieu.AutoSize = true;
			this.lblResultHieu.Location = new System.Drawing.Point(227, 228);
			this.lblResultHieu.Name = "lblResultHieu";
			this.lblResultHieu.Size = new System.Drawing.Size(0, 20);
			this.lblResultHieu.TabIndex = 12;
			// 
			// lblResultThuong
			// 
			this.lblResultThuong.AutoSize = true;
			this.lblResultThuong.Location = new System.Drawing.Point(227, 294);
			this.lblResultThuong.Name = "lblResultThuong";
			this.lblResultThuong.Size = new System.Drawing.Size(0, 20);
			this.lblResultThuong.TabIndex = 14;
			// 
			// lblResultTich
			// 
			this.lblResultTich.AutoSize = true;
			this.lblResultTich.Location = new System.Drawing.Point(227, 261);
			this.lblResultTich.Name = "lblResultTich";
			this.lblResultTich.Size = new System.Drawing.Size(0, 20);
			this.lblResultTich.TabIndex = 13;
			// 
			// Bai4
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.lblResultThuong);
			this.Controls.Add(this.lblResultTich);
			this.Controls.Add(this.lblResultHieu);
			this.Controls.Add(this.lblResultTong);
			this.Controls.Add(this.lblError);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.lbl2);
			this.Controls.Add(this.btnGiai);
			this.Controls.Add(this.lbl1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtbB);
			this.Controls.Add(this.txtbA);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Bai4";
			this.Text = "Bài 4,5 Tìm tổng, hiệu, tích, thương của 2 phân số";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Bai4_FormClosing);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Label label1;
		private Label label2;
		private TextBox txtbA;
		private TextBox txtbB;
		private Label label3;
		private Button btnGiai;
		private Label lbl1;
		private Label lbl2;
		private Label label4;
		private Label label5;
		private Label lblError;
		private Label lblResultTong;
		private Label lblResultHieu;
		private Label lblResultThuong;
		private Label lblResultTich;
	}
}