namespace LTWindows
{
    public partial class MainView : Form
    {
        public MainView()
        {
            InitializeComponent();
        }

        private void btKetThuc_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cbLoaiMonAn_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbLoaiMonAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstMonAn.Items.Clear();

            string? Choose = cbLoaiMonAn.SelectedItem.ToString();
            if (String.IsNullOrEmpty(Choose))
            {
                return;
            }
            if (Choose == "Pháp")
            {
                lstMonAn.Items.Add("Ớt trộn mù tạc");
                lstMonAn.Items.Add("Dầu xối mỡ");
                return;
            }
            if (Choose == "Trung Quốc")
            {
                lstMonAn.Items.Add("Vịt Tiềm");
                lstMonAn.Items.Add("Hủ Tiếu");
                lstMonAn.Items.Add("Nước Mắm Xào Giòn");
                return;
            }
            if (Choose == "Ý")
            {
                lstMonAn.Items.Add("Bolognese");
                lstMonAn.Items.Add("Mì Ý - Spaghetti");
                lstMonAn.Items.Add("Lasagne");
                return;
            }
            if (Choose == "Việt Nam")
            {
                lstMonAn.Items.Add("Muối Chấm Nước Mắm");
                lstMonAn.Items.Add("Cá Kho Tộ");
                return;
            }
        }

        private void MainView_Load(object sender, EventArgs e)
        {
            lstMonAn.Items.Add("Xin mời chọn loại (Quốc gia)");
        }

        private void btChon_Click(object sender, EventArgs e)
        {
            if (lstMonAn.SelectedItem == null)
            {
                MessageBox.Show("Chọn món đê");
                return;
            }
            string ten = lstMonAn.SelectedItem.ToString();
            decimal sl = txtSoLuong.Value;
            dgMonAnChon.Rows.Add(ten, sl);
        }

        private void btBoChon_Click(object sender, EventArgs e)
        {

        }

        private void btChonLai_Click(object sender, EventArgs e)
        {

        }
    }
}