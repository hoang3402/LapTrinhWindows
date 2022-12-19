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
            dataGridView.Rows.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!checkEmpty())
            {
                MessageBox.Show("Không được để rỗng!");
                return;
            }
        }

        private bool checkEmpty()
        {
            if (String.IsNullOrEmpty(txtMSSV.Text)) return false;
            if (String.IsNullOrEmpty(txtHoTen.Text)) return false;
            if (String.IsNullOrEmpty(txtPhai.Text)) return false;
            if (String.IsNullOrEmpty(txtSDT.Text)) return false;

            return true;
        }
    }
}
