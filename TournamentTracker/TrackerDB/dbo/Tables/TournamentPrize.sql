CREATE TABLE [dbo].[TournamentPrize]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [PrizeId] INT NOT NULL, 
    [TournamentId] INT NOT NULL, 
    CONSTRAINT [FK_TournamentPrize_Prize] FOREIGN KEY ([PrizeId]) REFERENCES [Prize]([Id]), 
    CONSTRAINT [FK_TournamentPrize_Tournament] FOREIGN KEY ([TournamentId]) REFERENCES [Tournament]([Id])
)
