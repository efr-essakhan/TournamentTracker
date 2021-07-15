CREATE PROCEDURE [dbo].[spPerson_GetAll]

AS
BEGIN
	SET NOCOUNT ON;
	SELECT [Id], [FirstName], [LastName], [EmailAddress], [CellphoneNumber] FROM dbo.Person
END
GO
