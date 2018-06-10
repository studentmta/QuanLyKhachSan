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


--THONG KE HOA DON
alter PROC TKHD(@MAHD INT )
AS
BEGIN
   SELECT MaHoaDon, NgayThanhToan,SoTienDatTruoc,DonVi,h.MaNV FROM HOADON h, NHANVIEN n
   WHERE H.MaHoaDon=N.MaNV
END

EXEC TKHD @MAHD='001'

--thong ke khach hang
create proc TKKH(@MaKH int)
as
begin
	select* from KHACHHANG
end

exec TKKH @MaKH='01'

--thong ke loai phong
create proc TKLP(@Maloaiphong int)
as
begin
	Select* from LOAIPHONG
end

exec TKLP @Maloaiphong='01'

--thong ke chuc vu
create proc TKCV(@MaCV int)
as
begin
	select* from CHUCVU
end
exec TKCV @MaCV='01'

--thong ke nhan vien
create proc TKNV(@MaNV int)
as
begin
	select Manv, TenNV,n.MaChucVu,GioiTinh, NgaySinh,DiaChi,SDT
	from NHANVIEN n, CHUCVU c
	where n.MaChucVu=c.MaChucVu
end
exec TKnv @MaNV='01'

--thong ke phieu dang ky
create proc TKPDK(@MaPDK int)
as
begin
	select MaPhieuDangKy,p.MaKH,p.MaNV,NgayLap,NgayDi,p.MaPhong,TraTruoc,p.DonVi
	from PHIEUDANGKY p,KHACHHANG k,NHANVIEN n,PHONG g
	where p.MaKH=k.MaKH and p.MaNV=n.MaNV and p.MaPhong=g.MaPhong
end

exec TKPDK @MaPDK='01'

