namespace LTWindows.MySubForms
{
	partial class FindPerfectNumber
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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.btnOK = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblX
			// 
			this.lblX.AutoSize = true;
			this.lblX.Location = new System.Drawing.Point(98, 78);
			this.lblX.Name = "lblX";
			this.lblX.Size = new System.Drawing.Size(86, 20);
			this.lblX.TabIndex = 0;
			this.lblX.Text = "Nhập vào X";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(190, 75);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(125, 27);
			this.textBox1.TabIndex = 1;
			this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
			// 
			// btnOK
			// 
			this.btnOK.Location = new System.Drawing.Point(148, 136);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(94, 29);
			this.btnOK.TabIndex = 2;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// FindX
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(424, 237);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.lblX);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "FindX";
			this.Text = "Tìm X trong dãy số";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Label lblX;
		private TextBox textBox1;
		private Button btnOK;
	}
}