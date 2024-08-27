namespace vbGeometry
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnCircle = new Button();
            btnRectangle = new Button();
            btnSquare = new Button();
            btnTriangle = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // btnCircle
            // 
            btnCircle.Anchor = AnchorStyles.None;
            btnCircle.BackColor = Color.Chartreuse;
            btnCircle.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            btnCircle.ForeColor = Color.White;
            btnCircle.Location = new Point(85, 116);
            btnCircle.Margin = new Padding(10);
            btnCircle.MinimumSize = new Size(20, 20);
            btnCircle.Name = "btnCircle";
            btnCircle.Padding = new Padding(10);
            btnCircle.Size = new Size(225, 62);
            btnCircle.TabIndex = 0;
            btnCircle.Text = "Circle";
            btnCircle.UseVisualStyleBackColor = false;
            btnCircle.Click += btnCircle_Click;
            // 
            // btnRectangle
            // 
            btnRectangle.Anchor = AnchorStyles.None;
            btnRectangle.BackColor = Color.Cyan;
            btnRectangle.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            btnRectangle.ForeColor = Color.White;
            btnRectangle.Location = new Point(85, 188);
            btnRectangle.Margin = new Padding(10);
            btnRectangle.MinimumSize = new Size(20, 20);
            btnRectangle.Name = "btnRectangle";
            btnRectangle.Padding = new Padding(10);
            btnRectangle.Size = new Size(225, 62);
            btnRectangle.TabIndex = 1;
            btnRectangle.Text = "Rectangle";
            btnRectangle.UseVisualStyleBackColor = false;
            btnRectangle.Click += btnRectangle_Click;
            // 
            // btnSquare
            // 
            btnSquare.Anchor = AnchorStyles.None;
            btnSquare.BackColor = Color.Fuchsia;
            btnSquare.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            btnSquare.ForeColor = Color.White;
            btnSquare.Location = new Point(85, 261);
            btnSquare.Margin = new Padding(10);
            btnSquare.MinimumSize = new Size(20, 20);
            btnSquare.Name = "btnSquare";
            btnSquare.Padding = new Padding(10);
            btnSquare.Size = new Size(225, 62);
            btnSquare.TabIndex = 2;
            btnSquare.Text = "Square";
            btnSquare.UseVisualStyleBackColor = false;
            btnSquare.Click += btnSquare_Click;
            // 
            // btnTriangle
            // 
            btnTriangle.Anchor = AnchorStyles.None;
            btnTriangle.BackColor = Color.Red;
            btnTriangle.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            btnTriangle.ForeColor = Color.White;
            btnTriangle.Location = new Point(85, 337);
            btnTriangle.Margin = new Padding(10);
            btnTriangle.MinimumSize = new Size(20, 20);
            btnTriangle.Name = "btnTriangle";
            btnTriangle.Padding = new Padding(10);
            btnTriangle.Size = new Size(225, 62);
            btnTriangle.TabIndex = 3;
            btnTriangle.Text = "Triangle";
            btnTriangle.UseVisualStyleBackColor = false;
            btnTriangle.Click += btnTriangle_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackColor = Color.Chartreuse;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = Properties.Resources.dry_clean;
            pictureBox1.Location = new Point(97, 128);
            pictureBox1.Margin = new Padding(10);
            pictureBox1.MinimumSize = new Size(20, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Padding = new Padding(10);
            pictureBox1.Size = new Size(39, 39);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.BackColor = Color.Cyan;
            pictureBox2.BackgroundImageLayout = ImageLayout.None;
            pictureBox2.Image = Properties.Resources.rectangular_shape_outline;
            pictureBox2.Location = new Point(97, 199);
            pictureBox2.Margin = new Padding(10);
            pictureBox2.MinimumSize = new Size(20, 20);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Padding = new Padding(10);
            pictureBox2.Size = new Size(39, 39);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.None;
            pictureBox3.BackColor = Color.Fuchsia;
            pictureBox3.BackgroundImageLayout = ImageLayout.None;
            pictureBox3.Image = Properties.Resources.square;
            pictureBox3.Location = new Point(97, 273);
            pictureBox3.Margin = new Padding(10);
            pictureBox3.MinimumSize = new Size(20, 20);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Padding = new Padding(10);
            pictureBox3.Size = new Size(39, 39);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.None;
            pictureBox4.BackColor = Color.Red;
            pictureBox4.BackgroundImageLayout = ImageLayout.None;
            pictureBox4.Image = Properties.Resources.triangle;
            pictureBox4.Location = new Point(97, 349);
            pictureBox4.Margin = new Padding(10);
            pictureBox4.MinimumSize = new Size(20, 20);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Padding = new Padding(10);
            pictureBox4.Size = new Size(39, 39);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            ClientSize = new Size(384, 539);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnTriangle);
            Controls.Add(btnSquare);
            Controls.Add(btnRectangle);
            Controls.Add(btnCircle);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Geometry";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCircle;
        private Button btnRectangle;
        private Button btnSquare;
        private Button btnTriangle;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}
