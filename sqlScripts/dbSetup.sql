-- first execute db creation
create database CarStoreDb;

-- second create tables
create table CarStoreDb.dbo.Inventory(
	Id int primary key identity(1,1),
	Brand nvarchar(50) not null,
	Model nvarchar(50) not null,
	Year nvarchar(5),
	Price money not null
	);

create table CarStoreDb.dbo.Sales(
	Id int primary key identity(1,1),
	Customer nvarchar(50) not null,
	PhoneNo nvarchar(30),
	Address nvarchar(50),
	ZipCodeCity nvarchar(50),
	DateSold datetime2 not null,
	CarModel nvarchar(50),
	PriceSold money not null
);

