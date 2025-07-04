USE [QL_THUVIEN]
GO
/****** Object:  StoredProcedure [dbo].[proc_docGia]    Script Date: 7/3/2024 5:11:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROC [dbo].[proc_docGia]
AS
BEGIN
	SELECT	dg.doc_gia_id as [Mã Độc Giả],
			dg.ten_doc_gia as [Tên Độc Giả],
			dg.nam_sinh as [Năm Sinh],
			dg.dia_chi as [Địa Chỉ],
			dg.so_dien_thoai as [SDT],
			dg.so_chung_minh_thu as [CMT],
			dg.han_the as [Hạn Thẻ]
	FROM doc_gia dg
END