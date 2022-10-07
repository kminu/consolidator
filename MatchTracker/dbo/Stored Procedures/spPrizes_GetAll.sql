-- Gets all the prizes for a given tournament
CREATE PROCEDURE [dbo].[spPrizes_GetAll]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

  select *
  from dbo.Prizes;

END