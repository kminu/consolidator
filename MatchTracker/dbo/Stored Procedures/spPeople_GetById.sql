
CREATE PROCEDURE dbo.spPeople_GetById 
	@id int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT top 5 * from dbo.People where id = @id;
END