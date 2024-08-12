namespace Library
{
    partial class ReaderDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReaderDetails));
            panel1 = new Panel();
            ReaderDetailsLabel = new Label();
            label1 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            ReadersDetailsUpdateBtn = new FontAwesome.Sharp.IconButton();
            ReadersDetailsCancelBtn = new FontAwesome.Sharp.IconButton();
            ReaderDetailsBackBtn = new Button();
            pictureBox1 = new PictureBox();
            FirstNameTxt = new TextBox();
            LastNameTxt = new TextBox();
            PasswordTxt = new TextBox();
            EmailTxt = new TextBox();
            PhoneNumberTxt = new TextBox();
            ReaderBackBtn = new FontAwesome.Sharp.IconButton();
            ReWritePasswordTxt = new TextBox();
            label9 = new Label();
            label10 = new Label();
            BrowseBtn = new FontAwesome.Sharp.IconButton();
            ReaderPic = new PictureBox();
            MemberShipDateTimePicker = new DateTimePicker();
            label11 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ReaderPic).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(204, 203, 200);
            panel1.Controls.Add(ReaderDetailsLabel);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(2, 1, 2, 1);
            panel1.Size = new Size(1213, 34);
            panel1.TabIndex = 19;
            // 
            // ReaderDetailsLabel
            // 
            ReaderDetailsLabel.AutoSize = true;
            ReaderDetailsLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ReaderDetailsLabel.ForeColor = Color.FromArgb(0, 102, 140);
            ReaderDetailsLabel.ImeMode = ImeMode.NoControl;
            ReaderDetailsLabel.Location = new Point(1209, 9);
            ReaderDetailsLabel.Name = "ReaderDetailsLabel";
            ReaderDetailsLabel.Size = new Size(15, 15);
            ReaderDetailsLabel.TabIndex = 49;
            ReaderDetailsLabel.Text = "X";
            ReaderDetailsLabel.Click += ReaderDetailsLabel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 102, 140);
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(9, 9);
            label1.Name = "label1";
            label1.Size = new Size(448, 16);
            label1.TabIndex = 17;
            label1.Text = "Library Management System | Reader Panel | Reader Details";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(1373, 9);
            label2.Name = "label2";
            label2.Size = new Size(15, 15);
            label2.TabIndex = 14;
            label2.Text = "X";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(204, 203, 200);
            panel2.Location = new Point(603, 51);
            panel2.Name = "panel2";
            panel2.Size = new Size(5, 528);
            panel2.TabIndex = 18;
            panel2.Paint += panel2_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(690, 214);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 20;
            label3.Text = "First-Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(690, 248);
            label4.Name = "label4";
            label4.Size = new Size(68, 15);
            label4.TabIndex = 21;
            label4.Text = "Last-Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(690, 281);
            label5.Name = "label5";
            label5.Size = new Size(93, 15);
            label5.TabIndex = 22;
            label5.Text = "Phone-Number:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(690, 314);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 23;
            label6.Text = "Email:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(690, 352);
            label7.Name = "label7";
            label7.Size = new Size(60, 15);
            label7.TabIndex = 24;
            label7.Text = "Password:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Verdana", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(0, 102, 140);
            label8.Location = new Point(811, 51);
            label8.Name = "label8";
            label8.Size = new Size(188, 42);
            label8.TabIndex = 25;
            label8.Text = "DETAILS";
            // 
            // ReadersDetailsUpdateBtn
            // 
            ReadersDetailsUpdateBtn.BackColor = Color.FromArgb(59, 60, 61);
            ReadersDetailsUpdateBtn.FlatStyle = FlatStyle.Flat;
            ReadersDetailsUpdateBtn.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ReadersDetailsUpdateBtn.ForeColor = Color.FromArgb(245, 244, 241);
            ReadersDetailsUpdateBtn.IconChar = FontAwesome.Sharp.IconChar.Upload;
            ReadersDetailsUpdateBtn.IconColor = Color.FromArgb(245, 244, 241);
            ReadersDetailsUpdateBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ReadersDetailsUpdateBtn.IconSize = 20;
            ReadersDetailsUpdateBtn.ImageAlign = ContentAlignment.MiddleLeft;
            ReadersDetailsUpdateBtn.Location = new Point(970, 500);
            ReadersDetailsUpdateBtn.Name = "ReadersDetailsUpdateBtn";
            ReadersDetailsUpdateBtn.Size = new Size(80, 27);
            ReadersDetailsUpdateBtn.TabIndex = 31;
            ReadersDetailsUpdateBtn.Text = "Update";
            ReadersDetailsUpdateBtn.TextAlign = ContentAlignment.MiddleRight;
            ReadersDetailsUpdateBtn.UseVisualStyleBackColor = false;
            ReadersDetailsUpdateBtn.Click += ReadersDetailsUpdateBtn_Click;
            // 
            // ReadersDetailsCancelBtn
            // 
            ReadersDetailsCancelBtn.BackColor = Color.FromArgb(0, 102, 140);
            ReadersDetailsCancelBtn.FlatStyle = FlatStyle.Flat;
            ReadersDetailsCancelBtn.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ReadersDetailsCancelBtn.ForeColor = Color.FromArgb(245, 244, 241);
            ReadersDetailsCancelBtn.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            ReadersDetailsCancelBtn.IconColor = Color.FromArgb(245, 244, 241);
            ReadersDetailsCancelBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ReadersDetailsCancelBtn.IconSize = 24;
            ReadersDetailsCancelBtn.ImageAlign = ContentAlignment.MiddleLeft;
            ReadersDetailsCancelBtn.Location = new Point(873, 500);
            ReadersDetailsCancelBtn.Name = "ReadersDetailsCancelBtn";
            ReadersDetailsCancelBtn.Size = new Size(80, 27);
            ReadersDetailsCancelBtn.TabIndex = 32;
            ReadersDetailsCancelBtn.Text = "Cancel";
            ReadersDetailsCancelBtn.TextAlign = ContentAlignment.MiddleRight;
            ReadersDetailsCancelBtn.UseVisualStyleBackColor = false;
            ReadersDetailsCancelBtn.Click += ReadersDetailsCancelBtn_Click;
            // 
            // ReaderDetailsBackBtn
            // 
            ReaderDetailsBackBtn.BackColor = Color.FromArgb(224, 224, 224);
            ReaderDetailsBackBtn.FlatStyle = FlatStyle.Flat;
            ReaderDetailsBackBtn.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            ReaderDetailsBackBtn.Location = new Point(37, 661);
            ReaderDetailsBackBtn.Name = "ReaderDetailsBackBtn";
            ReaderDetailsBackBtn.Size = new Size(75, 23);
            ReaderDetailsBackBtn.TabIndex = 33;
            ReaderDetailsBackBtn.Text = "Back";
            ReaderDetailsBackBtn.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(62, 171);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(418, 276);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 34;
            pictureBox1.TabStop = false;
            // 
            // FirstNameTxt
            // 
            FirstNameTxt.BackColor = Color.FromArgb(224, 224, 224);
            FirstNameTxt.BorderStyle = BorderStyle.FixedSingle;
            FirstNameTxt.Font = new Font("Verdana", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            FirstNameTxt.ForeColor = Color.FromArgb(0, 0, 0, 7);
            FirstNameTxt.Location = new Point(873, 212);
            FirstNameTxt.Name = "FirstNameTxt";
            FirstNameTxt.PlaceholderText = "Enter username";
            FirstNameTxt.Size = new Size(177, 20);
            FirstNameTxt.TabIndex = 35;
            FirstNameTxt.TextAlign = HorizontalAlignment.Center;
            // 
            // LastNameTxt
            // 
            LastNameTxt.BackColor = Color.FromArgb(224, 224, 224);
            LastNameTxt.BorderStyle = BorderStyle.FixedSingle;
            LastNameTxt.Font = new Font("Verdana", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            LastNameTxt.ForeColor = Color.FromArgb(0, 0, 0, 7);
            LastNameTxt.Location = new Point(873, 246);
            LastNameTxt.Name = "LastNameTxt";
            LastNameTxt.PlaceholderText = "Enter username";
            LastNameTxt.Size = new Size(177, 20);
            LastNameTxt.TabIndex = 36;
            LastNameTxt.TextAlign = HorizontalAlignment.Center;
            // 
            // PasswordTxt
            // 
            PasswordTxt.BackColor = Color.FromArgb(224, 224, 224);
            PasswordTxt.BorderStyle = BorderStyle.FixedSingle;
            PasswordTxt.Font = new Font("Verdana", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            PasswordTxt.ForeColor = Color.FromArgb(0, 0, 0, 7);
            PasswordTxt.Location = new Point(873, 350);
            PasswordTxt.Name = "PasswordTxt";
            PasswordTxt.PlaceholderText = "Enter username";
            PasswordTxt.Size = new Size(177, 20);
            PasswordTxt.TabIndex = 37;
            PasswordTxt.TextAlign = HorizontalAlignment.Center;
            // 
            // EmailTxt
            // 
            EmailTxt.BackColor = Color.FromArgb(224, 224, 224);
            EmailTxt.BorderStyle = BorderStyle.FixedSingle;
            EmailTxt.Font = new Font("Verdana", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            EmailTxt.ForeColor = Color.FromArgb(0, 0, 0, 7);
            EmailTxt.Location = new Point(873, 312);
            EmailTxt.Name = "EmailTxt";
            EmailTxt.PlaceholderText = "Enter username";
            EmailTxt.Size = new Size(177, 20);
            EmailTxt.TabIndex = 38;
            EmailTxt.TextAlign = HorizontalAlignment.Center;
            // 
            // PhoneNumberTxt
            // 
            PhoneNumberTxt.BackColor = Color.FromArgb(224, 224, 224);
            PhoneNumberTxt.BorderStyle = BorderStyle.FixedSingle;
            PhoneNumberTxt.Font = new Font("Verdana", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            PhoneNumberTxt.ForeColor = Color.FromArgb(0, 0, 0, 7);
            PhoneNumberTxt.Location = new Point(873, 279);
            PhoneNumberTxt.Name = "PhoneNumberTxt";
            PhoneNumberTxt.PlaceholderText = "Enter username";
            PhoneNumberTxt.Size = new Size(177, 20);
            PhoneNumberTxt.TabIndex = 39;
            PhoneNumberTxt.TextAlign = HorizontalAlignment.Center;
            // 
            // ReaderBackBtn
            // 
            ReaderBackBtn.BackColor = Color.FromArgb(29, 28, 28);
            ReaderBackBtn.FlatStyle = FlatStyle.Popup;
            ReaderBackBtn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ReaderBackBtn.ForeColor = Color.White;
            ReaderBackBtn.IconChar = FontAwesome.Sharp.IconChar.Backspace;
            ReaderBackBtn.IconColor = Color.White;
            ReaderBackBtn.IconFont = FontAwesome.Sharp.IconFont.Solid;
            ReaderBackBtn.IconSize = 20;
            ReaderBackBtn.ImageAlign = ContentAlignment.MiddleLeft;
            ReaderBackBtn.Location = new Point(62, 471);
            ReaderBackBtn.Margin = new Padding(3, 2, 3, 2);
            ReaderBackBtn.Name = "ReaderBackBtn";
            ReaderBackBtn.Size = new Size(74, 26);
            ReaderBackBtn.TabIndex = 40;
            ReaderBackBtn.Text = "Back";
            ReaderBackBtn.TextAlign = ContentAlignment.MiddleRight;
            ReaderBackBtn.UseVisualStyleBackColor = false;
            ReaderBackBtn.Click += ReaderBackBtn_Click;
            // 
            // ReWritePasswordTxt
            // 
            ReWritePasswordTxt.BackColor = Color.FromArgb(224, 224, 224);
            ReWritePasswordTxt.BorderStyle = BorderStyle.FixedSingle;
            ReWritePasswordTxt.Font = new Font("Verdana", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            ReWritePasswordTxt.ForeColor = Color.FromArgb(0, 0, 0, 7);
            ReWritePasswordTxt.Location = new Point(873, 386);
            ReWritePasswordTxt.Name = "ReWritePasswordTxt";
            ReWritePasswordTxt.PlaceholderText = "Enter username";
            ReWritePasswordTxt.Size = new Size(177, 20);
            ReWritePasswordTxt.TabIndex = 42;
            ReWritePasswordTxt.TextAlign = HorizontalAlignment.Center;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(690, 388);
            label9.Name = "label9";
            label9.Size = new Size(102, 15);
            label9.TabIndex = 41;
            label9.Text = "Re-Write assword:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(690, 470);
            label10.Name = "label10";
            label10.Size = new Size(136, 19);
            label10.TabIndex = 44;
            label10.Text = "Please Select Image!";
            // 
            // BrowseBtn
            // 
            BrowseBtn.BackColor = Color.FromArgb(204, 203, 200);
            BrowseBtn.FlatStyle = FlatStyle.Flat;
            BrowseBtn.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            BrowseBtn.ForeColor = Color.FromArgb(0, 102, 140);
            BrowseBtn.IconChar = FontAwesome.Sharp.IconChar.CircleArrowDown;
            BrowseBtn.IconColor = Color.FromArgb(0, 102, 140);
            BrowseBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BrowseBtn.IconSize = 24;
            BrowseBtn.ImageAlign = ContentAlignment.MiddleLeft;
            BrowseBtn.Location = new Point(964, 462);
            BrowseBtn.Name = "BrowseBtn";
            BrowseBtn.Size = new Size(86, 25);
            BrowseBtn.TabIndex = 45;
            BrowseBtn.Text = "Browse";
            BrowseBtn.TextAlign = ContentAlignment.MiddleRight;
            BrowseBtn.UseVisualStyleBackColor = false;
            BrowseBtn.Click += BrowseBtn_Click;
            // 
            // ReaderPic
            // 
            ReaderPic.BackColor = Color.Transparent;
            ReaderPic.InitialImage = (Image)resources.GetObject("ReaderPic.InitialImage");
            ReaderPic.Location = new Point(690, 112);
            ReaderPic.Margin = new Padding(3, 2, 3, 2);
            ReaderPic.Name = "ReaderPic";
            ReaderPic.Size = new Size(105, 75);
            ReaderPic.SizeMode = PictureBoxSizeMode.StretchImage;
            ReaderPic.TabIndex = 46;
            ReaderPic.TabStop = false;
            ReaderPic.Visible = false;
            ReaderPic.WaitOnLoad = true;
            // 
            // MemberShipDateTimePicker
            // 
            MemberShipDateTimePicker.Location = new Point(873, 421);
            MemberShipDateTimePicker.Name = "MemberShipDateTimePicker";
            MemberShipDateTimePicker.Size = new Size(177, 23);
            MemberShipDateTimePicker.TabIndex = 48;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(690, 426);
            label11.Name = "label11";
            label11.Size = new Size(128, 15);
            label11.TabIndex = 47;
            label11.Text = "Membership Due Date:";
            // 
            // ReaderDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1213, 591);
            Controls.Add(MemberShipDateTimePicker);
            Controls.Add(label11);
            Controls.Add(ReaderPic);
            Controls.Add(BrowseBtn);
            Controls.Add(label10);
            Controls.Add(ReWritePasswordTxt);
            Controls.Add(label9);
            Controls.Add(ReaderBackBtn);
            Controls.Add(PhoneNumberTxt);
            Controls.Add(EmailTxt);
            Controls.Add(PasswordTxt);
            Controls.Add(LastNameTxt);
            Controls.Add(FirstNameTxt);
            Controls.Add(pictureBox1);
            Controls.Add(ReaderDetailsBackBtn);
            Controls.Add(ReadersDetailsCancelBtn);
            Controls.Add(ReadersDetailsUpdateBtn);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "ReaderDetails";
            Text = "ReaderDetails";
            Load += ReaderDetails_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ReaderPic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Panel panel2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private FontAwesome.Sharp.IconButton ReadersDetailsUpdateBtn;
        private FontAwesome.Sharp.IconButton ReadersDetailsCancelBtn;
        private Button ReaderDetailsBackBtn;
        private PictureBox pictureBox1;
        private TextBox FirstNameTxt;
        private TextBox LastNameTxt;
        private TextBox PasswordTxt;
        private TextBox EmailTxt;
        private TextBox PhoneNumberTxt;
        private FontAwesome.Sharp.IconButton ReaderBackBtn;
        private TextBox ReWritePasswordTxt;
        private Label label9;
        private Label label10;
        private FontAwesome.Sharp.IconButton BrowseBtn;
        private PictureBox ReaderPic;
        private DateTimePicker MemberShipDateTimePicker;
        private Label label11;
        private Label ReaderDetailsLabel;
    }
}