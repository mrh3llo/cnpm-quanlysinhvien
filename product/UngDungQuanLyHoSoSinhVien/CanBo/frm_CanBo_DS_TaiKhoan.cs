using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UngDungQuanLyHoSoSinhVien.admin
{
    public partial class frm_admin_DSTaiKhoan : Form
    {
        public frm_admin_DSTaiKhoan()
        {
            InitializeComponent();

            XuLyTaiKhoanSinhVien TK_SinhVien = new XuLyTaiKhoanSinhVien();
            TK_SinhVien.HienThi_DS_SinhVien(dgv_DSSinhVien);
        }

        private void frm_admin_DSTaiKhoan_Load(object sender, EventArgs e)
        {
            XuLyTaiKhoanSinhVien TK_SinhVien = new XuLyTaiKhoanSinhVien();
            TK_SinhVien.HienThi_DS_SinhVien(dgv_DSSinhVien);
        }

        private void btn_TaiLai_Click(object sender, EventArgs e)
        {
            XuLyTaiKhoanSinhVien TK_SinhVien = new XuLyTaiKhoanSinhVien();
            TK_SinhVien.HienThi_DS_SinhVien(dgv_DSSinhVien);
        }
    }
}
