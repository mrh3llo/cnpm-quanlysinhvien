using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UngDungQuanLyHoSoSinhVien.admin
{
    public partial class frm_admin_QuanLy : Form
    {
        public frm_admin_QuanLy()
        {
            InitializeComponent();
        }

        private void btn_DSTaiKhoan_Click(object sender, EventArgs e)
        {
            frm_admin_DanhSachTaiKhoan frm_DSTK = new frm_admin_DanhSachTaiKhoan();
            frm_DSTK.ShowDialog();
        }

        private void btn_XoaTaiKhoan_Click(object sender, EventArgs e)
        {
            frm_admin_DanhSachTaiKhoan frm_DSTK = new frm_admin_DanhSachTaiKhoan();
            frm_DSTK.ShowDialog();
        }

        private void btn_TaoTaiKhoan_Click(object sender, EventArgs e)
        {
            frm_admin_DienThongTin frm_DienTT = new frm_admin_DienThongTin();
            frm_DienTT.ShowDialog();
        }

        private void btn_SuaTaiKhoan_Click(object sender, EventArgs e)
        {
            frm_admin_DienThongTin frm_DienTT = new frm_admin_DienThongTin();
            frm_DienTT.ShowDialog();
        }
    }
}
