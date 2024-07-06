USE master;
GO

DROP DATABASE IF EXISTS QL_THUVIEN;
GO

CREATE DATABASE QL_THUVIEN;
GO

USE QL_THUVIEN;
GO
-- Table: nguoi_dung
drop table nguoi_dung
CREATE TABLE nguoi_dung (
    nguoi_dung_id INT IDENTITY PRIMARY KEY,
    ten_nguoi_dung NVARCHAR(100),
    mat_khau NVARCHAR(50)
);

-- Table: loai_sach
CREATE TABLE loai_sach (
    loai_sach_id INT IDENTITY PRIMARY KEY,
    ten_loai_sach NVARCHAR(100)
);

-- Table: ngon_ngu
CREATE TABLE ngon_ngu (
    ngon_ngu_id INT IDENTITY PRIMARY KEY,
    ten_ngon_ngu NVARCHAR(50)
);

-- Table: sach
CREATE TABLE sach (
    sach_id INT PRIMARY KEY,
    loai_sach_id INT,
    nha_xb NVARCHAR(100),
    ngon_ngu_id INT,
    ten_sach NVARCHAR(100),
    tac_gia NVARCHAR(100),
    so_luong INT,
    ngay_nhap DATE,
    gia_bia FLOAT,
    FOREIGN KEY (loai_sach_id) REFERENCES loai_sach(loai_sach_id),
    FOREIGN KEY (ngon_ngu_id) REFERENCES ngon_ngu(ngon_ngu_id)
);

-- Table: doc_gia
CREATE TABLE doc_gia (
    doc_gia_id INT PRIMARY KEY,
    ten_doc_gia NVARCHAR(100),
	nam_sinh Date,
    dia_chi NVARCHAR(100),
	so_dien_thoai varchar(30),
    so_chung_minh_thu VARCHAR(50),
	han_the nvarchar(20)
);

ALTER TABLE doc_gia ADD so_dien_thoai varchar(30);

drop table doc_gia

drop table phieu_muon
go
drop table chi_tiet_phieu_muon
-- Table: phieu_muon
CREATE TABLE phieu_muon (
    phieu_muon_id INT IDENTITY PRIMARY KEY,
    doc_gia_id INT,
    ngay_muon DATE,
    ngay_hen_tra DATE,
    FOREIGN KEY (doc_gia_id) REFERENCES doc_gia(doc_gia_id)
);
go
-- Table: chi_tiet_phieu_muon
CREATE TABLE chi_tiet_phieu_muon (
    phieu_muon_id INT,
    sach_id INT,
	so_luong INT,
    FOREIGN KEY (phieu_muon_id) REFERENCES phieu_muon(phieu_muon_id),
    FOREIGN KEY (sach_id) REFERENCES sach(sach_id)
);
USE QL_THUVIEN;
GO

-- Insert sample data into nguoi_dung
INSERT INTO nguoi_dung (ten_nguoi_dung, mat_khau)
VALUES
( N'admin', 'admin123'),
( N'admin', 'admin');

 SELECT * FROM nguoi_dung

-- Insert sample data into loai_sach
INSERT INTO loai_sach (ten_loai_sach)
VALUES
(N'Tiểu thuyết'),
(N'Khoa học'),
(N'Lịch sử');

-- Insert sample data into ngon_ngu
INSERT INTO ngon_ngu ( ten_ngon_ngu)
VALUES
(N'Tiếng Việt'),
(N'Tiếng Anh'),
(N'Tiếng Pháp'),
(N'Tiếng Ý');

-- Insert sample data into sach
INSERT INTO sach (sach_id, loai_sach_id, nha_xb, ngon_ngu_id, ten_sach, tac_gia, so_luong, ngay_nhap, gia_bia)
VALUES
(1, 1, N'NXB Kim Dong', 1, N'Truyen Kieu', N'Nguyen Du', 10, '2023-01-15', 50000),
(2, 2, N'NXB Tre', 2, N'A Brief History of Time', N'Stephen Hawking', 5, '2023-03-10', 150000),
(3, 3, N'NXB Giao Duc', 1, N'Lich Su Viet Nam', N'Pham Van Dong', 7, '2023-05-20', 70000);

-- Insert sample data into doc_gia
INSERT INTO doc_gia (doc_gia_id, ten_doc_gia, nam_sinh, dia_chi, so_dien_thoai, so_chung_minh_thu, han_the)
VALUES
(4, N'Nguyễn Văn Anh', '1-1-2000' , N'Hà Nội', '090237584', '123456789', '1-1-2028'),
(5, N'Nguyễn Văn Đạt', '2-2-2002', N'Hồ Chí Minh', '018538372','987654321', '1-1-2028');

SELECT * FROM doc_gia;

-- Insert sample data into phieu_muon
INSERT INTO phieu_muon (doc_gia_id, ngay_muon, ngay_hen_tra)
VALUES
(1, '2024-06-01', '2024-06-15'),
(2, '2024-06-05', '2024-06-20');

delete chi_tiet_phieu_muon where phieu_muon_id = 2
delete phieu_muon where phieu_muon_id = 2

select * from phieu_muon
select * from chi_tiet_phieu_muon
select * from sach
-- Insert sample data into chi_tiet_phieu_muon
INSERT INTO chi_tiet_phieu_muon (phieu_muon_id, sach_id, so_luong)
VALUES
(1, 1, 2),
(1, 2, 1),
(2, 2, 4);


--- viết proc cho bảng sách
CREATE PROCEDURE proc_loads_the_loai
AS
BEGIN
    SELECT * FROM loai_sach;
END;
GO

CREATE PROCEDURE proc_loads_ngon_ngu
AS
BEGIN
    SELECT * FROM ngon_ngu;
END;
GO

USE QL_THUVIEN;
GO

alter PROCEDURE proc_insert_sach
    @sach_id INT,
    @loai_sach_id INT,
    @nha_xb NVARCHAR(100),
    @ngon_ngu_id INT,
    @ten_sach NVARCHAR(100),
    @tac_gia NVARCHAR(100),
    @so_luong INT,
    @ngay_nhap DATE,
    @gia_bia FLOAT
AS
BEGIN
    INSERT INTO sach (sach_id, loai_sach_id, nha_xb, ngon_ngu_id, ten_sach, tac_gia, so_luong, ngay_nhap, gia_bia)
    VALUES (@sach_id, @loai_sach_id, @nha_xb, @ngon_ngu_id, @ten_sach, @tac_gia, @so_luong, @ngay_nhap, @gia_bia);
END;
GO


USE QL_THUVIEN;
GO

ALTER PROCEDURE proc_loads_sach
AS
BEGIN
    SELECT 
		s.sach_id as [Mã Sách],
		s.ten_sach as [Tên Sách],
		s.gia_bia as [Giá Sách],
		ls.ten_loai_sach as [Loại Sách],
		nn.ten_ngon_ngu as [Ngôn Ngữ],
		s.so_luong as [Số Lượng],
		s.tac_gia as [Tác Giả],
		s.ngay_nhap as [Ngày Nhập],
		s.nha_xb as [Nhà xuất bản] 
	FROM sach s 
	JOIN
		loai_sach ls ON ls.loai_sach_id = s.loai_sach_id
	JOIN 
		ngon_ngu nn ON nn.ngon_ngu_id = s.ngon_ngu_id

END;
GO

USE QL_THUVIEN;
GO

CREATE PROCEDURE proc_delete_sach
    @sach_id INT
AS
BEGIN
    DELETE FROM sach
    WHERE sach_id = @sach_id;
END;
GO

USE QL_THUVIEN;
GO

ALTER PROCEDURE proc_edit_sach
    @sach_id INT,
    @loai_sach_id INT,
    @nha_xb NVARCHAR(100),
    @ngon_ngu_id INT,
    @ten_sach NVARCHAR(100),
    @tac_gia NVARCHAR(100),
    @so_luong INT,
    @ngay_nhap DATE,
    @gia_bia FLOAT
AS
BEGIN
    UPDATE sach
    SET 
        loai_sach_id = @loai_sach_id,
        nha_xb = @nha_xb,
        ngon_ngu_id = @ngon_ngu_id,
        ten_sach = @ten_sach,
        tac_gia = @tac_gia,
        so_luong = @so_luong,
        ngay_nhap = @ngay_nhap,
        gia_bia = @gia_bia
    WHERE sach_id = @sach_id;
END;
GO

--Quản Lý Mượn Trả
-- Procedure to load data from phieu_muon table
CREATE PROCEDURE proc_loads_phieu_muon
AS
BEGIN
    SELECT * FROM phieu_muon;
END;
GO

-- Procedure to load data from chi_tiet_phieu_muon table
ALTER PROCEDURE proc_loads_chi_tiet_phieu_muon
    @phieu_muon_id INT
AS
BEGIN
    SELECT 
        s.ten_sach AS [Tên Sách],
        ctpm.so_luong AS [Số Lượng]
    FROM 
        chi_tiet_phieu_muon ctpm
    JOIN 
        sach s ON ctpm.sach_id = s.sach_id
    WHERE
        ctpm.phieu_muon_id = @phieu_muon_id;
END;
GO

--proc tìm kiếm 
ALTER PROCEDURE proc_loads_tim_kiem
@tensach NVARCHAR(MAX)
AS
BEGIN
    SELECT s.sach_id as [Mã Sách], 
	s.nha_xb as [NXB], 
	s.ten_sach as [Tên Sách], 
	s.tac_gia as [Tác Giả], 
	nn.ten_ngon_ngu as [Ngôn Ngữ], 
	ls.ten_loai_sach as [Loại Sách], 
	s.so_luong as [Số Lượng], 
	s.ngay_nhap as [Ngày Nhập], 
	s.gia_bia as [Giá Bán]
	FROM sach s
	JOIN 
		ngon_ngu nn on s.ngon_ngu_id = nn.ngon_ngu_id
	JOIN
		loai_sach ls on s.loai_sach_id = ls.loai_sach_id
	WHERE 
		@tensach IS NULL OR ten_sach LIKE '%' + @tensach + '%'
	ORDER BY ten_sach;
END;
GO

select * from sach
EXEC proc_loads_tim_kiem @tensach = N'Truyen';


-- Phiếu Mượn Proc
USE QL_THUVIEN;
GO

CREATE PROCEDURE proc_loads_phieuMuon
AS
BEGIN
    SELECT 
        pm.phieu_muon_id AS [Mã Phiếu Mượn],
		pm.doc_gia_id as [Mã Độc Giả],
        dg.ten_doc_gia AS [Tên Độc Giả],
        pm.ngay_muon AS [Ngày Mượn],
        pm.ngay_hen_tra AS [Ngày Hẹn Trả]
    FROM 
        phieu_muon pm
    JOIN 
        doc_gia dg ON pm.doc_gia_id = dg.doc_gia_id
    ORDER BY 
        dg.ten_doc_gia;
END;
GO

-- Loadss all chi tiết phiếu mượn
CREATE PROCEDURE proc_loads_chiTietPhieuMuon
@phieu_muon_id INT
AS
BEGIN
    SELECT 
        ctpm.phieu_muon_id AS [Mã Phiếu Mượn],
        s.ten_sach AS [Tên Sách],
        ctpm.so_luong AS [Số Lượng],
        pm.ngay_hen_tra AS [Ngày Trả]
    FROM 
        chi_tiet_phieu_muon ctpm
    JOIN 
        sach s ON ctpm.sach_id = s.sach_id
	JOIN 
        phieu_muon pm ON ctpm.phieu_muon_id = pm.phieu_muon_id
    WHERE
        ctpm.phieu_muon_id = @phieu_muon_id
    ORDER BY 
        s.ten_sach;
END;
GO

--thêm phiếu mượn
CREATE PROCEDURE proc_insert_phieuMuon
	
    @doc_gia_id INT,
    @ngay_muon DATE,
    @ngay_hen_tra DATE
AS
BEGIN
    INSERT INTO phieu_muon ( doc_gia_id, ngay_muon, ngay_hen_tra)
    VALUES ( @doc_gia_id, @ngay_muon, @ngay_hen_tra);
END;
GO

CREATE PROCEDURE dbo.proc_editPhieuMuon
    @phieu_muon_id INT,
    @doc_gia_id INT,
    @ngay_muon DATE,
    @ngay_hen_tra DATE
AS
BEGIN
    -- Update the phieu_muon table
    UPDATE phieu_muon
    SET 
        doc_gia_id = @doc_gia_id,
        ngay_muon = @ngay_muon,
        ngay_hen_tra = @ngay_hen_tra
    WHERE 
        phieu_muon_id = @phieu_muon_id
END;
GO


Create PROCEDURE proc_docGia
AS
BEGIN
    SELECT * FROM doc_gia;
END;
GO

-- 
CREATE PROCEDURE proc_DeletePM
    @phieu_muon_id INT
AS
BEGIN


    -- Cập nhật số lượng sách trước khi xóa chi tiết phiếu mượn
    UPDATE s
    SET s.so_luong = s.so_luong + ctpm.so_luong
    FROM sach s
    JOIN chi_tiet_phieu_muon ctpm ON s.sach_id = ctpm.sach_id
    WHERE ctpm.phieu_muon_id = @phieu_muon_id;

    -- Xóa các chi tiết phiếu mượn liên quan
    DELETE FROM chi_tiet_phieu_muon
    WHERE phieu_muon_id = @phieu_muon_id;

    -- Xóa phiếu mượn
    DELETE FROM phieu_muon
    WHERE phieu_muon_id = @phieu_muon_id;


END;
GO
select*from phieu_muon
select*from chi_tiet_phieu_muon where phieu_muon_id = 3;
EXEC proc_DeletePM @phieu_muon_id = 5;


--thêm sách vào chi tiết phiếu mượn
USE QL_THUVIEN;
GO

CREATE PROCEDURE proc_themChiTietPM
    @phieu_muon_id INT,
    @sach_id INT,
    @so_luong INT
AS
BEGIN
    -- Bắt đầu một giao dịch
    BEGIN TRANSACTION;

    -- Trừ số lượng sách trước khi thêm chi tiết phiếu mượn
    UPDATE sach
    SET so_luong = so_luong - @so_luong
    WHERE sach_id = @sach_id;

    -- Kiểm tra nếu số lượng sách không đủ
    IF (SELECT so_luong FROM sach WHERE sach_id = @sach_id) < 0
    BEGIN
        -- Hủy giao dịch nếu số lượng sách không đủ
        ROLLBACK TRANSACTION;
        RAISERROR('Số lượng sách không đủ. Không thể thêm chi tiết phiếu mượn.', 16, 1);
        RETURN;
    END

    -- Thêm chi tiết phiếu mượn
    INSERT INTO chi_tiet_phieu_muon (phieu_muon_id, sach_id, so_luong)
    VALUES (@phieu_muon_id, @sach_id, @so_luong);

    -- Nếu mọi thứ diễn ra tốt đẹp, xác nhận giao dịch
    COMMIT TRANSACTION;
END;
GO



EXEC proc_themChiTietPM @phieu_muon_id = 2, @sach_id = 2, @so_luong = 2;


USE QL_THUVIEN;
GO

CREATE PROCEDURE proc_deleteChiTietPM
    @phieu_muon_id INT,
    @sach_id INT
AS
BEGIN
    -- Bắt đầu một giao dịch
    BEGIN TRANSACTION;

    -- Lấy số lượng sách từ bảng chi_tiet_phieu_muon để cập nhật số lượng sách
    DECLARE @so_luong INT;

    SELECT @so_luong = so_luong
    FROM chi_tiet_phieu_muon
    WHERE phieu_muon_id = @phieu_muon_id AND sach_id = @sach_id;

    -- Nếu không tìm thấy bản ghi, trả về lỗi
    IF @so_luong IS NULL
    BEGIN
        -- Hủy giao dịch và thông báo lỗi nếu không tìm thấy bản ghi
        ROLLBACK TRANSACTION;
        RAISERROR('Chi tiết phiếu mượn không tồn tại.', 16, 1);
        RETURN;
    END

    -- Cập nhật số lượng sách trong bảng sach
    UPDATE sach
    SET so_luong = so_luong + @so_luong
    WHERE sach_id = @sach_id;

    -- Xóa chi tiết phiếu mượn
    DELETE FROM chi_tiet_phieu_muon
    WHERE phieu_muon_id = @phieu_muon_id AND sach_id = @sach_id;

    -- Nếu mọi thứ diễn ra tốt đẹp, xác nhận giao dịch
    COMMIT TRANSACTION;
END;
GO
EXEC proc_deleteChiTietPM @phieu_muon_id = 2, @sach_id = 2;


USE QL_THUVIEN;
GO

CREATE VIEW vw_doc_gia_phieu_muon AS
SELECT 
    pm.phieu_muon_id as [Mã Phiếu],
    dg.ten_doc_gia as [Tên Độc Giả],
    dg.dia_chi as [Địa Chỉ],
    pm.ngay_muon as [Ngày Mượn],
    pm.ngay_hen_tra as [Ngày Trả]
FROM 
    phieu_muon pm
JOIN 
    doc_gia dg ON pm.doc_gia_id = dg.doc_gia_id;
GO


alter VIEW vw_phieu_muon_chi_tiet_sach AS
SELECT 
	pm.phieu_muon_id as [Mã Phiếu],
    s.ten_sach as [Tên Sách],
    ctpm.so_luong as [Số Lượng]
FROM 
    phieu_muon pm
JOIN 
    chi_tiet_phieu_muon ctpm ON pm.phieu_muon_id = ctpm.phieu_muon_id
JOIN 
    sach s ON ctpm.sach_id = s.sach_id;
GO