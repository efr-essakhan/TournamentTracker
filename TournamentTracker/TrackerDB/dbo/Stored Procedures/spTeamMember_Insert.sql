CREATE PROCEDURE [dbo].[spTeamMember_Insert]
	@TeamId int,
	@PersonId int, 
	@Id int=0 output
AS
BEGIN
	SET NOCOUNT ON;

	insert into dbo.TeamMember(TeamId, PersonId)
	values (@TeamId, @PersonId);

	select @Id = SCOPE_IDENTITY();


END
GO
