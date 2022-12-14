using LTWindows.Core;

namespace LTWindows
{
    public partial class Lab3 : Form
    {
        private string? _curChoose;
        public Lab3()
        {
            InitializeComponent();
        }
        private void radioButton_Click(object sender, EventArgs e)
        {
            _curChoose = ((RadioButton)sender).Text;
            disableAndReset();
            switch (_curChoose)
            {
                case "Hình tròn":
                    lbla.Text = "Bán kính";
                    txtA.Visible = true;
                    break;
                case "Hình vuông":
                    lbla.Text = "Cạnh";
                    txtA.Visible = true;
                    break;
                case "Hình chữ nhật":
                    lbla.Text = "Cạnh dài";
                    txtA.Visible = true;
                    lblb.Text = "Cạnh rộng";
                    txtB.Visible = true;
                    break;
                case "Hình tam giác":
                    lbla.Text = "Cạnh 1";
                    txtA.Visible = true;
                    lblb.Text = "Cạnh 2";
                    txtB.Visible = true;
                    lblc.Text = "Cạnh 3";
                    txtC.Visible = true;
                    break;
                default:
                    MessageBox.Show("What?");
                    break;
            }
            return;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void disableAndReset()
        {
            lbla.Text = string.Empty;
            lblb.Text = string.Empty;
            lblc.Text = string.Empty;
            txtA.ResetText();
            txtB.ResetText();
            txtC.ResetText();
            txtA.Visible = false;
            txtB.Visible = false;
            txtC.Visible = false;
            txtChuVi.ResetText();
            txtDienTich.ResetText();
        }
        private void btnReload_Click(object sender, EventArgs e)
        {
            txtA.ResetText();
            txtB.ResetText();
            txtC.ResetText();
            txtChuVi.ResetText();
            txtDienTich.ResetText();
        }
        private void btnGiai_Click(object sender, EventArgs e)
        {
            switch (_curChoose)
            {
                case "Hình tròn":
                    GiaiHinhTron();
                    break;
                case "Hình vuông":
                    GiaiHinhVuong();
                    break;
                case "Hình chữ nhật":
                    GiaiHinhChuNhat();
                    break;
                case "Hình tam giác":
                    GiaiHinhTamGiac();
                    break;
                default:
                    MessageBox.Show("What?");
                    break;
            }
        }

        private void GiaiHinhTron()
        {
            if (txtA.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập đủ dữ liệu!");
                return;
            }
            double r = double.Parse(txtA.Text);
            HinhTron HT = new(r);
            txtChuVi.Text = HT.LayChuVi().ToString("0.00");
            txtDienTich.Text = HT.LayDienTich().ToString("0.00");
            return;
        }
        private void GiaiHinhVuong()
        {
            if (txtA.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập đủ dữ liệu!");
                return;
            }
            double canh = double.Parse(txtA.Text);
            HinhVuong HV = new(canh);
            txtChuVi.Text = HV.LayChuVi().ToString("0.00");
            txtDienTich.Text = HV.LayDienTich().ToString("0.00");
            return;
        }
        private void GiaiHinhChuNhat()
        {
            if (txtA.Text == string.Empty || txtB.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập đủ dữ liệu!");
                return;
            }
            double a = double.Parse(txtA.Text);
            double b = double.Parse(txtB.Text);
            HCN hcn = new(a, b);
            txtChuVi.Text = hcn.ChuVi().ToString("0.00");
            txtDienTich.Text = hcn.DienTich().ToString("0.00");
            return;
        }
        private void GiaiHinhTamGiac()
        {
            if (txtA.Text == string.Empty || txtB.Text == string.Empty || txtC.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập đủ dữ liệu!");
                return;
            }
            int a = int.Parse(txtA.Text);
            int b = int.Parse(txtB.Text);
            int c = int.Parse(txtC.Text);
            HinhTamGiac TG = new(a, b, c);
            txtChuVi.Text = TG.LayChuVi().ToString("0.00");
            txtDienTich.Text = TG.LayDienTich().ToString("0.00");
            return;
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputManager.txtb_KeyPress(ref sender, ref e);

            // When user press 'enter' system call btnGiai_Click
            if (e.KeyChar == (int)13)
            {
                btnGiai_Click(sender, e);
            }
        }
        private void Lab3_FormClosing(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Lab3_Load(object sender, EventArgs e)
        {
            disableAndReset();
        }
    }
}
