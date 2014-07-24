CREATE TABLE [dbo].[Track] (
    [TrackId]             INT            IDENTITY (1, 1) NOT NULL,
    [Path]                NVARCHAR (400) NOT NULL,
    [WebPath]             NVARCHAR (500) NULL,
    [FileName]            NVARCHAR (500) NOT NULL,
    [FileSize]            BIGINT         NOT NULL,
    [FileType]            NVARCHAR (10)  NOT NULL,
    [ConfigSetId]         INT            NOT NULL,
    [LastUpdated]         DATETIME       NOT NULL,
    [FileStatus]          NVARCHAR (10)  NULL,
    [Notes]               NVARCHAR (500) NULL,
    [Artist]              NVARCHAR (100) NULL,
    [Title]               NVARCHAR (100) NULL,
    [Album]               NVARCHAR (100) NULL,
    [Year]                INT            NULL,
    [TrackNumber]         INT            NULL,
    [Genre]               NVARCHAR (100) NULL,
    [BPM]                 INT            NULL,
    [BPMAccuracyPct]      INT            NULL,
    [DurationSec]         BIGINT         NULL,
    [Bitrate]             INT            NULL,
    [Lossless]            NVARCHAR (10)  NULL,
    [ReplayGainTrackGain] FLOAT (53)     CONSTRAINT [DF_Track_ReplayGainTrackGain] DEFAULT ((0)) NOT NULL,
    [ReplayGainTrackPeak] FLOAT (53)     CONSTRAINT [DF_Track_ReplayGainTrackPeak] DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_Track] PRIMARY KEY CLUSTERED ([TrackId] ASC),
    CONSTRAINT [FK_Track_ConfigSet] FOREIGN KEY ([ConfigSetId]) REFERENCES [dbo].[ConfigSet] ([ConfigSetId])
);


GO
CREATE UNIQUE NONCLUSTERED INDEX [UK_TrackPath]
    ON [dbo].[Track]([Path] ASC);

