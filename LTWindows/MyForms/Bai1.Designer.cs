namespace LTWindows
{
	partial class Bai1
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
			this.lblX = new System.Windows.Forms.Label();
			this.txtbA = new System.Windows.Forms.TextBox();
			this.txtbB = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnConfirm = new System.Windows.Forms.Button();
			this.resultX = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnReset = new System.Windows.Forms.Button();
			this.btnReturnPrev = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblX
			// 
			this.lblX.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblX.AutoSize = true;
			this.lblX.Location = new System.Drawing.Point(182, 112);
			this.lblX.Name = "lblX";
			this.lblX.Size = new System.Drawing.Size(30, 20);
			this.lblX.TabIndex = 0;
			this.lblX.Text = "x +";
			// 
			// txtbA
			// 
			this.txtbA.Location = new System.Drawing.Point(132, 109);
			this.txtbA.Name = "txtbA";
			this.txtbA.PlaceholderText = "A";
			this.txtbA.Size = new System.Drawing.Size(44, 27);
			this.txtbA.TabIndex = 1;
			this.txtbA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtb_KeyPress);
			// 
			// txtbB
			// 
			this.txtbB.Location = new System.Drawing.Point(218, 109);
			this.txtbB.Name = "txtbB";
			this.txtbB.PlaceholderText = "B";
			this.txtbB.Size = new System.Drawing.Size(44, 27);
			this.txtbB.TabIndex = 3;
			this.txtbB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtb_KeyPress);
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(268, 112);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(31, 20);
			this.label2.TabIndex = 4;
			this.label2.Text = "= 0";
			// 
			// btnConfirm
			// 
			this.btnConfirm.Location = new System.Drawing.Point(112, 295);
			this.btnConfirm.Name = "btnConfirm";
			this.btnConfirm.Size = new System.Drawing.Size(94, 29);
			this.btnConfirm.TabIndex = 5;
			this.btnConfirm.Text = "Giải";
			this.btnConfirm.UseVisualStyleBackColor = true;
			this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
			// 
			// resultX
			// 
			this.resultX.AutoSize = true;
			this.resultX.Location = new System.Drawing.Point(119, 188);
			this.resultX.Name = "resultX";
			this.resultX.Size = new System.Drawing.Size(0, 20);
			this.resultX.TabIndex = 6;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(56, 53);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(340, 31);
			this.label1.TabIndex = 7;
			this.label1.Text = "Nhập A và B cho phương trình";
			// 
			// btnReset
			// 
			this.btnReset.Location = new System.Drawing.Point(232, 295);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(94, 29);
			this.btnReset.TabIndex = 8;
			this.btnReset.Text = "Reset";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
			// 
			// btnReturnPrev
			// 
			this.btnReturnPrev.Location = new System.Drawing.Point(168, 349);
			this.btnReturnPrev.Name = "btnReturnPrev";
			this.btnReturnPrev.Size = new System.Drawing.Size(94, 29);
			this.btnReturnPrev.TabIndex = 9;
			this.btnReturnPrev.Text = "Quay lại";
			this.btnReturnPrev.UseVisualStyleBackColor = true;
			this.btnReturnPrev.Click += new System.EventHandler(this.btnReturnPrev_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(271, 20);
			this.label3.TabIndex = 10;
			this.label3.Text = "Để trống chương trình sẽ tự hiểu là số 0";
			// 
			// Bai1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(448, 450);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnReturnPrev);
			this.Controls.Add(this.btnReset);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.resultX);
			this.Controls.Add(this.btnConfirm);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtbB);
			this.Controls.Add(this.txtbA);
			this.Controls.Add(this.lblX);
			this.Name = "Bai1";
			this.Text = "Bài 1 Giải phương trình bậc 1 (ax + b = 0)";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Bai1_FormClosing);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Label lblX;
		private TextBox txtbA;
		private TextBox txtbB;
		private Label label2;
		private Button btnConfirm;
		private Label resultX;
		private Label label1;
		private Button btnReset;
		private Button btnReturnPrev;
		private Label label3;
	}
}