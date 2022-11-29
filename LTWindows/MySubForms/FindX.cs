using LTWindows.Core;

namespace LTWindows.MySubForms
{
	public partial class FindPerfectNumber : Form
	{
		Bai12 Main;

		public FindPerfectNumber(Bai12 main)
		{
			InitializeComponent();
			Main = main;
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			try
			{
				bool check = false;
				int result = 0;
				int temp = int.Parse(this.textBox1.Text);
				foreach (int i in Main.List)
				{
					result++;
					if (i == temp)
					{
						check = true;
						MessageBox.Show("Có số " + i + " trong dãy số bạn nhập"
							+ "\nSố " + i + " nằm ở vị trí thứ " + result);
						break;
					}
				}
				if (!check)
				{
					MessageBox.Show("Không có số bạn vừa nhập!");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
		{
			InputManager.txtb_KeyPress(ref sender, ref e);
			if (e.KeyChar == (int)13)
			{
				btnOK_Click(sender, e);
			}
		}
	}
}
