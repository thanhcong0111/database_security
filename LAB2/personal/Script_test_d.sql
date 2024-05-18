use QLBongDa

--Test BDAdmin--
select* from CAUTHU

select* from TINH

insert into TINH(MATINH, TENTINH)
values
('LD', 'Lam Dong')

--Test BDBK--
backup database QLBongDa
to disk = 'C:\LAB2\QLBongDa.bak'
with noformat, noinit, name=N'QLBongDa-Full Database Backup', skip, norewind, nounload, stats = 10
go

--Test BDRead--
select* from CAULACBO

select* from QUOCGIA

insert into TINH(MATINH, TENTINH)
values
('NT', 'Nha Trang')

update CAULACBO set MACLB = 'HAGL'
where MASAN = 'PL' and MATINH = 'GL'

--Test BDU01--
create table dbo.DOITRUONG
(
MADT char(4) primary key,
TENDT nvarchar(20)
)

--Test BDU02--
insert into SANVD(MASAN, TENSAN, DIACHI)
values
('GG', N'Hoang Gia', N'13/4 Xa Lộ Hà Nội')

delete SANVD where MASAN = 'GG'

drop table CAUTHU

create table DOITRUONG1
(
MADT char(4) primary key,
TENDT nvarchar(20)
)

--Test BDU03--
select* from dbo.CAULACBO

insert into CAULACBO(MACLB, TENCLB, MASAN, MATINH)
values
('HV', N'Hang Vuong', 'GD', 'BD')

delete CAULACBO where MACLB = 'HV'

select* from QUOCGIA

insert into TINH(MATINH, TENTINH)
values
('CT', 'Can Tho')

delete SANVD where MASAN='GD'

--Test BDU04--
select MACT, HOTEN, VITRI, DIACHI, MACLB, MAQG, SO from CAUTHU

select CAUTHU.NGAYSINH from CAUTHU

update CAUTHU set VITRI = N'Lum banh'
where MACT = 01

select* from HLV_CLB

select* from TINH