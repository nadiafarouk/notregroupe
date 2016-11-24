CREATE TABLE [dbo].[Pays]
(
	[IdPays] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Nom] VARCHAR(50) NOT NULL, 
    [Capitale] VARCHAR(50) NOT NULL, 
    [Population] INT NOT NULL, 
    [Sperficie] INT NOT NULL,
	CONSTRAINT AK_Nom UNIQUE(Nom)
)
