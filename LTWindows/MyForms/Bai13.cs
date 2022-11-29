using LTWindows.Core;

namespace LTWindows.MyForms
{
	public partial class Bai13 : Form
	{
		MainView? _prev;
		Matrix? a;

		public Bai13(MainView prev)
		{
			InitializeComponent();
			_prev = prev;
		}

		private void Bai13_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (_prev != null)
			{
				_prev.Show();
			}
		}

		private void btnCreateMatrix_Click(object sender, EventArgs e)
		{
			int SoDong;
			int SoCot;

			if (this.checkBoxMatrixSquare.Checked == true)
			{
				SoCot = int.Parse(txtbCot.Text);
				SoDong = SoCot;
			}
			else
			{
				SoDong = int.Parse(txtbDong.Text);
				SoCot = int.Parse(txtbCot.Text);
			}

			a = new(SoDong, SoCot);
			this.tabPage2.Controls.Clear();
			DisplayMatrix(a);
			this.tabControlViewMatrix.SelectTab(1);
		}

		private void DisplayMatrix(Matrix a)
		{
			for (int i = 0; i < a.SoDong; i++)
			{
				for (int j = 0; j < a.SoCot; j++)
				{
					TextBox newTxtb = new TextBox();

					newTxtb.Name = i.ToString() + " " + j.ToString();
					newTxtb.Size = new Size(45, 35);
					newTxtb.Location = new Point(50 * i, 40 * j);
					newTxtb.KeyPress += new KeyPressEventHandler((sender, e) => InputManager.txtb_KeyPress(ref sender, ref e));
					newTxtb.TextChanged += new EventHandler(ChangeData);

					this.tabPage2.Controls.Add(newTxtb);
				}
			}
		}

		private void ChangeData(object sender, EventArgs e)
		{
			string[] temp = ((TextBox)sender).Name.Split(" ");
			int SoDong = int.Parse(temp[0]);
			int SoCot = int.Parse(temp[1]);

			a.matrix[SoDong, SoCot] = int.Parse(((TextBox)sender).Text);
		}

		private void checkBoxMatrixSquare_CheckedChanged(object sender, EventArgs e)
		{
			if (((CheckBox)sender).Checked == true)
			{
				txtbDong.Enabled = false;
			}
			else
			{
				txtbDong.Enabled = true;
			}
		}

		private void btnTotal_Click(object sender, EventArgs e)
		{
			if (CheckNull()) return;
			if (!a.isSquare)
			{
				MessageBox.Show("Chỉ áp dụng cho ma trận vuông!");
				return;
			}

			string resultRightToLeft = a.TotalDiagonalRightToLeft(a).ToString();
			string resultLeftToRight = a.TotalDiagonalLeftToRight(a).ToString();
			MessageBox.Show("Tổng đường chéo chính = " + resultRightToLeft + "\nTổng đường chéo phụ = " + resultLeftToRight);
		}

		private bool CheckNull()
		{
			if (a is null)
			{
				MessageBox.Show("Ma trận rỗng!");
				return true;
			}
			return false;
		}
	}
}
