CREATE TABLE [dbo].[Utilisateur] (
    [Id]         INT           IDENTITY (1, 1) NOT NULL,
    [Nom]        VARCHAR (255) NOT NULL,
    [NumEmploye] VARCHAR (255) NOT NULL,
    [MotDePasse] VARCHAR (255) NOT NULL,
    [EstActif]   BIT           DEFAULT ((1)) NOT NULL,
    [Role]       NVARCHAR (50) DEFAULT (user_name()) NOT NULL,
    CONSTRAINT [PK_UTILISATEUR] PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[Categorie] (
    [Id]       INT            IDENTITY (1, 1) NOT NULL,
    [Nom]      VARCHAR (50)   NOT NULL,
    [ImageCat] NVARCHAR (200) DEFAULT (NULL) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[Article] (
    [Id]          INT             IDENTITY (1, 1) NOT NULL,
    [Nom]         VARCHAR (255)   NOT NULL,
    [Designation] VARCHAR (255)   NOT NULL,
    [Prix]        DECIMAL (10, 2) NOT NULL,
    [Commentaire] VARCHAR (255)   NULL,
    [CategorieId] INT             DEFAULT (NULL) NULL,
    [EstActif]    BIT             DEFAULT ((1)) NOT NULL,
    CONSTRAINT [PK_ARTICLE] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Article_Categorie] FOREIGN KEY ([CategorieId]) REFERENCES [dbo].[Categorie] ([Id])
);

CREATE TABLE [dbo].[Client] (
    [Id]       INT           IDENTITY (1, 1) NOT NULL,
    [Nom]      NVARCHAR (50) NOT NULL,
    [Prenom]   NVARCHAR (50) NOT NULL,
    [Adresse]  NVARCHAR (50) NOT NULL,
    [npa]      NVARCHAR (10) NOT NULL,
    [localite] NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_CLIENT] PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[Facture] (
    [Id]          INT           IDENTITY (1, 1) NOT NULL,
    [DateFacture] DATETIME      NOT NULL,
    [ClientId]    INT           NULL,
    [NumFacture]  NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_FACTURE] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [Facture_fk0] FOREIGN KEY ([ClientId]) REFERENCES [dbo].[Client] ([Id]) ON UPDATE CASCADE
);

CREATE TABLE [dbo].[LigneFacture] (
    [Id]          INT             IDENTITY (1, 1) NOT NULL,
    [FactureId]   INT             NOT NULL,
    [ArticleId]   INT             NOT NULL,
    [Quantite]    INT             NOT NULL,
    [PrixUntaire] DECIMAL (10, 2) NOT NULL,
    CONSTRAINT [PK_LIGNEFACTURE] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [LigneFacture_fk0] FOREIGN KEY ([FactureId]) REFERENCES [dbo].[Facture] ([Id]) ON UPDATE CASCADE,
    CONSTRAINT [LigneFacture_fk1] FOREIGN KEY ([ArticleId]) REFERENCES [dbo].[Article] ([Id]) ON UPDATE CASCADE
);

