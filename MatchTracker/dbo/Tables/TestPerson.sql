CREATE TABLE [dbo].[TestPerson] (
    [id]           INT            IDENTITY (1, 1) NOT NULL,
    [FirstName]    NVARCHAR (100) NOT NULL,
    [LastName]     NVARCHAR (100) NOT NULL,
    [EmailAddress] NVARCHAR (200) NOT NULL,
    [PhoneNumber]  VARCHAR (20)   NULL,
    [NumberOfKids] INT            CONSTRAINT [DF_TestPerson_NumberOfKids] DEFAULT ((0)) NOT NULL,
    [CreateDate]   DATETIME2 (7)  CONSTRAINT [DF_TestPerson_CreateDate] DEFAULT (getdate()) NOT NULL,
    CONSTRAINT [PK_TestPerson] PRIMARY KEY CLUSTERED ([id] ASC)
);

