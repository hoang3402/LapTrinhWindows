using LTWindows.Core;
using System.Drawing.Drawing2D;

namespace LTWindows
{
	public partial class Bai1 : Form
	{
		private MainView? _prev;
		public Bai1() => InitializeComponent();

		public Bai1(MainView prev)
		{
			InitializeComponent();
			_prev = prev;
		}

		// Setup linear gradient background
		protected override void OnPaintBackground(PaintEventArgs e)
		{
			using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle,
															   Color.Gray,
															   Color.Blue,
															   -45F))
			{
				e.Graphics.FillRectangle(brush, this.ClientRectangle);
			}
		}

		private void btnConfirm_Click(object sender, EventArgs e)
		{
			try
			{
				int A = this.txtbA.Text == string.Empty ? 0 : int.Parse(this.txtbA.Text);
				int B = this.txtbB.Text == string.Empty ? 0 : int.Parse(this.txtbB.Text);
				resultX.Text = GiaiPhuongTrinhBac1(A, B);
			}
			catch (Exception ex)
			{
				this.resultX.Text = ex.Message;
			}
		}

		public string GiaiPhuongTrinhBac1(int a, int b)
		{
			if (a == 0 && b == 0)
			{
				return "Phương trình vô số nghiệm";
			}
			if (a == 0)
			{
				return "Phương trình vô nghiệm";
			}
			if (b == 0)
			{
				return "X = 0";
			}

			string result = "X = ";
			double _res = (-b * 1.0 / a);
			if ((int)_res != _res)
			{
				result += -b + " / " + a;
				result += " = " + _res;
			}
			else
			{
				result += _res;
			}
			return result;
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
		}

		private void btnReturnPrev_Click(object sender, EventArgs e)
		{
			this.Close();
			if (this._prev != null) { _prev.Show(); }
		}

		private void Bai1_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (this._prev != null) { _prev.Show(); }
		}
	}
}
