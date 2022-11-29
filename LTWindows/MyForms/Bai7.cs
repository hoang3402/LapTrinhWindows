using LTWindows.Core;

namespace LTWindows
{
    public partial class Bai7 : Form
	{
		MainView? _prev;

		public Bai7()
		{
			InitializeComponent();
		}

		public Bai7(MainView _prev)
		{
			InitializeComponent();
			this._prev = _prev;
		}

		private void txtb_Press(object sender, KeyPressEventArgs e)
		{
			InputManager.txtb_KeyPress(ref sender, ref e);
		}

		private void Bai7_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (_prev != null)
			{
				_prev.Show();
			}
		}

		private void Giai(int a, int b, int c)
		{
			if (a < b + c && b < a + c && c < a + b)
			{
				if (a < b + c && b < a + c && c < a + b)
				{
					if (a * a == b * b + c * c || b * b == a * a + c * c || c * c == a * a + b * b)
					{
						this.lblResult.Text = "Đây là tam giác vuông";
					}
					else if (a == b && b == c)
					{
						this.lblResult.Text = "Đây là tam giác đều";
					}
					else if (a == b || a == c || b == c)
					{
						this.lblResult.Text = "Đây là tam giác cân";
					}
					else if (a * a > b * b + c * c || b * b > a * a + c * c || c * c > a * a + b * b)
						this.lblResult.Text = "Đây là tam giac tù";
				}
				else
					this.lblResult.Text = "Đây là tam giac nhọn";
			}
			else
			{
				this.lblResult.Text = "Không phải là tam giác";
			}
		}

		private void btnGiai_Click(object sender, EventArgs e)
		{
			try
			{
				int a = int.Parse(this.txtbA.Text);
				int b = int.Parse(this.txtbB.Text);
				int c = int.Parse(this.txtbC.Text);
				Giai(a, b, c);
			}
			catch (Exception ex)
			{
				this.lblResult.Text = ex.Message;
			}
		}
	}
}
