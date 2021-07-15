CREATE PROCEDURE [dbo].[spPerson_Insert]
	@FirstName nvarchar(50),
	@LastName nvarchar(50),
	@EmailAddress nvarchar(200),
	@CellphoneNumber nvarchar(20),
	@Id int = 0 output

AS
BEGIN

	SET NOCOUNT ON;
	insert into dbo.Person (FirstName, LastName, EmailAddress, CellphoneNumber)
	values (@FirstName, @LastName, @EmailAddress, @CellphoneNumber)

	select @Id = SCOPE_IDENTITY();

END
GO