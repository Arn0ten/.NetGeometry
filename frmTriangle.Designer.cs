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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTriangle));
            panel2 = new Panel();
            lblTriangle = new Label();
            btnMenu = new Button();
            btnClear = new Button();
            btnArea = new Button();
            txtSResult = new TextBox();
            txtSideA = new TextBox();
            lblResult = new Label();
            lblSideA = new Label();
            panel1 = new Panel();
            txtSideB = new TextBox();
            lblSideB = new Label();
            pictureBox1 = new PictureBox();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Red;
            panel2.Controls.Add(lblTriangle);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(571, 70);
            panel2.TabIndex = 10;
            // 
            // lblTriangle
            // 
            lblTriangle.Anchor = AnchorStyles.None;
            lblTriangle.AutoSize = true;
            lblTriangle.BackColor = Color.Red;
            lblTriangle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTriangle.ForeColor = Color.White;
            lblTriangle.Location = new Point(261, 23);
            lblTriangle.Name = "lblTriangle";
            lblTriangle.Size = new Size(86, 21);
            lblTriangle.TabIndex = 0;
            lblTriangle.Text = "TRIANGLE";
            // 
            // btnMenu
            // 
            btnMenu.Anchor = AnchorStyles.None;
            btnMenu.Location = new Point(432, 251);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(127, 42);
            btnMenu.TabIndex = 36;
            btnMenu.Text = "Back to menu.";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.None;
            btnClear.Location = new Point(291, 251);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(127, 42);
            btnClear.TabIndex = 35;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnArea
            // 
            btnArea.Anchor = AnchorStyles.None;
            btnArea.Location = new Point(291, 202);
            btnArea.Name = "btnArea";
            btnArea.Size = new Size(268, 42);
            btnArea.TabIndex = 34;
            btnArea.Text = "Area";
            btnArea.UseVisualStyleBackColor = true;
            btnArea.Click += btnArea_Click;
            // 
            // txtSResult
            // 
            txtSResult.Anchor = AnchorStyles.None;
            txtSResult.BackColor = Color.White;
            txtSResult.BorderStyle = BorderStyle.None;
            txtSResult.Enabled = false;
            txtSResult.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSResult.Location = new Point(301, 171);
            txtSResult.Name = "txtSResult";
            txtSResult.Size = new Size(245, 22);
            txtSResult.TabIndex = 33;
            // 
            // txtSideA
            // 
            txtSideA.Anchor = AnchorStyles.None;
            txtSideA.BackColor = Color.White;
            txtSideA.BorderStyle = BorderStyle.None;
            txtSideA.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSideA.Location = new Point(301, 106);
            txtSideA.Name = "txtSideA";
            txtSideA.Size = new Size(246, 22);
            txtSideA.TabIndex = 32;
            // 
            // lblResult
            // 
            lblResult.Anchor = AnchorStyles.None;
            lblResult.AutoSize = true;
            lblResult.BackColor = Color.White;
            lblResult.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblResult.Location = new Point(222, 171);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(76, 21);
            lblResult.TabIndex = 31;
            lblResult.Text = "RESULT  :";
            // 
            // lblSideA
            // 
            lblSideA.Anchor = AnchorStyles.None;
            lblSideA.AutoSize = true;
            lblSideA.BackColor = Color.White;
            lblSideA.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblSideA.Location = new Point(222, 105);
            lblSideA.Name = "lblSideA";
            lblSideA.Size = new Size(66, 21);
            lblSideA.TabIndex = 30;
            lblSideA.Text = "SIDE A :";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(txtSideB);
            panel1.Controls.Add(lblSideB);
            panel1.Location = new Point(206, 101);
            panel1.Name = "panel1";
            panel1.Size = new Size(353, 95);
            panel1.TabIndex = 37;
            // 
            // txtSideB
            // 
            txtSideB.BackColor = Color.White;
            txtSideB.BorderStyle = BorderStyle.None;
            txtSideB.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSideB.Location = new Point(95, 37);
            txtSideB.Name = "txtSideB";
            txtSideB.Size = new Size(246, 22);
            txtSideB.TabIndex = 21;
            // 
            // lblSideB
            // 
            lblSideB.AutoSize = true;
            lblSideB.BackColor = Color.White;
            lblSideB.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblSideB.Location = new Point(16, 37);
            lblSideB.Name = "lblSideB";
            lblSideB.Size = new Size(69, 21);
            lblSideB.TabIndex = 21;
            lblSideB.Text = "SIDE B  :";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackColor = Color.White;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Location = new Point(11, 100);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(189, 165);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 38;
            pictureBox1.TabStop = false;
            // 
            // frmTriangle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(571, 331);
            Controls.Add(pictureBox1);
            Controls.Add(btnMenu);
            Controls.Add(btnClear);
            Controls.Add(btnArea);
            Controls.Add(txtSResult);
            Controls.Add(txtSideA);
            Controls.Add(lblResult);
            Controls.Add(lblSideA);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmTriangle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Triangle";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label lblTriangle;
        private Button btnMenu;
        private Button btnClear;
        private Button btnArea;
        private TextBox txtSResult;
        private TextBox txtSideA;
        private Label lblResult;
        private Label lblSideA;
        private Panel panel1;
        private TextBox txtSideB;
        private Label lblSideB;
        private PictureBox pictureBox1;
    }
}