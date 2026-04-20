USE Quan_Ly_Ho_So_Sinh_Vien;
GO

-- Sao lưu CSDL
-- Thêm đường dẫn để sao lưu. Đường dẫn đến tệp .bak
-- Ví dụ: D:\DB\backup.bak
BACKUP DATABASE [YourDB] TO DISK = N'' WITH INIT, COPY_ONLY;

-- Khôi phục CSDL
-- Thêm đường dẫn đến tệp .bak để khôi phục
-- Ví dụ: D:\DB\backup.bak
RESTORE DATABASE [YourDB] FROM DISK = N'' WITH REPLACE;