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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // text1
            // 
            text1.BackColor = Color.White;
            text1.BorderStyle = BorderStyle.FixedSingle;
            text1.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            text1.ForeColor = Color.Black;
            text1.Location = new Point(19, 259);
            text1.Margin = new Padding(3, 4, 3, 4);
            text1.Name = "text1";
            text1.PlaceholderText = "Enter username";
            text1.Size = new Size(360, 27);
            text1.TabIndex = 0;
            text1.TextAlign = HorizontalAlignment.Center;
            // 
            // text2
            // 
            text2.BackColor = Color.White;
            text2.BorderStyle = BorderStyle.FixedSingle;
            text2.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            text2.ForeColor = Color.Black;
            text2.Location = new Point(19, 331);
            text2.Margin = new Padding(3, 4, 3, 4);
            text2.Name = "text2";
            text2.PlaceholderText = "Enter your Password";
            text2.Size = new Size(360, 27);
            text2.TabIndex = 1;
            text2.TextAlign = HorizontalAlignment.Center;
            text2.UseSystemPasswordChar = true;
            // 
            // userName
            // 
            userName.AutoSize = true;
            userName.BackColor = Color.Transparent;
            userName.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            userName.ForeColor = Color.Black;
            userName.Location = new Point(10, 236);
            userName.Name = "userName";
            userName.Size = new Size(110, 23);
            userName.TabIndex = 2;
            userName.Text = "User-Name:";
            // 
            // Pass
            // 
            Pass.AutoSize = true;
            Pass.BackColor = Color.Transparent;
            Pass.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Pass.ForeColor = Color.Black;
            Pass.Location = new Point(10, 307);
            Pass.Name = "Pass";
            Pass.Size = new Size(95, 23);
            Pass.TabIndex = 3;
            Pass.Text = "Password:";
            // 
            // Login
            // 
            Login.BackColor = Color.FromArgb(192, 192, 255);
            Login.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            Login.ForeColor = Color.White;
            Login.Location = new Point(18, 388);
            Login.Margin = new Padding(3, 4, 3, 4);
            Login.Name = "Login";
            Login.Size = new Size(362, 48);
            Login.TabIndex = 6;
            Login.Text = "Login";
            Login.UseVisualStyleBackColor = false;
            Login.Click += Login_Click;
            // 
            // hehe
            // 
            hehe.AutoSize = true;
            hehe.BackColor = Color.Transparent;
            hehe.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            hehe.ForeColor = Color.Black;
            hehe.Location = new Point(19, 476);
            hehe.Name = "hehe";
            hehe.Size = new Size(238, 18);
            hehe.TabIndex = 7;
            hehe.Text = "Don't have account? Register here:";
            // 
            // sign
            // 
            sign.BackColor = Color.White;
            sign.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            sign.ForeColor = Color.FromArgb(192, 192, 255);
            sign.Location = new Point(21, 499);
            sign.Margin = new Padding(3, 4, 3, 4);
            sign.Name = "sign";
            sign.Size = new Size(357, 56);
            sign.TabIndex = 8;
            sign.Text = "Sign-Up";
            sign.UseVisualStyleBackColor = false;
            sign.Click += sign_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.Transparent;
            checkBox1.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.ForeColor = Color.Black;
            checkBox1.Location = new Point(14, 362);
            checkBox1.Margin = new Padding(3, 2, 3, 2);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(130, 22);
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
            checkadmin.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            checkadmin.ForeColor = Color.Black;
            checkadmin.Location = new Point(311, 362);
            checkadmin.Margin = new Padding(3, 2, 3, 2);
            checkadmin.Name = "checkadmin";
            checkadmin.Size = new Size(70, 22);
            checkadmin.TabIndex = 12;
            checkadmin.Text = "Admin";
            checkadmin.TextAlign = ContentAlignment.MiddleCenter;
            checkadmin.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 192, 255);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(2);
            panel1.Size = new Size(387, 41);
            panel1.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(361, 13);
            label1.Name = "label1";
            label1.Size = new Size(19, 20);
            label1.TabIndex = 14;
            label1.Text = "X";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(147, 58);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(104, 98);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Forte", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(135, 160);
            label2.Name = "label2";
            label2.Size = new Size(129, 32);
            label2.TabIndex = 15;
            label2.Text = "Welcome";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(387, 570);
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
    }
}