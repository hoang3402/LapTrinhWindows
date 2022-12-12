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
			this.listBox2 = new System.Windows.Forms.ListBox();
			this.listBox3 = new System.Windows.Forms.ListBox();
			this.listBox4 = new System.Windows.Forms.ListBox();
			this.listBox5 = new System.Windows.Forms.ListBox();
			this.listBox6 = new System.Windows.Forms.ListBox();
			this.listBox7 = new System.Windows.Forms.ListBox();
			this.listBox8 = new System.Windows.Forms.ListBox();
			this.listBox9 = new System.Windows.Forms.ListBox();
			this.btnReturn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// listBox2
			// 
			this.listBox2.FormattingEnabled = true;
			this.listBox2.ItemHeight = 20;
			this.listBox2.Location = new System.Drawing.Point(90, 58);
			this.listBox2.Name = "listBox2";
			this.listBox2.Size = new System.Drawing.Size(150, 124);
			this.listBox2.TabIndex = 0;
			this.listBox2.Tag = "Result";
			// 
			// listBox3
			// 
			this.listBox3.FormattingEnabled = true;
			this.listBox3.ItemHeight = 20;
			this.listBox3.Location = new System.Drawing.Point(246, 58);
			this.listBox3.Name = "listBox3";
			this.listBox3.Size = new System.Drawing.Size(150, 124);
			this.listBox3.TabIndex = 1;
			this.listBox3.Tag = "Result";
			// 
			// listBox4
			// 
			this.listBox4.FormattingEnabled = true;
			this.listBox4.ItemHeight = 20;
			this.listBox4.Location = new System.Drawing.Point(402, 58);
			this.listBox4.Name = "listBox4";
			this.listBox4.Size = new System.Drawing.Size(150, 124);
			this.listBox4.TabIndex = 2;
			this.listBox4.Tag = "Result";
			// 
			// listBox5
			// 
			this.listBox5.FormattingEnabled = true;
			this.listBox5.ItemHeight = 20;
			this.listBox5.Location = new System.Drawing.Point(558, 58);
			this.listBox5.Name = "listBox5";
			this.listBox5.Size = new System.Drawing.Size(150, 124);
			this.listBox5.TabIndex = 3;
			this.listBox5.Tag = "Result";
			// 
			// listBox6
			// 
			this.listBox6.FormattingEnabled = true;
			this.listBox6.ItemHeight = 20;
			this.listBox6.Location = new System.Drawing.Point(90, 188);
			this.listBox6.Name = "listBox6";
			this.listBox6.Size = new System.Drawing.Size(150, 124);
			this.listBox6.TabIndex = 4;
			this.listBox6.Tag = "Result";
			// 
			// listBox7
			// 
			this.listBox7.FormattingEnabled = true;
			this.listBox7.ItemHeight = 20;
			this.listBox7.Location = new System.Drawing.Point(246, 188);
			this.listBox7.Name = "listBox7";
			this.listBox7.Size = new System.Drawing.Size(150, 124);
			this.listBox7.TabIndex = 5;
			this.listBox7.Tag = "Result";
			// 
			// listBox8
			// 
			this.listBox8.FormattingEnabled = true;
			this.listBox8.ItemHeight = 20;
			this.listBox8.Location = new System.Drawing.Point(402, 188);
			this.listBox8.Name = "listBox8";
			this.listBox8.Size = new System.Drawing.Size(150, 124);
			this.listBox8.TabIndex = 6;
			this.listBox8.Tag = "Result";
			// 
			// listBox9
			// 
			this.listBox9.FormattingEnabled = true;
			this.listBox9.ItemHeight = 20;
			this.listBox9.Location = new System.Drawing.Point(558, 188);
			this.listBox9.Name = "listBox9";
			this.listBox9.Size = new System.Drawing.Size(150, 124);
			this.listBox9.TabIndex = 7;
			this.listBox9.Tag = "Result";
			// 
			// btnReturn
			// 
			this.btnReturn.Location = new System.Drawing.Point(345, 356);
			this.btnReturn.Name = "btnReturn";
			this.btnReturn.Size = new System.Drawing.Size(94, 29);
			this.btnReturn.TabIndex = 8;
			this.btnReturn.Text = "Quay lại";
			this.btnReturn.UseVisualStyleBackColor = true;
			this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
			// 
			// Bai6
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(816, 450);
			this.Controls.Add(this.btnReturn);
			this.Controls.Add(this.listBox9);
			this.Controls.Add(this.listBox8);
			this.Controls.Add(this.listBox7);
			this.Controls.Add(this.listBox6);
			this.Controls.Add(this.listBox5);
			this.Controls.Add(this.listBox4);
			this.Controls.Add(this.listBox3);
			this.Controls.Add(this.listBox2);
			this.Name = "Bai6";
			this.Text = "Bài 6 In ra màn hình bảng cửu chương";
			this.Activated += new System.EventHandler(this.Bai4_Activated);
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Bai4_FormClosing);
			this.ResumeLayout(false);

		}

		#endregion

		private ListBox listBox2;
		private ListBox listBox3;
		private ListBox listBox4;
		private ListBox listBox5;
		private ListBox listBox6;
		private ListBox listBox7;
		private ListBox listBox8;
		private ListBox listBox9;
		private Button btnReturn;
	}
}