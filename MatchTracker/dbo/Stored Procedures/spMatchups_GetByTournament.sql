-- Gets all the matchups for a given tournament
CREATE PROCEDURE [dbo].[spMatchups_GetByTournament]
  @TournamentId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

  select m.*
  from dbo.Matchups m
  where m.TournamentId = @TournamentId
  order by MatchupRound;

END