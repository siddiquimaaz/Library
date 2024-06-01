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
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            ad = new Label();
            src = new Label();
            label1 = new Label();
            label2 = new Label();
            HomeStdPic = new PictureBox();
            HomeStdNameLabel = new Label();
            logout = new Button();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)HomeStdPic).BeginInit();
            SuspendLayout();
            // 
            // addbk
            // 
            addbk.BackColor = Color.Transparent;
            addbk.BackgroundImage = (Image)resources.GetObject("addbk.BackgroundImage");
            addbk.BackgroundImageLayout = ImageLayout.Center;
            addbk.FlatAppearance.BorderSize = 0;
            addbk.FlatStyle = FlatStyle.Popup;
            addbk.ForeColor = Color.Transparent;
            addbk.Location = new Point(368, 247);
            addbk.Margin = new Padding(3, 4, 3, 4);
            addbk.Name = "addbk";
            addbk.Size = new Size(134, 127);
            addbk.TabIndex = 0;
            addbk.UseVisualStyleBackColor = false;
            addbk.Click += addbk_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Center;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Location = new Point(528, 247);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(134, 127);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Center;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Popup;
            button3.ForeColor = Color.White;
            button3.Location = new Point(848, 247);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(134, 127);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.BackgroundImageLayout = ImageLayout.Center;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Location = new Point(688, 247);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(134, 127);
            button4.TabIndex = 3;
            button4.UseVisualStyleBackColor = false;
            // 
            // ad
            // 
            ad.AutoSize = true;
            ad.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            ad.Location = new Point(388, 389);
            ad.Name = "ad";
            ad.Size = new Size(95, 25);
            ad.TabIndex = 4;
            ad.Text = "Add Book";
            // 
            // src
            // 
            src.AutoSize = true;
            src.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            src.Location = new Point(532, 389);
            src.Name = "src";
            src.Size = new Size(117, 25);
            src.TabIndex = 5;
            src.Text = "Search Book";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(836, 389);
            label1.Name = "label1";
            label1.Size = new Size(178, 25);
            label1.TabIndex = 6;
            label1.Text = "Renew Membership";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(683, 389);
            label2.Name = "label2";
            label2.Size = new Size(144, 25);
            label2.TabIndex = 7;
            label2.Text = "Become Reader";
            // 
            // HomeStdPic
            // 
            HomeStdPic.ErrorImage = (Image)resources.GetObject("HomeStdPic.ErrorImage");
            HomeStdPic.InitialImage = null;
            HomeStdPic.Location = new Point(12, 28);
            HomeStdPic.Name = "HomeStdPic";
            HomeStdPic.Size = new Size(131, 89);
            HomeStdPic.SizeMode = PictureBoxSizeMode.Zoom;
            HomeStdPic.TabIndex = 8;
            HomeStdPic.TabStop = false;
            HomeStdPic.Visible = false;
            HomeStdPic.WaitOnLoad = true;
            // 
            // HomeStdNameLabel
            // 
            HomeStdNameLabel.AutoSize = true;
            HomeStdNameLabel.Location = new Point(35, 130);
            HomeStdNameLabel.Name = "HomeStdNameLabel";
            HomeStdNameLabel.Size = new Size(0, 20);
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
            logout.Location = new Point(20, 647);
            logout.Margin = new Padding(0);
            logout.Name = "logout";
            logout.Size = new Size(83, 38);
            logout.TabIndex = 10;
            logout.UseVisualStyleBackColor = false;
            logout.Click += logout_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(20, 691);
            label3.Name = "label3";
            label3.Size = new Size(59, 20);
            label3.TabIndex = 11;
            label3.Text = "LogOut";
            // 
            // home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1393, 727);
            Controls.Add(label3);
            Controls.Add(logout);
            Controls.Add(HomeStdNameLabel);
            Controls.Add(HomeStdPic);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(addbk);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(src);
            Controls.Add(ad);
            Margin = new Padding(3, 4, 3, 4);
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
        private Button button2;
        private Button button3;
        private Button button4;
        private Label ad;
        private Label src;
        private Label label1;
        private Label label2;
        private PictureBox HomeStdPic;
        private Label HomeStdNameLabel;
        private Button logout;
        private Label label3;
    }
}