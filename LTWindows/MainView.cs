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
                return;
            }
            if (Choose == "Trung Quốc")
            {
                return;
            }
            if (Choose == "Ý")
            {
                return;
            }
            if (Choose == "Việt Nam")
            {
                return;
            }
        }
    }
}