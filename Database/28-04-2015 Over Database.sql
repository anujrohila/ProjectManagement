USE [master]
GO
/****** Object:  Database [ProjectManagement]    Script Date: 04/28/2015 09:28:24 ******/
CREATE DATABASE [ProjectManagement] ON  PRIMARY 
( NAME = N'ProjectManagement', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.ANUJSQLSERVER\MSSQL\DATA\ProjectManagement.mdf' , SIZE = 2048KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'ProjectManagement_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.ANUJSQLSERVER\MSSQL\DATA\ProjectManagement_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [ProjectManagement] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ProjectManagement].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ProjectManagement] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [ProjectManagement] SET ANSI_NULLS OFF
GO
ALTER DATABASE [ProjectManagement] SET ANSI_PADDING OFF
GO
ALTER DATABASE [ProjectManagement] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [ProjectManagement] SET ARITHABORT OFF
GO
ALTER DATABASE [ProjectManagement] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [ProjectManagement] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [ProjectManagement] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [ProjectManagement] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [ProjectManagement] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [ProjectManagement] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [ProjectManagement] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [ProjectManagement] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [ProjectManagement] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [ProjectManagement] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [ProjectManagement] SET  DISABLE_BROKER
GO
ALTER DATABASE [ProjectManagement] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [ProjectManagement] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [ProjectManagement] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [ProjectManagement] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [ProjectManagement] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [ProjectManagement] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [ProjectManagement] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [ProjectManagement] SET  READ_WRITE
GO
ALTER DATABASE [ProjectManagement] SET RECOVERY FULL
GO
ALTER DATABASE [ProjectManagement] SET  MULTI_USER
GO
ALTER DATABASE [ProjectManagement] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [ProjectManagement] SET DB_CHAINING OFF
GO
EXEC sys.sp_db_vardecimal_storage_format N'ProjectManagement', N'ON'
GO
USE [ProjectManagement]
GO
/****** Object:  Table [dbo].[tblProject]    Script Date: 04/28/2015 09:28:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblProject](
	[ProjectId] [int] IDENTITY(1,1) NOT NULL,
	[Title] [varchar](100) NOT NULL,
	[SiteName] [varchar](100) NOT NULL,
	[Address] [varchar](500) NULL,
	[Description] [varchar](500) NULL,
	[StratDateTime] [date] NOT NULL,
	[Catalog] [varchar](100) NOT NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_tblProject] PRIMARY KEY CLUSTERED 
(
	[ProjectId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tblProject] ON
INSERT [dbo].[tblProject] ([ProjectId], [Title], [SiteName], [Address], [Description], [StratDateTime], [Catalog], [IsActive]) VALUES (1, N'Behstan', N'Behstan', N'Behstan', N'Behstan', CAST(0x80360B00 AS Date), N'Co_BHESTAN', 0)
INSERT [dbo].[tblProject] ([ProjectId], [Title], [SiteName], [Address], [Description], [StratDateTime], [Catalog], [IsActive]) VALUES (2, N'Second Project', N'Second Project', N'Second Project', N'SecondProject', CAST(0x80360B00 AS Date), N'SecondProject', 1)
INSERT [dbo].[tblProject] ([ProjectId], [Title], [SiteName], [Address], [Description], [StratDateTime], [Catalog], [IsActive]) VALUES (8, N'asd', N'asd', N'asdasdsd', N'asd', CAST(0xB9390B00 AS Date), N'asd', 1)
SET IDENTITY_INSERT [dbo].[tblProject] OFF
/****** Object:  Table [dbo].[tblMemberType]    Script Date: 04/28/2015 09:28:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblMemberType](
	[MemberTypeId] [int] IDENTITY(1,1) NOT NULL,
	[TypeName] [varchar](50) NULL,
 CONSTRAINT [PK_MemberType] PRIMARY KEY CLUSTERED 
(
	[MemberTypeId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tblMemberType] ON
INSERT [dbo].[tblMemberType] ([MemberTypeId], [TypeName]) VALUES (1, N'Admin')
INSERT [dbo].[tblMemberType] ([MemberTypeId], [TypeName]) VALUES (2, N'Member')
SET IDENTITY_INSERT [dbo].[tblMemberType] OFF
/****** Object:  Table [dbo].[tblImageMaster]    Script Date: 04/28/2015 09:28:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblImageMaster](
	[ImageID] [bigint] IDENTITY(1,1) NOT NULL,
	[ImagesPath] [varchar](100) NULL,
	[Comment] [text] NULL,
	[CreateBy] [int] NULL,
	[CreationDateTime] [datetime] NULL,
	[UpdateBy] [int] NULL,
	[UpdationDateTime] [datetime] NULL,
 CONSTRAINT [PK_tblImageMaster] PRIMARY KEY CLUSTERED 
(
	[ImageID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tblImageMaster] ON
INSERT [dbo].[tblImageMaster] ([ImageID], [ImagesPath], [Comment], [CreateBy], [CreationDateTime], [UpdateBy], [UpdationDateTime]) VALUES (2, N'btnDelete.png', N'delete', 1, CAST(0x0000A45E01054083 AS DateTime), NULL, NULL)
INSERT [dbo].[tblImageMaster] ([ImageID], [ImagesPath], [Comment], [CreateBy], [CreationDateTime], [UpdateBy], [UpdationDateTime]) VALUES (4, N'farm_fence-wallpaper-1680x1050-compressed.jpg', N'commect', 1, CAST(0x0000A45E014042A8 AS DateTime), NULL, NULL)
SET IDENTITY_INSERT [dbo].[tblImageMaster] OFF
/****** Object:  Table [dbo].[tblEntityMaster]    Script Date: 04/28/2015 09:28:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblEntityMaster](
	[EntityId] [int] IDENTITY(1,1) NOT NULL,
	[EntityName] [varchar](50) NULL,
	[Description] [varchar](500) NULL,
	[ControllerName] [varchar](50) NULL,
	[IsReport] [bit] NOT NULL,
 CONSTRAINT [PK_tblEntityMaster] PRIMARY KEY CLUSTERED 
(
	[EntityId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tblEntityMaster] ON
INSERT [dbo].[tblEntityMaster] ([EntityId], [EntityName], [Description], [ControllerName], [IsReport]) VALUES (1, N'Supplier', N'You can use this for doing all transaction with supplier.', N'Supplier', 0)
INSERT [dbo].[tblEntityMaster] ([EntityId], [EntityName], [Description], [ControllerName], [IsReport]) VALUES (2, N'Material Master', NULL, N'MaterialGroup', 0)
INSERT [dbo].[tblEntityMaster] ([EntityId], [EntityName], [Description], [ControllerName], [IsReport]) VALUES (3, N'Material Sub Master', NULL, N'MaterialSubGroup', 0)
INSERT [dbo].[tblEntityMaster] ([EntityId], [EntityName], [Description], [ControllerName], [IsReport]) VALUES (4, N'Material Entry', NULL, N'MaterialEntry', 0)
INSERT [dbo].[tblEntityMaster] ([EntityId], [EntityName], [Description], [ControllerName], [IsReport]) VALUES (5, N'Member', NULL, N'Member', 0)
INSERT [dbo].[tblEntityMaster] ([EntityId], [EntityName], [Description], [ControllerName], [IsReport]) VALUES (6, N'Project', NULL, N'Project', 0)
INSERT [dbo].[tblEntityMaster] ([EntityId], [EntityName], [Description], [ControllerName], [IsReport]) VALUES (7, N'Cash Book', NULL, N'CashBook', 1)
INSERT [dbo].[tblEntityMaster] ([EntityId], [EntityName], [Description], [ControllerName], [IsReport]) VALUES (8, N'Bank Book', NULL, N'BankBook', 1)
INSERT [dbo].[tblEntityMaster] ([EntityId], [EntityName], [Description], [ControllerName], [IsReport]) VALUES (9, N'Ledger Book', NULL, N'LedgerBook', 1)
INSERT [dbo].[tblEntityMaster] ([EntityId], [EntityName], [Description], [ControllerName], [IsReport]) VALUES (10, N'Trial Book', NULL, N'TrialBook', 1)
INSERT [dbo].[tblEntityMaster] ([EntityId], [EntityName], [Description], [ControllerName], [IsReport]) VALUES (12, N'Transaction Entry', NULL, N'TransactionEntry', 0)
SET IDENTITY_INSERT [dbo].[tblEntityMaster] OFF
/****** Object:  Table [dbo].[tblMember]    Script Date: 04/28/2015 09:28:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblMember](
	[MemberId] [int] IDENTITY(1,1) NOT NULL,
	[MemberTypeId] [int] NOT NULL,
	[FirstName] [varchar](50) NOT NULL,
	[LastName] [varchar](50) NOT NULL,
	[Address] [varchar](500) NOT NULL,
	[EmailAddress] [varchar](50) NOT NULL,
	[MobileNo] [varchar](50) NOT NULL,
	[Password] [varchar](500) NOT NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_tblMember] PRIMARY KEY CLUSTERED 
(
	[MemberId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tblMember] ON
INSERT [dbo].[tblMember] ([MemberId], [MemberTypeId], [FirstName], [LastName], [Address], [EmailAddress], [MobileNo], [Password], [IsActive]) VALUES (1, 1, N'Anuj', N'Rohilas', N'Anuj', N'anuj', N'Anuj', N'CpievEp3tWpuK7exnZldGFzkQJDBPimEt+zG1EbUth6pmRt2pMLwSxtNJEhBRJRU', 1)
INSERT [dbo].[tblMember] ([MemberId], [MemberTypeId], [FirstName], [LastName], [Address], [EmailAddress], [MobileNo], [Password], [IsActive]) VALUES (2, 1, N' xcv', N'xcvxcv', N'xcvxcv', N'cvxcv', N'xcvx', N'CpievEp3tWpuK7exnZldGFzkQJDBPimEt+zG1EbUth6pmRt2pMLwSxtNJEhBRJRU', 1)
INSERT [dbo].[tblMember] ([MemberId], [MemberTypeId], [FirstName], [LastName], [Address], [EmailAddress], [MobileNo], [Password], [IsActive]) VALUES (4, 2, N'Mayur', N'Sorthiya', N'boj', N'mayur', N'bb', N'CpievEp3tWpuK7exnZldGFzkQJDBPimEt+zG1EbUth6pmRt2pMLwSxtNJEhBRJRU', 1)
INSERT [dbo].[tblMember] ([MemberId], [MemberTypeId], [FirstName], [LastName], [Address], [EmailAddress], [MobileNo], [Password], [IsActive]) VALUES (5, 2, N'dasd', N'asdasd', N'asdasd', N'dasd', N'asdas', N'CpievEp3tWpuK7exnZldGFzkQJDBPimEt+zG1EbUth6pmRt2pMLwSxtNJEhBRJRU', 1)
INSERT [dbo].[tblMember] ([MemberId], [MemberTypeId], [FirstName], [LastName], [Address], [EmailAddress], [MobileNo], [Password], [IsActive]) VALUES (6, 2, N'Nilesh', N'Joliya', N'simadagam', N'nilesh', N'8866303520', N'CpievEp3tWpuK7exnZldGFzkQJDBPimEt+zG1EbUth6pmRt2pMLwSxtNJEhBRJRU', 1)
SET IDENTITY_INSERT [dbo].[tblMember] OFF
/****** Object:  Table [dbo].[tblMemberPermission]    Script Date: 04/28/2015 09:28:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblMemberPermission](
	[MemberPermissionId] [int] IDENTITY(1,1) NOT NULL,
	[ProjectId] [int] NOT NULL,
	[MemberId] [int] NOT NULL,
	[EnitytId] [int] NOT NULL,
	[CanListAll] [bit] NOT NULL,
	[CanInsert] [bit] NOT NULL,
	[CanEdit] [bit] NOT NULL,
	[CanDelete] [bit] NOT NULL,
 CONSTRAINT [PK_MemberPermission] PRIMARY KEY CLUSTERED 
(
	[MemberPermissionId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tblMemberPermission] ON
INSERT [dbo].[tblMemberPermission] ([MemberPermissionId], [ProjectId], [MemberId], [EnitytId], [CanListAll], [CanInsert], [CanEdit], [CanDelete]) VALUES (1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[tblMemberPermission] ([MemberPermissionId], [ProjectId], [MemberId], [EnitytId], [CanListAll], [CanInsert], [CanEdit], [CanDelete]) VALUES (2, 1, 1, 2, 1, 1, 1, 1)
INSERT [dbo].[tblMemberPermission] ([MemberPermissionId], [ProjectId], [MemberId], [EnitytId], [CanListAll], [CanInsert], [CanEdit], [CanDelete]) VALUES (3, 1, 1, 3, 1, 1, 1, 1)
INSERT [dbo].[tblMemberPermission] ([MemberPermissionId], [ProjectId], [MemberId], [EnitytId], [CanListAll], [CanInsert], [CanEdit], [CanDelete]) VALUES (4, 1, 1, 4, 1, 1, 1, 1)
INSERT [dbo].[tblMemberPermission] ([MemberPermissionId], [ProjectId], [MemberId], [EnitytId], [CanListAll], [CanInsert], [CanEdit], [CanDelete]) VALUES (5, 1, 1, 5, 1, 1, 1, 1)
INSERT [dbo].[tblMemberPermission] ([MemberPermissionId], [ProjectId], [MemberId], [EnitytId], [CanListAll], [CanInsert], [CanEdit], [CanDelete]) VALUES (6, 2, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[tblMemberPermission] ([MemberPermissionId], [ProjectId], [MemberId], [EnitytId], [CanListAll], [CanInsert], [CanEdit], [CanDelete]) VALUES (7, 2, 1, 2, 1, 1, 1, 1)
INSERT [dbo].[tblMemberPermission] ([MemberPermissionId], [ProjectId], [MemberId], [EnitytId], [CanListAll], [CanInsert], [CanEdit], [CanDelete]) VALUES (8, 2, 1, 3, 1, 1, 1, 1)
INSERT [dbo].[tblMemberPermission] ([MemberPermissionId], [ProjectId], [MemberId], [EnitytId], [CanListAll], [CanInsert], [CanEdit], [CanDelete]) VALUES (9, 2, 1, 4, 1, 1, 1, 1)
INSERT [dbo].[tblMemberPermission] ([MemberPermissionId], [ProjectId], [MemberId], [EnitytId], [CanListAll], [CanInsert], [CanEdit], [CanDelete]) VALUES (10, 2, 1, 5, 1, 1, 1, 1)
INSERT [dbo].[tblMemberPermission] ([MemberPermissionId], [ProjectId], [MemberId], [EnitytId], [CanListAll], [CanInsert], [CanEdit], [CanDelete]) VALUES (13, 1, 1, 3, 1, 1, 0, 0)
INSERT [dbo].[tblMemberPermission] ([MemberPermissionId], [ProjectId], [MemberId], [EnitytId], [CanListAll], [CanInsert], [CanEdit], [CanDelete]) VALUES (14, 1, 1, 6, 1, 1, 0, 0)
INSERT [dbo].[tblMemberPermission] ([MemberPermissionId], [ProjectId], [MemberId], [EnitytId], [CanListAll], [CanInsert], [CanEdit], [CanDelete]) VALUES (26, 1, 5, 1, 1, 1, 0, 0)
INSERT [dbo].[tblMemberPermission] ([MemberPermissionId], [ProjectId], [MemberId], [EnitytId], [CanListAll], [CanInsert], [CanEdit], [CanDelete]) VALUES (27, 1, 5, 2, 1, 1, 0, 0)
INSERT [dbo].[tblMemberPermission] ([MemberPermissionId], [ProjectId], [MemberId], [EnitytId], [CanListAll], [CanInsert], [CanEdit], [CanDelete]) VALUES (28, 1, 5, 7, 1, 0, 0, 0)
INSERT [dbo].[tblMemberPermission] ([MemberPermissionId], [ProjectId], [MemberId], [EnitytId], [CanListAll], [CanInsert], [CanEdit], [CanDelete]) VALUES (29, 1, 5, 9, 1, 0, 0, 0)
INSERT [dbo].[tblMemberPermission] ([MemberPermissionId], [ProjectId], [MemberId], [EnitytId], [CanListAll], [CanInsert], [CanEdit], [CanDelete]) VALUES (30, 2, 4, 1, 1, 1, 1, 1)
INSERT [dbo].[tblMemberPermission] ([MemberPermissionId], [ProjectId], [MemberId], [EnitytId], [CanListAll], [CanInsert], [CanEdit], [CanDelete]) VALUES (31, 2, 4, 2, 1, 1, 1, 1)
INSERT [dbo].[tblMemberPermission] ([MemberPermissionId], [ProjectId], [MemberId], [EnitytId], [CanListAll], [CanInsert], [CanEdit], [CanDelete]) VALUES (32, 2, 4, 3, 1, 1, 1, 1)
INSERT [dbo].[tblMemberPermission] ([MemberPermissionId], [ProjectId], [MemberId], [EnitytId], [CanListAll], [CanInsert], [CanEdit], [CanDelete]) VALUES (33, 2, 4, 4, 1, 1, 1, 1)
INSERT [dbo].[tblMemberPermission] ([MemberPermissionId], [ProjectId], [MemberId], [EnitytId], [CanListAll], [CanInsert], [CanEdit], [CanDelete]) VALUES (34, 2, 4, 5, 1, 1, 1, 1)
INSERT [dbo].[tblMemberPermission] ([MemberPermissionId], [ProjectId], [MemberId], [EnitytId], [CanListAll], [CanInsert], [CanEdit], [CanDelete]) VALUES (35, 2, 4, 6, 1, 1, 1, 1)
INSERT [dbo].[tblMemberPermission] ([MemberPermissionId], [ProjectId], [MemberId], [EnitytId], [CanListAll], [CanInsert], [CanEdit], [CanDelete]) VALUES (36, 2, 4, 7, 1, 1, 1, 1)
INSERT [dbo].[tblMemberPermission] ([MemberPermissionId], [ProjectId], [MemberId], [EnitytId], [CanListAll], [CanInsert], [CanEdit], [CanDelete]) VALUES (37, 2, 4, 8, 1, 1, 1, 1)
INSERT [dbo].[tblMemberPermission] ([MemberPermissionId], [ProjectId], [MemberId], [EnitytId], [CanListAll], [CanInsert], [CanEdit], [CanDelete]) VALUES (38, 2, 4, 9, 1, 1, 1, 1)
INSERT [dbo].[tblMemberPermission] ([MemberPermissionId], [ProjectId], [MemberId], [EnitytId], [CanListAll], [CanInsert], [CanEdit], [CanDelete]) VALUES (39, 2, 4, 10, 1, 1, 1, 1)
INSERT [dbo].[tblMemberPermission] ([MemberPermissionId], [ProjectId], [MemberId], [EnitytId], [CanListAll], [CanInsert], [CanEdit], [CanDelete]) VALUES (40, 2, 4, 12, 1, 1, 1, 1)
SET IDENTITY_INSERT [dbo].[tblMemberPermission] OFF
/****** Object:  ForeignKey [FK_tblMember_tblMemberType]    Script Date: 04/28/2015 09:28:27 ******/
ALTER TABLE [dbo].[tblMember]  WITH CHECK ADD  CONSTRAINT [FK_tblMember_tblMemberType] FOREIGN KEY([MemberTypeId])
REFERENCES [dbo].[tblMemberType] ([MemberTypeId])
GO
ALTER TABLE [dbo].[tblMember] CHECK CONSTRAINT [FK_tblMember_tblMemberType]
GO
/****** Object:  ForeignKey [FK_tblMemberPermission_tblMember]    Script Date: 04/28/2015 09:28:27 ******/
ALTER TABLE [dbo].[tblMemberPermission]  WITH CHECK ADD  CONSTRAINT [FK_tblMemberPermission_tblMember] FOREIGN KEY([MemberId])
REFERENCES [dbo].[tblMember] ([MemberId])
GO
ALTER TABLE [dbo].[tblMemberPermission] CHECK CONSTRAINT [FK_tblMemberPermission_tblMember]
GO
