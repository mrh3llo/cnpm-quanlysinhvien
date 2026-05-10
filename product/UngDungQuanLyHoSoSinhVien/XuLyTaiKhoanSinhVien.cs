using System;
using System.Collections.Generic;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace UngDungQuanLyHoSoSinhVien
{
    internal class XuLyTaiKhoanSinhVien
    {
        KetNoiCSDL KetNoi = new KetNoiCSDL();
        DataTable BangSinhVien = new DataTable();

        public void HienThi_DS_SinhVien(DataGridView dgv)
        {
            string SQL_TruyVan = $@"USE QuanLyHoSoSinhVien;" +
                "SELECT " +
                    "SV.MaSV, " +
                    "CONCAT(SV.Ho, ' ', SV.Ten) AS HoTen, " +
                    "CASE WHEN SV.GioiTinh = N'Nam' THEN N'Nam' ELSE N'Nữ' " +
                    "END AS GioiTinh, " +
                    "FORMAT(SV.NgaySinh, 'dd/MM/yyyy') AS NgaySinh, " +
                    "SV.SDT, " +
                    "SV.Email, " +
                    "SV.DiaChiThuongTru, " +
                    "DT.TenDanToc AS DanToc, " +
                    "TG.TenTonGiao AS TonGiao, " +
                    "TT_NS.TenTinhThanh AS NoiSinh, " +
                    "CONCAT(XP.TenXaPhuong, ', tỉnh ', TT_QQ.TenTinhThanh) AS QueQuan, " +
                    "SV.SoCCCD AS So_CCCD, " +
                    "KTr.TenKhoa_Truong AS Khoa_Truong, " +
                    "NG.TenNganh AS Nganh, " +
                    "L.TenLop AS Lop, " +
                    "SV.NienKhoa, " +
                    "SV.TrangThai " +
                "FROM SinhVien SV " +
                "JOIN DanToc DT ON SV.DanToc = DT.MaDanToc " +
                "JOIN TonGiao TG ON SV.TonGiao = TG.MaTonGiao " +
                "JOIN TinhThanh TT_NS ON SV.NoiSinh_TinhThanh = TT_NS.MaTinhThanh " +
                "JOIN XaPhuong XP ON SV.QueQuan_XaPhuong = XP.MaXaPhuong " +
                "JOIN TinhThanh TT_QQ ON SV.QueQuan_TinhThanh = TT_QQ.MaTinhThanh " +
                "JOIN Khoa_Truong KTr ON SV.Khoa_Truong = KTr.MaKhoa_Truong " +
                "JOIN Nganh NG ON SV.Nganh = NG.MaNganh " +
                "JOIN Lop L ON SV.Lop = L.MaLop;";

            BangSinhVien = KetNoi.GhiDuLieuVaoBang(SQL_TruyVan);
            dgv.DataSource = BangSinhVien;

            // Đặt tên cột cho DataGridView
            dgv.Columns[0].HeaderText = "Mã sinh viên";
            dgv.Columns[1].HeaderText = "Họ tên";
            dgv.Columns[2].HeaderText = "Giới tính";
            dgv.Columns[3].HeaderText = "Ngày sinh";
            dgv.Columns[4].HeaderText = "Số điện thoại";
            dgv.Columns[5].HeaderText = "Email";
            dgv.Columns[6].HeaderText = "Địa chỉ thường trú";
            dgv.Columns[7].HeaderText = "Dân tộc";
            dgv.Columns[8].HeaderText = "Tôn giáo";
            dgv.Columns[9].HeaderText = "Nơi sinh";
            dgv.Columns[10].HeaderText = "Quê quán";
            dgv.Columns[11].HeaderText = "Số CCCD";
            dgv.Columns[12].HeaderText = "Khoa/ Trường";
            dgv.Columns[13].HeaderText = "Ngành";
            dgv.Columns[14].HeaderText = "Lớp";
            dgv.Columns[15].HeaderText = "Niên khóa";
            dgv.Columns[16].HeaderText = "Trạng thái";
        }

        // Hàm tách Ho và Ten từ HoTen (từ cuối cùng là Ten, phần còn lại là Ho)
        private (string Ho, string Ten) TachHoTen(string HoTen)
        {
            if (string.IsNullOrWhiteSpace(HoTen))
                return ("", "");

            string[] parts = HoTen.Trim().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            
            if (parts.Length == 1)
            {
                return ("", parts[0]);
            }
            
            string Ten = parts[parts.Length - 1];
            string Ho = string.Join(" ", parts, 0, parts.Length - 1);
            
            return (Ho, Ten);
        }

        // Hàm tạo MaSV ngẫu nhiên (Format: YYYY + 3 số + 3 số)
        private string TaoMaSVNgauNhien()
        {
            Random rand = new Random();
            string namHienTai = DateTime.Now.Year.ToString();
            
            // Format: YYYY + 3 chữ số (001-999) + 3 chữ số (001-999)
            return namHienTai + rand.Next(1, 1000).ToString("D3") + rand.Next(1, 1000).ToString("D3");
        }

        public void ThemSinhVien(string HoTen, string Email, string SDT, string GioiTinh, 
                                 DateTime NgaySinh, string SoCCCD, string MaDanToc, string MaTonGiao,
                                 string DiaChiThuongTru, string MaTinhThanhNoiSinh, string MaTinhThanhQueQuan,
                                 string MaXaPhuongQueQuan, string MaKhoaTruong, string MaNganh, 
                                 string MaLop, string NienKhoa, string TrangThai, string AnhDaiDien)
        {
            try
            {
                // Tách Ho và Ten từ HoTen
                string Ho, Ten;
                (Ho, Ten) = TachHoTen(HoTen);

                // Tạo MaSV ngẫu nhiên
                string MaSV = TaoMaSVNgauNhien();

                // Xây dựng câu lệnh SQL INSERT
                string SQL_TruyVan = $@"USE QuanLyHoSoSinhVien;" +
                    $@"INSERT INTO SinhVien " +
                    $@"VALUES ('{MaSV}', N'{Ho}', N'{Ten}', '{Email}', '{SDT}', N'{GioiTinh}', '{NgaySinh:yyyy-MM-dd}', " +
                    $@"'{SoCCCD}', '{MaDanToc}', '{MaTonGiao}', N'{DiaChiThuongTru}', '{MaTinhThanhNoiSinh}', " +
                    $@"'{MaTinhThanhQueQuan}', '{MaXaPhuongQueQuan}', '{MaKhoaTruong}', '{MaNganh}', '{MaLop}', " +
                    $@"'{NienKhoa}', N'{TrangThai}', {(string.IsNullOrEmpty(AnhDaiDien) ? "NULL" : $"'{AnhDaiDien}'")});";

                // Thực thi câu lệnh thêm sinh viên
                KetNoi.ThaoTac_Ghi_DuLieu(SQL_TruyVan);

                // Thêm tài khoản cho sinh viên (TenTaiKhoan = MaSV, MatKhau = SDT, VaiTro = 4)
                string SQL_TaiKhoan = $@"USE QuanLyHoSoSinhVien;" +
                $@"INSERT INTO TaiKhoanNguoiDung " +
                $@"VALUES ('{MaSV}', '{SDT}', 4);";

                KetNoi.ThaoTac_Ghi_DuLieu(SQL_TaiKhoan);

                MessageBox.Show($"Thêm sinh viên thành công!\nMã sinh viên: {MaSV}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm sinh viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void TimMaSV(string MaSV)
        {
            string SQL_TruyVan = $@"USE QuanLyHoSoSinhVien;" +
                "SELECT " +
                    "SV.MaSV, " +
                    "CONCAT(SV.Ho, ' ', SV.Ten) AS HoTen, " +
                    "CASE WHEN SV.GioiTinh = N'Nam' THEN N'Nam' ELSE N'Nữ' " +
                    "END AS GioiTinh, " +
                    "FORMAT(SV.NgaySinh, 'dd/MM/yyyy') AS NgaySinh, " +
                    "SV.SDT, " +
                    "SV.Email, " +
                    "SV.DiaChiThuongTru, " +
                    "DT.TenDanToc AS DanToc, " +
                    "TG.TenTonGiao AS TonGiao, " +
                    "TT_NS.TenTinhThanh AS NoiSinh, " +
                    "CONCAT(XP.TenXaPhuong, N', tỉnh ', TT_QQ.TenTinhThanh) AS QueQuan, " +
                    "SV.SoCCCD AS So_CCCD, " +
                    "KTr.TenKhoa_Truong AS Khoa_Truong, " +
                    "NG.TenNganh AS Nganh, " +
                    "L.TenLop AS Lop, " +
                    "SV.NienKhoa, " +
                    "SV.TrangThai, " +
                    "SV.AnhDaiDien " +
                "FROM SinhVien SV " +
                "JOIN DanToc DT ON SV.DanToc = DT.MaDanToc " +
                "JOIN TonGiao TG ON SV.TonGiao = TG.MaTonGiao " +
                "JOIN TinhThanh TT_NS ON SV.NoiSinh_TinhThanh = TT_NS.MaTinhThanh " +
                "JOIN XaPhuong XP ON SV.QueQuan_XaPhuong = XP.MaXaPhuong " +
                "JOIN TinhThanh TT_QQ ON SV.QueQuan_TinhThanh = TT_QQ.MaTinhThanh " +
                "JOIN Khoa_Truong KTr ON SV.Khoa_Truong = KTr.MaKhoa_Truong " +
                "JOIN Nganh NG ON SV.Nganh = NG.MaNganh " +
                "JOIN Lop L ON SV.Lop = L.MaLop " +
                $"WHERE SV.MaSV = '{MaSV}';";

            DataRow KQ_TimKiem = KetNoi.ThaoTac_DocMotDong_DuLieu(SQL_TruyVan);

            if(KQ_TimKiem == null)
                MessageBox.Show($"Không tìm thấy sinh viên với mã: {MaSV}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                frm_ThongTinTaiKhoan frm_TTSV = new frm_ThongTinTaiKhoan();

                // Thông tin cá nhân
                frm_TTSV.ptb_AnhDaiDien.ImageLocation = KQ_TimKiem["AnhDaiDien"] != DBNull.Value ? KQ_TimKiem["AnhDaiDien"].ToString() : null;
                frm_TTSV.lb_MSSV.Text = KQ_TimKiem["MaSV"].ToString();
                frm_TTSV.lb_HoTen.Text = KQ_TimKiem["HoTen"].ToString();
                frm_TTSV.lb_GioiTinh.Text = KQ_TimKiem["GioiTinh"].ToString();
                frm_TTSV.lb_SDT.Text = KQ_TimKiem["SDT"].ToString();
                frm_TTSV.lb_Email.Text = KQ_TimKiem["Email"].ToString();
                frm_TTSV.lb_NgaySinh.Text = KQ_TimKiem["NgaySinh"].ToString();
                frm_TTSV.lb_NoiSinh.Text = KQ_TimKiem["NoiSinh"].ToString();
                frm_TTSV.lb_DanToc.Text = KQ_TimKiem["DanToc"].ToString();
                frm_TTSV.lb_TonGiao.Text = KQ_TimKiem["TonGiao"].ToString();
                frm_TTSV.lb_QueQuan.Text = KQ_TimKiem["QueQuan"].ToString();
                // Thông tin học tập
                frm_TTSV.lb_Lop.Text = KQ_TimKiem["Lop"].ToString();
                frm_TTSV.lb_Nganh.Text = KQ_TimKiem["Nganh"].ToString();
                frm_TTSV.lb_Khoa_Truong.Text = KQ_TimKiem["Khoa_Truong"].ToString();
                frm_TTSV.lb_NienKhoa.Text = KQ_TimKiem["NienKhoa"].ToString();

                frm_TTSV.ShowDialog();
            }
        }
    }
}
