-- store procedure to insert a new inventory line
[USE CarStoreDb]

CREATE PROCEDURE dbo.insertNewInventoryCar
	@brand nvarchar(50),
	@model nvarchar(50),
	@year nvarchar(5),
	@price money
AS
BEGIN
	insert into dbo.Inventory(Brand, Model, Year, Price)
	values(@brand, @model, @year, @price)
END
GO
