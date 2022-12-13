using LTWindows.Core;

namespace LTWindows
{
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            if (txtCanh1.Text == string.Empty || txtCanh2.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin!" +
                              "\nXin hãy kiểm tra lại!");
                return;
            }

            try
            {
                double canh1 = double.Parse(txtCanh1.Text);
                double canh2 = double.Parse(txtCanh2.Text);
                HCN hcn = new(canh1, canh2);
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

        private void MainView_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}