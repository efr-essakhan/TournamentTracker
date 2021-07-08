CREATE TABLE [dbo].[TeamMember]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [TeamId] INT NOT NULL, 
    [PersonId] INT NOT NULL, 
    CONSTRAINT [FK_TeamMember_Team] FOREIGN KEY ([TeamId]) REFERENCES [Team]([Id]), 
    CONSTRAINT [FK_TeamMember_Person] FOREIGN KEY ([PersonId]) REFERENCES [Person]([Id])
)
