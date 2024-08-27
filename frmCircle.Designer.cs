namespace vbGeometry
{
    partial class frmCircle
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
            lblRadius = new Label();
            label2 = new Label();
            txtRadius = new TextBox();
            txtCResult = new TextBox();
            btnArea = new Button();
            btnClear = new Button();
            btnCircumference = new Button();
            btnMenu = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            lblCircle = new Label();
            pictureBox1 = new PictureBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblRadius
            // 
            lblRadius.AutoSize = true;
            lblRadius.BackColor = Color.White;
            lblRadius.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblRadius.Location = new Point(223, 111);
            lblRadius.Name = "lblRadius";
            lblRadius.Size = new Size(75, 21);
            lblRadius.TabIndex = 0;
            lblRadius.Text = "RADIUS :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(223, 159);
            label2.Name = "label2";
            label2.Size = new Size(72, 21);
            label2.TabIndex = 1;
            label2.Text = "RESULT :";
            // 
            // txtRadius
            // 
            txtRadius.BackColor = Color.White;
            txtRadius.BorderStyle = BorderStyle.None;
            txtRadius.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtRadius.Location = new Point(302, 112);
            txtRadius.Name = "txtRadius";
            txtRadius.Size = new Size(246, 22);
            txtRadius.TabIndex = 2;
            // 
            // txtCResult
            // 
            txtCResult.BackColor = Color.White;
            txtCResult.BorderStyle = BorderStyle.None;
            txtCResult.Enabled = false;
            txtCResult.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCResult.Location = new Point(301, 158);
            txtCResult.Name = "txtCResult";
            txtCResult.Size = new Size(246, 22);
            txtCResult.TabIndex = 3;
            // 
            // btnArea
            // 
            btnArea.Location = new Point(292, 203);
            btnArea.Name = "btnArea";
            btnArea.Size = new Size(127, 42);
            btnArea.TabIndex = 4;
            btnArea.Text = "Area";
            btnArea.UseVisualStyleBackColor = true;
            btnArea.Click += btnArea_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(292, 252);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(127, 42);
            btnClear.TabIndex = 5;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnCircumference
            // 
            btnCircumference.Location = new Point(433, 203);
            btnCircumference.Name = "btnCircumference";
            btnCircumference.Size = new Size(127, 42);
            btnCircumference.TabIndex = 6;
            btnCircumference.Text = "Circumference";
            btnCircumference.UseVisualStyleBackColor = true;
            btnCircumference.Click += btnCircumference_Click;
            // 
            // btnMenu
            // 
            btnMenu.Location = new Point(433, 252);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(127, 42);
            btnMenu.TabIndex = 7;
            btnMenu.Text = "Back to menu.";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Location = new Point(207, 102);
            panel1.Name = "panel1";
            panel1.Size = new Size(353, 95);
            panel1.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Chartreuse;
            panel2.Controls.Add(lblCircle);
            panel2.Location = new Point(1, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(569, 70);
            panel2.TabIndex = 9;
            // 
            // lblCircle
            // 
            lblCircle.AutoSize = true;
            lblCircle.BackColor = Color.Chartreuse;
            lblCircle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCircle.ForeColor = Color.White;
            lblCircle.Location = new Point(277, 22);
            lblCircle.Name = "lblCircle";
            lblCircle.Size = new Size(62, 21);
            lblCircle.TabIndex = 0;
            lblCircle.Text = "CIRCLE";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = Properties.Resources.Screenshot_2024_08_27_162622;
            pictureBox1.Location = new Point(12, 101);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(189, 165);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // frmCircle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            ClientSize = new Size(571, 331);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Controls.Add(btnMenu);
            Controls.Add(btnCircumference);
            Controls.Add(btnClear);
            Controls.Add(btnArea);
            Controls.Add(txtCResult);
            Controls.Add(txtRadius);
            Controls.Add(label2);
            Controls.Add(lblRadius);
            Controls.Add(panel1);
            Name = "frmCircle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Circle";
            Load += frmCircle_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRadius;
        private Label label2;
        private TextBox txtRadius;
        private TextBox txtCResult;
        private Button btnArea;
        private Button btnClear;
        private Button btnCircumference;
        private Button btnMenu;
        private Panel panel1;
        private Panel panel2;
        private Label lblCircle;
        private PictureBox pictureBox1;
    }
}