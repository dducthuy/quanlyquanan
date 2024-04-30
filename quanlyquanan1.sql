USE [master]
GO
/****** Object:  Database [qlqa]    Script Date: 30/04/2024 11:37:46 CH ******/
CREATE DATABASE [qlqa]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'qlqa', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\qlqa.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'qlqa_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\qlqa_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [qlqa] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [qlqa].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [qlqa] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [qlqa] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [qlqa] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [qlqa] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [qlqa] SET ARITHABORT OFF 
GO
ALTER DATABASE [qlqa] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [qlqa] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [qlqa] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [qlqa] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [qlqa] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [qlqa] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [qlqa] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [qlqa] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [qlqa] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [qlqa] SET  ENABLE_BROKER 
GO
ALTER DATABASE [qlqa] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [qlqa] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [qlqa] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [qlqa] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [qlqa] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [qlqa] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [qlqa] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [qlqa] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [qlqa] SET  MULTI_USER 
GO
ALTER DATABASE [qlqa] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [qlqa] SET DB_CHAINING OFF 
GO
ALTER DATABASE [qlqa] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [qlqa] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [qlqa] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [qlqa] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [qlqa] SET QUERY_STORE = ON
GO
ALTER DATABASE [qlqa] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [qlqa]
GO
/****** Object:  Table [dbo].[BanAn]    Script Date: 30/04/2024 11:37:46 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BanAn](
	[MaBan] [int] IDENTITY(1,1) NOT NULL,
	[TrangThai] [nvarchar](10) NULL,
	[TenBan] [varchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaBan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietHoaDon]    Script Date: 30/04/2024 11:37:46 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHoaDon](
	[MaChiTietHD] [int] IDENTITY(1,1) NOT NULL,
	[MaHD] [int] NULL,
	[MaMon] [varchar](20) NULL,
	[SoLuong] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaChiTietHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DanhMucMon]    Script Date: 30/04/2024 11:37:46 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DanhMucMon](
	[MaDM] [varchar](20) NOT NULL,
	[TenDM] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaDM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 30/04/2024 11:37:46 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHD] [int] IDENTITY(1,1) NOT NULL,
	[NgayTao] [date] NOT NULL,
	[NgayThanhToan] [date] NULL,
	[MaBan] [int] NULL,
	[TinhTrang] [varchar](30) NULL,
	[MaNV] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 30/04/2024 11:37:46 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [nvarchar](255) NOT NULL,
	[HoTen] [nvarchar](50) NULL,
	[SDT] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MonAn]    Script Date: 30/04/2024 11:37:46 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MonAn](
	[MaMon] [varchar](20) NOT NULL,
	[TenMon] [nvarchar](30) NULL,
	[Gia] [float] NULL,
	[MaDM] [varchar](20) NULL,
	[Cell] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaMon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 30/04/2024 11:37:46 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [varchar](10) NOT NULL,
	[HoTen] [nvarchar](50) NULL,
	[SDT] [varchar](10) NULL,
	[NgaySinh] [date] NULL,
	[MaTK] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Quyen]    Script Date: 30/04/2024 11:37:46 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Quyen](
	[MaQ] [varchar](20) NOT NULL,
	[TenQ] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaQ] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 30/04/2024 11:37:46 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[MaTK] [varchar](50) NOT NULL,
	[TK] [nvarchar](50) NULL,
	[mk] [nvarchar](50) NULL,
	[MaQ] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaTK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[BanAn] ON 

INSERT [dbo].[BanAn] ([MaBan], [TrangThai], [TenBan]) VALUES (22, N'', N'B1')
INSERT [dbo].[BanAn] ([MaBan], [TrangThai], [TenBan]) VALUES (23, N'', N'B2')
INSERT [dbo].[BanAn] ([MaBan], [TrangThai], [TenBan]) VALUES (24, N'', N'B3')
INSERT [dbo].[BanAn] ([MaBan], [TrangThai], [TenBan]) VALUES (25, N'', N'B4')
INSERT [dbo].[BanAn] ([MaBan], [TrangThai], [TenBan]) VALUES (26, N'', N'B5')
INSERT [dbo].[BanAn] ([MaBan], [TrangThai], [TenBan]) VALUES (27, N'', N'B6')
INSERT [dbo].[BanAn] ([MaBan], [TrangThai], [TenBan]) VALUES (28, N'', N'B7')
INSERT [dbo].[BanAn] ([MaBan], [TrangThai], [TenBan]) VALUES (29, N'', N'B8')
INSERT [dbo].[BanAn] ([MaBan], [TrangThai], [TenBan]) VALUES (30, N'', N'B9')
INSERT [dbo].[BanAn] ([MaBan], [TrangThai], [TenBan]) VALUES (31, N'', N'B10')
INSERT [dbo].[BanAn] ([MaBan], [TrangThai], [TenBan]) VALUES (32, N'Trống', N'B11')
INSERT [dbo].[BanAn] ([MaBan], [TrangThai], [TenBan]) VALUES (33, N'Trống', N'B12')
INSERT [dbo].[BanAn] ([MaBan], [TrangThai], [TenBan]) VALUES (34, N'Trống', N'B13')
INSERT [dbo].[BanAn] ([MaBan], [TrangThai], [TenBan]) VALUES (35, N'Trống', N'B14')
INSERT [dbo].[BanAn] ([MaBan], [TrangThai], [TenBan]) VALUES (36, N'Trống', N'B15')
INSERT [dbo].[BanAn] ([MaBan], [TrangThai], [TenBan]) VALUES (39, N'Trống', N'B16')
INSERT [dbo].[BanAn] ([MaBan], [TrangThai], [TenBan]) VALUES (40, N'Trống', N'B17')
INSERT [dbo].[BanAn] ([MaBan], [TrangThai], [TenBan]) VALUES (41, N'Trống', N'B18')
INSERT [dbo].[BanAn] ([MaBan], [TrangThai], [TenBan]) VALUES (42, N'Trống', N'B19')
INSERT [dbo].[BanAn] ([MaBan], [TrangThai], [TenBan]) VALUES (43, N'Trống', N'B20')
INSERT [dbo].[BanAn] ([MaBan], [TrangThai], [TenBan]) VALUES (44, N'Trống', N'B21')
INSERT [dbo].[BanAn] ([MaBan], [TrangThai], [TenBan]) VALUES (45, N'Trống', N'B22')
INSERT [dbo].[BanAn] ([MaBan], [TrangThai], [TenBan]) VALUES (46, N'Trống', N'B23')
INSERT [dbo].[BanAn] ([MaBan], [TrangThai], [TenBan]) VALUES (47, N'Trống', N'B24')
SET IDENTITY_INSERT [dbo].[BanAn] OFF
GO
SET IDENTITY_INSERT [dbo].[ChiTietHoaDon] ON 

INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHD], [MaHD], [MaMon], [SoLuong]) VALUES (3, 2, N'DU001', 2)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHD], [MaHD], [MaMon], [SoLuong]) VALUES (4, 2, N'DU002', 2)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHD], [MaHD], [MaMon], [SoLuong]) VALUES (5, 2, N'DU005', 2)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHD], [MaHD], [MaMon], [SoLuong]) VALUES (6, 2, N'DU006', 10)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHD], [MaHD], [MaMon], [SoLuong]) VALUES (10, 3, N'DU006', 6)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHD], [MaHD], [MaMon], [SoLuong]) VALUES (11, 3, N'DU001', 8)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHD], [MaHD], [MaMon], [SoLuong]) VALUES (12, 3, N'MA004', 2)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHD], [MaHD], [MaMon], [SoLuong]) VALUES (13, 3, N'DU004', 2)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHD], [MaHD], [MaMon], [SoLuong]) VALUES (14, 3, N'DU005', 4)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHD], [MaHD], [MaMon], [SoLuong]) VALUES (15, 1, N'DU006', 1)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHD], [MaHD], [MaMon], [SoLuong]) VALUES (16, 1, N'MA001', 4)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHD], [MaHD], [MaMon], [SoLuong]) VALUES (18, 12, N'DU006', 2)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHD], [MaHD], [MaMon], [SoLuong]) VALUES (19, 13, N'DU006', 2)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHD], [MaHD], [MaMon], [SoLuong]) VALUES (20, 1, N'MA002', 3)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHD], [MaHD], [MaMon], [SoLuong]) VALUES (21, 14, N'DU001', 2)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHD], [MaHD], [MaMon], [SoLuong]) VALUES (22, 14, N'MA005', 2)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHD], [MaHD], [MaMon], [SoLuong]) VALUES (23, 15, N'MA005', 3)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHD], [MaHD], [MaMon], [SoLuong]) VALUES (24, 16, N'DU001', 3)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHD], [MaHD], [MaMon], [SoLuong]) VALUES (25, 17, N'MA005', 2)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHD], [MaHD], [MaMon], [SoLuong]) VALUES (26, 17, N'DU006', 2)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHD], [MaHD], [MaMon], [SoLuong]) VALUES (27, 18, N'DU004', 2)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHD], [MaHD], [MaMon], [SoLuong]) VALUES (29, 1, N'DU002', 9)
SET IDENTITY_INSERT [dbo].[ChiTietHoaDon] OFF
GO
INSERT [dbo].[DanhMucMon] ([MaDM], [TenDM]) VALUES (N'DM001', N'Đồ Uống ')
INSERT [dbo].[DanhMucMon] ([MaDM], [TenDM]) VALUES (N'DM002', N'Đồ Mặn ')
INSERT [dbo].[DanhMucMon] ([MaDM], [TenDM]) VALUES (N'DM003', N'Đồ Nhậu ')
GO
SET IDENTITY_INSERT [dbo].[HoaDon] ON 

INSERT [dbo].[HoaDon] ([MaHD], [NgayTao], [NgayThanhToan], [MaBan], [TinhTrang], [MaNV]) VALUES (1, CAST(N'2024-04-28' AS Date), NULL, 22, N'1', N'NV001')
INSERT [dbo].[HoaDon] ([MaHD], [NgayTao], [NgayThanhToan], [MaBan], [TinhTrang], [MaNV]) VALUES (2, CAST(N'2024-04-29' AS Date), NULL, 23, N'1', N'NV001')
INSERT [dbo].[HoaDon] ([MaHD], [NgayTao], [NgayThanhToan], [MaBan], [TinhTrang], [MaNV]) VALUES (3, CAST(N'2024-04-30' AS Date), NULL, 24, N'1', N'NV001')
INSERT [dbo].[HoaDon] ([MaHD], [NgayTao], [NgayThanhToan], [MaBan], [TinhTrang], [MaNV]) VALUES (12, CAST(N'2024-04-30' AS Date), NULL, 26, N'1', N'NV001')
INSERT [dbo].[HoaDon] ([MaHD], [NgayTao], [NgayThanhToan], [MaBan], [TinhTrang], [MaNV]) VALUES (13, CAST(N'2024-04-30' AS Date), NULL, 27, N'1', N'NV001')
INSERT [dbo].[HoaDon] ([MaHD], [NgayTao], [NgayThanhToan], [MaBan], [TinhTrang], [MaNV]) VALUES (14, CAST(N'2024-04-30' AS Date), NULL, 25, N'1', N'NV001')
INSERT [dbo].[HoaDon] ([MaHD], [NgayTao], [NgayThanhToan], [MaBan], [TinhTrang], [MaNV]) VALUES (15, CAST(N'2024-04-30' AS Date), NULL, 28, N'1', N'NV001')
INSERT [dbo].[HoaDon] ([MaHD], [NgayTao], [NgayThanhToan], [MaBan], [TinhTrang], [MaNV]) VALUES (16, CAST(N'2024-04-30' AS Date), NULL, 29, N'1', N'NV001')
INSERT [dbo].[HoaDon] ([MaHD], [NgayTao], [NgayThanhToan], [MaBan], [TinhTrang], [MaNV]) VALUES (17, CAST(N'2024-04-30' AS Date), NULL, 30, N'1', N'NV001')
INSERT [dbo].[HoaDon] ([MaHD], [NgayTao], [NgayThanhToan], [MaBan], [TinhTrang], [MaNV]) VALUES (18, CAST(N'2024-04-30' AS Date), NULL, 31, N'1', N'NV001')
SET IDENTITY_INSERT [dbo].[HoaDon] OFF
GO
INSERT [dbo].[MonAn] ([MaMon], [TenMon], [Gia], [MaDM], [Cell]) VALUES (N'DU001', N'Nước cam ép', 250000, N'DM001', 9)
INSERT [dbo].[MonAn] ([MaMon], [TenMon], [Gia], [MaDM], [Cell]) VALUES (N'DU002', N'Cà phê sữa đá', 300000, N'DM001', 2)
INSERT [dbo].[MonAn] ([MaMon], [TenMon], [Gia], [MaDM], [Cell]) VALUES (N'DU003', N'Trà sữa trân châu', 350000, N'DM001', 0)
INSERT [dbo].[MonAn] ([MaMon], [TenMon], [Gia], [MaDM], [Cell]) VALUES (N'DU004', N'Nước ngọt lon', 150000, N'DM001', 0)
INSERT [dbo].[MonAn] ([MaMon], [TenMon], [Gia], [MaDM], [Cell]) VALUES (N'DU005', N'Bia lạnh', 350000, N'DM001', 4)
INSERT [dbo].[MonAn] ([MaMon], [TenMon], [Gia], [MaDM], [Cell]) VALUES (N'DU006', N'Rượu vang đỏ', 800000, N'DM001', 12)
INSERT [dbo].[MonAn] ([MaMon], [TenMon], [Gia], [MaDM], [Cell]) VALUES (N'MA001', N'Bún bò Huế', 450000, N'DM001', 1)
INSERT [dbo].[MonAn] ([MaMon], [TenMon], [Gia], [MaDM], [Cell]) VALUES (N'MA002', N'Phở bò', 400000, N'DM001', 0)
INSERT [dbo].[MonAn] ([MaMon], [TenMon], [Gia], [MaDM], [Cell]) VALUES (N'MA003', N'Gà nướng sả ớt', 600000, N'DM002', 0)
INSERT [dbo].[MonAn] ([MaMon], [TenMon], [Gia], [MaDM], [Cell]) VALUES (N'MA004', N'Cơm chiên', 350000, N'DM002', 0)
INSERT [dbo].[MonAn] ([MaMon], [TenMon], [Gia], [MaDM], [Cell]) VALUES (N'MA005', N'Hủ tiếu Nam Vang', 50000, N'DM003', 0)
INSERT [dbo].[MonAn] ([MaMon], [TenMon], [Gia], [MaDM], [Cell]) VALUES (N'MA006', N'Gỏi cuốn', 250000, N'DM003', 0)
GO
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [SDT], [NgaySinh], [MaTK]) VALUES (N'NV001', N'Nam', N'0987654321', CAST(N'2004-05-18' AS Date), N'NV0001')
GO
INSERT [dbo].[Quyen] ([MaQ], [TenQ]) VALUES (N'admin', N'admin')
INSERT [dbo].[Quyen] ([MaQ], [TenQ]) VALUES (N'nv', N'nv')
GO
INSERT [dbo].[TaiKhoan] ([MaTK], [TK], [mk], [MaQ]) VALUES (N'Admin', N'Admin', N'Admin', N'admin')
INSERT [dbo].[TaiKhoan] ([MaTK], [TK], [mk], [MaQ]) VALUES (N'NV0001', N'NV0001', N'123456789', N'nv')
INSERT [dbo].[TaiKhoan] ([MaTK], [TK], [mk], [MaQ]) VALUES (N'NV0002', N'NV0002', N'123456789', N'nv')
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD FOREIGN KEY([MaMon])
REFERENCES [dbo].[MonAn] ([MaMon])
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD FOREIGN KEY([MaHD])
REFERENCES [dbo].[HoaDon] ([MaHD])
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD FOREIGN KEY([MaBan])
REFERENCES [dbo].[BanAn] ([MaBan])
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[MonAn]  WITH CHECK ADD FOREIGN KEY([MaDM])
REFERENCES [dbo].[DanhMucMon] ([MaDM])
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD FOREIGN KEY([MaTK])
REFERENCES [dbo].[TaiKhoan] ([MaTK])
GO
ALTER TABLE [dbo].[TaiKhoan]  WITH CHECK ADD FOREIGN KEY([MaQ])
REFERENCES [dbo].[Quyen] ([MaQ])
GO
/****** Object:  StoredProcedure [dbo].[InsertChiTietHoaDon]    Script Date: 30/04/2024 11:37:46 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertChiTietHoaDon]
    @MaHD INT,
    @MaMon VARCHAR(20),
    @SoLuong INT
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @check INT
    DECLARE @SL INT = 1;
    
    -- 
    SELECT @check = COUNT(*) FROM ChiTietHoaDon WHERE MaHD = @MaHD AND MaMon = @MaMon
    --- 
    IF (@check > 0)
    BEGIN
        
        UPDATE ChiTietHoaDon SET SoLuong = SoLuong + @SoLuong WHERE MaHD = @MaHD AND MaMon = @MaMon
        
     
        IF (SELECT SoLuong FROM ChiTietHoaDon WHERE MaHD = @MaHD AND MaMon = @MaMon) < 1
        BEGIN
            DELETE FROM ChiTietHoaDon WHERE MaHD = @MaHD AND MaMon = @MaMon
        END

        -- Update cell in MonAn by adding @SoLuong
        UPDATE MonAn SET cell = cell + @SoLuong WHERE MaMon = @MaMon
    END
    ELSE
    BEGIN
        -- If the combination doesn't exist, insert a new row
        INSERT INTO ChiTietHoaDon (MaHD, MaMon, SoLuong) VALUES (@MaHD, @MaMon, @SoLuong)
    END
END
GO
/****** Object:  StoredProcedure [dbo].[InsertHoaDon]    Script Date: 30/04/2024 11:37:46 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertHoaDon]
    @MaNV VARCHAR(10),
    @MaBan INT
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @NgayTao DATE = GETDATE();
    DECLARE @NgayThanhToan DATE = NULL;
    DECLARE @TinhTrang VARCHAR(30) = '1';

    INSERT INTO HoaDon (NgayTao, NgayThanhToan, MaBan, TinhTrang, MaNV)
    VALUES (@NgayTao, @NgayThanhToan, @MaBan, @TinhTrang, @MaNV);

    UPDATE BanAn
    SET TrangThai = ''
    WHERE MaBan = @MaBan;
END;
GO
USE [master]
GO
ALTER DATABASE [qlqa] SET  READ_WRITE 
GO
