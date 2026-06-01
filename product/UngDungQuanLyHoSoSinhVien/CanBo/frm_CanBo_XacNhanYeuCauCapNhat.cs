using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UngDungQuanLyHoSoSinhVien.GiangVien
{
    public partial class frm_CanBo_XacNhanYeuCauCapNhat : Form
    {
        KetNoiCSDL KN = new KetNoiCSDL();

        private string MaSV;
        private string MaYeuCau;
        private byte VaiTro;
        private byte TrangThaiYeuCau;

        public frm_CanBo_XacNhanYeuCauCapNhat(byte VaiTro)
        {
            InitializeComponent();
            this.VaiTro = VaiTro;

            if (this.VaiTro != 2)
            {
                this.Enabled = false;

                MessageBox.Show("Bạn không có quyền truy cập vào trang quản lý tài khoản! Vui lòng đăng nhập bằng tài khoản cán bộ để sử dụng chức năng này.", "Quyền truy cập bị từ chối");
                this.Close();
            }

            this.Size = new System.Drawing.Size(690, 590);
            grb_TT_CapNhat.Visible = false;
            grb_TT_SinhVien.Visible = false;

            HienThiYeuCauCapNhat();
        }

        private void HienThiYeuCauCapNhat()
        {
            string SQL_TruyVan = $"SELECT " +
                $"YC.MaYeuCau AS MaYeuCau, " +
                $"YC.MaSV AS MaSV, " +
                $"YC.Email_Moi AS Email_Moi, " +
                $"YC.SDT_Moi AS SDT_Moi, " +
                $"YC.DiaChiThuongTru_Moi AS DiaChiThuongTru_Moi, " +
                $"YC.ThoiGianYeuCau AS ThoiGianYeuCau, " +
                $"YC.LyDoCapNhat AS LyDoCapNhat, " +
                $"YC.TrangThai AS TrangThai " +
                $"FROM YeuCauCapNhat AS YC " +
                $"JOIN SinhVien AS SV ON YC.MaSV = SV.MaSV " +
                $"ORDER BY TrangThai ASC;";
            DataTable DS_YeuCauCapNhat = new DataTable();
            DS_YeuCauCapNhat = KN.GhiDuLieuVaoBang(SQL_TruyVan);
            dgv_DSYeuCauCapNhat.DataSource = DS_YeuCauCapNhat;

            dgv_DSYeuCauCapNhat.Columns[0].HeaderText = "Mã yêu cầu";
            dgv_DSYeuCauCapNhat.Columns[1].HeaderText = "Mã sinh viên";
            dgv_DSYeuCauCapNhat.Columns[2].HeaderText = "Email mới";
            dgv_DSYeuCauCapNhat.Columns[3].HeaderText = "SĐT mới";
            dgv_DSYeuCauCapNhat.Columns[4].HeaderText = "Địa chỉ thường trú mới";
            dgv_DSYeuCauCapNhat.Columns[5].HeaderText = "Thời gian yêu cầu";
            dgv_DSYeuCauCapNhat.Columns[6].HeaderText = "Lý do cập nhật";
            dgv_DSYeuCauCapNhat.Columns[7].HeaderText = "Trạng thái";
        }

        private void dgv_DSYeuCauCapNhat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;

            if (dong < 0)
            {
                MessageBox.Show("Không tìm thấy thông tin chi tiết của yêu cầu cập nhật!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            grb_TT_CapNhat.Visible = true;
            grb_TT_SinhVien.Visible = true;

            this.Size = new System.Drawing.Size(1200, 650);

            XuLyTaiKhoanSinhVien TK_SinhVien = new XuLyTaiKhoanSinhVien();
            DataRow TTSV_YeuCauCapNhat = TK_SinhVien.TimSinhVienChiTiet(dgv_DSYeuCauCapNhat.Rows[dong].Cells["MaSV"].Value.ToString());
            DataRow TT_YeuCauCapNhat = ((DataRowView)dgv_DSYeuCauCapNhat.Rows[dong].DataBoundItem).Row;

            this.MaSV = TTSV_YeuCauCapNhat["MaSV"].ToString();
            this.MaYeuCau = TT_YeuCauCapNhat["MaYeuCau"].ToString();
            this.TrangThaiYeuCau = Byte.Parse(TT_YeuCauCapNhat["TrangThai"].ToString());

            // Thông tin sinh viên yêu cầu cập nhật
            lb_HT_MSSV.Text = TTSV_YeuCauCapNhat["MaSV"].ToString();
            lb_HT_HoTen.Text = TTSV_YeuCauCapNhat["HoTen"].ToString();
            lb_HT_Lop.Text = TTSV_YeuCauCapNhat["Lop"].ToString();

            string SQL_TruyVan = $"SELECT " +
                                    $"YC.MaYeuCau AS MaYeuCau, " +
                                    $"YC.MaSV AS MaSV, " +
                                    $"YC.Email_Moi AS Email_Moi, " +
                                    $"YC.SDT_Moi AS SDT_Moi, " +
                                    $"YC.DiaChiThuongTru_Moi AS DiaChiThuongTru_Moi, " +
                                    $"YC.ThoiGianYeuCau AS ThoiGianYeuCau, " +
                                    $"YC.LyDoCapNhat AS LyDoCapNhat, " +
                                    $"YC.TrangThai AS TrangThai " +
                                    $"FROM YeuCauCapNhat AS YC " +
                                    $"JOIN SinhVien AS SV ON YC.MaSV = SV.MaSV " +
                                    $"WHERE MaYeuCau = '{TT_YeuCauCapNhat["MaYeuCau"].ToString()}';";

            DataRow TT_CapNhat = KN.ThaoTac_DocMotDong_DuLieu(SQL_TruyVan);

            byte TrangThaiCapNhat = Convert.ToByte(TT_CapNhat["TrangThai"].ToString());
            string TieuDe = "Thông tin trạng thái:";
            switch (TrangThaiCapNhat)
            {
                case 0:
                    grb_TT_CapNhat.Text = $"{TieuDe} Đợi duyệt";
                    break;
                case 1:
                    grb_TT_CapNhat.Text = $"{TieuDe} Đã duyệt";
                    break;
                case 2:
                    grb_TT_CapNhat.Text = $"{TieuDe} Không duyệt";
                    break;
            }

            if (TrangThaiCapNhat == 0)
                btn_DuyetYeuCau.Enabled = true;
            else
            {
                btn_DuyetYeuCau.Enabled = false;
                btn_KhongDuyetYeuCau.Enabled = false;
            }

            lb_HT_SDT_Cu.Text = TTSV_YeuCauCapNhat["SDT"].ToString();
            lb_HT_SDT_Moi.Text = TT_CapNhat["SDT_Moi"].ToString();

            lb_HT_Email_Cu.Text = TTSV_YeuCauCapNhat["Email"].ToString();
            lb_HT_Email_Moi.Text = TT_CapNhat["Email_Moi"].ToString();

            lb_HT_DiaChi_Cu.Text = TTSV_YeuCauCapNhat["DiaChiThuongTru"].ToString();
            lb_HT_DiaChi_Moi.Text = TT_CapNhat["DiaChiThuongTru_Moi"].ToString();

            rtb_HT_LyDoCapNhat.Text = TT_CapNhat["LyDoCapNhat"].ToString();
        }

        private void dgv_DSYeuCauCapNhat_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;

            if (dong < 0)
            {
                MessageBox.Show("Không tìm thấy thông tin chi tiết của yêu cầu cập nhật!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            grb_TT_CapNhat.Visible = true;
            grb_TT_SinhVien.Visible = true;

            this.Size = new System.Drawing.Size(1200, 650);

            XuLyTaiKhoanSinhVien TK_SinhVien = new XuLyTaiKhoanSinhVien();
            DataRow TTSV_YeuCauCapNhat = TK_SinhVien.TimSinhVienChiTiet(dgv_DSYeuCauCapNhat.Rows[dong].Cells["MaSV"].Value.ToString());
            DataRow TT_YeuCauCapNhat = ((DataRowView)dgv_DSYeuCauCapNhat.Rows[dong].DataBoundItem).Row;

            this.MaSV = TTSV_YeuCauCapNhat["MaSV"].ToString();
            this.MaYeuCau = TT_YeuCauCapNhat["MaYeuCau"].ToString();
            this.TrangThaiYeuCau = Byte.Parse(TT_YeuCauCapNhat["TrangThai"].ToString());

            // Thông tin sinh viên yêu cầu cập nhật
            lb_HT_MSSV.Text = TTSV_YeuCauCapNhat["MaSV"].ToString();
            lb_HT_HoTen.Text = TTSV_YeuCauCapNhat["HoTen"].ToString();
            lb_HT_Lop.Text = TTSV_YeuCauCapNhat["Lop"].ToString();

            string SQL_TruyVan = $"SELECT " +
                                    $"YC.MaYeuCau AS MaYeuCau, " +
                                    $"YC.MaSV AS MaSV, " +
                                    $"YC.Email_Moi AS Email_Moi, " +
                                    $"YC.SDT_Moi AS SDT_Moi, " +
                                    $"YC.DiaChiThuongTru_Moi AS DiaChiThuongTru_Moi, " +
                                    $"YC.ThoiGianYeuCau AS ThoiGianYeuCau, " +
                                    $"YC.LyDoCapNhat AS LyDoCapNhat, " +
                                    $"YC.TrangThai AS TrangThai " +
                                    $"FROM YeuCauCapNhat AS YC " +
                                    $"JOIN SinhVien AS SV ON YC.MaSV = SV.MaSV " +
                                    $"WHERE MaYeuCau = '{TT_YeuCauCapNhat["MaYeuCau"].ToString()}';";

            DataRow TT_CapNhat = KN.ThaoTac_DocMotDong_DuLieu(SQL_TruyVan);

            byte TrangThaiCapNhat = Convert.ToByte(TT_CapNhat["TrangThai"].ToString());
            string TieuDe = "Thông tin trạng thái:";
            switch (TrangThaiCapNhat)
            {
                case 0:
                    grb_TT_CapNhat.Text = $"{TieuDe} Đợi duyệt";
                    break;
                case 1:
                    grb_TT_CapNhat.Text = $"{TieuDe} Đã duyệt";
                    break;
                case 2:
                    grb_TT_CapNhat.Text = $"{TieuDe}  Không duyệt";
                    break;
            }

            if (TrangThaiCapNhat == 0)
                btn_DuyetYeuCau.Enabled = true;
            else
            {
                btn_DuyetYeuCau.Enabled = false;
                btn_KhongDuyetYeuCau.Enabled = false;
            }    

            lb_HT_SDT_Cu.Text = TTSV_YeuCauCapNhat["SDT"].ToString();
            lb_HT_SDT_Moi.Text = TT_CapNhat["SDT_Moi"].ToString();

            lb_HT_Email_Cu.Text = TTSV_YeuCauCapNhat["Email"].ToString();
            lb_HT_Email_Moi.Text = TT_CapNhat["Email_Moi"].ToString();

            lb_HT_DiaChi_Cu.Text = TTSV_YeuCauCapNhat["DiaChiThuongTru"].ToString();
            lb_HT_DiaChi_Moi.Text = TT_CapNhat["DiaChiThuongTru_Moi"].ToString();

            rtb_HT_LyDoCapNhat.Text = TT_CapNhat["LyDoCapNhat"].ToString();
        }

        private void btn_DuyetYeuCau_Click(object sender, EventArgs e)
        {
            XuLyTaiKhoanSinhVien TK_SinhVien = new XuLyTaiKhoanSinhVien();

            TK_SinhVien.DuyetYeuCau_CapNhat(this.MaYeuCau, this.MaSV, lb_HT_SDT_Moi.Text.ToString(), lb_HT_Email_Moi.Text.ToString(), lb_HT_DiaChi_Moi.Text.ToString());
            HienThiYeuCauCapNhat();
        }

        private void btn_KhongDuyetYeuCau_Click(object sender, EventArgs e)
        {
            if (this.TrangThaiYeuCau == 0)
            {
                string SQL_TruyVan = $"UPDATE YeuCauCapNhat " +
                    $"SET TrangThai = 2 " +
                    $"WHERE MaYeuCau = '{this.MaYeuCau}';";

                KN.ThaoTac_Ghi_DuLieu(SQL_TruyVan);
            }
            else
                MessageBox.Show("Thao tác không hợp lệ!\nVui lòng xem lại trạng thái yêu cầu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            HienThiYeuCauCapNhat();
        }
    }
}
