using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Text;
using System.Windows.Forms;

using UngDungQuanLyHoSoSinhVien;

namespace UngDungQuanLyHoSoSinhVien.admin
{
    public partial class frm_admin_QuanLy : Form
    {
        frm_DangNhap frm_DN;
        byte TrangThai;

        public frm_admin_QuanLy()
        {
            InitializeComponent();

            frm_DN = new frm_DangNhap();
            TrangThai = frm_DN.layVaiTro();

            if (TrangThai == 1)
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

        private void frm_admin_QuanLy_Load(object sender, EventArgs e)
        {
            XuLyTaiKhoanSinhVien TK_SinhVien = new XuLyTaiKhoanSinhVien();
            TK_SinhVien.HienThi_DS_SinhVien(dgv_DSSinhVien);
        }

        private void btn_TaiLai_Click(object sender, EventArgs e)
        {
            XuLyTaiKhoanSinhVien TK_SinhVien = new XuLyTaiKhoanSinhVien();
            TK_SinhVien.HienThi_DS_SinhVien(dgv_DSSinhVien);
        }

        private void btn_DangXuat_Click(object sender, EventArgs e)
        {
            frm_DN.datVaiTro(0);
            frm_DN.ShowDialog();
            this.Close();
        }
    }
}
