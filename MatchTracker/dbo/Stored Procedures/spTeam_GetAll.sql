
CREATE PROCEDURE [dbo].[spTeam_GetAll] 
AS
BEGIN
	SET NOCOUNT ON;

    select *
	from dbo.Teams;

END