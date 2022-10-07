CREATE TABLE [dbo].[Tournaments] (
    [id]             INT            IDENTITY (1, 1) NOT NULL,
    [TournamentName] NVARCHAR (200) NOT NULL,
    [EntryFee]       MONEY          CONSTRAINT [DF_Tournaments_EntryFee] DEFAULT ((0)) NOT NULL,
    [Active]         BIT            CONSTRAINT [DF_Tournaments_Active] DEFAULT ((1)) NOT NULL,
    CONSTRAINT [PK_Tournaments] PRIMARY KEY CLUSTERED ([id] ASC)
);

