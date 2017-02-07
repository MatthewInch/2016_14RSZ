USE [Lakaszovetkezet]
GO

/****** Object:  Table [dbo].[Deposit]    Script Date: 2017. 01. 24. 8:26:54 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Deposit](
	[Year] [int] NOT NULL,
	[Month] [int] NULL,
	[Value] [int] NULL,
	[DepositType] [nvarchar](50) NULL,
	[DepositDate] [date] NULL,
	[FlatID] [int] NULL,
	[DepositID] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_Deposit] PRIMARY KEY CLUSTERED 
(
	[DepositID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO



CREATE TABLE [dbo].[Flat](
	[FlatID] [int] IDENTITY(1,1) NOT NULL,
	[Size] [float] NULL,
	[Radiators] [int] NULL,
	[Stairway] [nvarchar](10) NULL,
	[Floor] [int] NULL,
	[FlatNumber] [int] NULL,
	[ResidentID] [int] NULL,
	[OwnerID] [int] NULL,
 CONSTRAINT [PK_Flat] PRIMARY KEY CLUSTERED 
(
	[FlatID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

/****** Object:  Table [dbo].[People]    Script Date: 2017. 01. 24. 8:27:14 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[People](
	[Name] [nvarchar](50) NOT NULL,
	[Address] [nvarchar](100) NOT NULL,
	[PhoneNumber] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[PeopleID] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_People] PRIMARY KEY CLUSTERED 
(
	[PeopleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


ALTER TABLE [dbo].[Deposit]  WITH CHECK ADD  CONSTRAINT [FK_Deposit_ToTable] FOREIGN KEY([FlatID])
REFERENCES [dbo].[Flat] ([FlatID])
GO

ALTER TABLE [dbo].[Deposit] CHECK CONSTRAINT [FK_Deposit_ToTable]
GO


ALTER TABLE [dbo].[Flat]  WITH CHECK ADD  CONSTRAINT [FK_Flat_ToTable] FOREIGN KEY([OwnerID])
REFERENCES [dbo].[People] ([PeopleID])
GO

ALTER TABLE [dbo].[Flat] CHECK CONSTRAINT [FK_Flat_ToTable]
GO

ALTER TABLE [dbo].[Flat]  WITH CHECK ADD  CONSTRAINT [FK_Flat_ToTable_1] FOREIGN KEY([ResidentID])
REFERENCES [dbo].[People] ([PeopleID])
GO

ALTER TABLE [dbo].[Flat] CHECK CONSTRAINT [FK_Flat_ToTable_1]
GO

