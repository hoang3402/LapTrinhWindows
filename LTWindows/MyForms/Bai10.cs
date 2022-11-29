using LTWindows.Core;

namespace LTWindows
{
    public partial class Bai10 : Form
	{
		MainView? _prev;

		public Bai10()
		{
			InitializeComponent();
		}

		public Bai10(MainView? prev)
		{
			InitializeComponent();
			this._prev = prev;
		}

		private void Bai10_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (this._prev != null)
			{
				this._prev.Show();
			}
		}

		private void txtbNumber_Click(object sender, EventArgs e)
		{
			listBoxResult.Items.Clear();
			try
			{
				long a = long.Parse(txtbNumber.Text);
				listBoxResult.Items.Add(a + " là số " + (Number.isEven(a) ? "chẵn" : "lẻ"));
				listBoxResult.Items.Add(a + " là số " + (Number.isPositive(a) ? "dương" : "âm"));
				listBoxResult.Items.Add(a + " là " + (Number.isPerfectNumber(a) ? "số hoàn hảo" : "không phải là số hoàn hảo"));
				listBoxResult.Items.Add(a + " là " + (Number.isPrimeNumber(a) ? "số nguyên tố" : "không phải số nguyên tố"));
				listBoxResult.Items.Add("Tổng các ước của " + a + " là " + Number.TotalDivisor(a).ToString());
				listBoxResult.Items.Add(a + " là " + (Number.isFibonacciNumber(a) ? "số Fibonacci" : "không phải số Fibonacci"));
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Lỗi");
				txtbNumber.ResetText();
			}
		}

		private void txtbNumber_KeyPress(object sender, KeyPressEventArgs e)
		{
			InputManager.txtb_KeyPress(ref sender, ref e);
			if (e.KeyChar == (int)13)
			{
				txtbNumber_Click(sender, e);
			}
		}
	}
}
