USE [onlineeclub]
GO

/****** Object:  Table [Social].[lnkGroupToUser]    Script Date: 11/18/2018 3:46:23 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [Social].[lnkGroupToUser](
	[GroupToUserID] [int] IDENTITY(1,1) NOT NULL,
	[GroupID] [int] NULL,
	[UserID] [nvarchar](450) NULL,
PRIMARY KEY CLUSTERED 
(
	[GroupToUserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [Social].[lnkGroupToUser]  WITH CHECK ADD FOREIGN KEY([GroupID])
REFERENCES [Social].[tblGroup] ([GroupID])
GO

ALTER TABLE [Social].[lnkGroupToUser]  WITH CHECK ADD FOREIGN KEY([UserID])
REFERENCES [dbo].[AspNetUsers] ([Id])
GO


