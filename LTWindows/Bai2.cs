using LTWindows.Core;

namespace LTWindows
{
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void Bai2_Load(object sender, EventArgs e)
        {
            dataGridView.Columns.Add("MSSV", "Mã số sinh viên");
            dataGridView.Columns.Add("HT", "Họ tên");
            dataGridView.Columns.Add("Phai", "Phái");
            dataGridView.Columns.Add("SDT", "Số điện thoại");

            // Format Column size
            foreach (DataGridViewTextBoxColumn a in dataGridView.Columns)
            {
                a.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (dataGridView.Rows.Count > 1)
            {
                int selectedRowIndex = dataGridView.SelectedCells[0].RowIndex;
                dataGridView.Rows.RemoveAt(selectedRowIndex);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!checkEmpty())
            {
                MessageBox.Show("Không được để rỗng!");
                return;
            }
            string mssv = txtMSSV.Text;
            string hoten = txtHoTen.Text;
            string phai = txtPhai.Text;
            string sdt = txtSDT.Text;
            reset();
            SinhVien temp = new(mssv, hoten, phai, sdt);
            dataGridView.Rows.Add(temp.MSSV, temp.HoTen, temp.Phai, temp.Sdt);
        }

        private void reset()
        {
            string[] controlNames = { "txtMSSV", "txtHoTen", "txtPhai", "txtSDT" };
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

        private bool checkEmpty()
        {
            string[] strings = { txtMSSV.Text, txtHoTen.Text, txtPhai.Text, txtSDT.Text };
            if (strings.All(str => String.IsNullOrWhiteSpace(str)))
            {
                return false;
            }
            return true;
        }

        private void Bai2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
