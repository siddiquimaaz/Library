namespace Library
{
    partial class AddBook
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            booktitltxt = new TextBox();
            booktitletxt = new TextBox();
            label4 = new Label();
            addtobtn = new FontAwesome.Sharp.IconButton();
            cancel = new FontAwesome.Sharp.IconButton();
            backbtn = new FontAwesome.Sharp.IconButton();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(458, 23);
            label1.Name = "label1";
            label1.Size = new Size(321, 54);
            label1.TabIndex = 0;
            label1.Text = "Jaun Elia Library";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(490, 77);
            label2.Name = "label2";
            label2.Size = new Size(256, 31);
            label2.TabIndex = 1;
            label2.Text = "Add Books to your cart";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(34, 166);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 2;
            label3.Text = "Book Title:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // booktitltxt
            // 
            booktitltxt.BackColor = Color.White;
            booktitltxt.BorderStyle = BorderStyle.FixedSingle;
            booktitltxt.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            booktitltxt.ForeColor = Color.Transparent;
            booktitltxt.Location = new Point(119, 159);
            booktitltxt.Name = "booktitltxt";
            booktitltxt.PlaceholderText = "Enter Book name";
            booktitltxt.Size = new Size(191, 27);
            booktitltxt.TabIndex = 3;
            booktitltxt.TextAlign = HorizontalAlignment.Center;
            // 
            // booktitletxt
            // 
            booktitletxt.BackColor = Color.White;
            booktitletxt.BorderStyle = BorderStyle.FixedSingle;
            booktitletxt.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            booktitletxt.ForeColor = Color.Transparent;
            booktitletxt.Location = new Point(119, 208);
            booktitletxt.Name = "booktitletxt";
            booktitletxt.PlaceholderText = "Enter Author name";
            booktitletxt.Size = new Size(191, 27);
            booktitletxt.TabIndex = 5;
            booktitletxt.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(34, 215);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 4;
            label4.Text = "Author";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // addtobtn
            // 
            addtobtn.BackColor = Color.Transparent;
            addtobtn.FlatStyle = FlatStyle.Popup;
            addtobtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            addtobtn.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            addtobtn.IconColor = Color.Black;
            addtobtn.IconFont = FontAwesome.Sharp.IconFont.Regular;
            addtobtn.IconSize = 28;
            addtobtn.ImageAlign = ContentAlignment.MiddleLeft;
            addtobtn.Location = new Point(119, 269);
            addtobtn.Name = "addtobtn";
            addtobtn.Size = new Size(72, 30);
            addtobtn.TabIndex = 6;
            addtobtn.Text = "Add";
            addtobtn.TextAlign = ContentAlignment.MiddleRight;
            addtobtn.UseVisualStyleBackColor = false;
            // 
            // cancel
            // 
            cancel.FlatStyle = FlatStyle.Popup;
            cancel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cancel.IconChar = FontAwesome.Sharp.IconChar.Recycle;
            cancel.IconColor = Color.Black;
            cancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            cancel.IconSize = 28;
            cancel.ImageAlign = ContentAlignment.MiddleLeft;
            cancel.Location = new Point(197, 269);
            cancel.Name = "cancel";
            cancel.Size = new Size(86, 30);
            cancel.TabIndex = 7;
            cancel.Text = "Cancel";
            cancel.TextAlign = ContentAlignment.MiddleRight;
            cancel.UseVisualStyleBackColor = true;
            // 
            // backbtn
            // 
            backbtn.FlatStyle = FlatStyle.Popup;
            backbtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            backbtn.IconChar = FontAwesome.Sharp.IconChar.Backspace;
            backbtn.IconColor = Color.Black;
            backbtn.IconFont = FontAwesome.Sharp.IconFont.Solid;
            backbtn.IconSize = 28;
            backbtn.ImageAlign = ContentAlignment.MiddleLeft;
            backbtn.Location = new Point(162, 320);
            backbtn.Name = "backbtn";
            backbtn.Size = new Size(76, 30);
            backbtn.TabIndex = 8;
            backbtn.Text = "Back";
            backbtn.TextAlign = ContentAlignment.MiddleRight;
            backbtn.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(552, 132);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(758, 564);
            dataGridView1.TabIndex = 9;
            // 
            // AddBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1314, 694);
            Controls.Add(dataGridView1);
            Controls.Add(backbtn);
            Controls.Add(cancel);
            Controls.Add(addtobtn);
            Controls.Add(booktitletxt);
            Controls.Add(label4);
            Controls.Add(booktitltxt);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddBook";
            Text = "AddBook";
            Load += AddBook_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox booktitltxt;
        private TextBox booktitletxt;
        private Label label4;
        private FontAwesome.Sharp.IconButton addtobtn;
        private FontAwesome.Sharp.IconButton cancel;
        private FontAwesome.Sharp.IconButton backbtn;
        private DataGridView dataGridView1;
    }
}