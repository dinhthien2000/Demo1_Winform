using Demo1.Helper;
using Demo1.View;
using System.Diagnostics;

namespace Demo1
{

    public partial class IndexForm : Form
    {
        public static IndexForm? Current;

        SinhVienForm sinhVienForm;
        LopFrom lopFrom;
        NienKhoaForm nienKhoaForm;
        KhoaForm khoaForm;

        public IndexForm()
        {
            InitializeComponent();

            Current = this;

            sinhVienForm = new SinhVienForm();
            lopFrom = new LopFrom();
            nienKhoaForm = new NienKhoaForm();
            khoaForm = new KhoaForm();
        }


        private void btn_sinh_vien_Click(object sender, EventArgs e)
        {
            ActionFormHelper.nevigationForm(this,sinhVienForm);
        }

        private void btn_lop_Click(object sender, EventArgs e)
        {
            ActionFormHelper.nevigationForm(this, lopFrom);
        }


        private void btn_nien_khoa_Click(object sender, EventArgs e)
        {
            ActionFormHelper.nevigationForm(this, nienKhoaForm);
        }

        private void btn_khoa_Click(object sender, EventArgs e)
        {
            ActionFormHelper.nevigationForm(this, khoaForm);
        }
    }
}