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
            txtTResult = new TextBox();
            txtBase = new TextBox();
            lblResult = new Label();
            lblBase = new Label();
            panel1 = new Panel();
            txtHeight = new TextBox();
            lblHeight = new Label();
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
            btnClear.Click += btnClear_Click;
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
            // txtTResult
            // 
            txtTResult.Anchor = AnchorStyles.None;
            txtTResult.BackColor = Color.White;
            txtTResult.BorderStyle = BorderStyle.None;
            txtTResult.Enabled = false;
            txtTResult.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTResult.Location = new Point(301, 171);
            txtTResult.Name = "txtTResult";
            txtTResult.Size = new Size(245, 22);
            txtTResult.TabIndex = 33;
            // 
            // txtBase
            // 
            txtBase.Anchor = AnchorStyles.None;
            txtBase.BackColor = Color.White;
            txtBase.BorderStyle = BorderStyle.None;
            txtBase.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBase.Location = new Point(301, 106);
            txtBase.Name = "txtBase";
            txtBase.Size = new Size(246, 22);
            txtBase.TabIndex = 32;
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
            // lblBase
            // 
            lblBase.Anchor = AnchorStyles.None;
            lblBase.AutoSize = true;
            lblBase.BackColor = Color.White;
            lblBase.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblBase.Location = new Point(222, 105);
            lblBase.Name = "lblBase";
            lblBase.Size = new Size(56, 21);
            lblBase.TabIndex = 30;
            lblBase.Text = "BASE :";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(txtHeight);
            panel1.Controls.Add(lblHeight);
            panel1.Location = new Point(206, 101);
            panel1.Name = "panel1";
            panel1.Size = new Size(353, 95);
            panel1.TabIndex = 37;
            // 
            // txtHeight
            // 
            txtHeight.BackColor = Color.White;
            txtHeight.BorderStyle = BorderStyle.None;
            txtHeight.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtHeight.Location = new Point(95, 37);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(246, 22);
            txtHeight.TabIndex = 21;
            // 
            // lblHeight
            // 
            lblHeight.AutoSize = true;
            lblHeight.BackColor = Color.White;
            lblHeight.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblHeight.Location = new Point(16, 37);
            lblHeight.Name = "lblHeight";
            lblHeight.Size = new Size(75, 21);
            lblHeight.TabIndex = 21;
            lblHeight.Text = "HEIGHT :";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackColor = Color.White;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = Properties.Resources.trianglesss;
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
            Controls.Add(txtTResult);
            Controls.Add(txtBase);
            Controls.Add(lblResult);
            Controls.Add(lblBase);
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
        private TextBox txtTResult;
        private TextBox txtBase;
        private Label lblResult;
        private Label lblBase;
        private Panel panel1;
        private TextBox txtHeight;
        private Label lblHeight;
        private PictureBox pictureBox1;
    }
}