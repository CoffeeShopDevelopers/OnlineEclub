USE [onlineeclub]
GO

/****** Object:  Table [Administration].[tblContent]    Script Date: 11/18/2018 3:46:04 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [Administration].[tblContent](
	[ContentID] [int] IDENTITY(1,1) NOT NULL,
	[ContentTitle] [varchar](200) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ContentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


