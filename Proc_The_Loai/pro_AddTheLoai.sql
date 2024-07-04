ALTER PROC proc_AddTheLoai
@tentheloai nvarchar(20) 
AS 
BEGIN
	INSERT INTO loai_sach(ten_loai_sach)
	VALUES (@tentheloai)
END