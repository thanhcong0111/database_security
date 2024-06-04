﻿/*--------------------------------------------------
MASV: 21120419
HO TEN: VŨ THÀNH CÔNG 
LAB: 03
NGAY: 24/4/2024 
--------------------------------------------------*/
--CAU LENH TAO DB
USE MASTER
CREATE DATABASE QLSV
GO

/*--------------------------------------------------
MASV: 21120419
HO TEN: VŨ THÀNH CÔNG 
LAB: 03
NGAY: 24/4/2024 
--------------------------------------------------*/
USE QLSV
GO
--CAC CAU LENH TAO TABLE
CREATE TABLE NHANVIEN
(
	MANV VARCHAR(20) NOT NULL PRIMARY KEY,
	HOTEN NVARCHAR(100) NOT NULL,
	EMAIL VARCHAR(20),
	LUONG VARBINARY(MAX),
	TENDN NVARCHAR(100) NOT NULL,
	MATKHAU VARBINARY(MAX) NOT NULL
);

CREATE TABLE LOP
(
	MALOP VARCHAR(20) NOT NULL PRIMARY KEY,
	TENLOP NVARCHAR(100) NOT NULL,
	MANV VARCHAR(20) FOREIGN KEY REFERENCES NHANVIEN(MANV)
)

CREATE TABLE SINHVIEN
(
	MASV NVARCHAR(20) NOT NULL PRIMARY KEY,
	HOTEN NVARCHAR(100) NOT NULL,
	NGAYSINH DATETIME,
	DIACHI NVARCHAR(200),
	MALOP VARCHAR(20) FOREIGN KEY REFERENCES LOP(MALOP),
	TENDN NVARCHAR(100) NOT NULL,
	MATKHAU VARBINARY(MAX) NOT NULL
);

/*--------------------------------------------------
MASV: 21120419
HO TEN: VŨ THÀNH CÔNG 
LAB: 03
NGAY: 24/4/2024 
--------------------------------------------------*/
--CAU LENH TAO STORED PROCEDURE
--SP_INS_SINHVIEN
GO
CREATE PROC SP_INS_SINHVIEN
(
	@MASV NVARCHAR(20),
	@HOTEN NVARCHAR(100),
	@NGAYSINH DATETIME,
	@DIACHI NVARCHAR(200),
	@MALOP VARCHAR(20),
	@TENDN NVARCHAR(100),
	@MATKHAU VARCHAR(32)
)
AS
	DECLARE @ENKEY VARBINARY(MAX)
	SET @ENKEY = CONVERT(VARBINARY, HASHBYTES('MD5', @MATKHAU));
	INSERT INTO SINHVIEN
	VALUES (@MASV, @HOTEN, @NGAYSINH, @DIACHI, @MALOP, @TENDN, @ENKEY)

--SP_INS_NHANVIEN
--TAO MASTERKEY
IF NOT EXISTS 
(
	SELECT*
	FROM SYS.symmetric_keys
	WHERE symmetric_key_id = 101
)
CREATE MASTER KEY ENCRYPTION BY PASSWORD = '21120419'
GO

--TAO CERTIFICATE
IF NOT EXISTS
(
	SELECT*
	FROM sys.certificates
	WHERE NAME = 'MYCERTT'
)
CREATE CERTIFICATE MYCERTT WITH SUBJECT = 'MYCERTT'
GO

--TAO SYMMETRIC KEY
IF NOT EXISTS
(
	SELECT*
	FROM sys.symmetric_keys
	WHERE NAME = 'PRIKEY'
)
CREATE SYMMETRIC KEY PRIKEY WITH ALGORITHM = AES_256
	ENCRYPTION BY CERTIFICATE MYCERTT;

GO
CREATE PROC SP_INS_NHANVIEN
(
	@MANV VARCHAR(20),
	@HOTEN NVARCHAR(100),
	@EMAIL VARCHAR(20),
	@LUONG INT,
	@TENDN NVARCHAR(100),
	@MATKHAU VARCHAR(32)
)
AS
	DECLARE @ENPASS VARBINARY(MAX);
	DECLARE @ENSALARY VARBINARY(MAX)
	SET @ENPASS = CONVERT(VARBINARY, HASHBYTES('SHA1', @MATKHAU))
	SET @ENSALARY = ENCRYPTBYKEY(KEY_GUID('PRIKEY'), CONVERT(VARBINARY(MAX), @LUONG))
	INSERT INTO NHANVIEN(MANV, HOTEN, EMAIL, LUONG, TENDN, MATKHAU)
	VALUES (@MANV, @HOTEN, @EMAIL, @ENSALARY, @TENDN, @ENPASS);

--TAO SP_SEL_NHANVIEN
GO
CREATE PROC SP_SEL_NHANVIEN
AS
	OPEN SYMMETRIC KEY PRIKEY
	DECRYPTION BY CERTIFICATE MYCERTT
	SELECT MANV, HOTEN, EMAIL, CONVERT(INT, DECRYPTBYKEY(LUONG)) AS LUONGCB
	FROM NHANVIEN

EXEC SP_INS_NHANVIEN 'NV01', N'NGUYEN DINH THUC', 'NGTHUC@MAIL.COM', 30000, N'NDT', 'NDT@1'
EXEC SP_INS_NHANVIEN 'NV02', N'NGUYEN THI HUONG', 'NTHUONG@MAIL.COM', 20000, N'NTH', 'NTT@2'
EXEC SP_INS_NHANVIEN 'NV03', N'TRAN NGOC BAO', 'TNBAO@MAIL.COM', 20000, N'TNB', N'TNB@3'
delete from NHANVIEN where manv = 'NV01'
delete from NHANVIEN where manv = 'NV02'
delete from NHANVIEN where manv = 'NV03'

INSERT INTO LOP VALUES('CNTT-K21', N'CÔNG NGHỆ THÔNG TIN KHÓA 21', 'NV01');
INSERT INTO LOP VALUES('CNTT-K35', N'CÔNG NGHỆ THÔNG TIN KHÓA 35', 'NV02');
INSERT INTO LOP VALUES('CNTT-K46', N'CÔNG NGHỆ THÔNG TIN KHÓA 46', 'NV03');

EXEC SP_INS_SINHVIEN '21120419', N'VŨ THÀNH CÔNG', '1/1/2003', N'LÂM ĐỒNG', 'CNTT-K21', '21120419', 'abcd419';
EXEC SP_INS_SINHVIEN '35120001', N'CÔNG THÀNH VŨ', '11/11/2017', N'LONG AN', 'CNTT-K35', '35120001', 'abcd001';
EXEC SP_INS_SINHVIEN '46120030', N'VŨ CÔNG', '12/12/2028', N'ĐỒNG THÁP', 'CNTT-K46', '46120030', 'abcd030';

select* from sinhvien order by masv

select*from NHANVIEN

exec SP_SEL_NHANVIEN