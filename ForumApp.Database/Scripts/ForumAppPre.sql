

/****** Object:  Database [ForumSample]     ******/
CREATE DATABASE [Forum]
 

ALTER DATABASE [Forum] SET COMPATIBILITY_LEVEL = 120
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Forum].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO





ALTER DATABASE [Forum] SET FILESTREAM( NON_TRANSACTED_ACCESS = FULL ) 
GO

ALTER DATABASE [Forum] SET  READ_WRITE 
GO

--create tables
--forum
CREATE TABLE [dbo].[Forum](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[UserID] [bigint] NOT NULL,
	[Title] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](255) NOT NULL,
 CONSTRAINT [PK__Forum__3214EC27086C0736] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

--threads
CREATE TABLE [dbo].[ForumThread](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[TopicID] [bigint] NOT NULL,
	[UserID] [bigint] NOT NULL,
	[Body] [ntext] NOT NULL,
	[CreatedOn] [datetime] NOT NULL,
	[Visible] [bit] NULL,
	[IsPosted] [bit] NULL,
 CONSTRAINT [PK__ForumThr__3214EC27D2D75217] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
--instant messages
CREATE TABLE [dbo].[InstantMessage](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[Body] [ntext] NOT NULL,
	[CreationDate] [datetime] NOT NULL,
	[ToUser] [bigint] NOT NULL,
	[FromUser] [bigint] NOT NULL,
	[IsNew] [bit] NULL,
	[IsSent] [bit] NULL,
	[ParentID] [bigint] NULL,
 CONSTRAINT [PK__InstantM__3214EC279832295D] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

--login attempts
CREATE TABLE [dbo].[LoginAttempt](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[LoginDate] [datetime] NOT NULL,
	[UserID] [bigint] NULL,
 CONSTRAINT [PK_LoginAttempt] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

--password
CREATE TABLE [dbo].[Password](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[UserID] [bigint] NOT NULL,
	[CreateDate] [datetime] NOT NULL,
	[Hash] [nvarchar](128) NOT NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_Password] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
--profile
CREATE TABLE [dbo].[Profile](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[UserID] [bigint] NOT NULL,
	[Email] [nchar](50) NOT NULL,
	[FirstName] [nchar](50) NOT NULL,
	[LastName] [nchar](50) NOT NULL,
	[Interests] [nchar](255) NULL,
	[PostCount] [int] NOT NULL,
	[Location] [nchar](50) NULL,
	[AvatarName] [nchar](128) NULL,
 CONSTRAINT [PK_Profile] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

--role
CREATE TABLE [dbo].[Role](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[RoleName] [nchar](25) NULL,
 CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

--thread reply
CREATE TABLE [dbo].[ThreadReply](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[ForumThreadID] [bigint] NOT NULL,
	[UserID] [bigint] NOT NULL,
	[Body] [ntext] NOT NULL,
	[CreatedOn] [datetime] NOT NULL,
	[IsPosted] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

--topic
CREATE TABLE [dbo].[Topic](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[ForumID] [bigint] NOT NULL,
	[UserID] [bigint] NOT NULL,
	[Subject] [nvarchar](255) NOT NULL,
	[Visible] [bit] NOT NULL,
	[IsSticky] [int] NOT NULL,
	[IsClosed] [bit] NOT NULL,
	[ViewsCount] [int] NOT NULL,
	[RepliesCount] [int] NOT NULL,
	[CreatedOn] [datetime] NOT NULL,
 CONSTRAINT [PK__Topics__3214EC2757F16623] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

--user
CREATE TABLE [dbo].[User](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[Username] [nchar](10) NOT NULL,
	[CreateDate] [datetime] NOT NULL,
	[IsActive] [bit] NOT NULL,
	[RoleID] [bigint] NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


--user subscriptions
CREATE TABLE [dbo].[UserSubscription](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[UserID] [bigint] NOT NULL,
	[SubscriptionID] [bigint] NOT NULL,
	[SubscriptionType] [nchar](25) NOT NULL,
 CONSTRAINT [PK_UserSubscription] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


--alter tables
--forum
ALTER TABLE [dbo].[Forum]  WITH CHECK ADD  CONSTRAINT [FK_Forum_User] FOREIGN KEY([UserID])
REFERENCES [dbo].[User] ([ID])
GO

ALTER TABLE [dbo].[Forum] CHECK CONSTRAINT [FK_Forum_User]
GO
--threads
ALTER TABLE [dbo].[ForumThread] ADD  CONSTRAINT [DF__ForumThre__Visib__6754599E]  DEFAULT ((1)) FOR [Visible]
GO

ALTER TABLE [dbo].[ForumThread]  WITH CHECK ADD  CONSTRAINT [FK_ForumThread_Topic] FOREIGN KEY([TopicID])
REFERENCES [dbo].[Topic] ([ID])
GO

ALTER TABLE [dbo].[ForumThread] CHECK CONSTRAINT [FK_ForumThread_Topic]
GO

ALTER TABLE [dbo].[ForumThread]  WITH CHECK ADD  CONSTRAINT [FK_ForumThread_User] FOREIGN KEY([UserID])
REFERENCES [dbo].[User] ([ID])
GO

ALTER TABLE [dbo].[ForumThread] CHECK CONSTRAINT [FK_ForumThread_User]
GO
--instant messages
ALTER TABLE [dbo].[InstantMessage]  WITH CHECK ADD  CONSTRAINT [FK_InstantMessage_FromUser] FOREIGN KEY([FromUser])
REFERENCES [dbo].[User] ([ID])
GO

ALTER TABLE [dbo].[InstantMessage] CHECK CONSTRAINT [FK_InstantMessage_FromUser]
GO

ALTER TABLE [dbo].[InstantMessage]  WITH CHECK ADD  CONSTRAINT [FK_InstantMessage_ToUser] FOREIGN KEY([ToUser])
REFERENCES [dbo].[User] ([ID])
GO

ALTER TABLE [dbo].[InstantMessage] CHECK CONSTRAINT [FK_InstantMessage_ToUser]
GO

--login attempt
ALTER TABLE [dbo].[LoginAttempt]  WITH CHECK ADD  CONSTRAINT [FK_LoginAttempt_User] FOREIGN KEY([UserID])
REFERENCES [dbo].[User] ([ID])
GO

ALTER TABLE [dbo].[LoginAttempt] CHECK CONSTRAINT [FK_LoginAttempt_User]
GO
--password
ALTER TABLE [dbo].[Password]  WITH CHECK ADD  CONSTRAINT [FK_Password_User] FOREIGN KEY([UserID])
REFERENCES [dbo].[User] ([ID])
GO

ALTER TABLE [dbo].[Password] CHECK CONSTRAINT [FK_Password_User]
GO
--profile
ALTER TABLE [dbo].[Profile]  WITH CHECK ADD  CONSTRAINT [FK_UserProfile_User] FOREIGN KEY([UserID])
REFERENCES [dbo].[User] ([ID])
GO

ALTER TABLE [dbo].[Profile] CHECK CONSTRAINT [FK_UserProfile_User]
GO

--thread reply
ALTER TABLE [dbo].[ThreadReply]  WITH CHECK ADD  CONSTRAINT [FK_ThreadReply_Thread] FOREIGN KEY([ForumThreadID])
REFERENCES [dbo].[ForumThread] ([ID])
GO

ALTER TABLE [dbo].[ThreadReply] CHECK CONSTRAINT [FK_ThreadReply_Thread]
GO

--topic
ALTER TABLE [dbo].[Topic] ADD  CONSTRAINT [DF__Topics__IsSticky__5070F446]  DEFAULT ((0)) FOR [IsSticky]
GO

ALTER TABLE [dbo].[Topic] ADD  CONSTRAINT [DF__Topics__IsClosed__5165187F]  DEFAULT ((0)) FOR [IsClosed]
GO

ALTER TABLE [dbo].[Topic] ADD  CONSTRAINT [DF__Topics__ViewsCou__52593CB8]  DEFAULT ((0)) FOR [ViewsCount]
GO

ALTER TABLE [dbo].[Topic] ADD  CONSTRAINT [DF__Topics__RepliesC__534D60F1]  DEFAULT ((0)) FOR [RepliesCount]
GO

ALTER TABLE [dbo].[Topic]  WITH CHECK ADD  CONSTRAINT [FK_Topics_Forum] FOREIGN KEY([ForumID])
REFERENCES [dbo].[Forum] ([ID])
GO

ALTER TABLE [dbo].[Topic] CHECK CONSTRAINT [FK_Topics_Forum]
GO

--user
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_Role] FOREIGN KEY([RoleID])
REFERENCES [dbo].[Role] ([ID])
GO

ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_User_Role]
GO

--user subscriptions
ALTER TABLE [dbo].[UserSubscription]  WITH CHECK ADD  CONSTRAINT [FK_UserSubscription_User] FOREIGN KEY([UserID])
REFERENCES [dbo].[User] ([ID])
GO

ALTER TABLE [dbo].[UserSubscription] CHECK CONSTRAINT [FK_UserSubscription_User]
GO