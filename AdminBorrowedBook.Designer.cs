namespace Library
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
            panel2 = new Panel();
            DeleteBoorowBookBtn = new FontAwesome.Sharp.IconButton();
            BorrowBookSearch = new FontAwesome.Sharp.IconButton();
            BorrowedBook = new TextBox();
            textBox1 = new TextBox();
            Bookname = new Label();
            BorrowBookBackBtn = new Button();
            panel1 = new Panel();
            label2 = new Label();
            BorrowedBookAdminPanel = new DataGridView();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BorrowedBookAdminPanel).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Controls.Add(DeleteBoorowBookBtn);
            panel2.Controls.Add(BorrowBookSearch);
            panel2.Controls.Add(BorrowedBook);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(Bookname);
            panel2.Controls.Add(BorrowBookBackBtn);
            panel2.Location = new Point(0, -8);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(295, 693);
            panel2.TabIndex = 18;
            panel2.Paint += panel2_Paint;
            // 
            // DeleteBoorowBookBtn
            // 
            DeleteBoorowBookBtn.BackColor = Color.LightGray;
            DeleteBoorowBookBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            DeleteBoorowBookBtn.IconChar = FontAwesome.Sharp.IconChar.FileCircleXmark;
            DeleteBoorowBookBtn.IconColor = Color.Black;
            DeleteBoorowBookBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            DeleteBoorowBookBtn.ImageAlign = ContentAlignment.MiddleLeft;
            DeleteBoorowBookBtn.Location = new Point(16, 415);
            DeleteBoorowBookBtn.Margin = new Padding(3, 4, 3, 4);
            DeleteBoorowBookBtn.Name = "DeleteBoorowBookBtn";
            DeleteBoorowBookBtn.Size = new Size(259, 72);
            DeleteBoorowBookBtn.TabIndex = 29;
            DeleteBoorowBookBtn.Text = "Retrieve Book";
            DeleteBoorowBookBtn.UseVisualStyleBackColor = false;
            DeleteBoorowBookBtn.Click += DeleteBoorowBookBtn_Click;
            // 
            // BorrowBookSearch
            // 
            BorrowBookSearch.BackColor = Color.White;
            BorrowBookSearch.Cursor = Cursors.Hand;
            BorrowBookSearch.FlatStyle = FlatStyle.Popup;
            BorrowBookSearch.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BorrowBookSearch.ForeColor = Color.Black;
            BorrowBookSearch.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            BorrowBookSearch.IconColor = Color.Black;
            BorrowBookSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BorrowBookSearch.IconSize = 20;
            BorrowBookSearch.ImageAlign = ContentAlignment.MiddleLeft;
            BorrowBookSearch.Location = new Point(19, 304);
            BorrowBookSearch.Name = "BorrowBookSearch";
            BorrowBookSearch.Padding = new Padding(1);
            BorrowBookSearch.Size = new Size(93, 35);
            BorrowBookSearch.TabIndex = 28;
            BorrowBookSearch.Text = "Search";
            BorrowBookSearch.TextAlign = ContentAlignment.MiddleRight;
            BorrowBookSearch.UseVisualStyleBackColor = false;
            BorrowBookSearch.Click += BorrowBookSearch_Click;
            // 
            // BorrowedBook
            // 
            BorrowedBook.Location = new Point(19, 267);
            BorrowedBook.Margin = new Padding(3, 4, 3, 4);
            BorrowedBook.Name = "BorrowedBook";
            BorrowedBook.Size = new Size(209, 27);
            BorrowedBook.TabIndex = 27;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(0, 0);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(114, 27);
            textBox1.TabIndex = 26;
            // 
            // Bookname
            // 
            Bookname.AutoSize = true;
            Bookname.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Bookname.ForeColor = Color.White;
            Bookname.Location = new Point(16, 240);
            Bookname.Name = "Bookname";
            Bookname.Size = new Size(145, 23);
            Bookname.TabIndex = 20;
            Bookname.Text = "Enter Book Name";
            // 
            // BorrowBookBackBtn
            // 
            BorrowBookBackBtn.BackColor = Color.White;
            BorrowBookBackBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BorrowBookBackBtn.Location = new Point(14, 645);
            BorrowBookBackBtn.Margin = new Padding(3, 4, 3, 4);
            BorrowBookBackBtn.Name = "BorrowBookBackBtn";
            BorrowBookBackBtn.Size = new Size(86, 31);
            BorrowBookBackBtn.TabIndex = 25;
            BorrowBookBackBtn.Text = "Back";
            BorrowBookBackBtn.UseVisualStyleBackColor = false;
            BorrowBookBackBtn.Click += BorrowBookBackBtn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1352, 49);
            panel1.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 9);
            label2.Name = "label2";
            label2.Size = new Size(535, 25);
            label2.TabIndex = 1;
            label2.Text = "Library Management System | Admin Panel | Borrowed Books";
            // 
            // BorrowedBookAdminPanel
            // 
            BorrowedBookAdminPanel.BackgroundColor = Color.White;
            BorrowedBookAdminPanel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BorrowedBookAdminPanel.Location = new Point(296, 51);
            BorrowedBookAdminPanel.Margin = new Padding(3, 4, 3, 4);
            BorrowedBookAdminPanel.Name = "BorrowedBookAdminPanel";
            BorrowedBookAdminPanel.RowHeadersWidth = 51;
            BorrowedBookAdminPanel.RowTemplate.Height = 25;
            BorrowedBookAdminPanel.Size = new Size(1056, 635);
            BorrowedBookAdminPanel.TabIndex = 19;
            // 
            // AdminBorrowedBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1352, 684);
            Controls.Add(BorrowedBookAdminPanel);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "AdminBorrowedBook";
            Text = "AdminBorrowedBook";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BorrowedBookAdminPanel).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Panel panel1;
        private Label label2;
        private DataGridView BorrowedBookAdminPanel;
        private Button BorrowBookBackBtn;
        private TextBox BorrowedBook;
        private TextBox textBox1;
        private Label Bookname;
        private FontAwesome.Sharp.IconButton BorrowBookSearch;
        private FontAwesome.Sharp.IconButton DeleteBoorowBookBtn;
    }
}