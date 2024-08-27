namespace vbGeometry
{
    partial class frmSquare
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
            lblSquare = new Label();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Fuchsia;
            panel2.Controls.Add(lblSquare);
            panel2.Location = new Point(1, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(569, 70);
            panel2.TabIndex = 10;
            // 
            // lblSquare
            // 
            lblSquare.AutoSize = true;
            lblSquare.BackColor = Color.Fuchsia;
            lblSquare.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSquare.ForeColor = Color.White;
            lblSquare.Location = new Point(255, 23);
            lblSquare.Name = "lblSquare";
            lblSquare.Size = new Size(73, 21);
            lblSquare.TabIndex = 0;
            lblSquare.Text = "SQUARE";
            // 
            // frmSquare
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(571, 331);
            Controls.Add(panel2);
            Name = "frmSquare";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Square";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label lblSquare;
    }
}