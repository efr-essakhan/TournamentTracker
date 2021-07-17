CREATE PROCEDURE [dbo].[spTeamMember_GetByTeam]
	@TeamId int
AS
BEGIN
	SET NOCOUNT ON;

	SELECT p.*
	from dbo.TeamMember m inner join dbo.Person p 
	on m.PersonId = p.Id
	where m.TeamId = @TeamId
END
GO
