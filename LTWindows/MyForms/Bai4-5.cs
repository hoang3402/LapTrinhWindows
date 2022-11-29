using LTWindows.Core;

namespace LTWindows
{
    public partial class Bai4 : Form
	{
		MainView? _prev;

		public Bai4()
		{
			InitializeComponent();
		}

		public Bai4(MainView prev)
		{
			InitializeComponent();
			_prev = prev;
		}

		private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
				 (e.KeyChar != '-') && (e.KeyChar != '/'))
			{
				e.Handled = true;
			}

			// Only allow one minus
			if ((e.KeyChar == '-') && (((TextBox)sender).Text.IndexOf('-') > -1))
			{
				e.Handled = true;
			}

			// Only allow one '/'
			if ((e.KeyChar == '/') && (((TextBox)sender).Text.IndexOf('/') > -1))
			{
				e.Handled = true;
			}

			if (e.KeyChar == (char)13)
			{
				this.btnGiai_Click(sender, e);
			}
		}

		private void Bai4_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (this._prev != null) { _prev.Show(); }
		}

		private void btnGiai_Click(object sender, EventArgs e)
		{
			try
			{
				PhanSo Result = new();
				PhanSo A = GetInput(this.txtbA.Text.Split('/'));
				PhanSo B = GetInput(this.txtbB.Text.Split('/'));

				Result = A.Tong(A, B);
				this.lblResultTong.Text = ToString(Result);
				Result = A.Hieu(A, B);
				this.lblResultHieu.Text = ToString(Result);
				Result = A.Tich(A, B);
				this.lblResultTich.Text = ToString(Result);
				Result = A.Thuong(A, B);
				this.lblResultThuong.Text = ToString(Result);
			}
			catch (Exception ex)
			{
				this.lblError.Text = ex.Message;
			}
		}

		private PhanSo GetInput(String[] a)
		{
			if (a[0] == string.Empty)
			{
				return new PhanSo(0, 1);
			}
			PhanSo A = new();
			if (a.Length > 1)
			{
				A.TuSo = int.Parse(a[0].ToString());
				A.MauSo = int.Parse(a[1].ToString());
			}
			else
			{
				A.TuSo = int.Parse(a[0].ToString());
				A.MauSo = 1;
			}
			return A;
		}

		private string ToString(PhanSo a)
		{
			if (a.MauSo == 0) return "Mẫu số không thể bằng 0";
			if (a.MauSo == 1) return a.TuSo.ToString();
			return a.TuSo.ToString() + "/" + a.MauSo.ToString();
		}
	}
}
