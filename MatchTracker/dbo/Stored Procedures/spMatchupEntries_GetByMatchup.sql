-- Gets all the matchups for a given tournament
CREATE PROCEDURE [dbo].[spMatchupEntries_GetByMatchup]
  @MatchupId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

  select *
  from MatchupEntries
  where MatchupId = @MatchupId;

END