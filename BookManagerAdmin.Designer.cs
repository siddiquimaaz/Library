namespace Library
{
    partial class BookManagerAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookManagerAdmin));
            panel1 = new Panel();
            BackBtn = new FontAwesome.Sharp.IconButton();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            submitBtn = new FontAwesome.Sharp.IconButton();
            dateTimePicker = new DateTimePicker();
            Genre = new TextBox();
            ISBNNo = new TextBox();
            BookAuthor = new TextBox();
            BooKNameAdmin = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            label7 = new Label();
            label8 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(77, 100, 141);
            panel1.Controls.Add(ISBNNo);
            panel1.Controls.Add(BookAuthor);
            panel1.Controls.Add(BooKNameAdmin);
            panel1.Controls.Add(BackBtn);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(submitBtn);
            panel1.Controls.Add(dateTimePicker);
            panel1.Controls.Add(Genre);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(198, 127);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(955, 532);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // BackBtn
            // 
            BackBtn.BackColor = Color.FromArgb(61, 90, 128);
            BackBtn.FlatStyle = FlatStyle.Flat;
            BackBtn.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BackBtn.ForeColor = Color.White;
            BackBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            BackBtn.IconColor = Color.Black;
            BackBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BackBtn.Location = new Point(15, 483);
            BackBtn.Margin = new Padding(3, 4, 3, 4);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(86, 33);
            BackBtn.TabIndex = 1;
            BackBtn.Text = "Back";
            BackBtn.UseVisualStyleBackColor = false;
            BackBtn.Click += BackBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(613, 117);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(255, 331);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(234, 41);
            label6.Name = "label6";
            label6.Size = new Size(520, 45);
            label6.TabIndex = 5;
            label6.Text = "Add A Book in Database";
            // 
            // submitBtn
            // 
            submitBtn.BackColor = Color.FromArgb(31, 43, 62);
            submitBtn.FlatStyle = FlatStyle.Flat;
            submitBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            submitBtn.ForeColor = Color.White;
            submitBtn.IconChar = FontAwesome.Sharp.IconChar.Upload;
            submitBtn.IconColor = Color.White;
            submitBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            submitBtn.IconSize = 32;
            submitBtn.ImageAlign = ContentAlignment.MiddleLeft;
            submitBtn.Location = new Point(227, 391);
            submitBtn.Margin = new Padding(3, 4, 3, 4);
            submitBtn.Name = "submitBtn";
            submitBtn.Size = new Size(158, 46);
            submitBtn.TabIndex = 10;
            submitBtn.Text = "Submit";
            submitBtn.UseVisualStyleBackColor = false;
            submitBtn.Click += submitBtn_Click_1;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(227, 283);
            dateTimePicker.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(237, 27);
            dateTimePicker.TabIndex = 9;
            // 
            // Genre
            // 
            Genre.ForeColor = Color.FromArgb(31, 43, 62);
            Genre.Location = new Point(227, 319);
            Genre.Margin = new Padding(3, 4, 3, 4);
            Genre.Name = "Genre";
            Genre.Size = new Size(171, 27);
            Genre.TabIndex = 8;
            // 
            // ISBNNo
            // 
            ISBNNo.BorderStyle = BorderStyle.FixedSingle;
            ISBNNo.ForeColor = Color.FromArgb(31, 43, 62);
            ISBNNo.Location = new Point(227, 244);
            ISBNNo.Margin = new Padding(3, 4, 3, 4);
            ISBNNo.Name = "ISBNNo";
            ISBNNo.Size = new Size(237, 27);
            ISBNNo.TabIndex = 7;
            // 
            // BookAuthor
            // 
            BookAuthor.BorderStyle = BorderStyle.FixedSingle;
            BookAuthor.ForeColor = Color.FromArgb(31, 43, 62);
            BookAuthor.Location = new Point(227, 205);
            BookAuthor.Margin = new Padding(3, 4, 3, 4);
            BookAuthor.Name = "BookAuthor";
            BookAuthor.Size = new Size(237, 27);
            BookAuthor.TabIndex = 6;
            // 
            // BooKNameAdmin
            // 
            BooKNameAdmin.BorderStyle = BorderStyle.FixedSingle;
            BooKNameAdmin.ForeColor = Color.FromArgb(31, 43, 62);
            BooKNameAdmin.Location = new Point(227, 168);
            BooKNameAdmin.Margin = new Padding(3, 4, 3, 4);
            BooKNameAdmin.Name = "BooKNameAdmin";
            BooKNameAdmin.Size = new Size(237, 27);
            BooKNameAdmin.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(51, 283);
            label5.Name = "label5";
            label5.Size = new Size(136, 23);
            label5.TabIndex = 4;
            label5.Text = "Publication Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(51, 321);
            label4.Name = "label4";
            label4.Size = new Size(56, 23);
            label4.TabIndex = 3;
            label4.Text = "Genre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(51, 252);
            label3.Name = "label3";
            label3.Size = new Size(78, 23);
            label3.TabIndex = 2;
            label3.Text = "ISBN NO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(51, 216);
            label2.Name = "label2";
            label2.Size = new Size(106, 23);
            label2.TabIndex = 1;
            label2.Text = "Book Author";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(51, 179);
            label1.Name = "label1";
            label1.Size = new Size(85, 23);
            label1.TabIndex = 0;
            label1.Text = "Book Title";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(55, 67, 87);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1370, 48);
            panel2.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(3, 13);
            label7.Name = "label7";
            label7.Size = new Size(617, 20);
            label7.TabIndex = 1;
            label7.Text = "Library Management System | Admin Panel | Book Management";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.ImeMode = ImeMode.NoControl;
            label8.Location = new Point(1339, 13);
            label8.Name = "label8";
            label8.Size = new Size(19, 20);
            label8.TabIndex = 17;
            label8.Text = "X";
            label8.Click += label8_Click;
            // 
            // BookManagerAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 28, 46);
            ClientSize = new Size(1370, 710);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "BookManagerAdmin";
            Text = "BookManagegerAdmin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker dateTimePicker;
        private TextBox Genre;
        private TextBox ISBNNo;
        private TextBox BookAuthor;
        private TextBox BooKNameAdmin;
        private Label label6;
        private FontAwesome.Sharp.IconButton submitBtn;
        private FontAwesome.Sharp.IconButton BackBtn;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label label7;
        private Label label8;
    }
}