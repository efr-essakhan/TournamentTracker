CREATE TABLE [dbo].[Tournament]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [TournamentName] NVARCHAR(100) NOT NULL, 
    [EntryFee] MONEY NOT NULL
)
