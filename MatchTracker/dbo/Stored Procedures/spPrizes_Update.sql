
CREATE PROCEDURE dbo.spPrizes_Update
	@id int,
	@PlaceNumber int,
	@PlaceName nvarchar(50),
	@PrizeAmount money,
	@PrizePercentage float
AS
BEGIN
	SET NOCOUNT ON;
	
	update dbo.Prizes
	set
	PlaceNumber =  @PlaceNumber,
	PlaceName =  @PlaceName,
	PrizeAmount =  @PrizeAmount,
	PrizePercentage =  @PrizePercentage
	where id = @id

END