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
            panel2 = new Panel();
            lblRectangle = new Label();
            pictureBox1 = new PictureBox();
            btnMenu = new Button();
            btnCircumference = new Button();
            btnClear = new Button();
            btnArea = new Button();
            txtRResult = new TextBox();
            txtRadius = new TextBox();
            lblResult = new Label();
            lblWidth = new Label();
            panel1 = new Panel();
            lblHeight = new Label();
            txtHeight = new TextBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Cyan;
            panel2.Controls.Add(lblRectangle);
            panel2.Location = new Point(2, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(569, 70);
            panel2.TabIndex = 10;
            // 
            // lblRectangle
            // 
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
            pictureBox1.BackColor = Color.White;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = Properties.Resources.Screenshot_2024_08_27_162622;
            pictureBox1.Location = new Point(11, 100);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(189, 165);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // btnMenu
            // 
            btnMenu.Location = new Point(432, 251);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(127, 42);
            btnMenu.TabIndex = 18;
            btnMenu.Text = "Back to menu.";
            btnMenu.UseVisualStyleBackColor = true;
            // 
            // btnCircumference
            // 
            btnCircumference.Location = new Point(432, 202);
            btnCircumference.Name = "btnCircumference";
            btnCircumference.Size = new Size(127, 42);
            btnCircumference.TabIndex = 17;
            btnCircumference.Text = "Circumference";
            btnCircumference.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(291, 251);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(127, 42);
            btnClear.TabIndex = 16;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnArea
            // 
            btnArea.Location = new Point(291, 202);
            btnArea.Name = "btnArea";
            btnArea.Size = new Size(127, 42);
            btnArea.TabIndex = 15;
            btnArea.Text = "Area";
            btnArea.UseVisualStyleBackColor = true;
            // 
            // txtRResult
            // 
            txtRResult.BackColor = Color.White;
            txtRResult.BorderStyle = BorderStyle.None;
            txtRResult.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtRResult.Location = new Point(300, 171);
            txtRResult.Name = "txtRResult";
            txtRResult.Size = new Size(246, 22);
            txtRResult.TabIndex = 14;
            txtRResult.TextChanged += txtResult_TextChanged;
            // 
            // txtRadius
            // 
            txtRadius.BackColor = Color.White;
            txtRadius.BorderStyle = BorderStyle.None;
            txtRadius.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtRadius.Location = new Point(301, 104);
            txtRadius.Name = "txtRadius";
            txtRadius.Size = new Size(246, 22);
            txtRadius.TabIndex = 13;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.BackColor = Color.White;
            lblResult.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblResult.Location = new Point(222, 171);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(72, 21);
            lblResult.TabIndex = 12;
            lblResult.Text = "RESULT :";
            // 
            // lblWidth
            // 
            lblWidth.AutoSize = true;
            lblWidth.BackColor = Color.White;
            lblWidth.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblWidth.Location = new Point(222, 105);
            lblWidth.Name = "lblWidth";
            lblWidth.Size = new Size(69, 21);
            lblWidth.TabIndex = 11;
            lblWidth.Text = "WIDTH :";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(txtHeight);
            panel1.Controls.Add(lblHeight);
            panel1.Location = new Point(206, 101);
            panel1.Name = "panel1";
            panel1.Size = new Size(353, 95);
            panel1.TabIndex = 19;
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
            lblHeight.Text = "HIEGHT :";
            // 
            // txtHeight
            // 
            txtHeight.BackColor = Color.White;
            txtHeight.BorderStyle = BorderStyle.None;
            txtHeight.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtHeight.Location = new Point(87, 37);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(254, 22);
            txtHeight.TabIndex = 21;
            // 
            // frmRectangle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(571, 331);
            Controls.Add(pictureBox1);
            Controls.Add(btnMenu);
            Controls.Add(btnCircumference);
            Controls.Add(btnClear);
            Controls.Add(btnArea);
            Controls.Add(txtRResult);
            Controls.Add(txtRadius);
            Controls.Add(lblResult);
            Controls.Add(lblWidth);
            Controls.Add(panel1);
            Controls.Add(panel2);
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
        private Button btnCircumference;
        private Button btnClear;
        private Button btnArea;
        private TextBox txtRResult;
        private TextBox txtRadius;
        private Label lblResult;
        private Label lblWidth;
        private Panel panel1;
        private TextBox txtHeight;
        private Label lblHeight;
    }
}