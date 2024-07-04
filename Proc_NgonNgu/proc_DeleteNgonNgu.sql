use QL_THUVIEN
go
CREATE PROC proc_DeleteNgonNgu
@mangonngu int
AS 
BEGIN
DELETE FROM ngon_ngu WHERE ngon_ngu_id = @mangonngu
END