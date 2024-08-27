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
            //Hide Form 1
            this.Hide();
            //Instance sa form 2
            frmCircle FormCircle = new frmCircle();
            //show form 2
            FormCircle.ShowDialog();
            //dispose 
            FormCircle = null;
            //show and form 1 if i close ang form 2
            this.Show();        
        }

        private void btnRectangle_Click(object sender, EventArgs e)
        {
            //Hide Form 1
            this.Hide();
            //Instance sa form circle
            frmRectangle FormRectangle = new frmRectangle();
            //show form circle
            FormRectangle.ShowDialog();
            //dispose 
            FormRectangle = null;
            //show and form 1 if i close ang form circle
            this.Show();
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSquare FormSquare = new frmSquare();
            FormSquare.ShowDialog();
            FormSquare = null;
            this.Show();
        }

        private void btnTriangle_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTriangle FormTriangle = new frmTriangle();
            FormTriangle.ShowDialog();
            FormTriangle = null;
            this.Show();
        }
    }
}
