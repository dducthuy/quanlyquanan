CREATE PROCEDURE InsertHoaDon
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
EXEC InsertHoaDon 'NV001', 27;

----------------------------------------------------------------------------------------
CREATE PROCEDURE checkout
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

-----------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE InsertChiTietHoaDon
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

            IF (ABS(@SoLuong) > @CurrentSoLuong)
            BEGIN
                -- Giảm trường cell trong MonAn bằng số lượng hiện tại
                UPDATE MonAn SET cell = cell - @CurrentSoLuong WHERE MaMon = @MaMon;
				DELETE FROM ChiTietHoaDon WHERE MaHD = @MaHD AND MaMon = @MaMon;
            END
            ELSE
            BEGIN
                -- Cập nhật lại trường cell trong MonAn khi số lượng mới nhỏ hơn hoặc bằng số lượng hiện tại
                UPDATE MonAn SET cell = cell + @SoLuong WHERE MaMon = @MaMon;
				-- Cập nhật số lượng trong ChiTietHoaDon
                UPDATE ChiTietHoaDon SET SoLuong = SoLuong + @SoLuong WHERE MaHD = @MaHD AND MaMon = @MaMon;
            END
        END
        ELSE
        BEGIN
            -- Cập nhật số lượng trong ChiTietHoaDon và MonAn khi số lượng mới là số dương
            UPDATE ChiTietHoaDon SET SoLuong = SoLuong + @SoLuong WHERE MaHD = @MaHD AND MaMon = @MaMon;
            UPDATE MonAn SET cell = cell + @SoLuong WHERE MaMon = @MaMon;
        END
    END
    ELSE 
    BEGIN
        -- Nếu không có dữ liệu, thêm một bản ghi mới vào ChiTietHoaDon
        INSERT INTO ChiTietHoaDon (MaHD, MaMon, SoLuong) VALUES (@MaHD, @MaMon, @SoLuong);
        -- Tăng trường cell trong MonAn
        UPDATE MonAn SET cell = cell + @SoLuong WHERE MaMon = @MaMon;
    END
END

drop PROC HoaDonchuyenban
CREATE PROC HoaDonchuyenban
@idBanDau INT,
@idBanMoi INT
AS
BEGIN
    DECLARE @idHoaDonCu INT, @idHoaDonMoi INT,
    
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
	---- gộp 2 hóa sđơn
	else 
	begin
	  UPDATE dbo.HoaDon
        SET MaBan = @idBanMoi
        WHERE MaHD = @idHoaDonCu


	end
    -- Cập nhật trạng thái của các bàn
    UPDATE dbo.BanAn
    SET TrangThai = N'Trống'
    WHERE MaBan = @idBanDau

    UPDATE dbo.BanAn
    SET TrangThai = N''
    WHERE MaBan = @idBanMoi
END


-- Gọi procedure USP_ChuyenDonHang với các tham số tương ứng
EXEC HoaDonchuyenban @idBanDau = 22, @idBanMoi = 23;
   select * from BanAn
   select * from HoaDon
   select* from ChiTietHoaDon
   select* from MonAn



  drop procedure HoaDonchuyenban

   CREATE PROC HoaDonchuyenban
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


--CREATE PROCEDURE GopSoLuongChiTietHoaDon
--AS
--BEGIN
--    -- Tạo bảng tạm thời để lưu trữ tổng số lượng của từng món trong hóa đơn
--    CREATE TABLE #TempSoLuongChiTietHoaDon (
--        MaHD INT,
--        MaMon VARCHAR(20),
--        TongSoLuong INT
--    );

--    -- Tính tổng số lượng của từng món trong hóa đơn và lưu vào bảng tạm thời
--    INSERT INTO #TempSoLuongChiTietHoaDon (MaHD, MaMon, TongSoLuong)
--    SELECT MaHD, MaMon, SUM(SoLuong) AS TongSoLuong
--    FROM dbo.ChiTietHoaDon
--    GROUP BY MaHD, MaMon;

--    -- Xóa các chi tiết hóa đơn cũ
--    DELETE FROM dbo.ChiTietHoaDon
--WHERE EXISTS (
--    SELECT 1
--    FROM #TempSoLuongChiTietHoaDon Temp
--    WHERE dbo.ChiTietHoaDon.MaHD = Temp.MaHD
--    AND dbo.ChiTietHoaDon.MaMon = Temp.MaMon
--);

--    -- Thêm các chi tiết hóa đơn mới với số lượng được gộp lại từ bảng tạm thời
--    INSERT INTO dbo.ChiTietHoaDon (MaHD, MaMon, SoLuong)
--    SELECT MaHD, MaMon, TongSoLuong
--    FROM #TempSoLuongChiTietHoaDon;

--    -- Xóa bảng tạm thời
--    DROP TABLE #TempSoLuongChiTietHoaDon;
--END;



