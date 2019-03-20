CREATE TABLE [dbo].[Fortnite]
(
    [SkinID] INT NOT NULL PRIMARY KEY IDENTITY(1,1)   , 
    [SkinNaam] VARCHAR(50) NOT NULL, 
    [SkinPrice] INT NOT NULL, 
    [SkinImage] VARCHAR(255) NOT NULL
)