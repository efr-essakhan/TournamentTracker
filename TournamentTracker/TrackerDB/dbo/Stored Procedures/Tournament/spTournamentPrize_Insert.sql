CREATE PROCEDURE [dbo].[spTournamentPrize_Insert]
	@PrizeId int,
	@TournamentId int,
	@Id int=0 output
AS
BEGIN

	SET NOCOUNT ON;

	INSERT INTO dbo.TournamentPrize (PrizeId, TournamentId)
	VALUES (@PrizeId, @TournamentId)

	select @Id = SCOPE_IDENTITY();

END
GO
