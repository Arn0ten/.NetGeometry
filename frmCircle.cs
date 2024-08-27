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
            if (txtRadius.Text == "")
            {
                MessageBox.Show("Input Radius");
            }
            else
            {
                radius = Convert.ToDouble(txtRadius.Text);
                area = Math.PI * radius * radius;
                txtCResult.Text = Convert.ToString(area);
            }
            
        }

        private void btnCircumference_Click(object sender, EventArgs e)
        {
            double radius, circ;
            if(txtRadius.Text == "")
            {
                MessageBox.Show("Input Radius");
            }
            else
            {
                radius = Convert.ToDouble(txtRadius.Text);
                circ = 2 * Math.PI * radius;
                txtCResult.Text = Convert.ToString(circ);
            }
 
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtRadius.Clear();
            txtCResult.Clear();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
