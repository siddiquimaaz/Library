﻿namespace Library
{
    partial class AddBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBook));
            label3 = new Label();
            booktitltxt = new TextBox();
            authortxt = new TextBox();
            label4 = new Label();
            addToStdbtn = new FontAwesome.Sharp.IconButton();
            cancel = new FontAwesome.Sharp.IconButton();
            backbtn = new FontAwesome.Sharp.IconButton();
            booksView = new DataGridView();
            SearchBtn = new FontAwesome.Sharp.IconButton();
            addbookstdname = new Label();
            addbookstdimage = new PictureBox();
            panel1 = new Panel();
            AddBookByReaderCloseLabel = new Label();
            label1 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)booksView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)addbookstdimage).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(0, 102, 140);
            label3.Location = new Point(26, 459);
            label3.Name = "label3";
            label3.Size = new Size(84, 17);
            label3.TabIndex = 2;
            label3.Text = "Book Title:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // booktitltxt
            // 
            booktitltxt.BackColor = Color.White;
            booktitltxt.BorderStyle = BorderStyle.FixedSingle;
            booktitltxt.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            booktitltxt.ForeColor = Color.FromArgb(0, 102, 140);
            booktitltxt.Location = new Point(30, 484);
            booktitltxt.Name = "booktitltxt";
            booktitltxt.PlaceholderText = "Enter Book name";
            booktitltxt.Size = new Size(240, 24);
            booktitltxt.TabIndex = 3;
            booktitltxt.TextAlign = HorizontalAlignment.Center;
            booktitltxt.TextChanged += booktitltxt_TextChanged;
            // 
            // authortxt
            // 
            authortxt.BackColor = Color.White;
            authortxt.BorderStyle = BorderStyle.FixedSingle;
            authortxt.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            authortxt.ForeColor = Color.FromArgb(0, 102, 140);
            authortxt.Location = new Point(29, 552);
            authortxt.Name = "authortxt";
            authortxt.PlaceholderText = "Enter Author name";
            authortxt.Size = new Size(240, 24);
            authortxt.TabIndex = 5;
            authortxt.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(0, 102, 140);
            label4.Location = new Point(26, 527);
            label4.Name = "label4";
            label4.Size = new Size(57, 17);
            label4.TabIndex = 4;
            label4.Text = "Author";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // addToStdbtn
            // 
            addToStdbtn.BackColor = Color.FromArgb(0, 102, 140);
            addToStdbtn.FlatStyle = FlatStyle.Popup;
            addToStdbtn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            addToStdbtn.ForeColor = Color.FromArgb(255, 254, 251);
            addToStdbtn.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            addToStdbtn.IconColor = Color.FromArgb(255, 254, 251);
            addToStdbtn.IconFont = FontAwesome.Sharp.IconFont.Regular;
            addToStdbtn.IconSize = 28;
            addToStdbtn.ImageAlign = ContentAlignment.MiddleLeft;
            addToStdbtn.Location = new Point(31, 664);
            addToStdbtn.Name = "addToStdbtn";
            addToStdbtn.Size = new Size(241, 53);
            addToStdbtn.TabIndex = 6;
            addToStdbtn.Text = "Issue Book";
            addToStdbtn.UseVisualStyleBackColor = false;
            addToStdbtn.Click += addToStdbtn_Click;
            // 
            // cancel
            // 
            cancel.BackColor = Color.FromArgb(29, 28, 28);
            cancel.FlatStyle = FlatStyle.Popup;
            cancel.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            cancel.ForeColor = Color.White;
            cancel.IconChar = FontAwesome.Sharp.IconChar.Recycle;
            cancel.IconColor = Color.White;
            cancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            cancel.IconSize = 20;
            cancel.ImageAlign = ContentAlignment.MiddleLeft;
            cancel.Location = new Point(183, 734);
            cancel.Name = "cancel";
            cancel.Size = new Size(87, 41);
            cancel.TabIndex = 7;
            cancel.Text = "Cancel";
            cancel.TextAlign = ContentAlignment.MiddleRight;
            cancel.UseVisualStyleBackColor = false;
            cancel.Click += cancel_Click;
            // 
            // backbtn
            // 
            backbtn.BackColor = Color.FromArgb(29, 28, 28);
            backbtn.FlatStyle = FlatStyle.Popup;
            backbtn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            backbtn.ForeColor = Color.White;
            backbtn.IconChar = FontAwesome.Sharp.IconChar.Backspace;
            backbtn.IconColor = Color.White;
            backbtn.IconFont = FontAwesome.Sharp.IconFont.Solid;
            backbtn.IconSize = 20;
            backbtn.ImageAlign = ContentAlignment.MiddleLeft;
            backbtn.Location = new Point(176, 447);
            backbtn.Name = "backbtn";
            backbtn.Size = new Size(83, 29);
            backbtn.TabIndex = 8;
            backbtn.Text = "Back";
            backbtn.TextAlign = ContentAlignment.MiddleRight;
            backbtn.UseVisualStyleBackColor = false;
            backbtn.Click += backbtn_Click;
            // 
            // booksView
            // 
            booksView.AllowUserToAddRows = false;
            booksView.AllowUserToDeleteRows = false;
            booksView.AllowUserToResizeColumns = false;
            booksView.AllowUserToResizeRows = false;
            booksView.BackgroundColor = Color.FromArgb(245, 244, 241);
            booksView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            booksView.Location = new Point(320, 57);
            booksView.Name = "booksView";
            booksView.RowHeadersWidth = 51;
            booksView.RowTemplate.Height = 29;
            booksView.Size = new Size(1238, 794);
            booksView.TabIndex = 9;
            booksView.CellContentClick += booksView_CellContentClick;
            // 
            // SearchBtn
            // 
            SearchBtn.BackColor = Color.FromArgb(255, 254, 251);
            SearchBtn.Cursor = Cursors.Hand;
            SearchBtn.FlatStyle = FlatStyle.Popup;
            SearchBtn.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            SearchBtn.ForeColor = Color.FromArgb(0, 102, 140);
            SearchBtn.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            SearchBtn.IconColor = Color.FromArgb(0, 102, 140);
            SearchBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            SearchBtn.IconSize = 20;
            SearchBtn.ImageAlign = ContentAlignment.MiddleLeft;
            SearchBtn.Location = new Point(32, 599);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Padding = new Padding(1);
            SearchBtn.Size = new Size(93, 35);
            SearchBtn.TabIndex = 11;
            SearchBtn.Text = "Search";
            SearchBtn.TextAlign = ContentAlignment.MiddleRight;
            SearchBtn.UseVisualStyleBackColor = false;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // addbookstdname
            // 
            addbookstdname.AutoSize = true;
            addbookstdname.Location = new Point(32, 409);
            addbookstdname.Name = "addbookstdname";
            addbookstdname.Size = new Size(0, 20);
            addbookstdname.TabIndex = 12;
            addbookstdname.Visible = false;
            // 
            // addbookstdimage
            // 
            addbookstdimage.Location = new Point(29, 288);
            addbookstdimage.Name = "addbookstdimage";
            addbookstdimage.Size = new Size(132, 105);
            addbookstdimage.SizeMode = PictureBoxSizeMode.Zoom;
            addbookstdimage.TabIndex = 13;
            addbookstdimage.TabStop = false;
            addbookstdimage.Visible = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(204, 203, 200);
            panel1.Controls.Add(AddBookByReaderCloseLabel);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 5, 3, 5);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(2, 1, 2, 1);
            panel1.Size = new Size(1566, 45);
            panel1.TabIndex = 18;
            panel1.Paint += panel1_Paint;
            // 
            // AddBookByReaderCloseLabel
            // 
            AddBookByReaderCloseLabel.AutoSize = true;
            AddBookByReaderCloseLabel.BackColor = Color.Transparent;
            AddBookByReaderCloseLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            AddBookByReaderCloseLabel.ForeColor = Color.FromArgb(0, 102, 140);
            AddBookByReaderCloseLabel.ImeMode = ImeMode.NoControl;
            AddBookByReaderCloseLabel.Location = new Point(1535, 11);
            AddBookByReaderCloseLabel.Name = "AddBookByReaderCloseLabel";
            AddBookByReaderCloseLabel.Size = new Size(19, 20);
            AddBookByReaderCloseLabel.TabIndex = 20;
            AddBookByReaderCloseLabel.Text = "X";
            AddBookByReaderCloseLabel.Click += AddBookByReaderCloseLabel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 102, 140);
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(8, 11);
            label1.Name = "label1";
            label1.Size = new Size(552, 20);
            label1.TabIndex = 17;
            label1.Text = "Library Management System | Reader Panel | Issue Book";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(1567, 11);
            label2.Name = "label2";
            label2.Size = new Size(19, 20);
            label2.TabIndex = 14;
            label2.Text = "X";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(245, 244, 241);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(authortxt);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(booktitltxt);
            panel2.Controls.Add(addbookstdimage);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(addbookstdname);
            panel2.Controls.Add(addToStdbtn);
            panel2.Controls.Add(SearchBtn);
            panel2.Controls.Add(cancel);
            panel2.Controls.Add(backbtn);
            panel2.ForeColor = Color.FromArgb(29, 28, 28);
            panel2.Location = new Point(8, 57);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(302, 794);
            panel2.TabIndex = 19;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(29, 32);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(230, 245);
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // AddBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1566, 862);
            Controls.Add(panel2);
            Controls.Add(booksView);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MinimizeBox = false;
            Name = "AddBook";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "4";
            Load += AddBook_Load;
            ((System.ComponentModel.ISupportInitialize)booksView).EndInit();
            ((System.ComponentModel.ISupportInitialize)addbookstdimage).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label3;
        private TextBox booktitltxt;
        private TextBox authortxt;
        private Label label4;
        private FontAwesome.Sharp.IconButton addToStdbtn;
        private FontAwesome.Sharp.IconButton cancel;
        private FontAwesome.Sharp.IconButton backbtn;
        private DataGridView booksView;
        private FontAwesome.Sharp.IconButton SearchBtn;
        private Label addbookstdname;
        private PictureBox addbookstdimage;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label AddBookByReaderCloseLabel;
    }
}