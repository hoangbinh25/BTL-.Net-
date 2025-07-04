USE [QL_THUVIEN]
GO
/****** Object:  StoredProcedure [dbo].[proc_InsertDocGia]    Script Date: 7/3/2024 5:09:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROC [dbo].[proc_InsertDocGia] 
@MaDocGia int,
@TenDocGia nvarchar(100),
@NamSinh date,
@DiaChi nvarchar(100),
@SoDienThoai varchar(30),
@SoCMT varchar(50),
@HanThe nvarchar(20)
AS
BEGIN
	INSERT INTO doc_gia (doc_gia_id, ten_doc_gia, nam_sinh, dia_chi, so_dien_thoai, so_chung_minh_thu, han_the)
	VALUES (@MaDocGia, @TenDocGia, @NamSinh, @DiaChi, @SoDienThoai, @SoCMT, @HanThe)
END