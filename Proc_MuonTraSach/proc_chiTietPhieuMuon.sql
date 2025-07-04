USE [QL_THUVIEN]
GO
/****** Object:  StoredProcedure [dbo].[proc_loads_chiTietPhieuMuon]    Script Date: 7/3/2024 11:24:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[proc_loads_chiTietPhieuMuon]
@phieu_muon_id INT
AS
BEGIN
    SELECT 
        ctpm.phieu_muon_id AS [Mã Phiếu Mượn],
		s.sach_id AS [Mã Sách],
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
