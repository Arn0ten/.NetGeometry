using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.MonthCalendar;

namespace vbGeometry
{
    public partial class frmCircle : Form
    {
        public frmCircle()
        {
            InitializeComponent();
        }

        private void frmCircle_Load(object sender, EventArgs e)
        {

        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            double radius, area;
            radius = Convert.ToDouble(txtRadius.Text);
            area = Math.PI * (Math.Sqrt(radius));
            txtCResult.Text = Convert.ToString(area);
            txtRadius.Clear();
        }

        private void btnCircumference_Click(object sender, EventArgs e)
        {

            double radius, circ;
            radius = Convert.ToDouble(txtRadius.Text);
            circ = 2 * Math.PI * radius;
            txtCResult.Text = Convert.ToString(circ);
            txtRadius.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtRadius.Clear();
            txtCResult.Clear();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Form1 Check = new Form1();
            Check.ShowDialog();
        }
    }
}
