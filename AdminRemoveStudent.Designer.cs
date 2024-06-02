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
            panel2 = new Panel();
            panel1 = new Panel();
            label2 = new Label();
            TerminateMembershipAdminPanel = new DataGridView();
            label1 = new Label();
            ReaderID = new TextBox();
            TerminateBtn = new FontAwesome.Sharp.IconButton();
            TerminateMemberSearch = new FontAwesome.Sharp.IconButton();
            TerminateMemberBackBtn = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TerminateMembershipAdminPanel).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Controls.Add(TerminateMemberBackBtn);
            panel2.Controls.Add(TerminateMemberSearch);
            panel2.Controls.Add(TerminateBtn);
            panel2.Controls.Add(ReaderID);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(0, -6);
            panel2.Name = "panel2";
            panel2.Size = new Size(258, 520);
            panel2.TabIndex = 18;
            panel2.Paint += panel2_Paint;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1183, 37);
            panel1.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 7);
            label2.Name = "label2";
            label2.Size = new Size(474, 20);
            label2.TabIndex = 1;
            label2.Text = "Library Management System | Admin Panel | Terminate Membership";
            // 
            // TerminateMembershipAdminPanel
            // 
            TerminateMembershipAdminPanel.BackgroundColor = Color.White;
            TerminateMembershipAdminPanel.BorderStyle = BorderStyle.Fixed3D;
            TerminateMembershipAdminPanel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TerminateMembershipAdminPanel.Location = new Point(259, 37);
            TerminateMembershipAdminPanel.Name = "TerminateMembershipAdminPanel";
            TerminateMembershipAdminPanel.RowTemplate.Height = 25;
            TerminateMembershipAdminPanel.Size = new Size(923, 477);
            TerminateMembershipAdminPanel.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(16, 191);
            label1.Name = "label1";
            label1.Size = new Size(67, 17);
            label1.TabIndex = 19;
            label1.Text = "Reader ID";
            // 
            // ReaderID
            // 
            ReaderID.Location = new Point(18, 213);
            ReaderID.Name = "ReaderID";
            ReaderID.Size = new Size(202, 23);
            ReaderID.TabIndex = 20;
            // 
            // TerminateBtn
            // 
            TerminateBtn.BackColor = Color.LightGray;
            TerminateBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            TerminateBtn.IconChar = FontAwesome.Sharp.IconChar.IdBadge;
            TerminateBtn.IconColor = Color.Black;
            TerminateBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            TerminateBtn.ImageAlign = ContentAlignment.MiddleLeft;
            TerminateBtn.Location = new Point(12, 370);
            TerminateBtn.Name = "TerminateBtn";
            TerminateBtn.Size = new Size(227, 54);
            TerminateBtn.TabIndex = 22;
            TerminateBtn.Text = "Terminate";
            TerminateBtn.UseVisualStyleBackColor = false;
            // 
            // TerminateMemberSearch
            // 
            TerminateMemberSearch.BackColor = Color.White;
            TerminateMemberSearch.Cursor = Cursors.Hand;
            TerminateMemberSearch.FlatStyle = FlatStyle.Popup;
            TerminateMemberSearch.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            TerminateMemberSearch.ForeColor = Color.Black;
            TerminateMemberSearch.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            TerminateMemberSearch.IconColor = Color.Black;
            TerminateMemberSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            TerminateMemberSearch.IconSize = 20;
            TerminateMemberSearch.ImageAlign = ContentAlignment.MiddleLeft;
            TerminateMemberSearch.Location = new Point(18, 245);
            TerminateMemberSearch.Margin = new Padding(3, 2, 3, 2);
            TerminateMemberSearch.Name = "TerminateMemberSearch";
            TerminateMemberSearch.Padding = new Padding(1);
            TerminateMemberSearch.Size = new Size(81, 26);
            TerminateMemberSearch.TabIndex = 23;
            TerminateMemberSearch.Text = "Search";
            TerminateMemberSearch.TextAlign = ContentAlignment.MiddleRight;
            TerminateMemberSearch.UseVisualStyleBackColor = false;
            // 
            // TerminateMemberBackBtn
            // 
            TerminateMemberBackBtn.BackColor = Color.White;
            TerminateMemberBackBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            TerminateMemberBackBtn.Location = new Point(16, 484);
            TerminateMemberBackBtn.Name = "TerminateMemberBackBtn";
            TerminateMemberBackBtn.Size = new Size(75, 23);
            TerminateMemberBackBtn.TabIndex = 24;
            TerminateMemberBackBtn.Text = "Back";
            TerminateMemberBackBtn.UseVisualStyleBackColor = false;
            // 
            // AdminRemoveStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1183, 513);
            Controls.Add(TerminateMembershipAdminPanel);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminRemoveStudent";
            Text = "AdminRemoveStudent";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TerminateMembershipAdminPanel).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Panel panel1;
        private Label label2;
        private DataGridView TerminateMembershipAdminPanel;
        private Label label1;
        private TextBox ReaderID;
        private FontAwesome.Sharp.IconButton TerminateBtn;
        private FontAwesome.Sharp.IconButton TerminateMemberSearch;
        private Button TerminateMemberBackBtn;
    }
}