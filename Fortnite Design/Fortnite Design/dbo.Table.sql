CREATE TABLE [dbo].[SkinTable]
(
    [SkinID] INT NOT NULL PRIMARY KEY IDENTITY(1,1)   , 
    [SkinNaam] VARCHAR(50) NULL, 
    [SkinPrice] MONEY NULL, 
    [SkinImage] IMAGE NULL
)