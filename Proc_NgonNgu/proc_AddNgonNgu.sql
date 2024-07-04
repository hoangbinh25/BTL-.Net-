use QL_THUVIEN
go
ALTER PROC proc_AddNgonNgu
@tenngonngu nvarchar(20) 
AS 
BEGIN
	INSERT INTO ngon_ngu( ten_ngon_ngu)
	VALUES (@tenngonngu)
END