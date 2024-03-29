USE [boksys_SampleDB]
GO

ALTER TABLE [dbo].[MASTER_CHARTOFACCOUNT_TABLE] DROP CONSTRAINT [DF_MASTER_CHARTOFACCOUNT_TABLE_isEnabled]
GO

ALTER TABLE [dbo].[MASTER_CHARTOFACCOUNT_TABLE] DROP CONSTRAINT [DF_MASTER_CHARTOFACCOUNT_TABLE_CreatedDate]
GO

ALTER TABLE [dbo].[MASTER_CHARTOFACCOUNT_TABLE] DROP CONSTRAINT [DF_MASTER_CHARTOFACCOUNT_TABLE_CreatedBy]
GO

ALTER TABLE [dbo].[MASTER_CHARTOFACCOUNT_TABLE] DROP CONSTRAINT [DF_MASTER_CHARTOFACCOUNT_TABLE_Normally]
GO

ALTER TABLE [dbo].[MASTER_CHARTOFACCOUNT_TABLE] DROP CONSTRAINT [DF_MASTER_CHARTOFACCOUNT_TABLE_FinancialStatementID]
GO

ALTER TABLE [dbo].[MASTER_CHARTOFACCOUNT_TABLE] DROP CONSTRAINT [DF_MASTER_CHARTOFACCOUNT_TABLE_GroupID]
GO

ALTER TABLE [dbo].[MASTER_CHARTOFACCOUNT_TABLE] DROP CONSTRAINT [DF_MASTER_CHARTOFACCOUNT_TABLE_CategoryID]
GO

ALTER TABLE [dbo].[MASTER_CHARTOFACCOUNT_TABLE] DROP CONSTRAINT [DF_MASTER_CHARTOFACCOUNT_TABLE_AccountNumber]
GO

/****** Object:  Table [dbo].[MASTER_CHARTOFACCOUNT_TABLE]    Script Date: 1/15/2024 4:34:13 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[MASTER_CHARTOFACCOUNT_TABLE]') AND type in (N'U'))
DROP TABLE [dbo].[MASTER_CHARTOFACCOUNT_TABLE]
GO

/****** Object:  Table [dbo].[MASTER_CHARTOFACCOUNT_TABLE]    Script Date: 1/15/2024 4:34:13 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[MASTER_CHARTOFACCOUNT_TABLE](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[AccountNumber] [int] NOT NULL,
	[AccountName] [nvarchar](500) NOT NULL,
	[CategoryID] [int] NOT NULL,
	[GroupID] [int] NOT NULL,
	[FinancialStatementID] [int] NOT NULL,
	[Normally] [int] NOT NULL,
	[Description] [nvarchar](500) NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[ModifiedBy] [int] NULL,
	[ModifiedDate] [datetime] NULL,
	[Remarks] [nvarchar](max) NULL,
	[isEnabled] [int] NOT NULL,
 CONSTRAINT [PK_MASTER_CHARTOFACCOUNT_TABLE] PRIMARY KEY CLUSTERED 
(
	[AccountNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[MASTER_CHARTOFACCOUNT_TABLE] ADD  CONSTRAINT [DF_MASTER_CHARTOFACCOUNT_TABLE_AccountNumber]  DEFAULT ((-1)) FOR [AccountNumber]
GO

ALTER TABLE [dbo].[MASTER_CHARTOFACCOUNT_TABLE] ADD  CONSTRAINT [DF_MASTER_CHARTOFACCOUNT_TABLE_CategoryID]  DEFAULT ((-1)) FOR [CategoryID]
GO

ALTER TABLE [dbo].[MASTER_CHARTOFACCOUNT_TABLE] ADD  CONSTRAINT [DF_MASTER_CHARTOFACCOUNT_TABLE_GroupID]  DEFAULT ((-1)) FOR [GroupID]
GO

ALTER TABLE [dbo].[MASTER_CHARTOFACCOUNT_TABLE] ADD  CONSTRAINT [DF_MASTER_CHARTOFACCOUNT_TABLE_FinancialStatementID]  DEFAULT ((-1)) FOR [FinancialStatementID]
GO

ALTER TABLE [dbo].[MASTER_CHARTOFACCOUNT_TABLE] ADD  CONSTRAINT [DF_MASTER_CHARTOFACCOUNT_TABLE_Normally]  DEFAULT ((-1)) FOR [Normally]
GO

ALTER TABLE [dbo].[MASTER_CHARTOFACCOUNT_TABLE] ADD  CONSTRAINT [DF_MASTER_CHARTOFACCOUNT_TABLE_CreatedBy]  DEFAULT ((-1)) FOR [CreatedBy]
GO

ALTER TABLE [dbo].[MASTER_CHARTOFACCOUNT_TABLE] ADD  CONSTRAINT [DF_MASTER_CHARTOFACCOUNT_TABLE_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO

ALTER TABLE [dbo].[MASTER_CHARTOFACCOUNT_TABLE] ADD  CONSTRAINT [DF_MASTER_CHARTOFACCOUNT_TABLE_isEnabled]  DEFAULT ((1)) FOR [isEnabled]
GO


