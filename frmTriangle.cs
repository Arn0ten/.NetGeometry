using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vbGeometry
{
    public partial class frmTriangle : Form
    {
        public frmTriangle()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            int parseValue;

            if (txtBase.Text == "" || txtHeight.Text == "" || !int.TryParse(txtBase.Text, out parseValue) || !int.TryParse(txtHeight.Text, out parseValue))
            {
                btnClear_Click(sender, e);
                MessageBox.Show("Input Valid Input");
            }
            else
            {
                double area, height, Base;

                Base = Convert.ToDouble(txtBase.Text);
                height = Convert.ToDouble(txtHeight.Text);

                area = 0.5 * Base * height;

                txtTResult.Text = area.ToString();
            }
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBase.Clear();
            txtHeight.Clear();
            txtTResult.Clear();
        }
    }
}
