namespace Library
{
    partial class ReaderCredentials
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReaderCredentials));
            pictureBox1 = new PictureBox();
            readerid = new Label();
            readername = new Label();
            readerphoneno = new Label();
            readeremail = new Label();
            heading = new Label();
            signdash = new Label();
            label2 = new Label();
            PrintReaderIDCard = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Location = new Point(114, 105);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 80);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // readerid
            // 
            readerid.AutoSize = true;
            readerid.BackColor = Color.Transparent;
            readerid.ForeColor = Color.White;
            readerid.Location = new Point(25, 224);
            readerid.Name = "readerid";
            readerid.Size = new Size(38, 15);
            readerid.TabIndex = 16;
            readerid.Text = "label2";
            // 
            // readername
            // 
            readername.AutoSize = true;
            readername.BackColor = Color.Transparent;
            readername.ForeColor = Color.White;
            readername.Location = new Point(25, 257);
            readername.Name = "readername";
            readername.Size = new Size(38, 15);
            readername.TabIndex = 17;
            readername.Text = "label3";
            // 
            // readerphoneno
            // 
            readerphoneno.AutoSize = true;
            readerphoneno.BackColor = Color.Transparent;
            readerphoneno.ForeColor = Color.White;
            readerphoneno.Location = new Point(25, 292);
            readerphoneno.Name = "readerphoneno";
            readerphoneno.Size = new Size(38, 15);
            readerphoneno.TabIndex = 18;
            readerphoneno.Text = "label3";
            // 
            // readeremail
            // 
            readeremail.AutoSize = true;
            readeremail.BackColor = Color.Transparent;
            readeremail.ForeColor = Color.White;
            readeremail.Location = new Point(25, 329);
            readeremail.Name = "readeremail";
            readeremail.Size = new Size(38, 15);
            readeremail.TabIndex = 19;
            readeremail.Text = "label3";
            // 
            // heading
            // 
            heading.AutoSize = true;
            heading.BackColor = Color.Transparent;
            heading.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            heading.ForeColor = Color.White;
            heading.Location = new Point(99, 42);
            heading.Name = "heading";
            heading.Size = new Size(131, 30);
            heading.TabIndex = 20;
            heading.Text = "Library Card";
            // 
            // signdash
            // 
            signdash.AutoSize = true;
            signdash.BackColor = Color.Transparent;
            signdash.ForeColor = Color.White;
            signdash.Location = new Point(217, 465);
            signdash.Name = "signdash";
            signdash.Size = new Size(117, 15);
            signdash.TabIndex = 21;
            signdash.Text = "______________________";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(219, 486);
            label2.Name = "label2";
            label2.Size = new Size(113, 15);
            label2.TabIndex = 22;
            label2.Text = "Reader's Signnature";
            label2.Click += label2_Click;
            // 
            // PrintReaderIDCard
            // 
            PrintReaderIDCard.BackColor = Color.Black;
            PrintReaderIDCard.FlatStyle = FlatStyle.Popup;
            PrintReaderIDCard.IconChar = FontAwesome.Sharp.IconChar.Print;
            PrintReaderIDCard.IconColor = Color.White;
            PrintReaderIDCard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            PrintReaderIDCard.IconSize = 28;
            PrintReaderIDCard.Location = new Point(288, 41);
            PrintReaderIDCard.Name = "PrintReaderIDCard";
            PrintReaderIDCard.Size = new Size(50, 35);
            PrintReaderIDCard.TabIndex = 23;
            PrintReaderIDCard.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(6, 7);
            panel1.Name = "panel1";
            panel1.Size = new Size(348, 528);
            panel1.TabIndex = 24;
            // 
            // ReaderCredentials
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(359, 541);
            Controls.Add(PrintReaderIDCard);
            Controls.Add(label2);
            Controls.Add(signdash);
            Controls.Add(heading);
            Controls.Add(readeremail);
            Controls.Add(readerphoneno);
            Controls.Add(readername);
            Controls.Add(readerid);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ReaderCredentials";
            Text = "ReaderCredentials";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Label readerid;
        private Label readername;
        private Label readerphoneno;
        private Label readeremail;
        private Label heading;
        private Label signdash;
        private Label label2;
        private FontAwesome.Sharp.IconButton PrintReaderIDCard;
        private Panel panel1;
    }
}