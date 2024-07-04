CREATE PROC proc_updateTheLoai
@matheloai int,
@tentheloai nvarchar(20)
AS 
BEGIN 
	UPDATE loai_sach
	SET ten_loai_sach = @tentheloai
	WHERE loai_sach_id = @matheloai
END