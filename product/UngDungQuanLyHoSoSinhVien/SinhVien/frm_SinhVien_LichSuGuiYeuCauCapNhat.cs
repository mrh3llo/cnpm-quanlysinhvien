using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UngDungQuanLyHoSoSinhVien.SinhVien
{
    public partial class frm_SinhVien_LichSuGuiYeuCauCapNhat : Form
    {
        KetNoiCSDL KN = new KetNoiCSDL();

        private string MaSV;

        public frm_SinhVien_LichSuGuiYeuCauCapNhat(string MaSV)
        {
            InitializeComponent();
            this.MaSV = MaSV;

            if (this.MaSV == null)
            {
                MessageBox.Show("Không tồn tại tài khoản. Vui lòng kiểm tra lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

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
                $"WHERE SV.MaSV = '{this.MaSV}' " +
                $"ORDER BY TrangThai ASC;";

            DataTable DS_YeuCauCapNhat = new DataTable();
            DS_YeuCauCapNhat = KN.GhiDuLieuVaoBang(SQL_TruyVan);
            dgv_LichSuYeuCauCapNhat.DataSource = DS_YeuCauCapNhat;

            dgv_LichSuYeuCauCapNhat.Columns[0].HeaderText = "Mã yêu cầu";
            dgv_LichSuYeuCauCapNhat.Columns[1].HeaderText = "Mã sinh viên";
            dgv_LichSuYeuCauCapNhat.Columns[2].HeaderText = "Email mới";
            dgv_LichSuYeuCauCapNhat.Columns[3].HeaderText = "SĐT mới";
            dgv_LichSuYeuCauCapNhat.Columns[4].HeaderText = "Địa chỉ thường trú mới";
            dgv_LichSuYeuCauCapNhat.Columns[5].HeaderText = "Thời gian yêu cầu";
            dgv_LichSuYeuCauCapNhat.Columns[6].HeaderText = "Lý do cập nhật";
            dgv_LichSuYeuCauCapNhat.Columns[7].HeaderText = "Trạng thái";

            int Dem_Duyet = 0, Dem_KhongDuyet = 0;

            foreach (DataGridViewRow Hang in dgv_LichSuYeuCauCapNhat.Rows)
            {
                if (Hang.IsNewRow) continue;

                var cell = Hang.Cells["TrangThai"].Value;
                if (cell == null) continue;

                string TrangThai = cell.ToString().Trim();
                if (TrangThai == "1") Dem_Duyet++;
                else if (TrangThai == "2") Dem_KhongDuyet++;
            }

            lb_Tong_YC.Text = $"Tổng số yêu cầu: {dgv_LichSuYeuCauCapNhat.RowCount}";
            lb_Tong_YCDuyet.Text = $"Tổng số yêu cầu đã duyệt: {Dem_Duyet}";
            lb_Tong_YCKhongDuyet.Text = $"Tổng số yêu cầu không được duyệt: {Dem_KhongDuyet}";
        }
    }
}
