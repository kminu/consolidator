
CREATE PROCEDURE [dbo].[spTestPerson_GetByLastName] 
	@LastName nvarchar(100)
AS
BEGIN
	SET NOCOUNT ON;

    select *
	from dbo.TestPerson
	where LastName = @LastName;

END