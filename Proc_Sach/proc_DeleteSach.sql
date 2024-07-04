CREATE PROCEDURE proc_delete_sach
    @sach_id INT
AS
BEGIN
    DELETE FROM sach
    WHERE sach_id = @sach_id;
END;