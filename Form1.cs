namespace vbGeometry
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            frmCircle Check = new frmCircle();
            Check.ShowDialog();
        }

        private void btnRectangle_Click(object sender, EventArgs e)
        {
            frmRectangle Check = new frmRectangle();
            Check.ShowDialog();
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            frmSquare Check = new frmSquare();
            Check.ShowDialog();
        }

        private void btnTriangle_Click(object sender, EventArgs e)
        {
            frmTriangle Check = new frmTriangle();
            Check.ShowDialog();
        }
    }
}
