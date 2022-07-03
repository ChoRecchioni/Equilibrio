CREATE TABLE [dbo].[Usuario] (
    [codigo]       INT           IDENTITY (1, 1) NOT NULL,
    [rut]          VARCHAR (15)  NOT NULL,
    [nombre]       VARCHAR (25)  NOT NULL,
    [apellido]     VARCHAR (25)  NOT NULL,
    [telefono]     VARCHAR (15)  NOT NULL,
    [pass]         VARCHAR (255) NOT NULL,
    [fk_direccion] INT           NULL,
    [fk_rol]       INT           NULL,
    [fk_sede]      INT           NOT NULL,
    [correo]       VARCHAR (100) NOT NULL,
    PRIMARY KEY CLUSTERED ([codigo] ASC),
    UNIQUE NONCLUSTERED ([rut] ASC),
    UNIQUE NONCLUSTERED ([correo] ASC),
    FOREIGN KEY ([fk_direccion]) REFERENCES [dbo].[Direccion] ([codigo]),
    FOREIGN KEY ([fk_rol]) REFERENCES [dbo].[Rol] ([codigo]),
    FOREIGN KEY ([fk_sede]) REFERENCES [dbo].[Sede] ([codigo])
);

