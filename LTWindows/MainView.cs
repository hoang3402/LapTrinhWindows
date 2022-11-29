using LTWindows.MyForms;
using System.Drawing.Drawing2D;

namespace LTWindows
{
	public partial class MainView : Form
	{
		public MainView()
		{
			InitializeComponent();
			DoubleBuffered = true;
		}

		// Setup linear gradient background
		protected override void OnPaintBackground(PaintEventArgs e)
		{
			using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle,
															   Color.Gray,
															   Color.Black,
															   45F))
			{
				e.Graphics.FillRectangle(brush, this.ClientRectangle);
			}
		}

		private void btnBai1_Click(object sender, EventArgs e)
		{
			Bai1 bai1 = new(this);
			bai1.Show();
			this.Hide();
		}

		private void btnBai2_Click(object sender, EventArgs e)
		{
			Bai2 bai2 = new(this);
			bai2.Show();
			this.Hide();
		}

		private void btnBai3_Click(object sender, EventArgs e)
		{
			Bai3 bai3 = new(this);
			bai3.Show();
			this.Hide();
		}

		private void btnBai4_Click(object sender, EventArgs e)
		{
			Bai4 bai4 = new(this);
			bai4.Show();
			this.Hide();
		}

		private void btnBai6_Click(object sender, EventArgs e)
		{
			Bai6 bai6 = new(this);
			bai6.Show();
			this.Hide();
		}

		private void btnBai7_Click(object sender, EventArgs e)
		{
			Bai7 bai7 = new(this);
			bai7.Show();
			this.Hide();
		}

		private void btnBai8_Click(object sender, EventArgs e)
		{
			Bai8 bai8 = new(this);
			bai8.Show();
			this.Hide();
		}

		private void btnBai10_Click(object sender, EventArgs e)
		{
			Bai10 bai10 = new(this);
			bai10.Show();
			this.Hide();
		}

		private void btnBai12_Click(object sender, EventArgs e)
		{
			Bai12 bai12 = new(this);
			bai12.Show();
			this.Hide();
		}

		private void btnBai13_Click(object sender, EventArgs e)
		{
			Bai13 bai13 = new(this);
			bai13.Show();
			this.Hide();
		}

		private void btnBai14_Click(object sender, EventArgs e)
		{
			Bai14 bai14 = new(this);
			bai14.Show();
			this.Hide();
		}
	}
}