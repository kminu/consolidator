
CREATE PROCEDURE dbo.spPrizes_GetById
	@id int
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	select top 2 *
	from dbo.Prizes
	where id = @id;

END