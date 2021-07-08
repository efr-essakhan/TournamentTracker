CREATE TABLE [dbo].[Matchup]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [WinnerId] INT NOT NULL, 
    [MatchupRound] INT NOT NULL, 
    CONSTRAINT [FK_Matchup_Team] FOREIGN KEY ([WinnerId]) REFERENCES [Team]([Id])
)
