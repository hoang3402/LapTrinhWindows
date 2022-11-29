using LTWindows.Core;

namespace LTWindows.MySubForms
{
	public partial class PerfectNumber : Form
	{
		Bai12 main;

		public PerfectNumber(Bai12 main)
		{
			InitializeComponent();
			this.main = main;
		}

		private void PerfectNumber_Load(object sender, EventArgs e)
		{
			foreach (int i in main.List)
			{
				if (Number.isPerfectNumber(i) && this.listBox1.Items.IndexOf(i) == -1)
				{
					this.listBox1.Items.Add(i);
				}
			}
			if (this.listBox1.Items.Count == 0)
			{
				this.listBox1.Items.Add("Không tìm thấy số hoàn hảo nào!");
			}
		}

		public int Min()
		{
			main.List.Sort();
			foreach (int i in main.List)
			{
				if (Number.isPerfectNumber(i))
				{
					return i;
				}
			}
			return -1;
		}
	}
}
