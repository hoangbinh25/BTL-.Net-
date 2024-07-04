use QL_THUVIEN
go
ALTER PROC proc_updateNgonNgu 
@mangonngu int,
@tenngonngu nvarchar(20)
AS 
BEGIN 
	UPDATE ngon_ngu
	SET ten_ngon_ngu = @tenngonngu
	WHERE ngon_ngu_id = @mangonngu
END