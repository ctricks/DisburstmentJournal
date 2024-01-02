USE [boksys_SampleDB]
GO

/****** Object:  Table [dbo].[MASTER_CHARTOFACCOUNTS_TABLE]    Script Date: 12/30/2023 7:40:14 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[MASTER_CHARTOFACCOUNTS_TABLE](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[AccountNumber] [int] NOT NULL,
	[AccountCode] [nvarchar](50) NOT NULL,
	[AccountName] [nvarchar](max) NOT NULL,
	[CategoryID] [int] NOT NULL,
	[MainAccount] [int] NOT NULL,
	[SubAccount] [int] NOT NULL,
	[TypeAccount] [int] NOT NULL,
	[Description] [nvarchar](max) NULL,
	[StatementType] [int] NOT NULL,
	[CurrentBalance] [numeric](18, 2) NOT NULL,
	[DebitEffect] [int] NOT NULL,
	[CreditEffect] [int] NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[ModifiedBy] [int] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[ModifiedDate] [datetime] NULL,
	[Remarks] [nvarchar](max) NULL,
	[isEnabled] [int] NOT NULL,
 CONSTRAINT [PK_MASTER_CHARTOFACCOUNTS_TABLE] PRIMARY KEY CLUSTERED 
(
	[AccountNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[MASTER_CHARTOFACCOUNTS_TABLE] ADD  CONSTRAINT [DF_MASTER_CHARTOFACCOUNTS_TABLE_CategoryID]  DEFAULT ((-1)) FOR [CategoryID]
GO

ALTER TABLE [dbo].[MASTER_CHARTOFACCOUNTS_TABLE] ADD  CONSTRAINT [DF_MASTER_CHARTOFACCOUNTS_TABLE_MainAccount]  DEFAULT ((-1)) FOR [MainAccount]
GO

ALTER TABLE [dbo].[MASTER_CHARTOFACCOUNTS_TABLE] ADD  CONSTRAINT [DF_MASTER_CHARTOFACCOUNTS_TABLE_SubAccount]  DEFAULT ((-1)) FOR [SubAccount]
GO

ALTER TABLE [dbo].[MASTER_CHARTOFACCOUNTS_TABLE] ADD  CONSTRAINT [DF_MASTER_CHARTOFACCOUNTS_TABLE_TypeAccount]  DEFAULT ((-1)) FOR [TypeAccount]
GO

ALTER TABLE [dbo].[MASTER_CHARTOFACCOUNTS_TABLE] ADD  CONSTRAINT [DF_MASTER_CHARTOFACCOUNTS_TABLE_StatementType]  DEFAULT ((-1)) FOR [StatementType]
GO

ALTER TABLE [dbo].[MASTER_CHARTOFACCOUNTS_TABLE] ADD  CONSTRAINT [DF_MASTER_CHARTOFACCOUNTS_TABLE_CurrentBalance]  DEFAULT ((0.00)) FOR [CurrentBalance]
GO

ALTER TABLE [dbo].[MASTER_CHARTOFACCOUNTS_TABLE] ADD  CONSTRAINT [DF_MASTER_CHARTOFACCOUNTS_TABLE_DebitEffect]  DEFAULT ((0)) FOR [DebitEffect]
GO

ALTER TABLE [dbo].[MASTER_CHARTOFACCOUNTS_TABLE] ADD  CONSTRAINT [DF_MASTER_CHARTOFACCOUNTS_TABLE_CreditEffect]  DEFAULT ((0)) FOR [CreditEffect]
GO

ALTER TABLE [dbo].[MASTER_CHARTOFACCOUNTS_TABLE] ADD  CONSTRAINT [DF_MASTER_CHARTOFACCOUNTS_TABLE_CreatedBy]  DEFAULT ((-1)) FOR [CreatedBy]
GO

ALTER TABLE [dbo].[MASTER_CHARTOFACCOUNTS_TABLE] ADD  CONSTRAINT [DF_MASTER_CHARTOFACCOUNTS_TABLE_ModifiedBy]  DEFAULT ((-1)) FOR [ModifiedBy]
GO

ALTER TABLE [dbo].[MASTER_CHARTOFACCOUNTS_TABLE] ADD  CONSTRAINT [DF_MASTER_CHARTOFACCOUNTS_TABLE_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO

ALTER TABLE [dbo].[MASTER_CHARTOFACCOUNTS_TABLE] ADD  CONSTRAINT [DF_MASTER_CHARTOFACCOUNTS_TABLE_isEnabled]  DEFAULT ((1)) FOR [isEnabled]
GO

