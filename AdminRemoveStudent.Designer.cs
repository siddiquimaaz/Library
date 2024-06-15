namespace Library
{
    partial class AdminRemoveStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminRemoveStudent));
            panel2 = new Panel();
            AdminRemoveReaderBackBtn = new FontAwesome.Sharp.IconButton();
            pictureBox1 = new PictureBox();
            TerminateMemberSearchbtn = new FontAwesome.Sharp.IconButton();
            TerminateBtn = new FontAwesome.Sharp.IconButton();
            ReaderID = new TextBox();
            label1 = new Label();
            TerminateMembershipAdminPanel = new DataGridView();
            panel1 = new Panel();
            label4 = new Label();
            label2 = new Label();
            AdminRemoveStudentCloseLabel = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TerminateMembershipAdminPanel).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(31, 58, 95);
            panel2.Controls.Add(AdminRemoveReaderBackBtn);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(TerminateMemberSearchbtn);
            panel2.Controls.Add(TerminateBtn);
            panel2.Controls.Add(ReaderID);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(8, 57);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(335, 835);
            panel2.TabIndex = 18;
            panel2.Paint += panel2_Paint;
            // 
            // AdminRemoveReaderBackBtn
            // 
            AdminRemoveReaderBackBtn.BackColor = Color.FromArgb(31, 43, 62);
            AdminRemoveReaderBackBtn.FlatStyle = FlatStyle.Popup;
            AdminRemoveReaderBackBtn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            AdminRemoveReaderBackBtn.ForeColor = Color.White;
            AdminRemoveReaderBackBtn.IconChar = FontAwesome.Sharp.IconChar.Backspace;
            AdminRemoveReaderBackBtn.IconColor = Color.White;
            AdminRemoveReaderBackBtn.IconFont = FontAwesome.Sharp.IconFont.Solid;
            AdminRemoveReaderBackBtn.IconSize = 20;
            AdminRemoveReaderBackBtn.ImageAlign = ContentAlignment.MiddleLeft;
            AdminRemoveReaderBackBtn.Location = new Point(19, 671);
            AdminRemoveReaderBackBtn.Name = "AdminRemoveReaderBackBtn";
            AdminRemoveReaderBackBtn.Size = new Size(84, 35);
            AdminRemoveReaderBackBtn.TabIndex = 42;
            AdminRemoveReaderBackBtn.Text = "Back";
            AdminRemoveReaderBackBtn.TextAlign = ContentAlignment.MiddleRight;
            AdminRemoveReaderBackBtn.UseVisualStyleBackColor = false;
            AdminRemoveReaderBackBtn.Click += AdminRemoveReaderBackBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(50, 63);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(229, 267);
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // TerminateMemberSearchbtn
            // 
            TerminateMemberSearchbtn.BackColor = Color.FromArgb(31, 43, 62);
            TerminateMemberSearchbtn.Cursor = Cursors.Hand;
            TerminateMemberSearchbtn.FlatStyle = FlatStyle.Flat;
            TerminateMemberSearchbtn.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            TerminateMemberSearchbtn.ForeColor = Color.White;
            TerminateMemberSearchbtn.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            TerminateMemberSearchbtn.IconColor = Color.White;
            TerminateMemberSearchbtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            TerminateMemberSearchbtn.IconSize = 20;
            TerminateMemberSearchbtn.ImageAlign = ContentAlignment.MiddleLeft;
            TerminateMemberSearchbtn.Location = new Point(22, 455);
            TerminateMemberSearchbtn.Name = "TerminateMemberSearchbtn";
            TerminateMemberSearchbtn.Padding = new Padding(1);
            TerminateMemberSearchbtn.Size = new Size(88, 33);
            TerminateMemberSearchbtn.TabIndex = 23;
            TerminateMemberSearchbtn.Text = "Search";
            TerminateMemberSearchbtn.TextAlign = ContentAlignment.MiddleRight;
            TerminateMemberSearchbtn.UseVisualStyleBackColor = false;
            TerminateMemberSearchbtn.Click += TerminateMemberSearchbtn_Click;
            // 
            // TerminateBtn
            // 
            TerminateBtn.BackColor = Color.FromArgb(31, 43, 62);
            TerminateBtn.FlatStyle = FlatStyle.Flat;
            TerminateBtn.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            TerminateBtn.ForeColor = Color.White;
            TerminateBtn.IconChar = FontAwesome.Sharp.IconChar.IdBadge;
            TerminateBtn.IconColor = Color.White;
            TerminateBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            TerminateBtn.IconSize = 44;
            TerminateBtn.ImageAlign = ContentAlignment.MiddleLeft;
            TerminateBtn.Location = new Point(22, 563);
            TerminateBtn.Margin = new Padding(3, 4, 3, 4);
            TerminateBtn.Name = "TerminateBtn";
            TerminateBtn.Size = new Size(229, 69);
            TerminateBtn.TabIndex = 22;
            TerminateBtn.Text = "Terminate";
            TerminateBtn.UseVisualStyleBackColor = false;
            TerminateBtn.Click += TerminateBtn_Click;
            // 
            // ReaderID
            // 
            ReaderID.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            ReaderID.Location = new Point(22, 412);
            ReaderID.Margin = new Padding(3, 4, 3, 4);
            ReaderID.Name = "ReaderID";
            ReaderID.PlaceholderText = "Enter Reader ID";
            ReaderID.Size = new Size(230, 24);
            ReaderID.TabIndex = 20;
            ReaderID.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(19, 387);
            label1.Name = "label1";
            label1.Size = new Size(78, 17);
            label1.TabIndex = 19;
            label1.Text = "Reader ID";
            // 
            // TerminateMembershipAdminPanel
            // 
            TerminateMembershipAdminPanel.AllowUserToAddRows = false;
            TerminateMembershipAdminPanel.AllowUserToDeleteRows = false;
            TerminateMembershipAdminPanel.AllowUserToOrderColumns = true;
            TerminateMembershipAdminPanel.AllowUserToResizeColumns = false;
            TerminateMembershipAdminPanel.AllowUserToResizeRows = false;
            TerminateMembershipAdminPanel.BackgroundColor = Color.White;
            TerminateMembershipAdminPanel.BorderStyle = BorderStyle.Fixed3D;
            TerminateMembershipAdminPanel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TerminateMembershipAdminPanel.Location = new Point(351, 57);
            TerminateMembershipAdminPanel.Margin = new Padding(3, 4, 3, 4);
            TerminateMembershipAdminPanel.Name = "TerminateMembershipAdminPanel";
            TerminateMembershipAdminPanel.RowHeadersWidth = 51;
            TerminateMembershipAdminPanel.RowTemplate.Height = 25;
            TerminateMembershipAdminPanel.ScrollBars = ScrollBars.Vertical;
            TerminateMembershipAdminPanel.Size = new Size(1215, 835);
            TerminateMembershipAdminPanel.TabIndex = 0;
            TerminateMembershipAdminPanel.CellContentClick += TerminateMembershipAdminPanel_CellContentClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(55, 67, 87);
            panel1.Controls.Add(AdminRemoveStudentCloseLabel);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 5, 3, 5);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(2, 1, 2, 1);
            panel1.Size = new Size(1566, 48);
            panel1.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(10, 12);
            label4.Name = "label4";
            label4.Size = new Size(557, 20);
            label4.TabIndex = 17;
            label4.Text = "Library Management System | Admin Panel | Membership";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(1569, 12);
            label2.Name = "label2";
            label2.Size = new Size(19, 20);
            label2.TabIndex = 14;
            label2.Text = "X";
            // 
            // AdminRemoveStudentCloseLabel
            // 
            AdminRemoveStudentCloseLabel.AutoSize = true;
            AdminRemoveStudentCloseLabel.BackColor = Color.Transparent;
            AdminRemoveStudentCloseLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            AdminRemoveStudentCloseLabel.ForeColor = Color.FromArgb(255, 254, 251);
            AdminRemoveStudentCloseLabel.ImeMode = ImeMode.NoControl;
            AdminRemoveStudentCloseLabel.Location = new Point(1535, 12);
            AdminRemoveStudentCloseLabel.Name = "AdminRemoveStudentCloseLabel";
            AdminRemoveStudentCloseLabel.Size = new Size(19, 20);
            AdminRemoveStudentCloseLabel.TabIndex = 43;
            AdminRemoveStudentCloseLabel.Text = "X";
            AdminRemoveStudentCloseLabel.Click += AdminRemoveStudentCloseLabel_Click;
            // 
            // AdminRemoveStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 28, 46);
            ClientSize = new Size(1566, 892);
            Controls.Add(panel1);
            Controls.Add(TerminateMembershipAdminPanel);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "AdminRemoveStudent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminRemoveStudent";
            Load += AdminRemoveStudent_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)TerminateMembershipAdminPanel).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private DataGridView TerminateMembershipAdminPanel;
        private Label label1;
        private TextBox ReaderID;
        private FontAwesome.Sharp.IconButton TerminateBtn;
        private FontAwesome.Sharp.IconButton TerminateMemberSearchbtn;
        private Panel panel1;
        private Label label4;
        private Label label2;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton AdminRemoveReaderBackBtn;
        private Label AdminRemoveStudentCloseLabel;
    }
}