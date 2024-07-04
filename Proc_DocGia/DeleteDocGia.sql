use QL_THUVIEN
go
CREATE PROC proc_DeleteDocGia
@MaDocGia int
AS 
BEGIN
DELETE FROM doc_gia WHERE doc_gia_id = @MaDocGia
END