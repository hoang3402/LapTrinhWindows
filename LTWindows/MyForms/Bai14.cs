using LTWindows.Core;

namespace LTWindows
{
    public partial class Bai14 : Form
    {
        MainView _prev;
        Matrix? A;
        Matrix? B;

        public Bai14(MainView prev)
        {
            InitializeComponent();
            _prev = prev;
        }

        private void btnCreateMatrixA_Click(object sender, EventArgs e)
        {
            int SoDong;
            int SoCot;

            if (this.checkBoxMatrixSquareA.Checked == true)
            {
                SoCot = int.Parse(txtbCotA.Text);
                SoDong = SoCot;
            }
            else
            {
                SoDong = int.Parse(txtbDongA.Text);
                SoCot = int.Parse(txtbCotA.Text);
            }

            A = new(SoDong, SoCot);
            this.tabPage2.Controls.Clear();
            DisplayMatrix(A, this.tabPage2);
            this.tabControl.SelectTab(this.tabPage2);
        }

        private void txt_keyPress(object sender, KeyPressEventArgs e)
        {
            InputManager.txtb_KeyPress(ref sender, ref e);
        }

        private void ChangeData(object sender, EventArgs e, Matrix a)
        {
            try
            {
                string[] temp = ((TextBox)sender).Name.Split(" ");
                int SoDong = int.Parse(temp[0]);
                int SoCot = int.Parse(temp[1]);

                a.matrix[SoDong, SoCot] = int.Parse(((TextBox)sender).Text);
            }
            catch
            {
                MessageBox.Show("Không được để trống!");
                return;
            }
        }

        private void DisplayMatrix(Matrix a, TabPage page)
        {
            for (int i = 0; i < a.SoDong; i++)
            {
                for (int j = 0; j < a.SoCot; j++)
                {
                    TextBox newTxtb = new TextBox();

                    newTxtb.Name = i.ToString() + " " + j.ToString();
                    newTxtb.Size = new Size(45, 35);
                    newTxtb.Location = new Point(50 * i, 40 * j);
                    newTxtb.KeyPress += new KeyPressEventHandler(txt_keyPress);
                    newTxtb.TextChanged += new EventHandler((sender, e) => ChangeData(sender, e, a));

                    page.Controls.Add(newTxtb);
                }
            }
        }

        private void DisplayResultMatrix(Matrix a, TabPage page)
        {
            for (int i = 0; i < a.SoDong; i++)
            {
                for (int j = 0; j < a.SoCot; j++)
                {
                    TextBox newTxtb = new TextBox();

                    newTxtb.Text = a.matrix[i, j].ToString();
                    newTxtb.Size = new Size(45, 35);
                    newTxtb.Location = new Point(50 * i, 40 * j);
                    newTxtb.Enabled = false;

                    page.Controls.Add(newTxtb);
                }
            }
        }

        private void btnCreateMatrixB_Click(object sender, EventArgs e)
        {
            int SoDong;
            int SoCot;

            if (this.checkBoxMatrixSquareB.Checked == true)
            {
                SoCot = int.Parse(txtbCotB.Text);
                SoDong = SoCot;
            }
            else
            {
                SoDong = int.Parse(txtbDongB.Text);
                SoCot = int.Parse(txtbCotB.Text);
            }

            B = new(SoDong, SoCot);
            this.tabPage2.Controls.Clear();
            DisplayMatrix(B, this.tabPage3);
            this.tabControl.SelectTab(this.tabPage3);
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            if (A is null)
            {
                MessageBox.Show("Ma trận hiện tại đang rỗng!");
                return;
            }
            Matrix temp = Matrix.Multiplication(A, B);
            if (temp != null)
            {
                this.tabControl.TabPages.Add(new TabPage("Kết quả tích 2 ma trận"));
                DisplayResultMatrix(temp, this.tabControl.TabPages[this.tabControl.TabPages.Count - 1]);
                this.tabControl.SelectTab(this.tabControl.TabPages.Count - 1);
            }
            else
            {
                MessageBox.Show("Kết quả rỗng!");
            }
        }

        private void Bai14_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_prev != null)
            {
                _prev.Show();
            }
        }

        private void btnPlusMatrix_Click(object sender, EventArgs e)
        {
            if (A is null)
            {
                MessageBox.Show("Ma trận hiện tại đang rỗng!");
                return;
            }
            Matrix temp = Matrix.Plus(A, B);
            if (temp != null)
            {
                this.tabControl.TabPages.Add(new TabPage("Kết quả tổng 2 ma trận"));
                DisplayResultMatrix(temp, this.tabControl.TabPages[this.tabControl.TabPages.Count - 1]);
                this.tabControl.SelectTab(this.tabControl.TabPages.Count - 1);
            }
            else
            {
                MessageBox.Show("Kết quả rỗng!");
            }
        }
    }
}
