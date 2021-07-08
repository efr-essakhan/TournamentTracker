CREATE PROCEDURE [dbo].[spPrize_GetByTournament]
	@TournamentId int
AS
begin
	SET NOCOUNT ON;

	select p.*
	from dbo.Prize p
	inner join dbo.TournamentPrize t on p.Id = t.PrizeId
	where t.TournamentId = @TournamentId;

end
