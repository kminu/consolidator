

CREATE PROCEDURE dbo.spPeople_Update
	@FirstName nvarchar(50),
	@LastName nvarchar(50),
	@EmailAddress nvarchar(50),
	@CellphoneNumber nvarchar(50),
	@Id int

AS
BEGIN

	SET NOCOUNT ON;

	Update People
	set
	FirstName=@FirstName,
	LastName=@LastName,
	EmailAddress=@EmailAddress,
	CellphoneNumber=@CellphoneNumber
	where Id = @Id
END