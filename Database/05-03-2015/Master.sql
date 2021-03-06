USE [ProjectManagement]
GO
/****** Object:  Table [dbo].[tblCompany]    Script Date: 03/05/2015 16:42:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblCompany](
	[CompanyId] [int] IDENTITY(1,1) NOT NULL,
	[CompanyName] [varchar](50) NULL,
	[Address] [varchar](500) NULL,
	[ContactDetails] [varchar](50) NULL,
	[AboutUs] [varchar](50) NULL,
	[CreationDateTime] [datetime] NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_tblCompany] PRIMARY KEY CLUSTERED 
(
	[CompanyId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblAccountType]    Script Date: 03/05/2015 16:42:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblAccountType](
	[AccountTypeId] [int] NOT NULL,
	[TypeName] [varchar](50) NULL,
	[Childof] [int] NULL,
	[IsDisplay] [bit] NULL,
	[ClosingBalance] [float] NULL,
 CONSTRAINT [PK_tblAccountType] PRIMARY KEY CLUSTERED 
(
	[AccountTypeId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[tblAccountType] ([AccountTypeId], [TypeName], [Childof], [IsDisplay], [ClosingBalance]) VALUES (1, N'_Primary', 1, 0, 0)
INSERT [dbo].[tblAccountType] ([AccountTypeId], [TypeName], [Childof], [IsDisplay], [ClosingBalance]) VALUES (2, N'Bank Accounts', 7, 1, 0)
INSERT [dbo].[tblAccountType] ([AccountTypeId], [TypeName], [Childof], [IsDisplay], [ClosingBalance]) VALUES (3, N'Bank OD A/c', 18, 1, 0)
INSERT [dbo].[tblAccountType] ([AccountTypeId], [TypeName], [Childof], [IsDisplay], [ClosingBalance]) VALUES (4, N'Branch / Divisions', 30, 1, 0)
INSERT [dbo].[tblAccountType] ([AccountTypeId], [TypeName], [Childof], [IsDisplay], [ClosingBalance]) VALUES (5, N'Capital Account', 30, 0, 0)
INSERT [dbo].[tblAccountType] ([AccountTypeId], [TypeName], [Childof], [IsDisplay], [ClosingBalance]) VALUES (6, N'Cash-In-Hand', 7, 1, 0)
INSERT [dbo].[tblAccountType] ([AccountTypeId], [TypeName], [Childof], [IsDisplay], [ClosingBalance]) VALUES (7, N'Current Assets', 31, 0, 0)
INSERT [dbo].[tblAccountType] ([AccountTypeId], [TypeName], [Childof], [IsDisplay], [ClosingBalance]) VALUES (8, N'Current Liabilities', 30, 1, 0)
INSERT [dbo].[tblAccountType] ([AccountTypeId], [TypeName], [Childof], [IsDisplay], [ClosingBalance]) VALUES (9, N'Deposits (Assets)', 7, 1, 0)
INSERT [dbo].[tblAccountType] ([AccountTypeId], [TypeName], [Childof], [IsDisplay], [ClosingBalance]) VALUES (10, N'Direct Expenses', 32, 1, 0)
INSERT [dbo].[tblAccountType] ([AccountTypeId], [TypeName], [Childof], [IsDisplay], [ClosingBalance]) VALUES (11, N'Direct Incomes', 33, 1, 0)
INSERT [dbo].[tblAccountType] ([AccountTypeId], [TypeName], [Childof], [IsDisplay], [ClosingBalance]) VALUES (12, N'Duties & Taxes', 8, 1, 0)
INSERT [dbo].[tblAccountType] ([AccountTypeId], [TypeName], [Childof], [IsDisplay], [ClosingBalance]) VALUES (13, N'Fixed Assets', 31, 0, 0)
INSERT [dbo].[tblAccountType] ([AccountTypeId], [TypeName], [Childof], [IsDisplay], [ClosingBalance]) VALUES (14, N'Indirect Expenses', 32, 1, 0)
INSERT [dbo].[tblAccountType] ([AccountTypeId], [TypeName], [Childof], [IsDisplay], [ClosingBalance]) VALUES (15, N'Indirect Incomes', 33, 1, 0)
INSERT [dbo].[tblAccountType] ([AccountTypeId], [TypeName], [Childof], [IsDisplay], [ClosingBalance]) VALUES (16, N'Investments', 31, 1, 0)
INSERT [dbo].[tblAccountType] ([AccountTypeId], [TypeName], [Childof], [IsDisplay], [ClosingBalance]) VALUES (17, N'Loans & Advances (Assets)', 7, 1, 0)
INSERT [dbo].[tblAccountType] ([AccountTypeId], [TypeName], [Childof], [IsDisplay], [ClosingBalance]) VALUES (18, N'Loans (Liability)', 30, 1, 0)
INSERT [dbo].[tblAccountType] ([AccountTypeId], [TypeName], [Childof], [IsDisplay], [ClosingBalance]) VALUES (19, N'Misc. Expenses (Assets)', 31, 1, 0)
INSERT [dbo].[tblAccountType] ([AccountTypeId], [TypeName], [Childof], [IsDisplay], [ClosingBalance]) VALUES (20, N'Provisions', 8, 1, 0)
INSERT [dbo].[tblAccountType] ([AccountTypeId], [TypeName], [Childof], [IsDisplay], [ClosingBalance]) VALUES (21, N'Purchase Accounts', 32, 1, 0)
INSERT [dbo].[tblAccountType] ([AccountTypeId], [TypeName], [Childof], [IsDisplay], [ClosingBalance]) VALUES (22, N'Reserves & Surplus', 5, 1, 0)
INSERT [dbo].[tblAccountType] ([AccountTypeId], [TypeName], [Childof], [IsDisplay], [ClosingBalance]) VALUES (23, N'Sales Account', 33, 1, 0)
INSERT [dbo].[tblAccountType] ([AccountTypeId], [TypeName], [Childof], [IsDisplay], [ClosingBalance]) VALUES (24, N'Secured Loans', 18, 1, 0)
INSERT [dbo].[tblAccountType] ([AccountTypeId], [TypeName], [Childof], [IsDisplay], [ClosingBalance]) VALUES (25, N'Stock-In-Hand', 7, 1, 0)
INSERT [dbo].[tblAccountType] ([AccountTypeId], [TypeName], [Childof], [IsDisplay], [ClosingBalance]) VALUES (26, N'Sundry Debtors', 7, 1, 0)
INSERT [dbo].[tblAccountType] ([AccountTypeId], [TypeName], [Childof], [IsDisplay], [ClosingBalance]) VALUES (27, N'Sundry Creditors', 8, 1, 0)
INSERT [dbo].[tblAccountType] ([AccountTypeId], [TypeName], [Childof], [IsDisplay], [ClosingBalance]) VALUES (28, N'Suspense A/c', 30, 0, 0)
INSERT [dbo].[tblAccountType] ([AccountTypeId], [TypeName], [Childof], [IsDisplay], [ClosingBalance]) VALUES (29, N'Unsecured Loans', 18, 1, 0)
INSERT [dbo].[tblAccountType] ([AccountTypeId], [TypeName], [Childof], [IsDisplay], [ClosingBalance]) VALUES (30, N'LIABILITIES', 1, 0, 0)
INSERT [dbo].[tblAccountType] ([AccountTypeId], [TypeName], [Childof], [IsDisplay], [ClosingBalance]) VALUES (31, N'ASSETS', 1, 0, 0)
INSERT [dbo].[tblAccountType] ([AccountTypeId], [TypeName], [Childof], [IsDisplay], [ClosingBalance]) VALUES (32, N'EXPENSES', 1, 0, 0)
INSERT [dbo].[tblAccountType] ([AccountTypeId], [TypeName], [Childof], [IsDisplay], [ClosingBalance]) VALUES (33, N'INCOME', 1, 0, 0)
INSERT [dbo].[tblAccountType] ([AccountTypeId], [TypeName], [Childof], [IsDisplay], [ClosingBalance]) VALUES (34, N'Members Ledger', 7, 1, 0)
INSERT [dbo].[tblAccountType] ([AccountTypeId], [TypeName], [Childof], [IsDisplay], [ClosingBalance]) VALUES (35, N'Branch Div', 4, 0, 0)
INSERT [dbo].[tblAccountType] ([AccountTypeId], [TypeName], [Childof], [IsDisplay], [ClosingBalance]) VALUES (36, N'Suspence A/c', 28, 1, 0)
INSERT [dbo].[tblAccountType] ([AccountTypeId], [TypeName], [Childof], [IsDisplay], [ClosingBalance]) VALUES (37, N'Fixed assets', 13, 0, 0)
INSERT [dbo].[tblAccountType] ([AccountTypeId], [TypeName], [Childof], [IsDisplay], [ClosingBalance]) VALUES (38, N'Current Liability', 8, 0, 0)
INSERT [dbo].[tblAccountType] ([AccountTypeId], [TypeName], [Childof], [IsDisplay], [ClosingBalance]) VALUES (39, N'Current Assets', 7, 0, 0)
INSERT [dbo].[tblAccountType] ([AccountTypeId], [TypeName], [Childof], [IsDisplay], [ClosingBalance]) VALUES (40, N'Capital', 5, 1, 0)
INSERT [dbo].[tblAccountType] ([AccountTypeId], [TypeName], [Childof], [IsDisplay], [ClosingBalance]) VALUES (41, N'Drawings', 1, 0, 0)
INSERT [dbo].[tblAccountType] ([AccountTypeId], [TypeName], [Childof], [IsDisplay], [ClosingBalance]) VALUES (42, N'Closing Stock', 1, 0, 0)
INSERT [dbo].[tblAccountType] ([AccountTypeId], [TypeName], [Childof], [IsDisplay], [ClosingBalance]) VALUES (43, N'Profit and Loss', 1, 0, 0)
INSERT [dbo].[tblAccountType] ([AccountTypeId], [TypeName], [Childof], [IsDisplay], [ClosingBalance]) VALUES (44, N'Profit and loss A/c', 43, 1, 0)
INSERT [dbo].[tblAccountType] ([AccountTypeId], [TypeName], [Childof], [IsDisplay], [ClosingBalance]) VALUES (45, N'Petty Cash', 7, 1, 0)
INSERT [dbo].[tblAccountType] ([AccountTypeId], [TypeName], [Childof], [IsDisplay], [ClosingBalance]) VALUES (46, N'Land and Building', 13, 1, 0)
INSERT [dbo].[tblAccountType] ([AccountTypeId], [TypeName], [Childof], [IsDisplay], [ClosingBalance]) VALUES (47, N'Expance Asset', 19, 1, 0)
INSERT [dbo].[tblAccountType] ([AccountTypeId], [TypeName], [Childof], [IsDisplay], [ClosingBalance]) VALUES (48, N'Investment', 7, 1, 0)
INSERT [dbo].[tblAccountType] ([AccountTypeId], [TypeName], [Childof], [IsDisplay], [ClosingBalance]) VALUES (49, N'Contractor', 8, 1, 0)
/****** Object:  Table [dbo].[tblMaterialGroup]    Script Date: 03/05/2015 16:42:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblMaterialGroup](
	[MaterialGroupId] [int] IDENTITY(1,1) NOT NULL,
	[GroupName] [varchar](50) NULL,
	[Description] [varchar](500) NULL,
 CONSTRAINT [PK_tblMaterialGroup] PRIMARY KEY CLUSTERED 
(
	[MaterialGroupId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblPermissionMaster]    Script Date: 03/05/2015 16:42:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblPermissionMaster](
	[PermissionId] [int] IDENTITY(1,1) NOT NULL,
	[PermissionName] [varchar](50) NULL,
	[Description] [varchar](500) NULL,
 CONSTRAINT [PK_PermissionMaster] PRIMARY KEY CLUSTERED 
(
	[PermissionId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblMemberType]    Script Date: 03/05/2015 16:42:54 ******/
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
/****** Object:  Table [dbo].[tblMember]    Script Date: 03/05/2015 16:42:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblMember](
	[MemberId] [int] IDENTITY(1,1) NOT NULL,
	[MemberTypeId] [int] NULL,
	[FirstName] [varchar](50) NULL,
	[LastName] [varchar](50) NULL,
	[EmailAddress] [varchar](50) NULL,
	[MobileNo] [varchar](50) NULL,
	[Password] [varchar](50) NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_tblMember] PRIMARY KEY CLUSTERED 
(
	[MemberId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblMemberPermission]    Script Date: 03/05/2015 16:42:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblMemberPermission](
	[MemberPermissionId] [int] IDENTITY(1,1) NOT NULL,
	[PermisisonId] [int] NOT NULL,
	[MemberId] [int] NOT NULL,
 CONSTRAINT [PK_MemberPermission] PRIMARY KEY CLUSTERED 
(
	[MemberPermissionId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblMaterial]    Script Date: 03/05/2015 16:42:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblMaterial](
	[MaterialId] [int] IDENTITY(1,1) NOT NULL,
	[MaterialGroupId] [int] NOT NULL,
	[Name] [varchar](200) NOT NULL,
	[BasicRate] [float] NOT NULL,
	[OpeningStock] [float] NOT NULL,
	[MemberId] [int] NOT NULL,
	[CompanyId] [int] NOT NULL,
	[CreationDateTime] [datetime] NOT NULL,
 CONSTRAINT [PK_tblMaterial] PRIMARY KEY CLUSTERED 
(
	[MaterialId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  ForeignKey [FK_tblMaterial_tblCompany]    Script Date: 03/05/2015 16:42:54 ******/
ALTER TABLE [dbo].[tblMaterial]  WITH CHECK ADD  CONSTRAINT [FK_tblMaterial_tblCompany] FOREIGN KEY([CompanyId])
REFERENCES [dbo].[tblCompany] ([CompanyId])
GO
ALTER TABLE [dbo].[tblMaterial] CHECK CONSTRAINT [FK_tblMaterial_tblCompany]
GO
/****** Object:  ForeignKey [FK_tblMaterial_tblMaterialGroup]    Script Date: 03/05/2015 16:42:54 ******/
ALTER TABLE [dbo].[tblMaterial]  WITH CHECK ADD  CONSTRAINT [FK_tblMaterial_tblMaterialGroup] FOREIGN KEY([MaterialGroupId])
REFERENCES [dbo].[tblMaterialGroup] ([MaterialGroupId])
GO
ALTER TABLE [dbo].[tblMaterial] CHECK CONSTRAINT [FK_tblMaterial_tblMaterialGroup]
GO
/****** Object:  ForeignKey [FK_tblMaterial_tblMember]    Script Date: 03/05/2015 16:42:54 ******/
ALTER TABLE [dbo].[tblMaterial]  WITH CHECK ADD  CONSTRAINT [FK_tblMaterial_tblMember] FOREIGN KEY([MemberId])
REFERENCES [dbo].[tblMember] ([MemberId])
GO
ALTER TABLE [dbo].[tblMaterial] CHECK CONSTRAINT [FK_tblMaterial_tblMember]
GO
/****** Object:  ForeignKey [FK_tblMember_tblMemberType]    Script Date: 03/05/2015 16:42:54 ******/
ALTER TABLE [dbo].[tblMember]  WITH CHECK ADD  CONSTRAINT [FK_tblMember_tblMemberType] FOREIGN KEY([MemberTypeId])
REFERENCES [dbo].[tblMemberType] ([MemberTypeId])
GO
ALTER TABLE [dbo].[tblMember] CHECK CONSTRAINT [FK_tblMember_tblMemberType]
GO
/****** Object:  ForeignKey [FK_tblMemberPermission_tblMember]    Script Date: 03/05/2015 16:42:54 ******/
ALTER TABLE [dbo].[tblMemberPermission]  WITH CHECK ADD  CONSTRAINT [FK_tblMemberPermission_tblMember] FOREIGN KEY([MemberId])
REFERENCES [dbo].[tblMember] ([MemberId])
GO
ALTER TABLE [dbo].[tblMemberPermission] CHECK CONSTRAINT [FK_tblMemberPermission_tblMember]
GO
/****** Object:  ForeignKey [FK_tblMemberPermission_tblPermissionMaster]    Script Date: 03/05/2015 16:42:54 ******/
ALTER TABLE [dbo].[tblMemberPermission]  WITH CHECK ADD  CONSTRAINT [FK_tblMemberPermission_tblPermissionMaster] FOREIGN KEY([PermisisonId])
REFERENCES [dbo].[tblPermissionMaster] ([PermissionId])
GO
ALTER TABLE [dbo].[tblMemberPermission] CHECK CONSTRAINT [FK_tblMemberPermission_tblPermissionMaster]
GO
