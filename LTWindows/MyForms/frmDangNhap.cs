namespace LTWindows.MyForms
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void KeyPressEvent(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)13)
            {
                btnLogin_Click(sender, e);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Bạn chưa nhập đủ dữ liệu!");
                return;
            }
            if (txtUserName.Text != "admin")
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
                return;
            }
            if (txtPassword.Text != "123")
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
                return;
            }

            frmMain newForm = new(this);
            newForm.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
