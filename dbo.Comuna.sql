CREATE TABLE [dbo].[Comuna] (
    [codigo] INT          IDENTITY (1, 1) NOT NULL,
    [nombre] VARCHAR (25) NOT NULL,	
    [fk_region] INT          NOT NULL,
    PRIMARY KEY CLUSTERED ([codigo] ASC),
    FOREIGN KEY ([fk_region]) REFERENCES [dbo].[Region] ([codigo])
);

