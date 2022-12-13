namespace LTWindows
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnBai1_Click(object sender, EventArgs e)
        {
            Bai1 a = new();
            a.Show();
            this.Hide();
        }

        private void btnBai2_Click(object sender, EventArgs e)
        {
            Bai2 a = new();
            a.Show();
            this.Hide();
        }
    }
}
