ALTER PROCEDURE proc_edit_sach
    @sach_id INT,
    @loai_sach_id INT,
    @nha_xb NVARCHAR(100),
    @ngon_ngu_id INT,
    @ten_sach NVARCHAR(100),
    @tac_gia NVARCHAR(100),
    @so_luong INT,
    @ngay_nhap DATE,
    @gia_bia FLOAT
AS
BEGIN
    UPDATE sach
    SET 
        loai_sach_id = @loai_sach_id,
        nha_xb = @nha_xb,
        ngon_ngu_id = @ngon_ngu_id,
        ten_sach = @ten_sach,
        tac_gia = @tac_gia,
        so_luong = @so_luong,
        ngay_nhap = @ngay_nhap,
        gia_bia = @gia_bia
    WHERE sach_id = @sach_id;
END;