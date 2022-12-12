using System.Drawing.Drawing2D;

namespace LTWindows
{
    public partial class MainView : Form
    {
        public MainView()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }

        // Setup linear gradient background
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle,
                                                               Color.Gray,
                                                               Color.Black,
                                                               45F))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }

        private void btnBai_Click(object sender, EventArgs e)
        {
            string className = ((Button)sender).Name.Split("btn")[1];
            string objectToInstantiate = "LTWindows." + className + ", LTWindows";

            Type? objectType = Type.GetType(objectToInstantiate);
            Form? instantiatedObject = (Form)Activator.CreateInstance(objectType, this);
            if (instantiatedObject == null)
            {
                MessageBox.Show("Error");
                return;
            }
            instantiatedObject.Show();

            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}