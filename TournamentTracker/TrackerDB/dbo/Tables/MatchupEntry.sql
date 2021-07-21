CREATE TABLE [dbo].[MatchupEntry]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [MatchupId] INT NOT NULL, 
    [ParentMatchupId] INT NULL, 
    [TeamCompetingId] INT NULL, 
    [Score] FLOAT NULL, 
    CONSTRAINT [FK_MatchupEntry_Matchup] FOREIGN KEY ([MatchupId]) REFERENCES [Matchup]([Id]), 
    CONSTRAINT [FK_MatchupEntry_parentMatchup] FOREIGN KEY ([parentMatchupId]) REFERENCES [Matchup]([Id]), 
    CONSTRAINT [FK_MatchupEntry_Team] FOREIGN KEY ([TeamCompetingId]) REFERENCES [Team]([Id])
)
