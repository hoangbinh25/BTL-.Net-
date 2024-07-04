CREATE PROCEDURE proc_insert_sach
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
    INSERT INTO sach (sach_id, loai_sach_id, nha_xb, ngon_ngu_id, ten_sach, tac_gia, so_luong, ngay_nhap, gia_bia)
    VALUES (@sach_id, @loai_sach_id, @nha_xb, @ngon_ngu_id, @ten_sach, @tac_gia, @so_luong, @ngay_nhap, @gia_bia);
END;