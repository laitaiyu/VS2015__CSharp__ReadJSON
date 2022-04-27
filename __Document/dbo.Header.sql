CREATE TABLE [dbo].[Header] (
    [xmlns]      NVARCHAR (50) NOT NULL,
    [identifier] NVARCHAR (50) NOT NULL,
    [sender]     NVARCHAR (50) NOT NULL,
    [sent]       NVARCHAR (50) NOT NULL,
    [status]     NVARCHAR (50) NOT NULL,
    [msgType]    NVARCHAR (50) NOT NULL,
    [dataid]     NVARCHAR (50) NOT NULL,
    [scope]      NVARCHAR (50) NOT NULL,
    [dataset]    NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([identifier] ASC)
);

