using LTWindows.Core;
using LTWindows.MySubForms;

namespace LTWindows
{
	public partial class Bai12 : Form
	{
		MainView? _prev;
		public List<int> List { get; set; } = new();
		long SumAll = 0, SumOfEven = 0, SumOfOdd = 0;

		public Bai12()
		{
			InitializeComponent();
		}

		public Bai12(MainView prev)
		{
			InitializeComponent();
			this._prev = prev;
		}

		private void Bai12_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (this._prev != null)
			{
				this._prev.Show();
			}
		}

		// -1 => not found
		private int FindMaxPrimeNumber()
		{
			List<int> _list = List;
			_list.Sort();
			for (int i = _list.Count - 1; i >= 0; i--)
			{
				if (Number.isPrimeNumber(_list[i]))
				{
					return _list[i];
				}
			}
			return -1;
		}

		private void SumAllItems()
		{
			this.SumAll = 0;
			this.SumOfEven = 0;
			foreach (int i in List)
			{
				this.SumAll += i;
				this.SumOfEven += (Number.isEven(i) ? i : 0);
			}
			this.SumOfOdd = this.SumAll - this.SumOfEven;
		}

		private void Sort()
		{
			List.Sort();
		}

		private void AddItems(string str)
		{
			try
			{
				string[] temp = str.Split(' ');
				foreach (string item in temp)
				{
					this.List.Add(int.Parse(item));
				}
			}
			catch
			{
				return;
			}
		}

		private void Print()
		{
			this.listViewResult.Items.Clear();
			foreach (int i in List)
			{
				this.listViewResult.Items.Add(i.ToString());
			}
		}

		private void txtbInput_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
				 e.KeyChar != '-' && e.KeyChar != ' ')
			{
				e.Handled = true;
			}

			if (e.KeyChar == (int)13)
			{
				this.OnPress();
			}
		}

		private void OnPress()
		{
			this.AddItems(this.txtbInput.Text);
			this.txtbInput.ResetText();
			this.Print();
			this.SumAllItems();
		}

		private void btnTotal_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Tổng của dãy = " + this.SumAll.ToString());
		}

		private void btnTotalOdd_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Tổng số lẻ của dãy = " + this.SumOfOdd.ToString());
		}

		private void btnTotalEven_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Tổng số chẵn của dãy = " + this.SumOfEven.ToString());
		}

		private void btnReset_Click(object sender, EventArgs e)
		{
			List.Clear();
			this.listViewResult.Clear();
		}

		private void btnSort_Click(object sender, EventArgs e)
		{
			this.Sort();
			this.Print();
		}

		private void btnFindX_Click(object sender, EventArgs e)
		{
			FindPerfectNumber NewBox = new(this);
			NewBox.Show();
		}

		private void btnAVG_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Trung bình cộng các phần tử chia hết cho 3 = " + this.AVG(3).ToString());
		}

		private void btnPrimeNumber_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Số nguyên tố lớn nhất trong dãy là " + this.FindMaxPrimeNumber());
		}

		private void btnMinPerfectNumber_Click(object sender, EventArgs e)
		{
			PerfectNumber NewBox = new(this);
			MessageBox.Show("Số hoàn hảo nhỏ nhất là " + NewBox.Min().ToString());
		}

		private void listViewResult_MouseDoubleClick(object sender, EventArgs e)
		{
			ListView temp = (ListView)sender;
			List.RemoveAt(listViewResult.Items.IndexOf(temp.SelectedItems[0]));
			this.listViewResult.Items.Remove(temp.SelectedItems[0]);
			this.SumAllItems();
		}

		private void btnPerfectNumber_Click(object sender, EventArgs e)
		{
			PerfectNumber NewBox = new(this);
			NewBox.Show();
		}

		private double AVG(int x)
		{
			List<int> result = new();

			foreach (int i in List)
			{
				if (i % x == 0)
				{
					result.Add(i);
				}
			}

			return result.Sum(x => Convert.ToInt32(x)) * 1.0 / result.Count;
		}
	}
}
