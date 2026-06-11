using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UngDungQuanLyHoSoSinhVien
{
    public partial class frm_DoiMatKhau : Form
    {
        private string MaSV = "";

        private bool HienThiMatKhau = false;
        private XuLyTaiKhoanSinhVien XL_TaiKhoan = new XuLyTaiKhoanSinhVien();

        public frm_DoiMatKhau(string MaSV)
        {
            InitializeComponent();
            this.MaSV = MaSV;
        }

        private void btn_HienThiMatKhau_Click(object sender, EventArgs e)
        {
            if (this.HienThiMatKhau == false)
            {
                this.tb_MatKhauCu.PasswordChar = '\0';
                this.tb_MatKhauMoi.PasswordChar = '\0';
                this.tb_XacNhanMatKhau.PasswordChar = '\0';
                this.btn_HienThiMatKhau.Text = "Ẩn mật khẩu";
                this.HienThiMatKhau = true;
            }
            else
            {
                this.tb_MatKhauCu.PasswordChar = '*';
                this.tb_MatKhauMoi.PasswordChar = '*';
                this.tb_XacNhanMatKhau.PasswordChar = '*';
                this.btn_HienThiMatKhau.Text = "Hiển thị mật khẩu";
                this.HienThiMatKhau = false;
            }
        }

        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            if (tb_MatKhauMoi.Text.ToString() == tb_XacNhanMatKhau.Text.ToString())
            {
                XL_TaiKhoan.DoiMatKhau(this.MaSV, tb_MatKhauCu.Text.ToString(), tb_MatKhauMoi.Text.ToString());
                MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Xác nhận mật khẩu không khớp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_NhapLai_Click(object sender, EventArgs e)
        {
            tb_MatKhauCu.Clear();
            tb_MatKhauMoi.Clear();
            tb_XacNhanMatKhau.Clear();
        }
    }
}
