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
            this.cbLoaiMonAn = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstMonAn = new System.Windows.Forms.ListBox();
            this.dgMonAnChon = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btChon = new System.Windows.Forms.Button();
            this.btBoChon = new System.Windows.Forms.Button();
            this.btChonLai = new System.Windows.Forms.Button();
            this.btKetThuc = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSoLuong = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgMonAnChon)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // cbLoaiMonAn
            // 
            this.cbLoaiMonAn.FormattingEnabled = true;
            this.cbLoaiMonAn.Items.AddRange(new object[] {
            "Trung Quốc",
            "Pháp",
            "Ý",
            "Việt Nam"});
            this.cbLoaiMonAn.Location = new System.Drawing.Point(9, 42);
            this.cbLoaiMonAn.Name = "cbLoaiMonAn";
            this.cbLoaiMonAn.Size = new System.Drawing.Size(188, 28);
            this.cbLoaiMonAn.TabIndex = 0;
            this.cbLoaiMonAn.Text = "Việt Nam";
            this.cbLoaiMonAn.SelectedIndexChanged += new System.EventHandler(this.cbLoaiMonAn_SelectedIndexChanged);
            this.cbLoaiMonAn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbLoaiMonAn_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(9, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Loại (Quốc gia)";
            // 
            // lstMonAn
            // 
            this.lstMonAn.FormattingEnabled = true;
            this.lstMonAn.ItemHeight = 20;
            this.lstMonAn.Location = new System.Drawing.Point(9, 109);
            this.lstMonAn.Name = "lstMonAn";
            this.lstMonAn.Size = new System.Drawing.Size(188, 244);
            this.lstMonAn.TabIndex = 2;
            this.lstMonAn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lstMonAn_KeyPress);
            this.lstMonAn.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstMonAn_MouseDoubleClick);
            // 
            // dgMonAnChon
            // 
            this.dgMonAnChon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMonAnChon.Location = new System.Drawing.Point(441, 67);
            this.dgMonAnChon.Name = "dgMonAnChon";
            this.dgMonAnChon.RowHeadersWidth = 51;
            this.dgMonAnChon.RowTemplate.Height = 29;
            this.dgMonAnChon.Size = new System.Drawing.Size(373, 311);
            this.dgMonAnChon.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Số lượng";
            // 
            // btChon
            // 
            this.btChon.Location = new System.Drawing.Point(281, 175);
            this.btChon.Name = "btChon";
            this.btChon.Size = new System.Drawing.Size(94, 29);
            this.btChon.TabIndex = 6;
            this.btChon.Text = "Chọn";
            this.btChon.UseVisualStyleBackColor = true;
            this.btChon.Click += new System.EventHandler(this.btChon_Click);
            // 
            // btBoChon
            // 
            this.btBoChon.Location = new System.Drawing.Point(281, 210);
            this.btBoChon.Name = "btBoChon";
            this.btBoChon.Size = new System.Drawing.Size(94, 29);
            this.btBoChon.TabIndex = 6;
            this.btBoChon.Text = "Bỏ chọn";
            this.btBoChon.UseVisualStyleBackColor = true;
            this.btBoChon.Click += new System.EventHandler(this.btBoChon_Click);
            // 
            // btChonLai
            // 
            this.btChonLai.Location = new System.Drawing.Point(281, 326);
            this.btChonLai.Name = "btChonLai";
            this.btChonLai.Size = new System.Drawing.Size(94, 29);
            this.btChonLai.TabIndex = 6;
            this.btChonLai.Text = "Chọn lại";
            this.btChonLai.UseVisualStyleBackColor = true;
            this.btChonLai.Click += new System.EventHandler(this.btChonLai_Click);
            // 
            // btKetThuc
            // 
            this.btKetThuc.Location = new System.Drawing.Point(720, 384);
            this.btKetThuc.Name = "btKetThuc";
            this.btKetThuc.Size = new System.Drawing.Size(94, 29);
            this.btKetThuc.TabIndex = 6;
            this.btKetThuc.Text = "Thoát";
            this.btKetThuc.UseVisualStyleBackColor = true;
            this.btKetThuc.Click += new System.EventHandler(this.btKetThuc_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(9, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Các món ăn thuộc loại";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lstMonAn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbLoaiMonAn);
            this.groupBox1.Location = new System.Drawing.Point(14, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 374);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(260, 103);
            this.txtSoLuong.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtSoLuong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(147, 27);
            this.txtSoLuong.TabIndex = 9;
            this.txtSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(840, 428);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btKetThuc);
            this.Controls.Add(this.btChonLai);
            this.Controls.Add(this.btBoChon);
            this.Controls.Add(this.btChon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgMonAnChon);
            this.Name = "MainView";
            this.Text = "Nguyễn Văn Hoàng - 12101005";
            this.Load += new System.EventHandler(this.MainView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgMonAnChon)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cbLoaiMonAn;
        private Label label1;
        private ListBox lstMonAn;
        private DataGridView dgMonAnChon;
        private Label label2;
        private Button btChon;
        private Button btBoChon;
        private Button btChonLai;
        private Button btKetThuc;
        private Label label3;
        private GroupBox groupBox1;
        private NumericUpDown txtSoLuong;
    }
}