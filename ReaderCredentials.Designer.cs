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
            readerId = new Label();
            readerName = new Label();
            readerPhoneNo = new Label();
            readerEmail = new Label();
            heading = new Label();
            signdash = new Label();
            signlabel = new Label();
            printIdCard = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            panel2 = new Panel();
            printDialog1 = new PrintDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)readerPicture).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // readerPicture
            // 
            readerPicture.BackColor = Color.Transparent;
            readerPicture.Location = new Point(38, 133);
            readerPicture.Margin = new Padding(3, 4, 3, 4);
            readerPicture.Name = "readerPicture";
            readerPicture.Size = new Size(137, 133);
            readerPicture.SizeMode = PictureBoxSizeMode.Zoom;
            readerPicture.TabIndex = 15;
            readerPicture.TabStop = false;
            readerPicture.Visible = false;
            // 
            // readerId
            // 
            readerId.AutoSize = true;
            readerId.BackColor = Color.Transparent;
            readerId.ForeColor = Color.Black;
            readerId.Location = new Point(38, 303);
            readerId.Name = "readerId";
            readerId.Size = new Size(50, 20);
            readerId.TabIndex = 16;
            readerId.Text = "label2";
            // 
            // readerName
            // 
            readerName.AutoSize = true;
            readerName.BackColor = Color.Transparent;
            readerName.ForeColor = Color.Black;
            readerName.Location = new Point(38, 347);
            readerName.Name = "readerName";
            readerName.Size = new Size(50, 20);
            readerName.TabIndex = 17;
            readerName.Text = "label3";
            // 
            // readerPhoneNo
            // 
            readerPhoneNo.AutoSize = true;
            readerPhoneNo.BackColor = Color.Transparent;
            readerPhoneNo.ForeColor = Color.Black;
            readerPhoneNo.Location = new Point(38, 392);
            readerPhoneNo.Name = "readerPhoneNo";
            readerPhoneNo.Size = new Size(50, 20);
            readerPhoneNo.TabIndex = 18;
            readerPhoneNo.Text = "label3";
            // 
            // readerEmail
            // 
            readerEmail.AutoSize = true;
            readerEmail.BackColor = Color.Transparent;
            readerEmail.ForeColor = Color.Black;
            readerEmail.Location = new Point(38, 443);
            readerEmail.Name = "readerEmail";
            readerEmail.Size = new Size(50, 20);
            readerEmail.TabIndex = 19;
            readerEmail.Text = "label3";
            // 
            // heading
            // 
            heading.AutoSize = true;
            heading.BackColor = Color.Transparent;
            heading.Font = new Font("Verdana", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            heading.ForeColor = Color.FromArgb(245, 244, 241);
            heading.Location = new Point(52, 10);
            heading.Name = "heading";
            heading.Size = new Size(335, 45);
            heading.TabIndex = 20;
            heading.Text = "LIBRARY CARD";
            // 
            // signdash
            // 
            signdash.AutoSize = true;
            signdash.BackColor = Color.Transparent;
            signdash.ForeColor = Color.FromArgb(0, 102, 140);
            signdash.Location = new Point(263, 683);
            signdash.Name = "signdash";
            signdash.Size = new Size(159, 20);
            signdash.TabIndex = 21;
            signdash.Text = "_________________________";
            // 
            // signlabel
            // 
            signlabel.AutoSize = true;
            signlabel.BackColor = Color.Transparent;
            signlabel.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            signlabel.ForeColor = Color.FromArgb(0, 102, 140);
            signlabel.Location = new Point(274, 703);
            signlabel.Name = "signlabel";
            signlabel.Size = new Size(134, 20);
            signlabel.TabIndex = 22;
            signlabel.Text = "Reader's Signnature";
            signlabel.Click += label2_Click;
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
            printIdCard.Location = new Point(374, 116);
            printIdCard.Margin = new Padding(3, 4, 3, 4);
            printIdCard.Name = "printIdCard";
            printIdCard.Size = new Size(34, 40);
            printIdCard.TabIndex = 30;
            printIdCard.TextAlign = ContentAlignment.BottomLeft;
            printIdCard.UseVisualStyleBackColor = false;
            printIdCard.Click += printIdCard_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 102, 140);
            panel1.Controls.Add(heading);
            panel1.Location = new Point(0, 16);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(442, 68);
            panel1.TabIndex = 31;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 102, 140);
            panel2.Location = new Point(0, 740);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(442, 41);
            panel2.TabIndex = 32;
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // ReaderCredentials
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 245, 249);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(440, 788);
            Controls.Add(signlabel);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(printIdCard);
            Controls.Add(readerPicture);
            Controls.Add(signdash);
            Controls.Add(readerEmail);
            Controls.Add(readerPhoneNo);
            Controls.Add(readerName);
            Controls.Add(readerId);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
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
        private Label readerId;
        private Label readerName;
        private Label readerPhoneNo;
        private Label readerEmail;
        private Label heading;
        private Label signdash;
        private Label signlabel;
        private FontAwesome.Sharp.IconButton printIdCard;
        private Panel panel1;
        private Panel panel2;
        private PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}