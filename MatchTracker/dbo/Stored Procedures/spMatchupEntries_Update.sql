
CREATE PROCEDURE [dbo].[spMatchupEntries_Update] 
	@id int,
	@TeamCompetingId int = null,
	@Score float = null
AS
BEGIN
	SET NOCOUNT ON;

    update dbo.MatchupEntries
	set TeamCompetingId = @TeamCompetingId, Score = @Score
	where id = @id;
END