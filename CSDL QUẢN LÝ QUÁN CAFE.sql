REATE DATABASE QuanLyQuanCafe
GO

use QuanlyQuanCafe
go

--Food
--Table
--Foodcategory
--Account
--Bill
--BillInfo

create table TableFood
(
	id INT IDENTITY PRIMARY KEY,
	name nvarchar(100)NOT NULL default 'Bàn chưa có tên',
	status  nvarchar(100) NOT NULL default N'Trống'		-- trống || có người 
)
go

create table Account
(
	userName NVARCHAR(100) primary key,
	disPlayname nvarchar(100) NOT NULL default N'Chưa đặt tên',
	password nvarchar(1000)NOT NULL default 0,
	type int NOT NULL	--1 la admin,0 laf staff
)
go

CREATE table FoodCategory
(
	id INT IDENTITY PRIMARY KEY,
	name nvarchar(100) not null default N'Chưa đặt tên'
)
go

CREATE table Food
(
	id INT IDENTITY PRIMARY KEY,
	name nvarchar(100) NOT NULL default N'Chưa đặt tên',
	idcategory int NOT NULL,
	price float not null

	foreign key (idcategory) references dbo.foodcategory(id)
)
go

CREATE table Bill
(
	id INT IDENTITY PRIMARY KEY,
	datecheckin date not null default getdate(),
	datecheckout date not null,
	idtable int not null,
	status int not null default 0	--1 là đã thanh toán, 0 là chưa thanh toán 

	foreign key (idtable) references dbo.tablefood(id)
)
go

CREATE table Billinfo
(
	id INT IDENTITY PRIMARY KEY,
	idbill int not null,
	idfood int not null,
	count int not null default 0

	foreign key (idbill) references dbo.Bill(id),
	foreign key (idfood) references dbo.Food(id)
)
go

insert into dbo.Account
(
	userName,
	disPlayname,
	password,
	type
)
values
(	
	N'admin',--username
	N'admin',-- displayname
	N'1',--password
	1 --type
)
insert into dbo.Account
(
	userName,
	displayName,
	password,
	type
)
values
(	
	N'staff',--username
	N'staff',-- displayname
	N'1',--password	
	0 --type
)
go


create proc USP_GetAccountByUserName
@UserName nvarchar(100)
as
begin
	select * from dbo.Account where userName=@UserName
end
go

exec dbo.USP_GetAccountByUserName @UserName = N'admin'
SELECT * FROM dbo.Account where userName = N'admin' and password = N'1'
go

create proc USP_Login
@userName nvarchar(100), @passWord nvarchar(100)
as
begin
	select * from dbo.Account where UserName = @userName and PassWord = @passWord
end
go

--thêm bàn
Declare @i Int = 0

While @i <= 10
BEGIN
	INSERT dbo.TableFood (name)Values (N'Bàn ' + cast(@i as nvarchar(100)))
	SET @i = @i + 1
END
GO

CREATE PROC USP_GetTableList
AS SELECT * FROM dbo.TableFood
GO

UPDATE dbo.TableFood SET STATUS = N'Có người' WHERE id = 9

EXEC dbo.USP_GetTableList
Go

--thêm category
INSERT dbo.Bill
(datecheckin, datecheckout, idtable, status)
VALUES (GETDATE(), GETDATE(), 184, 0) --1 đã check out, 0 chưa checkout)


INSERT dbo.Bill
(datecheckin, datecheckout, idtable, status)
VALUES (GETDATE(), GETDATE(), 185, 0) --1 đã check out, 0 chưa checkout)

INSERT dbo.Bill
(datecheckin, datecheckout, idtable, status)
VALUES (GETDATE(), GETDATE(), 186, 1) --1 đã check out, 0 chưa checkout)

--thên bill info
INSERT dbo.Billinfo
(idbill, idfood, count)
Values (4, 1, 2)

INSERT dbo.Billinfo
(idbill, idfood, count)
Values (4, 3, 4)

INSERT dbo.Billinfo
(idbill, idfood, count)
Values (4, 5, 1)


INSERT dbo.Billinfo
(idbill, idfood, count)
Values (5, 1, 2)

INSERT dbo.Billinfo
(idbill, idfood, count)
Values (5, 6, 2)

INSERT dbo.Billinfo
(idbill, idfood, count)
Values (6, 5, 2)

SELECT * FROM dbo.Billinfo WHERE idbill = 5
SELECT f.name, bi.count, f.price, f.price * bi.count as totalPrice FROM dbo.Billinfo as bi, dbo.Bill as b, dbo.Food as f
Where bi.idbill = b.id AND bi.idfood = f.id AND b.idtable = 184

SELECT * FROM dbo.Bill
SELECT * From dbo.Billinfo

