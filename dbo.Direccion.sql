CREATE TABLE [dbo].[Direccion] (
    [codigo]    INT          IDENTITY (1, 1) NOT NULL,
    [alias]     VARCHAR (25) NULL,
    [calleYnum] VARCHAR (50) NULL,
    [depto]     VARCHAR (25) NULL,
    [fk_comuna] INT          NOT NULL,
    PRIMARY KEY CLUSTERED ([codigo] ASC),
    FOREIGN KEY ([fk_comuna]) REFERENCES [dbo].[Comuna] ([codigo]),
);

