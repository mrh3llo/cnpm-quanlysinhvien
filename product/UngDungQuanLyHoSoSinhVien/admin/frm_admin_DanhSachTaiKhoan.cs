using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UngDungQuanLyHoSoSinhVien.admin
{
    public partial class frm_admin_DanhSachTaiKhoan : Form
    {
        public frm_admin_DanhSachTaiKhoan()
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
            else
            {
                XuLyTaiKhoanSinhVien TK_SinhVien = new XuLyTaiKhoanSinhVien();
                TK_SinhVien.HienThi_DS_SinhVien(dgv_DSSinhVien);
            }
        }

        private void frm_admin_DanhSachTaiKhoan_Load(object sender, EventArgs e)
        {
            XuLyTaiKhoanSinhVien TK_SinhVien = new XuLyTaiKhoanSinhVien();
            TK_SinhVien.HienThi_DS_SinhVien(dgv_DSSinhVien);
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_TimMSSV_Click(object sender, EventArgs e)
        {
            XuLyTaiKhoanSinhVien TK_SinhVien = new XuLyTaiKhoanSinhVien();
            TK_SinhVien.TimMaSV(tb_TimMSSV.Text.ToString());
        }

        private void btn_ChiTietTT_Click(object sender, EventArgs e)
        {
            int dong = dgv_DSSinhVien.CurrentCell.RowIndex;

            XuLyTaiKhoanSinhVien TK_SinhVien = new XuLyTaiKhoanSinhVien();
            if(dong >= 0 && dong < dgv_DSSinhVien.Rows.Count)
            {
                DataRow TTSV = ((DataRowView)dgv_DSSinhVien.Rows[dong].DataBoundItem).Row;
                TK_SinhVien.HienThiChiTiet_TT_SinhVien(TTSV);
            }
        }

        private void dgv_DSSinhVien_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            XuLyTaiKhoanSinhVien TK_SinhVien = new XuLyTaiKhoanSinhVien();
            if (e.RowIndex >= 0 && e.RowIndex < dgv_DSSinhVien.Rows.Count)
            {
                DataRow TTSV = ((DataRowView)dgv_DSSinhVien.Rows[e.RowIndex].DataBoundItem).Row;
                TK_SinhVien.TimMaSV(TTSV["MaSV"].ToString());
            }
        }

        private void btn_XoaTaiKhoan_Click(object sender, EventArgs e)
        {
            int dong = dgv_DSSinhVien.CurrentCell.RowIndex;

            XuLyTaiKhoanSinhVien TK_SinhVien = new XuLyTaiKhoanSinhVien();
            if(dong >= 0 && dong < dgv_DSSinhVien.Rows.Count)
            {
                // Xác định trước khi xóa tài khoản, tránh xóa nhầm
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa tài khoản này không?", "Xác nhận xóa tài khoản", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DataRow TTSV = ((DataRowView)dgv_DSSinhVien.Rows[dong].DataBoundItem).Row;
                    TK_SinhVien.XoaSinhVien(TTSV["MaSV"].ToString());
                }
            }
        }

        private void btn_CapNhatTT_Click(object sender, EventArgs e)
        {
            int dong = dgv_DSSinhVien.CurrentCell.RowIndex;

            frm_admin_DienThongTin frm_DienTT = new frm_admin_DienThongTin();

            if (dong >= 0 && dong < dgv_DSSinhVien.Rows.Count)
            {
                DataRow TTSV = ((DataRowView)dgv_DSSinhVien.Rows[dong].DataBoundItem).Row;

                // Hiển thị thông tin trên form điền thông tin
                frm_DienTT.tb_HoTen.Text = TTSV["HoTen"].ToString();
                frm_DienTT.tb_Email.Text = TTSV["Email"].ToString();
                frm_DienTT.tb_SDT.Text = TTSV["SDT"].ToString();

                frm_DienTT.cmb_GioiTinh.SelectedItem = TTSV["GioiTinh"].ToString();

                frm_DienTT.date_NgaySinh.Value = DateTime.Parse(TTSV["NgaySinh"].ToString());
                frm_DienTT.tb_SoCCCD.Text = TTSV["So_CCCD"].ToString();
                frm_DienTT.cmb_DanToc.SelectedValue = TTSV["DanToc"].ToString();
                frm_DienTT.cmb_TonGiao.SelectedValue = TTSV["TonGiao"].ToString();
                frm_DienTT.tb_DiaChi.Text = TTSV["DiaChiThuongTru"].ToString();
                frm_DienTT.cmb_NoiSinh.SelectedValue = TTSV["NoiSinh"].ToString();
                frm_DienTT.cmb_QQ_TinhThanh.SelectedValue = TTSV["QueQuan"].ToString();
                frm_DienTT.cmb_QQ_XaPhuong.SelectedValue = TTSV["QueQuan"].ToString();
                frm_DienTT.cmb_KhoaTruong.SelectedValue = TTSV["Khoa_Truong"].ToString();
                frm_DienTT.cmb_Nganh.SelectedValue = TTSV["Nganh"].ToString();
                frm_DienTT.cmb_Lop.SelectedValue = TTSV["Lop"].ToString();
                frm_DienTT.tb_NienKhoa.Text = TTSV["NienKhoa"].ToString();
                frm_DienTT.cmb_TrangThai.SelectedValue = TTSV["TrangThai"].ToString();
                frm_DienTT.DuongDanAnh = TTSV["AnhDaiDien"].ToString();

                frm_DienTT.ShowDialog();
            }
        }
    }
}
