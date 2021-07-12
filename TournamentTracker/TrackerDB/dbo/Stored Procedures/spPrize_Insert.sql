CREATE PROCEDURE [dbo].[spPrize_Insert]
	@PlaceNumber int,
	@PlaceName nvarchar(50),
	@PrizeAmount money,
	@PrizePercentage float,
	@id int = 0 output

AS
BEGIN
	SET NOCOUNT ON;
	insert into dbo.Prize (PlaceNumber, PlaceName, PrizeAmount, PrizePercentage)
	values (@PlaceNumber, @PlaceName, @PrizeAmount, @PrizeAmount)

	select @id = SCOPE_IDENTITY();
END
GO
