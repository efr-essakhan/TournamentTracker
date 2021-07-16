CREATE PROCEDURE [dbo].[spTeam_Insert]
	@TeamName nvarchar(50),
	@Id int=0 output
AS
BEGIN
	SET NOCOUNT ON;

	insert into dbo.Team (TeamName)
	values (@TeamName);

	select @Id =  SCOPE_IDENTITY();

END
GO
