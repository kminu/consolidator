-- Gets the current teams for a given tournament
CREATE PROCEDURE [dbo].[spTeam_GetByTournament]
	@TournamentId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

  select t.*
  from dbo.Teams t
  inner join dbo.TournamentEntries e on t.id = e.TeamId
  where e.TournamentId = @TournamentId;

END