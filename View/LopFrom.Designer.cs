namespace Demo1.View
{
    partial class LopFrom
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            txt_file_name = new TextBox();
            btn_upload = new Button();
            picbox_test = new PictureBox();
            btn_test = new Button();
            cbx_test = new ComboBox();
            btn_capnhat = new Button();
            btn_luu = new Button();
            txt_ten_lop = new TextBox();
            label4 = new Label();
            txt_ma_lop = new TextBox();
            label3 = new Label();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            maKhoaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tenKhoaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            khoaBindingSource = new BindingSource(components);
            lstv_lop = new ListView();
            colhead_ma_lop = new ColumnHeader();
            col_head_ten_lop = new ColumnHeader();
            btn_xoa = new Button();
            grdv_lop = new DataGridView();
            maLopDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tenLopDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lopBindingSource = new BindingSource(components);
            btn_back_previous_form = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picbox_test).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)khoaBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grdv_lop).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lopBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.CausesValidation = false;
            label1.Font = new Font("Segoe UI", 24.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(229, 45);
            label1.TabIndex = 0;
            label1.Text = "Thông tin lớp";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(438, 9);
            label2.Name = "label2";
            label2.Size = new Size(239, 45);
            label2.TabIndex = 1;
            label2.Text = "Danh sách lớp";
            // 
            // panel1
            // 
            panel1.Controls.Add(txt_file_name);
            panel1.Controls.Add(btn_upload);
            panel1.Controls.Add(picbox_test);
            panel1.Controls.Add(btn_test);
            panel1.Controls.Add(cbx_test);
            panel1.Controls.Add(btn_capnhat);
            panel1.Controls.Add(btn_luu);
            panel1.Controls.Add(txt_ten_lop);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txt_ma_lop);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(12, 66);
            panel1.Name = "panel1";
            panel1.Size = new Size(383, 513);
            panel1.TabIndex = 2;
            // 
            // txt_file_name
            // 
            txt_file_name.Location = new Point(11, 246);
            txt_file_name.Name = "txt_file_name";
            txt_file_name.Size = new Size(327, 23);
            txt_file_name.TabIndex = 10;
            // 
            // btn_upload
            // 
            btn_upload.Location = new Point(11, 470);
            btn_upload.Name = "btn_upload";
            btn_upload.Size = new Size(75, 23);
            btn_upload.TabIndex = 9;
            btn_upload.Text = "Upload";
            btn_upload.UseVisualStyleBackColor = true;
            btn_upload.Click += btn_upload_Click;
            // 
            // picbox_test
            // 
            picbox_test.Location = new Point(11, 275);
            picbox_test.Name = "picbox_test";
            picbox_test.Size = new Size(327, 189);
            picbox_test.TabIndex = 8;
            picbox_test.TabStop = false;
            picbox_test.Click += picbox_test_Click;
            // 
            // btn_test
            // 
            btn_test.Location = new Point(172, 181);
            btn_test.Name = "btn_test";
            btn_test.Size = new Size(75, 23);
            btn_test.TabIndex = 7;
            btn_test.Text = "button1";
            btn_test.UseVisualStyleBackColor = true;
            btn_test.Click += btn_test_Click;
            // 
            // cbx_test
            // 
            cbx_test.FormattingEnabled = true;
            cbx_test.Location = new Point(11, 181);
            cbx_test.Name = "cbx_test";
            cbx_test.Size = new Size(121, 23);
            cbx_test.TabIndex = 6;
            // 
            // btn_capnhat
            // 
            btn_capnhat.Location = new Point(92, 120);
            btn_capnhat.Name = "btn_capnhat";
            btn_capnhat.Size = new Size(75, 23);
            btn_capnhat.TabIndex = 5;
            btn_capnhat.Text = "Cập nhật";
            btn_capnhat.UseVisualStyleBackColor = true;
            btn_capnhat.Click += btn_capnhat_Click;
            // 
            // btn_luu
            // 
            btn_luu.Location = new Point(11, 120);
            btn_luu.Name = "btn_luu";
            btn_luu.Size = new Size(75, 23);
            btn_luu.TabIndex = 4;
            btn_luu.Text = "Lưu";
            btn_luu.UseVisualStyleBackColor = true;
            btn_luu.Click += btn_luu_Click;
            // 
            // txt_ten_lop
            // 
            txt_ten_lop.Location = new Point(128, 70);
            txt_ten_lop.Name = "txt_ten_lop";
            txt_ten_lop.Size = new Size(252, 23);
            txt_ten_lop.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 78);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 2;
            label4.Text = "Tên lớp";
            // 
            // txt_ma_lop
            // 
            txt_ma_lop.Location = new Point(128, 19);
            txt_ma_lop.Name = "txt_ma_lop";
            txt_ma_lop.Size = new Size(252, 23);
            txt_ma_lop.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 27);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 0;
            label3.Text = "Mã lớp";
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(lstv_lop);
            panel2.Controls.Add(btn_xoa);
            panel2.Controls.Add(grdv_lop);
            panel2.Location = new Point(438, 66);
            panel2.Name = "panel2";
            panel2.Size = new Size(785, 513);
            panel2.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { maKhoaDataGridViewTextBoxColumn, tenKhoaDataGridViewTextBoxColumn });
            dataGridView1.DataSource = khoaBindingSource;
            dataGridView1.Location = new Point(3, 337);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(240, 150);
            dataGridView1.TabIndex = 3;
            // 
            // maKhoaDataGridViewTextBoxColumn
            // 
            maKhoaDataGridViewTextBoxColumn.DataPropertyName = "MaKhoa";
            maKhoaDataGridViewTextBoxColumn.HeaderText = "MaKhoa";
            maKhoaDataGridViewTextBoxColumn.Name = "maKhoaDataGridViewTextBoxColumn";
            // 
            // tenKhoaDataGridViewTextBoxColumn
            // 
            tenKhoaDataGridViewTextBoxColumn.DataPropertyName = "TenKhoa";
            tenKhoaDataGridViewTextBoxColumn.HeaderText = "TenKhoa";
            tenKhoaDataGridViewTextBoxColumn.Name = "tenKhoaDataGridViewTextBoxColumn";
            // 
            // khoaBindingSource
            // 
            khoaBindingSource.DataSource = typeof(Entities.Khoa);
            // 
            // lstv_lop
            // 
            lstv_lop.Columns.AddRange(new ColumnHeader[] { colhead_ma_lop, col_head_ten_lop });
            lstv_lop.Location = new Point(6, 201);
            lstv_lop.Name = "lstv_lop";
            lstv_lop.Size = new Size(776, 97);
            lstv_lop.TabIndex = 2;
            lstv_lop.UseCompatibleStateImageBehavior = false;
            lstv_lop.View = System.Windows.Forms.View.Details;
            lstv_lop.SelectedIndexChanged += lstv_SelectedIndexChanged;
            // 
            // colhead_ma_lop
            // 
            colhead_ma_lop.Text = "Mã lớp";
            colhead_ma_lop.Width = 300;
            // 
            // col_head_ten_lop
            // 
            col_head_ten_lop.Text = "Tên lớp";
            col_head_ten_lop.Width = 300;
            // 
            // btn_xoa
            // 
            btn_xoa.Location = new Point(6, 161);
            btn_xoa.Name = "btn_xoa";
            btn_xoa.Size = new Size(75, 23);
            btn_xoa.TabIndex = 1;
            btn_xoa.Text = "Xóa";
            btn_xoa.UseVisualStyleBackColor = true;
            btn_xoa.Click += btn_xoa_Click;
            // 
            // grdv_lop
            // 
            grdv_lop.AllowUserToOrderColumns = true;
            grdv_lop.AutoGenerateColumns = false;
            grdv_lop.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdv_lop.Columns.AddRange(new DataGridViewColumn[] { maLopDataGridViewTextBoxColumn, tenLopDataGridViewTextBoxColumn });
            grdv_lop.DataSource = lopBindingSource;
            grdv_lop.Location = new Point(6, 3);
            grdv_lop.Name = "grdv_lop";
            grdv_lop.RowTemplate.Height = 25;
            grdv_lop.Size = new Size(779, 140);
            grdv_lop.TabIndex = 0;
            grdv_lop.CellClick += grdv_lop_CellClick;
            // 
            // maLopDataGridViewTextBoxColumn
            // 
            maLopDataGridViewTextBoxColumn.DataPropertyName = "MaLop";
            maLopDataGridViewTextBoxColumn.HeaderText = "Mã Lớp";
            maLopDataGridViewTextBoxColumn.Name = "maLopDataGridViewTextBoxColumn";
            maLopDataGridViewTextBoxColumn.Width = 360;
            // 
            // tenLopDataGridViewTextBoxColumn
            // 
            tenLopDataGridViewTextBoxColumn.DataPropertyName = "TenLop";
            tenLopDataGridViewTextBoxColumn.HeaderText = "Tên lớp";
            tenLopDataGridViewTextBoxColumn.Name = "tenLopDataGridViewTextBoxColumn";
            tenLopDataGridViewTextBoxColumn.Width = 360;
            // 
            // lopBindingSource
            // 
            lopBindingSource.DataSource = typeof(Entities.Lop);
            // 
            // btn_back_previous_form
            // 
            btn_back_previous_form.Location = new Point(319, 16);
            btn_back_previous_form.Name = "btn_back_previous_form";
            btn_back_previous_form.Size = new Size(75, 23);
            btn_back_previous_form.TabIndex = 4;
            btn_back_previous_form.Text = "Back previous form";
            btn_back_previous_form.UseVisualStyleBackColor = true;
            btn_back_previous_form.Click += btn_back_previous_form_Click;
            // 
            // LopFrom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1235, 591);
            Controls.Add(btn_back_previous_form);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LopFrom";
            Text = "Lớp";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picbox_test).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)khoaBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)grdv_lop).EndInit();
            ((System.ComponentModel.ISupportInitialize)lopBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Panel panel1;
        private Panel panel2;
        private TextBox txt_ma_lop;
        private Label label3;
        private TextBox txt_ten_lop;
        private Label label4;
        private Button btn_capnhat;
        private Button btn_luu;
        private DataGridView grdv_lop;
        private BindingSource lopBindingSource;
        private Button btn_xoa;
        private ComboBox cbx_test;
        private Button btn_test;
        private DataGridViewTextBoxColumn maLopDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tenLopDataGridViewTextBoxColumn;
        private ListView lstv_lop;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader colhead_ma_lop;
        private ColumnHeader col_head_ten_lop;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn maKhoaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tenKhoaDataGridViewTextBoxColumn;
        private BindingSource khoaBindingSource;
        private PictureBox picbox_test;
        private Button btn_upload;
        private TextBox txt_file_name;
        private Button btn_back_previous_form;
    }
}