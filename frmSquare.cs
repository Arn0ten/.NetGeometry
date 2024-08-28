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
    public partial class frmSquare : Form
    {
        public frmSquare()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnArea_Click(object sender, EventArgs e)
        {

            int sideA, sideB, area, parseValue;

            if (txtSideA.Text == "" || txtSideB.Text == "" || !int.TryParse(txtSideA.Text, out parseValue) || !int.TryParse(txtSideB.Text, out parseValue))
            {
                btnClear_Click(sender, e);
                MessageBox.Show("Input Valid Input");
            }
            else
            {
                sideA = Convert.ToInt32(txtSideA.Text);
                sideB = Convert.ToInt32(txtSideB.Text);

                area = sideA * sideB;

                txtSResult.Text = area.ToString();
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSideA.Clear();
            txtSideB.Clear();
            txtSResult.Clear();
        }
    }
}
