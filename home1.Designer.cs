namespace Library
{
    partial class home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home));
            addbk = new Button();
            RenewMembershipBtn = new Button();
            ad = new Label();
            label1 = new Label();
            HomeStdPic = new PictureBox();
            HomeStdNameLabel = new Label();
            logout = new Button();
            label3 = new Label();
            DetailsBtn = new Button();
            ReaderDetails = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            label2 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            ReaderReturnBookBtn = new Button();
            ReturnBook = new Label();
            ((System.ComponentModel.ISupportInitialize)HomeStdPic).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // addbk
            // 
            addbk.BackColor = Color.FromArgb(0, 102, 140);
            addbk.BackgroundImage = (Image)resources.GetObject("addbk.BackgroundImage");
            addbk.BackgroundImageLayout = ImageLayout.Center;
            addbk.FlatAppearance.BorderSize = 0;
            addbk.FlatStyle = FlatStyle.Popup;
            addbk.ForeColor = Color.Transparent;
            addbk.Location = new Point(868, 319);
            addbk.Name = "addbk";
            addbk.Size = new Size(117, 95);
            addbk.TabIndex = 0;
            addbk.UseVisualStyleBackColor = false;
            addbk.Click += addbk_Click;
            // 
            // RenewMembershipBtn
            // 
            RenewMembershipBtn.BackColor = Color.FromArgb(0, 102, 140);
            RenewMembershipBtn.BackgroundImage = (Image)resources.GetObject("RenewMembershipBtn.BackgroundImage");
            RenewMembershipBtn.BackgroundImageLayout = ImageLayout.Center;
            RenewMembershipBtn.FlatAppearance.BorderSize = 0;
            RenewMembershipBtn.FlatStyle = FlatStyle.Popup;
            RenewMembershipBtn.ForeColor = Color.White;
            RenewMembershipBtn.Location = new Point(1047, 319);
            RenewMembershipBtn.Name = "RenewMembershipBtn";
            RenewMembershipBtn.Size = new Size(117, 95);
            RenewMembershipBtn.TabIndex = 2;
            RenewMembershipBtn.UseVisualStyleBackColor = false;
            RenewMembershipBtn.Click += button3_Click;
            // 
            // ad
            // 
            ad.AutoSize = true;
            ad.BackColor = Color.Transparent;
            ad.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            ad.Location = new Point(886, 426);
            ad.Name = "ad";
            ad.Size = new Size(76, 20);
            ad.TabIndex = 4;
            ad.Text = "Add Book";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 10.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(1036, 426);
            label1.Name = "label1";
            label1.Size = new Size(133, 19);
            label1.TabIndex = 6;
            label1.Text = "Renew Membership";
            // 
            // HomeStdPic
            // 
            HomeStdPic.BackColor = Color.Transparent;
            HomeStdPic.ErrorImage = (Image)resources.GetObject("HomeStdPic.ErrorImage");
            HomeStdPic.InitialImage = null;
            HomeStdPic.Location = new Point(661, 100);
            HomeStdPic.Margin = new Padding(3, 2, 3, 2);
            HomeStdPic.Name = "HomeStdPic";
            HomeStdPic.Size = new Size(120, 100);
            HomeStdPic.SizeMode = PictureBoxSizeMode.Zoom;
            HomeStdPic.TabIndex = 8;
            HomeStdPic.TabStop = false;
            HomeStdPic.Visible = false;
            HomeStdPic.WaitOnLoad = true;
            // 
            // HomeStdNameLabel
            // 
            HomeStdNameLabel.AutoSize = true;
            HomeStdNameLabel.Location = new Point(663, 190);
            HomeStdNameLabel.Name = "HomeStdNameLabel";
            HomeStdNameLabel.Size = new Size(0, 15);
            HomeStdNameLabel.TabIndex = 9;
            HomeStdNameLabel.Visible = false;
            // 
            // logout
            // 
            logout.AutoSize = true;
            logout.BackColor = Color.Transparent;
            logout.BackgroundImageLayout = ImageLayout.Stretch;
            logout.FlatAppearance.BorderSize = 0;
            logout.FlatStyle = FlatStyle.Popup;
            logout.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            logout.ForeColor = Color.FromArgb(182, 204, 216);
            logout.Image = (Image)resources.GetObject("logout.Image");
            logout.Location = new Point(23, 637);
            logout.Margin = new Padding(0);
            logout.Name = "logout";
            logout.Size = new Size(73, 38);
            logout.TabIndex = 10;
            logout.UseVisualStyleBackColor = false;
            logout.Click += logout_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Verdana", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(29, 28, 28);
            label3.Location = new Point(23, 670);
            label3.Name = "label3";
            label3.Size = new Size(52, 13);
            label3.TabIndex = 11;
            label3.Text = "LogOut";
            // 
            // DetailsBtn
            // 
            DetailsBtn.BackColor = Color.FromArgb(0, 102, 140);
            DetailsBtn.BackgroundImage = (Image)resources.GetObject("DetailsBtn.BackgroundImage");
            DetailsBtn.BackgroundImageLayout = ImageLayout.Center;
            DetailsBtn.FlatAppearance.BorderSize = 0;
            DetailsBtn.FlatStyle = FlatStyle.Popup;
            DetailsBtn.ForeColor = Color.White;
            DetailsBtn.Location = new Point(1223, 319);
            DetailsBtn.Name = "DetailsBtn";
            DetailsBtn.Size = new Size(117, 95);
            DetailsBtn.TabIndex = 12;
            DetailsBtn.UseVisualStyleBackColor = false;
            DetailsBtn.Click += DetailsBtn_Click;
            // 
            // ReaderDetails
            // 
            ReaderDetails.AutoSize = true;
            ReaderDetails.BackColor = Color.Transparent;
            ReaderDetails.Font = new Font("Segoe UI Semibold", 10.25F, FontStyle.Bold, GraphicsUnit.Point);
            ReaderDetails.Location = new Point(1251, 426);
            ReaderDetails.Name = "ReaderDetails";
            ReaderDetails.Size = new Size(52, 19);
            ReaderDetails.TabIndex = 13;
            ReaderDetails.Text = "Details";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(204, 203, 200);
            panel1.Location = new Point(633, 100);
            panel1.Name = "panel1";
            panel1.Size = new Size(5, 542);
            panel1.TabIndex = 14;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(204, 203, 200);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label4);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(2, 1, 2, 1);
            panel2.Size = new Size(1370, 34);
            panel2.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 102, 140);
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(9, 9);
            label2.Name = "label2";
            label2.Size = new Size(386, 16);
            label2.TabIndex = 17;
            label2.Text = "Library Management System | Reader Panel | Home";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.ImeMode = ImeMode.NoControl;
            label4.Location = new Point(1373, 9);
            label4.Name = "label4";
            label4.Size = new Size(15, 15);
            label4.TabIndex = 14;
            label4.Text = "X";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(125, 166);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(383, 274);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Verdana", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(0, 102, 140);
            label5.Location = new Point(219, 100);
            label5.Name = "label5";
            label5.Size = new Size(194, 38);
            label5.TabIndex = 21;
            label5.Text = "Welcome!";
            // 
            // ReaderReturnBookBtn
            // 
            ReaderReturnBookBtn.BackColor = Color.FromArgb(0, 102, 140);
            ReaderReturnBookBtn.BackgroundImage = (Image)resources.GetObject("ReaderReturnBookBtn.BackgroundImage");
            ReaderReturnBookBtn.BackgroundImageLayout = ImageLayout.Center;
            ReaderReturnBookBtn.FlatAppearance.BorderSize = 0;
            ReaderReturnBookBtn.FlatStyle = FlatStyle.Popup;
            ReaderReturnBookBtn.ForeColor = Color.White;
            ReaderReturnBookBtn.Location = new Point(693, 319);
            ReaderReturnBookBtn.Name = "ReaderReturnBookBtn";
            ReaderReturnBookBtn.Size = new Size(117, 95);
            ReaderReturnBookBtn.TabIndex = 22;
            ReaderReturnBookBtn.UseVisualStyleBackColor = false;
            // 
            // ReturnBook
            // 
            ReturnBook.AutoSize = true;
            ReturnBook.BackColor = Color.Transparent;
            ReturnBook.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            ReturnBook.Location = new Point(705, 426);
            ReturnBook.Name = "ReturnBook";
            ReturnBook.Size = new Size(94, 20);
            ReturnBook.TabIndex = 23;
            ReturnBook.Text = "Return Book";
            // 
            // home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 254, 251);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1370, 710);
            Controls.Add(ReturnBook);
            Controls.Add(ReaderReturnBookBtn);
            Controls.Add(label5);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(ReaderDetails);
            Controls.Add(DetailsBtn);
            Controls.Add(label3);
            Controls.Add(logout);
            Controls.Add(HomeStdNameLabel);
            Controls.Add(HomeStdPic);
            Controls.Add(RenewMembershipBtn);
            Controls.Add(addbk);
            Controls.Add(label1);
            Controls.Add(ad);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "home";
            Load += home_Load;
            ((System.ComponentModel.ISupportInitialize)HomeStdPic).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addbk;
        private Button RenewMembershipBtn;
        private Label ad;
        private Label label1;
        private PictureBox HomeStdPic;
        private Label HomeStdNameLabel;
        private Button logout;
        private Label label3;
        private Button DetailsBtn;
        private Label ReaderDetails;
        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private Label label4;
        private PictureBox pictureBox1;
        private Label label5;
        private Button ReaderReturnBookBtn;
        private Label ReturnBook;
    }
}