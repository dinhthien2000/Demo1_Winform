namespace Demo1.View
{
    partial class NienKhoaForm
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
            label1 = new Label();
            txt_ten_khoa = new TextBox();
            label4 = new Label();
            txt_ma_khoa = new TextBox();
            label3 = new Label();
            btn_capnhat = new Button();
            btn_luu = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Location = new Point(438, 67);
            panel2.Name = "panel2";
            panel2.Size = new Size(785, 513);
            panel2.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_capnhat);
            panel1.Controls.Add(btn_luu);
            panel1.Controls.Add(txt_ten_khoa);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txt_ma_khoa);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(12, 67);
            panel1.Name = "panel1";
            panel1.Size = new Size(383, 513);
            panel1.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(438, 10);
            label2.Name = "label2";
            label2.Size = new Size(341, 45);
            label2.TabIndex = 5;
            label2.Text = "Danh sách niên khóa";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.CausesValidation = false;
            label1.Font = new Font("Segoe UI", 24.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 10);
            label1.Name = "label1";
            label1.Size = new Size(331, 45);
            label1.TabIndex = 4;
            label1.Text = "Thông tin niên khóa";
            // 
            // txt_ten_khoa
            // 
            txt_ten_khoa.Location = new Point(128, 72);
            txt_ten_khoa.Name = "txt_ten_khoa";
            txt_ten_khoa.Size = new Size(252, 23);
            txt_ten_khoa.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 80);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 6;
            label4.Text = "Tên khóa";
            // 
            // txt_ma_khoa
            // 
            txt_ma_khoa.Location = new Point(128, 21);
            txt_ma_khoa.Name = "txt_ma_khoa";
            txt_ma_khoa.Size = new Size(252, 23);
            txt_ma_khoa.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 29);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 4;
            label3.Text = "Mã khóa";
            // 
            // btn_capnhat
            // 
            btn_capnhat.Location = new Point(92, 123);
            btn_capnhat.Name = "btn_capnhat";
            btn_capnhat.Size = new Size(75, 23);
            btn_capnhat.TabIndex = 9;
            btn_capnhat.Text = "Cập nhật";
            btn_capnhat.UseVisualStyleBackColor = true;
            // 
            // btn_luu
            // 
            btn_luu.Location = new Point(11, 123);
            btn_luu.Name = "btn_luu";
            btn_luu.Size = new Size(75, 23);
            btn_luu.TabIndex = 8;
            btn_luu.Text = "Lưu";
            btn_luu.UseVisualStyleBackColor = true;
            // 
            // NienKhoaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1235, 591);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "NienKhoaForm";
            Text = "Niên khóa";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private TextBox txt_ten_khoa;
        private Label label4;
        private TextBox txt_ma_khoa;
        private Label label3;
        private Button btn_capnhat;
        private Button btn_luu;
    }
}