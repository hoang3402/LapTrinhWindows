using System.Data;

namespace LTWindows
{
    public partial class frmNhanvien : Form
    {
        private DataTable db = new();
        DataGridViewRow? current;

        public frmNhanvien()
        {
            InitializeComponent();
        }

        private void frmNhanvien_Load(object sender, EventArgs e)
        {
            string[] items = { "Họ tên", "Ngày sinh", "Địa chỉ", "Điện thoại" };
            foreach (string i in items)
            {
                db.Columns.Add(new DataColumn(i, typeof(string)));
            }
            db.PrimaryKey = new DataColumn[] { db.Columns["Họ Tên"] };
            dataGridView.DataSource = db;

            foreach (DataGridViewColumn i in dataGridView.Columns)
            {
                i.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!isEmpty()) return;
            Add();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (db.Rows.Count <= 0)
            {
                MessageBox.Show("Không có gì đễ xóa!");
                return;
            }
            dataGridView.Rows.RemoveAt(dataGridView.CurrentRow.Index);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (current is null)
            {
                MessageBox.Show("Không có gì để sửa!");
                return;
            }

            current.Cells["Họ tên"].Value = txtHoTen.Text;
            current.Cells["Điện thoại"].Value = txtSDT.Text;
            current.Cells["Địa chỉ"].Value = txtDiaChi.Text;
            current.Cells["Ngày sinh"].Value = DatePick.Text;
        }

        private bool isEmpty()
        {
            if (string.IsNullOrEmpty(txtHoTen.Text)) return false;
            if (string.IsNullOrEmpty(txtDiaChi.Text)) return false;
            if (string.IsNullOrEmpty(txtSDT.Text)) return false;
            return true;
        }

        private void Add()
        {
            try
            {
                string ten = txtHoTen.Text;
                string sdt = txtSDT.Text;
                string diachi = txtDiaChi.Text;
                string dateTime = DatePick.Text;
                db.Rows.Add(ten, dateTime, diachi, sdt);
            }
            catch (Exception ex)
            {
                if (ex.TargetSite is not null &&
                    ex.TargetSite.DeclaringType is not null &&
                    ex.TargetSite.DeclaringType.Name == "UniqueConstraint")
                {
                    MessageBox.Show("Bạn đã nhập người này rồi!");
                    return;
                }
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            current = dataGridView.CurrentRow;

            txtHoTen.Text = current.Cells["Họ Tên"].Value.ToString();
            txtDiaChi.Text = current.Cells["Địa chỉ"].Value.ToString();
            txtSDT.Text = current.Cells["Điện thoại"].Value.ToString();
            DatePick.Value = DateTime.Parse(current.Cells["Ngày sinh"].Value.ToString());
        }
    }
}
