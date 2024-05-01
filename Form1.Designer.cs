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
            Head = new Label();
            tag = new Label();
            Login = new Button();
            hehe = new Label();
            sign = new Button();
            checkBox1 = new CheckBox();
            checkadmin = new CheckBox();
            SuspendLayout();
            // 
            // text1
            // 
            text1.BackColor = Color.Black;
            text1.BorderStyle = BorderStyle.FixedSingle;
            text1.ForeColor = Color.WhiteSmoke;
            text1.Location = new Point(188, 264);
            text1.Margin = new Padding(3, 4, 3, 4);
            text1.Name = "text1";
            text1.PlaceholderText = "Enter user name";
            text1.Size = new Size(188, 27);
            text1.TabIndex = 0;
            text1.TextAlign = HorizontalAlignment.Center;
            // 
            // text2
            // 
            text2.BackColor = Color.Black;
            text2.BorderStyle = BorderStyle.FixedSingle;
            text2.ForeColor = Color.White;
            text2.Location = new Point(188, 336);
            text2.Margin = new Padding(3, 4, 3, 4);
            text2.Name = "text2";
            text2.PlaceholderText = "Enter your Password";
            text2.Size = new Size(188, 27);
            text2.TabIndex = 1;
            text2.TextAlign = HorizontalAlignment.Center;
            text2.UseSystemPasswordChar = true;
            // 
            // userName
            // 
            userName.AutoSize = true;
            userName.BackColor = Color.Transparent;
            userName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            userName.ForeColor = Color.White;
            userName.Location = new Point(62, 263);
            userName.Name = "userName";
            userName.Size = new Size(119, 28);
            userName.TabIndex = 2;
            userName.Text = "User-Name:";
            // 
            // Pass
            // 
            Pass.AutoSize = true;
            Pass.BackColor = Color.Transparent;
            Pass.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Pass.ForeColor = Color.White;
            Pass.Location = new Point(62, 335);
            Pass.Name = "Pass";
            Pass.Size = new Size(102, 28);
            Pass.TabIndex = 3;
            Pass.Text = "Password:";
            // 
            // Head
            // 
            Head.AutoSize = true;
            Head.BackColor = Color.Transparent;
            Head.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            Head.ForeColor = Color.White;
            Head.Location = new Point(476, 64);
            Head.Name = "Head";
            Head.Size = new Size(249, 41);
            Head.TabIndex = 4;
            Head.Text = "Jaun Elia Library";
            // 
            // tag
            // 
            tag.AutoSize = true;
            tag.BackColor = Color.Transparent;
            tag.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            tag.ForeColor = Color.White;
            tag.Location = new Point(511, 9);
            tag.Name = "tag";
            tag.Size = new Size(178, 41);
            tag.TabIndex = 5;
            tag.Text = "Welcome to";
            // 
            // Login
            // 
            Login.BackColor = Color.Black;
            Login.ForeColor = SystemColors.Info;
            Login.Location = new Point(228, 397);
            Login.Margin = new Padding(3, 4, 3, 4);
            Login.Name = "Login";
            Login.Size = new Size(86, 31);
            Login.TabIndex = 6;
            Login.Text = "Logiin";
            Login.UseVisualStyleBackColor = false;
            Login.Click += Login_Click;
            // 
            // hehe
            // 
            hehe.AutoSize = true;
            hehe.BackColor = Color.Transparent;
            hehe.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            hehe.ForeColor = Color.White;
            hehe.Location = new Point(51, 483);
            hehe.Name = "hehe";
            hehe.Size = new Size(315, 23);
            hehe.TabIndex = 7;
            hehe.Text = "Did not have any accout? Register here:";
            // 
            // sign
            // 
            sign.BackColor = Color.Black;
            sign.ForeColor = SystemColors.Menu;
            sign.Location = new Point(382, 475);
            sign.Margin = new Padding(3, 4, 3, 4);
            sign.Name = "sign";
            sign.Size = new Size(86, 31);
            sign.TabIndex = 8;
            sign.Text = "Sign-Up";
            sign.UseVisualStyleBackColor = false;
            sign.Click += sign_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.Transparent;
            checkBox1.Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox1.ForeColor = Color.White;
            checkBox1.Location = new Point(382, 341);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(70, 25);
            checkBox1.TabIndex = 11;
            checkBox1.Text = "show";
            checkBox1.TextAlign = ContentAlignment.MiddleCenter;
            checkBox1.UseVisualStyleBackColor = false;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkadmin
            // 
            checkadmin.AutoSize = true;
            checkadmin.BackColor = Color.Transparent;
            checkadmin.Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            checkadmin.ForeColor = Color.White;
            checkadmin.Location = new Point(320, 404);
            checkadmin.Name = "checkadmin";
            checkadmin.Size = new Size(78, 25);
            checkadmin.TabIndex = 12;
            checkadmin.Text = "Admin";
            checkadmin.TextAlign = ContentAlignment.MiddleCenter;
            checkadmin.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1403, 730);
            Controls.Add(text1);
            Controls.Add(checkadmin);
            Controls.Add(checkBox1);
            Controls.Add(sign);
            Controls.Add(hehe);
            Controls.Add(Login);
            Controls.Add(tag);
            Controls.Add(Head);
            Controls.Add(Pass);
            Controls.Add(userName);
            Controls.Add(text2);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LMS";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox text1;
        private TextBox text2;
        private Label userName;
        private Label Pass;
        private Label Head;
        private Label tag;
        private Button Login;
        private Label hehe;
        private Button sign;
        private CheckBox checkBox1;
        private CheckBox checkadmin;
    }
}