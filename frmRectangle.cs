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
    public partial class frmRectangle : Form
    {
        public frmRectangle()
        {
            InitializeComponent();
        }

        private void txtResult_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnArea_Click(object sender, EventArgs e)
        {
            int length, width, area;
            
            if (txtLength.Text == "")
            {
                MessageBox.Show("Input Length or Width.");
            }
            else
            {
                length = Convert.ToInt32(txtLength.Text);
                width = Convert.ToInt32(txtWidth.Text);
                area = length * width;
                txtRResult.Text = Convert.ToString(area);
            }


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtLength.Clear();
            txtWidth.Clear();
            txtRResult.Clear();
        }
        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
