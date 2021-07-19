CREATE PROCEDURE [dbo].[spTournament_Insert]
	@TournamentName nvarchar(100),
	@EntryFee money,
	@Id int=0 output
AS
BEGIN

	SET NOCOUNT ON;

	insert into dbo.Tournament (TournamentName, EntryFee, Active)
	values (@TournamentName, @EntryFee, 1);

	select @Id = SCOPE_IDENTITY();

END
GO
