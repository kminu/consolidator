
CREATE PROCEDURE [dbo].[TestProcedure]

@FirstName varchar (50)

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	select top 10 * from People
	where FirstName = @FirstName

END