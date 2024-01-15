﻿USE [boksys_SampleDB]
GO

ALTER TABLE [dbo].[MASTER_REFERENCE_DATA] DROP CONSTRAINT [DF_MASTER_REFERENCE_DATA_SortingNumber]
GO

ALTER TABLE [dbo].[MASTER_REFERENCE_DATA] DROP CONSTRAINT [DF_MASTER_REFERENCE_DATA_isEnabled]
GO

ALTER TABLE [dbo].[MASTER_REFERENCE_DATA] DROP CONSTRAINT [DF_MASTER_REFERENCE_DATA_CreatedDate]
GO

ALTER TABLE [dbo].[MASTER_REFERENCE_DATA] DROP CONSTRAINT [DF_MASTER_REFERENCE_DATA_CreatedBy]
GO

/****** Object:  Table [dbo].[MASTER_REFERENCE_DATA]    Script Date: 1/16/2024 4:27:18 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[MASTER_REFERENCE_DATA]') AND type in (N'U'))
DROP TABLE [dbo].[MASTER_REFERENCE_DATA]
GO

/****** Object:  Table [dbo].[MASTER_REFERENCE_DATA]    Script Date: 1/16/2024 4:27:18 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[MASTER_REFERENCE_DATA](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[PKEY] [nvarchar](50) NOT NULL,
	[ModuleName] [nvarchar](max) NOT NULL,
	[ForValue] [nvarchar](50) NOT NULL,
	[ValueString] [nvarchar](max) NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[ModifiedBy] [int] NULL,
	[ModifiedDate] [datetime] NULL,
	[isEnabled] [int] NOT NULL,
	[Remarks] [nvarchar](max) NULL,
	[SortingNumber] [int] NOT NULL,
 CONSTRAINT [PK_MASTER_REFERENCE_DATA] PRIMARY KEY CLUSTERED 
(
	[PKEY] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[MASTER_REFERENCE_DATA] ADD  CONSTRAINT [DF_MASTER_REFERENCE_DATA_CreatedBy]  DEFAULT ((-1)) FOR [CreatedBy]
GO

ALTER TABLE [dbo].[MASTER_REFERENCE_DATA] ADD  CONSTRAINT [DF_MASTER_REFERENCE_DATA_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO

ALTER TABLE [dbo].[MASTER_REFERENCE_DATA] ADD  CONSTRAINT [DF_MASTER_REFERENCE_DATA_isEnabled]  DEFAULT ((1)) FOR [isEnabled]
GO

ALTER TABLE [dbo].[MASTER_REFERENCE_DATA] ADD  CONSTRAINT [DF_MASTER_REFERENCE_DATA_SortingNumber]  DEFAULT ((0)) FOR [SortingNumber]
GO


