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
            frm_DienTT.datTrangThai(0);
            frm_DienTT.ShowDialog();
        }

        private void btn_SuaTaiKhoan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("DỮ LIỆU CỦA QUÊ QUÁN XÃ PHƯỜNG CHỈ CÓ CHO 5 TỈNH ĐẦU TIÊN!!!", "NHẮC NHỎ KHI DEMO", MessageBoxButtons.OK);

            int dong = dgv_DSSinhVien.CurrentCell.RowIndex;

            frm_admin_DienThongTin frm_DienTT = new frm_admin_DienThongTin();
            frm_DienTT.datTrangThai(1);

            if (dong >= 0 && dong < dgv_DSSinhVien.Rows.Count)
            {
                DataRow TTSV = ((DataRowView)dgv_DSSinhVien.Rows[dong].DataBoundItem).Row;

                frm_DienTT.datMaSV(TTSV["MaSV"].ToString());

                frm_DienTT.DuongDanAnh = TTSV["AnhDaiDien"].ToString();
                frm_DienTT.tb_HoTen.Text = TTSV["HoTen"].ToString();
                frm_DienTT.cmb_GioiTinh.SelectedItem = TTSV["GioiTinh"].ToString();
                frm_DienTT.date_NgaySinh.Value = DateTime.Parse(TTSV["NgaySinh"].ToString());
                frm_DienTT.tb_SDT.Text = TTSV["SDT"].ToString();
                frm_DienTT.tb_Email.Text = TTSV["Email"].ToString();
                frm_DienTT.tb_DiaChi.Text = TTSV["DiaChiThuongTru"].ToString();

                frm_DienTT.cmb_DanToc.SelectedText = TTSV["DanToc"].ToString();
                frm_DienTT.cmb_TonGiao.SelectedText = TTSV["TonGiao"].ToString();
                frm_DienTT.cmb_NoiSinh.SelectedText = TTSV["NoiSinh"].ToString();
                frm_DienTT.cmb_QQ_TinhThanh.SelectedText = TTSV["QQ_TinhThanh"].ToString();
                frm_DienTT.cmb_QQ_XaPhuong.SelectedText = TTSV["QQ_XaPhuong"].ToString();

                frm_DienTT.tb_SoCCCD.Text = TTSV["SoCCCD"].ToString();
                frm_DienTT.cmb_KhoaTruong.SelectedText = TTSV["Khoa_Truong"].ToString();
                frm_DienTT.cmb_Nganh.SelectedText = TTSV["Nganh"].ToString();
                frm_DienTT.cmb_Lop.SelectedText = TTSV["Lop"].ToString();
                frm_DienTT.tb_NienKhoa.Text = TTSV["NienKhoa"].ToString();
                frm_DienTT.cmb_TrangThai.SelectedText = TTSV["TrangThai"].ToString();

                frm_DienTT.ShowDialog();
            }
            else
                MessageBox.Show("Không tìm thấy thông tin chi tiết của sinh viên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            frm_DN.Visible = true;
            this.Close();
        }

        private void btn_TimMSSV_Click(object sender, EventArgs e)
        {
            XuLyTaiKhoanSinhVien TK_SinhVien = new XuLyTaiKhoanSinhVien();
            TK_SinhVien.TimMaSV(tb_TimMSSV.Text.ToString());
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
    }
}
