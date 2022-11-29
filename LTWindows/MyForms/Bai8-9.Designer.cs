namespace LTWindows
{
	partial class Bai8
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
			this.textBoxBase10 = new System.Windows.Forms.TextBox();
			this.textBoxResult2 = new System.Windows.Forms.TextBox();
			this.textBoxResult10 = new System.Windows.Forms.TextBox();
			this.textBoxBase2 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// textBoxBase10
			// 
			this.textBoxBase10.Location = new System.Drawing.Point(121, 113);
			this.textBoxBase10.Name = "textBoxBase10";
			this.textBoxBase10.Size = new System.Drawing.Size(156, 27);
			this.textBoxBase10.TabIndex = 0;
			this.textBoxBase10.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxBase10_KeyPress);
			this.textBoxBase10.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyUp);
			// 
			// textBoxResult2
			// 
			this.textBoxResult2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.textBoxResult2.Location = new System.Drawing.Point(384, 113);
			this.textBoxResult2.Name = "textBoxResult2";
			this.textBoxResult2.ReadOnly = true;
			this.textBoxResult2.Size = new System.Drawing.Size(125, 27);
			this.textBoxResult2.TabIndex = 1;
			// 
			// textBoxResult10
			// 
			this.textBoxResult10.Location = new System.Drawing.Point(384, 221);
			this.textBoxResult10.Name = "textBoxResult10";
			this.textBoxResult10.ReadOnly = true;
			this.textBoxResult10.Size = new System.Drawing.Size(125, 27);
			this.textBoxResult10.TabIndex = 3;
			// 
			// textBoxBase2
			// 
			this.textBoxBase2.Location = new System.Drawing.Point(121, 221);
			this.textBoxBase2.Name = "textBoxBase2";
			this.textBoxBase2.Size = new System.Drawing.Size(156, 27);
			this.textBoxBase2.TabIndex = 2;
			this.textBoxBase2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxBase2_KeyPress);
			this.textBoxBase2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyUp);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(121, 90);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(156, 20);
			this.label1.TabIndex = 4;
			this.label1.Text = "Từ cơ số 10 -> cơ số 2";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(121, 198);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(156, 20);
			this.label2.TabIndex = 5;
			this.label2.Text = "Từ cơ số 2 -> cơ số 10";
			// 
			// Bai8
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(683, 400);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBoxResult10);
			this.Controls.Add(this.textBoxBase2);
			this.Controls.Add(this.textBoxResult2);
			this.Controls.Add(this.textBoxBase10);
			this.Name = "Bai8";
			this.Text = "Bài 8";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Bai8_FormClosing);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private TextBox textBoxBase10;
		private TextBox textBoxResult2;
		private TextBox textBoxResult10;
		private TextBox textBoxBase2;
		private Label label1;
		private Label label2;
	}
}