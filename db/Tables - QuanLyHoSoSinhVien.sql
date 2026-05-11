CREATE DATABASE QuanLyHoSoSinhVien;
GO

USE QuanLyHoSoSinhVien;
GO

CREATE TABLE DanToc
(
	MaDanToc VARCHAR (5) PRIMARY KEY,
	TenDanToc NVARCHAR (30) NOT NULL,
);
GO

CREATE TABLE TonGiao
( 
	MaTonGiao VARCHAR (5) PRIMARY KEY,
	TenTonGiao NVARCHAR (30) NOT NULL,
);
GO

CREATE TABLE TinhThanh
(
	MaTinhThanh VARCHAR (5) PRIMARY KEY,
	TenTinhThanh NVARCHAR (30) NOT NULL,
);
GO

CREATE TABLE XaPhuong
(
	MaXaPhuong VARCHAR (5) PRIMARY KEY,
	TenXaPhuong NVARCHAR (30) NOT NULL,
	MaTinhThanh VARCHAR (5) NOT NULL,
	CONSTRAINT fk_TrucThuoc_TinhThanh FOREIGN KEY (MaTinhThanh) REFERENCES TinhThanh(MaTinhThanh)
);
GO

CREATE TABLE Khoa_Truong
(
	MaKhoa_Truong VARCHAR (5) PRIMARY KEY,
	TenKhoa_Truong NVARCHAR (30) NOT NULL,
);
GO

CREATE TABLE Nganh
(
	MaNganh VARCHAR (5) PRIMARY KEY,
	TenNganh NVARCHAR (30) NOT NULL,
	MaKhoa_Truong VARCHAR (5) NOT NULL,
	CONSTRAINT fk_QuanLy_Nganh FOREIGN KEY (MaKhoa_Truong) REFERENCES Khoa_Truong(MaKhoa_Truong)
);
GO

CREATE TABLE Lop
(
	MaLop VARCHAR (5) PRIMARY KEY,
	TenLop NVARCHAR(30) NOT NULL,
	MaKhoa_Truong VARCHAR (5) NOT NULL,
	CONSTRAINT fk_QuanLy_Lop FOREIGN KEY (MaKhoa_Truong) REFERENCES Khoa_Truong(MaKhoa_Truong)
);
GO

CREATE TABLE TaiKhoanNguoiDung
(
	TenTaiKhoan VARCHAR(20) PRIMARY KEY NOT NULL,
	MatKhau TEXT NOT NULL,
	VaiTro TINYINT NOT NULL,
	-- Có 4 vai trò:
	-- 1: Admin
	-- 2: Cán bộ phòng CTSV
	-- 3: Giảng viên
	-- 4: Sinh viên
);
GO

CREATE TABLE SinhVien
(
	-- Tên tài khoản sinh viên là MSSV, mật khẩu mặc định là số điện thoại
	MaSV VARCHAR (10) PRIMARY KEY,
	
	-- VS viết thuật toán xử lý họ tên với, chữ cuối trong họ tên là tên của người dùng (sinh viên)
	Ho NVARCHAR (50) NOT NULL,
	Ten NVARCHAR (20) NOT NULL,
	Email TEXT NOT NULL,
	SDT CHAR (10) NOT NULL,
	GioiTinh NVARCHAR (3) NOT NULL,
	NgaySinh DATE NOT NULL,
	SoCCCD CHAR (12) NOT NULL,
	DanToc VARCHAR (5) NOT NULL, -- fk
	TonGiao VARCHAR (5) NOT NULL, -- fk
	DiaChiThuongTru NTEXT,
	NoiSinh_TinhThanh VARCHAR (5) NOT NULL, -- fk
	QueQuan_TinhThanh VARCHAR (5) NOT NULL, -- fk
	QueQuan_XaPhuong VARCHAR (5) NOT NULL, -- fk
	Khoa_Truong VARCHAR (5) NOT NULL, -- fk
	Nganh VARCHAR (5) NOT NULL, -- fk
	Lop VARCHAR (5) NOT NULL, -- fk
	NienKhoa CHAR (10) NOT NULL,
	TrangThai NVARCHAR(20) NOT NULL,
	AnhDaiDien TEXT,
	CONSTRAINT fk_SV_La_DanToc FOREIGN KEY (DanToc) REFERENCES DanToc(MaDanToc),
	CONSTRAINT fk_SV_Theo_TonGiao FOREIGN KEY (TonGiao) REFERENCES TonGiao(MaTonGiao),
	CONSTRAINT fk_SV_NoiSinhTinhThanh FOREIGN KEY (NoiSinh_TinhThanh) REFERENCES TinhThanh(MaTinhThanh),
	CONSTRAINT fk_SV_QueQuanTinhThanh FOREIGN KEY (QueQuan_TinhThanh) REFERENCES TinhThanh(MaTinhThanh),
	CONSTRAINT fk_SV_QueQuanXaPhuong FOREIGN KEY (QueQuan_XaPhuong) REFERENCES XaPhuong(MaXaPhuong),
	CONSTRAINT fk_SV_Thuoc_KhoaTruong FOREIGN KEY (Khoa_Truong) REFERENCES Khoa_Truong(MaKhoa_Truong),
	CONSTRAINT fk_SV_TheoHoc_Nganh FOREIGN KEY (Nganh) REFERENCES Nganh(MaNganh),
	CONSTRAINT fk_SV_Lop FOREIGN KEY (Lop) REFERENCES Lop(MaLop),
);
GO

CREATE TABLE YeuCauCapNhat
(
	MaYeuCau VARCHAR(5) PRIMARY KEY NOT NULL,
	MaSV VARCHAR(10),
	Email_Moi TEXT,
	SDT_Moi CHAR(10),
	DiaChiThuongTru_Moi NTEXT,
	ThoiGianYeuCau DATETIME NOT NULL,
	LyDoCapNhat NTEXT NOT NULL,
	TrangThai TINYINT NOT NULL,
	-- 0: Không đồng ý,
	-- 1: Đồng ý,
	-- 2: Bị hủy yêu cầu cập nhật
	CONSTRAINT fk_GuiYeuCau FOREIGN KEY (MaSV) REFERENCES SinhVien(MaSV),
);
GO