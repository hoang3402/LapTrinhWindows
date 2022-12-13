using LTWindows.Core;

namespace LTWindows
{
    public partial class MainView : Form
    {
        public MainView()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            if (txtCanh1.Text == string.Empty || txtCanh2.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin!\nXin hãy kiểm tra lại!");
                return;
            }

            try
            {
                int canh1 = int.Parse(txtCanh1.Text);
                int canh2 = int.Parse(txtCanh2.Text);
                txtChuVi.Text = ((canh1 + canh2) * 2).ToString();
                txtDienTich.Text = (canh1 * canh2).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputManager.txtb_KeyPress(ref sender, ref e);
        }
    }
}