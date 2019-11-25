create database thinking
go
use thinking
go
create table KhachHang ( MaKhachHang varchar(10) not null primary key, TenKhachHang nvarchar(50), 
						 NgaySinh date, GioiTinh nvarchar(5), CMND int , DiaChi nvarchar(100), SoDienThoai int
					 )

go
create table HopDong ( MaHopDong varchar(10) not null primary key, MaKhachHang varchar(10), DonGiaDien int,
					 DonGiaNuoc int, GiaTriHD int, DatTruoc int, ConLai int, NgayKy date, NgayNhanPhong date, 
					 foreign key (MaKhachHang) references KhachHang(MaKhachHang)
					 )
go
create table Phong ( MaPhong varchar(10) not null primary key, MaHopdong varchar(10), TinhTrang nvarchar(10),
					 SoChuDienDau int, SoChuDIenCuoi int, SoChuNuocDau int, SoChuNuocCuoi int, 
					 foreign key (MaHopDong) references HopDong(MaHopDong)
					 )
go
create table ChiPhi (MaChiPhi varchar(10) primary key not null, MaPhong varchar(10), TenCP nvarchar(100), ThoiGian date , SoTien int,
					foreign key (MaPhong) references Phong (MaPhong)
					)
go
create table Hoadon ( MaHoaDon varchar(10) not null primary key, MaKhachHang varchar(10), MaPhong varchar(10), SoChuDien int,
					TienDien int, SoChuNuoc int, TienNuoc int, TienPhong int, TongTien int, NgayLapHD date,
					foreign key (MaKhachHang) references KhachHang(MaKhachHang),
					foreign key (MaPhong) references Phong(MaPhong)
					)
go
create table TaiKhoan (TenTaiKhoan varchar(20) not null primary key, password varchar(20) not null, LoaiTK int)
go
insert into TaiKhoan values ('admin','12345678',1),
							('thaiht','12345678',0),
							('tuyenpt','12345678',0),
							('thintp','12345678',0),
							('ngavv','12345678',0),
							('ngantb','12345678',0)

go
insert into ChiPhi values ('CP001','P1011',N'Bóng đèn','11/17/2019',100000)
go
insert into KhachHang values ('KH001',N'Hồ Thanh Thái','10/20/1997','Nam',201725217, N'Hòa Liên, Hòa Vang, Đà Nẵng', 0935305471)
--
go
create proc pThemKhachHang @Makh varchar(5), @Tenkh nvarchar(50), @Ngaysinh date, @GioiTinh varchar(10), @Cmnd int, @Diachi nvarchar(100), @Sdt int
as
begin
	insert into KhachHang values (@Makh, @Tenkh, @Ngaysinh, @GioiTinh,@Cmnd,@Diachi,@Sdt) 
end
insert into KhachHang values ('KH002',N'Phạm Thị Tuyến','10/10/1998','Nu',2010825218,N'Duy Xuyên, Quảng nam',0764836184)
go
insert into HopDong values ('HDOG001','KH001',3000,3000,2000000,0,2000000,'9/14/2019', '9/14/2019')
insert into HopDong values ('HDOG002','KH002',3000,3000,2000000,0,2000000,'9/14/2019', '9/14/2019')
go

insert into Phong values ('P101','HDOG001',N'Đã Thuê',0,30,0,15)
insert into Phong values ('P1011','HDOG002',N'Đã Thuê',0,30,0,15)
update Phong 
set TinhTrang = N'Đã thuê' where MaPhong = 'P101'
--
update Phong 
set TinhTrang = N'Trống' where MaPhong = 'P1011'
-- insert phòng
declare @i int = 1
while @i <= 10
begin
	insert into Phong (MaPhong, TinhTrang) values ('P10'+ cast (@i as nvarchar (100)),N'Trống')
	set @i = @i + 1
end
go
--
create proc pLogin @username varchar(20), @password varchar(20)
as
begin
	select * from TaiKhoan where TenTaiKhoan = @username and password = @password
end
go
--
create proc pGetTableList 
as
begin
	select * from Phong
end
exec pGetTableList
go
--
alter proc UpdateAccount @username varchar(50), @password varchar(20), @newpassword varchar(20)
as
begin
	declare @isrightpass int = 0
	select @isrightpass = count (*) from TaiKhoan where TenTaiKhoan = @username and password = @password
	if (@isrightpass = 1)
	begin
		 update TaiKhoan set password = @newpassword where TenTaiKhoan = @username
	end
end
go
-- thêm chi phí
create proc pInsertChiPhi @MaCP varchar(10), @MaPhong varchar(10), @TenCp nvarchar(50), @ThoiGian date, @SoTien int
as
begin
	insert into ChiPhi values (@MaCP, @MaPhong, @TenCp, @ThoiGian, @SoTien)
end
go
alter proc pGetCustomer @khachhang varchar(20)
as
begin
	select * from KhachHang where MaKhachHang = @khachhang
end
/*exec pGetCustomer @khachhang = 'KH001'*/
go
create proc pAddAccount @username varchar(20), @password varchar(20)
as
begin
	insert into TaiKhoan values (@username, @password)
end
go
alter proc pTimKiemKH @Ten nvarchar(50) , @SDT int 
as
begin
	select * from KhachHang where   TenKhachHang = @Ten  or SoDienThoai = @SDT
end 
declare @return nvarchar(50)
exec pTimKiemKH N'Hồ Thanh Thái', @return
print @return
--
go
--
create proc updateDT
as
begin
select MaHoaDon, NgayLapHD , TongTien from Hoadon
end
--
go
alter proc hienthiphong
as
begin
select * from Phong join HopDong on Phong.MaHopdong = HopDong.MaHopDong
					join KhachHang on HopDong.MaKhachHang = KhachHang.MaKhachHang
end
-- tìm kiếm
go
alter proc pTimKiem @TenKhachHang nvarchar(50)
as
begin
	select * from KhachHang where TenKhachHang like '%'+@TenKhachhang+'%'
end

