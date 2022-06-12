CREATE PROCEDURE dbo.RemoveCarFromInventory
	@carId int
AS
BEGIN
	delete from dbo.Inventory
	where Id = @carId
END
GO
