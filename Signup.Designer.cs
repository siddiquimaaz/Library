namespace Library
{
    partial class Signup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signup));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            button1 = new Button();
            lastnametxt = new TextBox();
            phonenumbertxt = new TextBox();
            emailtxt = new TextBox();
            passwordtxt = new TextBox();
            repasswordtxt = new TextBox();
            button2 = new Button();
            firstnametxt = new TextBox();
            openFileDialog1 = new OpenFileDialog();
            openFileDialog2 = new OpenFileDialog();
            openFileDialog3 = new OpenFileDialog();
            addpic = new PictureBox();
            selectimg = new Button();
            label9 = new Label();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)addpic).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(480, 94);
            label1.Name = "label1";
            label1.Size = new Size(241, 41);
            label1.TabIndex = 0;
            label1.Text = "Jaun Elia Library";
            //label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(264, 167);
            label2.Name = "label2";
            label2.Size = new Size(74, 24);
            label2.TabIndex = 1;
            label2.Text = "Sign-Up";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(41, 221);
            label3.Name = "label3";
            label3.Size = new Size(104, 20);
            label3.TabIndex = 2;
            label3.Text = "first-Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.FlatStyle = FlatStyle.Popup;
            label4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(41, 259);
            label4.Name = "label4";
            label4.Size = new Size(107, 20);
            label4.TabIndex = 3;
            label4.Text = "Last-Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.FlatStyle = FlatStyle.Popup;
            label5.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(41, 297);
            label5.Name = "label5";
            label5.Size = new Size(139, 20);
            label5.TabIndex = 4;
            label5.Text = "Phone-Number:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.FlatStyle = FlatStyle.Popup;
            label6.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(41, 335);
            label6.Name = "label6";
            label6.Size = new Size(62, 20);
            label6.TabIndex = 5;
            label6.Text = "Email:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.FlatStyle = FlatStyle.Popup;
            label7.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(41, 377);
            label7.Name = "label7";
            label7.Size = new Size(97, 20);
            label7.TabIndex = 6;
            label7.Text = "Password:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.FlatStyle = FlatStyle.Popup;
            label8.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(41, 417);
            label8.Name = "label8";
            label8.Size = new Size(168, 20);
            label8.TabIndex = 7;
            label8.Text = "Re-type Password:";
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.ForeColor = Color.White;
            button1.Location = new Point(218, 469);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 42);
            button1.TabIndex = 8;
            button1.Text = "Sign-up";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // lastnametxt
            // 
            lastnametxt.BackColor = Color.Black;
            lastnametxt.ForeColor = Color.White;
            lastnametxt.Location = new Point(218, 256);
            lastnametxt.Margin = new Padding(3, 4, 3, 4);
            lastnametxt.Name = "lastnametxt";
            lastnametxt.PlaceholderText = "Enter last name";
            lastnametxt.Size = new Size(178, 27);
            lastnametxt.TabIndex = 10;
            lastnametxt.TextAlign = HorizontalAlignment.Center;
            // 
            // phonenumbertxt
            // 
            phonenumbertxt.BackColor = Color.Black;
            phonenumbertxt.ForeColor = Color.White;
            phonenumbertxt.Location = new Point(218, 294);
            phonenumbertxt.Margin = new Padding(3, 4, 3, 4);
            phonenumbertxt.Name = "phonenumbertxt";
            phonenumbertxt.PlaceholderText = "Enter Phone Number";
            phonenumbertxt.Size = new Size(178, 27);
            phonenumbertxt.TabIndex = 11;
            phonenumbertxt.TextAlign = HorizontalAlignment.Center;
            // 
            // emailtxt
            // 
            emailtxt.BackColor = Color.Black;
            emailtxt.ForeColor = Color.White;
            emailtxt.Location = new Point(218, 332);
            emailtxt.Margin = new Padding(3, 4, 3, 4);
            emailtxt.Name = "emailtxt";
            emailtxt.PlaceholderText = "Enter email";
            emailtxt.Size = new Size(178, 27);
            emailtxt.TabIndex = 12;
            emailtxt.TextAlign = HorizontalAlignment.Center;
            // 
            // passwordtxt
            // 
            passwordtxt.BackColor = Color.Black;
            passwordtxt.ForeColor = Color.White;
            passwordtxt.Location = new Point(218, 370);
            passwordtxt.Margin = new Padding(3, 4, 3, 4);
            passwordtxt.Name = "passwordtxt";
            passwordtxt.PlaceholderText = "Enter Passowrd";
            passwordtxt.Size = new Size(178, 27);
            passwordtxt.TabIndex = 13;
            passwordtxt.TextAlign = HorizontalAlignment.Center;
            passwordtxt.UseSystemPasswordChar = true;
            // 
            // repasswordtxt
            // 
            repasswordtxt.BackColor = Color.Black;
            repasswordtxt.ForeColor = Color.White;
            repasswordtxt.Location = new Point(218, 414);
            repasswordtxt.Margin = new Padding(3, 4, 3, 4);
            repasswordtxt.Name = "repasswordtxt";
            repasswordtxt.PlaceholderText = "Re-Enter Password";
            repasswordtxt.Size = new Size(178, 27);
            repasswordtxt.TabIndex = 14;
            repasswordtxt.TextAlign = HorizontalAlignment.Center;
            repasswordtxt.UseSystemPasswordChar = true;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(329, 469);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(86, 42);
            button2.TabIndex = 15;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // firstnametxt
            // 
            firstnametxt.BackColor = Color.Black;
            firstnametxt.ForeColor = Color.White;
            firstnametxt.Location = new Point(218, 218);
            firstnametxt.Name = "firstnametxt";
            firstnametxt.PlaceholderText = "Enter first name";
            firstnametxt.Size = new Size(178, 27);
            firstnametxt.TabIndex = 16;
            firstnametxt.TextAlign = HorizontalAlignment.Center;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            openFileDialog2.FileName = "openFileDialog2";
            // 
            // openFileDialog3
            // 
            openFileDialog3.FileName = "openFileDialog3";
            // 
            // addpic
            // 
            addpic.BackColor = Color.Transparent;
            addpic.InitialImage = (Image)resources.GetObject("addpic.InitialImage");
            addpic.Location = new Point(41, 48);
            addpic.Name = "addpic";
            addpic.Size = new Size(125, 116);
            addpic.SizeMode = PictureBoxSizeMode.Zoom;
            addpic.TabIndex = 18;
            addpic.TabStop = false;
            addpic.Visible = false;
            addpic.WaitOnLoad = true;
            // 
            // selectimg
            // 
            selectimg.BackColor = Color.Transparent;
            selectimg.FlatStyle = FlatStyle.Popup;
            selectimg.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point);
            selectimg.ForeColor = Color.Transparent;
            selectimg.Location = new Point(329, 545);
            selectimg.Name = "selectimg";
            selectimg.Size = new Size(86, 42);
            selectimg.TabIndex = 19;
            selectimg.Text = "Browse...";
            selectimg.UseVisualStyleBackColor = false;
            selectimg.Click += selectimg_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(134, 563);
            label9.Name = "label9";
            label9.Size = new Size(180, 24);
            label9.TabIndex = 20;
            label9.Text = "Please Select Image!";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(475, 9);
            label10.Name = "label10";
            label10.Size = new Size(251, 54);
            label10.TabIndex = 21;
            label10.Text = "Welcome to ";
            // 
            // Signup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1371, 704);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(selectimg);
            Controls.Add(addpic);
            Controls.Add(firstnametxt);
            Controls.Add(button2);
            Controls.Add(repasswordtxt);
            Controls.Add(passwordtxt);
            Controls.Add(emailtxt);
            Controls.Add(phonenumbertxt);
            Controls.Add(lastnametxt);
            Controls.Add(button1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Signup";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Back";
            ((System.ComponentModel.ISupportInitialize)addpic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button button1;
        private TextBox lastnametxt;
        private TextBox phonenumbertxt;
        private TextBox emailtxt;
        private TextBox passwordtxt;
        private TextBox repasswordtxt;
        private Button button2;
        private TextBox firstnametxt;
        private OpenFileDialog openFileDialog1;
        private OpenFileDialog openFileDialog2;
        private OpenFileDialog openFileDialog3;
        private PictureBox addpic;
        private Button selectimg;
        private Label label9;
        private Label label10;
    }
}