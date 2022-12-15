namespace LTWindows
{
    public partial class MainView : Form
    {
        public MainView()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Info_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Trường đại học Yersin Đà Lạt" +
                "\nNguyễn Văn Hoàng - 12101005" +
                "\nLớp CNTT K18", "Thông tin tác giả");
        }

        private void ClickEvent(object sender, EventArgs e)
        {
            string _Name = ((ToolStripMenuItem)sender).Name;
            if (string.IsNullOrEmpty(_Name)) { return; }

            string objectToInstantiate = "LTWindows." + _Name + ", LTWindows";

            Type? objectType = Type.GetType(objectToInstantiate);
            if (objectType == null) { return; }
            Form? instantiatedObject = (Form)Activator.CreateInstance(objectType, this);
            if (instantiatedObject == null)
            {
                MessageBox.Show("Error");
                return;
            }
            instantiatedObject.Show();
        }
    }
}