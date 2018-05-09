create database QLKhachSan
go
use QLKhachSan
go
create table KHACHHANG
(
	MaKH int primary key,
	TenKH nvarchar(50),
	CMND int,
	DiaChi nvarchar(50),
	GioiTinh bit,
	SDT int,
	QuocTich nvarchar(20),
)
create table NHANVIEN
(
	MaNV int primary key,
	TenNV nvarchar(50),
	MaChucVu int references CHUCVU(MaChucVu),
	GioiTinh bit,
	NgaySinh date,
	DiaChi nvarchar(50),
	SDT int,
)
alter table NHANVIEN
ALTER COLUMN GioiTinh text
create table PHONG
(
	MaPhong int primary key,
	TenPhong nvarchar(50),
	TinhTrang nchar(10),
	MaLoaiPhong int references LOAIPHONG(MaLoaiPhong),
	GiaPhong int,
	DonVi varchar(10),
)
create table LOAIPHONG 
(
	MaLoaiPhong int primary key,
	TenLoaiPhong nvarchar(50),
	TrangBi nvarchar(100),
)
create table CHUCVU
(
	MaChucVu int primary key,
	TenChucVu nvarchar(50),
)
create table PHIEUDANGKY
(
	MaPhieuDangKy int primary key,
	MaKH int references KHACHHANG(MaKH),
	MaNV int references NHANVIEN(MaNV),
	NgayLap date,
	NgayDi date,
	MaPhong int references PHONG(MaPhong),
	TraTruoc int,
	DonVi varchar(10), 
)
create table PHIEUDICHVU
(
	MaPhieuDichVu int primary key,
	MaPhieuDangKy int references PHIEUDANGKY(MaPhieuDangKy),
	TenDichVu nvarchar(50),
	GiaDichVu int,
)
create table HOADON
(
	MaHoaDon int primary key,
	NgayThanhToan date,
	SoTienDatTruoc int,
	DonVi varchar(10),
	MaNV int references NHANVIEN(MaNV),
)
go
