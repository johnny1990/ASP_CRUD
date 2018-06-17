USE [CRUDASP]
GO

/****** Object:  Table [dbo].[Zi]    Script Date: 4/17/2018 12:34:53 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Zi](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Data] [datetime] NULL,
	[Checked] [nvarchar](10) NULL,
	[Solved] [nvarchar](10) NULL,
	[Comments] [nvarchar](100) NULL
) ON [PRIMARY]
GO


