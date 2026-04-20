create database Quan_Ly_Ho_So_Sinh_Vien;
GO

use Quan_Ly_Ho_So_Sinh_Vien;

create table DanToc
(
	MaDanToc char (5) primary key,
	TenDanToc nvarchar (30) not null,
);

create table TonGiao
( 
	MaTonGiao char (5) primary key,
	TenTonGiao nvarchar (30) not null,
);

create table TinhThanh
(
	MaTinhThanh char (5) primary key,
	TenTinhThanh nvarchar (30) not null,
);

create table XaPhuong
(
	MaXaPhuong char (5) primary key,
	TenXaPhuong nvarchar (30) not null,
	MaTinhThanh char (5) not null,
	constraint fk_MaTinh1 foreign key (MaTinhThanh) references TinhThanh(MaTinhThanh)
);

create table Khoa_Truong
(
	MaKhoa_Truong char (5) primary key,
	TenKhoa_Truong nvarchar (30) not null,
);

create table Nganh
(
	MaNganh char (5) primary key,
	TenNganh nvarchar (30) not null,
	MaKhoa_Truong char (5) not null,
	constraint fk_MaKhoa_Truong1 foreign key (MaKhoa_Truong) references Khoa_Truong(MaKhoa_Truong)
);

create table Lop
(
	MaLop char (5) primary key,
	TenLop nvarchar(30) not null,
	MaKhoa_Truong char (5) not null,
	constraint fk_MaKhoa_Truong2 foreign key (MaKhoa_Truong) references Khoa_Truong(MaKhoa_Truong)
);

create table MonHoc
(
	MaMonHoc char (5) primary key,
	TenMonHoc char (5) not null,
	TienQuyet smallint,
);

create table KetQuaHocTap
(
	MaKQ char (5) primary key,
	KhoaHoc date not null,
	MaMonHoc char (5) not null,
	DiemQT decimal (4,2),
	DiemKT decimal (4,2),
	Dau_Rot bit -- Kiểu boolean trả về True/False
	constraint fk_MaMonHoc1 foreign key (MaMonHoc) references MonHoc(MaMonHoc)
);

create table SinhVien
(
	-- Tên tài khoản sinh viên là MSSV, mật khẩu mặc định là số điện thoại
	MaSV char (10) primary key,
	Ho nvarchar (20) not null,
	TenLot nvarchar (40) ,
	Ten nvarchar (20) not null,
	MatKhauTK text not null,
	Email text not null,
	SDT char (10) not null,
	GioiTinh nvarchar (3) not null,
	NgaySinh date not null,
	SoCCCD char (12) not null,
	DanToc char (5) not null,
	TonGiao char (5) not null,
	DiaChiThuongTru text,
	NoiSinh char (5) not null,
	QueQuan_TinhThanh char (5) not null,
	QueQuan_XaPhuong char (5) not null,
	Khoa int,
	Khoa_Truong char (5) not null,
	Nganh char (5) not null,
	Lop char (5) not null,
	NienKhoa char (10) not null,
	TrangThai nvarchar(20) not null,
	KetQuaHocTap char (5) not null,
	constraint fk_SV_DanToc foreign key (DanToc) references DanToc(MaDanToc),
	constraint fk_SV_TonGiao foreign key (TonGiao) references TonGiao(MaTonGiao),
	constraint fk_SV_NoiSinh foreign key (NoiSinh) references TinhThanh(MaTinhThanh),
	constraint fk_SV_QueQuanTinhThanh foreign key (QueQuan_TinhThanh) references TinhThanh(MaTinhThanh),
	constraint fk_SV_QueQuanXaPhuong foreign key (QueQuan_XaPhuong) references XaPhuong(MaXaPhuong),
	constraint fk_SV_KhoaTruong foreign key (Khoa_Truong) references Khoa_Truong(MaKhoa_Truong),
	constraint fk_SV_Nganh foreign key (Nganh) references Nganh(MaNganh),
	constraint fk_SV_Lop foreign key (Lop) references Lop(MaLop),
	constraint fk_SV_KetQuaHocTap foreign key (KetQuaHocTap) references KetQuaHocTap(MaKQ)
);