namespace Library
{
    partial class adminpanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminpanel));
            adminNamelbl = new Label();
            AddBookBtnAdmin = new FontAwesome.Sharp.IconButton();
            ShowBorrrwedBookAdmin = new FontAwesome.Sharp.IconButton();
            adminDataGridView = new DataGridView();
            panel1 = new Panel();
            label2 = new Label();
            panel2 = new Panel();
            RemoveStdBtn = new FontAwesome.Sharp.IconButton();
            AdminLogOutBtn = new FontAwesome.Sharp.IconButton();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)adminDataGridView).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // adminNamelbl
            // 
            adminNamelbl.AutoSize = true;
            adminNamelbl.Location = new Point(477, 145);
            adminNamelbl.Name = "adminNamelbl";
            adminNamelbl.Size = new Size(0, 20);
            adminNamelbl.TabIndex = 2;
            adminNamelbl.Visible = false;
            // 
            // AddBookBtnAdmin
            // 
            AddBookBtnAdmin.BackColor = Color.Transparent;
            AddBookBtnAdmin.BackgroundImageLayout = ImageLayout.None;
            AddBookBtnAdmin.FlatAppearance.MouseOverBackColor = SystemColors.ButtonShadow;
            AddBookBtnAdmin.FlatStyle = FlatStyle.Popup;
            AddBookBtnAdmin.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            AddBookBtnAdmin.ForeColor = Color.White;
            AddBookBtnAdmin.IconChar = FontAwesome.Sharp.IconChar.BookOpenReader;
            AddBookBtnAdmin.IconColor = Color.White;
            AddBookBtnAdmin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            AddBookBtnAdmin.IconSize = 42;
            AddBookBtnAdmin.ImageAlign = ContentAlignment.MiddleLeft;
            AddBookBtnAdmin.Location = new Point(22, 265);
            AddBookBtnAdmin.Name = "AddBookBtnAdmin";
            AddBookBtnAdmin.Size = new Size(259, 75);
            AddBookBtnAdmin.TabIndex = 12;
            AddBookBtnAdmin.Text = "Book Management";
            AddBookBtnAdmin.UseVisualStyleBackColor = false;
            AddBookBtnAdmin.Click += iconButton3_Click;
            // 
            // ShowBorrrwedBookAdmin
            // 
            ShowBorrrwedBookAdmin.BackColor = Color.Transparent;
            ShowBorrrwedBookAdmin.BackgroundImageLayout = ImageLayout.None;
            ShowBorrrwedBookAdmin.FlatStyle = FlatStyle.Popup;
            ShowBorrrwedBookAdmin.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            ShowBorrrwedBookAdmin.ForeColor = Color.White;
            ShowBorrrwedBookAdmin.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            ShowBorrrwedBookAdmin.IconColor = Color.White;
            ShowBorrrwedBookAdmin.IconFont = FontAwesome.Sharp.IconFont.Regular;
            ShowBorrrwedBookAdmin.IconSize = 42;
            ShowBorrrwedBookAdmin.ImageAlign = ContentAlignment.MiddleLeft;
            ShowBorrrwedBookAdmin.Location = new Point(23, 365);
            ShowBorrrwedBookAdmin.Name = "ShowBorrrwedBookAdmin";
            ShowBorrrwedBookAdmin.Size = new Size(258, 75);
            ShowBorrrwedBookAdmin.TabIndex = 13;
            ShowBorrrwedBookAdmin.Text = "Borrowed Books";
            ShowBorrrwedBookAdmin.UseVisualStyleBackColor = false;
            ShowBorrrwedBookAdmin.Click += ShowBorrrwedBookAdmin_Click;
            // 
            // adminDataGridView
            // 
            adminDataGridView.AllowUserToAddRows = false;
            adminDataGridView.AllowUserToDeleteRows = false;
            adminDataGridView.BackgroundColor = Color.LightGray;
            adminDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            adminDataGridView.Location = new Point(288, 51);
            adminDataGridView.Name = "adminDataGridView";
            adminDataGridView.ReadOnly = true;
            adminDataGridView.RowHeadersWidth = 51;
            adminDataGridView.RowTemplate.Height = 29;
            adminDataGridView.Size = new Size(1082, 687);
            adminDataGridView.TabIndex = 14;
            adminDataGridView.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1370, 52);
            panel1.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 9);
            label2.Name = "label2";
            label2.Size = new Size(490, 25);
            label2.TabIndex = 1;
            label2.Text = "Library Management System | Admin Panel | Dashboard";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Controls.Add(RemoveStdBtn);
            panel2.Controls.Add(AdminLogOutBtn);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(ShowBorrrwedBookAdmin);
            panel2.Controls.Add(AddBookBtnAdmin);
            panel2.Location = new Point(0, 48);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(295, 688);
            panel2.TabIndex = 16;
            panel2.Paint += panel2_Paint;
            // 
            // RemoveStdBtn
            // 
            RemoveStdBtn.BackColor = Color.Transparent;
            RemoveStdBtn.BackgroundImageLayout = ImageLayout.None;
            RemoveStdBtn.FlatStyle = FlatStyle.Popup;
            RemoveStdBtn.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            RemoveStdBtn.ForeColor = Color.White;
            RemoveStdBtn.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            RemoveStdBtn.IconColor = Color.White;
            RemoveStdBtn.IconFont = FontAwesome.Sharp.IconFont.Regular;
            RemoveStdBtn.IconSize = 42;
            RemoveStdBtn.ImageAlign = ContentAlignment.MiddleLeft;
            RemoveStdBtn.Location = new Point(22, 461);
            RemoveStdBtn.Name = "RemoveStdBtn";
            RemoveStdBtn.Size = new Size(258, 75);
            RemoveStdBtn.TabIndex = 22;
            RemoveStdBtn.Text = "Delete Membership";
            RemoveStdBtn.UseVisualStyleBackColor = false;
            RemoveStdBtn.Click += RemoveStdBtn_Click;
            // 
            // AdminLogOutBtn
            // 
            AdminLogOutBtn.BackColor = Color.White;
            AdminLogOutBtn.BackgroundImage = (Image)resources.GetObject("AdminLogOutBtn.BackgroundImage");
            AdminLogOutBtn.BackgroundImageLayout = ImageLayout.None;
            AdminLogOutBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            AdminLogOutBtn.IconColor = Color.White;
            AdminLogOutBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            AdminLogOutBtn.Location = new Point(22, 637);
            AdminLogOutBtn.Margin = new Padding(3, 4, 3, 4);
            AdminLogOutBtn.Name = "AdminLogOutBtn";
            AdminLogOutBtn.Size = new Size(110, 35);
            AdminLogOutBtn.TabIndex = 18;
            AdminLogOutBtn.Text = "Log out";
            AdminLogOutBtn.UseVisualStyleBackColor = false;
            AdminLogOutBtn.Click += iconButton1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(23, 157);
            label3.Name = "label3";
            label3.Size = new Size(259, 41);
            label3.TabIndex = 17;
            label3.Text = "Welcome Admin!";
            // 
            // adminpanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            ClientSize = new Size(1370, 736);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(adminDataGridView);
            Controls.Add(adminNamelbl);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "adminpanel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin-Panel";
            Load += adminpanel_Load;
            ((System.ComponentModel.ISupportInitialize)adminDataGridView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label adminNamelbl;
        private FontAwesome.Sharp.IconButton AddBookBtnAdmin;
        private FontAwesome.Sharp.IconButton ShowBorrrwedBookAdmin;
        private DataGridView adminDataGridView;
        private Panel panel1;
        private Label label2;
        private Panel panel2;
        private Label label3;
        private FontAwesome.Sharp.IconButton AdminLogOutBtn;
        private FontAwesome.Sharp.IconButton RemoveStdBtn;
    }
}