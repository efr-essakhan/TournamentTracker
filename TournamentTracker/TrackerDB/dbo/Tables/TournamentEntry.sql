CREATE TABLE [dbo].[TournamentEntry]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [TournamentId] INT NOT NULL, 
    [TeamId] INT NOT NULL, 
    CONSTRAINT [FK_TournamentEntry_Tournament] FOREIGN KEY ([TournamentId]) REFERENCES [Tournament]([Id]), 
    CONSTRAINT [FK_TournamentEntry_Team] FOREIGN KEY ([TeamId]) REFERENCES [Team]([Id])
)
