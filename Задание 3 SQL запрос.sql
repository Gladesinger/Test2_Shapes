/*	Запрос для выбора пар имя продукта - имя категории
	Продукты хранятся в таблице Products, категории в таблице Categories
	Таблица Products_Categories создана для связи многие ко многим */

SELECT P.Name AS [Имя продукта], C.Name AS [Имя категории] FROM Products_Categories AS P_C
RIGHT JOIN Products AS P ON P_C.Product_Id = P.Id
LEFT JOIN Categories AS C ON P_C.Category_Id = C.Id;




--	Ниже приведены примеры запросов для создания таблиц Products, Categories и Products_Categories
CREATE TABLE [dbo].[Categories] (
    [Id]   INT IDENTITY(0,1)	NOT NULL,
    [Name] NVARCHAR (50)		NOT NULL,
    [Description] NVARCHAR(250) NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[Products] (
    [Id]   INT IDENTITY(0,1)	NOT NULL,
    [Name] NVARCHAR (50)		NOT NULL,
    [Description] NVARCHAR(250) NULL, 
    [Price] INT NOT NULL, 
    [Img_preview] VARBINARY(MAX) NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[Products_Categories] (
    [Id]          INT IDENTITY (0, 1) NOT NULL,
    [Product_Id]  INT NOT NULL,
    [Category_Id] INT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Products_Categories_Products] FOREIGN KEY ([Product_Id]) REFERENCES [dbo].[Products] ([Id]) ON DELETE CASCADE ON UPDATE CASCADE,
    CONSTRAINT [FK_Products_Categories_Categories] FOREIGN KEY ([Category_Id]) REFERENCES [dbo].[Categories] ([Id]) ON DELETE SET NULL ON UPDATE CASCADE
);
