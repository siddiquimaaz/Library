﻿namespace Library
{
    partial class AdminBorrowedBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminBorrowedBook));
            panel2 = new Panel();
            DeleteBoorowBookBtn = new FontAwesome.Sharp.IconButton();
            BorrowBookSearch = new FontAwesome.Sharp.IconButton();
            BorrowedBook = new TextBox();
            Bookname = new Label();
            BorrowBookBackBtn = new Button();
            BorrowedBookAdminPanel = new DataGridView();
            panel1 = new Panel();
            label4 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BorrowedBookAdminPanel).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(31, 58, 95);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(DeleteBoorowBookBtn);
            panel2.Controls.Add(BorrowBookSearch);
            panel2.Controls.Add(BorrowedBook);
            panel2.Controls.Add(Bookname);
            panel2.Controls.Add(BorrowBookBackBtn);
            panel2.Location = new Point(7, 41);
            panel2.Name = "panel2";
            panel2.Size = new Size(293, 664);
            panel2.TabIndex = 18;
            panel2.Paint += panel2_Paint;
            // 
            // DeleteBoorowBookBtn
            // 
            DeleteBoorowBookBtn.BackColor = Color.FromArgb(15, 28, 46);
            DeleteBoorowBookBtn.FlatStyle = FlatStyle.Flat;
            DeleteBoorowBookBtn.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            DeleteBoorowBookBtn.ForeColor = Color.White;
            DeleteBoorowBookBtn.IconChar = FontAwesome.Sharp.IconChar.FileCircleXmark;
            DeleteBoorowBookBtn.IconColor = Color.White;
            DeleteBoorowBookBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            DeleteBoorowBookBtn.ImageAlign = ContentAlignment.MiddleLeft;
            DeleteBoorowBookBtn.Location = new Point(18, 402);
            DeleteBoorowBookBtn.Name = "DeleteBoorowBookBtn";
            DeleteBoorowBookBtn.Size = new Size(200, 52);
            DeleteBoorowBookBtn.TabIndex = 29;
            DeleteBoorowBookBtn.Text = "Retrieve Book";
            DeleteBoorowBookBtn.UseVisualStyleBackColor = false;
            DeleteBoorowBookBtn.Click += DeleteBoorowBookBtn_Click;
            // 
            // BorrowBookSearch
            // 
            BorrowBookSearch.BackColor = Color.FromArgb(31, 43, 62);
            BorrowBookSearch.Cursor = Cursors.Hand;
            BorrowBookSearch.FlatStyle = FlatStyle.Flat;
            BorrowBookSearch.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            BorrowBookSearch.ForeColor = Color.White;
            BorrowBookSearch.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            BorrowBookSearch.IconColor = Color.White;
            BorrowBookSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BorrowBookSearch.IconSize = 20;
            BorrowBookSearch.ImageAlign = ContentAlignment.MiddleLeft;
            BorrowBookSearch.Location = new Point(18, 327);
            BorrowBookSearch.Margin = new Padding(3, 2, 3, 2);
            BorrowBookSearch.Name = "BorrowBookSearch";
            BorrowBookSearch.Padding = new Padding(1);
            BorrowBookSearch.Size = new Size(77, 25);
            BorrowBookSearch.TabIndex = 28;
            BorrowBookSearch.Text = "Search";
            BorrowBookSearch.TextAlign = ContentAlignment.MiddleRight;
            BorrowBookSearch.UseVisualStyleBackColor = false;
            BorrowBookSearch.Click += BorrowBookSearch_Click;
            // 
            // BorrowedBook
            // 
            BorrowedBook.BackColor = Color.White;
            BorrowedBook.Cursor = Cursors.IBeam;
            BorrowedBook.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            BorrowedBook.Location = new Point(18, 292);
            BorrowedBook.Name = "BorrowedBook";
            BorrowedBook.PlaceholderText = "Enter Book Name";
            BorrowedBook.Size = new Size(209, 21);
            BorrowedBook.TabIndex = 27;
            BorrowedBook.TextAlign = HorizontalAlignment.Center;
            // 
            // Bookname
            // 
            Bookname.AutoSize = true;
            Bookname.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            Bookname.ForeColor = Color.White;
            Bookname.Location = new Point(16, 275);
            Bookname.Name = "Bookname";
            Bookname.Size = new Size(107, 13);
            Bookname.TabIndex = 20;
            Bookname.Text = "Enter Book Name";
            // 
            // BorrowBookBackBtn
            // 
            BorrowBookBackBtn.BackColor = Color.FromArgb(224, 224, 224);
            BorrowBookBackBtn.FlatStyle = FlatStyle.Flat;
            BorrowBookBackBtn.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            BorrowBookBackBtn.Location = new Point(14, 629);
            BorrowBookBackBtn.Name = "BorrowBookBackBtn";
            BorrowBookBackBtn.Size = new Size(75, 23);
            BorrowBookBackBtn.TabIndex = 25;
            BorrowBookBackBtn.Text = "Back";
            BorrowBookBackBtn.UseVisualStyleBackColor = false;
            BorrowBookBackBtn.Click += BorrowBookBackBtn_Click;
            // 
            // BorrowedBookAdminPanel
            // 
            BorrowedBookAdminPanel.BackgroundColor = Color.White;
            BorrowedBookAdminPanel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BorrowedBookAdminPanel.Location = new Point(308, 42);
            BorrowedBookAdminPanel.Name = "BorrowedBookAdminPanel";
            BorrowedBookAdminPanel.RowHeadersWidth = 51;
            BorrowedBookAdminPanel.RowTemplate.Height = 25;
            BorrowedBookAdminPanel.Size = new Size(1054, 663);
            BorrowedBookAdminPanel.TabIndex = 19;
            BorrowedBookAdminPanel.CellContentClick += BorrowedBookAdminPanel_CellContentClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(55, 67, 87);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(2, 1, 2, 1);
            panel1.Size = new Size(1370, 36);
            panel1.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(7, 8);
            label4.Name = "label4";
            label4.Size = new Size(456, 16);
            label4.TabIndex = 17;
            label4.Text = "Library Management System | Admin Panel | Borrowed Books";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(1371, 8);
            label1.Name = "label1";
            label1.Size = new Size(15, 15);
            label1.TabIndex = 14;
            label1.Text = "X";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(53, 71);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(183, 155);
            pictureBox1.TabIndex = 30;
            pictureBox1.TabStop = false;
            // 
            // AdminBorrowedBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 28, 46);
            ClientSize = new Size(1370, 710);
            Controls.Add(panel1);
            Controls.Add(BorrowedBookAdminPanel);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminBorrowedBook";
            Text = "S";
            WindowState = FormWindowState.Maximized;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BorrowedBookAdminPanel).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private DataGridView BorrowedBookAdminPanel;
        private Button BorrowBookBackBtn;
        private TextBox BorrowedBook;
        private Label Bookname;
        private FontAwesome.Sharp.IconButton BorrowBookSearch;
        private FontAwesome.Sharp.IconButton DeleteBoorowBookBtn;
        private Panel panel1;
        private Label label4;
        private Label label1;
        private PictureBox pictureBox1;
    }
}