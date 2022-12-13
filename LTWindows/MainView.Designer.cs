namespace LTWindows
{
    partial class MainView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnTinh = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCanh1 = new System.Windows.Forms.TextBox();
            this.txtDienTich = new System.Windows.Forms.TextBox();
            this.txtChuVi = new System.Windows.Forms.TextBox();
            this.txtCanh2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(797, 108);
            this.label1.TabIndex = 0;
            this.label1.Text = "TÍNH CHU VI VÀ DIỆN TÍCH HCN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTinh
            // 
            this.btnTinh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnTinh.Location = new System.Drawing.Point(502, 167);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(94, 29);
            this.btnTinh.TabIndex = 1;
            this.btnTinh.Text = "Tính";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExit.Location = new System.Drawing.Point(502, 237);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 29);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(113, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cạnh 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(113, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cạnh 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(113, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Diện tích";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(113, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Chu vi";
            // 
            // txtCanh1
            // 
            this.txtCanh1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCanh1.Location = new System.Drawing.Point(211, 135);
            this.txtCanh1.Name = "txtCanh1";
            this.txtCanh1.Size = new System.Drawing.Size(211, 27);
            this.txtCanh1.TabIndex = 7;
            this.txtCanh1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // txtDienTich
            // 
            this.txtDienTich.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtDienTich.Location = new System.Drawing.Point(211, 284);
            this.txtDienTich.Name = "txtDienTich";
            this.txtDienTich.ReadOnly = true;
            this.txtDienTich.Size = new System.Drawing.Size(211, 27);
            this.txtDienTich.TabIndex = 8;
            // 
            // txtChuVi
            // 
            this.txtChuVi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtChuVi.Location = new System.Drawing.Point(211, 237);
            this.txtChuVi.Name = "txtChuVi";
            this.txtChuVi.ReadOnly = true;
            this.txtChuVi.Size = new System.Drawing.Size(211, 27);
            this.txtChuVi.TabIndex = 9;
            // 
            // txtCanh2
            // 
            this.txtCanh2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCanh2.Location = new System.Drawing.Point(211, 188);
            this.txtCanh2.Name = "txtCanh2";
            this.txtCanh2.Size = new System.Drawing.Size(211, 27);
            this.txtCanh2.TabIndex = 10;
            this.txtCanh2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(797, 444);
            this.Controls.Add(this.txtCanh2);
            this.Controls.Add(this.txtChuVi);
            this.Controls.Add(this.txtDienTich);
            this.Controls.Add(this.txtCanh1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.label1);
            this.Name = "MainView";
            this.Text = "Nguyễn Văn Hoàng - 12101005";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Button btnTinh;
        private Button btnExit;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtCanh1;
        private TextBox txtDienTich;
        private TextBox txtChuVi;
        private TextBox txtCanh2;
    }
}