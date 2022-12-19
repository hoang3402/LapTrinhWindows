using LTWindows.Core;

namespace LTWindows
{
    public partial class MainView : Form
    {
        public MainView()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!checkEmpty())
            {
                MessageBox.Show("Dữ liệu không được để rỗng!");
                return;
            }

            try
            {
                uint _age = Convert.ToUInt32(txtAge.Text);
                double _salary = Convert.ToDouble(txtSalary.Text);
                Person person = new(txtName.Text, _age, _salary);
                Reset();

                dataGridView.Rows.Add(person.Name, person.Age, person.Salary);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool checkEmpty()
        {
            if (string.IsNullOrEmpty(txtName.Text)) return false;
            if (string.IsNullOrEmpty(txtAge.Text)) return false;
            if (string.IsNullOrEmpty(txtSalary.Text)) return false;

            return true;
        }

        private void Reset()
        {
            txtName.ResetText();
            txtAge.ResetText();
            txtSalary.ResetText();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dataGridView.Rows.Clear();
        }
    }
}