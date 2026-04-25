create database Quan_Ly_Ho_So_Sinh_Vien;
go

use Quan_Ly_Ho_So_Sinh_Vien;
go

create table DanToc
(
	MaDanToc varchar (5) primary key,
	TenDanToc nvarchar (30) not null,
);
go

create table TonGiao
( 
	MaTonGiao varchar (5) primary key,
	TenTonGiao nvarchar (30) not null,
);
go

create table TinhThanh
(
	MaTinhThanh varchar (5) primary key,
	TenTinhThanh nvarchar (30) not null,
);
go

create table XaPhuong
(
	MaXaPhuong varchar (5) primary key,
	TenXaPhuong nvarchar (30) not null,
	MaTinhThanh char (5) not null,
	constraint fk_TrucThuoc_TinhThanh foreign key (MaTinhThanh) references TinhThanh(MaTinhThanh)
);
go

create table Khoa_Truong
(
	MaKhoa_Truong varchar (5) primary key,
	TenKhoa_Truong nvarchar (30) not null,
);
go

create table Nganh
(
	MaNganh varchar (5) primary key,
	TenNganh nvarchar (30) not null,
	MaKhoa_Truong char (5) not null,
	constraint fk_QuanLy_Nganh foreign key (MaKhoa_Truong) references Khoa_Truong(MaKhoa_Truong)
);
go

create table Lop
(
	MaLop varchar (5) primary key,
	TenLop nvarchar(30) not null,
	MaKhoa_Truong char (5) not null,
	constraint fk_QuanLy_Lop foreign key (MaKhoa_Truong) references Khoa_Truong(MaKhoa_Truong)
);
go

create table TaiKhoanNguoiDung
(
	TenTaiKhoan varchar(20) primary key not null,
	MatKhau text not null,
	VaiTro tinyint not null,
	-- Có 4 vai trò:
	-- 1: Admin
	-- 2: Cán bộ phòng CTSV
	-- 3: Giảng viên
	-- 4: Sinh viên
);
go

create table YeuCauCapNhat
(
	MaYeuCau char(5) primary key not null,
	MaSV char(10),
	Email_Moi text,
	SDT_Moi char(10),
	DiaChiThuongTru_Moi text,
	ThoiGianYeuCau datetime not null,
	LyDoCapNhat text not null,
	TrangThai tinyint not null,
	-- 0: Không đồng ý,
	-- 1: Đồng ý,
	-- 2: Bị hủy yêu cầu cập nhật
	constraint fk_GuiYeuCau foreign key (MaSV) references SinhVien(MaSV),
);
go

create table SinhVien
(
	-- Tên tài khoản sinh viên là MSSV, mật khẩu mặc định là số điện thoại
	MaSV char (10) primary key,
	Ho nvarchar (20) not null,
	TenLot nvarchar (40) ,
	Ten nvarchar (20) not null,
	Email text not null,
	SDT char (10) not null,
	GioiTinh nvarchar (3) not null,
	NgaySinh date not null,
	SoCCCD char (12) not null,
	DanToc char (5) not null, -- fk
	TonGiao char (5) not null, -- fk
	DiaChiThuongTru text,
	NoiSinh_TinhThanh char (5) not null, -- fk
	QueQuan_TinhThanh char (5) not null, -- fk
	QueQuan_XaPhuong char (5) not null, -- fk
	Khoa_Truong char (5) not null, -- fk
	Nganh char (5) not null, -- fk
	Lop char (5) not null, -- fk
	NienKhoa char (10) not null,
	TrangThai nvarchar(20) not null,
	constraint fk_SV_La_DanToc foreign key (DanToc) references DanToc(MaDanToc),
	constraint fk_SV_Theo_TonGiao foreign key (TonGiao) references TonGiao(MaTonGiao),
	constraint fk_SV_NoiSinhTinhThanh foreign key (NoiSinh_TinhThanh) references TinhThanh(MaTinhThanh),
	constraint fk_SV_QueQuanTinhThanh foreign key (QueQuan_TinhThanh) references TinhThanh(MaTinhThanh),
	constraint fk_SV_QueQuanXaPhuong foreign key (QueQuan_XaPhuong) references XaPhuong(MaXaPhuong),
	constraint fk_SV_Thuoc_KhoaTruong foreign key (Khoa_Truong) references Khoa_Truong(MaKhoa_Truong),
	constraint fk_SV_TheoHoc_Nganh foreign key (Nganh) references Nganh(MaNganh),
	constraint fk_SV_Lop foreign key (Lop) references Lop(MaLop),
);