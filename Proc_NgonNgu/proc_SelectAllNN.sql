USE [QL_THUVIEN]
GO

ALTER PROC proc_selectAllNgonNgu
AS
BEGIN 
	SELECT ngon_ngu.ngon_ngu_id as [Mã], 
	ngon_ngu.ten_ngon_ngu as [Tên ngôn ngữ] FROM ngon_ngu 
END