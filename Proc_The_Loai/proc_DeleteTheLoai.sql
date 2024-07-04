CREATE PROC proc_DeleteTheLoai
@maloaisach int
AS 
BEGIN
DELETE FROM loai_sach WHERE loai_sach_id = @maloaisach
END