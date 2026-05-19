use QuanLyHoSoSinhVien;
GO

-- Truy vấn hiển thị danh sách thông tin sinh viên trong thực thể sinh viên
SELECT 
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
	sv.SoCCCD AS So_CCCD,
	kt.TenKhoa_Truong AS Khoa_Truong,
	n.TenNganh AS Nganh,
	l.TenLop AS Lop,
	sv.NienKhoa,
	sv.TrangThai
	sv.AnhDaiDien
FROM SinhVien sv
JOIN DanToc dt ON sv.DanToc = dt.MaDanToc
JOIN TonGiao tg ON sv.TonGiao = tg.MaTonGiao
JOIN TinhThanh tt_ns ON sv.NoiSinh_TinhThanh = tt_ns.MaTinhThanh
JOIN XaPhuong xp ON sv.QueQuan_XaPhuong = xp.MaXaPhuong
JOIN TinhThanh tt_qq ON sv.QueQuan_TinhThanh = tt_qq.MaTinhThanh
JOIN Khoa_Truong kt ON sv.Khoa_Truong = kt.MaKhoa_Truong
JOIN Nganh n ON sv.Nganh = n.MaNganh
JOIN Lop l ON sv.Lop = l.MaLop;