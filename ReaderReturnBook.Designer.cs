namespace Library
{
    partial class ReaderReturnBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReaderReturnBook));
            panel2 = new Panel();
            Closebtn = new Label();
            label2 = new Label();
            label4 = new Label();
            ReturnBookDataGrid = new DataGridView();
            panel1 = new Panel();
            ReturnBookBtn = new FontAwesome.Sharp.IconButton();
            BookIDSearchBtn = new FontAwesome.Sharp.IconButton();
            ReturnBookbackbtn = new FontAwesome.Sharp.IconButton();
            BookIdTxt = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ReturnBookDataGrid).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(204, 203, 200);
            panel2.Controls.Add(Closebtn);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label4);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(2, 1, 2, 1);
            panel2.Size = new Size(1213, 34);
            panel2.TabIndex = 20;
            // 
            // Closebtn
            // 
            Closebtn.AutoSize = true;
            Closebtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Closebtn.ForeColor = Color.FromArgb(0, 102, 140);
            Closebtn.ImeMode = ImeMode.NoControl;
            Closebtn.Location = new Point(1343, 10);
            Closebtn.Name = "Closebtn";
            Closebtn.Size = new Size(15, 15);
            Closebtn.TabIndex = 23;
            Closebtn.Text = "X";
            Closebtn.Click += Closebtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 102, 140);
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(11, 10);
            label2.Name = "label2";
            label2.Size = new Size(431, 16);
            label2.TabIndex = 17;
            label2.Text = "Library Management System | Reader Panel | Return Book";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.ImeMode = ImeMode.NoControl;
            label4.Location = new Point(1375, 10);
            label4.Name = "label4";
            label4.Size = new Size(15, 15);
            label4.TabIndex = 14;
            label4.Text = "X";
            // 
            // ReturnBookDataGrid
            // 
            ReturnBookDataGrid.BackgroundColor = Color.FromArgb(245, 244, 241);
            ReturnBookDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ReturnBookDataGrid.Location = new Point(279, 41);
            ReturnBookDataGrid.Name = "ReturnBookDataGrid";
            ReturnBookDataGrid.RowHeadersWidth = 51;
            ReturnBookDataGrid.RowTemplate.Height = 25;
            ReturnBookDataGrid.Size = new Size(1083, 661);
            ReturnBookDataGrid.TabIndex = 21;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(245, 244, 241);
            panel1.Controls.Add(ReturnBookBtn);
            panel1.Controls.Add(BookIDSearchBtn);
            panel1.Controls.Add(ReturnBookbackbtn);
            panel1.Controls.Add(BookIdTxt);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(8, 41);
            panel1.Name = "panel1";
            panel1.Size = new Size(264, 662);
            panel1.TabIndex = 22;
            // 
            // ReturnBookBtn
            // 
            ReturnBookBtn.BackColor = Color.FromArgb(0, 102, 140);
            ReturnBookBtn.FlatStyle = FlatStyle.Popup;
            ReturnBookBtn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ReturnBookBtn.ForeColor = Color.FromArgb(255, 254, 251);
            ReturnBookBtn.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            ReturnBookBtn.IconColor = Color.FromArgb(255, 254, 251);
            ReturnBookBtn.IconFont = FontAwesome.Sharp.IconFont.Regular;
            ReturnBookBtn.IconSize = 34;
            ReturnBookBtn.ImageAlign = ContentAlignment.MiddleLeft;
            ReturnBookBtn.Location = new Point(23, 386);
            ReturnBookBtn.Margin = new Padding(3, 2, 3, 2);
            ReturnBookBtn.Name = "ReturnBookBtn";
            ReturnBookBtn.Size = new Size(208, 40);
            ReturnBookBtn.TabIndex = 30;
            ReturnBookBtn.Text = "Return Book";
            ReturnBookBtn.UseVisualStyleBackColor = false;
            ReturnBookBtn.Click += ReturnBookBtn_Click;
            // 
            // BookIDSearchBtn
            // 
            BookIDSearchBtn.BackColor = Color.FromArgb(255, 254, 251);
            BookIDSearchBtn.Cursor = Cursors.Hand;
            BookIDSearchBtn.FlatStyle = FlatStyle.Popup;
            BookIDSearchBtn.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            BookIDSearchBtn.ForeColor = Color.FromArgb(0, 102, 140);
            BookIDSearchBtn.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            BookIDSearchBtn.IconColor = Color.FromArgb(0, 102, 140);
            BookIDSearchBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BookIDSearchBtn.IconSize = 20;
            BookIDSearchBtn.ImageAlign = ContentAlignment.MiddleLeft;
            BookIDSearchBtn.Location = new Point(24, 337);
            BookIDSearchBtn.Margin = new Padding(3, 2, 3, 2);
            BookIDSearchBtn.Name = "BookIDSearchBtn";
            BookIDSearchBtn.Padding = new Padding(1);
            BookIDSearchBtn.Size = new Size(81, 26);
            BookIDSearchBtn.TabIndex = 31;
            BookIDSearchBtn.Text = "Search";
            BookIDSearchBtn.TextAlign = ContentAlignment.MiddleRight;
            BookIDSearchBtn.UseVisualStyleBackColor = false;
            BookIDSearchBtn.Click += BookIDSearchBtn_Click;
            // 
            // ReturnBookbackbtn
            // 
            ReturnBookbackbtn.BackColor = Color.FromArgb(29, 28, 28);
            ReturnBookbackbtn.FlatStyle = FlatStyle.Popup;
            ReturnBookbackbtn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ReturnBookbackbtn.ForeColor = Color.White;
            ReturnBookbackbtn.IconChar = FontAwesome.Sharp.IconChar.Backspace;
            ReturnBookbackbtn.IconColor = Color.White;
            ReturnBookbackbtn.IconFont = FontAwesome.Sharp.IconFont.Solid;
            ReturnBookbackbtn.IconSize = 20;
            ReturnBookbackbtn.ImageAlign = ContentAlignment.MiddleLeft;
            ReturnBookbackbtn.Location = new Point(86, 430);
            ReturnBookbackbtn.Margin = new Padding(3, 2, 3, 2);
            ReturnBookbackbtn.Name = "ReturnBookbackbtn";
            ReturnBookbackbtn.Size = new Size(64, 31);
            ReturnBookbackbtn.TabIndex = 29;
            ReturnBookbackbtn.Text = "Back";
            ReturnBookbackbtn.TextAlign = ContentAlignment.MiddleRight;
            ReturnBookbackbtn.UseVisualStyleBackColor = false;
            ReturnBookbackbtn.Click += ReturnBookbackbtn_Click;
            // 
            // BookIdTxt
            // 
            BookIdTxt.BorderStyle = BorderStyle.FixedSingle;
            BookIdTxt.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            BookIdTxt.ForeColor = Color.FromArgb(0, 102, 140);
            BookIdTxt.Location = new Point(23, 303);
            BookIdTxt.Margin = new Padding(1, 2, 1, 1);
            BookIdTxt.Name = "BookIdTxt";
            BookIdTxt.PlaceholderText = "Enter Book ID";
            BookIdTxt.Size = new Size(202, 21);
            BookIdTxt.TabIndex = 26;
            BookIdTxt.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 102, 140);
            label1.Location = new Point(21, 284);
            label1.Name = "label1";
            label1.Size = new Size(88, 13);
            label1.TabIndex = 25;
            label1.Text = "Enter Book ID";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(24, 58);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(201, 184);
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // ReaderReturnBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1213, 591);
            Controls.Add(panel1);
            Controls.Add(ReturnBookDataGrid);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ReaderReturnBook";
            Text = "ReaderReturnBook";
            Load += ReaderReturnBook_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ReturnBookDataGrid).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label2;
        private Label label4;
        private DataGridView ReturnBookDataGrid;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button TerminateMemberBackBtn;
        private FontAwesome.Sharp.IconButton TerminateMemberSearch;
        private FontAwesome.Sharp.IconButton TerminateBtn;
        private TextBox BookIdTxt;
        private Label label1;
        private FontAwesome.Sharp.IconButton ReturnBookbackbtn;
        private FontAwesome.Sharp.IconButton ReturnBookBtn;
        private FontAwesome.Sharp.IconButton BookIDSearchBtn;
        private Label Closebtn;
    }
}