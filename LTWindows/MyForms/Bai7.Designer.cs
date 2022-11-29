namespace LTWindows
{
	partial class Bai7
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
			this.txtbC = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtbB = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.lblResult = new System.Windows.Forms.Label();
			this.btnGiai = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(307, 28);
			this.label1.TabIndex = 0;
			this.label1.Text = "Hãy nhập vào 3 cạch của tam giác";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(54, 76);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(33, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "A =";
			// 
			// txtbA
			// 
			this.txtbA.Location = new System.Drawing.Point(93, 73);
			this.txtbA.Name = "txtbA";
			this.txtbA.Size = new System.Drawing.Size(103, 27);
			this.txtbA.TabIndex = 2;
			this.txtbA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtb_Press);
			// 
			// txtbC
			// 
			this.txtbC.Location = new System.Drawing.Point(93, 139);
			this.txtbC.Name = "txtbC";
			this.txtbC.Size = new System.Drawing.Size(103, 27);
			this.txtbC.TabIndex = 4;
			this.txtbC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtb_Press);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(54, 142);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(32, 20);
			this.label3.TabIndex = 3;
			this.label3.Text = "C =";
			// 
			// txtbB
			// 
			this.txtbB.Location = new System.Drawing.Point(93, 106);
			this.txtbB.Name = "txtbB";
			this.txtbB.Size = new System.Drawing.Size(103, 27);
			this.txtbB.TabIndex = 6;
			this.txtbB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtb_Press);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(54, 109);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(32, 20);
			this.label4.TabIndex = 5;
			this.label4.Text = "B =";
			// 
			// lblResult
			// 
			this.lblResult.AutoSize = true;
			this.lblResult.Location = new System.Drawing.Point(93, 197);
			this.lblResult.Name = "lblResult";
			this.lblResult.Size = new System.Drawing.Size(0, 20);
			this.lblResult.TabIndex = 7;
			// 
			// btnGiai
			// 
			this.btnGiai.Location = new System.Drawing.Point(102, 305);
			this.btnGiai.Name = "btnGiai";
			this.btnGiai.Size = new System.Drawing.Size(94, 29);
			this.btnGiai.TabIndex = 8;
			this.btnGiai.Text = "Kiểm tra";
			this.btnGiai.UseVisualStyleBackColor = true;
			this.btnGiai.Click += new System.EventHandler(this.btnGiai_Click);
			// 
			// Bai7
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnGiai);
			this.Controls.Add(this.lblResult);
			this.Controls.Add(this.txtbB);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtbC);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtbA);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Bai7";
			this.Text = "Bài 7";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Bai7_FormClosing);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Label label1;
		private Label label2;
		private TextBox txtbA;
		private TextBox txtbC;
		private Label label3;
		private TextBox txtbB;
		private Label label4;
		private Label lblResult;
		private Button btnGiai;
	}
}