namespace Library
{
    partial class Form2
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Verdana", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(31, 58, 95);
            label1.Location = new Point(49, 38);
            label1.Name = "label1";
            label1.Size = new Size(478, 35);
            label1.TabIndex = 0;
            label1.Text = "Library Management System";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 321);
            panel1.Name = "panel1";
            panel1.Size = new Size(570, 29);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(15, 28, 46);
            panel2.Location = new Point(0, 321);
            panel2.Name = "panel2";
            panel2.Size = new Size(122, 29);
            panel2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(188, 89);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 200);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            timer1.Interval = 20;
            timer1.Tick += timer1_Tick;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 244, 241);
            ClientSize = new Size(570, 350);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
    }
}