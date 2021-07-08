CREATE TABLE [dbo].[Person]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [FirstName] NVARCHAR(50) NOT NULL, 
    [LastName] NVARCHAR(50) NOT NULL, 
    [EmailAddres] NVARCHAR(200) NOT NULL, 
    [CellphoneNumber] NVARCHAR(20) NULL
)
