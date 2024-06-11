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
            readerPicture = new PictureBox();
            readerid = new Label();
            readername = new Label();
            readerphoneno = new Label();
            readeremail = new Label();
            heading = new Label();
            signdash = new Label();
            label2 = new Label();
            printIdCard = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)readerPicture).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // readerPicture
            // 
            readerPicture.BackColor = Color.Transparent;
            readerPicture.Location = new Point(33, 100);
            readerPicture.Name = "readerPicture";
            readerPicture.Size = new Size(120, 100);
            readerPicture.SizeMode = PictureBoxSizeMode.Zoom;
            readerPicture.TabIndex = 15;
            readerPicture.TabStop = false;
            readerPicture.Visible = false;
            // 
            // readerid
            // 
            readerid.AutoSize = true;
            readerid.BackColor = Color.Transparent;
            readerid.ForeColor = Color.Black;
            readerid.Location = new Point(33, 227);
            readerid.Name = "readerid";
            readerid.Size = new Size(38, 15);
            readerid.TabIndex = 16;
            readerid.Text = "label2";
            // 
            // readername
            // 
            readername.AutoSize = true;
            readername.BackColor = Color.Transparent;
            readername.ForeColor = Color.Black;
            readername.Location = new Point(33, 260);
            readername.Name = "readername";
            readername.Size = new Size(38, 15);
            readername.TabIndex = 17;
            readername.Text = "label3";
            // 
            // readerphoneno
            // 
            readerphoneno.AutoSize = true;
            readerphoneno.BackColor = Color.Transparent;
            readerphoneno.ForeColor = Color.Black;
            readerphoneno.Location = new Point(33, 294);
            readerphoneno.Name = "readerphoneno";
            readerphoneno.Size = new Size(38, 15);
            readerphoneno.TabIndex = 18;
            readerphoneno.Text = "label3";
            // 
            // readeremail
            // 
            readeremail.AutoSize = true;
            readeremail.BackColor = Color.Transparent;
            readeremail.ForeColor = Color.Black;
            readeremail.Location = new Point(33, 332);
            readeremail.Name = "readeremail";
            readeremail.Size = new Size(38, 15);
            readeremail.TabIndex = 19;
            readeremail.Text = "label3";
            // 
            // heading
            // 
            heading.AutoSize = true;
            heading.BackColor = Color.Transparent;
            heading.Font = new Font("Verdana", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            heading.ForeColor = Color.FromArgb(245, 244, 241);
            heading.Location = new Point(60, 8);
            heading.Name = "heading";
            heading.Size = new Size(262, 35);
            heading.TabIndex = 20;
            heading.Text = "LIBRARY CARD";
            // 
            // signdash
            // 
            signdash.AutoSize = true;
            signdash.BackColor = Color.Transparent;
            signdash.ForeColor = Color.FromArgb(0, 102, 140);
            signdash.Location = new Point(230, 512);
            signdash.Name = "signdash";
            signdash.Size = new Size(132, 15);
            signdash.TabIndex = 21;
            signdash.Text = "_________________________";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 102, 140);
            label2.Location = new Point(240, 527);
            label2.Name = "label2";
            label2.Size = new Size(113, 15);
            label2.TabIndex = 22;
            label2.Text = "Reader's Signnature";
            label2.Click += label2_Click;
            // 
            // printIdCard
            // 
            printIdCard.BackColor = Color.FromArgb(0, 102, 140);
            printIdCard.FlatStyle = FlatStyle.Popup;
            printIdCard.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            printIdCard.ForeColor = Color.White;
            printIdCard.IconChar = FontAwesome.Sharp.IconChar.FileDownload;
            printIdCard.IconColor = Color.WhiteSmoke;
            printIdCard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            printIdCard.IconSize = 20;
            printIdCard.Location = new Point(343, 100);
            printIdCard.Name = "printIdCard";
            printIdCard.Size = new Size(30, 30);
            printIdCard.TabIndex = 30;
            printIdCard.TextAlign = ContentAlignment.BottomLeft;
            printIdCard.UseVisualStyleBackColor = false;
            printIdCard.Click += printIdCard_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 102, 140);
            panel1.Controls.Add(heading);
            panel1.Location = new Point(0, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(387, 51);
            panel1.TabIndex = 31;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 102, 140);
            panel2.Location = new Point(0, 555);
            panel2.Name = "panel2";
            panel2.Size = new Size(387, 31);
            panel2.TabIndex = 32;
            // 
            // ReaderCredentials
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 245, 249);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(385, 591);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(printIdCard);
            Controls.Add(readerPicture);
            Controls.Add(signdash);
            Controls.Add(readeremail);
            Controls.Add(readerphoneno);
            Controls.Add(readername);
            Controls.Add(readerid);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ReaderCredentials";
            Text = "ReaderCredentials";
            Load += ReaderCredentials_Load;
            ((System.ComponentModel.ISupportInitialize)readerPicture).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox readerPicture;
        private Label readerid;
        private Label readername;
        private Label readerphoneno;
        private Label readeremail;
        private Label heading;
        private Label signdash;
        private Label label2;
        private FontAwesome.Sharp.IconButton printIdCard;
        private Panel panel1;
        private Panel panel2;
    }
}