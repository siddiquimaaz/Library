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
            panel1 = new Panel();
            label2 = new Label();
            AddBookBtnAdmin = new FontAwesome.Sharp.IconButton();
            ShowBorrrwedBookAdmin = new FontAwesome.Sharp.IconButton();
            label3 = new Label();
            AdminLogOutBtn = new FontAwesome.Sharp.IconButton();
            RemoveStdBtn = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)adminDataGridView).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
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
            adminDataGridView.BackgroundColor = Color.LightGray;
            adminDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(adminDataGridView, "adminDataGridView");
            adminDataGridView.Name = "adminDataGridView";
            adminDataGridView.ReadOnly = true;
            adminDataGridView.RowTemplate.Height = 29;
            adminDataGridView.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(label2);
            resources.ApplyResources(panel1, "panel1");
            panel1.Name = "panel1";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.ForeColor = Color.White;
            label2.Name = "label2";
            // 
            // AddBookBtnAdmin
            // 
            AddBookBtnAdmin.BackColor = Color.Transparent;
            resources.ApplyResources(AddBookBtnAdmin, "AddBookBtnAdmin");
            AddBookBtnAdmin.FlatAppearance.MouseOverBackColor = SystemColors.ButtonShadow;
            AddBookBtnAdmin.ForeColor = Color.White;
            AddBookBtnAdmin.IconChar = FontAwesome.Sharp.IconChar.BookOpenReader;
            AddBookBtnAdmin.IconColor = Color.White;
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
            ShowBorrrwedBookAdmin.ForeColor = Color.White;
            ShowBorrrwedBookAdmin.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            ShowBorrrwedBookAdmin.IconColor = Color.White;
            ShowBorrrwedBookAdmin.IconFont = FontAwesome.Sharp.IconFont.Regular;
            ShowBorrrwedBookAdmin.IconSize = 42;
            ShowBorrrwedBookAdmin.Name = "ShowBorrrwedBookAdmin";
            ShowBorrrwedBookAdmin.UseVisualStyleBackColor = false;
            ShowBorrrwedBookAdmin.Click += ShowBorrrwedBookAdmin_Click;
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.ForeColor = Color.White;
            label3.Name = "label3";
            // 
            // AdminLogOutBtn
            // 
            AdminLogOutBtn.BackColor = Color.White;
            resources.ApplyResources(AdminLogOutBtn, "AdminLogOutBtn");
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
            RemoveStdBtn.ForeColor = Color.White;
            RemoveStdBtn.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            RemoveStdBtn.IconColor = Color.White;
            RemoveStdBtn.IconFont = FontAwesome.Sharp.IconFont.Regular;
            RemoveStdBtn.IconSize = 42;
            RemoveStdBtn.Name = "RemoveStdBtn";
            RemoveStdBtn.UseVisualStyleBackColor = false;
            RemoveStdBtn.Click += RemoveStdBtn_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Controls.Add(RemoveStdBtn);
            panel2.Controls.Add(AdminLogOutBtn);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(ShowBorrrwedBookAdmin);
            panel2.Controls.Add(AddBookBtnAdmin);
            resources.ApplyResources(panel2, "panel2");
            panel2.Name = "panel2";
            panel2.Paint += panel2_Paint;
            // 
            // adminpanel
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(adminDataGridView);
            Controls.Add(panel1);
            Controls.Add(adminNamelbl);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "adminpanel";
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
        private DataGridView adminDataGridView;
        private Panel panel1;
        private Label label2;
        private FontAwesome.Sharp.IconButton AddBookBtnAdmin;
        private FontAwesome.Sharp.IconButton ShowBorrrwedBookAdmin;
        private Label label3;
        private FontAwesome.Sharp.IconButton AdminLogOutBtn;
        private FontAwesome.Sharp.IconButton RemoveStdBtn;
        private Panel panel2;
    }
}