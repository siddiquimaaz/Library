namespace Library
{
    partial class ReaderReturnBook
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
            label2 = new Label();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(204, 203, 200);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label4);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(2, 1, 2, 1);
            panel2.Size = new Size(1370, 34);
            panel2.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 102, 140);
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(11, 10);
            label2.Name = "label2";
            label2.Size = new Size(431, 16);
            label2.TabIndex = 17;
            label2.Text = "Library Management System | Reader Panel | Return Book";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.ImeMode = ImeMode.NoControl;
            label4.Location = new Point(1375, 10);
            label4.Name = "label4";
            label4.Size = new Size(15, 15);
            label4.TabIndex = 14;
            label4.Text = "X";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(245, 244, 241);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(279, 41);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1083, 661);
            dataGridView1.TabIndex = 21;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(245, 244, 241);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(8, 41);
            panel1.Name = "panel1";
            panel1.Size = new Size(264, 662);
            panel1.TabIndex = 22;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(41, 61);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(169, 165);
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // ReaderReturnBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1370, 710);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ReaderReturnBook";
            Text = "ReaderReturnBook";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label2;
        private Label label4;
        private DataGridView dataGridView1;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}