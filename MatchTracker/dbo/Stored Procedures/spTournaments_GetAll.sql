-- Gets all the tournaments in the database that are active
CREATE PROCEDURE [dbo].[spTournaments_GetAll]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

  select *
  from dbo.Tournaments
  where Active = 1;

END