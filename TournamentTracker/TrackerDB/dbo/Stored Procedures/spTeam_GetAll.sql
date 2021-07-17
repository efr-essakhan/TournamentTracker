CREATE PROCEDURE [dbo].[spTeam_GetAll]

AS
BEGIN
	SET NOCOUNT ON;
	SELECT [Id], [TeamName] FROM dbo.Team;
END
GO
