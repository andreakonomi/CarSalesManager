USE CarStoreDb

CREATE PROCEDURE dbo.AddSaleRecord
	@customerName nvarchar(50),
	@phoneNo nvarchar(30),
	@address nvarchar(50),
	@zipCodeCity nvarchar(50),
	@carFullModel nvarchar(50),
	@priceSold money

AS
BEGIN
	insert into dbo.Sales
	(Customer, PhoneNo, Address, ZipCodeCity, DateSold, CarModel, PriceSold)
	values(@customerName, @phoneNo, @address, @zipCodeCity, GETDATE(), @carFullModel, @priceSold)
END
GO
