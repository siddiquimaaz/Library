namespace Library
{
    partial class ReaderDetails
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
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(204, 203, 200);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(2, 1, 2, 1);
            panel1.Size = new Size(1370, 34);
            panel1.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 102, 140);
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(9, 9);
            label1.Name = "label1";
            label1.Size = new Size(423, 16);
            label1.TabIndex = 17;
            label1.Text = "Library Management System | Reader Panel | Issue Book";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(1373, 9);
            label2.Name = "label2";
            label2.Size = new Size(15, 15);
            label2.TabIndex = 14;
            label2.Text = "X";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(204, 203, 200);
            panel2.Location = new Point(655, 101);
            panel2.Name = "panel2";
            panel2.Size = new Size(5, 528);
            panel2.TabIndex = 18;
            // 
            // ReaderDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 710);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "ReaderDetails";
            Text = "ReaderDetails";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Panel panel2;
    }
}