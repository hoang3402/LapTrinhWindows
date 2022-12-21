using LTWindows.Core;

namespace LTWindows
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Bai3_Load(object sender, EventArgs e)
        {
            string[,] columns = {
                {"MSSV", "Mã số sinh viên"},
                {"HT", "Họ và tên"},
                {"SDT", "Số điện thoại"},
                {"Phai", "Phái"},
                {"Toan", "Toán"},
                {"Hoa", "Hóa"},
                {"Ly", "Lý"},
                {"TB", "TB"}
            };

            for (int i = 0; i < columns.GetLength(0); i++)
            {
                dataGridView.Columns.Add(columns[i, 0], columns[i, 1]);
            }

            // Format Column size
            foreach (DataGridViewTextBoxColumn a in dataGridView.Columns)
            {
                a.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void Bai3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!checkEmpty())
            {
                MessageBox.Show("Không được để rỗng!");
                return;
            }
            try
            {
                string mssv = txtMSSV.Text;
                string hoten = txtHoTen.Text;
                string phai = txtPhai.Text;
                string sdt = txtSDT.Text;
                double toan = Convert.ToDouble(txtToan.Text);
                double ly = Convert.ToDouble(txtLy.Text);
                double hoa = Convert.ToDouble(txtHoa.Text);
                reset();
                HocSinh temp = new(mssv, hoten, phai, sdt, toan, hoa, ly);
                dataGridView.Rows.Add(temp.MaHV, temp.HoTen, temp.SoDT, temp.Phai, temp.Toan, temp.Ly, temp.Hoa, temp.Tb.ToString("f2"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool checkEmpty()
        {
            string[] strings = { txtMSSV.Text, txtHoTen.Text, txtPhai.Text, txtSDT.Text, txtToan.Text, txtHoa.Text, txtLy.Text };
            if (strings.All(str => String.IsNullOrWhiteSpace(str)))
            {
                return false;
            }
            return true;
        }

        private void reset()
        {
            string[] controlNames = { "txtMSSV", "txtHoTen", "txtPhai", "txtSDT", "txtToan", "txtLy", "txtHoa", "txtDTB" };
            foreach (string name in controlNames)
            {
                Control control = this.Controls[name];
                if (control is TextBox)
                {
                    ((TextBox)control).ResetText();
                }
                else if (control is ComboBox)
                {
                    ((ComboBox)control).ResetText();
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (dataGridView.Rows.Count > 1)
            {
                int selectedRowIndex = dataGridView.SelectedCells[0].RowIndex;
                dataGridView.Rows.RemoveAt(selectedRowIndex);
            }
        }

        private void txtDiemSo_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtToan.Text.Length < 1) return;
            if (txtHoa.Text.Length < 1) return;
            if (txtLy.Text.Length < 1) return;
            double a = Convert.ToDouble(txtToan.Text);
            double b = Convert.ToDouble(txtHoa.Text);
            double c = Convert.ToDouble(txtLy.Text);
            txtDTB.Text = Diem.getTB(a, b, c).ToString("f2");
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dataGridView.Rows[e.RowIndex].Cells[0].Value is null) return;

            DataGridViewRow temp = dataGridView.Rows[e.RowIndex];
            txtMSSV.Text = temp.Cells[0].Value.ToString();
            txtHoTen.Text = temp.Cells[1].Value.ToString();
            txtPhai.Text = temp.Cells[2].Value.ToString();
            txtSDT.Text = temp.Cells[3].Value.ToString();
            txtToan.Text = temp.Cells[4].Value.ToString();
            txtHoa.Text = temp.Cells[5].Value.ToString();
            txtLy.Text = temp.Cells[6].Value.ToString();
            txtDTB.Text = temp.Cells[7].Value.ToString();
        }

        private void txtPhai_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
