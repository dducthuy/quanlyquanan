
select* from MonAn


go

------------------------------------
CREATE PROCEDURE InsertChiTietHoaDon
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


--DROP PROCEDURE  InsertChiTietHoaDon
------------------------------------------
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


---------------------------



EXEC  InsertChiTietHoaDon  13, 'MA001', -6;
select Max(MaHD) from HoaDon

select * from MonAn
select * from ChiTietHoaDon
select * from HoaDon
select * from  BanAn
select * from HoaDon

-- Xóa dữ liệu từ bảng ChiTietHoaDon
DELETE FROM ChiTietHoaDon;

-- Xóa dữ liệu từ bảng HoaDon
DELETE FROM HoaDon;

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
exec checkout 22,22;
drop procedure checkout