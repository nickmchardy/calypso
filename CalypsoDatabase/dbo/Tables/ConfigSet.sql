CREATE TABLE [dbo].[ConfigSet] (
    [ConfigSetId]     INT            IDENTITY (1, 1) NOT NULL,
    [Name]            NVARCHAR (50)  NOT NULL,
    [Description]     NVARCHAR (500) NULL,
    [Status]          NVARCHAR (10)  NOT NULL,
    [BasePath]        NVARCHAR (500) NOT NULL,
    [WebPath]         NVARCHAR (500) NOT NULL,
    [LastLoaded]      DATETIME       NULL,
    [TimeTakenToLoad] BIGINT         CONSTRAINT [DF_ConfigSet_TImeTakenToLoad] DEFAULT ((0)) NOT NULL,
    [FileCount]       BIGINT         CONSTRAINT [DF_ConfigSet_FilesLoaded] DEFAULT ((0)) NOT NULL,
    [ErrorCount]      BIGINT         CONSTRAINT [DF_ConfigSet_ErrorFiles] DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_ConfigSet] PRIMARY KEY CLUSTERED ([ConfigSetId] ASC)
);

