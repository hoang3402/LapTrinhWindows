using System.Numerics;
using LTWindows.Core;

namespace LTWindows
{
    public partial class Bai3 : Form
	{
		readonly MainView? _prev;

		public Bai3(MainView prev)
		{
			InitializeComponent();
			_prev = prev;
		}

		private void Bai3_KeyPress(object sender, KeyPressEventArgs e)
		{
			InputManager.txtb_KeyPress(ref sender, ref e);
		}

		private void btnReset_Click(object sender, EventArgs e)
		{
			this.txtbA.ResetText();
			this.txtbB.ResetText();
			this.lblUCLN.ResetText();
			this.lblBCNN.ResetText();
		}

		private void Giai(int a, int b)
		{
			string gcd = BigInteger.GreatestCommonDivisor(a, b).ToString();
			string lcm = this.BSCNN(a, b).ToString();
			this.lblUCLN.Text = "Ước chung lớn nhất của " + a + " và " + b + " là " + gcd;
			this.lblBCNN.Text = "Bội số chung nhỏ nhất của " + a + " và " + b + " là " + lcm;
		}

		private int BSCNN(int a, int b)
		{
			int result = Math.Max(a, b);

			while (result % a != 0 || result % b != 0)
			{
				result++;
			}

			return result;
		}

		private void btnGiai_Click(object sender, EventArgs e)
		{
			try
			{
				int A = int.Parse(this.txtbA.Text);
				int B = int.Parse(this.txtbB.Text);
				Giai(A, B);
			}
			catch (Exception ex)
			{
				btnReset_Click(sender, e);
				this.lblUCLN.Text = ex.Message;
			}
		}

		private void btnReturn_Click(object sender, EventArgs e)
		{
			this.Close();
			if (this._prev != null) { _prev.Show(); }
		}

		private void Bai3_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (this._prev != null) { _prev.Show(); }
		}
	}
}
