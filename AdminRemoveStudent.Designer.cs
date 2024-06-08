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
            TerminateMemberBackBtn = new Button();
            TerminateMemberSearch = new FontAwesome.Sharp.IconButton();
            TerminateBtn = new FontAwesome.Sharp.IconButton();
            ReaderID = new TextBox();
            label1 = new Label();
            TerminateMembershipAdminPanel = new DataGridView();
            panel1 = new Panel();
            label4 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TerminateMembershipAdminPanel).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(31, 58, 95);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(TerminateMemberBackBtn);
            panel2.Controls.Add(TerminateMemberSearch);
            panel2.Controls.Add(TerminateBtn);
            panel2.Controls.Add(ReaderID);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(7, 43);
            panel2.Name = "panel2";
            panel2.Size = new Size(293, 657);
            panel2.TabIndex = 18;
            panel2.Paint += panel2_Paint;
            // 
            // TerminateMemberBackBtn
            // 
            TerminateMemberBackBtn.BackColor = Color.White;
            TerminateMemberBackBtn.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            TerminateMemberBackBtn.Location = new Point(14, 617);
            TerminateMemberBackBtn.Name = "TerminateMemberBackBtn";
            TerminateMemberBackBtn.Size = new Size(75, 23);
            TerminateMemberBackBtn.TabIndex = 24;
            TerminateMemberBackBtn.Text = "Back";
            TerminateMemberBackBtn.UseVisualStyleBackColor = false;
            // 
            // TerminateMemberSearch
            // 
            TerminateMemberSearch.BackColor = Color.FromArgb(31, 43, 62);
            TerminateMemberSearch.Cursor = Cursors.Hand;
            TerminateMemberSearch.FlatStyle = FlatStyle.Flat;
            TerminateMemberSearch.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            TerminateMemberSearch.ForeColor = Color.White;
            TerminateMemberSearch.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            TerminateMemberSearch.IconColor = Color.White;
            TerminateMemberSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            TerminateMemberSearch.IconSize = 20;
            TerminateMemberSearch.ImageAlign = ContentAlignment.MiddleLeft;
            TerminateMemberSearch.Location = new Point(19, 341);
            TerminateMemberSearch.Margin = new Padding(3, 2, 3, 2);
            TerminateMemberSearch.Name = "TerminateMemberSearch";
            TerminateMemberSearch.Padding = new Padding(1);
            TerminateMemberSearch.Size = new Size(77, 25);
            TerminateMemberSearch.TabIndex = 23;
            TerminateMemberSearch.Text = "Search";
            TerminateMemberSearch.TextAlign = ContentAlignment.MiddleRight;
            TerminateMemberSearch.UseVisualStyleBackColor = false;
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
            TerminateBtn.IconSize = 40;
            TerminateBtn.ImageAlign = ContentAlignment.MiddleLeft;
            TerminateBtn.Location = new Point(19, 422);
            TerminateBtn.Name = "TerminateBtn";
            TerminateBtn.Size = new Size(200, 52);
            TerminateBtn.TabIndex = 22;
            TerminateBtn.Text = "Terminate";
            TerminateBtn.UseVisualStyleBackColor = false;
            // 
            // ReaderID
            // 
            ReaderID.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            ReaderID.Location = new Point(19, 309);
            ReaderID.Name = "ReaderID";
            ReaderID.Size = new Size(202, 21);
            ReaderID.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(17, 290);
            label1.Name = "label1";
            label1.Size = new Size(66, 13);
            label1.TabIndex = 19;
            label1.Text = "Reader ID";
            // 
            // TerminateMembershipAdminPanel
            // 
            TerminateMembershipAdminPanel.BackgroundColor = Color.White;
            TerminateMembershipAdminPanel.BorderStyle = BorderStyle.Fixed3D;
            TerminateMembershipAdminPanel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TerminateMembershipAdminPanel.Location = new Point(307, 43);
            TerminateMembershipAdminPanel.Name = "TerminateMembershipAdminPanel";
            TerminateMembershipAdminPanel.RowHeadersWidth = 51;
            TerminateMembershipAdminPanel.RowTemplate.Height = 25;
            TerminateMembershipAdminPanel.Size = new Size(1083, 661);
            TerminateMembershipAdminPanel.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(55, 67, 87);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(2, 1, 2, 1);
            panel1.Size = new Size(1370, 36);
            panel1.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(9, 9);
            label4.Name = "label4";
            label4.Size = new Size(427, 16);
            label4.TabIndex = 17;
            label4.Text = "Library Management System | Admin Panel | Membership";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(1373, 9);
            label2.Name = "label2";
            label2.Size = new Size(15, 15);
            label2.TabIndex = 14;
            label2.Text = "X";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(44, 47);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 200);
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // AdminRemoveStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 28, 46);
            ClientSize = new Size(1370, 710);
            Controls.Add(panel1);
            Controls.Add(TerminateMembershipAdminPanel);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminRemoveStudent";
            Text = "AdminRemoveStudent";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TerminateMembershipAdminPanel).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private DataGridView TerminateMembershipAdminPanel;
        private Label label1;
        private TextBox ReaderID;
        private FontAwesome.Sharp.IconButton TerminateBtn;
        private FontAwesome.Sharp.IconButton TerminateMemberSearch;
        private Button TerminateMemberBackBtn;
        private Panel panel1;
        private Label label4;
        private Label label2;
        private PictureBox pictureBox1;
    }
}