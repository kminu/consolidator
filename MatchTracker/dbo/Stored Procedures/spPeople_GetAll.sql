-- Gets all the people in the database
CREATE PROCEDURE [dbo].[spPeople_GetAll]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

  select *
  from People;

END