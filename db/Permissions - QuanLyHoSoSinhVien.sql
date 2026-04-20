USE Quan_Ly_Ho_So_Sinh_Vien;

-- Tạo vai trò cho các đối tượng người dùng
CREATE ROLE QuanTriVien;
GO

CREATE ROLE CanBoPhongCTSV;
GO

CREATE ROLE GiangVien;
GO

CREATE ROLE SinhVien;
GO

-- Quyền hạn của vai trò QuanTriVien
GRANT SELECT, INSERT, UPDATE, DELETE
	ON SCHEMA::dbo
	TO QuanTriVien;

-- Quyền hạn của vai trò CanBoPhongCTSV
GRANT SELECT, INSERT, UPDATE
	ON SinhVien
	TO CanBoPhongCTSV;

-- Quyền hạn của vai trò GiangVien
GRANT SELECT
	ON SinhVien
	TO GiangVien;

-- Quyền hạn của vai trò SinhVien
GRANT SELECT, UPDATE
	ON SinhVien
	TO SinhVien;

-- Gán hoặc thu hồi vai trò cho người dùng
-- ALTER ROLE <Vai Trò> ADD MEMBER <Tên người dùng>;
-- ALTER ROLE <Vai Trò> DROP MEMBER <Tên người dùng>;

-- Hiển thị các vai trò đã có
SELECT
    name,
    principal_id,
    type_desc,
    create_date,
    modify_date
FROM sys.database_principals
WHERE type = 'R'
ORDER BY name;

-- Hiển thị thành viên của vai trò
SELECT
    r.name AS role_name,
    m.name AS member_name,
    m.type_desc AS member_type
FROM sys.database_role_members drm
JOIN sys.database_principals r ON drm.role_principal_id = r.principal_id
JOIN sys.database_principals m ON drm.member_principal_id = m.principal_id
ORDER BY r.name, m.name;

-- Hiển thị vai trò của một người dùng cụ thể
DECLARE @UserName sysname = N''; -- Có thể thay bằng tên người dùng trong csdl
SELECT
    r.name AS role_name
FROM sys.database_role_members drm
JOIN sys.database_principals r ON drm.role_principal_id = r.principal_id
JOIN sys.database_principals m ON drm.member_principal_id = m.principal_id
WHERE m.name = @UserName
ORDER BY r.name;