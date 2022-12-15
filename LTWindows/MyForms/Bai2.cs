using LTWindows.Core;

namespace LTWindows
{
    public partial class Bai2 : Form
    {
        readonly frmMain? _prev;

        public Bai2(frmMain prev)
        {
            InitializeComponent();
            _prev = prev;
        }

        // Check input type
        private void txtb_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputManager.txtb_KeyPress(ref sender, ref e);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.txtbA.ResetText();
            this.txtbB.ResetText();
            this.txtbC.ResetText();
            this.lblResultX.ResetText();
            this.lblResultY.ResetText();
        }

        private void btnGiai_Click(object sender, EventArgs e)
        {
            try
            {
                int A = this.txtbA.Text == string.Empty ? 0 : int.Parse(this.txtbA.Text);
                int B = this.txtbB.Text == string.Empty ? 0 : int.Parse(this.txtbB.Text);
                int C = this.txtbC.Text == string.Empty ? 0 : int.Parse(this.txtbC.Text);
                Giai(A, B, C);
            }
            catch (Exception ex)
            {
                this.lblResultX.Text = ex.Message;
            }

        }

        private void Giai(int a, int b, int c)
        {
            if (a == 0)
            {
                Bai1 bai1 = new();
                this.lblResultX.Text = bai1.GiaiPhuongTrinhBac1(b, c);
                this.lblResultY.ResetText();
                return;
            }
            double delta = b * b - 4 * a * c;
            if (delta < 0)
            {
                this.lblResultX.Text = "Phương trình vô nghiệm!";
                this.lblResultY.ResetText();
            }
            else if (delta == 0)
            {
                this.lblResultX.Text = "x1 = x2 = " + -b * 1.0 / (2 * a);
                this.lblResultY.ResetText();
            }
            else
            {
                this.lblResultX.Text = "x1 = " + (-b + Math.Sqrt(delta)) / (2 * a);
                this.lblResultY.Text = "x2 = " + (-b - Math.Sqrt(delta)) / (2 * a);
            }
        }

        private void btnReturnPrev_Click(object sender, EventArgs e)
        {
            this.Close();
            if (this._prev != null) { _prev.Show(); }
        }

        private void Bai2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this._prev != null) { _prev.Show(); }
        }
    }
}
