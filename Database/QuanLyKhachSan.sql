create database QuanLyKhachSan
go
use QuanLyKhachSan
go

create table KhachHang(
	MaKH int primary key identity(1,1),
	TenKH nvarchar(50) null,
	CMND varchar(12) null,
	QuocTich nvarchar(50) null,
	GioiTinh nvarchar(10) null,
	NgaySinh date null,
	SoDienThoa char(10)
)
create table LoaiPhong(
	MaLoaiPhong int primary key identity(1,1),
	TenLoai nvarchar(50)
	
)
create table PhongThue(
	MaPhong int primary key identity(1,1),
	TenPhong nvarchar(10),
	GiaThue money,
	MaLoaiPhong int references LoaiPhong(MaLoaiPhong) on delete cascade,
	TrangThai bit
)
create table VatTu(
	MaVatTu int primary key identity(1,1),
	TenVT nvarchar(100),
	GiaTien money,
	SoLuongHienCo int
)
create table ChiTietDoDungPhong(
	MaPhong int references PhongThue(MaPhong),
	MaVatTu int references VatTu(MaVatTu),
	TinhTrang bit,
	GhiChu ntext
	primary key (MaPhong,MaVatTu)
)
create table HoaDon(
	MaHD int primary key identity(1,1),
	MaPhong int references PhongThue(MaPhong),
	MaKH int references KhachHang(MaKH),
	NgayBatDau datetime,
	NgayTraPhong datetime,
	ThanhTien money
)
create table DichVu(
	MaDV int primary key identity(1,1),
	TenDV nvarchar(50),
	GiaDV money
)
create table ChiTietHoaDon(
	MaHD int references HoaDon(MaHD),
	MaDV int references DichVu(MaDV),
	SoLuong money
	primary key (MaHD,MaDV)
)
create table UserTaiKhoan(
	MaTK int primary key identity(1,1),
	TaiKhoan varchar(32),
	MatKhau varchar(16)
)