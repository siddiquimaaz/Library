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
            ((System.ComponentModel.ISupportInitialize)readerPicture).BeginInit();
            SuspendLayout();
            // 
            // readerPicture
            // 
            readerPicture.BackColor = Color.Transparent;
            readerPicture.Location = new Point(363, 134);
            readerPicture.Margin = new Padding(3, 4, 3, 4);
            readerPicture.Name = "readerPicture";
            readerPicture.Size = new Size(139, 114);
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
            readerid.Location = new Point(407, 373);
            readerid.Name = "readerid";
            readerid.Size = new Size(50, 20);
            readerid.TabIndex = 16;
            readerid.Text = "label2";
            // 
            // readername
            // 
            readername.AutoSize = true;
            readername.BackColor = Color.Transparent;
            readername.ForeColor = Color.Black;
            readername.Location = new Point(407, 417);
            readername.Name = "readername";
            readername.Size = new Size(50, 20);
            readername.TabIndex = 17;
            readername.Text = "label3";
            // 
            // readerphoneno
            // 
            readerphoneno.AutoSize = true;
            readerphoneno.BackColor = Color.Transparent;
            readerphoneno.ForeColor = Color.Black;
            readerphoneno.Location = new Point(407, 463);
            readerphoneno.Name = "readerphoneno";
            readerphoneno.Size = new Size(50, 20);
            readerphoneno.TabIndex = 18;
            readerphoneno.Text = "label3";
            // 
            // readeremail
            // 
            readeremail.AutoSize = true;
            readeremail.BackColor = Color.Transparent;
            readeremail.ForeColor = Color.Black;
            readeremail.Location = new Point(407, 513);
            readeremail.Name = "readeremail";
            readeremail.Size = new Size(50, 20);
            readeremail.TabIndex = 19;
            readeremail.Text = "label3";
            // 
            // heading
            // 
            heading.AutoSize = true;
            heading.BackColor = Color.Transparent;
            heading.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            heading.ForeColor = Color.Black;
            heading.Location = new Point(349, 82);
            heading.Name = "heading";
            heading.Size = new Size(166, 37);
            heading.TabIndex = 20;
            heading.Text = "Library Card";
            // 
            // signdash
            // 
            signdash.AutoSize = true;
            signdash.BackColor = Color.Transparent;
            signdash.ForeColor = Color.Black;
            signdash.Location = new Point(362, 290);
            signdash.Name = "signdash";
            signdash.Size = new Size(141, 20);
            signdash.TabIndex = 21;
            signdash.Text = "______________________";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(365, 318);
            label2.Name = "label2";
            label2.Size = new Size(134, 20);
            label2.TabIndex = 22;
            label2.Text = "Reader's Signnature";
            label2.Click += label2_Click;
            // 
            // printIdCard
            // 
            printIdCard.BackColor = Color.Black;
            printIdCard.FlatStyle = FlatStyle.Popup;
            printIdCard.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            printIdCard.ForeColor = Color.White;
            printIdCard.IconChar = FontAwesome.Sharp.IconChar.FileDownload;
            printIdCard.IconColor = Color.WhiteSmoke;
            printIdCard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            printIdCard.IconSize = 38;
            printIdCard.Location = new Point(396, 579);
            printIdCard.Margin = new Padding(3, 4, 3, 4);
            printIdCard.Name = "printIdCard";
            printIdCard.Size = new Size(73, 63);
            printIdCard.TabIndex = 30;
            printIdCard.TextAlign = ContentAlignment.BottomLeft;
            printIdCard.UseVisualStyleBackColor = false;
            printIdCard.Click += printIdCard_Click;
            // 
            // ReaderCredentials
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(900, 900);
            Controls.Add(printIdCard);
            Controls.Add(readerPicture);
            Controls.Add(label2);
            Controls.Add(signdash);
            Controls.Add(heading);
            Controls.Add(readeremail);
            Controls.Add(readerphoneno);
            Controls.Add(readername);
            Controls.Add(readerid);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "ReaderCredentials";
            Text = "ReaderCredentials";
            Load += ReaderCredentials_Load;
            ((System.ComponentModel.ISupportInitialize)readerPicture).EndInit();
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
    }
}