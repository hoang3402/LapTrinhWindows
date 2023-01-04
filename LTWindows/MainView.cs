using System.Data;

namespace LTWindows
{
    public partial class MainView : Form
    {
        DataTable db = new();

        public MainView()
        {
            InitializeComponent();
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            string nameFood = ((Button)sender).Text;
            var temp = db.Rows.Find(nameFood);
            if (temp != null)
            {
                temp["Số lượng"] = (int)temp["Số lượng"] + 1;
            }
            else
            {
                db.Rows.Add(nameFood, 1);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (db.Rows.Count <= 0)
            {
                MessageBox.Show("Không có gì đễ xóa!");
                return;
            }
            dataGridView.Rows.RemoveAt(dataGridView.CurrentRow.Index);
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (comboBoxTable.SelectedIndex == -1)
            {
                MessageBox.Show("Hãy chọn bàn!");
                return;
            }
            if (dataGridView.Rows.Count <= 1)
            {
                MessageBox.Show("Hãy chọn món!");
                return;
            }

            db.Rows.Clear();
            MessageBox.Show("Order thành công!");
        }

        private void MainView_Load(object sender, EventArgs e)
        {
            db.Columns.Add(new DataColumn("Tên món", typeof(string)));
            db.Columns.Add(new DataColumn("Số lượng", typeof(int)));
            db.PrimaryKey = new DataColumn[] { db.Columns["Tên món"] };

            dataGridView.DataSource = db;

            foreach (DataGridViewColumn i in dataGridView.Columns)
            {
                i.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
    }
}