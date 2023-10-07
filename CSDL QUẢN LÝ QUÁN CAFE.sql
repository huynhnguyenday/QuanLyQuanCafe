CREATE DATABASE QuanLyQuanCafe
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
	username NVARCHAR(100) primary key,
	displayname nvarchar(100) NOT NULL default N'Chưa đặt tên',
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
	username,
	displayname,
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
	username,
	displayname,
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
 select * from dbo.Account