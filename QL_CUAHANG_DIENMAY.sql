/*
	Thanh vien nhom: Ngo Thi Ngoc Diem, Nguyen Thu Tuyet, Le Thanh Thien
	lop: cd16tt2
	ma so: 16211tt0449
	do an nhom: tao CSDL cho quan ly cua hang dien may
*/
CREATE DATABASE QL_CUAHANG_DIENMAY
GO
USE QL_CUAHANG_DIENMAY
GO

--	Bảng Nhân viên   
CREATE TABLE NHANVIEN
(
	MaNV INT IDENTITY(1, 1) PRIMARY KEY, -- Khóa chính , IDENTITY(1, 1): BAT DAU TU 1 VÀ MỖI LẦN TĂNG LÊN 1
	HoTen NVARCHAR(30) NOT NULL, -- Số kí tự tiếng việt có dầu, tối đa 30 kí tự 
	GioiTinh NVARCHAR(3) CONSTRAINT CK_NHANVIEN1 CHECK (GioiTinh = 'Nam' OR GioiTinh = N'Nữ'), -- Ràng buộc mặc định cho kiểu giới tính
	CMND VARCHAR(13) NOT NULL, 
	DiaChi NVARCHAR(50),
	SoDT VARCHAR(12),
	NgayVL SMALLDATETIME, -- Kiểu ngày giờ, chính xác đến % của phút
	TaiKhoan VARCHAR(20) NOT NULL,
	MatKhau VARCHAR(10) NOT NULL,
	MucLuong MONEY,
	PhuCap MONEY,
	IsDelete Bit default 0, -- 0: chua xoa, 1: da xoa  --> truong hop thong ke lai du lieu da xoa, con ko kinh doanh nua
)
GO

-- Bảng Hóa Đơn:
CREATE TABLE HOADON
(
	SoHD INT IDENTITY(1, 1) PRIMARY KEY, -- Khóa chính, IDENTITY(1, 1): BAT DAU TU 1 VÀ MỖI LẦN TĂNG LÊN 1
	NgayLap SMALLDATETIME NOT NULL, 
	MaNV INT NOT NULL,
	TongTien MONEY, -- Kiểu tiền tệ
	--MaKH VARCHAR(6),
	IsDelete Bit default 0, -- 0: chua xoa, 1: da xoa  --> truong hop thong ke lai du lieu da xoa, ko con kinh doanh nua
)
GO

-- Bảng Loại Sản Phẩm
CREATE TABLE LOAISP
(	
	MaLoaiSP INT IDENTITY(1, 1) PRIMARY KEY, -- Khóa chính, IDENTITY(1, 1): BAT DAU TU 1 VÀ MỖI LẦN TĂNG LÊN 1
	TenLoaiSP NVARCHAR(50) NOT NULL,
	IsDelete Bit default 0, -- 0: chua xoa, 1: da xoa  --> truong hop thong ke lai du lieu da xoa, ko kinh doanh nua
)
GO

-- Bảng Sản Phẩm
CREATE TABLE SANPHAM
(
	MaSP INT IDENTITY(1, 1) PRIMARY KEY, -- Khóa chính, IDENTITY(1, 1): BAT DAU TU 1 VÀ MỖI LẦN TĂNG LÊN 1
	TenSP NVARCHAR(100) NOT NULL,
	GiaBan MONEY NOT NULL, -- Kiểu tiền tệ
	MaLoaiSP INT NOT NULL,
	NuocSX NVARCHAR(50),
	HinhAnh NVARCHAR(200) DEFAULT N'HinhSanPham\no_picture.png',
	IsDelete Bit default 0, -- 0: chua xoa, 1: da xoa  --> truong hop thong ke lai du lieu da xoa, ko kinh doanh nua
)
GO

-- Bảng Chi tiết Hóa đơn:
CREATE TABLE CTHOADON
(
	ID INT IDENTITY(1, 1) PRIMARY KEY,
	SoHD INT NOT NULL, -- IDENTITY(1, 1): BAT DAU TU 1 VÀ MỖI LẦN TĂNG LÊN 1
	MaSP INT NOT NULL,
	GiaBan MONEY NOT NULL,
	SoLuong INT NOT NULL,
	ThanhTien MONEY, -- Kiểu tiền tệ
	
	IsDelete Bit default 0, -- 0: chua xoa, 1: da xoa  --> truong hop thong ke lai du lieu da xoa, ko kinh doanh nua
)
GO

-- Khóa ngoại Mã Nhân viên
ALTER TABLE HOADON
ADD CONSTRAINT FK_MaNV_HOADON
FOREIGN KEY (MaNV) REFERENCES NHANVIEN(MaNV)
GO

-- Khóa ngoại Mã Loại Sản Phẩm
ALTER TABLE SANPHAM
ADD CONSTRAINT FK_MaLoaiSP_SANPHAM
FOREIGN KEY (MaLoaiSP) REFERENCES LOAISP(MaLoaiSP)
GO

-- Khóa ngoại Mã Sản Phẩm
ALTER TABLE CTHOADON
ADD CONSTRAINT FK_MaSP_CTHOADON
FOREIGN KEY (MaSP) REFERENCES SANPHAM(MaSP)
GO

-- Khóa ngoại Số Hóa đơn
ALTER TABLE CTHOADON
ADD CONSTRAINT FK_SoHD_CTHOADON
FOREIGN KEY (SoHD) REFERENCES HOADON(SoHD)
GO

set dateformat dmy

-- Thêm dữ liệu

-- Thêm dữ liệu cho Bảng Nhân viên: 5 NV
INSERT INTO NHANVIEN (HoTen, GioiTinh, CMND, DiaChi, SoDT, NgayVL, TaiKhoan, MatKhau, MucLuong, PhuCap)
VALUES (N'Ngô Thị Ngọc Diễm', N'Nữ', '12345671', N'Quận 1, TP.HCM', '01234567890', '11/5/2017', 'NV01_ngocdiem', '123',2300000, 600000)
--
INSERT INTO NHANVIEN (HoTen, GioiTinh, CMND, DiaChi, SoDT, NgayVL, TaiKhoan, MatKhau, MucLuong, PhuCap)
VALUES (N'Nguyễn Thu Tuyết', N'Nữ', '12345672', N'Quận 2, TP.HCM', '01234567891', '11/5/2017', 'NV02_thutuyet', '123',2300000, 700000)
--
INSERT INTO NHANVIEN (HoTen, GioiTinh, CMND, DiaChi, SoDT, NgayVL, TaiKhoan, MatKhau, MucLuong, PhuCap)
VALUES (N'Lê Thanh Thiện', 'Nam', '1234563', N'Quận 3, TP.HCM', '01234567892', '12/6/2017', 'NV03_thanhthien', '123',2300000, 500000)
--
INSERT INTO NHANVIEN (HoTen, GioiTinh, CMND, DiaChi, SoDT, NgayVL, TaiKhoan, MatKhau, MucLuong, PhuCap)
VALUES (N'Phan Thành Nhân', 'Nam', '12345674', N'Quận 4, TP.HCM', '01234567893', '13/8/2017', 'NV04_thanhnhan', '123',2100000, 500000)
--
INSERT INTO NHANVIEN (HoTen, GioiTinh, CMND, DiaChi, SoDT, NgayVL, TaiKhoan, MatKhau, MucLuong, PhuCap)
VALUES (N'Bùi Mai Ly', N'Nữ', '12345675', N'Quận 5, TP.HCM', '01234567894', '14/9/2017', 'NV05_maily', '123',2200000, 500000)
GO


-- Thêm dữ liệu cho Bảng Loại Sản Phẩm: 4 loai
INSERT INTO LOAISP(TenLoaiSP)
VALUES (N'Điện gia dụng')
--
INSERT INTO LOAISP(TenLoaiSP)
VALUES (N'Thiết bị điện tử')
--
INSERT INTO LOAISP(TenLoaiSP)
VALUES (N'Thiết bị công nghệ')
--
INSERT INTO LOAISP(TenLoaiSP)
VALUES (N'Phụ kiện')
GO

-- Thêm dữ liệu cho Bảng Sản Phẩm: 20 SP
-- Điện GD
INSERT INTO SANPHAM(TenSP, GiaBan, MaLoaiSP, NuocSX)
VALUES (N'Điều hòa Daikio', 5250000, 1, N'Nhật Bản')
--
INSERT INTO SANPHAM(TenSP, GiaBan, MaLoaiSP, NuocSX)
VALUES (N'Quạt treo Midea', 360000, 1, N'Thái Lan')
--
INSERT INTO SANPHAM(TenSP, GiaBan, MaLoaiSP, NuocSX)
VALUES (N'Quạt treo Asia', 430000, 1, N'Nhật Bản')
--
INSERT INTO SANPHAM(TenSP, GiaBan, MaLoaiSP, NuocSX)
VALUES (N'Nồi cơm điện Sharp 1.8 lít', 610000, 1, N'Nhật Bản')
--
INSERT INTO SANPHAM(TenSP, GiaBan, MaLoaiSP, NuocSX)
VALUES (N'Bếp gas Sunhouse', 590000, 1, N'Trung Quốc')
-- TBDT
INSERT INTO SANPHAM(TenSP, GiaBan, MaLoaiSP, NuocSX)
VALUES (N'Loa thanh SamsungHW-J250', 1490000, 2, N'Hàn Quốc')
--
INSERT INTO SANPHAM(TenSP, GiaBan, MaLoaiSP, NuocSX)
VALUES (N'Loa thanh SamsungHW-K350', 3290000, 2, N'Hàn Quốc')
--
INSERT INTO SANPHAM(TenSP, GiaBan, MaLoaiSP, NuocSX)
VALUES (N'Ti vi Samsung SmartTV 32 inch', 6890000, 2, N'Hàn Quốc')
--
INSERT INTO SANPHAM(TenSP, GiaBan, MaLoaiSP, NuocSX)
VALUES (N'Ti vi TCL SmartTV 64 inch', 10490000, 2, N'Hàn Quốc')
--
INSERT INTO SANPHAM(TenSP, GiaBan, MaLoaiSP, NuocSX)
VALUES (N'Máy giặt Candy 8kg', 6990000, 2, N'Nhật Bản')
-- TBCN
INSERT INTO SANPHAM(TenSP, GiaBan, MaLoaiSP, NuocSX)
VALUES (N'Điện thoại IPhone X 256GB', 3479000, 3, N'Mỹ')
--
INSERT INTO SANPHAM(TenSP, GiaBan, MaLoaiSP, NuocSX)
VALUES (N'Điện thoại IPhone 8 Plus 256GB', 28790000, 3, N'Mỹ')
--
INSERT INTO SANPHAM(TenSP, GiaBan, MaLoaiSP, NuocSX)
VALUES (N'Laptop Lenovo Ideapad 320 14ISK i3 6006', 8990000, 3, N'Thái Lan')
--
INSERT INTO SANPHAM(TenSP, GiaBan, MaLoaiSP, NuocSX)
VALUES (N'Laptop Asus X541UA i3 6100U', 9990000, 3, N'Trung Quốc')
--
INSERT INTO SANPHAM(TenSP, GiaBan, MaLoaiSP, NuocSX)
VALUES (N'IPad Pro 10.5 inch Wifi 64GB 2017', 16990000, 3, N'Trung Quốc')
-- Phu Kien
INSERT INTO SANPHAM(TenSP, GiaBan, MaLoaiSP, NuocSX)
VALUES (N'Cục sạc dự phòng 7.500 mAh eSaver', 280000, 4, N'Hàn Quốc')
--
INSERT INTO SANPHAM(TenSP, GiaBan, MaLoaiSP, NuocSX)
VALUES (N'Cục sạc dự phòng 15.000 mAh Xmobile', 418000, 4, N'Trung Quốc')
--
INSERT INTO SANPHAM(TenSP, GiaBan, MaLoaiSP, NuocSX)
VALUES (N'Tai nghe Bluetooth Kanen', 300000, 4, N'Nhật Bản')
--
INSERT INTO SANPHAM(TenSP, GiaBan, MaLoaiSP, NuocSX)
VALUES (N'USB 3.0 Sandisk 16GB', 250000, 4, N'Trung Quốc')
--
INSERT INTO SANPHAM(TenSP, GiaBan, MaLoaiSP, NuocSX)
VALUES (N'Cap eSeaver 1m MicroUSB', 100000, 4, N'Trung Quốc')
GO


--thanh thiện
CREATE PROC SP_LOAD_SANPHAM
AS
BEGIN
	SELECT MaSP, TenSP, GiaBan, MaLoaiSP, NuocSX, HinhAnh, IsDelete FROM SANPHAM
END
GO

CREATE PROC SP_LOAD_LOAISP
AS
BEGIN
	SELECT MaLoaiSP, TenLoaiSP FROM LOAISP WHERE IsDelete = 0
END
GO

CREATE PROC SP_THEM_HOADON
(
	@NgayLap SMALLDATETIME,
	@MaNV INT,
	@TongTien MONEY
)
AS
BEGIN
	INSERT INTO HOADON(NgayLap, MaNV, TongTien) VALUES ( @NgayLap , @MaNV , @TongTien )
END
GO

CREATE PROC SP_GETLAST_HOADON
AS
BEGIN
	SELECT TOP 1 SoHD FROM HOADON
	ORDER BY SoHD DESC
END
GO

CREATE PROC SP_THEM_CTHOADON
(
	@SoHD INT,
	@MaSP INT,
	@GiaBan MONEY,
	@SoLuong INT,
	@ThanhTien MONEY
)
AS
BEGIN
	INSERT INTO CTHOADON( SoHD, MaSP, GiaBan, SoLuong, ThanhTien) VALUES ( @SoHD , @MaSP , @GiaBan , @SoLuong , @ThanhTien )
END
GO

-- thu tuyết
CREATE PROC SP_THEM_NHANVIEN
(   
	@HoTen NVARCHAR(30),
	@GioiTinh NVARCHAR(3),
	@CMND VARCHAR(13), 
	@DiaChi NVARCHAR(50),
	@SoDT VARCHAR(12),
	@NgayVL SMALLDATETIME,
	@TaiKhoan VARCHAR(20),
	@MatKhau VARCHAR(10),
	@MucLuong MONEY,
	@PhuCap MONEY
)
AS
BEGIN
SET DATEFORMAT dmy
	-- CÂU LỆNH THÊM --
	INSERT INTO NHANVIEN (HoTen,GioiTinh, CMND, DiaChi, SoDT, NgayVL, TaiKhoan, MatKhau, MucLuong, PhuCap) 
	VALUES ( @HoTen, @GioiTinh, @CMND , @DiaChi, @SoDT, @NgayVL, @TaiKhoan, @MatKhau, @MucLuong, @PhuCap)
END
-- THỰC THI STORE --
--EXEC SP_THEM_NHANVIEN
GO

	-- XÓA NHÂN VIÊN --

CREATE PROC SP_XOA_NHANVIEN
(
	@MANV INT
)
AS
BEGIN
	-- CÂU LỆNH XÓA --
	UPDATE NHANVIEN
	SET ISDELETE = 1
	WHERE MANV = @MANV
END
-- THỰC THI STORE --
--EXEC SP_XOA_NHANVIEN
GO
--EXEC SP_XOA_NHANVIEN 1

	-- SỬA NHÂN VIÊN --

CREATE PROC SP_SUA_NHANVIEN
(
	@MaNV INT,
	@HoTen NVARCHAR(30),
	@GioiTinh NVARCHAR(3),
	@CMND VARCHAR(13), 
	@DiaChi NVARCHAR(50),
	@SoDT VARCHAR(12),
	@NgayVL SMALLDATETIME,
	@TaiKhoan VARCHAR(20),
	@MatKhau VARCHAR(10),
	@MucLuong MONEY,
	@PhuCap MONEY
)
AS 
BEGIN
	UPDATE NHANVIEN
	SET HoTen = @HoTen,
	GioiTinh = @GioiTinh,
	CMND = @CMND, 
	DiaChi = @DiaChi,
	SoDT = @SoDT,
	NgayVL = @NgayVL,
	TaiKhoan = @TaiKhoan,
	MatKhau = @MatKhau,
	MucLuong = @MucLuong,
	PhuCap = @PhuCap
	WHERE MaNV = @MaNV
END
-- THỰC THI STORE
--EXEC SP_SUA_NHANVIEN
GO
	-- LẤY NHÂN VIÊN --

CREATE PROC SP_LOAD_NHANVIEN
AS 
BEGIN
	SELECT * FROM NHANVIEN
	WHERE IsDelete = 0
END
-- THỰC THI STORE
--EXEC SP_LOAD_NHANVIEN

-------- BẢNG SẢN PHẨM --------
	-- THÊM SẢN PHẨM --
GO 
CREATE PROC SP_THEM_SANPHAM
(   
	@TenSP NVARCHAR(100),
	@GiaBan MONEY,
	@MaLoaiSP INT,
	@NuocSX NVARCHAR(50),
	@HinhAnh NVARCHAR(200)
)
AS
BEGIN
	-- CÂU LỆNH THÊM --
	INSERT INTO SANPHAM ( TenSP, GiaBan, MaLoaiSP, NuocSX, HinhAnh) 
	VALUES ( @TenSP, @GiaBan, @MaLoaiSP, @NuocSX, @HinhAnh)
END
-- THỰC THI STORE --
--EXEC SP_THEM_SANPHAM
GO

	-- XÓA SẢN PHẨM --

CREATE PROC SP_XOA_SANPHAM
(
	@MaSP INT
)
AS
BEGIN
	-- CÂU LỆNH XÓA --
	UPDATE SANPHAM
	SET ISDELETE = 1
	WHERE MaSP = @MaSP
END
-- THỰC THI STORE --

--EXEC SP_XOA_SANPHAM 
GO
	-- SỬA SẢN PHẨM --

CREATE PROC SP_SUA_SANPHAM
(
	@MaSP INT,
	@TenSP NVARCHAR(100),
	@GiaBan MONEY,
	@MaLoaiSP INT,
	@NuocSX NVARCHAR(50),
	@HinhAnh NVARCHAR(200),
	@IsDelete Bit
)
AS 
BEGIN
	UPDATE SANPHAM
	SET TenSP = @TenSP,
	GiaBan = @GiaBan,
	MaLoaiSP = @MaLoaiSP,
	NuocSX = @NuocSX,
	HinhAnh = @HinhAnh,
	IsDelete = @IsDelete
	WHERE MaSP = @MaSP
END
-- THỰC THI STORE
--EXEC SP_SUA_SANPHAM 
GO


	-- LẤY SẢN PHẨM --
-- THỰC THI STORE


--------- LOẠI SẢN PHẨM --------
	-- LẤY LOẠI SẢN PHẨM --
--GO 
--CREATE PROC SP_LOAD_LOAISP
--AS 
--BEGIN
--	SELECT * FROM LOAISP
--	WHERE IsDelete = 0
--END
-- THỰC THI STORE
GO

--ngọc diễm

-- store truy van bao cao doanh thu theo thoi gian
CREATE PROC SP_LOAD_DTTHEOTHOIGIAN
(
	@NgayBatDau SMALLDATETIME,
	@NgayKetThuc SMALLDATETIME
)
AS
BEGIN
	SELECT * 
	FROM HOADON 
	WHERE NgayLap BETWEEN @NgayBatDau AND @NgayKetThuc 
END
-- thuc thi store
--EXEC SP_LOAD_DTTHEOTHOIGIAN 
GO

-- store truy van bao cao doanh thu theo nhan vien
CREATE PROC SP_LOAD_DTTHEONHANVIEN
(
	@MaNV INT
) 
AS
BEGIN
	SELECT *
	FROM HOADON
	WHERE MaNV = @MaNV AND IsDelete = 0
END
-- thuc thi store
--EXEC SP_LOAD_DTTHEONHANVIEN 1
GO

CREATE PROC SP_LOAD_CTHD
(
	@SoHD INT
) 
AS
BEGIN
	SELECT *
	FROM CTHOADON
	WHERE SoHD = @SoHD
END
-- thuc thi store
--EXEC SP_LOAD_CTHD 
GO
