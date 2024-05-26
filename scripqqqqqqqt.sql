USE [master]
GO
/****** Object:  Database [qlqa]    Script Date: 26/05/2024 1:35:33 SA ******/
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
/****** Object:  Table [dbo].[BanAn]    Script Date: 26/05/2024 1:35:33 SA ******/
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
/****** Object:  Table [dbo].[ChiTietHoaDon]    Script Date: 26/05/2024 1:35:33 SA ******/
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
/****** Object:  Table [dbo].[DanhMucMon]    Script Date: 26/05/2024 1:35:33 SA ******/
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
/****** Object:  Table [dbo].[HoaDon]    Script Date: 26/05/2024 1:35:33 SA ******/
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
/****** Object:  Table [dbo].[MonAn]    Script Date: 26/05/2024 1:35:33 SA ******/
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
/****** Object:  Table [dbo].[NhanVien]    Script Date: 26/05/2024 1:35:33 SA ******/
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
/****** Object:  Table [dbo].[Quyen]    Script Date: 26/05/2024 1:35:33 SA ******/
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
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 26/05/2024 1:35:33 SA ******/
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
/****** Object:  StoredProcedure [dbo].[checkout]    Script Date: 26/05/2024 1:35:33 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[checkout]
    @MaHD int,
    @MaBan int
AS
BEGIN
    SET NOCOUNT ON;
    
    UPDATE HoaDon  
    SET TinhTrang = '0', NgayThanhToan = GETDATE() 
    WHERE MaHD = @MaHD;

    UPDATE BanAn 
    SET TrangThai = N'Trống' 
    WHERE MaBan = @MaBan;
END;
GO
/****** Object:  StoredProcedure [dbo].[GetBillDetailsByMaHD]    Script Date: 26/05/2024 1:35:33 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

	CREATE PROCEDURE [dbo].[GetBillDetailsByMaHD]
    @MaHD INT
AS
begin
SELECT 
    HD.MaHD,
    m.TenMon,
    m.Gia,
    CT.SoLuong,
    CT.SoLuong * m.Gia AS ThanhTien,
  
    BA.TenBan,
    SUM(CT.SoLuong * m.Gia) OVER () AS TongHoaDon
FROM 
    MonAn AS m
JOIN 
    ChiTietHoaDon AS CT ON m.MaMon = CT.MaMon
JOIN 
    HoaDon AS HD ON CT.MaHD = HD.MaHD
JOIN 
    BanAn AS BA ON HD.MaBan = BA.MaBan
WHERE 
    HD.TinhTrang = 1
    AND HD.MaBan = @MaHD
end


GO
/****** Object:  StoredProcedure [dbo].[GopSoLuongChiTietHoaDon]    Script Date: 26/05/2024 1:35:33 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GopSoLuongChiTietHoaDon]
AS
BEGIN
    -- Tạo bảng tạm thời để lưu trữ tổng số lượng của từng món trong hóa đơn
    CREATE TABLE #TempSoLuongChiTietHoaDon (
        MaHD INT,
        MaMon VARCHAR(20),
        TongSoLuong INT
    );

    -- Tính tổng số lượng của từng món trong hóa đơn và lưu vào bảng tạm thời
    INSERT INTO #TempSoLuongChiTietHoaDon (MaHD, MaMon, TongSoLuong)
    SELECT MaHD, MaMon, SUM(SoLuong) AS TongSoLuong
    FROM dbo.ChiTietHoaDon
    GROUP BY MaHD, MaMon;

    -- Xóa các chi tiết hóa đơn cũ
    DELETE FROM dbo.ChiTietHoaDon
WHERE EXISTS (
    SELECT 1
    FROM #TempSoLuongChiTietHoaDon Temp
    WHERE dbo.ChiTietHoaDon.MaHD = Temp.MaHD
    AND dbo.ChiTietHoaDon.MaMon = Temp.MaMon
);

    -- Thêm các chi tiết hóa đơn mới với số lượng được gộp lại từ bảng tạm thời
    INSERT INTO dbo.ChiTietHoaDon (MaHD, MaMon, SoLuong)
    SELECT MaHD, MaMon, TongSoLuong
    FROM #TempSoLuongChiTietHoaDon;

    -- Xóa bảng tạm thời
    DROP TABLE #TempSoLuongChiTietHoaDon;
END;
GO
/****** Object:  StoredProcedure [dbo].[HoaDonchuyenban]    Script Date: 26/05/2024 1:35:33 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE PROC [dbo].[HoaDonchuyenban]
@idBanDau INT,
@idBanMoi INT
AS
BEGIN
    DECLARE @idHoaDonCu INT, @idHoaDonMoi INT
    
    -- Lấy ID của hóa đơn liên kết với bàn đầu tiên
    SELECT @idHoaDonCu = MaHD
    FROM dbo.HoaDon
    WHERE MaBan = @idBanDau AND TinhTrang = N'1'

    -- Lấy ID của hóa đơn liên kết với bàn thứ hai
    SELECT @idHoaDonMoi = MaHD
    FROM dbo.HoaDon
    WHERE MaBan = @idBanMoi AND TinhTrang = N'1'

    -- Nếu không có hóa đơn nào liên kết với bàn thứ hai, cập nhật hóa đơn của bàn cũ sang bàn mới
    IF @idHoaDonMoi IS NULL
    BEGIN
        UPDATE dbo.HoaDon
        SET MaBan = @idBanMoi
        WHERE MaHD = @idHoaDonCu
    END
    -- Nếu có hóa đơn đang tồn tại trên bàn mới, gộp hóa đơn của bàn cũ vào hóa đơn của bàn mới
    ELSE
    BEGIN


        -- Cập nhật MaBan của hóa đơn của bàn cũ sang bàn mới
        UPDATE dbo.HoaDon
        SET MaBan = @idBanMoi
        WHERE MaHD = @idHoaDonCu;

        -- Gộp các mục trong bảng ChiTietHoaDon vào hóa đơn của bàn mới
        UPDATE dbo.ChiTietHoaDon
        SET MaHD = @idHoaDonMoi
        WHERE MaHD = @idHoaDonCu;
		EXEC GopSoLuongChiTietHoaDon;


        -- Xóa hóa đơn của bàn cũ sau khi đã gộp
        DELETE FROM dbo.HoaDon WHERE MaHD = @idHoaDonCu;
    END

    -- Cập nhật trạng thái của các bàn
    UPDATE dbo.BanAn
    SET TrangThai = N'Trống'
    WHERE MaBan = @idBanDau;

    UPDATE dbo.BanAn
    SET TrangThai = N''
    WHERE MaBan = @idBanMoi;
END
GO
/****** Object:  StoredProcedure [dbo].[HoadonNgay]    Script Date: 26/05/2024 1:35:33 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[HoadonNgay]
    @Ngay DATE
AS
BEGIN
    SELECT
        SUM(MA.Gia * CTHD.SoLuong) AS  TongTien,
        CTHD.MaHD,
        HD.NgayTao,
        HD.NgayThanhToan,
		SUM(SUM(MA.Gia * CTHD.SoLuong)) over () as TongDT
    FROM
        HoaDon HD
        INNER JOIN ChiTietHoaDon CTHD ON HD.MaHD = CTHD.MaHD
        INNER JOIN MonAn MA ON CTHD.MaMon = MA.MaMon
    WHERE
        CONVERT(DATE, HD.NgayThanhToan) = @Ngay
        AND HD.TinhTrang = '0'
    GROUP BY
        CTHD.MaHD,
        HD.NgayTao,
        HD.NgayThanhToan;
END;
GO
/****** Object:  StoredProcedure [dbo].[InsertChiTietHoaDon]    Script Date: 26/05/2024 1:35:33 SA ******/
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
    DECLARE @check INT;
    SELECT @check = COUNT(*) FROM ChiTietHoaDon WHERE MaHD = @MaHD AND MaMon = @MaMon;
    
    IF (@check > 0)
    BEGIN
        IF (@SoLuong < 0)
        BEGIN
            DECLARE @CurrentSoLuong INT;
            SELECT @CurrentSoLuong = SoLuong FROM ChiTietHoaDon WHERE MaHD = @MaHD AND MaMon = @MaMon;

            IF (ABS(@SoLuong) >= @CurrentSoLuong)
            BEGIN
                -- Giảm trường cell trong MonAn bằng số lượng hiện tại
                DELETE FROM ChiTietHoaDon WHERE MaHD = @MaHD AND MaMon = @MaMon;
            END
            ELSE
            BEGIN
                -- Cập nhật lại trường cell trong MonAn khi số lượng mới nhỏ hơn hoặc bằng số lượng hiện tại
                UPDATE ChiTietHoaDon SET SoLuong = SoLuong + @SoLuong WHERE MaHD = @MaHD AND MaMon = @MaMon;
            END
        END
        ELSE
        BEGIN
            -- Cập nhật số lượng trong ChiTietHoaDon khi số lượng mới là số dương
            UPDATE ChiTietHoaDon SET SoLuong = SoLuong + @SoLuong WHERE MaHD = @MaHD AND MaMon = @MaMon;
        END
    END
    ELSE 
    BEGIN
        -- Nếu không có dữ liệu, thêm một bản ghi mới vào ChiTietHoaDon
        INSERT INTO ChiTietHoaDon (MaHD, MaMon, SoLuong) VALUES (@MaHD, @MaMon, @SoLuong);
    END
END
GO
/****** Object:  StoredProcedure [dbo].[InsertHoaDon]    Script Date: 26/05/2024 1:35:33 SA ******/
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
/****** Object:  StoredProcedure [dbo].[layhd]    Script Date: 26/05/2024 1:35:33 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

	CREATE PROCEDURE [dbo].[layhd]
    @MaHD INT
AS
begin
SELECT 
    HD.MaHD,
	HD.MaNV,
    m.TenMon,
    m.Gia,
    CT.SoLuong,
    CT.SoLuong * m.Gia AS ThanhTien,
  
    BA.TenBan,
    SUM(CT.SoLuong * m.Gia) OVER () AS TongHoaDon
FROM 
    MonAn AS m
JOIN 
    ChiTietHoaDon AS CT ON m.MaMon = CT.MaMon
JOIN 
    HoaDon AS HD ON CT.MaHD = HD.MaHD
JOIN 
    BanAn AS BA ON HD.MaBan = BA.MaBan
WHERE 
    HD.TinhTrang = 1
    AND HD.MaBan = @MaHD
end
GO
/****** Object:  StoredProcedure [dbo].[layhd_tk]    Script Date: 26/05/2024 1:35:33 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[layhd_tk] 
    @MaHD INT
AS
begin
SELECT 
    HD.MaHD,
	HD.MaNV,
    m.TenMon,
    m.Gia,
    CT.SoLuong,
    CT.SoLuong * m.Gia AS ThanhTien,

  
    BA.TenBan,
    SUM(CT.SoLuong * m.Gia) OVER () AS TongHoaDon,
	HD.NgayThanhToan as ngay
FROM 
    MonAn AS m
JOIN 
    ChiTietHoaDon AS CT ON m.MaMon = CT.MaMon
JOIN 
    HoaDon AS HD ON CT.MaHD = HD.MaHD
JOIN 
    BanAn AS BA ON HD.MaBan = BA.MaBan
WHERE 
    HD.TinhTrang = 0
    AND HD.MaHD = @MaHD
end
GO
/****** Object:  StoredProcedure [dbo].[ThongKeSoDonHangVaDoanhThuTheoNam]    Script Date: 26/05/2024 1:35:33 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ThongKeSoDonHangVaDoanhThuTheoNam]
    @Nam INT
AS
BEGIN
    SELECT
  COUNT(DISTINCT HD.MaHD) AS SoDonHang,
  SUM(MA.Gia * CTHD.SoLuong) AS TongTien,
       MONTH(HD.NgayThanhToan) AS Thang,
  SUM(SUM(MA.Gia * CTHD.SoLuong)) OVER () AS TongDT ,
       YEAR(HD.NgayThanhToan) as nam

    FROM
        HoaDon HD
        INNER JOIN ChiTietHoaDon CTHD ON HD.MaHD = CTHD.MaHD
        INNER JOIN MonAn MA ON CTHD.MaMon = MA.MaMon
    WHERE
        YEAR(HD.NgayThanhToan) = @Nam
        AND HD.TinhTrang = '0'
    GROUP BY
        MONTH(HD.NgayThanhToan), YEAR(HD.NgayThanhToan);
END;
GO
/****** Object:  StoredProcedure [dbo].[ThongKeSoDonHangVaDoanhThuTheoNgay]    Script Date: 26/05/2024 1:35:33 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ThongKeSoDonHangVaDoanhThuTheoNgay]
 @Thang INT,
 @Nam INT
AS
BEGIN
 SELECT
  COUNT(DISTINCT HD.MaHD) AS SoDonHang, -- Sử dụng COUNT(DISTINCT HD.MaHD) để đếm số lượng hóa đơn duy nhất
  SUM(MA.Gia * CTHD.SoLuong) AS TongTien, -- Create an alias for daily total revenue (moved up)
  HD.NgayThanhToan AS Ngay,
   SUM(SUM(MA.Gia * CTHD.SoLuong)) OVER () AS TongDoanhThu, -- Thêm cột tổng doanh thu
  MONTH(HD.NgayThanhToan) as thang
  
FROM
 HoaDon HD
 INNER JOIN ChiTietHoaDon CTHD ON HD.MaHD = CTHD.MaHD
 INNER JOIN MonAn MA ON CTHD.MaMon = MA.MaMon
WHERE
 MONTH(HD.NgayThanhToan) = @Thang
 AND YEAR(HD.NgayThanhToan) = @Nam
 AND HD.TinhTrang = '0'
GROUP BY
  HD.NgayThanhToan;
END;

GO
USE [master]
GO
ALTER DATABASE [qlqa] SET  READ_WRITE 
GO
