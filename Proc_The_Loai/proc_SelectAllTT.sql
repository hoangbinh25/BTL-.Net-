USE [QL_THUVIEN]
GO

CREATE PROC pro_selectAllTheLoai
AS
BEGIN 
	SELECT ls.loai_sach_id as [Mã], 
	ls.ten_loai_sach as [Tên Loại Sách] FROM loai_sach ls
END