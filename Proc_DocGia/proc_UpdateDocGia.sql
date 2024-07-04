
use QL_THUVIEN
go
ALTER PROC proc_UpdateDocGia 
@MaDocGia int,
@TenDocGia nvarchar(100),
@NamSinh date,
@DiaChi nvarchar(100),
@SoDienThoai varchar(30),
@SoCMT varchar(50),
@HanThe nvarchar(20)
AS
BEGIN
	UPDATE doc_gia
    SET
        ten_doc_gia = @TenDocGia,
        nam_sinh = @NamSinh,
        dia_chi = @DiaChi,
        so_dien_thoai = @SoDienThoai,
        so_chung_minh_thu = @SoCMT,
        han_the = @HanThe
    WHERE doc_gia_id = @MaDocGia;
END