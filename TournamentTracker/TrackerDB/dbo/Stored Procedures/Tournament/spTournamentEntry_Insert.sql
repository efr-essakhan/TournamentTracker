CREATE PROCEDURE [dbo].[spTournamentEntry_Insert]
	@TeamId int,
	@TournamentId int,
	@Id int=0 output
AS
BEGIN

	SET NOCOUNT ON;

	INSERT INTO dbo.TournamentEntry (TeamId, TournamentId)
	VALUES (@TeamId, @TournamentId)

	select @Id = SCOPE_IDENTITY();

END
GO
