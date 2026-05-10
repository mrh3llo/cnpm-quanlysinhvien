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
        }
    }
}
