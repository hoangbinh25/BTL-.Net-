USE [QL_THUVIEN]
GO
/****** Object:  StoredProcedure [dbo].[proc_loads_sach]    Script Date: 7/4/2024 8:50:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[proc_loads_sach]
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
