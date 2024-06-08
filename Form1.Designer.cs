namespace Library
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            text1 = new TextBox();
            text2 = new TextBox();
            userName = new Label();
            Pass = new Label();
            Login = new Button();
            hehe = new Label();
            sign = new Button();
            checkBox1 = new CheckBox();
            checkadmin = new CheckBox();
            panel1 = new Panel();
            label4 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            panel2 = new Panel();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // text1
            // 
            text1.BackColor = Color.FromArgb(224, 224, 224);
            text1.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            text1.ForeColor = Color.FromArgb(31, 58, 95);
            text1.Location = new Point(968, 222);
            text1.Margin = new Padding(3, 4, 3, 4);
            text1.Name = "text1";
            text1.PlaceholderText = "Enter username";
            text1.Size = new Size(228, 24);
            text1.TabIndex = 0;
            text1.TextAlign = HorizontalAlignment.Center;
            // 
            // text2
            // 
            text2.BackColor = Color.FromArgb(224, 224, 224);
            text2.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            text2.ForeColor = Color.FromArgb(31, 58, 95);
            text2.Location = new Point(968, 286);
            text2.Margin = new Padding(2, 10, 2, 3);
            text2.Name = "text2";
            text2.PlaceholderText = "Enter your Password";
            text2.Size = new Size(228, 24);
            text2.TabIndex = 1;
            text2.TextAlign = HorizontalAlignment.Center;
            text2.UseSystemPasswordChar = true;
            // 
            // userName
            // 
            userName.AutoSize = true;
            userName.BackColor = Color.Transparent;
            userName.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            userName.ForeColor = Color.White;
            userName.Location = new Point(967, 201);
            userName.Name = "userName";
            userName.Size = new Size(92, 17);
            userName.TabIndex = 2;
            userName.Text = "User-Name:";
            // 
            // Pass
            // 
            Pass.AutoSize = true;
            Pass.BackColor = Color.Transparent;
            Pass.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            Pass.ForeColor = Color.White;
            Pass.Location = new Point(966, 268);
            Pass.Name = "Pass";
            Pass.Size = new Size(81, 17);
            Pass.TabIndex = 3;
            Pass.Text = "Password:";
            // 
            // Login
            // 
            Login.BackColor = Color.FromArgb(55, 67, 87);
            Login.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Login.ForeColor = Color.White;
            Login.Location = new Point(967, 347);
            Login.Margin = new Padding(3, 4, 3, 4);
            Login.Name = "Login";
            Login.Size = new Size(231, 48);
            Login.TabIndex = 6;
            Login.Text = "Login";
            Login.UseVisualStyleBackColor = false;
            Login.Click += Login_Click;
            // 
            // hehe
            // 
            hehe.AutoSize = true;
            hehe.BackColor = Color.Transparent;
            hehe.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            hehe.ForeColor = Color.White;
            hehe.Location = new Point(953, 442);
            hehe.Name = "hehe";
            hehe.Size = new Size(258, 17);
            hehe.TabIndex = 7;
            hehe.Text = "Don't have account? Register here:";
            // 
            // sign
            // 
            sign.BackColor = Color.FromArgb(224, 224, 224);
            sign.FlatStyle = FlatStyle.Popup;
            sign.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            sign.ForeColor = Color.FromArgb(31, 58, 95);
            sign.Location = new Point(966, 463);
            sign.Margin = new Padding(3, 4, 3, 4);
            sign.Name = "sign";
            sign.Size = new Size(233, 53);
            sign.TabIndex = 8;
            sign.Text = "Sign-Up";
            sign.UseVisualStyleBackColor = false;
            sign.Click += sign_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.Transparent;
            checkBox1.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.ForeColor = Color.White;
            checkBox1.Location = new Point(1012, 316);
            checkBox1.Margin = new Padding(3, 1, 3, 1);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(141, 21);
            checkBox1.TabIndex = 11;
            checkBox1.Text = "Show Password";
            checkBox1.TextAlign = ContentAlignment.MiddleCenter;
            checkBox1.UseVisualStyleBackColor = false;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkadmin
            // 
            checkadmin.AutoSize = true;
            checkadmin.BackColor = Color.Transparent;
            checkadmin.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            checkadmin.ForeColor = Color.White;
            checkadmin.Location = new Point(967, 405);
            checkadmin.Margin = new Padding(3, 1, 3, 1);
            checkadmin.Name = "checkadmin";
            checkadmin.Size = new Size(74, 21);
            checkadmin.TabIndex = 12;
            checkadmin.Text = "Admin";
            checkadmin.TextAlign = ContentAlignment.MiddleCenter;
            checkadmin.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(55, 67, 87);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(2, 1, 2, 1);
            panel1.Size = new Size(1370, 34);
            panel1.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(5, 7);
            label4.Name = "label4";
            label4.Size = new Size(360, 20);
            label4.TabIndex = 17;
            label4.Text = "Library Management System | Login ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(1369, 7);
            label1.Name = "label1";
            label1.Size = new Size(19, 20);
            label1.TabIndex = 14;
            label1.Text = "X";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(185, 315);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(209, 201);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Yu Gothic UI", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(224, 224, 224);
            label2.Location = new Point(987, 120);
            label2.Name = "label2";
            label2.Size = new Size(191, 54);
            label2.TabIndex = 15;
            label2.Text = "Welcome";
            label2.Click += label2_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(224, 224, 224);
            panel2.ForeColor = Color.FromArgb(224, 224, 224);
            panel2.Location = new Point(652, 52);
            panel2.Name = "panel2";
            panel2.Size = new Size(5, 625);
            panel2.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(36, 92);
            label3.Name = "label3";
            label3.Size = new Size(569, 106);
            label3.TabIndex = 0;
            label3.Text = "LIBRARY MANAGEMENT \r\nSYSTEM";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += label3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 28, 46);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1370, 710);
            Controls.Add(panel2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(text1);
            Controls.Add(checkadmin);
            Controls.Add(checkBox1);
            Controls.Add(sign);
            Controls.Add(hehe);
            Controls.Add(Login);
            Controls.Add(Pass);
            Controls.Add(userName);
            Controls.Add(text2);
            Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LMS";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox text1;
        private TextBox text2;
        private Label userName;
        private Label Pass;
        private Button Login;
        private Label hehe;
        private Button sign;
        private CheckBox checkBox1;
        private CheckBox checkadmin;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Panel panel2;
        private Label label3;
        private Label label4;
    }
}