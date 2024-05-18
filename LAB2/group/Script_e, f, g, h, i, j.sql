use QLBongDa

--e--
GO
CREATE PROCEDURE SP_SEL_NO_ENCRYPT (@TenCLB NVARCHAR(100), @TENQG NVARCHAR(60))
AS
SELECT mact, hoten, ngaysinh, diachi, vitri 
FROM CAUTHU
WHERE MACLB  = ( SELECT MACLB  FROM CAULACBO WHERE TENCLB = @TenCLB 
				AND MAQG = ( SELECT MAQG FROM QUOCGIA WHERE TENQG = @TENQG )
				)


--f--
GO
CREATE PROCEDURE SP_SEL_ENCRYPT @TenCLB NVARCHAR(100), @TENQG NVARCHAR(60)
WITH ENCRYPTION 
AS
SELECT mact, hoten, ngaysinh, diachi, vitri 
FROM CAUTHU
WHERE MACLB  = ( SELECT MACLB  FROM CAULACBO WHERE TENCLB = @TenCLB 
				AND MAQG = ( SELECT MAQG FROM QUOCGIA WHERE TENQG = @TENQG )
				)

--g--
EXEC SP_SEL_NO_ENCRYPT @TenCLB = N'SHB Đà Nẵng', @TenQG = N'Brazil'
EXEC SP_SEL_ENCRYPT @TenCLB = N'SHB Đà Nẵng', @TenQG = N'Brazil'
--> Nhận xét: cả 2 đều có cùng 1 kết quả 

--h--
go
CREATE PROCEDURE EncryptAllStoredProcedures
AS
BEGIN
    DECLARE @ProcedureName NVARCHAR(500)
    DECLARE @EncryptStatement NVARCHAR(MAX)
	DECLARE ProcedureCursor CURSOR FOR
	SELECT name
	FROM sys.procedures

	OPEN ProcedureCursor

	FETCH NEXT FROM ProcedureCursor INTO @ProcedureName

	WHILE @@FETCH_STATUS = 0
	BEGIN
		SET @EncryptStatement = 'ALTER PROCEDURE ' + @ProcedureName + ' WITH ENCRYPTION'
		EXEC sp_executesql @EncryptStatement

		FETCH NEXT FROM ProcedureCursor INTO @ProcedureName
	END

CLOSE ProcedureCursor
DEALLOCATE ProcedureCursor

--Stored procedure trên được đặt tên là EncryptAllStoredProcedures.
--Stored procedure này sử dụng một con trỏ (cursor) để lặp qua tất cả các stored procedure trong cơ sở dữ liệu.
--Mỗi lần lặp, nó tạo một câu lệnh ALTER PROCEDURE với câu lệnh WITH ENCRYPTION để mã hóa stored procedure.
--Sau đó, nó thực thi câu lệnh trên bằng cách sử dụng sp_executesql.
--Quá trình này lặp lại cho tất cả các stored procedure trong cơ sở dữ liệu cho đến khi không còn stored procedure nào nữa. 

--i--
--i.1--
go
create view vCau1 as
select ct.mact, ct.hoten, ct.ngaysinh, ct.diachi, ct.vitri
from CAUTHU ct join CAULACBO clb on clb.MACLB = ct.MACLB
			   join QUOCGIA qg on qg.MAQG = ct.MAQG
where clb.TENCLB =N'SHB Đà Nẵng' and qg.TENQG = N'Brazil'

--i.2--
go
create view vCau2 as 
select td.MATRAN, td.NGAYTD, svd.TENSAN, clb1.TENCLB as TENCLB1, clb2.TENCLB as TENCLB2, td.KETQUA
from TRANDAU as td join CAULACBO as clb1 on clb1.MACLB = td.MACLB1
				   join CAULACBO as clb2 on clb2.MACLB  = td.MACLB2
				   join SANVD as svd on svd.MASAN = td.MASAN
where td.VONG = 3 and td.NAM = 2009

--i.3--
go
create view vCau3 as 
select hlv.MAHLV, hlv.TENHLV, hlv.NGAYSINH, hlv.DIACHI, hlvclb.VAITRO , clb.TENCLB
from HLV_CLB as hlvclb join HUANLUYENVIEN as hlv on hlv.MAHLV = hlvclb.MAHLV 
						  join CAULACBO as clb on clb.MACLB = hlvclb.MACLB
						  join QUOCGIA as qg on qg.MAQG = hlv.MAQG
WHERE qg.TENQG = N'Việt Nam'

--i.4--
go
create view vCau4 as 
select clb.MACLB, clb.TENCLB, svd.TENSAN, svd.DIACHI, count(ct.MACT) as SOLUONG
from CAULACBO as clb join SANVD  as svd on svd.MASAN = clb.MASAN
					 join CAUTHU as ct on ct.MACLB = clb.MACLB					
where  ct.MAQG <> ( select MAQG from QUOCGIA as qg where qg.TENQG = N'Việt Nam')
group by clb.maclb, clb.tenclb, svd.tensan, svd.DIACHI
having count(ct.MACT) > 2 

--i.5--
go
create view vCau5 as
select t.TENTINH, count(ct.mact) as PLAYER 
from TINH as t join CAULACBO as clb on clb.MATINH = t.MATINH
			   join CAUTHU as ct on ct.MACLB = clb.MACLB
where ct.MACT = (select MACT from CAUTHU where CAUTHU.VITRI = N'Tiền đạo')  
group by t.TENTINH

--i.6--
go
CREATE VIEW vCau6 AS
SELECT CAULACBO.TENCLB, TINH.TENTINH
FROM BANGXH JOIN CAULACBO ON BANGXH.MACLB = CAULACBO.MACLB
			JOIN TINH ON CAULACBO.MATINH = TINH.MATINH
WHERE BANGXH.VONG = '3' AND BANGXH.HANG = '1' AND BANGXH.NAM = 2009

--i.7--
go
CREATE VIEW vCau7 AS
SELECT hlv.TENHLV
FROM HUANLUYENVIEN hlv JOIN HLV_CLB ON hlv.MAHLV = HLV_CLB.MAHLV
WHERE hlv.MAHLV IN (SELECT MAHLV
					FROM HLV_CLB)
				AND hlv.DIENTHOAI = NULL

--i.8--
go
CREATE VIEW vCAU8 AS
SELECT hlv.TENHLV
FROM HUANLUYENVIEN hlv JOIN HLV_CLB ON hlv.MAHLV = HLV_CLB.MAHLV
						JOIN QUOCGIA ON hlv.MAQG = QUOCGIA.MAQG
WHERE hlv.MAHLV NOT IN (SELECT MAHLV
						FROM HLV_CLB)
				AND QUOCGIA.TENQG = N'Việt Nam'

--i.9--
go
CREATE VIEW vCau9 AS
SELECT DISTINCT NGAYTD, TENSAN, clb1.TENCLB AS TENCLB1, clb2.TENCLB AS TENCLB2, KETQUA
FROM TRANDAU JOIN CAULACBO AS clb1 ON TRANDAU.MACLB1 = clb1.MACLB
			JOIN CAULACBO AS clb2 ON TRANDAU.MACLB2 = clb2.MACLB
			JOIN BANGXH ON clb1.MACLB = BANGXH.MACLB OR clb2.MACLB=BANGXH.MACLB
			JOIN SANVD ON SANVD.MASAN = TRANDAU.MASAN
WHERE TRANDAU.VONG <= 3 
		AND (clb1.MACLB = (SELECT MACLB
							FROM BANGXH
							WHERE HANG = '1' AND VONG = '3' AND NAM = 2009)
				OR clb2.MACLB = (SELECT MACLB
									FROM BANGXH
									WHERE HANG = '1' AND VONG = '3' AND NAM = 2009))
GROUP BY NGAYTD, TENSAN, clb1.TENCLB, clb2.TENCLB, KETQUA

--i.10--
GO
CREATE VIEW vCau10 AS
SELECT DISTINCT NGAYTD, TENSAN, clb1.TENCLB AS TENCLB1, clb2.TENCLB AS TENCLB2, KETQUA
FROM TRANDAU JOIN CAULACBO AS clb1 ON TRANDAU.MACLB1 = clb1.MACLB
			JOIN CAULACBO AS clb2 ON TRANDAU.MACLB2 = clb2.MACLB
			JOIN BANGXH ON clb1.MACLB = BANGXH.MACLB OR clb2.MACLB = BANGXH.MACLB
			JOIN SANVD ON SANVD.MASAN = TRANDAU.MASAN
WHERE TRANDAU.VONG < 3
		AND (clb1.MACLB = (SELECT TOP 1 MACLB
							FROM BANGXH
							WHERE VONG = '3' AND NAM = 2009
							ORDER BY DIEM ASC
							)
				OR clb2.MACLB = (SELECT TOP 1 MACLB
								 FROM BANGXH
								 WHERE VONG = '3' AND NAM = 2009
								 ORDER BY DIEM ASC
								 )
							)
GROUP BY NGAYTD, TENSAN, clb1.TENCLB, clb2.TENCLB, KETQUA

 ----i. Grant view permission----
 --BDRead--
grant select,view definition to BDRead

--BDU01
grant select,view definition on vCau5 to BDU1
grant select,view definition on vCau6 to BDU1
grant select,view definition on vCau7 to BDU1
grant select,view definition on vCau8 to BDU1
grant select,view definition on vCau9 to BDU1
grant select,view definition on vCau10 to BDU1

--BDU03
grant select,view definition on vCau1 to BDU03
grant select,view definition on vCau2 to BDU03
grant select,view definition on vCau3 to BDU03
grant select,view definition on vCau4 to BDU03

--BDU04
grant select,view definition on vCau1 to BDU04
grant select,view definition on vCau2 to BDU04
grant select,view definition on vCau3 to BDU04
grant select,view definition on vCau4 to BDU04

----i. Test----
--BDRead--
SELECT * FROM vCau1
SELECT * FROM vCau5
--BDU01--
SELECT * FROM vCau2 
SELECT * FROM vCau10
--BDU03-- 
SELECT * FROM vCau1
SELECT * FROM vCau2
SELECT * FROM vCau3
SELECT * FROM vCau4
--BDU04--
SELECT * FROM vCau1
SELECT * FROM vCau2
SELECT * FROM vCau3
SELECT * FROM vCau4

--j--
--j.1--
GO
CREATE PROC SPCau1 (@TENCLB NVARCHAR(100), @TENQG NVARCHAR(60))
AS
	SELECT CT.MACT, CT.HOTEN, CT.NGAYSINH, CT.DIACHI, CT.VITRI
	FROM CAUTHU CT JOIN QUOCGIA QG ON CT.MAQG = QG.MAQG
					JOIN CAULACBO CLB ON CT.MACLB = CLB.MACLB
	WHERE CLB.TENCLB = @TENCLB AND QG.TENQG = @TENQG

--j.2--
GO
CREATE PROC SPCau2 (@VONG INT, @NAM INT)
AS
	SELECT TD.MATRAN, TD.NGAYTD, SANVD.TENSAN, CLB1.TENCLB, CLB2.TENCLB, TD.KETQUA
	FROM TRANDAU TD JOIN CAULACBO CLB1 ON TD.MACLB1 = CLB1.MACLB
					JOIN CAULACBO CLB2 ON TD.MACLB2 = CLB2.MACLB
					JOIN SANVD ON SANVD.MASAN = TD.MASAN
	WHERE TD.VONG = @VONG AND TD.NAM = @NAM

--j.3--
GO
CREATE PROC SPCau3 (@TENQG NVARCHAR(60))
AS
	SELECT HLV.MAHLV, HLV.TENHLV, HLV.NGAYSINH, HLV.DIACHI, HLV_CLB.VAITRO, CLB.TENCLB
	FROM HUANLUYENVIEN HLV JOIN HLV_CLB ON HLV.MAHLV = HLV_CLB.MAHLV
						JOIN CAULACBO CLB ON CLB.MACLB = HLV_CLB.MACLB
						JOIN QUOCGIA QG ON QG.MAQG = HLV.MAQG
	WHERE QG.TENQG = @TENQG

--j.4--
GO 
CREATE PROC SPCau4 (@TENQG NVARCHAR(60))
AS
	SELECT CLB.MACLB, CLB.TENCLB, SVD.TENSAN, SVD.DIACHI, COUNT(CT.MACT) AS SOLUONG
	FROM CAULACBO CLB JOIN SANVD SVD ON SVD.MASAN = CLB.MASAN
					JOIN CAUTHU CT ON CT.MACLB = CLB.MACLB
	WHERE CT.MAQG <> (SELECT MAQG FROM QUOCGIA QG WHERE QG.TENQG = @TENQG)
	GROUP BY CLB.MACLB, CLB.TENCLB, SVD.TENSAN, SVD.DIACHI
	HAVING COUNT(CT.MACT) > 2

--j.5--
GO
CREATE PROC SPCau5 (@VITRI NVARCHAR(20))
AS
	SELECT T.TENTINH, COUNT(CT.MACT) AS SOLUONG
	FROM TINH T JOIN CAULACBO CLB ON CLB.MATINH = T.MATINH
				JOIN CAUTHU CT ON CT.MACLB = CLB.MACLB
	WHERE CT.MACT = (SELECT MACT FROM CAUTHU WHERE CAUTHU.VITRI = @VITRI)
	GROUP BY T.TENTINH

--j.6--
GO
CREATE PROC SPCau6 (@VONG INT, @NAM INT)
AS
	SELECT CLB.TENCLB, T.TENTINH
	FROM BANGXH BXH JOIN CAULACBO CLB ON BXH.MACLB = CLB.MACLB
					JOIN TINH T ON CLB.MATINH = T.MATINH
	WHERE BXH.VONG = @VONG AND BXH.NAM = @NAM AND BXH.HANG = '1'

--j.7--
GO
CREATE PROC SPCau7
AS
	SELECT HLV.TENHLV
	FROM HUANLUYENVIEN HLV JOIN HLV_CLB ON HLV.MAHLV = HLV_CLB.MAHLV
	WHERE HLV.MAHLV IN (SELECT MAHLV FROM HLV_CLB) AND HLV.DIENTHOAI = NULL
	
--j.8--
GO
CREATE PROC SPCau8 (@TENQG NVARCHAR(60))
AS
	SELECT HLV.TENHLV 
	FROM HUANLUYENVIEN HLV JOIN HLV_CLB ON HLV.MAHLV = HLV_CLB.MAHLV
				JOIN QUOCGIA QG ON HLV.MAQG = QG.MAQG
	WHERE HLV.MAHLV NOT IN (SELECT MAHLV FROM HLV_CLB)
					AND QG.TENQG = @TENQG

--j.9--
GO
CREATE PROC SPCau9 @VONG INT, @NAM INT
AS
	SELECT DISTINCT TD.NGAYTD, SVD.TENSAN, CLB1.TENCLB AS TENCLB1, CLB2.TENCLB AS TENCLB2, TD.KETQUA
	FROM TRANDAU TD JOIN CAULACBO CLB1 ON TD.MACLB1 = CLB1.MACLB
					JOIN CAULACBO CLB2 ON TD.MACLB2 = CLB2.MACLB
					JOIN BANGXH BXH ON CLB1.MACLB = BXH.MACLB OR CLB2.MACLB = BXH.MACLB
					JOIN SANVD SVD ON SVD.MASAN = TD.MASAN
	WHERE TD.VONG <= @VONG 
			AND (CLB1.MACLB = (SELECT MACLB FROM BANGXH WHERE HANG = '1' AND VONG = @VONG AND NAM = @NAM)
					OR CLB2.MACLB = (SELECT MACLB FROM BANGXH WHERE HANG = '1' AND VONG = @VONG AND NAM = @NAM)
				)
	GROUP BY TD.NGAYTD, SVD.TENSAN, CLB1.TENCLB, CLB2.TENCLB, TD.KETQUA

--j.10--
GO
CREATE PROC SPCau10 @VONG INT, @NAM INT
AS
	SELECT DISTINCT TD.NGAYTD, SVD.TENSAN, CLB1.TENCLB AS TENCLB1, CLB2.TENCLB AS TENCLB2, TD.KETQUA
	FROM TRANDAU TD JOIN CAULACBO CLB1 ON TD.MACLB1 = CLB1.MACLB
					JOIN CAULACBO CLB2 ON TD.MACLB2 = CLB2.MACLB
					JOIN BANGXH BXH ON CLB1.MACLB = BXH.MACLB OR CLB2.MACLB = BXH.MACLB
					JOIN SANVD SVD ON SVD.MASAN = TD.MASAN
	WHERE TD.VONG < @VONG 
			AND (CLB1.MACLB = (SELECT TOP 1 MACLB 
								FROM BANGXH 
								WHERE VONG = @VONG AND NAM = @NAM
								ORDER BY DIEM ASC)
					OR CLB2.MACLB = (SELECT TOP 1 MACLB 
									FROM BANGXH 
									WHERE VONG = @VONG AND NAM = @NAM
									ORDER BY DIEM ASC)
				)
	GROUP BY TD.NGAYTD, SVD.TENSAN, CLB1.TENCLB, CLB2.TENCLB, TD.KETQUA

--j. GRANT STORE PROCEDURE PERMISSION--

--BDRead--
grant execute to BDRead

--BDU01
grant execute on object::SPCau5 to BDU1
grant execute on object::SPCau6 to BDU1
grant execute on object::SPCau7 to BDU1
grant execute on object::SPCau8 to BDU1
grant execute on object::SPCau9 to BDU1
grant execute on object::SPCau10 to BDU1

--BDU03
grant execute on object::SPCau1 to BDU03
grant execute on object::SPCau2 to BDU03
grant execute on object::SPCau3 to BDU03
grant execute on object::SPCau4 to BDU03

--BDU04
grant execute on object::SPCau1 to BDU04
grant execute on object::SPCau2 to BDU04
grant execute on object::SPCau3 to BDU04
grant execute on object::SPCau4 to BDU04

--test SP--
--BDRead--
exec SPCau1 N'SHB Đà Nẵng', N'Brazil'
exec SPCau9 3, 2009

--BDU01--
exec SPCau3 N'Việt Nam'
exec SPCau10 3, 2009

--BDU03--
exec SPCau1 N'SHB Đà Nẵng', N'Brazil'
exec SPCau3 N'Việt Nam'
exec SPCau4 N'Việt Nam'
exec SPCau10 3, 2009

--BDU04--
exec SPCau1 N'SHB Đà Nẵng', N'Brazil'
exec SPCau3 N'Việt Nam'
exec SPCau4 N'Việt Nam'
exec SPCau10 3, 2009