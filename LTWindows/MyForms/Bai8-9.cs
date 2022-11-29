namespace LTWindows
{
	public partial class Bai8 : Form
	{
		MainView? _prev;

		public Bai8()
		{
			InitializeComponent();
		}
		public Bai8(MainView _prev)
		{
			InitializeComponent();
			this._prev = _prev;
		}

		private void Bai8_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (_prev != null)
			{
				_prev.Show();
			}
		}

		private void textBoxBase2_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar != '0' && e.KeyChar != '1' && !char.IsControl(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void textBoxBase10_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private string TransBase10to2(ulong Base)
		{
			string result = "";
			Stack<ulong> temp = new();
			while (Base > 0)
			{
				temp.Push(Base % 2);
				Base /= 2;
			}
			while (temp.Count > 0)
			{
				result += temp.Pop();
			}
			return result;
		}

		private string TranBase2to10(string Base)
		{
			return Convert.ToInt64(Base, 2).ToString();
		}

		private void textBox_TextChanged(object sender, EventArgs e)
		{
			try
			{
				if (this.textBoxBase10.Text != string.Empty)
				{
					this.textBoxResult2.Text = TransBase10to2(ulong.Parse(this.textBoxBase10.Text));
				}
				if (this.textBoxBase2.Text != string.Empty)
				{
					this.textBoxResult10.Text = TranBase2to10(this.textBoxBase2.Text);
				}
			}
			catch
			{
				return;
			}
		}

		private void textBox_KeyUp(object sender, KeyEventArgs e)
		{
			textBox_TextChanged(sender, e);
		}
	}
}
