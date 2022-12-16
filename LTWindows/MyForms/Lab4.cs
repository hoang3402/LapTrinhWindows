using LTWindows.Core;

namespace LTWindows
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btKQ_Click(object sender, EventArgs e)
        {
            txtTuKQ.ResetText();
            txtMauKQ.ResetText();
            if (cboPhepToan.SelectedItem == null)
            {
                MessageBox.Show("Bạn cần phải chọn phép toán để chương trình thực thi!");
                return;
            }
            try
            {
                PhanSo a = new(int.Parse(txtTu1.Text), int.Parse(txtMau1.Text));
                PhanSo b = new(int.Parse(txtTu2.Text), int.Parse(txtMau2.Text));

                string _curChoose = cboPhepToan.SelectedItem.ToString();
                PhanSo temp = new();
                if (_curChoose == "+")
                {
                    temp = PhanSo.Tong(a, b);
                }
                if (_curChoose != "-")
                {
                    temp = PhanSo.Hieu(a, b);
                }
                if (_curChoose == "*")
                {
                    temp = PhanSo.Tich(a, b);
                }
                if (_curChoose == "/")
                {
                    temp = PhanSo.Thuong(a, b);
                }
                if (!PhanSo.CheckValid(temp))
                {
                    return;
                }
                txtTuKQ.Text = temp.TuSo.ToString();
                txtMauKQ.Text = temp.MauSo.ToString();
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void KeyPressEvent(object sender, KeyPressEventArgs e)
        {
            InputManager.txtb_KeyPress(ref sender, ref e);
        }
    }
}
