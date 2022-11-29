namespace LTWindows
{
    partial class Bai14
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnMultiplication = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbDongB = new System.Windows.Forms.TextBox();
            this.checkBoxMatrixSquareB = new System.Windows.Forms.CheckBox();
            this.txtbCotB = new System.Windows.Forms.TextBox();
            this.btnCreateMatrixB = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbDongA = new System.Windows.Forms.TextBox();
            this.checkBoxMatrixSquareA = new System.Windows.Forms.CheckBox();
            this.txtbCotA = new System.Windows.Forms.TextBox();
            this.btnCreateMatrixA = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Location = new System.Drawing.Point(-2, -4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(800, 581);
            this.tabControl.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.btnMultiplication);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtbDongB);
            this.tabPage1.Controls.Add(this.checkBoxMatrixSquareB);
            this.tabPage1.Controls.Add(this.txtbCotB);
            this.tabPage1.Controls.Add(this.btnCreateMatrixB);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtbDongA);
            this.tabPage1.Controls.Add(this.checkBoxMatrixSquareA);
            this.tabPage1.Controls.Add(this.txtbCotA);
            this.tabPage1.Controls.Add(this.btnCreateMatrixA);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 548);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nhập ma trận";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(204, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Hãy nhập thông tin ma trận B";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Hãy nhập thông tin ma trận A";
            // 
            // btnMultiplication
            // 
            this.btnMultiplication.Location = new System.Drawing.Point(42, 409);
            this.btnMultiplication.Name = "btnMultiplication";
            this.btnMultiplication.Size = new System.Drawing.Size(138, 29);
            this.btnMultiplication.TabIndex = 13;
            this.btnMultiplication.Text = "Tích 2 ma trận";
            this.btnMultiplication.UseVisualStyleBackColor = true;
            this.btnMultiplication.Click += new System.EventHandler(this.btnMultiplication_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(242, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Số dòng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(242, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Số cột";
            // 
            // txtbDongB
            // 
            this.txtbDongB.Location = new System.Drawing.Point(309, 293);
            this.txtbDongB.Name = "txtbDongB";
            this.txtbDongB.Size = new System.Drawing.Size(138, 27);
            this.txtbDongB.TabIndex = 10;
            // 
            // checkBoxMatrixSquareB
            // 
            this.checkBoxMatrixSquareB.AutoSize = true;
            this.checkBoxMatrixSquareB.Location = new System.Drawing.Point(470, 262);
            this.checkBoxMatrixSquareB.Name = "checkBoxMatrixSquareB";
            this.checkBoxMatrixSquareB.Size = new System.Drawing.Size(127, 24);
            this.checkBoxMatrixSquareB.TabIndex = 9;
            this.checkBoxMatrixSquareB.Text = "Ma trận vuông";
            this.checkBoxMatrixSquareB.UseVisualStyleBackColor = true;
            // 
            // txtbCotB
            // 
            this.txtbCotB.Location = new System.Drawing.Point(309, 260);
            this.txtbCotB.Name = "txtbCotB";
            this.txtbCotB.Size = new System.Drawing.Size(138, 27);
            this.txtbCotB.TabIndex = 8;
            // 
            // btnCreateMatrixB
            // 
            this.btnCreateMatrixB.Location = new System.Drawing.Point(309, 348);
            this.btnCreateMatrixB.Name = "btnCreateMatrixB";
            this.btnCreateMatrixB.Size = new System.Drawing.Size(138, 29);
            this.btnCreateMatrixB.TabIndex = 7;
            this.btnCreateMatrixB.Text = "Tạo ma trận";
            this.btnCreateMatrixB.UseVisualStyleBackColor = true;
            this.btnCreateMatrixB.Click += new System.EventHandler(this.btnCreateMatrixB_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Số dòng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(242, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Số cột";
            // 
            // txtbDongA
            // 
            this.txtbDongA.Location = new System.Drawing.Point(309, 79);
            this.txtbDongA.Name = "txtbDongA";
            this.txtbDongA.Size = new System.Drawing.Size(138, 27);
            this.txtbDongA.TabIndex = 3;
            // 
            // checkBoxMatrixSquareA
            // 
            this.checkBoxMatrixSquareA.AutoSize = true;
            this.checkBoxMatrixSquareA.Location = new System.Drawing.Point(470, 48);
            this.checkBoxMatrixSquareA.Name = "checkBoxMatrixSquareA";
            this.checkBoxMatrixSquareA.Size = new System.Drawing.Size(127, 24);
            this.checkBoxMatrixSquareA.TabIndex = 2;
            this.checkBoxMatrixSquareA.Text = "Ma trận vuông";
            this.checkBoxMatrixSquareA.UseVisualStyleBackColor = true;
            // 
            // txtbCotA
            // 
            this.txtbCotA.Location = new System.Drawing.Point(309, 46);
            this.txtbCotA.Name = "txtbCotA";
            this.txtbCotA.Size = new System.Drawing.Size(138, 27);
            this.txtbCotA.TabIndex = 1;
            // 
            // btnCreateMatrixA
            // 
            this.btnCreateMatrixA.Location = new System.Drawing.Point(309, 134);
            this.btnCreateMatrixA.Name = "btnCreateMatrixA";
            this.btnCreateMatrixA.Size = new System.Drawing.Size(138, 29);
            this.btnCreateMatrixA.TabIndex = 0;
            this.btnCreateMatrixA.Text = "Tạo ma trận";
            this.btnCreateMatrixA.UseVisualStyleBackColor = true;
            this.btnCreateMatrixA.Click += new System.EventHandler(this.btnCreateMatrixA_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(772, 548);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ma trận A";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.AutoScroll = true;
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(772, 548);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Ma trận B";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Bai14
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 572);
            this.Controls.Add(this.tabControl);
            this.Name = "Bai14";
            this.Text = "Bài 14";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Bai14_FormClosing);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl;
        private TabPage tabPage1;
        private Label label2;
        private Label label1;
        private TextBox txtbDongA;
        private CheckBox checkBoxMatrixSquareA;
        private TextBox txtbCotA;
        private Button btnCreateMatrixA;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Button btnMultiplication;
        private Label label3;
        private Label label4;
        private TextBox txtbDongB;
        private CheckBox checkBoxMatrixSquareB;
        private TextBox txtbCotB;
        private Button btnCreateMatrixB;
        private Label label6;
        private Label label5;
    }
}