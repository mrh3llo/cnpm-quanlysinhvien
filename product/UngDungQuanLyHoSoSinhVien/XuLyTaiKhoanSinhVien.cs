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

        /* =================================================================
        ======================= HÀM XỬ LÝ HIỂN THỊ =========================
        ================================================================= */

        public void HienThi_DS_SinhVien(DataGridView dgv)
        {
            string SQL_TruyVan = $@"SELECT 
	                                    sv.MaSV,
	                                    sv.Ho + ' ' + sv.Ten AS HoTen,
	                                    CASE WHEN sv.GioiTinh = N'Nam' THEN N'Nam' ELSE N'Nữ' END AS GioiTinh,
	                                    FORMAT(sv.NgaySinh, 'dd/MM/yyyy') AS NgaySinh,
	                                    sv.SDT,
	                                    sv.Email,
	                                    sv.DiaChiThuongTru,
	                                    dt.TenDanToc AS DanToc,
	                                    tg.TenTonGiao AS TonGiao,
	                                    tt_ns.TenTinhThanh AS NoiSinh,
	                                    xp.TenXaPhuong + ', ' + tt_qq.TenTinhThanh AS QueQuan,
	                                    sv.SoCCCD,
	                                    kt.TenKhoa_Truong AS Khoa_Truong,
	                                    n.TenNganh AS Nganh,
	                                    l.TenLop AS Lop,
	                                    sv.NienKhoa,
	                                    sv.TrangThai,
                                        sv.AnhDaiDien,
                                        sv.QueQuan_TinhThanh as QQ_TinhThanh,
                                        sv.QueQuan_XaPhuong as QQ_XaPhuong
                                    FROM SinhVien sv
                                    JOIN DanToc dt ON sv.DanToc = dt.MaDanToc
                                    JOIN TonGiao tg ON sv.TonGiao = tg.MaTonGiao
                                    JOIN TinhThanh tt_ns ON sv.NoiSinh_TinhThanh = tt_ns.MaTinhThanh
                                    JOIN XaPhuong xp ON sv.QueQuan_XaPhuong = xp.MaXaPhuong
                                    JOIN TinhThanh tt_qq ON sv.QueQuan_TinhThanh = tt_qq.MaTinhThanh
                                    JOIN Khoa_Truong kt ON sv.Khoa_Truong = kt.MaKhoa_Truong
                                    JOIN Nganh n ON sv.Nganh = n.MaNganh
                                    JOIN Lop l ON sv.Lop = l.MaLop;";

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
            dgv.Columns[17].Visible = false;
            dgv.Columns[18].Visible = false;
            dgv.Columns[19].Visible = false;
        }

        public void HienThi_DS_SinhVien_TheoLop(DataGridView dgv, string MaLop)
        {
            string SQL_TruyVan = $@"SELECT 
	                                    sv.MaSV,
	                                    sv.Ho + ' ' + sv.Ten AS HoTen,
	                                    CASE WHEN sv.GioiTinh = N'Nam' THEN N'Nam' ELSE N'Nữ' END AS GioiTinh,
	                                    FORMAT(sv.NgaySinh, 'dd/MM/yyyy') AS NgaySinh,
	                                    sv.SDT,
	                                    sv.Email,
	                                    sv.DiaChiThuongTru,
	                                    dt.TenDanToc AS DanToc,
	                                    tg.TenTonGiao AS TonGiao,
	                                    tt_ns.TenTinhThanh AS NoiSinh,
	                                    xp.TenXaPhuong + ', ' + tt_qq.TenTinhThanh AS QueQuan,
	                                    sv.SoCCCD,
	                                    kt.TenKhoa_Truong AS Khoa_Truong,
	                                    n.TenNganh AS Nganh,
	                                    l.TenLop AS Lop,
	                                    sv.NienKhoa,
	                                    sv.TrangThai,
                                        sv.AnhDaiDien,
                                        sv.QueQuan_TinhThanh as QQ_TinhThanh,
                                        sv.QueQuan_XaPhuong as QQ_XaPhuong
                                    FROM SinhVien sv
                                    JOIN DanToc dt ON sv.DanToc = dt.MaDanToc
                                    JOIN TonGiao tg ON sv.TonGiao = tg.MaTonGiao
                                    JOIN TinhThanh tt_ns ON sv.NoiSinh_TinhThanh = tt_ns.MaTinhThanh
                                    JOIN XaPhuong xp ON sv.QueQuan_XaPhuong = xp.MaXaPhuong
                                    JOIN TinhThanh tt_qq ON sv.QueQuan_TinhThanh = tt_qq.MaTinhThanh
                                    JOIN Khoa_Truong kt ON sv.Khoa_Truong = kt.MaKhoa_Truong
                                    JOIN Nganh n ON sv.Nganh = n.MaNganh
                                    JOIN Lop l ON sv.Lop = l.MaLop
                                WHERE l.MaLop = '{MaLop}';";

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
            dgv.Columns[17].Visible = false;
            dgv.Columns[18].Visible = false;
            dgv.Columns[19].Visible = false;
        }

        public void HienThiChiTiet_TT_SinhVien(DataRow TT_SinhVien)
        {
            try
            {
                if (TT_SinhVien == null)
                {
                    MessageBox.Show("Không có dữ liệu sinh viên để hiển thị!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // string QueQuan = $"{TT_SinhVien["QQ_XaPhuong"].ToString()}" + $"{TT_SinhVien["QQ_TinhThanh"].ToString()}";

                frm_ThongTinTaiKhoan frm_TTSV = new frm_ThongTinTaiKhoan();

                // Thông tin cá nhân
                if(TT_SinhVien["AnhDaiDien"] == DBNull.Value || string.IsNullOrEmpty(TT_SinhVien["AnhDaiDien"].ToString()))
                    frm_TTSV.ptb_AnhDaiDien.Image = new Bitmap(Application.StartupPath + @"\assets\img\AnhDaiDien_MacDinh.png");
                else
                    frm_TTSV.ptb_AnhDaiDien.Image = new Bitmap(Application.StartupPath + @$"{TT_SinhVien["AnhDaiDien"].ToString()}");
                
                frm_TTSV.lb_MSSV.Text = TT_SinhVien["MaSV"].ToString();
                frm_TTSV.lb_HoTen.Text = TT_SinhVien["HoTen"].ToString();
                frm_TTSV.lb_GioiTinh.Text = TT_SinhVien["GioiTinh"].ToString();
                frm_TTSV.lb_SDT.Text = TT_SinhVien["SDT"].ToString();
                frm_TTSV.lb_Email.Text = TT_SinhVien["Email"].ToString();
                frm_TTSV.lb_NgaySinh.Text = TT_SinhVien["NgaySinh"].ToString();
                frm_TTSV.lb_NoiSinh.Text = TT_SinhVien["NoiSinh"].ToString();
                frm_TTSV.lb_DanToc.Text = TT_SinhVien["DanToc"].ToString();
                frm_TTSV.lb_TonGiao.Text = TT_SinhVien["TonGiao"].ToString();
                frm_TTSV.lb_QueQuan.Text = TT_SinhVien["QueQuan"].ToString();
                
                // Thông tin học tập
                frm_TTSV.lb_Lop.Text = TT_SinhVien["Lop"].ToString();
                frm_TTSV.lb_Nganh.Text = TT_SinhVien["Nganh"].ToString();
                frm_TTSV.lb_Khoa_Truong.Text = TT_SinhVien["Khoa_Truong"].ToString();
                frm_TTSV.lb_NienKhoa.Text = TT_SinhVien["NienKhoa"].ToString();

                frm_TTSV.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi hiển thị thông tin sinh viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void HienThi_LuaChon(ComboBox comboBox, string SQL_TruyVan, string HienThiThuocTinh, string GiaTriThuocTinh)
        {
            comboBox.DataSource = KetNoi.GhiDuLieuVaoBang(SQL_TruyVan);
            comboBox.DisplayMember = HienThiThuocTinh;
            comboBox.ValueMember = GiaTriThuocTinh;
        }

        /* =================================================================
        ========================= HÀM XỬ LÝ CHUỖI ==========================
        ================================================================= */

        public string ChuanHoaDuongDanAnh(string DuongDanBanDau, string MaSV)
        {
            if (string.IsNullOrWhiteSpace(DuongDanBanDau))
                return null;

            try
            {
                if (!File.Exists(DuongDanBanDau))
                    return null;

                string DuoiTepTin = Path.GetExtension(DuongDanBanDau).ToLower();
                string DuongDanLuuAnh = Path.Combine(Application.StartupPath, "assets", "avt", $"{MaSV}" + $"{DuoiTepTin}");

                File.Copy(DuongDanBanDau, DuongDanLuuAnh, true);

                string DuongDanAnhTrongCSDL = Path.Combine("assets", "avt", $"{MaSV}" + $"{DuoiTepTin}");
                return DuongDanAnhTrongCSDL;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xử lý ảnh: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
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
        public string TaoMaSVNgauNhien()
        {
            Random rand = new Random();
            string namHienTai = DateTime.Now.Year.ToString();

            // Format: YYYY + 3 chữ số (001-999) + 3 chữ số (001-999)
            return namHienTai + rand.Next(1, 1000).ToString("D3") + rand.Next(1, 1000).ToString("D3");
        }

        /* =================================================================
        ================== HÀM XỬ LÝ DỮ LIỆU THUỘC CSDL ====================
        ================================================================= */
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

        public void GuiYeuCauCapNhat_TT_SinhVien(string MaSV, string EmailMoi, string SDT_Moi,
                                        string DiaChiThuongTru_Moi, string LyDoCapNhat)
        {
            try
            {
                // Tạo MaYeuCau ngẫu nhiên (Format: YC + 3 số)
                Random rand = new Random();
                string MaYeuCau = "YC" + rand.Next(1, 1000).ToString("D3");

                // Lấy thời gian hiện tại
                string ThoiGianYeuCau = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                // Xây dựng câu lệnh SQL INSERT
                string SQL_TruyVan = $@"USE QuanLyHoSoSinhVien;" +
                    $@"INSERT INTO YeuCauCapNhat " +
                    $@"VALUES ('{MaYeuCau}', '{MaSV}', " +
                    $@"{(string.IsNullOrEmpty(EmailMoi) ? "NULL" : $"N'{EmailMoi}'")}, " +
                    $@"{(string.IsNullOrEmpty(SDT_Moi) ? "NULL" : $"'{SDT_Moi}'")}, " +
                    $@"{(string.IsNullOrEmpty(DiaChiThuongTru_Moi) ? "NULL" : $"N'{DiaChiThuongTru_Moi}'")}, " +
                    $@"'{ThoiGianYeuCau}', N'{LyDoCapNhat}', 0);";

                // Thực thi câu lệnh thêm yêu cầu cập nhật
                KetNoi.ThaoTac_Ghi_DuLieu(SQL_TruyVan);

                MessageBox.Show($"Gửi yêu cầu cập nhật thành công!\nMã yêu cầu: {MaYeuCau}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi gửi yêu cầu cập nhật: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CapNhat_TT_SinhVien(string MaSV, string HoTen, string Email, string SDT, string GioiTinh,
                                        DateTime NgaySinh, string SoCCCD, string MaDanToc, string MaTonGiao,
                                        string DiaChiThuongTru, string MaTinhThanhNoiSinh, string MaTinhThanhQueQuan,
                                        string MaXaPhuongQueQuan, string MaKhoaTruong, string MaNganh,
                                        string MaLop, string NienKhoa, string AnhDaiDien)
        {
            try
            {
                // Tách Ho và Ten từ HoTen
                string Ho, Ten;
                (Ho, Ten) = TachHoTen(HoTen);

                // Xây dựng câu lệnh SQL UPDATE
                string SQL_TruyVan = $@"USE QuanLyHoSoSinhVien;" +
                    $@"UPDATE SinhVien " +
                    $@"SET Ho = N'{Ho}', Ten = N'{Ten}', Email = '{Email}', SDT = '{SDT}', " +
                    $@"GioiTinh = N'{GioiTinh}', NgaySinh = '{NgaySinh:yyyy-MM-dd}', SoCCCD = '{SoCCCD}', " +
                    $@"DanToc = '{MaDanToc}', TonGiao = '{MaTonGiao}', DiaChiThuongTru = N'{DiaChiThuongTru}', " +
                    $@"NoiSinh_TinhThanh = '{MaTinhThanhNoiSinh}', QueQuan_TinhThanh = '{MaTinhThanhQueQuan}', " +
                    $@"QueQuan_XaPhuong = '{MaXaPhuongQueQuan}', Khoa_Truong = '{MaKhoaTruong}', " +
                    $@"Nganh = '{MaNganh}', Lop = '{MaLop}', NienKhoa = '{NienKhoa}', " +
                    $@"TrangThai = N'0', AnhDaiDien = {(string.IsNullOrEmpty(AnhDaiDien) ? "NULL" : $"'{AnhDaiDien}'")} " +
                    $@"WHERE MaSV = '{MaSV}';";

                // Thực thi câu lệnh cập nhật sinh viên
                KetNoi.ThaoTac_Ghi_DuLieu(SQL_TruyVan);

                MessageBox.Show($"Cập nhật thông tin sinh viên thành công!\nMã sinh viên: {MaSV}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi cập nhật thông tin sinh viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void XoaSinhVien(string MaSV)
        {
            string SQL_TruyVan = $@"DELETE FROM SinhVien WHERE MaSV = '{MaSV}';";

            try
            {
                KetNoi.ThaoTac_Ghi_DuLieu(SQL_TruyVan);
                MessageBox.Show($"Xóa sinh viên thành công!\nMã sinh viên: {MaSV}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa sinh viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DataRow TimSinhVienChiTiet(string MaSV)
        {
            string SQL_TruyVan = $@"SELECT 
	                                    sv.MaSV,
	                                    sv.Ho + ' ' + sv.Ten AS HoTen,
	                                    CASE WHEN sv.GioiTinh = N'Nam' THEN N'Nam' ELSE N'Nữ' END AS GioiTinh,
	                                    FORMAT(sv.NgaySinh, 'dd/MM/yyyy') AS NgaySinh,
	                                    sv.SDT,
	                                    sv.Email,
	                                    sv.DiaChiThuongTru,
	                                    dt.TenDanToc AS DanToc,
	                                    tg.TenTonGiao AS TonGiao,
	                                    tt_ns.TenTinhThanh AS NoiSinh,
	                                    xp.TenXaPhuong + ', ' + tt_qq.TenTinhThanh AS QueQuan,
	                                    sv.SoCCCD,
	                                    kt.TenKhoa_Truong AS Khoa_Truong,
	                                    n.TenNganh AS Nganh,
	                                    l.TenLop AS Lop,
	                                    sv.NienKhoa,
	                                    sv.TrangThai,
                                        sv.AnhDaiDien
                                    FROM SinhVien sv
                                    JOIN DanToc dt ON sv.DanToc = dt.MaDanToc
                                    JOIN TonGiao tg ON sv.TonGiao = tg.MaTonGiao
                                    JOIN TinhThanh tt_ns ON sv.NoiSinh_TinhThanh = tt_ns.MaTinhThanh
                                    JOIN XaPhuong xp ON sv.QueQuan_XaPhuong = xp.MaXaPhuong
                                    JOIN TinhThanh tt_qq ON sv.QueQuan_TinhThanh = tt_qq.MaTinhThanh
                                    JOIN Khoa_Truong kt ON sv.Khoa_Truong = kt.MaKhoa_Truong
                                    JOIN Nganh n ON sv.Nganh = n.MaNganh
                                    JOIN Lop l ON sv.Lop = l.MaLop
                                    WHERE sv.MaSV = '{MaSV}';";

            return KetNoi.ThaoTac_DocMotDong_DuLieu(SQL_TruyVan);
        }

        public void TimMaSV(string MaSV)
        {
            string SQL_TruyVan = $@"SELECT 
	                                    sv.MaSV,
	                                    sv.Ho + ' ' + sv.Ten AS HoTen,
	                                    CASE WHEN sv.GioiTinh = N'Nam' THEN N'Nam' ELSE N'Nữ' END AS GioiTinh,
	                                    FORMAT(sv.NgaySinh, 'dd/MM/yyyy') AS NgaySinh,
	                                    sv.SDT,
	                                    sv.Email,
	                                    sv.DiaChiThuongTru,
	                                    dt.TenDanToc AS DanToc,
	                                    tg.TenTonGiao AS TonGiao,
	                                    tt_ns.TenTinhThanh AS NoiSinh,
	                                    xp.TenXaPhuong + ', ' + tt_qq.TenTinhThanh AS QueQuan,
	                                    sv.SoCCCD,
	                                    kt.TenKhoa_Truong AS Khoa_Truong,
	                                    n.TenNganh AS Nganh,
	                                    l.TenLop AS Lop,
	                                    sv.NienKhoa,
	                                    sv.TrangThai,
                                        sv.AnhDaiDien
                                    FROM SinhVien sv
                                    JOIN DanToc dt ON sv.DanToc = dt.MaDanToc
                                    JOIN TonGiao tg ON sv.TonGiao = tg.MaTonGiao
                                    JOIN TinhThanh tt_ns ON sv.NoiSinh_TinhThanh = tt_ns.MaTinhThanh
                                    JOIN XaPhuong xp ON sv.QueQuan_XaPhuong = xp.MaXaPhuong
                                    JOIN TinhThanh tt_qq ON sv.QueQuan_TinhThanh = tt_qq.MaTinhThanh
                                    JOIN Khoa_Truong kt ON sv.Khoa_Truong = kt.MaKhoa_Truong
                                    JOIN Nganh n ON sv.Nganh = n.MaNganh
                                    JOIN Lop l ON sv.Lop = l.MaLop
                                    WHERE sv.MaSV = '{MaSV}';";

            DataRow KQ_TimKiem = KetNoi.ThaoTac_DocMotDong_DuLieu(SQL_TruyVan);

            if (KQ_TimKiem == null)
                MessageBox.Show($"Không tìm thấy sinh viên với mã: {MaSV}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                HienThiChiTiet_TT_SinhVien(KQ_TimKiem);
        }
    }
}