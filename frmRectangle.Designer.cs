namespace vbGeometry
{
    partial class frmRectangle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRectangle));
            panel2 = new Panel();
            lblRectangle = new Label();
            pictureBox1 = new PictureBox();
            btnMenu = new Button();
            btnClear = new Button();
            btnArea = new Button();
            txtRResult = new TextBox();
            txtLength = new TextBox();
            lblResult = new Label();
            lblLength = new Label();
            panel1 = new Panel();
            txtWidth = new TextBox();
            lblWidth = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Cyan;
            panel2.Controls.Add(lblRectangle);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(571, 70);
            panel2.TabIndex = 10;
            // 
            // lblRectangle
            // 
            lblRectangle.Anchor = AnchorStyles.None;
            lblRectangle.AutoSize = true;
            lblRectangle.BackColor = Color.Cyan;
            lblRectangle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRectangle.ForeColor = Color.White;
            lblRectangle.Location = new Point(256, 22);
            lblRectangle.Name = "lblRectangle";
            lblRectangle.Size = new Size(99, 21);
            lblRectangle.TabIndex = 0;
            lblRectangle.Text = "RECTANGLE";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackColor = Color.White;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = Properties.Resources.rectangle;
            pictureBox1.Location = new Point(11, 100);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(189, 165);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // btnMenu
            // 
            btnMenu.Anchor = AnchorStyles.None;
            btnMenu.Location = new Point(432, 251);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(127, 42);
            btnMenu.TabIndex = 18;
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
            btnClear.TabIndex = 16;
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
            btnArea.TabIndex = 15;
            btnArea.Text = "Area";
            btnArea.UseVisualStyleBackColor = true;
            btnArea.Click += btnArea_Click;
            // 
            // txtRResult
            // 
            txtRResult.Anchor = AnchorStyles.None;
            txtRResult.BackColor = Color.White;
            txtRResult.BorderStyle = BorderStyle.None;
            txtRResult.Enabled = false;
            txtRResult.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtRResult.Location = new Point(301, 171);
            txtRResult.Name = "txtRResult";
            txtRResult.Size = new Size(245, 22);
            txtRResult.TabIndex = 14;
            txtRResult.TextChanged += txtResult_TextChanged;
            // 
            // txtLength
            // 
            txtLength.Anchor = AnchorStyles.None;
            txtLength.BackColor = Color.White;
            txtLength.BorderStyle = BorderStyle.None;
            txtLength.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtLength.Location = new Point(301, 104);
            txtLength.Name = "txtLength";
            txtLength.Size = new Size(246, 22);
            txtLength.TabIndex = 13;
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
            lblResult.TabIndex = 12;
            lblResult.Text = "RESULT  :";
            // 
            // lblLength
            // 
            lblLength.Anchor = AnchorStyles.None;
            lblLength.AutoSize = true;
            lblLength.BackColor = Color.White;
            lblLength.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblLength.Location = new Point(222, 105);
            lblLength.Name = "lblLength";
            lblLength.Size = new Size(78, 21);
            lblLength.TabIndex = 11;
            lblLength.Text = "LENGTH :";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(txtWidth);
            panel1.Controls.Add(lblWidth);
            panel1.Location = new Point(206, 101);
            panel1.Name = "panel1";
            panel1.Size = new Size(353, 95);
            panel1.TabIndex = 19;
            // 
            // txtWidth
            // 
            txtWidth.BackColor = Color.White;
            txtWidth.BorderStyle = BorderStyle.None;
            txtWidth.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtWidth.Location = new Point(95, 37);
            txtWidth.Name = "txtWidth";
            txtWidth.Size = new Size(246, 22);
            txtWidth.TabIndex = 21;
            // 
            // lblWidth
            // 
            lblWidth.AutoSize = true;
            lblWidth.BackColor = Color.White;
            lblWidth.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblWidth.Location = new Point(16, 37);
            lblWidth.Name = "lblWidth";
            lblWidth.Size = new Size(77, 21);
            lblWidth.TabIndex = 21;
            lblWidth.Text = "WIDTH   :";
            // 
            // frmRectangle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(571, 331);
            Controls.Add(pictureBox1);
            Controls.Add(btnMenu);
            Controls.Add(btnClear);
            Controls.Add(btnArea);
            Controls.Add(txtRResult);
            Controls.Add(txtLength);
            Controls.Add(lblResult);
            Controls.Add(lblLength);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmRectangle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Rectangle";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label lblRectangle;
        private PictureBox pictureBox1;
        private Button btnMenu;
        private Button btnClear;
        private Button btnArea;
        private TextBox txtRResult;
        private TextBox txtLength;
        private Label lblResult;
        private Label lblLength;
        private Panel panel1;
        private TextBox txtWidth;
        private Label lblWidth;
    }
}