namespace LTWindows
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void ShowForm(Type formType)
        {
            Form form = (Form)Activator.CreateInstance(formType);
            form.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowForm(typeof(Bai1));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowForm(typeof(Bai2));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShowForm(typeof(Bai3));
        }
    }
}
