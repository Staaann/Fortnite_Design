CREATE TABLE [dbo].[Account]
(
    [ID] INT NOT NULL PRIMARY KEY IDENTITY(1,1)   , 
    [username] VARCHAR(50) NOT NULL, 
	[password] VARCHAR(50) NOT NULL, 
)