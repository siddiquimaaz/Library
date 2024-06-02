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
            button3 = new Button();
            ad = new Label();
            label1 = new Label();
            HomeStdPic = new PictureBox();
            HomeStdNameLabel = new Label();
            logout = new Button();
            label3 = new Label();
            DetailsBtn = new Button();
            ReaderDetails = new Label();
            ((System.ComponentModel.ISupportInitialize)HomeStdPic).BeginInit();
            SuspendLayout();
            // 
            // addbk
            // 
            addbk.BackColor = Color.LightGray;
            addbk.BackgroundImage = (Image)resources.GetObject("addbk.BackgroundImage");
            addbk.BackgroundImageLayout = ImageLayout.Center;
            addbk.FlatAppearance.BorderSize = 0;
            addbk.FlatStyle = FlatStyle.Popup;
            addbk.ForeColor = Color.Transparent;
            addbk.Location = new Point(371, 145);
            addbk.Name = "addbk";
            addbk.Size = new Size(117, 95);
            addbk.TabIndex = 0;
            addbk.UseVisualStyleBackColor = false;
            addbk.Click += addbk_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.LightGray;
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Center;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Popup;
            button3.ForeColor = Color.White;
            button3.Location = new Point(558, 145);
            button3.Name = "button3";
            button3.Size = new Size(117, 95);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = false;
            // 
            // ad
            // 
            ad.AutoSize = true;
            ad.BackColor = Color.Transparent;
            ad.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            ad.Location = new Point(389, 252);
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
            label1.Location = new Point(548, 252);
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
            HomeStdPic.Location = new Point(12, 22);
            HomeStdPic.Margin = new Padding(3, 2, 3, 2);
            HomeStdPic.Name = "HomeStdPic";
            HomeStdPic.Size = new Size(89, 95);
            HomeStdPic.SizeMode = PictureBoxSizeMode.Zoom;
            HomeStdPic.TabIndex = 8;
            HomeStdPic.TabStop = false;
            HomeStdPic.Visible = false;
            HomeStdPic.WaitOnLoad = true;
            // 
            // HomeStdNameLabel
            // 
            HomeStdNameLabel.AutoSize = true;
            HomeStdNameLabel.Location = new Point(18, 129);
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
            logout.ForeColor = Color.Black;
            logout.Image = (Image)resources.GetObject("logout.Image");
            logout.Location = new Point(18, 485);
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
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(18, 518);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 11;
            label3.Text = "LogOut";
            // 
            // DetailsBtn
            // 
            DetailsBtn.BackColor = Color.LightGray;
            DetailsBtn.BackgroundImage = (Image)resources.GetObject("DetailsBtn.BackgroundImage");
            DetailsBtn.BackgroundImageLayout = ImageLayout.Center;
            DetailsBtn.FlatAppearance.BorderSize = 0;
            DetailsBtn.FlatStyle = FlatStyle.Popup;
            DetailsBtn.ForeColor = Color.White;
            DetailsBtn.Location = new Point(730, 145);
            DetailsBtn.Name = "DetailsBtn";
            DetailsBtn.Size = new Size(117, 95);
            DetailsBtn.TabIndex = 12;
            DetailsBtn.UseVisualStyleBackColor = false;
            // 
            // ReaderDetails
            // 
            ReaderDetails.AutoSize = true;
            ReaderDetails.BackColor = Color.Transparent;
            ReaderDetails.Font = new Font("Segoe UI Semibold", 10.25F, FontStyle.Bold, GraphicsUnit.Point);
            ReaderDetails.Location = new Point(767, 252);
            ReaderDetails.Name = "ReaderDetails";
            ReaderDetails.Size = new Size(52, 19);
            ReaderDetails.TabIndex = 13;
            ReaderDetails.Text = "Details";
            // 
            // home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1199, 552);
            Controls.Add(ReaderDetails);
            Controls.Add(DetailsBtn);
            Controls.Add(label3);
            Controls.Add(logout);
            Controls.Add(HomeStdNameLabel);
            Controls.Add(HomeStdPic);
            Controls.Add(button3);
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addbk;
        private Button button3;
        private Label ad;
        private Label label1;
        private PictureBox HomeStdPic;
        private Label HomeStdNameLabel;
        private Button logout;
        private Label label3;
        private Button DetailsBtn;
        private Label ReaderDetails;
    }
}