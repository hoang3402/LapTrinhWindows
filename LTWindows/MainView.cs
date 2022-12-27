using System.Data;

namespace LTWindows
{
    public partial class MainView : Form
    {
        DataTable dataTable = new();

        public MainView()
        {
            InitializeComponent();
        }

        private void btKetThuc_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cbLoaiMonAn_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbLoaiMonAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstMonAn.Items.Clear();

            string? Choose = cbLoaiMonAn.SelectedItem.ToString();
            if (String.IsNullOrEmpty(Choose))
            {
                return;
            }
            if (Choose == "Pháp")
            {
                lstMonAn.Items.Add("Ớt trộn mù tạc");
                lstMonAn.Items.Add("Dầu xối mỡ");
                return;
            }
            if (Choose == "Trung Quốc")
            {
                lstMonAn.Items.Add("Vịt Tiềm");
                lstMonAn.Items.Add("Hủ Tiếu");
                lstMonAn.Items.Add("Nước Mắm Xào Giòn");
                return;
            }
            if (Choose == "Ý")
            {
                lstMonAn.Items.Add("Bolognese");
                lstMonAn.Items.Add("Mì Ý - Spaghetti");
                lstMonAn.Items.Add("Lasagne");
                return;
            }
            if (Choose == "Việt Nam")
            {
                lstMonAn.Items.Add("Muối Chấm Nước Mắm");
                lstMonAn.Items.Add("Cá Kho Tộ");
                return;
            }
        }

        private void MainView_Load(object sender, EventArgs e)
        {
            cbLoaiMonAn_SelectedIndexChanged(sender, e);
            dataTable.Columns.Add(new DataColumn("Tên món ăn", typeof(string)));
            dataTable.Columns.Add(new DataColumn("Số lượng", typeof(decimal)));
            dgMonAnChon.DataSource = dataTable;
            foreach (DataGridViewColumn i in dgMonAnChon.Columns)
            {
                i.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void btChon_Click(object sender, EventArgs e)
        {
            if (lstMonAn.SelectedItem is null)
            {
                MessageBox.Show("Xin mời chọn món");
                return;
            }
            string? ten = lstMonAn.SelectedItem.ToString();
            decimal sl = txtSoLuong.Value;
            AddFood(ten, sl);
        }

        private void btBoChon_Click(object sender, EventArgs e)
        {
            if (dgMonAnChon.CurrentRow is null)
            {
                return;
            }
            dataTable.Rows.RemoveAt(dgMonAnChon.CurrentRow.Index);
        }

        private void btChonLai_Click(object sender, EventArgs e)
        {
            dataTable.Rows.Clear();
        }

        private void lstMonAn_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (((ListBox)sender).SelectedItem is null)
            {
                return;
            }
            string? Choose = ((ListBox)sender).SelectedItem.ToString();
            decimal sl = txtSoLuong.Value;
            AddFood(Choose, sl);
        }

        private void AddFood(string FoodName = "null", decimal Number = 1)
        {
            foreach (DataGridViewRow item in dgMonAnChon.Rows)
            {
                if (item.Cells[0].Value != null && FoodName == item.Cells[0].Value.ToString())
                {
                    item.Cells[1].Value = (Decimal)item.Cells[1].Value + Number;
                    return;
                }
            }
            dataTable.Rows.Add(FoodName, Number);
        }

        private void lstMonAn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)13)
            {
                btChon_Click(sender, e);
            }
        }
    }
}