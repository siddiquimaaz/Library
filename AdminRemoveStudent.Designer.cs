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
            TerminateMemberBackBtn = new Button();
            TerminateMemberSearch = new FontAwesome.Sharp.IconButton();
            TerminateBtn = new FontAwesome.Sharp.IconButton();
            ReaderID = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            TerminateMembershipAdminPanel = new DataGridView();
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
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(295, 705);
            panel2.TabIndex = 18;
            panel2.Paint += panel2_Paint;
            // 
            // TerminateMemberBackBtn
            // 
            TerminateMemberBackBtn.BackColor = Color.White;
            TerminateMemberBackBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            TerminateMemberBackBtn.Location = new Point(21, 613);
            TerminateMemberBackBtn.Margin = new Padding(3, 4, 3, 4);
            TerminateMemberBackBtn.Name = "TerminateMemberBackBtn";
            TerminateMemberBackBtn.Size = new Size(86, 31);
            TerminateMemberBackBtn.TabIndex = 24;
            TerminateMemberBackBtn.Text = "Back";
            TerminateMemberBackBtn.UseVisualStyleBackColor = false;
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
            TerminateMemberSearch.Location = new Point(21, 327);
            TerminateMemberSearch.Name = "TerminateMemberSearch";
            TerminateMemberSearch.Padding = new Padding(1);
            TerminateMemberSearch.Size = new Size(93, 35);
            TerminateMemberSearch.TabIndex = 23;
            TerminateMemberSearch.Text = "Search";
            TerminateMemberSearch.TextAlign = ContentAlignment.MiddleRight;
            TerminateMemberSearch.UseVisualStyleBackColor = false;
            // 
            // TerminateBtn
            // 
            TerminateBtn.BackColor = Color.LightGray;
            TerminateBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            TerminateBtn.IconChar = FontAwesome.Sharp.IconChar.IdBadge;
            TerminateBtn.IconColor = Color.Black;
            TerminateBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            TerminateBtn.ImageAlign = ContentAlignment.MiddleLeft;
            TerminateBtn.Location = new Point(14, 493);
            TerminateBtn.Margin = new Padding(3, 4, 3, 4);
            TerminateBtn.Name = "TerminateBtn";
            TerminateBtn.Size = new Size(259, 72);
            TerminateBtn.TabIndex = 22;
            TerminateBtn.Text = "Terminate";
            TerminateBtn.UseVisualStyleBackColor = false;
            // 
            // ReaderID
            // 
            ReaderID.Location = new Point(21, 284);
            ReaderID.Margin = new Padding(3, 4, 3, 4);
            ReaderID.Name = "ReaderID";
            ReaderID.Size = new Size(230, 27);
            ReaderID.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(18, 255);
            label1.Name = "label1";
            label1.Size = new Size(86, 23);
            label1.TabIndex = 19;
            label1.Text = "Reader ID";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1400, 49);
            panel1.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 9);
            label2.Name = "label2";
            label2.Size = new Size(595, 25);
            label2.TabIndex = 1;
            label2.Text = "Library Management System | Admin Panel | Terminate Membership";
            // 
            // TerminateMembershipAdminPanel
            // 
            TerminateMembershipAdminPanel.BackgroundColor = Color.White;
            TerminateMembershipAdminPanel.BorderStyle = BorderStyle.Fixed3D;
            TerminateMembershipAdminPanel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TerminateMembershipAdminPanel.Location = new Point(296, 49);
            TerminateMembershipAdminPanel.Margin = new Padding(3, 4, 3, 4);
            TerminateMembershipAdminPanel.Name = "TerminateMembershipAdminPanel";
            TerminateMembershipAdminPanel.RowHeadersWidth = 51;
            TerminateMembershipAdminPanel.RowTemplate.Height = 25;
            TerminateMembershipAdminPanel.Size = new Size(1104, 649);
            TerminateMembershipAdminPanel.TabIndex = 0;
            // 
            // AdminRemoveStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1400, 700);
            Controls.Add(TerminateMembershipAdminPanel);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
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