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
            adminpic = new PictureBox();
            adminNamelbl = new Label();
            adminLogOutBtn = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)adminpic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // adminpic
            // 
            adminpic.Location = new Point(12, 12);
            adminpic.Name = "adminpic";
            adminpic.Size = new Size(100, 76);
            adminpic.TabIndex = 1;
            adminpic.TabStop = false;
            // 
            // adminNamelbl
            // 
            adminNamelbl.AutoSize = true;
            adminNamelbl.Location = new Point(12, 101);
            adminNamelbl.Name = "adminNamelbl";
            adminNamelbl.Size = new Size(0, 20);
            adminNamelbl.TabIndex = 2;
            adminNamelbl.Visible = false;
            // 
            // adminLogOutBtn
            // 
            adminLogOutBtn.FlatStyle = FlatStyle.Popup;
            adminLogOutBtn.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            adminLogOutBtn.IconChar = FontAwesome.Sharp.IconChar.Lock;
            adminLogOutBtn.IconColor = Color.Black;
            adminLogOutBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            adminLogOutBtn.IconSize = 30;
            adminLogOutBtn.ImageAlign = ContentAlignment.MiddleLeft;
            adminLogOutBtn.Location = new Point(118, 12);
            adminLogOutBtn.Name = "adminLogOutBtn";
            adminLogOutBtn.Size = new Size(100, 34);
            adminLogOutBtn.TabIndex = 10;
            adminLogOutBtn.Text = "LogOut";
            adminLogOutBtn.TextAlign = ContentAlignment.MiddleRight;
            adminLogOutBtn.UseVisualStyleBackColor = true;
            // 
            // iconButton2
            // 
            iconButton2.FlatAppearance.MouseOverBackColor = SystemColors.ButtonShadow;
            iconButton2.FlatStyle = FlatStyle.Popup;
            iconButton2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            iconButton2.ForeColor = Color.Black;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.GraduationCap;
            iconButton2.IconColor = Color.Black;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 42;
            iconButton2.ImageAlign = ContentAlignment.TopCenter;
            iconButton2.Location = new Point(118, 206);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(150, 94);
            iconButton2.TabIndex = 11;
            iconButton2.Text = "Registered Students";
            iconButton2.TextAlign = ContentAlignment.BottomCenter;
            iconButton2.UseVisualStyleBackColor = true;
            // 
            // iconButton3
            // 
            iconButton3.FlatAppearance.MouseOverBackColor = SystemColors.ButtonShadow;
            iconButton3.FlatStyle = FlatStyle.Popup;
            iconButton3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            iconButton3.ForeColor = Color.Black;
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.BookOpenReader;
            iconButton3.IconColor = Color.Black;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.IconSize = 42;
            iconButton3.Location = new Point(118, 367);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(150, 94);
            iconButton3.TabIndex = 12;
            iconButton3.Text = "Books";
            iconButton3.TextAlign = ContentAlignment.BottomCenter;
            iconButton3.UseVisualStyleBackColor = true;
            // 
            // iconButton4
            // 
            iconButton4.FlatStyle = FlatStyle.Popup;
            iconButton4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            iconButton4.ForeColor = Color.Black;
            iconButton4.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            iconButton4.IconColor = Color.Black;
            iconButton4.IconFont = FontAwesome.Sharp.IconFont.Regular;
            iconButton4.IconSize = 42;
            iconButton4.Location = new Point(118, 488);
            iconButton4.Name = "iconButton4";
            iconButton4.Size = new Size(150, 94);
            iconButton4.TabIndex = 13;
            iconButton4.Text = "Borrowed Books";
            iconButton4.TextAlign = ContentAlignment.BottomCenter;
            iconButton4.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(441, 1);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(833, 725);
            dataGridView1.TabIndex = 14;
            // 
            // adminpanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1275, 705);
            Controls.Add(dataGridView1);
            Controls.Add(iconButton4);
            Controls.Add(iconButton3);
            Controls.Add(iconButton2);
            Controls.Add(adminLogOutBtn);
            Controls.Add(adminNamelbl);
            Controls.Add(adminpic);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "adminpanel";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin-Panel";
            ((System.ComponentModel.ISupportInitialize)adminpic).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox adminpic;
        private Label adminNamelbl;
        private FontAwesome.Sharp.IconButton adminLogOutBtn;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton4;
        private DataGridView dataGridView1;
    }
}