using Demo1.DAO;
using Demo1.Entities;
using Demo1.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Demo1.View
{
    public partial class LopFrom : Form
    {
        List<Lop> lop_list;
        AbstractDAO<Lop> lop_dao;

        public LopFrom()
        {
            InitializeComponent();
            lop_dao = new LopDAO();

            lop_list = lop_dao.getAll();

            loadData(lop_list);
            loadDataCombox();
            loadListView();

            lstv_lop.MultiSelect = true;


            Debug.WriteLine(System.IO.Path.Combine(Path.GetFullPath(@"..\..\..\"), "Images", "DemoImg.jpg"));
            picbox_test.Image = Image.FromFile(System.IO.Path.Combine(Path.GetFullPath(@"..\..\..\"), "Images", "DemoImg.jpg"));
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            string malop = txt_ma_lop.Text;
            string tenlop = txt_ten_lop.Text;

            Debug.WriteLine("Btn click");

            Lop lop = new Lop(malop, tenlop);


            Lop recieve = lop_dao.insert(lop);

            Debug.WriteLine(recieve.MaLop + " " + recieve.TenLop);

            txt_ma_lop.Text = recieve.MaLop;
            txt_ten_lop.Text = recieve.TenLop;

            loadData();
            MessageBox.Show("Thêm thành công");
        }


        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            string malop = txt_ma_lop.Text;
            string tenlop = txt_ten_lop.Text;

            Lop lop = new Lop(malop, tenlop);


            Lop recieve = lop_dao.upadte(lop);

            Debug.WriteLine(recieve.MaLop + " " + recieve.TenLop);

            txt_ma_lop.Text = recieve.MaLop;
            txt_ten_lop.Text = recieve.TenLop;

            loadData();
            MessageBox.Show("Cập nhật thành công");
        }

        private void loadData()
        {
            List<Lop> list = lop_dao.getAll();
            grdv_lop.DataSource = list;
        }

        private void loadListView()
        {
            List<Lop> list = lop_dao.getAll();
            foreach (Lop lop in list)
            {
                string[] row = { lop.MaLop, lop.TenLop };
                var listViewItem = new ListViewItem(row);
                lstv_lop.Items.Add(listViewItem);
            }
        }

        private void loadData(List<Lop> list)
        {
            grdv_lop.DataSource = list;
        }

        private void loadDataCombox()
        {
            List<Lop> list = lop_dao.getAll();

            cbx_test.DataSource = list;
            cbx_test.ValueMember = "MaLop"; // value combobox
            cbx_test.DisplayMember = "TenLop"; // Label combobox


        }

        private void grdv_lop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_ma_lop.Text = grdv_lop.CurrentRow.Cells[0].FormattedValue.ToString();
            txt_ten_lop.Text = grdv_lop.CurrentRow.Cells[1].FormattedValue.ToString();
        }


        //  lấy  được chọn 1 hoặc nhiều kết quả trong grid view
        public List<Lop> GetSelectionInGridView()
        {
            List<Lop> list = new List<Lop>();
            var rows = grdv_lop.SelectedRows;
            for (int i = 0; i < rows.Count; i++)
            {
                Lop? p = rows[i].DataBoundItem as Lop;
                if (p != null)
                    list.Add(p);
            }

            return list;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc xóa kết quả đã chọn ?",
                       "Đồng ý", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    List<Lop> lops = GetSelectionInGridView();
                    foreach (var lop in lops)
                    {
                        lop_dao.remove(lop);
                    }
                    loadData();
                    break;
                case DialogResult.No:
                    break;
            }

        }

        private void btn_test_Click(object sender, EventArgs e)
        {


            Lop? lop = cbx_test.SelectedItem as Lop;

            Lop? lop_find = null;
            LopDAO dAO = new LopDAO();

            if (cbx_test.SelectedIndex > -1)
            {

                lop_find = dAO.findById(lop.MaLop);
                MessageBox.Show("Value: " + lop.MaLop + " Display: " + lop.TenLop + " Find: " + lop_find.MaLop + " " + lop_find.TenLop);

            }

        }

        private void lstv_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Lop> list = new List<Lop>();
            Lop lop = new Lop();


            if (lstv_lop.SelectedItems.Count > 0)
            {
                string colunmName = lstv_lop.Columns[0].Text;//Get the title name of first column

                //Get the value of the first column of the selected row
                lop.MaLop = lstv_lop.SelectedItems[0].SubItems[0].Text;

                //Get the value of the second column of the selected row
                lop.TenLop = lstv_lop.SelectedItems[0].SubItems[1].Text;

                //Get the value when multiple rows are selected, can use or comment 
                foreach (ListViewItem lvi in lstv_lop.SelectedItems)
                {
                    lop.MaLop = lvi.SubItems[0].Text;
                    lop.TenLop = lvi.SubItems[1].Text;
                    list.Add(lop);
                }
            }

            foreach (Lop l in list)
            {
                Debug.WriteLine(l.MaLop + " " + l.TenLop);
            }

            Debug.WriteLine(lop.MaLop + " " + lop.TenLop);
        }

        private void picbox_test_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.png; *.gif; *.bmp;)| *.jpg; *.jpeg; *.png; *.gif; *.bmp; ";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                picbox_test.Image = new Bitmap(openFileDialog.FileName);
                txt_file_name.Text = openFileDialog.FileName;
            }
        }

        private void btn_upload_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_file_name.Text))
            {
                // 3 tham số: tên file, nối tên file với đường dẫn thư mục của project, có ghi đè không
                File.Copy(txt_file_name.Text, Path.Combine(Path.GetFullPath(@"..\..\..\"), "Images", Path.GetFileName(txt_file_name.Text)), true);
                string path = Path.Combine(Path.GetFullPath(@"..\..\..\"), "Images", Path.GetFileName(txt_file_name.Text));
                Debug.WriteLine(path);
                MessageBox.Show("Uploaded successful", "Comfirm");
            }
            else
            {
                MessageBox.Show("File not chose", "Comfirm");
            }

        }

        private void btn_back_previous_form_Click(object sender, EventArgs e)
        {
            ActionFormHelper.backPreviousForm(this, new IndexForm());
        }
    }
}
