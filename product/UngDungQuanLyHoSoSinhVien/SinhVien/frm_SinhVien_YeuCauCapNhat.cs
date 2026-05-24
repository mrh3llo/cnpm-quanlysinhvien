using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UngDungQuanLyHoSoSinhVien.SinhVien
{
    public partial class frm_SinhVien_YeuCauCapNhat : Form
    {
        private string MaSV;

        public frm_SinhVien_YeuCauCapNhat(string MaSV)
        {
            InitializeComponent();
            this.MaSV = MaSV;

            if(this.MaSV == null)
            {
                MessageBox.Show("Không tồn tại tài khoản. Vui lòng kiểm tra lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            XuLyTaiKhoanSinhVien TK_SinhVien = new XuLyTaiKhoanSinhVien();
            TK_SinhVien.GuiYeuCauCapNhat_TT_SinhVien(this.MaSV, tb_SDT.Text.ToString(), tb_Email.Text.ToString(), tb_DiaChi.Text.ToString(), rtb_LyDoCapNhat.Text.ToString());
        }

        private void btn_NhapLai_Click(object sender, EventArgs e)
        {
            tb_SDT.Clear();
            tb_Email.Clear();
            tb_DiaChi.Clear();
            rtb_LyDoCapNhat.Clear();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
