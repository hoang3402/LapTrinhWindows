using LTWindows.Core;

namespace LTWindows
{
    public partial class Bai2 : Form
    {
        private string? _curChoose;
        public Bai2()
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
                MessageBox.Show("Không được để trống!");
                return;
            }
            double r = double.Parse(txtA.Text);
            HinhTron HT = new(r);
            txtChuVi.Text = HT.LayChuVi().ToString();
            txtDienTich.Text = HT.LayDienTich().ToString();
            MessageBox.Show(HT.Xuat());
            return;
        }
        private void GiaiHinhVuong()
        {
            double canh = double.Parse(txtA.Text);
            HinhVuong HV = new(canh);
            txtChuVi.Text = HV.LayChuVi().ToString();
            txtDienTich.Text = HV.LayDienTich().ToString();
            MessageBox.Show(HV.Xuat());
            return;
        }
        private void GiaiHinhChuNhat()
        {
            double a = double.Parse(txtA.Text);
            double b = double.Parse(txtB.Text);
            HCN hcn = new(a, b);
            txtChuVi.Text = hcn.ChuVi().ToString();
            txtDienTich.Text = hcn.DienTich().ToString();
            MessageBox.Show(hcn.Xuat());
            return;
        }
        private void GiaiHinhTamGiac()
        {
            int a = int.Parse(txtA.Text);
            int b = int.Parse(txtB.Text);
            int c = int.Parse(txtC.Text);
            HinhTamGiac TG = new(a, b, c);
            txtChuVi.Text = TG.LayChuVi().ToString();
            txtDienTich.Text = TG.LayDienTich().ToString();
            MessageBox.Show(TG.Xuat());
            return;
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputManager.txtb_KeyPress(ref sender, ref e);
            if (e.KeyChar == (int)13)
            {
                btnGiai_Click(sender, e);
            }
        }
        private void Bai2_FormClosing(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
