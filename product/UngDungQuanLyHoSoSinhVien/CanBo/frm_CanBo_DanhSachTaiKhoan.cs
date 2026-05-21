using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UngDungQuanLyHoSoSinhVien.CanBo
{
    public partial class frm_CanBo_DanhSachTaiKhoan : Form
    {
        public frm_CanBo_DanhSachTaiKhoan()
        {
            InitializeComponent();

            frm_DangNhap frm_DN = new frm_DangNhap();

            if (frm_DN.layVaiTro() == 2)
            {
                XuLyTaiKhoanSinhVien TK_SinhVien = new XuLyTaiKhoanSinhVien();
                TK_SinhVien.HienThi_DS_SinhVien(dgv_DSSinhVien);
            }
            else
            {
                this.Enabled = false;

                MessageBox.Show("Bạn không có quyền truy cập vào trang quản lý tài khoản! Vui lòng đăng nhập bằng tài khoản quản trị viên để sử dụng chức năng này.", "Quyền truy cập bị từ chối");
                this.Close();

                frm_DN.datVaiTro(0);
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
