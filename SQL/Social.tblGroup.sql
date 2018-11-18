USE [onlineeclub]
GO

/****** Object:  Table [Social].[tblGroup]    Script Date: 11/18/2018 3:46:39 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [Social].[tblGroup](
	[GroupID] [int] IDENTITY(1,1) NOT NULL,
	[GroupName] [varchar](200) NOT NULL,
	[CategoryID] [int] NULL,
	[ContentID] [int] NULL,
	[MemberMin] [int] NULL,
	[MemberLimit] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[GroupID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [Social].[tblGroup]  WITH CHECK ADD FOREIGN KEY([CategoryID])
REFERENCES [Administration].[luCategories] ([CategoryID])
GO

ALTER TABLE [Social].[tblGroup]  WITH CHECK ADD FOREIGN KEY([ContentID])
REFERENCES [Administration].[tblContent] ([ContentID])
GO


