using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UngDungQuanLyHoSoSinhVien.SinhVien
{
    public partial class frm_SinhVien_ThongTinCaNhan : Form
    {
        private byte VaiTro;

        public frm_SinhVien_ThongTinCaNhan(byte VaiTro, string MaSV)
        {
            InitializeComponent();
            this.VaiTro = VaiTro;

            if (this.VaiTro == 4)
            {
                XuLyTaiKhoanSinhVien TK_SinhVien = new XuLyTaiKhoanSinhVien();
                DataRow TTSV = TK_SinhVien.TimSinhVienChiTiet(MaSV);

                HienThiTTSinhVien(TTSV);
            }
            else
            {
                this.Enabled = false;

                MessageBox.Show("Bạn không có quyền truy cập vào trang quản lý tài khoản! Vui lòng đăng nhập bằng tài khoản cán bộ để sử dụng chức năng này.", "Quyền truy cập bị từ chối");
                this.Close();
            }
        }

        private void HienThiTTSinhVien(DataRow TT_SinhVien)
        {
            try
            {
                if (TT_SinhVien == null)
                {
                    MessageBox.Show("Không có dữ liệu sinh viên để hiển thị!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // Thông tin cá nhân
                if (TT_SinhVien["AnhDaiDien"] == DBNull.Value || string.IsNullOrEmpty(TT_SinhVien["AnhDaiDien"].ToString()))
                    ptb_AnhDaiDien.Image = new Bitmap(Application.StartupPath + @"\assets\img\AnhDaiDien_MacDinh.png");
                else
                    ptb_AnhDaiDien.Image = new Bitmap(Application.StartupPath + @$"{TT_SinhVien["AnhDaiDien"].ToString()}");

                lb_MSSV.Text = TT_SinhVien["MaSV"].ToString();
                lb_HoTen.Text = TT_SinhVien["HoTen"].ToString();
                lb_GioiTinh.Text = TT_SinhVien["GioiTinh"].ToString();
                lb_SDT.Text = TT_SinhVien["SDT"].ToString();
                lb_Email.Text = TT_SinhVien["Email"].ToString();
                lb_DiaChiThuongTru.Text = TT_SinhVien["DiaChiThuongTru"].ToString();
                lb_NgaySinh.Text = TT_SinhVien["NgaySinh"].ToString();
                lb_NoiSinh.Text = TT_SinhVien["NoiSinh"].ToString();
                lb_DanToc.Text = TT_SinhVien["DanToc"].ToString();
                lb_TonGiao.Text = TT_SinhVien["TonGiao"].ToString();
                lb_QueQuan.Text = TT_SinhVien["QueQuan"].ToString();

                // Thông tin học tập
                lb_Lop.Text = TT_SinhVien["Lop"].ToString();
                lb_Nganh.Text = TT_SinhVien["Nganh"].ToString();
                lb_Khoa_Truong.Text = TT_SinhVien["Khoa_Truong"].ToString();
                lb_NienKhoa.Text = TT_SinhVien["NienKhoa"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi hiển thị thông tin sinh viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_YeuCauCapNhat_Click(object sender, EventArgs e)
        {
            frm_SinhVien_YeuCauCapNhat frm_YCCapNhat = new frm_SinhVien_YeuCauCapNhat(lb_MSSV.Text.ToString());

            frm_YCCapNhat.tb_SDT.Text = this.lb_SDT.Text.ToString();
            frm_YCCapNhat.tb_Email.Text = this.lb_Email.Text.ToString();
            frm_YCCapNhat.tb_DiaChi.Text = this.lb_DiaChiThuongTru.Text.ToString();

            frm_YCCapNhat.Show();
        }

        private void btn_LichSu_YCCapNhat_Click(object sender, EventArgs e)
        {
            frm_SinhVien_LichSuGuiYeuCauCapNhat frm_LSCapNhat = new frm_SinhVien_LichSuGuiYeuCauCapNhat(lb_MSSV.Text.ToString());
            frm_LSCapNhat.Show();
        }

        private void btn_DangXuat_Click(object sender, EventArgs e)
        {
            frm_DangNhap frm_DN = new frm_DangNhap();
            frm_DN.Show();
            this.Close();
        }

        private void btn_DoiMatKhau_Click(object sender, EventArgs e)
        {
            frm_DoiMatKhau frm_DoiMK = new frm_DoiMatKhau(lb_MSSV.Text.ToString());
            frm_DoiMK.Show();
        }
    }
}
