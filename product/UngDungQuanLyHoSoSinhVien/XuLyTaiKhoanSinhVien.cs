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
            string SQL_Query = "USE QuanLyHoSoSinhVien; SELECT \r\n\tsv.MaSV,\r\n\tsv.Ho + ' ' + sv.Ten AS HoTen,\r\n\tCASE WHEN sv.GioiTinh = N'Nam' THEN N'Nam' ELSE N'Nữ' END AS GioiTinh,\r\n\tFORMAT(sv.NgaySinh, 'dd/MM/yyyy') AS NgaySinh,\r\n\tsv.SDT,\r\n\tsv.Email,\r\n\tsv.DiaChiThuongTru,\r\n\tdt.TenDanToc AS DanToc,\r\n\ttg.TenTonGiao AS TonGiao,\r\n\ttt_ns.TenTinhThanh AS NoiSinh,\r\n\txp.TenXaPhuong + N', tỉnh ' + tt_qq.TenTinhThanh AS QueQuan,\r\n\tsv.SoCCCD AS So_CCCD,\r\n\tkt.TenKhoa_Truong AS Khoa_Truong,\r\n\tn.TenNganh AS Nganh,\r\n\tl.TenLop AS Lop,\r\n\tsv.NienKhoa,\r\n\tsv.TrangThai\r\nFROM SinhVien sv\r\nJOIN DanToc dt ON sv.DanToc = dt.MaDanToc\r\nJOIN TonGiao tg ON sv.TonGiao = tg.MaTonGiao\r\nJOIN TinhThanh tt_ns ON sv.NoiSinh_TinhThanh = tt_ns.MaTinhThanh\r\nJOIN XaPhuong xp ON sv.QueQuan_XaPhuong = xp.MaXaPhuong\r\nJOIN TinhThanh tt_qq ON sv.QueQuan_TinhThanh = tt_qq.MaTinhThanh\r\nJOIN Khoa_Truong kt ON sv.Khoa_Truong = kt.MaKhoa_Truong\r\nJOIN Nganh n ON sv.Nganh = n.MaNganh\r\nJOIN Lop l ON sv.Lop = l.MaLop;";
            BangSinhVien = KetNoi.GhiDuLieuVaoBang(SQL_Query);
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
                string SQL_Query = $@"USE QuanLyHoSoSinhVien;";
                SQL_Query += $@"INSERT INTO SinhVien ";
                SQL_Query += $@"VALUES ('{MaSV}', N'{Ho}', N'{Ten}', '{Email}', '{SDT}', N'{GioiTinh}', '{NgaySinh:yyyy-MM-dd}', ";
                SQL_Query += $@"'{SoCCCD}', '{MaDanToc}', '{MaTonGiao}', N'{DiaChiThuongTru}', '{MaTinhThanhNoiSinh}', ";
                SQL_Query += $@"'{MaTinhThanhQueQuan}', '{MaXaPhuongQueQuan}', '{MaKhoaTruong}', '{MaNganh}', '{MaLop}', ";
                SQL_Query += $@"'{NienKhoa}', N'{TrangThai}', {(string.IsNullOrEmpty(AnhDaiDien) ? "NULL" : $"'{AnhDaiDien}'")});";

                // Thực thi câu lệnh thêm sinh viên
                KetNoi.ThaoTac_Ghi_DuLieu(SQL_Query);

                // Thêm tài khoản cho sinh viên (TenTaiKhoan = MaSV, MatKhau = SDT, VaiTro = 4)
                string SQL_TaiKhoan = $@"USE QuanLyHoSoSinhVien;";
                SQL_TaiKhoan += $@"INSERT INTO TaiKhoanNguoiDung ";
                SQL_TaiKhoan += $@"VALUES ('{MaSV}', '{SDT}', 4);";

                KetNoi.ThaoTac_Ghi_DuLieu(SQL_TaiKhoan);

                MessageBox.Show($"Thêm sinh viên thành công!\nMã sinh viên: {MaSV}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm sinh viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
