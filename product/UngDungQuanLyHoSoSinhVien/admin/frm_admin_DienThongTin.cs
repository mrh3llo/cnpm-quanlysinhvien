using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UngDungQuanLyHoSoSinhVien.admin
{
    public partial class frm_admin_DienThongTin : Form
    {
        public string DuongDanAnh = "";

        public frm_admin_DienThongTin()
        {
            InitializeComponent();

            frm_DangNhap frm_DN = new frm_DangNhap();
            byte TrangThai = frm_DN.layVaiTro();

            if (TrangThai != 1)
            {
                this.Enabled = false;

                MessageBox.Show("Bạn không có quyền truy cập vào trang quản lý tài khoản! Vui lòng đăng nhập bằng tài khoản quản trị viên để sử dụng chức năng này.", "Quyền truy cập bị từ chối");
                this.Close();

                frm_DN.datVaiTro(0);
            }

            // Hiển thị các giá trị trong ComboBox
            XuLyTaiKhoanSinhVien TK_SinhVien = new XuLyTaiKhoanSinhVien();

            cmb_DanToc = TK_SinhVien.HienThi_LuaChon("SELECT * FROM DanToc", "TenDanToc", "MaDanToc");
        }

        private void btn_ChonAnhDaiDien_Click(object sender, EventArgs e)
        {
            file_AnhDaiDien.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            file_AnhDaiDien.Title = "Chọn ảnh đại diện";
            if (file_AnhDaiDien.ShowDialog() == DialogResult.OK)
                this.DuongDanAnh = file_AnhDaiDien.FileName;
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
