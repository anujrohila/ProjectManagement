USE [ProjectManagement]
GO
/****** Object:  Table [dbo].[tblProject]    Script Date: 03/17/2015 23:05:33 ******/
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
/****** Object:  Table [dbo].[tblMemberType]    Script Date: 03/17/2015 23:05:33 ******/
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
/****** Object:  Table [dbo].[tblImageMaster]    Script Date: 03/17/2015 23:05:33 ******/
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
/****** Object:  Table [dbo].[tblEntityMaster]    Script Date: 03/17/2015 23:05:33 ******/
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
 CONSTRAINT [PK_tblEntityMaster] PRIMARY KEY CLUSTERED 
(
	[EntityId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tblEntityMaster] ON
INSERT [dbo].[tblEntityMaster] ([EntityId], [EntityName], [Description], [ControllerName]) VALUES (1, N'Supplier', N'You can use this for doing all transaction with supplier.', N'Supplier')
INSERT [dbo].[tblEntityMaster] ([EntityId], [EntityName], [Description], [ControllerName]) VALUES (2, N'Material Master', NULL, N'MaterialGroup')
INSERT [dbo].[tblEntityMaster] ([EntityId], [EntityName], [Description], [ControllerName]) VALUES (3, N'Material Sub Master', NULL, N'MaterialSubGroup')
INSERT [dbo].[tblEntityMaster] ([EntityId], [EntityName], [Description], [ControllerName]) VALUES (4, N'Material Entry', NULL, N'MaterialEntry')
INSERT [dbo].[tblEntityMaster] ([EntityId], [EntityName], [Description], [ControllerName]) VALUES (5, N'Member', NULL, N'Member')
INSERT [dbo].[tblEntityMaster] ([EntityId], [EntityName], [Description], [ControllerName]) VALUES (6, N'Project', NULL, N'Project')
SET IDENTITY_INSERT [dbo].[tblEntityMaster] OFF
/****** Object:  Table [dbo].[tblMember]    Script Date: 03/17/2015 23:05:33 ******/
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
INSERT [dbo].[tblMember] ([MemberId], [MemberTypeId], [FirstName], [LastName], [Address], [EmailAddress], [MobileNo], [Password], [IsActive]) VALUES (2, 1, N' xcv', N'xcvxcv', N'xcvxcv', N'cvxcv', N'xcvx', N'mgqC8MDPMUcNev/t40BsyaqEEGcVILcnBE7aFbTCVTKptc2Kr5zsSRnXYlW2v7AP', 1)
INSERT [dbo].[tblMember] ([MemberId], [MemberTypeId], [FirstName], [LastName], [Address], [EmailAddress], [MobileNo], [Password], [IsActive]) VALUES (4, 1, N'sasd', N'asdasd', N'boj', N'jbbl', N'bb', N'mgqC8MDPMUcNev/t40BsyaqEEGcVILcnBE7aFbTCVTKptc2Kr5zsSRnXYlW2v7AP', 1)
INSERT [dbo].[tblMember] ([MemberId], [MemberTypeId], [FirstName], [LastName], [Address], [EmailAddress], [MobileNo], [Password], [IsActive]) VALUES (5, 1, N'dasd', N'asdasd', N'asdasd', N'dasd', N'asdas', N'4wu+nVvJ6uD9uf1XJNMCm9Ueq51cx2pkSUEIGLKJPbMOz84xbe+duYJn3QfcnvLh', 0)
INSERT [dbo].[tblMember] ([MemberId], [MemberTypeId], [FirstName], [LastName], [Address], [EmailAddress], [MobileNo], [Password], [IsActive]) VALUES (6, 1, N'mayur', N'sorahiya', N'simadagam', N'sorathiyamayur111@gmail.com', N'8866303520', N'CpievEp3tWpuK7exnZldGFzkQJDBPimEt+zG1EbUth6pmRt2pMLwSxtNJEhBRJRU', 1)
SET IDENTITY_INSERT [dbo].[tblMember] OFF
/****** Object:  Table [dbo].[tblMemberPermission]    Script Date: 03/17/2015 23:05:33 ******/
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
INSERT [dbo].[tblMemberPermission] ([MemberPermissionId], [ProjectId], [MemberId], [EnitytId], [CanListAll], [CanInsert], [CanEdit], [CanDelete]) VALUES (11, 1, 6, 1, 1, 0, 0, 0)
INSERT [dbo].[tblMemberPermission] ([MemberPermissionId], [ProjectId], [MemberId], [EnitytId], [CanListAll], [CanInsert], [CanEdit], [CanDelete]) VALUES (12, 1, 6, 2, 1, 1, 1, 1)
INSERT [dbo].[tblMemberPermission] ([MemberPermissionId], [ProjectId], [MemberId], [EnitytId], [CanListAll], [CanInsert], [CanEdit], [CanDelete]) VALUES (13, 1, 1, 3, 1, 1, 0, 0)
INSERT [dbo].[tblMemberPermission] ([MemberPermissionId], [ProjectId], [MemberId], [EnitytId], [CanListAll], [CanInsert], [CanEdit], [CanDelete]) VALUES (14, 1, 1, 6, 1, 1, 0, 0)
INSERT [dbo].[tblMemberPermission] ([MemberPermissionId], [ProjectId], [MemberId], [EnitytId], [CanListAll], [CanInsert], [CanEdit], [CanDelete]) VALUES (15, 1, 5, 1, 1, 1, 0, 0)
SET IDENTITY_INSERT [dbo].[tblMemberPermission] OFF
/****** Object:  ForeignKey [FK_tblMember_tblMemberType]    Script Date: 03/17/2015 23:05:33 ******/
ALTER TABLE [dbo].[tblMember]  WITH CHECK ADD  CONSTRAINT [FK_tblMember_tblMemberType] FOREIGN KEY([MemberTypeId])
REFERENCES [dbo].[tblMemberType] ([MemberTypeId])
GO
ALTER TABLE [dbo].[tblMember] CHECK CONSTRAINT [FK_tblMember_tblMemberType]
GO
/****** Object:  ForeignKey [FK_tblMemberPermission_tblMember]    Script Date: 03/17/2015 23:05:33 ******/
ALTER TABLE [dbo].[tblMemberPermission]  WITH CHECK ADD  CONSTRAINT [FK_tblMemberPermission_tblMember] FOREIGN KEY([MemberId])
REFERENCES [dbo].[tblMember] ([MemberId])
GO
ALTER TABLE [dbo].[tblMemberPermission] CHECK CONSTRAINT [FK_tblMemberPermission_tblMember]
GO
