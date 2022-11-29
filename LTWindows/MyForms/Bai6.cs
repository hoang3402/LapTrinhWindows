namespace LTWindows
{
	public partial class Bai6 : Form
	{
		MainView? _prev;

		public Bai6()
		{
			InitializeComponent();
		}

		public Bai6(MainView _prev)
		{
			InitializeComponent();
			this._prev = _prev;
		}

		private void Bai6_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (this._prev != null) { _prev.Show(); }
		}

		private void Giai()
		{
			for (int i = 2; i < 10; i++)
			{
				ListBox _cur;
				switch (i)
				{
					case 2:
						{
							_cur = this.listBox2;
							break;
						}
					case 3:
						{
							_cur = this.listBox3;
							break;
						}
					case 4:
						{
							_cur = this.listBox4;
							break;
						}
					case 5:
						{
							_cur = this.listBox5;
							break;
						}
					case 6:
						{
							_cur = this.listBox6;
							break;
						}
					case 7:
						{
							_cur = this.listBox7;
							break;
						}
					case 8:
						{
							_cur = this.listBox8;
							break;
						}
					case 9:
						{
							_cur = this.listBox9;
							break;
						}
					default:
						{
							_cur = this.listBox2;
							break;
						}
				}
				for (int j = 1; j <= 10; j++)
				{
					string temp = "";
					temp = i + " * " + j + " = " + i * j;
					_cur.Items.Add(temp);
				}
			}
		}

		private void Bai6_Activated(object sender, EventArgs e)
		{
			Giai();
		}

		private void btnReturn_Click(object sender, EventArgs e)
		{
			this.Close();
			if (_prev != null) _prev.Show();
		}
	}
}
