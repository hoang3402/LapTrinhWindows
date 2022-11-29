namespace LTWindows
{
	partial class Bai12
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
			this.txtbInput = new System.Windows.Forms.TextBox();
			this.lblTitle = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.listViewResult = new System.Windows.Forms.ListView();
			this.btnTotal = new System.Windows.Forms.Button();
			this.btnTotalOdd = new System.Windows.Forms.Button();
			this.btnTotalEven = new System.Windows.Forms.Button();
			this.btnReset = new System.Windows.Forms.Button();
			this.btnSort = new System.Windows.Forms.Button();
			this.btnFindX = new System.Windows.Forms.Button();
			this.btnAVG = new System.Windows.Forms.Button();
			this.btnPrimeNumber = new System.Windows.Forms.Button();
			this.btnMinPerfectNumber = new System.Windows.Forms.Button();
			this.btnPerfectNumber = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtbInput
			// 
			this.txtbInput.Location = new System.Drawing.Point(162, 135);
			this.txtbInput.Name = "txtbInput";
			this.txtbInput.Size = new System.Drawing.Size(456, 27);
			this.txtbInput.TabIndex = 0;
			this.txtbInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbInput_KeyPress);
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblTitle.Location = new System.Drawing.Point(271, 104);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(245, 28);
			this.lblTitle.TabIndex = 1;
			this.lblTitle.Text = "Nhập vào 1 dãy số nguyên";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(39, 182);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(170, 28);
			this.label1.TabIndex = 3;
			this.label1.Text = "Dãy bạn vừa nhập";
			// 
			// listViewResult
			// 
			this.listViewResult.Location = new System.Drawing.Point(39, 213);
			this.listViewResult.Name = "listViewResult";
			this.listViewResult.Size = new System.Drawing.Size(731, 138);
			this.listViewResult.TabIndex = 4;
			this.listViewResult.UseCompatibleStateImageBehavior = false;
			this.listViewResult.DoubleClick += new System.EventHandler(this.listViewResult_MouseDoubleClick);
			// 
			// btnTotal
			// 
			this.btnTotal.Location = new System.Drawing.Point(162, 375);
			this.btnTotal.Name = "btnTotal";
			this.btnTotal.Size = new System.Drawing.Size(140, 29);
			this.btnTotal.TabIndex = 5;
			this.btnTotal.Text = "Tổng của dãy";
			this.btnTotal.UseVisualStyleBackColor = true;
			this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
			// 
			// btnTotalOdd
			// 
			this.btnTotalOdd.Location = new System.Drawing.Point(162, 445);
			this.btnTotalOdd.Name = "btnTotalOdd";
			this.btnTotalOdd.Size = new System.Drawing.Size(140, 29);
			this.btnTotalOdd.TabIndex = 6;
			this.btnTotalOdd.Text = "Tổng số lẻ";
			this.btnTotalOdd.UseVisualStyleBackColor = true;
			this.btnTotalOdd.Click += new System.EventHandler(this.btnTotalOdd_Click);
			// 
			// btnTotalEven
			// 
			this.btnTotalEven.Location = new System.Drawing.Point(162, 410);
			this.btnTotalEven.Name = "btnTotalEven";
			this.btnTotalEven.Size = new System.Drawing.Size(140, 29);
			this.btnTotalEven.TabIndex = 7;
			this.btnTotalEven.Text = "Tổng số chẵn";
			this.btnTotalEven.UseVisualStyleBackColor = true;
			this.btnTotalEven.Click += new System.EventHandler(this.btnTotalEven_Click);
			// 
			// btnReset
			// 
			this.btnReset.Image = global::LTWindows.Properties.Resources.icons8_refresh_22;
			this.btnReset.Location = new System.Drawing.Point(736, 182);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(34, 28);
			this.btnReset.TabIndex = 8;
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
			// 
			// btnSort
			// 
			this.btnSort.Location = new System.Drawing.Point(162, 480);
			this.btnSort.Name = "btnSort";
			this.btnSort.Size = new System.Drawing.Size(140, 29);
			this.btnSort.TabIndex = 9;
			this.btnSort.Text = "Sắp xếp dãy";
			this.btnSort.UseVisualStyleBackColor = true;
			this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
			// 
			// btnFindX
			// 
			this.btnFindX.Location = new System.Drawing.Point(330, 375);
			this.btnFindX.Name = "btnFindX";
			this.btnFindX.Size = new System.Drawing.Size(131, 29);
			this.btnFindX.TabIndex = 10;
			this.btnFindX.Text = "Tìm x trong dãy";
			this.btnFindX.UseVisualStyleBackColor = true;
			this.btnFindX.Click += new System.EventHandler(this.btnFindX_Click);
			// 
			// btnAVG
			// 
			this.btnAVG.Location = new System.Drawing.Point(330, 410);
			this.btnAVG.Name = "btnAVG";
			this.btnAVG.Size = new System.Drawing.Size(131, 99);
			this.btnAVG.TabIndex = 11;
			this.btnAVG.Text = "Trung bình cộng các phần tử chia hết cho 3";
			this.btnAVG.UseVisualStyleBackColor = true;
			this.btnAVG.Click += new System.EventHandler(this.btnAVG_Click);
			// 
			// btnPrimeNumber
			// 
			this.btnPrimeNumber.Location = new System.Drawing.Point(487, 375);
			this.btnPrimeNumber.Name = "btnPrimeNumber";
			this.btnPrimeNumber.Size = new System.Drawing.Size(131, 29);
			this.btnPrimeNumber.TabIndex = 12;
			this.btnPrimeNumber.Text = "Số nguyên tố";
			this.btnPrimeNumber.UseVisualStyleBackColor = true;
			this.btnPrimeNumber.Click += new System.EventHandler(this.btnPrimeNumber_Click);
			// 
			// btnMinPerfectNumber
			// 
			this.btnMinPerfectNumber.Location = new System.Drawing.Point(487, 445);
			this.btnMinPerfectNumber.Name = "btnMinPerfectNumber";
			this.btnMinPerfectNumber.Size = new System.Drawing.Size(131, 64);
			this.btnMinPerfectNumber.TabIndex = 13;
			this.btnMinPerfectNumber.Text = "Số hoàn chỉnh nhỏ nhất";
			this.btnMinPerfectNumber.UseVisualStyleBackColor = true;
			this.btnMinPerfectNumber.Click += new System.EventHandler(this.btnMinPerfectNumber_Click);
			// 
			// btnPerfectNumber
			// 
			this.btnPerfectNumber.Location = new System.Drawing.Point(487, 410);
			this.btnPerfectNumber.Name = "btnPerfectNumber";
			this.btnPerfectNumber.Size = new System.Drawing.Size(131, 29);
			this.btnPerfectNumber.TabIndex = 14;
			this.btnPerfectNumber.Text = "Số hoàn chỉnh";
			this.btnPerfectNumber.UseVisualStyleBackColor = true;
			this.btnPerfectNumber.Click += new System.EventHandler(this.btnPerfectNumber_Click);
			// 
			// Bai12
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 591);
			this.Controls.Add(this.btnPerfectNumber);
			this.Controls.Add(this.btnMinPerfectNumber);
			this.Controls.Add(this.btnPrimeNumber);
			this.Controls.Add(this.btnAVG);
			this.Controls.Add(this.btnFindX);
			this.Controls.Add(this.btnSort);
			this.Controls.Add(this.btnReset);
			this.Controls.Add(this.btnTotalEven);
			this.Controls.Add(this.btnTotalOdd);
			this.Controls.Add(this.btnTotal);
			this.Controls.Add(this.listViewResult);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblTitle);
			this.Controls.Add(this.txtbInput);
			this.Name = "Bai12";
			this.Text = "Bài 12";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Bai12_FormClosing);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private TextBox txtbInput;
		private Label lblTitle;
		private Label label1;
		private ListView listViewResult;
		private Button btnTotal;
		private Button btnTotalOdd;
		private Button btnTotalEven;
		private Button btnReset;
		private Button btnSort;
		private Button btnFindX;
		private Button btnAVG;
		private Button btnPrimeNumber;
		private Button btnMinPerfectNumber;
		private Button btnPerfectNumber;
	}
}