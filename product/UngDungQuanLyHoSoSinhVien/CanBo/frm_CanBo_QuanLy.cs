using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using UngDungQuanLyHoSoSinhVien.admin;

namespace UngDungQuanLyHoSoSinhVien.CanBo
{
    public partial class frm_CanBo_QuanLy : Form
    {
        public frm_CanBo_QuanLy()
        {
            InitializeComponent();

            XuLyTaiKhoanSinhVien TK_SinhVien = new XuLyTaiKhoanSinhVien();
            TK_SinhVien.HienThi_DS_SinhVien(dgv_DSSinhVien);
        }

        private void frm_CanBo_QuanLy_Load(object sender, EventArgs e)
        {
            XuLyTaiKhoanSinhVien TK_SinhVien = new XuLyTaiKhoanSinhVien();
            TK_SinhVien.HienThi_DS_SinhVien(dgv_DSSinhVien);
        }

        private void btn_TaiLai_Click(object sender, EventArgs e)
        {
            XuLyTaiKhoanSinhVien TK_SinhVien = new XuLyTaiKhoanSinhVien();
            TK_SinhVien.HienThi_DS_SinhVien(dgv_DSSinhVien);
        }

        private void btn_DSTaiKhoan_Click(object sender, EventArgs e)
        {
            frm_CanBo_DanhSachTaiKhoan frm_DSTK = new frm_CanBo_DanhSachTaiKhoan();
            frm_DSTK.ShowDialog();
        }

        private void btn_TaoTaiKhoan_Click(object sender, EventArgs e)
        {
            frm_CanBo_DienThongTin frm_DienTT = new frm_CanBo_DienThongTin();
            frm_DienTT.ShowDialog();
        }

        private void btn_SuaTaiKhoan_Click(object sender, EventArgs e)
        {
            int dong = dgv_DSSinhVien.CurrentCell.RowIndex;

            frm_admin_DienThongTin frm_DienTT = new frm_admin_DienThongTin();
            frm_DienTT.datTrangThai(1);

            if (dong >= 0 && dong < dgv_DSSinhVien.Rows.Count)
            {
                DataRow TTSV_Grid = ((DataRowView)dgv_DSSinhVien.Rows[dong].DataBoundItem).Row;
                string MaSV = TTSV_Grid["MaSV"].ToString();

                XuLyTaiKhoanSinhVien TK_SinhVien = new XuLyTaiKhoanSinhVien();
                DataRow TTSV = TK_SinhVien.TimSinhVienChiTiet(MaSV);

                if (TTSV != null)
                {
                    frm_DienTT.tb_HoTen.Text = TTSV["HoTen"].ToString();
                    frm_DienTT.tb_Email.Text = TTSV["Email"].ToString();
                    frm_DienTT.tb_SDT.Text = TTSV["SDT"].ToString();
                    frm_DienTT.cmb_GioiTinh.SelectedItem = TTSV["GioiTinh"].ToString();
                    frm_DienTT.date_NgaySinh.Value = DateTime.Parse(TTSV["NgaySinh"].ToString());
                    frm_DienTT.tb_SoCCCD.Text = TTSV["SoCCCD"].ToString();
                    frm_DienTT.tb_DiaChi.Text = TTSV["DiaChiThuongTru"].ToString();
                    frm_DienTT.tb_NienKhoa.Text = TTSV["NienKhoa"].ToString();
                    frm_DienTT.DuongDanAnh = TTSV["AnhDaiDien"].ToString();

                    // Gán giá trị cho ComboBox (sử dụng SelectedValue - mã)
                    frm_DienTT.cmb_DanToc.SelectedValue = TTSV["MaDanToc"].ToString();
                    frm_DienTT.cmb_TonGiao.SelectedValue = TTSV["MaTonGiao"].ToString();
                    frm_DienTT.cmb_NoiSinh.SelectedValue = TTSV["MaTinhThanhNoiSinh"].ToString();
                    frm_DienTT.cmb_KhoaTruong.SelectedValue = TTSV["MaKhoaTruong"].ToString();
                    frm_DienTT.cmb_Nganh.SelectedValue = TTSV["MaNganh"].ToString();
                    frm_DienTT.cmb_Lop.SelectedValue = TTSV["MaLop"].ToString();

                    // Gán Quê quán (cần reload cmb_QQ_XaPhuong theo TinhThanh)
                    frm_DienTT.cmb_QQ_TinhThanh.SelectedValue = TTSV["MaTinhThanhQueQuan"].ToString();
                    frm_DienTT.cmb_QQ_XaPhuong.SelectedValue = TTSV["MaXaPhuongQueQuan"].ToString();
                    frm_DienTT.cmb_TrangThai.SelectedItem = TTSV["TrangThai"].ToString();

                    frm_DienTT.ShowDialog();
                }
                else
                    MessageBox.Show("Không tìm thấy thông tin chi tiết của sinh viên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_DangXuat_Click(object sender, EventArgs e)
        {
            this.Close();

            frm_DangNhap frm_DN = new frm_DangNhap();
            frm_DN.Visible = true;
            frm_DN.datVaiTro(0);
        }
    }
}
