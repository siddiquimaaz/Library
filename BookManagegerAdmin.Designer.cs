namespace Library
{
    partial class BookManagegerAdmin
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
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            BooKNameAdmin = new TextBox();
            BookAuthor = new TextBox();
            ISBNNo = new TextBox();
            Genre = new TextBox();
            dateTimePicker = new DateTimePicker();
            submitBtn = new FontAwesome.Sharp.IconButton();
            BackBtn = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(BackBtn);
            panel1.Controls.Add(submitBtn);
            panel1.Controls.Add(dateTimePicker);
            panel1.Controls.Add(Genre);
            panel1.Controls.Add(ISBNNo);
            panel1.Controls.Add(BookAuthor);
            panel1.Controls.Add(BooKNameAdmin);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(244, 79);
            panel1.Name = "panel1";
            panel1.Size = new Size(721, 399);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(45, 134);
            label1.Name = "label1";
            label1.Size = new Size(65, 17);
            label1.TabIndex = 0;
            label1.Text = "Book Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(45, 162);
            label2.Name = "label2";
            label2.Size = new Size(80, 17);
            label2.TabIndex = 1;
            label2.Text = "Book Author";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(45, 189);
            label3.Name = "label3";
            label3.Size = new Size(59, 17);
            label3.TabIndex = 2;
            label3.Text = "ISBN NO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(45, 241);
            label4.Name = "label4";
            label4.Size = new Size(43, 17);
            label4.TabIndex = 3;
            label4.Text = "Genre";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(45, 212);
            label5.Name = "label5";
            label5.Size = new Size(102, 17);
            label5.TabIndex = 4;
            label5.Text = "Publication Date";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bahnschrift SemiBold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(322, 34);
            label6.Name = "label6";
            label6.Size = new Size(137, 29);
            label6.TabIndex = 5;
            label6.Text = "Add A Book";
            // 
            // BooKNameAdmin
            // 
            BooKNameAdmin.Location = new Point(199, 126);
            BooKNameAdmin.Name = "BooKNameAdmin";
            BooKNameAdmin.Size = new Size(150, 23);
            BooKNameAdmin.TabIndex = 1;
            // 
            // BookAuthor
            // 
            BookAuthor.Location = new Point(199, 154);
            BookAuthor.Name = "BookAuthor";
            BookAuthor.Size = new Size(150, 23);
            BookAuthor.TabIndex = 6;
            // 
            // ISBNNo
            // 
            ISBNNo.Location = new Point(199, 183);
            ISBNNo.Name = "ISBNNo";
            ISBNNo.Size = new Size(150, 23);
            ISBNNo.TabIndex = 7;
            // 
            // Genre
            // 
            Genre.Location = new Point(199, 239);
            Genre.Name = "Genre";
            Genre.Size = new Size(150, 23);
            Genre.TabIndex = 8;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(199, 212);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(208, 23);
            dateTimePicker.TabIndex = 9;
            // 
            // submitBtn
            // 
            submitBtn.BackColor = Color.FromArgb(192, 192, 255);
            submitBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            submitBtn.IconChar = FontAwesome.Sharp.IconChar.Upload;
            submitBtn.IconColor = Color.Black;
            submitBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            submitBtn.IconSize = 36;
            submitBtn.ImageAlign = ContentAlignment.MiddleLeft;
            submitBtn.Location = new Point(199, 290);
            submitBtn.Name = "submitBtn";
            submitBtn.Size = new Size(167, 46);
            submitBtn.TabIndex = 10;
            submitBtn.Text = "Submit";
            submitBtn.UseVisualStyleBackColor = false;
            // 
            // BackBtn
            // 
            BackBtn.BackColor = Color.FromArgb(192, 192, 255);
            BackBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            BackBtn.IconColor = Color.Black;
            BackBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BackBtn.Location = new Point(13, 362);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(75, 23);
            BackBtn.TabIndex = 1;
            BackBtn.Text = "Back";
            BackBtn.UseVisualStyleBackColor = false;
            // 
            // BookManagegerAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(1199, 552);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "BookManagegerAdmin";
            Text = "BookManagegerAdmin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
    }
}