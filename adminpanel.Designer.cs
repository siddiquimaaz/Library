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
            adminDataGridView = new DataGridView();
            AddBookBtnAdmin = new FontAwesome.Sharp.IconButton();
            ShowBorrrwedBookAdmin = new FontAwesome.Sharp.IconButton();
            label3 = new Label();
            AdminLogOutBtn = new FontAwesome.Sharp.IconButton();
            RemoveStdBtn = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            panel1 = new Panel();
            label4 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)adminDataGridView).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // adminNamelbl
            // 
            resources.ApplyResources(adminNamelbl, "adminNamelbl");
            adminNamelbl.Name = "adminNamelbl";
            // 
            // adminDataGridView
            // 
            adminDataGridView.AllowUserToAddRows = false;
            adminDataGridView.AllowUserToDeleteRows = false;
            adminDataGridView.BackgroundColor = Color.FromArgb(245, 244, 241);
            adminDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(adminDataGridView, "adminDataGridView");
            adminDataGridView.Name = "adminDataGridView";
            adminDataGridView.ReadOnly = true;
            adminDataGridView.RowTemplate.Height = 29;
            adminDataGridView.CellContentClick += dataGridView1_CellContentClick;
            // 
            // AddBookBtnAdmin
            // 
            AddBookBtnAdmin.BackColor = Color.Transparent;
            resources.ApplyResources(AddBookBtnAdmin, "AddBookBtnAdmin");
            AddBookBtnAdmin.FlatAppearance.MouseOverBackColor = SystemColors.ButtonShadow;
            AddBookBtnAdmin.ForeColor = Color.FromArgb(29, 28, 28);
            AddBookBtnAdmin.IconChar = FontAwesome.Sharp.IconChar.BookOpenReader;
            AddBookBtnAdmin.IconColor = Color.FromArgb(29, 28, 28);
            AddBookBtnAdmin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            AddBookBtnAdmin.IconSize = 42;
            AddBookBtnAdmin.Name = "AddBookBtnAdmin";
            AddBookBtnAdmin.UseVisualStyleBackColor = false;
            AddBookBtnAdmin.Click += iconButton3_Click;
            // 
            // ShowBorrrwedBookAdmin
            // 
            ShowBorrrwedBookAdmin.BackColor = Color.Transparent;
            resources.ApplyResources(ShowBorrrwedBookAdmin, "ShowBorrrwedBookAdmin");
            ShowBorrrwedBookAdmin.ForeColor = Color.FromArgb(29, 28, 28);
            ShowBorrrwedBookAdmin.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            ShowBorrrwedBookAdmin.IconColor = Color.FromArgb(29, 28, 28);
            ShowBorrrwedBookAdmin.IconFont = FontAwesome.Sharp.IconFont.Regular;
            ShowBorrrwedBookAdmin.IconSize = 42;
            ShowBorrrwedBookAdmin.Name = "ShowBorrrwedBookAdmin";
            ShowBorrrwedBookAdmin.UseVisualStyleBackColor = false;
            ShowBorrrwedBookAdmin.Click += ShowBorrrwedBookAdmin_Click;
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.ForeColor = Color.FromArgb(0, 102, 140);
            label3.Name = "label3";
            // 
            // AdminLogOutBtn
            // 
            AdminLogOutBtn.BackColor = Color.FromArgb(0, 102, 140);
            resources.ApplyResources(AdminLogOutBtn, "AdminLogOutBtn");
            AdminLogOutBtn.ForeColor = Color.FromArgb(255, 254, 251);
            AdminLogOutBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            AdminLogOutBtn.IconColor = Color.White;
            AdminLogOutBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            AdminLogOutBtn.Name = "AdminLogOutBtn";
            AdminLogOutBtn.UseVisualStyleBackColor = false;
            AdminLogOutBtn.Click += iconButton1_Click;
            // 
            // RemoveStdBtn
            // 
            RemoveStdBtn.BackColor = Color.Transparent;
            resources.ApplyResources(RemoveStdBtn, "RemoveStdBtn");
            RemoveStdBtn.ForeColor = Color.FromArgb(29, 28, 28);
            RemoveStdBtn.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            RemoveStdBtn.IconColor = Color.FromArgb(29, 28, 28);
            RemoveStdBtn.IconFont = FontAwesome.Sharp.IconFont.Regular;
            RemoveStdBtn.IconSize = 42;
            RemoveStdBtn.Name = "RemoveStdBtn";
            RemoveStdBtn.UseVisualStyleBackColor = false;
            RemoveStdBtn.Click += RemoveStdBtn_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(245, 244, 241);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(RemoveStdBtn);
            panel2.Controls.Add(AdminLogOutBtn);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(ShowBorrrwedBookAdmin);
            panel2.Controls.Add(AddBookBtnAdmin);
            resources.ApplyResources(panel2, "panel2");
            panel2.Name = "panel2";
            panel2.Paint += panel2_Paint;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(204, 203, 200);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label1);
            resources.ApplyResources(panel1, "panel1");
            panel1.Name = "panel1";
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.ForeColor = Color.White;
            label4.Name = "label4";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.ForeColor = Color.White;
            label1.Name = "label1";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // adminpanel
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 254, 251);
            Controls.Add(panel1);
            Controls.Add(adminDataGridView);
            Controls.Add(adminNamelbl);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "adminpanel";
            Load += adminpanel_Load;
            ((System.ComponentModel.ISupportInitialize)adminDataGridView).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label adminNamelbl;
        private DataGridView adminDataGridView;
        private FontAwesome.Sharp.IconButton AddBookBtnAdmin;
        private FontAwesome.Sharp.IconButton ShowBorrrwedBookAdmin;
        private Label label3;
        private FontAwesome.Sharp.IconButton AdminLogOutBtn;
        private FontAwesome.Sharp.IconButton RemoveStdBtn;
        private Panel panel2;
        private Panel panel1;
        private Label label4;
        private Label label1;
        private PictureBox pictureBox1;
    }
}