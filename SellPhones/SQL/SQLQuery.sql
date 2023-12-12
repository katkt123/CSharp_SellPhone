

create table NhaCungCap
(
	MaNCC				NCHAR(7)					NOT NULL,
	TenNCC				NVARCHAR(40)				NOT NULL,
	DiaChiNCC			NVARCHAR(40),
	SDTNCC				NVARCHAR(10)
)
create table Quyen
(
        MaTK				NCHAR(7)					NOT NULL,
        PhanQuyen                       NVARCHAR(20)                                    NOT NULL
)
create table SanPham
(
	MaSP				NCHAR(5)					NOT NULL,
	TenSP				NVARCHAR(20)                                    NOT NULL,
	Hang				NVARCHAR(20)				NOT NULL,
	DungLuong			NVARCHAR(20)			NOT NULL,
	DonGia				INT						NOT NULL,
	GiaBan				INT						,
	SoLuong 			INT						NOT NULL,
    HinhAnh                 NCHAR(100)                                      NOT NULL,
	TrangThaiTonTai			INT					NOT NULL    
)
-- create table DoanhThu
-- (
-- 	MaDoanhThu		NCHAR(5)						NOT NULL,
--         TongDoanhThu                    int                   
-- )

create table TaiKhoan
(
	MaTK				NCHAR(7)					NOT NULL,
	TenDangNhap				NCHAR(50)					,
	MatKhau				NVARCHAR(50)				,
	Email				NVarChar(50) 				,
	TrangThai					INT							NOT NULL
)

create table NhanVien
(
	MaNV		NCHAR(5)					NOT NULL,
	TenNV			NVARCHAR(50)				NOT NULL,
    GioiTinh        NVARCHAR(10)                                    NOT NULL,
    DiaChiNV			NVARCHAR(100),
	SDTNV				NVARCHAR(20),
	MaTK				NCHAR(7)					NOT NULL
	
)

create table KhachHang
(
	MaKH			NCHAR(5)					NOT NULL,
	TenKH		NVARCHAR(40)				NOT NULL,
	DiaChi				NVARCHAR(100),
	SDT					NVARCHAR(10),
	MaTK				NCHAR(7)					NOT NULL
)

create table ChuongTrinhKhuyenMai
(
	MaCTKM                          NCHAR(5)					NOT NULL,
        TenCTKM                         NVARCHAR(100)                                   NOT NULL,
	MucGiamGia			int,
	LoaiSanPhamDuocApDung		NVARCHAR(100)                                 NOT NULL,
        ThoiGianBatDau			NVARCHAR(100)                                    NOT NULL,
	ThoiGianKetThuc			NVARCHAR(100)                         NOT NULL,
        ThoiGianTaoKM                   NVARCHAR(100)                          NOT NULL,
        MaSP				NCHAR(5)					                               
        
	
)

create table HoaDon
(
	MaHoaDon			NCHAR(5)					NOT NULL,
	MaKH				NCHAR(5)					NOT NULL,
	MaNV				NCHAR(5)					NOT NULL,
	NgayLap                         datetime,
    NgayXuat                        datetime,
	TongGiaGoc			int                                             NOT NULL,
        TongGiaSauGiam                  int,
        -- MaDoanhThu		NCHAR(5)						NOT NULL
        
)

create table CTHoaDon
(
	MaHoaDon			NCHAR(5)					NOT NULL,
	MaSP				NCHAR(5)					NOT NULL,
	TenSP				NVARCHAR(40)				NOT NULL,
	SoLuong				int,
	GiaTien				int
)

create table Kho
(
	MaKho			NCHAR(5)						NOT NULL,
	TenKho			NVARCHAR(40)					NOT NULL,
	DiaChiKho		NVARCHAR(10),
	SDTKho			NVARCHAR(10)
)
create table PhieuNhapKho
(
	MaPhieuNhap		NCHAR(5)						NOT NULL,
	MaKho			NCHAR(5)						NOT NULL,
	MaNV			NCHAR(5)						NOT NULL,
	NgayNhap		datetime                                               NOT NULL,
	TongTien		int                                                     NOT NULL
)

create table CTPhieuNhapKho
(
	MaPhieuNhap		NCHAR(5)						NOT NULL,
	MaNCC			NCHAR(7)						NOT NULL,
	SLNhap			int,
	Tamtinh			int,
	DonGia                          int                                             NOT NULL,
	TenSP			NVarChar(50)
)

create table SanPhamNCC
(
    MaNCC				NCHAR(7)					NOT NULL,
	MaSP				NCHAR(5)					NOT NULL,
	TenSP				NVarChar(50)				NOT NULL,
	DonGia				int				 						
)



--Thiết lập ràng buộc--
--Khóa chính--
alter table HoaDon
	add constraint PK_HoaDon primary key (MaHoaDon)

alter table NhaCungCap
	add constraint PK_NhaCungCap primary key (MaNCC)

alter table SanPham
	add constraint PK_SanPham primary key (MaSP)

alter table NhanVien
	add constraint PK_NhanVien primary key (MaNV)

alter table KhachHang
	add constraint PK_KhachHang primary key (MaKH)

alter table Kho
	add constraint PK_Kho primary key (MaKho)

alter table PhieuNhapKho
	add constraint PK_PhieuNhapKho primary key(MaPhieuNhap)

alter table ChuongTrinhKhuyenMai
	add constraint PK_ChuongTrinhKhuyenMai primary key(MaCTKM)

alter table TaiKhoan
	add constraint PK_TaiKhoan primary key(MaTK)

-- alter table DoanhThu
-- 	add constraint PK_DoanhThu primary key(MaDoanhThu)

--Khóa ngoại--
alter table HoaDon
	add constraint FK_MaKhachHang_HoaDon foreign key (MaKH) references KhachHang(MaKH)
alter table HoaDon
        add constraint FK_MaNhanVien_HoaDon foreign key (MaNV) references NhanVien(MaNV)
-- alter table HoaDon 
--         add constraint FK_MaDoanhThu_HoaDon foreign key (MaDoanhThu) references DoanhThu(MaDoanhThu)

alter table SanPhamNCC
        add constraint FK_MaNCC_SanPhamNCC  foreign key (MaNCC)    references NhaCungCap(MaNCC)
alter table SanPhamNCC
        add constraint FK_MaSP_SanPhamNCC   foreign key (MaSP)     references SanPham(MaSP)

alter table CTHoaDon 
	add constraint FK_MaHoaDon_CTHoaDon foreign key (MaHoaDon) references HoaDon(MaHoaDon)
alter table CTHoaDon 
	add constraint FK_MaSP_CTHoaDon foreign key (MaSP) references SanPham(MaSP)

alter table KhachHang
	add constraint FK_MaTK_KhachHang foreign key (MaTK) references TaiKhoan(MaTK)

alter table NhanVien
	add constraint FK_MaTK_NhanVien foreign key (MaTK) references TaiKhoan(MaTK)

alter table Quyen   
        add constraint FK_MaTK_Quyen foreign key (MaTK) references TaiKhoan(MaTK)

alter table PhieuNhapKho
	add constraint FK_MaKho_PhieuNhapKho foreign key (MaKho) references Kho(MaKho)
alter table PhieuNhapKho
	add constraint FK_MaNV_PhieuNhapKho foreign key (MaNV) references NhanVien(MaNV)

alter table CTPhieuNhapKho
	add constraint FK_MaPhieuNhap_CTPhieuNhapKho foreign key (MaPhieuNhap) references PhieuNhapKho(MaPhieuNhap)
alter table CTPhieuNhapKho
	add constraint FK_MaNCC_CTPhieuNhapKho foreign key (MaNCC) references NhaCungCap(MaNCC)


alter table ChuongTrinhKhuyenMai
	add constraint FK_MaSP_ChuongTrinhKhuyenMai foreign key (MaSP) references SanPham(MaSP)
 
-- Thêm dữ liệu
-- NhaCungCap
INSERT INTO NhaCungCap VALUES
('NCC001', 'Công ty A', 'Địa chỉ A', '0123456789'),
('NCC002', 'Công ty B', 'Địa chỉ B', '0987654321')
-- Add 8 more rows...
-- TaiKhoan
INSERT INTO TaiKhoan VALUES

('AD', 'admin', 'admin', 'lamkiet0902741206@gmail.com', 0),
('TK001', 'user1', 'userpass1', 'user1@gmail.com', 0),
('TK002', 'user2', 'userpass2', 'user2@gmail.com', 0),
('TK003', 'user3', 'userpass3', 'user3@gmail.com', 0),
('TK004', 'user4', 'userpass4', 'user4@gmail.com', 0)
-- Quyen
INSERT INTO Quyen VALUES
('AD', 'Quản Trị Viên'),
('TK001', 'Nhân Viên'),
('TK002', 'Nhân Viên'),
('TK003', 'Khách Hàng'),
('TK004', 'Khách Hàng')
-- Add 8 more rows...

-- SanPham
INSERT INTO SanPham VALUES
('SP001', 'Laptop', 'Dell', '8GB', 1200,1320, 50, 'C:\SGU\Nam3 HK1\CNPM\DoAn_Final\CNPM\src\HinhDT\Iphone_11.jpg',1),
('SP002', 'Smartphone', 'Samsung', '128GB', 800,880, 30, 'C:\SGU\Nam3 HK1\CNPM\DoAn_Final\CNPM\src\HinhDT\Iphone_11.jpg',1)
-- Add 8 more rows...


-- Add 8 more rows...

-- NhanVien
INSERT INTO NhanVien VALUES
('NV001', 'Nguyen Van A', 'Nam', 'Địa chỉ A', '0123456789', 'TK001'),
('NV002', 'Tran Thi B', 'Nữ', 'Địa chỉ B', '0987654321', 'TK002')
-- Add 8 more rows...

-- KhachHang
INSERT INTO KhachHang VALUES
('KH001', 'Le Van C', 'Địa chỉ C', '0123456789', 'TK003'),
('KH002', 'Pham Thi D', 'Địa chỉ D', '0987654321', 'TK004')
-- Add 8 more rows...






-- Kho
INSERT INTO Kho VALUES
('K001', 'Kho 1', 'HCM', '0123456789')
-- Add 8 more rows...



-- Add 8 more rows...


