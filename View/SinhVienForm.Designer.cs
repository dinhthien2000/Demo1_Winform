namespace Demo1.View
{
    partial class SinhVienForm
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
            panel1 = new Panel();
            panel2 = new Panel();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(327, 46);
            label1.TabIndex = 0;
            label1.Text = "Thông tin sinh viên";
            // 
            // panel1
            // 
            panel1.Location = new Point(12, 66);
            panel1.Name = "panel1";
            panel1.Size = new Size(383, 513);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Location = new Point(438, 66);
            panel2.Name = "panel2";
            panel2.Size = new Size(785, 513);
            panel2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(438, 9);
            label2.Name = "label2";
            label2.Size = new Size(333, 46);
            label2.TabIndex = 3;
            label2.Text = "Danh sách sinh viên";
            // 
            // SinhVienForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1235, 591);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "SinhVienForm";
            Text = "Sinh viên";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Label label2;
    }
}