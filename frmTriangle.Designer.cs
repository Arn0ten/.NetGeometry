namespace vbGeometry
{
    partial class frmTriangle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel2 = new Panel();
            lblTriangle = new Label();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Red;
            panel2.Controls.Add(lblTriangle);
            panel2.Location = new Point(1, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(569, 70);
            panel2.TabIndex = 10;
            // 
            // lblTriangle
            // 
            lblTriangle.AutoSize = true;
            lblTriangle.BackColor = Color.Red;
            lblTriangle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTriangle.ForeColor = Color.White;
            lblTriangle.Location = new Point(260, 23);
            lblTriangle.Name = "lblTriangle";
            lblTriangle.Size = new Size(86, 21);
            lblTriangle.TabIndex = 0;
            lblTriangle.Text = "TRIANGLE";
            // 
            // frmTriangle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(571, 331);
            Controls.Add(panel2);
            Name = "frmTriangle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Triangle";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label lblTriangle;
    }
}