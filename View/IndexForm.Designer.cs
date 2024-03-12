namespace Demo1
{
    partial class IndexForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            panel1 = new Panel();
            btn_khoa = new Button();
            btn_lop = new Button();
            btn_nien_khoa = new Button();
            btn_sinh_vien = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1000, 24);
            menuStrip1.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(btn_khoa);
            panel1.Controls.Add(btn_lop);
            panel1.Controls.Add(btn_nien_khoa);
            panel1.Controls.Add(btn_sinh_vien);
            panel1.Location = new Point(172, 84);
            panel1.Name = "panel1";
            panel1.Size = new Size(678, 331);
            panel1.TabIndex = 1;
            // 
            // btn_khoa
            // 
            btn_khoa.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn_khoa.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_khoa.Location = new Point(209, 231);
            btn_khoa.Name = "btn_khoa";
            btn_khoa.Size = new Size(275, 70);
            btn_khoa.TabIndex = 4;
            btn_khoa.Text = "Khoa";
            btn_khoa.UseVisualStyleBackColor = true;
            btn_khoa.Click += btn_khoa_Click;
            // 
            // btn_lop
            // 
            btn_lop.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn_lop.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_lop.Location = new Point(209, 79);
            btn_lop.Name = "btn_lop";
            btn_lop.Size = new Size(275, 70);
            btn_lop.TabIndex = 2;
            btn_lop.Text = "Lớp";
            btn_lop.UseVisualStyleBackColor = true;
            btn_lop.Click += btn_lop_Click;
            // 
            // btn_nien_khoa
            // 
            btn_nien_khoa.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn_nien_khoa.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_nien_khoa.Location = new Point(209, 155);
            btn_nien_khoa.Name = "btn_nien_khoa";
            btn_nien_khoa.Size = new Size(275, 70);
            btn_nien_khoa.TabIndex = 3;
            btn_nien_khoa.Text = "Khóa ";
            btn_nien_khoa.UseVisualStyleBackColor = true;
            btn_nien_khoa.Click += btn_nien_khoa_Click;
            // 
            // btn_sinh_vien
            // 
            btn_sinh_vien.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn_sinh_vien.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_sinh_vien.Location = new Point(209, 3);
            btn_sinh_vien.Name = "btn_sinh_vien";
            btn_sinh_vien.Size = new Size(275, 70);
            btn_sinh_vien.TabIndex = 0;
            btn_sinh_vien.Text = "Sinh viên";
            btn_sinh_vien.UseVisualStyleBackColor = true;
            btn_sinh_vien.Click += btn_sinh_vien_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(336, 9);
            label1.Name = "label1";
            label1.Size = new Size(345, 54);
            label1.TabIndex = 2;
            label1.Text = "Quản lý sinh viên";
            // 
            // IndexForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 532);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "IndexForm";
            Text = "Trang chủ";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private Panel panel1;
        private Button btn_nien_khoa;
        private Button btn_sinh_vien;
        private Button btn_lop;
        private Button btn_khoa;
        private Label label1;
    }
}