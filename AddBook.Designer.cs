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
            label3.Location = new Point(36, 194);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
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
            booktitltxt.Location = new Point(110, 192);
            booktitltxt.Margin = new Padding(3, 2, 3, 2);
            booktitltxt.Name = "booktitltxt";
            booktitltxt.PlaceholderText = "Enter Book name";
            booktitltxt.Size = new Size(167, 23);
            booktitltxt.TabIndex = 3;
            booktitltxt.TextAlign = HorizontalAlignment.Center;
            // 
            // authortxt
            // 
            authortxt.BackColor = Color.White;
            authortxt.BorderStyle = BorderStyle.FixedSingle;
            authortxt.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            authortxt.ForeColor = Color.Black;
            authortxt.Location = new Point(110, 229);
            authortxt.Margin = new Padding(3, 2, 3, 2);
            authortxt.Name = "authortxt";
            authortxt.PlaceholderText = "Enter Author name";
            authortxt.Size = new Size(167, 23);
            authortxt.TabIndex = 5;
            authortxt.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(36, 230);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 4;
            label4.Text = "Author";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // addToStdbtn
            // 
            addToStdbtn.BackColor = Color.Transparent;
            addToStdbtn.FlatStyle = FlatStyle.Popup;
            addToStdbtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            addToStdbtn.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            addToStdbtn.IconColor = Color.Black;
            addToStdbtn.IconFont = FontAwesome.Sharp.IconFont.Regular;
            addToStdbtn.IconSize = 28;
            addToStdbtn.ImageAlign = ContentAlignment.MiddleLeft;
            addToStdbtn.Location = new Point(119, 384);
            addToStdbtn.Margin = new Padding(3, 2, 3, 2);
            addToStdbtn.Name = "addToStdbtn";
            addToStdbtn.Size = new Size(63, 22);
            addToStdbtn.TabIndex = 6;
            addToStdbtn.Text = "Add";
            addToStdbtn.TextAlign = ContentAlignment.MiddleRight;
            addToStdbtn.UseVisualStyleBackColor = false;
            addToStdbtn.Click += addToStdbtn_Click;
            // 
            // cancel
            // 
            cancel.FlatStyle = FlatStyle.Popup;
            cancel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cancel.IconChar = FontAwesome.Sharp.IconChar.Recycle;
            cancel.IconColor = Color.Black;
            cancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            cancel.IconSize = 28;
            cancel.ImageAlign = ContentAlignment.MiddleLeft;
            cancel.Location = new Point(187, 384);
            cancel.Margin = new Padding(3, 2, 3, 2);
            cancel.Name = "cancel";
            cancel.Size = new Size(75, 22);
            cancel.TabIndex = 7;
            cancel.Text = "Cancel";
            cancel.TextAlign = ContentAlignment.MiddleRight;
            cancel.UseVisualStyleBackColor = true;
            cancel.Click += cancel_Click;
            // 
            // backbtn
            // 
            backbtn.FlatStyle = FlatStyle.Popup;
            backbtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            backbtn.IconChar = FontAwesome.Sharp.IconChar.Backspace;
            backbtn.IconColor = Color.Black;
            backbtn.IconFont = FontAwesome.Sharp.IconFont.Solid;
            backbtn.IconSize = 28;
            backbtn.ImageAlign = ContentAlignment.MiddleLeft;
            backbtn.Location = new Point(159, 419);
            backbtn.Margin = new Padding(3, 2, 3, 2);
            backbtn.Name = "backbtn";
            backbtn.Size = new Size(66, 22);
            backbtn.TabIndex = 8;
            backbtn.Text = "Back";
            backbtn.TextAlign = ContentAlignment.MiddleRight;
            backbtn.UseVisualStyleBackColor = true;
            backbtn.Click += backbtn_Click;
            // 
            // booksView
            // 
            booksView.AllowUserToAddRows = false;
            booksView.AllowUserToDeleteRows = false;
            booksView.AllowUserToResizeColumns = false;
            booksView.AllowUserToResizeRows = false;
            booksView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            booksView.Location = new Point(454, 96);
            booksView.Margin = new Padding(3, 2, 3, 2);
            booksView.Name = "booksView";
            booksView.RowHeadersWidth = 51;
            booksView.RowTemplate.Height = 29;
            booksView.Size = new Size(692, 421);
            booksView.TabIndex = 9;
            booksView.CellContentClick += booksView_CellContentClick;
            // 
            // SearchBtn
            // 
            SearchBtn.Cursor = Cursors.Hand;
            SearchBtn.FlatStyle = FlatStyle.Popup;
            SearchBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            SearchBtn.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            SearchBtn.IconColor = Color.Black;
            SearchBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            SearchBtn.IconSize = 20;
            SearchBtn.ImageAlign = ContentAlignment.MiddleLeft;
            SearchBtn.Location = new Point(110, 267);
            SearchBtn.Margin = new Padding(3, 2, 3, 2);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Padding = new Padding(1);
            SearchBtn.Size = new Size(167, 26);
            SearchBtn.TabIndex = 11;
            SearchBtn.Text = "Search";
            SearchBtn.UseVisualStyleBackColor = true;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // addbookstdname
            // 
            addbookstdname.AutoSize = true;
            addbookstdname.Location = new Point(138, 75);
            addbookstdname.Name = "addbookstdname";
            addbookstdname.Size = new Size(0, 15);
            addbookstdname.TabIndex = 12;
            addbookstdname.Visible = false;
            // 
            // addbookstdimage
            // 
            addbookstdimage.Location = new Point(12, 65);
            addbookstdimage.Margin = new Padding(3, 2, 3, 2);
            addbookstdimage.Name = "addbookstdimage";
            addbookstdimage.Size = new Size(87, 79);
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
            panel1.Name = "panel1";
            panel1.Size = new Size(1150, 35);
            panel1.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(3, 9);
            label7.Name = "label7";
            label7.Size = new Size(391, 20);
            label7.TabIndex = 2;
            label7.Text = "Library Management System | Reader Panel | Issue Book";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(192, 192, 255);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(449, 41);
            panel2.Name = "panel2";
            panel2.Size = new Size(701, 479);
            panel2.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(315, 15);
            label1.Name = "label1";
            label1.Size = new Size(169, 30);
            label1.TabIndex = 16;
            label1.Text = "Books Available";
            // 
            // AddBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1150, 520);
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
            Margin = new Padding(3, 2, 3, 2);
            MinimizeBox = false;
            Name = "AddBook";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddBook";
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