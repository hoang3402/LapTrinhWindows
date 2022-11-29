namespace LTWindows
{
	partial class Bai10
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
			this.lblNumber = new System.Windows.Forms.Label();
			this.txtbNumber = new System.Windows.Forms.TextBox();
			this.listBoxResult = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// lblNumber
			// 
			this.lblNumber.AutoSize = true;
			this.lblNumber.Location = new System.Drawing.Point(128, 62);
			this.lblNumber.Name = "lblNumber";
			this.lblNumber.Size = new System.Drawing.Size(111, 20);
			this.lblNumber.TabIndex = 0;
			this.lblNumber.Text = "Số cần kiểm tra";
			this.lblNumber.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// txtbNumber
			// 
			this.txtbNumber.Location = new System.Drawing.Point(245, 59);
			this.txtbNumber.Name = "txtbNumber";
			this.txtbNumber.Size = new System.Drawing.Size(143, 27);
			this.txtbNumber.TabIndex = 1;
			this.txtbNumber.Click += new System.EventHandler(this.txtbNumber_Click);
			this.txtbNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbNumber_KeyPress);
			// 
			// listBoxResult
			// 
			this.listBoxResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listBoxResult.FormattingEnabled = true;
			this.listBoxResult.ItemHeight = 20;
			this.listBoxResult.Location = new System.Drawing.Point(12, 125);
			this.listBoxResult.Name = "listBoxResult";
			this.listBoxResult.Size = new System.Drawing.Size(534, 304);
			this.listBoxResult.TabIndex = 2;
			// 
			// Bai10
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(558, 450);
			this.Controls.Add(this.listBoxResult);
			this.Controls.Add(this.txtbNumber);
			this.Controls.Add(this.lblNumber);
			this.Name = "Bai10";
			this.Text = "Bai10";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Bai10_FormClosing);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Label lblNumber;
		private TextBox txtbNumber;
		private ListBox listBoxResult;
	}
}