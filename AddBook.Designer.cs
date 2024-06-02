namespace Library
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
            label7 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)booksView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)addbookstdimage).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(64, 205);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 2;
            label3.Text = "Book Title:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // booktitltxt
            // 
            booktitltxt.BackColor = Color.White;
            booktitltxt.BorderStyle = BorderStyle.FixedSingle;
            booktitltxt.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            booktitltxt.ForeColor = Color.Black;
            booktitltxt.Location = new Point(138, 203);
            booktitltxt.Margin = new Padding(3, 2, 3, 2);
            booktitltxt.Name = "booktitltxt";
            booktitltxt.PlaceholderText = "Enter Book name";
            booktitltxt.Size = new Size(235, 27);
            booktitltxt.TabIndex = 3;
            booktitltxt.TextAlign = HorizontalAlignment.Center;
            // 
            // authortxt
            // 
            authortxt.BackColor = Color.White;
            authortxt.BorderStyle = BorderStyle.FixedSingle;
            authortxt.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            authortxt.ForeColor = Color.Black;
            authortxt.Location = new Point(138, 240);
            authortxt.Margin = new Padding(3, 2, 3, 2);
            authortxt.Name = "authortxt";
            authortxt.PlaceholderText = "Enter Author name";
            authortxt.Size = new Size(235, 27);
            authortxt.TabIndex = 5;
            authortxt.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(64, 241);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 4;
            label4.Text = "Author";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // addToStdbtn
            // 
            addToStdbtn.BackColor = Color.FromArgb(192, 192, 255);
            addToStdbtn.FlatStyle = FlatStyle.Popup;
            addToStdbtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            addToStdbtn.ForeColor = Color.White;
            addToStdbtn.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            addToStdbtn.IconColor = Color.White;
            addToStdbtn.IconFont = FontAwesome.Sharp.IconFont.Regular;
            addToStdbtn.IconSize = 20;
            addToStdbtn.ImageAlign = ContentAlignment.MiddleLeft;
            addToStdbtn.Location = new Point(176, 339);
            addToStdbtn.Margin = new Padding(3, 2, 3, 2);
            addToStdbtn.Name = "addToStdbtn";
            addToStdbtn.Size = new Size(140, 26);
            addToStdbtn.TabIndex = 6;
            addToStdbtn.Text = "Issue Book";
            addToStdbtn.UseVisualStyleBackColor = false;
            addToStdbtn.Click += addToStdbtn_Click;
            // 
            // cancel
            // 
            cancel.BackColor = Color.FromArgb(192, 192, 255);
            cancel.FlatStyle = FlatStyle.Popup;
            cancel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cancel.ForeColor = Color.White;
            cancel.IconChar = FontAwesome.Sharp.IconChar.Recycle;
            cancel.IconColor = Color.White;
            cancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            cancel.IconSize = 20;
            cancel.ImageAlign = ContentAlignment.MiddleLeft;
            cancel.Location = new Point(176, 376);
            cancel.Margin = new Padding(3, 2, 3, 2);
            cancel.Name = "cancel";
            cancel.Size = new Size(140, 28);
            cancel.TabIndex = 7;
            cancel.Text = "Cancel";
            cancel.UseVisualStyleBackColor = false;
            cancel.Click += cancel_Click;
            // 
            // backbtn
            // 
            backbtn.BackColor = Color.FromArgb(192, 192, 255);
            backbtn.FlatStyle = FlatStyle.Popup;
            backbtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            backbtn.ForeColor = Color.White;
            backbtn.IconChar = FontAwesome.Sharp.IconChar.Backspace;
            backbtn.IconColor = Color.White;
            backbtn.IconFont = FontAwesome.Sharp.IconFont.Solid;
            backbtn.IconSize = 20;
            backbtn.ImageAlign = ContentAlignment.MiddleLeft;
            backbtn.Location = new Point(12, 482);
            backbtn.Margin = new Padding(3, 2, 3, 2);
            backbtn.Name = "backbtn";
            backbtn.Size = new Size(68, 27);
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
            booksView.BackgroundColor = Color.White;
            booksView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            booksView.Location = new Point(454, 66);
            booksView.Margin = new Padding(3, 2, 3, 2);
            booksView.Name = "booksView";
            booksView.RowHeadersWidth = 51;
            booksView.RowTemplate.Height = 29;
            booksView.Size = new Size(692, 451);
            booksView.TabIndex = 9;
            booksView.CellContentClick += booksView_CellContentClick;
            // 
            // SearchBtn
            // 
            SearchBtn.BackColor = Color.FromArgb(224, 224, 224);
            SearchBtn.Cursor = Cursors.Hand;
            SearchBtn.FlatStyle = FlatStyle.Popup;
            SearchBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            SearchBtn.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            SearchBtn.IconColor = Color.Black;
            SearchBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            SearchBtn.IconSize = 20;
            SearchBtn.ImageAlign = ContentAlignment.MiddleLeft;
            SearchBtn.Location = new Point(138, 278);
            SearchBtn.Margin = new Padding(3, 2, 3, 2);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Padding = new Padding(1);
            SearchBtn.Size = new Size(235, 38);
            SearchBtn.TabIndex = 11;
            SearchBtn.Text = "Search";
            SearchBtn.UseVisualStyleBackColor = false;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // addbookstdname
            // 
            addbookstdname.AutoSize = true;
            addbookstdname.Location = new Point(126, 172);
            addbookstdname.Name = "addbookstdname";
            addbookstdname.Size = new Size(0, 20);
            addbookstdname.TabIndex = 12;
            addbookstdname.Visible = false;
            // 
            // addbookstdimage
            // 
            addbookstdimage.Location = new Point(14, 87);
            addbookstdimage.Name = "addbookstdimage";
            addbookstdimage.Size = new Size(99, 105);
            addbookstdimage.SizeMode = PictureBoxSizeMode.Zoom;
            addbookstdimage.TabIndex = 13;
            addbookstdimage.TabStop = false;
            addbookstdimage.Visible = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 192, 255);
            panel1.Controls.Add(label7);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1314, 47);
            panel1.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(3, 12);
            label7.Name = "label7";
            label7.Size = new Size(490, 25);
            label7.TabIndex = 2;
            label7.Text = "Library Management System | Reader Panel | Issue Book";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(192, 192, 255);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(449, 35);
            panel2.Name = "panel2";
            panel2.Size = new Size(701, 494);
            panel2.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(279, 1);
            label1.Name = "label1";
            label1.Size = new Size(221, 37);
            label1.TabIndex = 16;
            label1.Text = "Books Available";
            // 
            // AddBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1314, 693);
            Controls.Add(panel1);
            Controls.Add(addbookstdimage);
            Controls.Add(addbookstdname);
            Controls.Add(SearchBtn);
            Controls.Add(booksView);
            Controls.Add(backbtn);
            Controls.Add(cancel);
            Controls.Add(addToStdbtn);
            Controls.Add(authortxt);
            Controls.Add(label4);
            Controls.Add(booktitltxt);
            Controls.Add(label3);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            MinimizeBox = false;
            Name = "AddBook";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "4";
            WindowState = FormWindowState.Maximized;
            Load += AddBook_Load;
            ((System.ComponentModel.ISupportInitialize)booksView).EndInit();
            ((System.ComponentModel.ISupportInitialize)addbookstdimage).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private Label label7;
        private Panel panel2;
        private Label label1;
    }
}