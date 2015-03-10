USE [Co_BHESTAN]
GO
/****** Object:  User [BUILTIN\Administrators]    Script Date: 03/10/2015 09:49:23 ******/
CREATE USER [BUILTIN\Administrators] FOR LOGIN [BUILTIN\Administrators]
GO
/****** Object:  User [chan2210]    Script Date: 03/10/2015 09:49:23 ******/
CREATE USER [chan2210] WITHOUT LOGIN WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [chandresh]    Script Date: 03/10/2015 09:49:23 ******/
CREATE USER [chandresh] WITHOUT LOGIN WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [harshil]    Script Date: 03/10/2015 09:49:23 ******/
CREATE USER [harshil] WITHOUT LOGIN WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [sahil]    Script Date: 03/10/2015 09:49:23 ******/
CREATE USER [sahil] WITHOUT LOGIN WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[Supplier]    Script Date: 03/10/2015 09:49:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Supplier](
	[Sup_id] [nvarchar](255) NOT NULL,
	[NameiS] [nvarchar](255) NULL,
	[AddiS] [nvarchar](255) NULL,
	[City] [nvarchar](255) NULL,
	[OpBalance] [float] NULL,
	[Sup_Ph] [varchar](10) NULL,
	[creditday] [int] NULL,
	[creditammount] [float] NULL,
	[GroupId] [int] NULL,
	[GuIdSup] [nvarchar](255) NULL,
	[share] [smallint] NULL,
	[CutDate] [datetime] NULL,
	[Adding] [nvarchar](255) NULL,
	[IntRates] [float] NULL,
	[AutoUpdate] [bit] NULL,
	[alias] [nvarchar](255) NULL,
	[userss] [nvarchar](255) NULL,
	[childof] [varchar](50) NOT NULL,
	[Balance] [float] NOT NULL,
	[CashBankBalance] [float] NOT NULL,
 CONSTRAINT [Supplier_PrimaryKey] PRIMARY KEY NONCLUSTERED 
(
	[Sup_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Supplier] ([Sup_id], [NameiS], [AddiS], [City], [OpBalance], [Sup_Ph], [creditday], [creditammount], [GroupId], [GuIdSup], [share], [CutDate], [Adding], [IntRates], [AutoUpdate], [alias], [userss], [childof], [Balance], [CashBankBalance]) VALUES (N'BHES-0001', N'MISC', N'SDF', N'FDSG', NULL, N'5011', NULL, -49150, 10, N'0000-0001', NULL, NULL, NULL, NULL, 0, N'', N'Chandresh', N'BHES-0001', -49150, -49150)
INSERT [dbo].[Supplier] ([Sup_id], [NameiS], [AddiS], [City], [OpBalance], [Sup_Ph], [creditday], [creditammount], [GroupId], [GuIdSup], [share], [CutDate], [Adding], [IntRates], [AutoUpdate], [alias], [userss], [childof], [Balance], [CashBankBalance]) VALUES (N'BHES-0002', N'CASH', N'ASD', N'ASDA', NULL, N'5000', NULL, 0, 6, N'0000-0001', NULL, NULL, NULL, NULL, 0, N'', N'Chandresh', N'BHES-0002', 0, 0)
INSERT [dbo].[Supplier] ([Sup_id], [NameiS], [AddiS], [City], [OpBalance], [Sup_Ph], [creditday], [creditammount], [GroupId], [GuIdSup], [share], [CutDate], [Adding], [IntRates], [AutoUpdate], [alias], [userss], [childof], [Balance], [CashBankBalance]) VALUES (N'BHES-0003', N'SANJAY CONTRACTOR', N'XXC', N'CC', NULL, N'100', NULL, 0, 27, N'0000-0001', 0, NULL, NULL, NULL, 0, N'', N'Chandresh', N'BHES-0003', 0, -45000)
INSERT [dbo].[Supplier] ([Sup_id], [NameiS], [AddiS], [City], [OpBalance], [Sup_Ph], [creditday], [creditammount], [GroupId], [GuIdSup], [share], [CutDate], [Adding], [IntRates], [AutoUpdate], [alias], [userss], [childof], [Balance], [CashBankBalance]) VALUES (N'BHES-0004', N'LABOUR EXP', N'DSF', N'DSF', NULL, N'5010', NULL, -15440, 10, N'0000-0001', 0, NULL, NULL, NULL, 0, N'', N'Chandresh', N'BHES-0004', -15440, -15440)
INSERT [dbo].[Supplier] ([Sup_id], [NameiS], [AddiS], [City], [OpBalance], [Sup_Ph], [creditday], [creditammount], [GroupId], [GuIdSup], [share], [CutDate], [Adding], [IntRates], [AutoUpdate], [alias], [userss], [childof], [Balance], [CashBankBalance]) VALUES (N'BHES-0005', N'CASH PURCHASE', N'DSF', N'DSF', NULL, N'5200', NULL, -15675, 10, N'0000-0001', NULL, NULL, NULL, NULL, 0, N'', N'Chandresh', N'BHES-0005', -15675, -15675)
INSERT [dbo].[Supplier] ([Sup_id], [NameiS], [AddiS], [City], [OpBalance], [Sup_Ph], [creditday], [creditammount], [GroupId], [GuIdSup], [share], [CutDate], [Adding], [IntRates], [AutoUpdate], [alias], [userss], [childof], [Balance], [CashBankBalance]) VALUES (N'BHES-0006', N'MILAN SUPERVISOR', N'SAD', N'SAD', NULL, N'100', NULL, -8225, 10, N'0000-0001', NULL, NULL, NULL, NULL, 0, N'', N'Chandresh', N'BHES-0006', -8225, -8225)
INSERT [dbo].[Supplier] ([Sup_id], [NameiS], [AddiS], [City], [OpBalance], [Sup_Ph], [creditday], [creditammount], [GroupId], [GuIdSup], [share], [CutDate], [Adding], [IntRates], [AutoUpdate], [alias], [userss], [childof], [Balance], [CashBankBalance]) VALUES (N'BHES-0007', N'RASIKKHAN', N'ASD', N'SAD', NULL, N'100', NULL, 0, 27, N'0000-0001', NULL, NULL, NULL, NULL, 0, N'', N'Chandresh', N'BHES-0007', 0, -400000)
INSERT [dbo].[Supplier] ([Sup_id], [NameiS], [AddiS], [City], [OpBalance], [Sup_Ph], [creditday], [creditammount], [GroupId], [GuIdSup], [share], [CutDate], [Adding], [IntRates], [AutoUpdate], [alias], [userss], [childof], [Balance], [CashBankBalance]) VALUES (N'BHES-0008', N'SETU BRICKS', N'ASD', N'SAD', NULL, N'100', NULL, 0, 27, N'0000-0001', NULL, NULL, NULL, NULL, 0, N'', N'Chandresh', N'BHES-0008', 0, -41000)
INSERT [dbo].[Supplier] ([Sup_id], [NameiS], [AddiS], [City], [OpBalance], [Sup_Ph], [creditday], [creditammount], [GroupId], [GuIdSup], [share], [CutDate], [Adding], [IntRates], [AutoUpdate], [alias], [userss], [childof], [Balance], [CashBankBalance]) VALUES (N'BHES-0009', N'VINOD VELDER', N'ASD', N'ASDSAD', NULL, N'9898376151', NULL, 0, 27, N'0000-0001', 0, NULL, NULL, NULL, 0, N'', N'Chandresh', N'BHES-0009', 0, -7600)
INSERT [dbo].[Supplier] ([Sup_id], [NameiS], [AddiS], [City], [OpBalance], [Sup_Ph], [creditday], [creditammount], [GroupId], [GuIdSup], [share], [CutDate], [Adding], [IntRates], [AutoUpdate], [alias], [userss], [childof], [Balance], [CashBankBalance]) VALUES (N'BHES-0010', N'RAJU MARBLE', N'ASD', N'ASD', NULL, N'100', NULL, 0, 27, N'0000-0001', 0, NULL, NULL, NULL, 0, N'', N'Chandresh', N'BHES-0010', 0, -5500)
INSERT [dbo].[Supplier] ([Sup_id], [NameiS], [AddiS], [City], [OpBalance], [Sup_Ph], [creditday], [creditammount], [GroupId], [GuIdSup], [share], [CutDate], [Adding], [IntRates], [AutoUpdate], [alias], [userss], [childof], [Balance], [CashBankBalance]) VALUES (N'BHES-0011', N'RADHEY SHYAM CEMENT', N'ASD', N'ASD', NULL, N'9825132028', NULL, 0, 27, N'0000-0001', 0, NULL, NULL, NULL, 0, N'', N'Chandresh', N'BHES-0011', 0, -21680)
INSERT [dbo].[Supplier] ([Sup_id], [NameiS], [AddiS], [City], [OpBalance], [Sup_Ph], [creditday], [creditammount], [GroupId], [GuIdSup], [share], [CutDate], [Adding], [IntRates], [AutoUpdate], [alias], [userss], [childof], [Balance], [CashBankBalance]) VALUES (N'BHES-0012', N'BHARAT SECTION', N'AS', N'ASD', NULL, N'100', NULL, 0, 27, N'0000-0001', 0, NULL, NULL, NULL, 0, N'', N'Chandresh', N'BHES-0012', 0, -7500)
INSERT [dbo].[Supplier] ([Sup_id], [NameiS], [AddiS], [City], [OpBalance], [Sup_Ph], [creditday], [creditammount], [GroupId], [GuIdSup], [share], [CutDate], [Adding], [IntRates], [AutoUpdate], [alias], [userss], [childof], [Balance], [CashBankBalance]) VALUES (N'BHES-0013', N'VARDMAN MARBLE', N'AS', N'ASD', NULL, N'9724224400', NULL, 0, 27, N'0000-0001', 0, NULL, NULL, NULL, 0, N'', N'Chandresh', N'BHES-0013', 0, -10496)
INSERT [dbo].[Supplier] ([Sup_id], [NameiS], [AddiS], [City], [OpBalance], [Sup_Ph], [creditday], [creditammount], [GroupId], [GuIdSup], [share], [CutDate], [Adding], [IntRates], [AutoUpdate], [alias], [userss], [childof], [Balance], [CashBankBalance]) VALUES (N'BHES-0014', N'PURCHASE', N'HJ', N'HJ', NULL, N'5003', NULL, -578255, 21, N'0000-0001', 0, NULL, NULL, NULL, 0, N'', N'Chandresh', N'BHES-0014', -578255, 0)
INSERT [dbo].[Supplier] ([Sup_id], [NameiS], [AddiS], [City], [OpBalance], [Sup_Ph], [creditday], [creditammount], [GroupId], [GuIdSup], [share], [CutDate], [Adding], [IntRates], [AutoUpdate], [alias], [userss], [childof], [Balance], [CashBankBalance]) VALUES (N'BHES-0015', N'KHODIYAR KARTING', N'ASD', N'SAD', NULL, N'9825736869', NULL, 0, 27, N'0000-0001', 0, NULL, NULL, NULL, 0, N'', N'Chandresh', N'BHES-0015', 0, -31479)
INSERT [dbo].[Supplier] ([Sup_id], [NameiS], [AddiS], [City], [OpBalance], [Sup_Ph], [creditday], [creditammount], [GroupId], [GuIdSup], [share], [CutDate], [Adding], [IntRates], [AutoUpdate], [alias], [userss], [childof], [Balance], [CashBankBalance]) VALUES (N'BHES-0016', N'SANJAY COLOUR', N'SAD', N'ASD', NULL, N'100', NULL, 0, 27, N'0000-0001', 0, NULL, NULL, NULL, 0, N'', N'Chandresh', N'BHES-0016', 0, -8000)
INSERT [dbo].[Supplier] ([Sup_id], [NameiS], [AddiS], [City], [OpBalance], [Sup_Ph], [creditday], [creditammount], [GroupId], [GuIdSup], [share], [CutDate], [Adding], [IntRates], [AutoUpdate], [alias], [userss], [childof], [Balance], [CashBankBalance]) VALUES (N'BHES-0017', N'INTREST A/C', N'Main', N'Main', NULL, N'5009', NULL, 0, 10, N'0000-0001', NULL, NULL, NULL, NULL, 0, N'', N'Chandresh', N'BHES-0017', 0, 0)
INSERT [dbo].[Supplier] ([Sup_id], [NameiS], [AddiS], [City], [OpBalance], [Sup_Ph], [creditday], [creditammount], [GroupId], [GuIdSup], [share], [CutDate], [Adding], [IntRates], [AutoUpdate], [alias], [userss], [childof], [Balance], [CashBankBalance]) VALUES (N'81C3-0001', N'RADHESHAYAM HARDWARE', N'AA', N'AA', NULL, N'9825132028', NULL, 0, 27, N'0000-0001', NULL, NULL, NULL, NULL, 0, N'', N'Chandresh', N'81C3-0001', 0, 0)
INSERT [dbo].[Supplier] ([Sup_id], [NameiS], [AddiS], [City], [OpBalance], [Sup_Ph], [creditday], [creditammount], [GroupId], [GuIdSup], [share], [CutDate], [Adding], [IntRates], [AutoUpdate], [alias], [userss], [childof], [Balance], [CashBankBalance]) VALUES (N'81C3-0002', N'KHODIYAAR CARTING', N'AA', N'AA', NULL, N'9825736869', NULL, 0, 27, N'0000-0001', NULL, NULL, NULL, NULL, 0, N'', N'Chandresh', N'81C3-0002', 0, 0)
INSERT [dbo].[Supplier] ([Sup_id], [NameiS], [AddiS], [City], [OpBalance], [Sup_Ph], [creditday], [creditammount], [GroupId], [GuIdSup], [share], [CutDate], [Adding], [IntRates], [AutoUpdate], [alias], [userss], [childof], [Balance], [CashBankBalance]) VALUES (N'81C3-0003', N'SETU BRICK', N'AA', N'AA', NULL, N'100', NULL, 0, 27, N'0000-0001', NULL, NULL, NULL, NULL, 0, N'', N'Chandresh', N'81C3-0003', 0, 0)
INSERT [dbo].[Supplier] ([Sup_id], [NameiS], [AddiS], [City], [OpBalance], [Sup_Ph], [creditday], [creditammount], [GroupId], [GuIdSup], [share], [CutDate], [Adding], [IntRates], [AutoUpdate], [alias], [userss], [childof], [Balance], [CashBankBalance]) VALUES (N'BHES-0018', N'KASAR A/C', N'FG', N'FDG', NULL, N'5500', NULL, 1155, 10, N'0000-0001', 0, NULL, NULL, NULL, 0, N'', N'Chandresh', N'BHES-0018', 1155, 1155)
INSERT [dbo].[Supplier] ([Sup_id], [NameiS], [AddiS], [City], [OpBalance], [Sup_Ph], [creditday], [creditammount], [GroupId], [GuIdSup], [share], [CutDate], [Adding], [IntRates], [AutoUpdate], [alias], [userss], [childof], [Balance], [CashBankBalance]) VALUES (N'0680-7B77', N'PROFIT AND LOSS', N'X', N'X', 0, N'5600', NULL, -134410, 44, N'0000-0001', 0, NULL, NULL, NULL, 0, N'', N'chandresh', N'0680-7B77', -134410, 0)
INSERT [dbo].[Supplier] ([Sup_id], [NameiS], [AddiS], [City], [OpBalance], [Sup_Ph], [creditday], [creditammount], [GroupId], [GuIdSup], [share], [CutDate], [Adding], [IntRates], [AutoUpdate], [alias], [userss], [childof], [Balance], [CashBankBalance]) VALUES (N'E12E-6A8B', N'CAP CN', N'dsf', N'SURAT', 0, N'100', NULL, 0, 40, N'E12E-6A8B', 40, NULL, N'', NULL, 0, N'', N'chandresh', N'E12E-6A8B', 0, -53764)
INSERT [dbo].[Supplier] ([Sup_id], [NameiS], [AddiS], [City], [OpBalance], [Sup_Ph], [creditday], [creditammount], [GroupId], [GuIdSup], [share], [CutDate], [Adding], [IntRates], [AutoUpdate], [alias], [userss], [childof], [Balance], [CashBankBalance]) VALUES (N'0000-0001', N'COMMON LEDGER', N'BASIC', N'SURAT', 0, N'100', 0, 0, 1, N'0000-0001', 0, CAST(0x00009FCB00000000 AS DateTime), N'', 0, 0, N'', N'CHANDRESH', N'0000-0001', 0, 0)
INSERT [dbo].[Supplier] ([Sup_id], [NameiS], [AddiS], [City], [OpBalance], [Sup_Ph], [creditday], [creditammount], [GroupId], [GuIdSup], [share], [CutDate], [Adding], [IntRates], [AutoUpdate], [alias], [userss], [childof], [Balance], [CashBankBalance]) VALUES (N'17B0-4AD5', N'SELL', N'df', N'SURAT', 0, N'100', NULL, 800000, 23, N'0000-0001', 0, NULL, N'', NULL, 0, N'', N'chandresh', N'17B0-4AD5', 800000, 0)
INSERT [dbo].[Supplier] ([Sup_id], [NameiS], [AddiS], [City], [OpBalance], [Sup_Ph], [creditday], [creditammount], [GroupId], [GuIdSup], [share], [CutDate], [Adding], [IntRates], [AutoUpdate], [alias], [userss], [childof], [Balance], [CashBankBalance]) VALUES (N'F0FD-BC16', N'KUBERJI AND SONS', N'sad', N'SURAT', 0, N'100', NULL, 0, 26, N'0000-0001', 0, NULL, N'', NULL, 0, N'', N'chandresh', N'F0FD-BC16', 0, 800000)
INSERT [dbo].[Supplier] ([Sup_id], [NameiS], [AddiS], [City], [OpBalance], [Sup_Ph], [creditday], [creditammount], [GroupId], [GuIdSup], [share], [CutDate], [Adding], [IntRates], [AutoUpdate], [alias], [userss], [childof], [Balance], [CashBankBalance]) VALUES (N'9B6D-8F87', N'CAP SANKAR', N'', N'SURAT', 0, N'100', NULL, 0, 40, N'', 60, NULL, N'', NULL, 0, N'', N'chandresh', N'0000-0001', 0, -80646)
INSERT [dbo].[Supplier] ([Sup_id], [NameiS], [AddiS], [City], [OpBalance], [Sup_Ph], [creditday], [creditammount], [GroupId], [GuIdSup], [share], [CutDate], [Adding], [IntRates], [AutoUpdate], [alias], [userss], [childof], [Balance], [CashBankBalance]) VALUES (N'1111', N'testing1', N'sadsad', N'asdasd', 213, NULL, 123, 123123, 1, NULL, 4343, NULL, N'sdsdad@gmail.com', NULL, NULL, NULL, NULL, N'BHES-0005', 0, 0)
INSERT [dbo].[Supplier] ([Sup_id], [NameiS], [AddiS], [City], [OpBalance], [Sup_Ph], [creditday], [creditammount], [GroupId], [GuIdSup], [share], [CutDate], [Adding], [IntRates], [AutoUpdate], [alias], [userss], [childof], [Balance], [CashBankBalance]) VALUES (N'C5D6-5455', N'SANJAY CONTRACTOR', N'dasdas', N'asdasdasd', NULL, NULL, NULL, NULL, 0, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'C5D6-5455', 0, 0)
INSERT [dbo].[Supplier] ([Sup_id], [NameiS], [AddiS], [City], [OpBalance], [Sup_Ph], [creditday], [creditammount], [GroupId], [GuIdSup], [share], [CutDate], [Adding], [IntRates], [AutoUpdate], [alias], [userss], [childof], [Balance], [CashBankBalance]) VALUES (N'41B7-2AB8', N'MISC', N'SDF', N'FDSG', NULL, NULL, NULL, -49150, 10, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'41B7-2AB8', 0, 0)
INSERT [dbo].[Supplier] ([Sup_id], [NameiS], [AddiS], [City], [OpBalance], [Sup_Ph], [creditday], [creditammount], [GroupId], [GuIdSup], [share], [CutDate], [Adding], [IntRates], [AutoUpdate], [alias], [userss], [childof], [Balance], [CashBankBalance]) VALUES (N'69DE-DBC5', N'MISC', N'SDF', N'FDSG', NULL, NULL, NULL, -49150, 10, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'69DE-DBC5', 0, 0)
INSERT [dbo].[Supplier] ([Sup_id], [NameiS], [AddiS], [City], [OpBalance], [Sup_Ph], [creditday], [creditammount], [GroupId], [GuIdSup], [share], [CutDate], [Adding], [IntRates], [AutoUpdate], [alias], [userss], [childof], [Balance], [CashBankBalance]) VALUES (N'BF7A-CB4B', N'SANJAY CONTRACTOR', N'asdasda', N'asdasda', NULL, NULL, NULL, NULL, 0, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'BF7A-CB4B', 0, 0)
INSERT [dbo].[Supplier] ([Sup_id], [NameiS], [AddiS], [City], [OpBalance], [Sup_Ph], [creditday], [creditammount], [GroupId], [GuIdSup], [share], [CutDate], [Adding], [IntRates], [AutoUpdate], [alias], [userss], [childof], [Balance], [CashBankBalance]) VALUES (N'492F-BCA0', N'MISC', N'SDF', N'FDSG', NULL, NULL, NULL, -49150, 10, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'492F-BCA0', 0, 0)
/****** Object:  Table [dbo].[QtyMaterial]    Script Date: 03/10/2015 09:49:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QtyMaterial](
	[Reg_id] [nvarchar](255) NOT NULL,
	[Mat_id] [nvarchar](255) NULL,
	[Sup_id] [nvarchar](255) NULL,
	[Ddate] [datetime] NULL,
	[Challan_No] [int] NULL,
	[Disp] [nvarchar](255) NULL,
	[Qty] [float] NULL,
	[Rate] [float] NULL,
	[Ammount] [float] NULL,
	[Unit] [nvarchar](255) NULL,
	[Proj_Name] [nvarchar](255) NULL,
	[Bill_No] [smallint] NULL,
	[Bill_Rate] [float] NULL,
	[Bil_Ent] [bit] NULL,
	[Valid] [bit] NULL,
	[Bill_Date] [datetime] NULL,
	[Bill_Ent_No] [nvarchar](255) NULL,
	[GuidQty] [nvarchar](255) NULL,
	[userss] [nvarchar](255) NULL,
 CONSTRAINT [QtyMaterial_PrimaryKey] PRIMARY KEY NONCLUSTERED 
(
	[Reg_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[QtyMaterial] ([Reg_id], [Mat_id], [Sup_id], [Ddate], [Challan_No], [Disp], [Qty], [Rate], [Ammount], [Unit], [Proj_Name], [Bill_No], [Bill_Rate], [Bil_Ent], [Valid], [Bill_Date], [Bill_Ent_No], [GuidQty], [userss]) VALUES (N'81C3-0003', N'81C3-0003', N'81C3-0002', CAST(0x00009E9400000000 AS DateTime), 2741, NULL, 2.53, 2600, 6578, N'BRASS', NULL, NULL, 2600, 0, 0, NULL, NULL, NULL, N'Chandresh')
INSERT [dbo].[QtyMaterial] ([Reg_id], [Mat_id], [Sup_id], [Ddate], [Challan_No], [Disp], [Qty], [Rate], [Ammount], [Unit], [Proj_Name], [Bill_No], [Bill_Rate], [Bil_Ent], [Valid], [Bill_Date], [Bill_Ent_No], [GuidQty], [userss]) VALUES (N'81C3-0002', N'81C3-0002', N'81C3-0002', CAST(0x00009E9400000000 AS DateTime), 2049, NULL, 16.61, 750, 12457.5, N'TONE', NULL, NULL, 750, 0, 0, NULL, NULL, NULL, N'Chandresh')
INSERT [dbo].[QtyMaterial] ([Reg_id], [Mat_id], [Sup_id], [Ddate], [Challan_No], [Disp], [Qty], [Rate], [Ammount], [Unit], [Proj_Name], [Bill_No], [Bill_Rate], [Bil_Ent], [Valid], [Bill_Date], [Bill_Ent_No], [GuidQty], [userss]) VALUES (N'81C3-0001', N'81C3-0001', N'81C3-0001', CAST(0x00009E9400000000 AS DateTime), 2950, N'', 80, 225, 18000, N'BAG', NULL, NULL, 225, 0, 0, NULL, N'', N'', NULL)
INSERT [dbo].[QtyMaterial] ([Reg_id], [Mat_id], [Sup_id], [Ddate], [Challan_No], [Disp], [Qty], [Rate], [Ammount], [Unit], [Proj_Name], [Bill_No], [Bill_Rate], [Bil_Ent], [Valid], [Bill_Date], [Bill_Ent_No], [GuidQty], [userss]) VALUES (N'81C3-0004', N'81C3-0004', N'81C3-0003', CAST(0x00009E9500000000 AS DateTime), 321, NULL, 4000, 2.7, 10800, N'NOS', NULL, NULL, 2.7, 0, 0, NULL, NULL, NULL, N'Chandresh')
INSERT [dbo].[QtyMaterial] ([Reg_id], [Mat_id], [Sup_id], [Ddate], [Challan_No], [Disp], [Qty], [Rate], [Ammount], [Unit], [Proj_Name], [Bill_No], [Bill_Rate], [Bil_Ent], [Valid], [Bill_Date], [Bill_Ent_No], [GuidQty], [userss]) VALUES (N'81C3-0006', N'81C3-0003', N'81C3-0002', CAST(0x00009E9800000000 AS DateTime), 2752, NULL, 2.62, 2600, 6812, N'BRASS', NULL, NULL, 2600, 0, 0, NULL, NULL, NULL, N'Chandresh')
INSERT [dbo].[QtyMaterial] ([Reg_id], [Mat_id], [Sup_id], [Ddate], [Challan_No], [Disp], [Qty], [Rate], [Ammount], [Unit], [Proj_Name], [Bill_No], [Bill_Rate], [Bil_Ent], [Valid], [Bill_Date], [Bill_Ent_No], [GuidQty], [userss]) VALUES (N'81C3-0005', N'81C3-0004', N'81C3-0003', CAST(0x00009E9800000000 AS DateTime), 324, NULL, 4000, 2.7, 10800, N'NOS', NULL, NULL, 2.7, 0, 0, NULL, NULL, NULL, N'Chandresh')
INSERT [dbo].[QtyMaterial] ([Reg_id], [Mat_id], [Sup_id], [Ddate], [Challan_No], [Disp], [Qty], [Rate], [Ammount], [Unit], [Proj_Name], [Bill_No], [Bill_Rate], [Bil_Ent], [Valid], [Bill_Date], [Bill_Ent_No], [GuidQty], [userss]) VALUES (N'81C3-0008', N'81C3-0004', N'81C3-0003', CAST(0x00009E9E00000000 AS DateTime), 335, NULL, 4000, 2.7, 10800, N'NOS', NULL, NULL, 2.7, 0, 0, NULL, NULL, NULL, N'Chandresh')
INSERT [dbo].[QtyMaterial] ([Reg_id], [Mat_id], [Sup_id], [Ddate], [Challan_No], [Disp], [Qty], [Rate], [Ammount], [Unit], [Proj_Name], [Bill_No], [Bill_Rate], [Bil_Ent], [Valid], [Bill_Date], [Bill_Ent_No], [GuidQty], [userss]) VALUES (N'81C3-0007', N'81C3-0003', N'81C3-0002', CAST(0x00009E9E00000000 AS DateTime), 2769, NULL, 2.62, 2600, 6812, N'BRASS', NULL, NULL, 2600, 0, 0, NULL, NULL, NULL, N'Chandresh')
/****** Object:  Table [dbo].[Material]    Script Date: 03/10/2015 09:49:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Material](
	[Mat_id] [nvarchar](255) NOT NULL,
	[Mat_Name] [nvarchar](255) NULL,
	[Mat_Unit] [nvarchar](255) NULL,
	[Basic_Rate] [float] NULL,
	[GroupId] [nvarchar](255) NULL,
	[GuIdMaterial] [nvarchar](255) NULL,
	[userss] [nvarchar](255) NULL,
 CONSTRAINT [Material_PrimaryKey] PRIMARY KEY NONCLUSTERED 
(
	[Mat_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Material] ([Mat_id], [Mat_Name], [Mat_Unit], [Basic_Rate], [GroupId], [GuIdMaterial], [userss]) VALUES (N'81C3-0001', N'CEMENT', N'BAG', 225, N'CEMENT', NULL, N'Chandresh')
INSERT [dbo].[Material] ([Mat_id], [Mat_Name], [Mat_Unit], [Basic_Rate], [GroupId], [GuIdMaterial], [userss]) VALUES (N'81C3-0002', N'KAPACHI KG', N'TONE', 750, N'ROW MATERIAL', NULL, N'Chandresh')
INSERT [dbo].[Material] ([Mat_id], [Mat_Name], [Mat_Unit], [Basic_Rate], [GroupId], [GuIdMaterial], [userss]) VALUES (N'81C3-0003', N'SAND', N'BRASS', 2600, N'ROW MATERIAL', NULL, N'Chandresh')
INSERT [dbo].[Material] ([Mat_id], [Mat_Name], [Mat_Unit], [Basic_Rate], [GroupId], [GuIdMaterial], [userss]) VALUES (N'81C3-0004', N'BRICK1', N'KG', 2.77, N'Cement', NULL, NULL)
/****** Object:  Table [dbo].[Mat_AccountTwo]    Script Date: 03/10/2015 09:49:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Mat_AccountTwo](
	[Ent_No] [nvarchar](255) NOT NULL,
	[VrNo] [int] NOT NULL,
	[Mode_Pay_Rec] [nvarchar](255) NULL,
	[Rec_Pay] [nvarchar](255) NULL,
	[Ammount] [float] NULL,
	[Ddate] [datetime] NULL,
	[Disp] [nvarchar](max) NULL,
	[From_Account] [nvarchar](255) NULL,
	[To_Account] [nvarchar](255) NULL,
	[Hand_Group] [nvarchar](255) NULL,
	[Kwat] [float] NULL,
	[Discount] [float] NULL,
	[Hand] [float] NULL,
	[SetViewOne] [nvarchar](255) NULL,
	[Freezed] [bit] NULL,
	[IsEntryOnly] [bit] NULL,
	[GuidAC] [nvarchar](max) NULL,
	[CurDate] [datetime] NULL,
	[Hide] [bit] NULL,
	[ChqNo] [nvarchar](255) NULL,
	[ChqDrawn] [nvarchar](255) NULL,
	[Userss] [nvarchar](255) NULL,
	[fy] [varchar](50) NULL,
 CONSTRAINT [Mat_AccountTwo_PrimaryKey] PRIMARY KEY NONCLUSTERED 
(
	[Ent_No] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Mat_AccountTwo] ([Ent_No], [VrNo], [Mode_Pay_Rec], [Rec_Pay], [Ammount], [Ddate], [Disp], [From_Account], [To_Account], [Hand_Group], [Kwat], [Discount], [Hand], [SetViewOne], [Freezed], [IsEntryOnly], [GuidAC], [CurDate], [Hide], [ChqNo], [ChqDrawn], [Userss], [fy]) VALUES (N'BHES-0005', 1, N'CASH', N'PAYMENT', 1740, CAST(0x00009E7F00000000 AS DateTime), N'PAID As flush fitting', N'BHES-0002', N'BHES-0004', N'R', 0, 0, 0, N'B', 0, 0, NULL, CAST(0x00009EF500000000 AS DateTime), 0, NULL, NULL, N'Chandresh', N'10-11')
INSERT [dbo].[Mat_AccountTwo] ([Ent_No], [VrNo], [Mode_Pay_Rec], [Rec_Pay], [Ammount], [Ddate], [Disp], [From_Account], [To_Account], [Hand_Group], [Kwat], [Discount], [Hand], [SetViewOne], [Freezed], [IsEntryOnly], [GuidAC], [CurDate], [Hide], [ChqNo], [ChqDrawn], [Userss], [fy]) VALUES (N'BHES-0001', 2, N'CASH', N'PAYMENT', 800, CAST(0x00009E8F00000000 AS DateTime), N'PAID As temppobhadu for majoor', N'BHES-0002', N'BHES-0001', N'R', 0, 0, 0, N'B', 0, 0, NULL, CAST(0x00009E9600000000 AS DateTime), 0, NULL, NULL, N'Chandresh', N'10-11')
INSERT [dbo].[Mat_AccountTwo] ([Ent_No], [VrNo], [Mode_Pay_Rec], [Rec_Pay], [Ammount], [Ddate], [Disp], [From_Account], [To_Account], [Hand_Group], [Kwat], [Discount], [Hand], [SetViewOne], [Freezed], [IsEntryOnly], [GuidAC], [CurDate], [Hide], [ChqNo], [ChqDrawn], [Userss], [fy]) VALUES (N'BHES-0002', 3, N'CASH', N'PAYMENT', 180, CAST(0x00009E9000000000 AS DateTime), N'PAID As line dori and chuno', N'BHES-0002', N'BHES-0001', N'R', 0, 0, 0, N'B', 0, 0, NULL, CAST(0x00009E9600000000 AS DateTime), 0, NULL, NULL, N'Chandresh', N'10-11')
INSERT [dbo].[Mat_AccountTwo] ([Ent_No], [VrNo], [Mode_Pay_Rec], [Rec_Pay], [Ammount], [Ddate], [Disp], [From_Account], [To_Account], [Hand_Group], [Kwat], [Discount], [Hand], [SetViewOne], [Freezed], [IsEntryOnly], [GuidAC], [CurDate], [Hide], [ChqNo], [ChqDrawn], [Userss], [fy]) VALUES (N'BHES-0025', 4, N'PURCHASE', N'RECEIPT', 21680, CAST(0x00009E9400000000 AS DateTime), N'RECEIPT As bill', N'BHES-0011', N'BHES-0014', N'R', 0, 0, 0, N'B', 0, 0, NULL, CAST(0x00009FA500000000 AS DateTime), 0, N'CHEQUE NO ', N'FROM BANK NAME', N'Chandresh', N'10-11')
INSERT [dbo].[Mat_AccountTwo] ([Ent_No], [VrNo], [Mode_Pay_Rec], [Rec_Pay], [Ammount], [Ddate], [Disp], [From_Account], [To_Account], [Hand_Group], [Kwat], [Discount], [Hand], [SetViewOne], [Freezed], [IsEntryOnly], [GuidAC], [CurDate], [Hide], [ChqNo], [ChqDrawn], [Userss], [fy]) VALUES (N'BHES-0027', 5, N'PURCHASE', N'RECEIPT', 24917, CAST(0x00009E9800000000 AS DateTime), N'RECEIPT As bill', N'BHES-0015', N'BHES-0014', N'R', 0, 0, 0, N'B', 0, 0, NULL, CAST(0x00009FA500000000 AS DateTime), 0, N'CHEQUE NO ', N'FROM BANK NAME', N'Chandresh', N'10-11')
INSERT [dbo].[Mat_AccountTwo] ([Ent_No], [VrNo], [Mode_Pay_Rec], [Rec_Pay], [Ammount], [Ddate], [Disp], [From_Account], [To_Account], [Hand_Group], [Kwat], [Discount], [Hand], [SetViewOne], [Freezed], [IsEntryOnly], [GuidAC], [CurDate], [Hide], [ChqNo], [ChqDrawn], [Userss], [fy]) VALUES (N'BHES-0036', 6, N'PURCHASE', N'RECEIPT', 400000, CAST(0x00009E9800000000 AS DateTime), N'RECEIPT As BILL', N'BHES-0007', N'BHES-0014', N'R', 0, 0, 0, N'B', 0, 0, NULL, CAST(0x00009FA600000000 AS DateTime), 0, N'CHEQUE NO ', N'FROM BANK NAME', N'Chandresh', N'10-11')
INSERT [dbo].[Mat_AccountTwo] ([Ent_No], [VrNo], [Mode_Pay_Rec], [Rec_Pay], [Ammount], [Ddate], [Disp], [From_Account], [To_Account], [Hand_Group], [Kwat], [Discount], [Hand], [SetViewOne], [Freezed], [IsEntryOnly], [GuidAC], [CurDate], [Hide], [ChqNo], [ChqDrawn], [Userss], [fy]) VALUES (N'BHES-0007', 7, N'CASH', N'PAYMENT', 300, CAST(0x00009E9A00000000 AS DateTime), N'PAID As vr', N'BHES-0002', N'BHES-0001', N'R', 0, 0, 0, N'B', 0, 0, NULL, CAST(0x00009EF500000000 AS DateTime), 0, NULL, NULL, N'Chandresh', N'10-11')
INSERT [dbo].[Mat_AccountTwo] ([Ent_No], [VrNo], [Mode_Pay_Rec], [Rec_Pay], [Ammount], [Ddate], [Disp], [From_Account], [To_Account], [Hand_Group], [Kwat], [Discount], [Hand], [SetViewOne], [Freezed], [IsEntryOnly], [GuidAC], [CurDate], [Hide], [ChqNo], [ChqDrawn], [Userss], [fy]) VALUES (N'BHES-0008', 8, N'CASH', N'PAYMENT', 14175, CAST(0x00009E9A00000000 AS DateTime), N'PAID As steel', N'BHES-0002', N'BHES-0005', N'R', 0, 0, 0, N'B', 0, 0, NULL, CAST(0x00009EF500000000 AS DateTime), 0, NULL, NULL, N'Chandresh', N'10-11')
INSERT [dbo].[Mat_AccountTwo] ([Ent_No], [VrNo], [Mode_Pay_Rec], [Rec_Pay], [Ammount], [Ddate], [Disp], [From_Account], [To_Account], [Hand_Group], [Kwat], [Discount], [Hand], [SetViewOne], [Freezed], [IsEntryOnly], [GuidAC], [CurDate], [Hide], [ChqNo], [ChqDrawn], [Userss], [fy]) VALUES (N'BHES-0006', 9, N'CASH', N'PAYMENT', 370, CAST(0x00009E9A00000000 AS DateTime), N'PAID As vr', N'BHES-0002', N'BHES-0001', N'R', 0, 0, 0, N'B', 0, 0, NULL, CAST(0x00009EF500000000 AS DateTime), 0, NULL, NULL, N'Chandresh', N'10-11')
INSERT [dbo].[Mat_AccountTwo] ([Ent_No], [VrNo], [Mode_Pay_Rec], [Rec_Pay], [Ammount], [Ddate], [Disp], [From_Account], [To_Account], [Hand_Group], [Kwat], [Discount], [Hand], [SetViewOne], [Freezed], [IsEntryOnly], [GuidAC], [CurDate], [Hide], [ChqNo], [ChqDrawn], [Userss], [fy]) VALUES (N'BHES-0009', 10, N'CASH', N'PAYMENT', 9200, CAST(0x00009E9E00000000 AS DateTime), N'PAID As office chaprui', N'BHES-0002', N'BHES-0004', N'R', 0, 0, 0, N'B', 0, 0, NULL, CAST(0x00009EF500000000 AS DateTime), 0, NULL, NULL, N'Chandresh', N'10-11')
INSERT [dbo].[Mat_AccountTwo] ([Ent_No], [VrNo], [Mode_Pay_Rec], [Rec_Pay], [Ammount], [Ddate], [Disp], [From_Account], [To_Account], [Hand_Group], [Kwat], [Discount], [Hand], [SetViewOne], [Freezed], [IsEntryOnly], [GuidAC], [CurDate], [Hide], [ChqNo], [ChqDrawn], [Userss], [fy]) VALUES (N'BHES-0026', 11, N'PURCHASE', N'RECEIPT', 32400, CAST(0x00009EA400000000 AS DateTime), N'RECEIPT As bill', N'BHES-0008', N'BHES-0014', N'R', 0, 0, 0, N'B', 0, 0, NULL, CAST(0x00009FA500000000 AS DateTime), 0, N'CHEQUE NO ', N'FROM BANK NAME', N'Chandresh', N'10-11')
INSERT [dbo].[Mat_AccountTwo] ([Ent_No], [VrNo], [Mode_Pay_Rec], [Rec_Pay], [Ammount], [Ddate], [Disp], [From_Account], [To_Account], [Hand_Group], [Kwat], [Discount], [Hand], [SetViewOne], [Freezed], [IsEntryOnly], [GuidAC], [CurDate], [Hide], [ChqNo], [ChqDrawn], [Userss], [fy]) VALUES (N'BHES-0010', 12, N'CASH', N'PAYMENT', 4000, CAST(0x00009EA800000000 AS DateTime), N'PAID As feb salary', N'BHES-0002', N'BHES-0006', N'R', 0, 0, 0, N'B', 0, 0, NULL, CAST(0x00009EF500000000 AS DateTime), 0, NULL, NULL, N'Chandresh', N'10-11')
INSERT [dbo].[Mat_AccountTwo] ([Ent_No], [VrNo], [Mode_Pay_Rec], [Rec_Pay], [Ammount], [Ddate], [Disp], [From_Account], [To_Account], [Hand_Group], [Kwat], [Discount], [Hand], [SetViewOne], [Freezed], [IsEntryOnly], [GuidAC], [CurDate], [Hide], [ChqNo], [ChqDrawn], [Userss], [fy]) VALUES (N'BHES-0012', 13, N'CASH', N'PAYMENT', 25000, CAST(0x00009EA900000000 AS DateTime), N'PAID As upad', N'BHES-0002', N'BHES-0003', N'R', 0, 0, 0, N'B', 0, 0, NULL, CAST(0x00009EF500000000 AS DateTime), 0, NULL, NULL, N'Chandresh', N'10-11')
INSERT [dbo].[Mat_AccountTwo] ([Ent_No], [VrNo], [Mode_Pay_Rec], [Rec_Pay], [Ammount], [Ddate], [Disp], [From_Account], [To_Account], [Hand_Group], [Kwat], [Discount], [Hand], [SetViewOne], [Freezed], [IsEntryOnly], [GuidAC], [CurDate], [Hide], [ChqNo], [ChqDrawn], [Userss], [fy]) VALUES (N'BHES-0011', 14, N'CASH', N'PAYMENT', 35000, CAST(0x00009EA900000000 AS DateTime), N'PAID As jcb bhimrao', N'BHES-0002', N'BHES-0001', N'R', 0, 0, 0, N'B', 0, 0, NULL, CAST(0x00009EF500000000 AS DateTime), 0, NULL, NULL, N'Chandresh', N'10-11')
INSERT [dbo].[Mat_AccountTwo] ([Ent_No], [VrNo], [Mode_Pay_Rec], [Rec_Pay], [Ammount], [Ddate], [Disp], [From_Account], [To_Account], [Hand_Group], [Kwat], [Discount], [Hand], [SetViewOne], [Freezed], [IsEntryOnly], [GuidAC], [CurDate], [Hide], [ChqNo], [ChqDrawn], [Userss], [fy]) VALUES (N'BHES-0013', 15, N'CASH', N'PAYMENT', 150000, CAST(0x00009EAA00000000 AS DateTime), N'PAID As upad', N'BHES-0002', N'BHES-0007', N'R', 0, 0, 0, N'B', 0, 0, NULL, CAST(0x00009EF500000000 AS DateTime), 0, NULL, NULL, N'Chandresh', N'10-11')
INSERT [dbo].[Mat_AccountTwo] ([Ent_No], [VrNo], [Mode_Pay_Rec], [Rec_Pay], [Ammount], [Ddate], [Disp], [From_Account], [To_Account], [Hand_Group], [Kwat], [Discount], [Hand], [SetViewOne], [Freezed], [IsEntryOnly], [GuidAC], [CurDate], [Hide], [ChqNo], [ChqDrawn], [Userss], [fy]) VALUES (N'BHES-0034', 16, N'PURCHASE', N'RECEIPT', 8000, CAST(0x00009EB600000000 AS DateTime), N'RECEIPT AS BILL', N'BHES-0016', N'BHES-0014', N'R', 0, 0, 0, N'B', 0, 0, NULL, CAST(0x00009FD600000000 AS DateTime), 0, N'CHEQUE NO ', N'FROM BANK NAME', N'Chandresh', N'10-11')
INSERT [dbo].[Mat_AccountTwo] ([Ent_No], [VrNo], [Mode_Pay_Rec], [Rec_Pay], [Ammount], [Ddate], [Disp], [From_Account], [To_Account], [Hand_Group], [Kwat], [Discount], [Hand], [SetViewOne], [Freezed], [IsEntryOnly], [GuidAC], [CurDate], [Hide], [ChqNo], [ChqDrawn], [Userss], [fy]) VALUES (N'BHES-0028', 17, N'PURCHASE', N'RECEIPT', 6562, CAST(0x00009EB700000000 AS DateTime), N'RECEIPT As bill', N'BHES-0015', N'BHES-0014', N'R', 0, 0, 0, N'B', 0, 0, NULL, CAST(0x00009FA500000000 AS DateTime), 0, N'CHEQUE NO ', N'FROM BANK NAME', N'Chandresh', N'10-11')
INSERT [dbo].[Mat_AccountTwo] ([Ent_No], [VrNo], [Mode_Pay_Rec], [Rec_Pay], [Ammount], [Ddate], [Disp], [From_Account], [To_Account], [Hand_Group], [Kwat], [Discount], [Hand], [SetViewOne], [Freezed], [IsEntryOnly], [GuidAC], [CurDate], [Hide], [ChqNo], [ChqDrawn], [Userss], [fy]) VALUES (N'BHES-0014', 18, N'CASH', N'PAYMENT', 10000, CAST(0x00009EBD00000000 AS DateTime), N'PAID As upad', N'BHES-0002', N'BHES-0003', N'R', 0, 0, 0, N'B', 0, 0, NULL, CAST(0x00009EF500000000 AS DateTime), 0, NULL, NULL, N'Chandresh', N'11-12')
INSERT [dbo].[Mat_AccountTwo] ([Ent_No], [VrNo], [Mode_Pay_Rec], [Rec_Pay], [Ammount], [Ddate], [Disp], [From_Account], [To_Account], [Hand_Group], [Kwat], [Discount], [Hand], [SetViewOne], [Freezed], [IsEntryOnly], [GuidAC], [CurDate], [Hide], [ChqNo], [ChqDrawn], [Userss], [fy]) VALUES (N'BHES-0003', 19, N'CASH', N'PAYMENT', 10000, CAST(0x00009EBD00000000 AS DateTime), N'PAID As upad', N'BHES-0002', N'BHES-0003', N'R', 0, 0, 0, N'B', 0, 0, NULL, CAST(0x00009F9F00000000 AS DateTime), 0, N'CHEQUE NO ', N'FROM BANK NAME', N'Chandresh', N'11-12')
INSERT [dbo].[Mat_AccountTwo] ([Ent_No], [VrNo], [Mode_Pay_Rec], [Rec_Pay], [Ammount], [Ddate], [Disp], [From_Account], [To_Account], [Hand_Group], [Kwat], [Discount], [Hand], [SetViewOne], [Freezed], [IsEntryOnly], [GuidAC], [CurDate], [Hide], [ChqNo], [ChqDrawn], [Userss], [fy]) VALUES (N'BHES-0030', 20, N'PURCHASE', N'RECEIPT', 10496, CAST(0x00009EC400000000 AS DateTime), N'RECEIPT As bill', N'BHES-0013', N'BHES-0014', N'R', 0, 0, 0, N'B', 0, 0, NULL, CAST(0x00009FA500000000 AS DateTime), 0, N'CHEQUE NO ', N'FROM BANK NAME', N'Chandresh', N'11-12')
INSERT [dbo].[Mat_AccountTwo] ([Ent_No], [VrNo], [Mode_Pay_Rec], [Rec_Pay], [Ammount], [Ddate], [Disp], [From_Account], [To_Account], [Hand_Group], [Kwat], [Discount], [Hand], [SetViewOne], [Freezed], [IsEntryOnly], [GuidAC], [CurDate], [Hide], [ChqNo], [ChqDrawn], [Userss], [fy]) VALUES (N'BHES-0016', 21, N'CASH', N'PAYMENT', 4225, CAST(0x00009ECF00000000 AS DateTime), N'PAID As salary', N'BHES-0002', N'BHES-0006', N'R', 0, 0, 0, N'B', 0, 0, NULL, CAST(0x00009EF500000000 AS DateTime), 0, NULL, NULL, N'Chandresh', N'11-12')
INSERT [dbo].[Mat_AccountTwo] ([Ent_No], [VrNo], [Mode_Pay_Rec], [Rec_Pay], [Ammount], [Ddate], [Disp], [From_Account], [To_Account], [Hand_Group], [Kwat], [Discount], [Hand], [SetViewOne], [Freezed], [IsEntryOnly], [GuidAC], [CurDate], [Hide], [ChqNo], [ChqDrawn], [Userss], [fy]) VALUES (N'BHES-0029', 22, N'PURCHASE', N'RECEIPT', 45000, CAST(0x00009ED500000000 AS DateTime), N'RECEIPT As bill', N'BHES-0003', N'BHES-0014', N'R', 0, 0, 0, N'B', 0, 0, NULL, CAST(0x00009FA500000000 AS DateTime), 0, N'CHEQUE NO ', N'FROM BANK NAME', N'Chandresh', N'11-12')
INSERT [dbo].[Mat_AccountTwo] ([Ent_No], [VrNo], [Mode_Pay_Rec], [Rec_Pay], [Ammount], [Ddate], [Disp], [From_Account], [To_Account], [Hand_Group], [Kwat], [Discount], [Hand], [SetViewOne], [Freezed], [IsEntryOnly], [GuidAC], [CurDate], [Hide], [ChqNo], [ChqDrawn], [Userss], [fy]) VALUES (N'BHES-0033', 23, N'PURCHASE', N'RECEIPT', 7600, CAST(0x00009ED500000000 AS DateTime), N'RECEIPT As bill', N'BHES-0009', N'BHES-0014', N'R', 0, 0, 0, N'B', 0, 0, NULL, CAST(0x00009FA500000000 AS DateTime), 0, N'CHEQUE NO ', N'FROM BANK NAME', N'Chandresh', N'11-12')
INSERT [dbo].[Mat_AccountTwo] ([Ent_No], [VrNo], [Mode_Pay_Rec], [Rec_Pay], [Ammount], [Ddate], [Disp], [From_Account], [To_Account], [Hand_Group], [Kwat], [Discount], [Hand], [SetViewOne], [Freezed], [IsEntryOnly], [GuidAC], [CurDate], [Hide], [ChqNo], [ChqDrawn], [Userss], [fy]) VALUES (N'BHES-0017', 24, N'CASH', N'PAYMENT', 4500, CAST(0x00009ED700000000 AS DateTime), N'PAID As flush door+majoori', N'BHES-0002', N'BHES-0004', N'R', 0, 0, 0, N'B', 0, 0, NULL, CAST(0x00009EF500000000 AS DateTime), 0, NULL, NULL, N'Chandresh', N'11-12')
INSERT [dbo].[Mat_AccountTwo] ([Ent_No], [VrNo], [Mode_Pay_Rec], [Rec_Pay], [Ammount], [Ddate], [Disp], [From_Account], [To_Account], [Hand_Group], [Kwat], [Discount], [Hand], [SetViewOne], [Freezed], [IsEntryOnly], [GuidAC], [CurDate], [Hide], [ChqNo], [ChqDrawn], [Userss], [fy]) VALUES (N'BHES-0018', 25, N'CASH', N'PAYMENT', 41000, CAST(0x00009EE500000000 AS DateTime), N'PAID As against bill', N'BHES-0002', N'BHES-0008', N'R', 0, 0, 0, N'B', 0, 0, NULL, CAST(0x00009EF500000000 AS DateTime), 0, NULL, NULL, N'Chandresh', N'11-12')
INSERT [dbo].[Mat_AccountTwo] ([Ent_No], [VrNo], [Mode_Pay_Rec], [Rec_Pay], [Ammount], [Ddate], [Disp], [From_Account], [To_Account], [Hand_Group], [Kwat], [Discount], [Hand], [SetViewOne], [Freezed], [IsEntryOnly], [GuidAC], [CurDate], [Hide], [ChqNo], [ChqDrawn], [Userss], [fy]) VALUES (N'BHES-0015', 26, N'CASH', N'PAYMENT', 1500, CAST(0x00009EED00000000 AS DateTime), N'PAID As cement bag', N'BHES-0002', N'BHES-0005', N'R', 0, 0, 0, N'B', 0, 0, NULL, CAST(0x00009EF500000000 AS DateTime), 0, NULL, NULL, N'Chandresh', N'11-12')
INSERT [dbo].[Mat_AccountTwo] ([Ent_No], [VrNo], [Mode_Pay_Rec], [Rec_Pay], [Ammount], [Ddate], [Disp], [From_Account], [To_Account], [Hand_Group], [Kwat], [Discount], [Hand], [SetViewOne], [Freezed], [IsEntryOnly], [GuidAC], [CurDate], [Hide], [ChqNo], [ChqDrawn], [Userss], [fy]) VALUES (N'BHES-0035', 27, N'PURCHASE', N'RECEIPT', 7500, CAST(0x00009EF400000000 AS DateTime), N'RECEIPT As bill', N'BHES-0012', N'BHES-0014', N'R', 0, 0, 0, N'B', 0, 0, NULL, CAST(0x00009FA500000000 AS DateTime), 0, N'CHEQUE NO ', N'FROM BANK NAME', N'Chandresh', N'11-12')
INSERT [dbo].[Mat_AccountTwo] ([Ent_No], [VrNo], [Mode_Pay_Rec], [Rec_Pay], [Ammount], [Ddate], [Disp], [From_Account], [To_Account], [Hand_Group], [Kwat], [Discount], [Hand], [SetViewOne], [Freezed], [IsEntryOnly], [GuidAC], [CurDate], [Hide], [ChqNo], [ChqDrawn], [Userss], [fy]) VALUES (N'BHES-0004', 28, N'CASH', N'PAYMENT', 6500, CAST(0x00009EFD00000000 AS DateTime), N'PAID As chiman jcb', N'BHES-0002', N'BHES-0001', N'R', 0, 0, 0, N'B', 0, 0, NULL, CAST(0x00009EF500000000 AS DateTime), 0, NULL, NULL, N'Chandresh', N'11-12')
INSERT [dbo].[Mat_AccountTwo] ([Ent_No], [VrNo], [Mode_Pay_Rec], [Rec_Pay], [Ammount], [Ddate], [Disp], [From_Account], [To_Account], [Hand_Group], [Kwat], [Discount], [Hand], [SetViewOne], [Freezed], [IsEntryOnly], [GuidAC], [CurDate], [Hide], [ChqNo], [ChqDrawn], [Userss], [fy]) VALUES (N'BHES-0032', 29, N'PURCHASE', N'RECEIPT', 1700, CAST(0x00009F1200000000 AS DateTime), N'RECEIPT As bill', N'BHES-0010', N'BHES-0014', N'R', 0, 0, 0, N'B', 0, 0, NULL, CAST(0x00009FA500000000 AS DateTime), 0, N'CHEQUE NO ', N'FROM BANK NAME', N'Chandresh', N'11-12')
INSERT [dbo].[Mat_AccountTwo] ([Ent_No], [VrNo], [Mode_Pay_Rec], [Rec_Pay], [Ammount], [Ddate], [Disp], [From_Account], [To_Account], [Hand_Group], [Kwat], [Discount], [Hand], [SetViewOne], [Freezed], [IsEntryOnly], [GuidAC], [CurDate], [Hide], [ChqNo], [ChqDrawn], [Userss], [fy]) VALUES (N'BHES-0031', 30, N'PURCHASE', N'RECEIPT', 3800, CAST(0x00009F1200000000 AS DateTime), N'RECEIPT As bill', N'BHES-0010', N'BHES-0014', N'R', 0, 0, 0, N'B', 0, 0, NULL, CAST(0x00009FA500000000 AS DateTime), 0, N'CHEQUE NO ', N'FROM BANK NAME', N'Chandresh', N'11-12')
INSERT [dbo].[Mat_AccountTwo] ([Ent_No], [VrNo], [Mode_Pay_Rec], [Rec_Pay], [Ammount], [Ddate], [Disp], [From_Account], [To_Account], [Hand_Group], [Kwat], [Discount], [Hand], [SetViewOne], [Freezed], [IsEntryOnly], [GuidAC], [CurDate], [Hide], [ChqNo], [ChqDrawn], [Userss], [fy]) VALUES (N'BHES-0019', 31, N'CASH', N'PAYMENT', 7600, CAST(0x00009F2600000000 AS DateTime), N'PAID As against bill', N'BHES-0002', N'BHES-0009', N'R', 0, 0, 0, N'B', 0, 0, NULL, CAST(0x00009FA100000000 AS DateTime), 0, N'CHEQUE NO ', N'FROM BANK NAME', N'Chandresh', N'11-12')
INSERT [dbo].[Mat_AccountTwo] ([Ent_No], [VrNo], [Mode_Pay_Rec], [Rec_Pay], [Ammount], [Ddate], [Disp], [From_Account], [To_Account], [Hand_Group], [Kwat], [Discount], [Hand], [SetViewOne], [Freezed], [IsEntryOnly], [GuidAC], [CurDate], [Hide], [ChqNo], [ChqDrawn], [Userss], [fy]) VALUES (N'BHES-0021', 32, N'CASH', N'PAYMENT', 21000, CAST(0x00009F2900000000 AS DateTime), N'PAID As against bill', N'BHES-0002', N'BHES-0011', N'R', 0, 0, 0, N'B', 0, 0, NULL, CAST(0x00009FA100000000 AS DateTime), 0, N'CHEQUE NO ', N'FROM BANK NAME', N'Chandresh', N'11-12')
INSERT [dbo].[Mat_AccountTwo] ([Ent_No], [VrNo], [Mode_Pay_Rec], [Rec_Pay], [Ammount], [Ddate], [Disp], [From_Account], [To_Account], [Hand_Group], [Kwat], [Discount], [Hand], [SetViewOne], [Freezed], [IsEntryOnly], [GuidAC], [CurDate], [Hide], [ChqNo], [ChqDrawn], [Userss], [fy]) VALUES (N'BHES-0022', 33, N'CASH', N'PAYMENT', 7500, CAST(0x00009F2B00000000 AS DateTime), N'PAID As against bill', N'BHES-0002', N'BHES-0012', N'R', 0, 0, 0, N'B', 0, 0, NULL, CAST(0x00009FA100000000 AS DateTime), 0, N'CHEQUE NO ', N'FROM BANK NAME', N'Chandresh', N'11-12')
INSERT [dbo].[Mat_AccountTwo] ([Ent_No], [VrNo], [Mode_Pay_Rec], [Rec_Pay], [Ammount], [Ddate], [Disp], [From_Account], [To_Account], [Hand_Group], [Kwat], [Discount], [Hand], [SetViewOne], [Freezed], [IsEntryOnly], [GuidAC], [CurDate], [Hide], [ChqNo], [ChqDrawn], [Userss], [fy]) VALUES (N'BHES-0024', 34, N'CASH', N'PAYMENT', 11000, CAST(0x00009F7600000000 AS DateTime), N'PAID As against bill', N'BHES-0002', N'BHES-0013', N'R', 0, 0, 0, N'B', 0, 0, NULL, CAST(0x00009FA100000000 AS DateTime), 0, N'CHEQUE NO ', N'FROM BANK NAME', N'Chandresh', N'11-12')
INSERT [dbo].[Mat_AccountTwo] ([Ent_No], [VrNo], [Mode_Pay_Rec], [Rec_Pay], [Ammount], [Ddate], [Disp], [From_Account], [To_Account], [Hand_Group], [Kwat], [Discount], [Hand], [SetViewOne], [Freezed], [IsEntryOnly], [GuidAC], [CurDate], [Hide], [ChqNo], [ChqDrawn], [Userss], [fy]) VALUES (N'BHES-0020', 35, N'CASH', N'PAYMENT', 5000, CAST(0x00009F7A00000000 AS DateTime), N'PAID As against bill', N'BHES-0002', N'BHES-0010', N'R', 0, 0, 0, N'B', 0, 0, NULL, CAST(0x00009FA100000000 AS DateTime), 0, N'CHEQUE NO ', N'FROM BANK NAME', N'Chandresh', N'11-12')
INSERT [dbo].[Mat_AccountTwo] ([Ent_No], [VrNo], [Mode_Pay_Rec], [Rec_Pay], [Ammount], [Ddate], [Disp], [From_Account], [To_Account], [Hand_Group], [Kwat], [Discount], [Hand], [SetViewOne], [Freezed], [IsEntryOnly], [GuidAC], [CurDate], [Hide], [ChqNo], [ChqDrawn], [Userss], [fy]) VALUES (N'BHES-0023', 36, N'CASH', N'PAYMENT', 200000, CAST(0x00009F8600000000 AS DateTime), N'PAID As against bill', N'BHES-0002', N'BHES-0007', N'R', 0, 0, 0, N'B', 0, 0, NULL, CAST(0x00009FA100000000 AS DateTime), 0, N'CHEQUE NO ', N'FROM BANK NAME', N'Chandresh', N'11-12')
INSERT [dbo].[Mat_AccountTwo] ([Ent_No], [VrNo], [Mode_Pay_Rec], [Rec_Pay], [Ammount], [Ddate], [Disp], [From_Account], [To_Account], [Hand_Group], [Kwat], [Discount], [Hand], [SetViewOne], [Freezed], [IsEntryOnly], [GuidAC], [CurDate], [Hide], [ChqNo], [ChqDrawn], [Userss], [fy]) VALUES (N'BHES-0037', 37, N'JOURNAL', N'PAYMENT', 680, CAST(0x00009FCD00000000 AS DateTime), N'
Payment To RADHEY SHYAM CEMENT', N'BHES-0018', N'BHES-0011', N'R', 0, 0, 0, N'B', 0, 0, NULL, CAST(0x00009FCD00000000 AS DateTime), 0, N'journal', N'journal', N'Chandresh', N'11-12')
INSERT [dbo].[Mat_AccountTwo] ([Ent_No], [VrNo], [Mode_Pay_Rec], [Rec_Pay], [Ammount], [Ddate], [Disp], [From_Account], [To_Account], [Hand_Group], [Kwat], [Discount], [Hand], [SetViewOne], [Freezed], [IsEntryOnly], [GuidAC], [CurDate], [Hide], [ChqNo], [ChqDrawn], [Userss], [fy]) VALUES (N'BHES-0038', 38, N'JOURNAL', N'PAYMENT', 500, CAST(0x00009FCD00000000 AS DateTime), N'
Payment To RAJU MARBLE', N'BHES-0018', N'BHES-0010', N'R', 0, 0, 0, N'B', 0, 0, NULL, CAST(0x00009FCD00000000 AS DateTime), 0, N'journal', N'journal', N'Chandresh', N'11-12')
INSERT [dbo].[Mat_AccountTwo] ([Ent_No], [VrNo], [Mode_Pay_Rec], [Rec_Pay], [Ammount], [Ddate], [Disp], [From_Account], [To_Account], [Hand_Group], [Kwat], [Discount], [Hand], [SetViewOne], [Freezed], [IsEntryOnly], [GuidAC], [CurDate], [Hide], [ChqNo], [ChqDrawn], [Userss], [fy]) VALUES (N'BHES-0039', 39, N'JOURNAL', N'RECEIPT', 504, CAST(0x00009FCD00000000 AS DateTime), N'
Receipt From VARDMAN MARBLE', N'BHES-0013', N'BHES-0018', N'R', 0, 0, 0, N'B', 0, 0, NULL, CAST(0x00009FCD00000000 AS DateTime), 0, N'journal', N'journal', N'Chandresh', N'11-12')
INSERT [dbo].[Mat_AccountTwo] ([Ent_No], [VrNo], [Mode_Pay_Rec], [Rec_Pay], [Ammount], [Ddate], [Disp], [From_Account], [To_Account], [Hand_Group], [Kwat], [Discount], [Hand], [SetViewOne], [Freezed], [IsEntryOnly], [GuidAC], [CurDate], [Hide], [ChqNo], [ChqDrawn], [Userss], [fy]) VALUES (N'BHES-0040', 40, N'CASH', N'PAYMENT', 8000, CAST(0x00009FD400000000 AS DateTime), N'PAID As AAGAINST BILL', N'BHES-0002', N'BHES-0016', N'R', 0, 0, 0, N'B', 0, 0, NULL, CAST(0x00009FD600000000 AS DateTime), 0, N'CHEQUE NO ', N'FROM BANK NAME', N'Chandresh', N'11-12')
INSERT [dbo].[Mat_AccountTwo] ([Ent_No], [VrNo], [Mode_Pay_Rec], [Rec_Pay], [Ammount], [Ddate], [Disp], [From_Account], [To_Account], [Hand_Group], [Kwat], [Discount], [Hand], [SetViewOne], [Freezed], [IsEntryOnly], [GuidAC], [CurDate], [Hide], [ChqNo], [ChqDrawn], [Userss], [fy]) VALUES (N'BHES-0041', 41, N'CASH', N'PAYMENT', 31000, CAST(0x0000A01400000000 AS DateTime), N'PAID As against bill', N'BHES-0002', N'BHES-0015', N'R', 0, 0, 0, N'B', 0, 0, NULL, CAST(0x0000A01400000000 AS DateTime), 0, N'CHEQUE NO ', N'FROM BANK NAME', N'Chandresh', N'11-12')
INSERT [dbo].[Mat_AccountTwo] ([Ent_No], [VrNo], [Mode_Pay_Rec], [Rec_Pay], [Ammount], [Ddate], [Disp], [From_Account], [To_Account], [Hand_Group], [Kwat], [Discount], [Hand], [SetViewOne], [Freezed], [IsEntryOnly], [GuidAC], [CurDate], [Hide], [ChqNo], [ChqDrawn], [Userss], [fy]) VALUES (N'BHES-0042', 42, N'CASH', N'PAYMENT', 50000, CAST(0x0000A01D00000000 AS DateTime), N'PAID As against bill', N'BHES-0002', N'BHES-0007', N'R', 0, 0, 0, N'B', 0, 0, NULL, CAST(0x0000A01E00000000 AS DateTime), 0, N'CHEQUE NO ', N'FROM BANK NAME', N'Chandresh', N'11-12')
INSERT [dbo].[Mat_AccountTwo] ([Ent_No], [VrNo], [Mode_Pay_Rec], [Rec_Pay], [Ammount], [Ddate], [Disp], [From_Account], [To_Account], [Hand_Group], [Kwat], [Discount], [Hand], [SetViewOne], [Freezed], [IsEntryOnly], [GuidAC], [CurDate], [Hide], [ChqNo], [ChqDrawn], [Userss], [fy]) VALUES (N'1D60-6611', 44, N'JOURNAL', N'PAYMENT', 479, CAST(0x0000A1CD00D1F088 AS DateTime), N'', N'BHES-0018', N'BHES-0015', N'R', 0, 0, 0, N'B', 0, 0, N'0044 ,1D60-6611,479,BHES-0015,BHES-0018,PAYMENT,JOURNAL,05/29/2013,,B,0,0,0,5/29/2013 12:44:55 PM,,,chandresh,0,0,0,R', CAST(0x0000A1CD00D21734 AS DateTime), 0, N'', N'', N'chandresh', N'13-14')
INSERT [dbo].[Mat_AccountTwo] ([Ent_No], [VrNo], [Mode_Pay_Rec], [Rec_Pay], [Ammount], [Ddate], [Disp], [From_Account], [To_Account], [Hand_Group], [Kwat], [Discount], [Hand], [SetViewOne], [Freezed], [IsEntryOnly], [GuidAC], [CurDate], [Hide], [ChqNo], [ChqDrawn], [Userss], [fy]) VALUES (N'376D-916F', 45, N'PURCHASE', N'RECEIPT', 8600, CAST(0x00009ED8013993C8 AS DateTime), N'as bill', N'BHES-0008', N'BHES-0014', N'R', 0, 0, 0, N'B', 0, 0, N'0045 ,376D-916F,8600,BHES-0014,BHES-0008,RECEIPT,PURCHASE,05/03/2011,as bill,B,0,0,0,5/31/2013 7:01:58 PM,,,chandresh,0,0,0,R', CAST(0x0000A1CF0139A688 AS DateTime), 0, N'', N'', N'chandresh', N'11-12')
INSERT [dbo].[Mat_AccountTwo] ([Ent_No], [VrNo], [Mode_Pay_Rec], [Rec_Pay], [Ammount], [Ddate], [Disp], [From_Account], [To_Account], [Hand_Group], [Kwat], [Discount], [Hand], [SetViewOne], [Freezed], [IsEntryOnly], [GuidAC], [CurDate], [Hide], [ChqNo], [ChqDrawn], [Userss], [fy]) VALUES (N'98A5-8B19', 46, N'CASH', N'PAYMENT', 6000, CAST(0x0000A34000CA3C44 AS DateTime), N'bhestan office electric work vijay sai electric', N'BHES-0002', N'BHES-0001', N'R', 0, 0, 0, N'B', 0, 0, N'0046 ,98A5-8B19,6000,BHES-0001,BHES-0002,PAYMENT,CASH,06/04/2014,bhestan office electric work vijay sai electric,B,0,0,0,6/5/2014 12:16:49 PM,,,chandresh,0,0,0,R', CAST(0x0000A34100CA5F6C AS DateTime), 0, N'', N'', N'chandresh', N'14-15')
INSERT [dbo].[Mat_AccountTwo] ([Ent_No], [VrNo], [Mode_Pay_Rec], [Rec_Pay], [Ammount], [Ddate], [Disp], [From_Account], [To_Account], [Hand_Group], [Kwat], [Discount], [Hand], [SetViewOne], [Freezed], [IsEntryOnly], [GuidAC], [CurDate], [Hide], [ChqNo], [ChqDrawn], [Userss], [fy]) VALUES (N'5AA1-497B', 48, N'SELL', N'PAYMENT', 800000, CAST(0x0000A12500000000 AS DateTime), N'as bill', N'17B0-4AD5', N'F0FD-BC16', N'R', 0, 0, 0, N'B', 0, 0, N'0048,5AA1-497B,800000,F0FD-BC16,17B0-4AD5,PAYMENT,SELL,12/12/2012,as bill,B,0,0,0,10/18/2014 4:25:28 PM,,,chandresh,0,0,0,R,,12-13', CAST(0x0000A3C8010EAAA0 AS DateTime), 0, N'', N'', N'chandresh', N'12-13')
INSERT [dbo].[Mat_AccountTwo] ([Ent_No], [VrNo], [Mode_Pay_Rec], [Rec_Pay], [Ammount], [Ddate], [Disp], [From_Account], [To_Account], [Hand_Group], [Kwat], [Discount], [Hand], [SetViewOne], [Freezed], [IsEntryOnly], [GuidAC], [CurDate], [Hide], [ChqNo], [ChqDrawn], [Userss], [fy]) VALUES (N'F507-6CA6', 50, N'CASH', N'RECEIPT', 800000, CAST(0x0000A3B600000000 AS DateTime), N'against work', N'F0FD-BC16', N'BHES-0002', N'R', 0, 0, 0, N'B', 0, 0, N'0050,F507-6CA6,800000,BHES-0002,F0FD-BC16,RECEIPT,CASH,9/30/2014,against work,B,0,0,0,10/19/2014 8:18:23 AM,,,chandresh,0,0,0,R,,14-15', CAST(0x0000A3C90088E294 AS DateTime), 0, N'', N'', N'chandresh', N'14-15')
INSERT [dbo].[Mat_AccountTwo] ([Ent_No], [VrNo], [Mode_Pay_Rec], [Rec_Pay], [Ammount], [Ddate], [Disp], [From_Account], [To_Account], [Hand_Group], [Kwat], [Discount], [Hand], [SetViewOne], [Freezed], [IsEntryOnly], [GuidAC], [CurDate], [Hide], [ChqNo], [ChqDrawn], [Userss], [fy]) VALUES (N'3272-F435', 49, N'CASH', N'PAYMENT', 53764, CAST(0x0000A41200000000 AS DateTime), N'as profit and same @ labh', N'BHES-0002', N'E12E-6A8B', N'R', 0, 0, 0, N'B', 0, 0, N'0049,3272-F435,53764,E12E-6A8B,BHES-0002,PAYMENT,CASH,12/31/2014,as profit and same @ labh,B,0,0,0,1/20/2015 2:05:49 AM,,,chandresh,0,0,0,R,,14-15', CAST(0x0000A42600228E7C AS DateTime), 0, N'', N'', N'chandresh', N'14-15')
INSERT [dbo].[Mat_AccountTwo] ([Ent_No], [VrNo], [Mode_Pay_Rec], [Rec_Pay], [Ammount], [Ddate], [Disp], [From_Account], [To_Account], [Hand_Group], [Kwat], [Discount], [Hand], [SetViewOne], [Freezed], [IsEntryOnly], [GuidAC], [CurDate], [Hide], [ChqNo], [ChqDrawn], [Userss], [fy]) VALUES (N'BF0A-6DA9', 53, N'CASH', N'PAYMENT', 80646, CAST(0x0000A41200000000 AS DateTime), N'as profit and same @ havala', N'BHES-0002', N'9B6D-8F87', N'R', 0, 0, 0, N'B', 0, 0, N'0053,BF0A-6DA9,80646,9B6D-8F87,BHES-0002,PAYMENT,CASH,12/31/2014,as profit and same @ havala,B,0,0,0,1/20/2015 2:06:11 AM,,,chandresh,0,0,0,R,,14-15', CAST(0x0000A4260022A844 AS DateTime), 0, N'', N'', N'chandresh', N'14-15')
INSERT [dbo].[Mat_AccountTwo] ([Ent_No], [VrNo], [Mode_Pay_Rec], [Rec_Pay], [Ammount], [Ddate], [Disp], [From_Account], [To_Account], [Hand_Group], [Kwat], [Discount], [Hand], [SetViewOne], [Freezed], [IsEntryOnly], [GuidAC], [CurDate], [Hide], [ChqNo], [ChqDrawn], [Userss], [fy]) VALUES (N'232C-40B0', 54, N'PNFJV', N'RECEIPT', 53764, CAST(0x0000A42600000000 AS DateTime), N'HAVALO FROM PROFIT AND LOSS( NET PROFIT   40 %) ', N'E12E-6A8B', N'0680-7B77', N'R', NULL, NULL, NULL, N'B', 0, 0, N'x', CAST(0x0000A4260022B2D0 AS DateTime), 0, N'x', N'x', N'chandresh', NULL)
INSERT [dbo].[Mat_AccountTwo] ([Ent_No], [VrNo], [Mode_Pay_Rec], [Rec_Pay], [Ammount], [Ddate], [Disp], [From_Account], [To_Account], [Hand_Group], [Kwat], [Discount], [Hand], [SetViewOne], [Freezed], [IsEntryOnly], [GuidAC], [CurDate], [Hide], [ChqNo], [ChqDrawn], [Userss], [fy]) VALUES (N'C38F-0B18', 55, N'PNFJV', N'RECEIPT', 80646, CAST(0x0000A42600000000 AS DateTime), N'HAVALO FROM PROFIT AND LOSS( NET PROFIT   60 %) ', N'9B6D-8F87', N'0680-7B77', N'R', NULL, NULL, NULL, N'B', 0, 0, N'x', CAST(0x0000A4260022B3FC AS DateTime), 0, N'x', N'x', N'chandresh', NULL)
/****** Object:  Table [dbo].[history_store]    Script Date: 03/10/2015 09:49:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[history_store](
	[timemark] [datetime] NOT NULL,
	[table_name] [nvarchar](50) NOT NULL,
	[pk_date_src] [nvarchar](400) NOT NULL,
	[pk_date_dest] [nvarchar](400) NOT NULL,
	[record_state] [smallint] NOT NULL,
 CONSTRAINT [history_store_primary] PRIMARY KEY NONCLUSTERED 
(
	[table_name] ASC,
	[pk_date_dest] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[history_store] ([timemark], [table_name], [pk_date_src], [pk_date_dest], [record_state]) VALUES (CAST(0x0000A427010BA729 AS DateTime), N'Supplier', N'<Sup_id>BHES-0001</Sup_id>', N'<Sup_id>BHES-0001</Sup_id>', 2)
INSERT [dbo].[history_store] ([timemark], [table_name], [pk_date_src], [pk_date_dest], [record_state]) VALUES (CAST(0x0000A427010BA72A AS DateTime), N'Supplier', N'<Sup_id>BHES-0002</Sup_id>', N'<Sup_id>BHES-0002</Sup_id>', 2)
INSERT [dbo].[history_store] ([timemark], [table_name], [pk_date_src], [pk_date_dest], [record_state]) VALUES (CAST(0x0000A427010BA780 AS DateTime), N'Supplier', N'<Sup_id>BHES-0003</Sup_id>', N'<Sup_id>BHES-0003</Sup_id>', 2)
INSERT [dbo].[history_store] ([timemark], [table_name], [pk_date_src], [pk_date_dest], [record_state]) VALUES (CAST(0x0000A427010BA780 AS DateTime), N'Supplier', N'<Sup_id>BHES-0004</Sup_id>', N'<Sup_id>BHES-0004</Sup_id>', 2)
INSERT [dbo].[history_store] ([timemark], [table_name], [pk_date_src], [pk_date_dest], [record_state]) VALUES (CAST(0x0000A427010BA781 AS DateTime), N'Supplier', N'<Sup_id>BHES-0005</Sup_id>', N'<Sup_id>BHES-0005</Sup_id>', 2)
INSERT [dbo].[history_store] ([timemark], [table_name], [pk_date_src], [pk_date_dest], [record_state]) VALUES (CAST(0x0000A427010BA781 AS DateTime), N'Supplier', N'<Sup_id>BHES-0006</Sup_id>', N'<Sup_id>BHES-0006</Sup_id>', 2)
INSERT [dbo].[history_store] ([timemark], [table_name], [pk_date_src], [pk_date_dest], [record_state]) VALUES (CAST(0x0000A427010BA782 AS DateTime), N'Supplier', N'<Sup_id>BHES-0007</Sup_id>', N'<Sup_id>BHES-0007</Sup_id>', 2)
INSERT [dbo].[history_store] ([timemark], [table_name], [pk_date_src], [pk_date_dest], [record_state]) VALUES (CAST(0x0000A427010BA782 AS DateTime), N'Supplier', N'<Sup_id>BHES-0008</Sup_id>', N'<Sup_id>BHES-0008</Sup_id>', 2)
INSERT [dbo].[history_store] ([timemark], [table_name], [pk_date_src], [pk_date_dest], [record_state]) VALUES (CAST(0x0000A427010BA782 AS DateTime), N'Supplier', N'<Sup_id>BHES-0009</Sup_id>', N'<Sup_id>BHES-0009</Sup_id>', 2)
INSERT [dbo].[history_store] ([timemark], [table_name], [pk_date_src], [pk_date_dest], [record_state]) VALUES (CAST(0x0000A427010BA783 AS DateTime), N'Supplier', N'<Sup_id>BHES-0010</Sup_id>', N'<Sup_id>BHES-0010</Sup_id>', 2)
INSERT [dbo].[history_store] ([timemark], [table_name], [pk_date_src], [pk_date_dest], [record_state]) VALUES (CAST(0x0000A427010BA783 AS DateTime), N'Supplier', N'<Sup_id>BHES-0011</Sup_id>', N'<Sup_id>BHES-0011</Sup_id>', 2)
INSERT [dbo].[history_store] ([timemark], [table_name], [pk_date_src], [pk_date_dest], [record_state]) VALUES (CAST(0x0000A427010BA784 AS DateTime), N'Supplier', N'<Sup_id>BHES-0012</Sup_id>', N'<Sup_id>BHES-0012</Sup_id>', 2)
INSERT [dbo].[history_store] ([timemark], [table_name], [pk_date_src], [pk_date_dest], [record_state]) VALUES (CAST(0x0000A427010BA784 AS DateTime), N'Supplier', N'<Sup_id>BHES-0013</Sup_id>', N'<Sup_id>BHES-0013</Sup_id>', 2)
INSERT [dbo].[history_store] ([timemark], [table_name], [pk_date_src], [pk_date_dest], [record_state]) VALUES (CAST(0x0000A427010BA785 AS DateTime), N'Supplier', N'<Sup_id>BHES-0014</Sup_id>', N'<Sup_id>BHES-0014</Sup_id>', 2)
INSERT [dbo].[history_store] ([timemark], [table_name], [pk_date_src], [pk_date_dest], [record_state]) VALUES (CAST(0x0000A427010BA785 AS DateTime), N'Supplier', N'<Sup_id>BHES-0015</Sup_id>', N'<Sup_id>BHES-0015</Sup_id>', 2)
INSERT [dbo].[history_store] ([timemark], [table_name], [pk_date_src], [pk_date_dest], [record_state]) VALUES (CAST(0x0000A427010BA785 AS DateTime), N'Supplier', N'<Sup_id>BHES-0016</Sup_id>', N'<Sup_id>BHES-0016</Sup_id>', 2)
INSERT [dbo].[history_store] ([timemark], [table_name], [pk_date_src], [pk_date_dest], [record_state]) VALUES (CAST(0x0000A427010BA786 AS DateTime), N'Supplier', N'<Sup_id>BHES-0017</Sup_id>', N'<Sup_id>BHES-0017</Sup_id>', 2)
INSERT [dbo].[history_store] ([timemark], [table_name], [pk_date_src], [pk_date_dest], [record_state]) VALUES (CAST(0x0000A427010BA786 AS DateTime), N'Supplier', N'<Sup_id>81C3-0001</Sup_id>', N'<Sup_id>81C3-0001</Sup_id>', 2)
INSERT [dbo].[history_store] ([timemark], [table_name], [pk_date_src], [pk_date_dest], [record_state]) VALUES (CAST(0x0000A427010BA786 AS DateTime), N'Supplier', N'<Sup_id>81C3-0002</Sup_id>', N'<Sup_id>81C3-0002</Sup_id>', 2)
INSERT [dbo].[history_store] ([timemark], [table_name], [pk_date_src], [pk_date_dest], [record_state]) VALUES (CAST(0x0000A427010BA787 AS DateTime), N'Supplier', N'<Sup_id>81C3-0003</Sup_id>', N'<Sup_id>81C3-0003</Sup_id>', 2)
INSERT [dbo].[history_store] ([timemark], [table_name], [pk_date_src], [pk_date_dest], [record_state]) VALUES (CAST(0x0000A427010BA787 AS DateTime), N'Supplier', N'<Sup_id>BHES-0018</Sup_id>', N'<Sup_id>BHES-0018</Sup_id>', 2)
INSERT [dbo].[history_store] ([timemark], [table_name], [pk_date_src], [pk_date_dest], [record_state]) VALUES (CAST(0x0000A427010BA788 AS DateTime), N'Supplier', N'<Sup_id>0680-7B77</Sup_id>', N'<Sup_id>0680-7B77</Sup_id>', 2)
INSERT [dbo].[history_store] ([timemark], [table_name], [pk_date_src], [pk_date_dest], [record_state]) VALUES (CAST(0x0000A427010BA788 AS DateTime), N'Supplier', N'<Sup_id>E12E-6A8B</Sup_id>', N'<Sup_id>E12E-6A8B</Sup_id>', 2)
INSERT [dbo].[history_store] ([timemark], [table_name], [pk_date_src], [pk_date_dest], [record_state]) VALUES (CAST(0x0000A427010BA788 AS DateTime), N'Supplier', N'<Sup_id>0000-0001</Sup_id>', N'<Sup_id>0000-0001</Sup_id>', 2)
INSERT [dbo].[history_store] ([timemark], [table_name], [pk_date_src], [pk_date_dest], [record_state]) VALUES (CAST(0x0000A3650086E921 AS DateTime), N'Mat_AccountTwo', N'<Ent_No>BHES-0005</Ent_No>', N'<Ent_No>BHES-0005</Ent_No>', 2)
INSERT [dbo].[history_store] ([timemark], [table_name], [pk_date_src], [pk_date_dest], [record_state]) VALUES (CAST(0x0000A3650086E921 AS DateTime), N'Mat_AccountTwo', N'<Ent_No>BHES-0001</Ent_No>', N'<Ent_No>BHES-0001</Ent_No>', 2)
INSERT [dbo].[history_store] ([timemark], [table_name], [pk_date_src], [pk_date_dest], [record_state]) VALUES (CAST(0x0000A3650086E921 AS DateTime), N'Mat_AccountTwo', N'<Ent_No>BHES-0002</Ent_No>', N'<Ent_No>BHES-0002</Ent_No>', 2)
INSERT [dbo].[history_store] ([timemark], [table_name], [pk_date_src], [pk_date_dest], [record_state]) VALUES (CAST(0x0000A3650086E921 AS DateTime), N'Mat_AccountTwo', N'<Ent_No>BHES-0025</Ent_No>', N'<Ent_No>BHES-0025</Ent_No>', 2)
INSERT [dbo].[history_store] ([timemark], [table_name], [pk_date_src], [pk_date_dest], [record_state]) VALUES (CAST(0x0000A3650086E921 AS DateTime), N'Mat_AccountTwo', N'<Ent_No>BHES-0027</Ent_No>', N'<Ent_No>BHES-0027</Ent_No>', 2)
INSERT [dbo].[history_store] ([timemark], [table_name], [pk_date_src], [pk_date_dest], [record_state]) VALUES (CAST(0x0000A3650086E921 AS DateTime), N'Mat_AccountTwo', N'<Ent_No>BHES-0036</Ent_No>', N'<Ent_No>BHES-0036</Ent_No>', 2)
INSERT [dbo].[history_store] ([timemark], [table_name], [pk_date_src], [pk_date_dest], [record_state]) VALUES (CAST(0x0000A3650086E921 AS DateTime), N'Mat_AccountTwo', N'<Ent_No>BHES-0007</Ent_No>', N'<Ent_No>BHES-0007</Ent_No>', 2)
INSERT [dbo].[history_store] ([timemark], [table_name], [pk_date_src], [pk_date_dest], [record_state]) VALUES (CAST(0x0000A3650086E921 AS DateTime), N'Mat_AccountTwo', N'<Ent_No>BHES-0008</Ent_No>', N'<Ent_No>BHES-0008</Ent_No>', 2)
INSERT [dbo].[history_store] ([timemark], [table_name], [pk_date_src], [pk_date_dest], [record_state]) VALUES (CAST(0x0000A3650086E921 AS DateTime), N'Mat_AccountTwo', N'<Ent_No>BHES-0006</Ent_No>', N'<Ent_No>BHES-0006</Ent_No>', 2)
INSERT [dbo].[history_store] ([timemark], [table_name], [pk_date_src], [pk_date_dest], [record_state]) VALUES (CAST(0x0000A3650086E921 AS DateTime), N'Mat_AccountTwo', N'<Ent_No>BHES-0009</Ent_No>', N'<Ent_No>BHES-0009</Ent_No>', 2)
INSERT [dbo].[history_store] ([timemark], [table_name], [pk_date_src], [pk_date_dest], [record_state]) VALUES (CAST(0x0000A3650086E921 AS DateTime), N'Mat_AccountTwo', N'<Ent_No>BHES-0026</Ent_No>', N'<Ent_No>BHES-0026</Ent_No>', 2)
INSERT [dbo].[history_store] ([timemark], [table_name], [pk_date_src], [pk_date_dest], [record_state]) VALUES (CAST(0x0000A3650086E921 AS DateTime), N'Mat_AccountTwo', N'<Ent_No>BHES-0010</Ent_No>', N'<Ent_No>BHES-0010</Ent_No>', 2)
INSERT [dbo].[history_store] ([timemark], [table_name], [pk_date_src], [pk_date_dest], [record_state]) VALUES (CAST(0x0000A3650086E921 AS DateTime), N'Mat_AccountTwo', N'<Ent_No>BHES-0012</Ent_No>', N'<Ent_No>BHES-0012</Ent_No>', 2)
INSERT [dbo].[history_store] ([timemark], [table_name], [pk_date_src], [pk_date_dest], [record_state]) VALUES (CAST(0x0000A3650086E921 AS DateTime), N'Mat_AccountTwo', N'<Ent_No>BHES-0011</Ent_No>', N'<Ent_No>BHES-0011</Ent_No>', 2)
INSERT [dbo].[history_store] ([timemark], [table_name], [pk_date_src], [pk_date_dest], [record_state]) VALUES (CAST(0x0000A3650086E921 AS DateTime), N'Mat_AccountTwo', N'<Ent_No>BHES-0013</Ent_No>', N'<Ent_No>BHES-0013</Ent_No>', 2)
INSERT [dbo].[history_store] ([timemark], [table_name], [pk_date_src], [pk_date_dest], [record_state]) VALUES (CAST(0x0000A3650086E921 AS DateTime), N'Mat_AccountTwo', N'<Ent_No>BHES-0034</Ent_No>', N'<Ent_No>BHES-0034</Ent_No>', 2)
INSERT [dbo].[history_store] ([timemark], [table_name], [pk_date_src], [pk_date_dest], [record_state]) VALUES (CAST(0x0000A3650086E921 AS DateTime), N'Mat_AccountTwo', N'<Ent_No>BHES-0028</Ent_No>', N'<Ent_No>BHES-0028</Ent_No>', 2)
INSERT [dbo].[history_store] ([timemark], [table_name], [pk_date_src], [pk_date_dest], [record_state]) VALUES (CAST(0x0000A3650086E921 AS DateTime), N'Mat_AccountTwo', N'<Ent_No>BHES-0014</Ent_No>', N'<Ent_No>BHES-0014</Ent_No>', 2)
INSERT [dbo].[history_store] ([timemark], [table_name], [pk_date_src], [pk_date_dest], [record_state]) VALUES (CAST(0x0000A3650086E921 AS DateTime), N'Mat_AccountTwo', N'<Ent_No>BHES-0003</Ent_No>', N'<Ent_No>BHES-0003</Ent_No>', 2)
INSERT [dbo].[history_store] ([timemark], [table_name], [pk_date_src], [pk_date_dest], [record_state]) VALUES (CAST(0x0000A3650086E921 AS DateTime), N'Mat_AccountTwo', N'<Ent_No>BHES-0030</Ent_No>', N'<Ent_No>BHES-0030</Ent_No>', 2)
INSERT [dbo].[history_store] ([timemark], [table_name], [pk_date_src], [pk_date_dest], [record_state]) VALUES (CAST(0x0000A3650086E921 AS DateTime), N'Mat_AccountTwo', N'<Ent_No>BHES-0016</Ent_No>', N'<Ent_No>BHES-0016</Ent_No>', 2)
INSERT [dbo].[history_store] ([timemark], [table_name], [pk_date_src], [pk_date_dest], [record_state]) VALUES (CAST(0x0000A3650086E921 AS DateTime), N'Mat_AccountTwo', N'<Ent_No>BHES-0029</Ent_No>', N'<Ent_No>BHES-0029</Ent_No>', 2)
INSERT [dbo].[history_store] ([timemark], [table_name], [pk_date_src], [pk_date_dest], [record_state]) VALUES (CAST(0x0000A3650086E921 AS DateTime), N'Mat_AccountTwo', N'<Ent_No>BHES-0033</Ent_No>', N'<Ent_No>BHES-0033</Ent_No>', 2)
INSERT [dbo].[history_store] ([timemark], [table_name], [pk_date_src], [pk_date_dest], [record_state]) VALUES (CAST(0x0000A3650086E921 AS DateTime), N'Mat_AccountTwo', N'<Ent_No>BHES-0017</Ent_No>', N'<Ent_No>BHES-0017</Ent_No>', 2)
INSERT [dbo].[history_store] ([timemark], [table_name], [pk_date_src], [pk_date_dest], [record_state]) VALUES (CAST(0x0000A3650086E921 AS DateTime), N'Mat_AccountTwo', N'<Ent_No>BHES-0018</Ent_No>', N'<Ent_No>BHES-0018</Ent_No>', 2)
INSERT [dbo].[history_store] ([timemark], [table_name], [pk_date_src], [pk_date_dest], [record_state]) VALUES (CAST(0x0000A3650086E921 AS DateTime), N'Mat_AccountTwo', N'<Ent_No>BHES-0015</Ent_No>', N'<Ent_No>BHES-0015</Ent_No>', 2)
INSERT [dbo].[history_store] ([timemark], [table_name], [pk_date_src], [pk_date_dest], [record_state]) VALUES (CAST(0x0000A3650086E921 AS DateTime), N'Mat_AccountTwo', N'<Ent_No>BHES-0035</Ent_No>', N'<Ent_No>BHES-0035</Ent_No>', 2)
INSERT [dbo].[history_store] ([timemark], [table_name], [pk_date_src], [pk_date_dest], [record_state]) VALUES (CAST(0x0000A3650086E921 AS DateTime), N'Mat_AccountTwo', N'<Ent_No>BHES-0004</Ent_No>', N'<Ent_No>BHES-0004</Ent_No>', 2)
INSERT [dbo].[history_store] ([timemark], [table_name], [pk_date_src], [pk_date_dest], [record_state]) VALUES (CAST(0x0000A3650086E921 AS DateTime), N'Mat_AccountTwo', N'<Ent_No>BHES-0032</Ent_No>', N'<Ent_No>BHES-0032</Ent_No>', 2)
INSERT [dbo].[history_store] ([timemark], [table_name], [pk_date_src], [pk_date_dest], [record_state]) VALUES (CAST(0x0000A3650086E921 AS DateTime), N'Mat_AccountTwo', N'<Ent_No>BHES-0031</Ent_No>', N'<Ent_No>BHES-0031</Ent_No>', 2)
INSERT [dbo].[history_store] ([timemark], [table_name], [pk_date_src], [pk_date_dest], [record_state]) VALUES (CAST(0x0000A3650086E921 AS DateTime), N'Mat_AccountTwo', N'<Ent_No>BHES-0019</Ent_No>', N'<Ent_No>BHES-0019</Ent_No>', 2)
INSERT [dbo].[history_store] ([timemark], [table_name], [pk_date_src], [pk_date_dest], [record_state]) VALUES (CAST(0x0000A3650086E921 AS DateTime), N'Mat_AccountTwo', N'<Ent_No>BHES-0021</Ent_No>', N'<Ent_No>BHES-0021</Ent_No>', 2)
INSERT [dbo].[history_store] ([timemark], [table_name], [pk_date_src], [pk_date_dest], [record_state]) VALUES (CAST(0x0000A3650086E921 AS DateTime), N'Mat_AccountTwo', N'<Ent_No>BHES-0022</Ent_No>', N'<Ent_No>BHES-0022</Ent_No>', 2)
INSERT [dbo].[history_store] ([timemark], [table_name], [pk_date_src], [pk_date_dest], [record_state]) VALUES (CAST(0x0000A3650086E921 AS DateTime), N'Mat_AccountTwo', N'<Ent_No>BHES-0024</Ent_No>', N'<Ent_No>BHES-0024</Ent_No>', 2)
INSERT [dbo].[history_store] ([timemark], [table_name], [pk_date_src], [pk_date_dest], [record_state]) VALUES (CAST(0x0000A3650086E921 AS DateTime), N'Mat_AccountTwo', N'<Ent_No>BHES-0020</Ent_No>', N'<Ent_No>BHES-0020</Ent_No>', 2)
INSERT [dbo].[history_store] ([timemark], [table_name], [pk_date_src], [pk_date_dest], [record_state]) VALUES (CAST(0x0000A3650086E921 AS DateTime), N'Mat_AccountTwo', N'<Ent_No>BHES-0023</Ent_No>', N'<Ent_No>BHES-0023</Ent_No>', 2)
INSERT [dbo].[history_store] ([timemark], [table_name], [pk_date_src], [pk_date_dest], [record_state]) VALUES (CAST(0x0000A3650086E921 AS DateTime), N'Mat_AccountTwo', N'<Ent_No>BHES-0037</Ent_No>', N'<Ent_No>BHES-0037</Ent_No>', 2)
INSERT [dbo].[history_store] ([timemark], [table_name], [pk_date_src], [pk_date_dest], [record_state]) VALUES (CAST(0x0000A3650086E921 AS DateTime), N'Mat_AccountTwo', N'<Ent_No>BHES-0038</Ent_No>', N'<Ent_No>BHES-0038</Ent_No>', 2)
INSERT [dbo].[history_store] ([timemark], [table_name], [pk_date_src], [pk_date_dest], [record_state]) VALUES (CAST(0x0000A3650086E921 AS DateTime), N'Mat_AccountTwo', N'<Ent_No>BHES-0039</Ent_No>', N'<Ent_No>BHES-0039</Ent_No>', 2)
INSERT [dbo].[history_store] ([timemark], [table_name], [pk_date_src], [pk_date_dest], [record_state]) VALUES (CAST(0x0000A3650086E921 AS DateTime), N'Mat_AccountTwo', N'<Ent_No>BHES-0040</Ent_No>', N'<Ent_No>BHES-0040</Ent_No>', 2)
INSERT [dbo].[history_store] ([timemark], [table_name], [pk_date_src], [pk_date_dest], [record_state]) VALUES (CAST(0x0000A3650086E921 AS DateTime), N'Mat_AccountTwo', N'<Ent_No>BHES-0041</Ent_No>', N'<Ent_No>BHES-0041</Ent_No>', 2)
INSERT [dbo].[history_store] ([timemark], [table_name], [pk_date_src], [pk_date_dest], [record_state]) VALUES (CAST(0x0000A3650086E921 AS DateTime), N'Mat_AccountTwo', N'<Ent_No>BHES-0042</Ent_No>', N'<Ent_No>BHES-0042</Ent_No>', 2)
INSERT [dbo].[history_store] ([timemark], [table_name], [pk_date_src], [pk_date_dest], [record_state]) VALUES (CAST(0x0000A3C800C3EE44 AS DateTime), N'Mat_AccountTwo', N'<Ent_No>8FF2-C498</Ent_No>', N'<Ent_No>8FF2-C498</Ent_No>', 3)
INSERT [dbo].[history_store] ([timemark], [table_name], [pk_date_src], [pk_date_dest], [record_state]) VALUES (CAST(0x0000A3650086E917 AS DateTime), N'Mat_AccountTwo', N'<Ent_No>1D60-6611</Ent_No>', N'<Ent_No>1D60-6611</Ent_No>', 2)
INSERT [dbo].[history_store] ([timemark], [table_name], [pk_date_src], [pk_date_dest], [record_state]) VALUES (CAST(0x0000A2EF010AD4BC AS DateTime), N'Mat_AccountTwo', N'<Ent_No>376D-916F</Ent_No>', N'<Ent_No>376D-916F</Ent_No>', 2)
INSERT [dbo].[history_store] ([timemark], [table_name], [pk_date_src], [pk_date_dest], [record_state]) VALUES (CAST(0x0000A3650086E917 AS DateTime), N'Mat_AccountTwo', N'<Ent_No>98A5-8B19</Ent_No>', N'<Ent_No>98A5-8B19</Ent_No>', 1)
INSERT [dbo].[history_store] ([timemark], [table_name], [pk_date_src], [pk_date_dest], [record_state]) VALUES (CAST(0x0000A427010BA789 AS DateTime), N'Supplier', N'<Sup_id>17B0-4AD5</Sup_id>', N'<Sup_id>17B0-4AD5</Sup_id>', 1)
INSERT [dbo].[history_store] ([timemark], [table_name], [pk_date_src], [pk_date_dest], [record_state]) VALUES (CAST(0x0000A427010BA789 AS DateTime), N'Supplier', N'<Sup_id>F0FD-BC16</Sup_id>', N'<Sup_id>F0FD-BC16</Sup_id>', 1)
INSERT [dbo].[history_store] ([timemark], [table_name], [pk_date_src], [pk_date_dest], [record_state]) VALUES (CAST(0x0000A3C800C48738 AS DateTime), N'Mat_AccountTwo', N'<Ent_No>5AA1-497B</Ent_No>', N'<Ent_No>5AA1-497B</Ent_No>', 1)
INSERT [dbo].[history_store] ([timemark], [table_name], [pk_date_src], [pk_date_dest], [record_state]) VALUES (CAST(0x0000A3C9003EC316 AS DateTime), N'Mat_AccountTwo', N'<Ent_No>F507-6CA6</Ent_No>', N'<Ent_No>F507-6CA6</Ent_No>', 1)
INSERT [dbo].[history_store] ([timemark], [table_name], [pk_date_src], [pk_date_dest], [record_state]) VALUES (CAST(0x0000A427010BA78A AS DateTime), N'Supplier', N'<Sup_id>9B6D-8F87</Sup_id>', N'<Sup_id>9B6D-8F87</Sup_id>', 1)
INSERT [dbo].[history_store] ([timemark], [table_name], [pk_date_src], [pk_date_dest], [record_state]) VALUES (CAST(0x0000A4270100904E AS DateTime), N'Mat_AccountTwo', N'<Ent_No>B964-DB3A</Ent_No>', N'<Ent_No>B964-DB3A</Ent_No>', 1)
INSERT [dbo].[history_store] ([timemark], [table_name], [pk_date_src], [pk_date_dest], [record_state]) VALUES (CAST(0x0000A427010114AF AS DateTime), N'Mat_AccountTwo', N'<Ent_No>3272-F435</Ent_No>', N'<Ent_No>3272-F435</Ent_No>', 1)
INSERT [dbo].[history_store] ([timemark], [table_name], [pk_date_src], [pk_date_dest], [record_state]) VALUES (CAST(0x0000A42701012E54 AS DateTime), N'Mat_AccountTwo', N'<Ent_No>BF0A-6DA9</Ent_No>', N'<Ent_No>BF0A-6DA9</Ent_No>', 1)
INSERT [dbo].[history_store] ([timemark], [table_name], [pk_date_src], [pk_date_dest], [record_state]) VALUES (CAST(0x0000A4270101383F AS DateTime), N'Mat_AccountTwo', N'<Ent_No>232C-40B0</Ent_No>', N'<Ent_No>232C-40B0</Ent_No>', 1)
INSERT [dbo].[history_store] ([timemark], [table_name], [pk_date_src], [pk_date_dest], [record_state]) VALUES (CAST(0x0000A427010139A6 AS DateTime), N'Mat_AccountTwo', N'<Ent_No>C38F-0B18</Ent_No>', N'<Ent_No>C38F-0B18</Ent_No>', 1)
/****** Object:  Table [dbo].[GroupBySupplier1]    Script Date: 03/10/2015 09:49:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GroupBySupplier1](
	[GrpIdSupplier] [int] NULL,
	[GroupSupplierName] [nvarchar](255) NULL,
	[GuIdSupplier] [nvarchar](255) NULL,
	[ChildOf] [int] NULL
) ON [PRIMARY]
GO
INSERT [dbo].[GroupBySupplier1] ([GrpIdSupplier], [GroupSupplierName], [GuIdSupplier], [ChildOf]) VALUES (35, N'Entry Only', NULL, NULL)
INSERT [dbo].[GroupBySupplier1] ([GrpIdSupplier], [GroupSupplierName], [GuIdSupplier], [ChildOf]) VALUES (4, N'branch/division', NULL, NULL)
INSERT [dbo].[GroupBySupplier1] ([GrpIdSupplier], [GroupSupplierName], [GuIdSupplier], [ChildOf]) VALUES (40, N'Capital Account', NULL, NULL)
INSERT [dbo].[GroupBySupplier1] ([GrpIdSupplier], [GroupSupplierName], [GuIdSupplier], [ChildOf]) VALUES (27, N'Sundry Creaditor', NULL, NULL)
INSERT [dbo].[GroupBySupplier1] ([GrpIdSupplier], [GroupSupplierName], [GuIdSupplier], [ChildOf]) VALUES (26, N'Sundry Debitor', NULL, NULL)
INSERT [dbo].[GroupBySupplier1] ([GrpIdSupplier], [GroupSupplierName], [GuIdSupplier], [ChildOf]) VALUES (10, N'Misllenious Expance', NULL, NULL)
INSERT [dbo].[GroupBySupplier1] ([GrpIdSupplier], [GroupSupplierName], [GuIdSupplier], [ChildOf]) VALUES (10, N'Salary Account', NULL, NULL)
INSERT [dbo].[GroupBySupplier1] ([GrpIdSupplier], [GroupSupplierName], [GuIdSupplier], [ChildOf]) VALUES (6, N'Cash', NULL, NULL)
INSERT [dbo].[GroupBySupplier1] ([GrpIdSupplier], [GroupSupplierName], [GuIdSupplier], [ChildOf]) VALUES (2, N'Bank', NULL, NULL)
INSERT [dbo].[GroupBySupplier1] ([GrpIdSupplier], [GroupSupplierName], [GuIdSupplier], [ChildOf]) VALUES (21, N'Purchase', NULL, NULL)
INSERT [dbo].[GroupBySupplier1] ([GrpIdSupplier], [GroupSupplierName], [GuIdSupplier], [ChildOf]) VALUES (29, N'Loan', NULL, NULL)
INSERT [dbo].[GroupBySupplier1] ([GrpIdSupplier], [GroupSupplierName], [GuIdSupplier], [ChildOf]) VALUES (12, N'Taxes', NULL, NULL)
INSERT [dbo].[GroupBySupplier1] ([GrpIdSupplier], [GroupSupplierName], [GuIdSupplier], [ChildOf]) VALUES (23, N'sell', NULL, NULL)
INSERT [dbo].[GroupBySupplier1] ([GrpIdSupplier], [GroupSupplierName], [GuIdSupplier], [ChildOf]) VALUES (15, N'Misllenious income', NULL, NULL)
INSERT [dbo].[GroupBySupplier1] ([GrpIdSupplier], [GroupSupplierName], [GuIdSupplier], [ChildOf]) VALUES (44, N'PROFIT AND LOSS', NULL, NULL)
INSERT [dbo].[GroupBySupplier1] ([GrpIdSupplier], [GroupSupplierName], [GuIdSupplier], [ChildOf]) VALUES (6, N'PETTY CASH', NULL, NULL)
INSERT [dbo].[GroupBySupplier1] ([GrpIdSupplier], [GroupSupplierName], [GuIdSupplier], [ChildOf]) VALUES (35, N'Entry Only', NULL, NULL)
INSERT [dbo].[GroupBySupplier1] ([GrpIdSupplier], [GroupSupplierName], [GuIdSupplier], [ChildOf]) VALUES (4, N'branch/division', NULL, NULL)
INSERT [dbo].[GroupBySupplier1] ([GrpIdSupplier], [GroupSupplierName], [GuIdSupplier], [ChildOf]) VALUES (40, N'Capital Account', NULL, NULL)
INSERT [dbo].[GroupBySupplier1] ([GrpIdSupplier], [GroupSupplierName], [GuIdSupplier], [ChildOf]) VALUES (27, N'Sundry Creaditor', NULL, NULL)
INSERT [dbo].[GroupBySupplier1] ([GrpIdSupplier], [GroupSupplierName], [GuIdSupplier], [ChildOf]) VALUES (26, N'Sundry Debitor', NULL, NULL)
INSERT [dbo].[GroupBySupplier1] ([GrpIdSupplier], [GroupSupplierName], [GuIdSupplier], [ChildOf]) VALUES (10, N'Misllenious Expance', NULL, NULL)
INSERT [dbo].[GroupBySupplier1] ([GrpIdSupplier], [GroupSupplierName], [GuIdSupplier], [ChildOf]) VALUES (10, N'Salary Account', NULL, NULL)
INSERT [dbo].[GroupBySupplier1] ([GrpIdSupplier], [GroupSupplierName], [GuIdSupplier], [ChildOf]) VALUES (6, N'Cash', NULL, NULL)
INSERT [dbo].[GroupBySupplier1] ([GrpIdSupplier], [GroupSupplierName], [GuIdSupplier], [ChildOf]) VALUES (2, N'Bank', NULL, NULL)
INSERT [dbo].[GroupBySupplier1] ([GrpIdSupplier], [GroupSupplierName], [GuIdSupplier], [ChildOf]) VALUES (21, N'Purchase', NULL, NULL)
INSERT [dbo].[GroupBySupplier1] ([GrpIdSupplier], [GroupSupplierName], [GuIdSupplier], [ChildOf]) VALUES (29, N'Loan', NULL, NULL)
INSERT [dbo].[GroupBySupplier1] ([GrpIdSupplier], [GroupSupplierName], [GuIdSupplier], [ChildOf]) VALUES (12, N'Taxes', NULL, NULL)
INSERT [dbo].[GroupBySupplier1] ([GrpIdSupplier], [GroupSupplierName], [GuIdSupplier], [ChildOf]) VALUES (23, N'sell', NULL, NULL)
INSERT [dbo].[GroupBySupplier1] ([GrpIdSupplier], [GroupSupplierName], [GuIdSupplier], [ChildOf]) VALUES (15, N'Misllenious income', NULL, NULL)
INSERT [dbo].[GroupBySupplier1] ([GrpIdSupplier], [GroupSupplierName], [GuIdSupplier], [ChildOf]) VALUES (44, N'PROFIT AND LOSS', NULL, NULL)
INSERT [dbo].[GroupBySupplier1] ([GrpIdSupplier], [GroupSupplierName], [GuIdSupplier], [ChildOf]) VALUES (6, N'PETTY CASH', NULL, NULL)
/****** Object:  Table [dbo].[GroupBySupplier]    Script Date: 03/10/2015 09:49:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GroupBySupplier](
	[GrpIdSupplier] [int] NOT NULL,
	[GroupSupplierName] [nvarchar](50) NULL,
	[childOf] [int] NULL,
	[Display] [bit] NULL,
	[ClosingBalance] [float] NULL,
 CONSTRAINT [GroupBySupplier_PrimaryKey] PRIMARY KEY NONCLUSTERED 
(
	[GrpIdSupplier] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[GroupBySupplier] ([GrpIdSupplier], [GroupSupplierName], [childOf], [Display], [ClosingBalance]) VALUES (1, N'_Primary', 1, 0, 0)
INSERT [dbo].[GroupBySupplier] ([GrpIdSupplier], [GroupSupplierName], [childOf], [Display], [ClosingBalance]) VALUES (2, N'Bank Accounts', 7, 1, 0)
INSERT [dbo].[GroupBySupplier] ([GrpIdSupplier], [GroupSupplierName], [childOf], [Display], [ClosingBalance]) VALUES (3, N'Bank OD A/c', 18, 1, 0)
INSERT [dbo].[GroupBySupplier] ([GrpIdSupplier], [GroupSupplierName], [childOf], [Display], [ClosingBalance]) VALUES (4, N'Branch / Divisions', 30, 0, 0)
INSERT [dbo].[GroupBySupplier] ([GrpIdSupplier], [GroupSupplierName], [childOf], [Display], [ClosingBalance]) VALUES (5, N'Capital Account', 30, 0, 0)
INSERT [dbo].[GroupBySupplier] ([GrpIdSupplier], [GroupSupplierName], [childOf], [Display], [ClosingBalance]) VALUES (6, N'Cash-In-Hand', 7, 1, 0)
INSERT [dbo].[GroupBySupplier] ([GrpIdSupplier], [GroupSupplierName], [childOf], [Display], [ClosingBalance]) VALUES (7, N'Current Assets', 31, 0, 0)
INSERT [dbo].[GroupBySupplier] ([GrpIdSupplier], [GroupSupplierName], [childOf], [Display], [ClosingBalance]) VALUES (8, N'Current Liabilities', 30, 0, 0)
INSERT [dbo].[GroupBySupplier] ([GrpIdSupplier], [GroupSupplierName], [childOf], [Display], [ClosingBalance]) VALUES (9, N'Deposits (Assets)', 7, 1, 0)
INSERT [dbo].[GroupBySupplier] ([GrpIdSupplier], [GroupSupplierName], [childOf], [Display], [ClosingBalance]) VALUES (10, N'Direct Expenses', 32, 1, 0)
INSERT [dbo].[GroupBySupplier] ([GrpIdSupplier], [GroupSupplierName], [childOf], [Display], [ClosingBalance]) VALUES (11, N'Direct Incomes', 33, 1, 0)
INSERT [dbo].[GroupBySupplier] ([GrpIdSupplier], [GroupSupplierName], [childOf], [Display], [ClosingBalance]) VALUES (12, N'Duties & Taxes', 8, 1, 0)
INSERT [dbo].[GroupBySupplier] ([GrpIdSupplier], [GroupSupplierName], [childOf], [Display], [ClosingBalance]) VALUES (13, N'Fixed Assets', 31, 0, 0)
INSERT [dbo].[GroupBySupplier] ([GrpIdSupplier], [GroupSupplierName], [childOf], [Display], [ClosingBalance]) VALUES (14, N'Indirect Expenses', 32, 1, 0)
INSERT [dbo].[GroupBySupplier] ([GrpIdSupplier], [GroupSupplierName], [childOf], [Display], [ClosingBalance]) VALUES (15, N'Indirect Incomes', 33, 1, 0)
INSERT [dbo].[GroupBySupplier] ([GrpIdSupplier], [GroupSupplierName], [childOf], [Display], [ClosingBalance]) VALUES (16, N'Investments', 31, 0, 0)
INSERT [dbo].[GroupBySupplier] ([GrpIdSupplier], [GroupSupplierName], [childOf], [Display], [ClosingBalance]) VALUES (17, N'Loans & Advances (Assets)', 7, 1, 0)
INSERT [dbo].[GroupBySupplier] ([GrpIdSupplier], [GroupSupplierName], [childOf], [Display], [ClosingBalance]) VALUES (18, N'Loans (Liability)', 30, 0, 0)
INSERT [dbo].[GroupBySupplier] ([GrpIdSupplier], [GroupSupplierName], [childOf], [Display], [ClosingBalance]) VALUES (19, N'Misc. Expenses (Assets)', 31, 0, 0)
INSERT [dbo].[GroupBySupplier] ([GrpIdSupplier], [GroupSupplierName], [childOf], [Display], [ClosingBalance]) VALUES (20, N'Provisions', 8, 1, 0)
INSERT [dbo].[GroupBySupplier] ([GrpIdSupplier], [GroupSupplierName], [childOf], [Display], [ClosingBalance]) VALUES (21, N'Purchase Accounts', 32, 1, 0)
INSERT [dbo].[GroupBySupplier] ([GrpIdSupplier], [GroupSupplierName], [childOf], [Display], [ClosingBalance]) VALUES (22, N'Reserves & Surplus', 5, 1, 0)
INSERT [dbo].[GroupBySupplier] ([GrpIdSupplier], [GroupSupplierName], [childOf], [Display], [ClosingBalance]) VALUES (23, N'Sales Account', 33, 1, 0)
INSERT [dbo].[GroupBySupplier] ([GrpIdSupplier], [GroupSupplierName], [childOf], [Display], [ClosingBalance]) VALUES (24, N'Secured Loans', 18, 1, 0)
INSERT [dbo].[GroupBySupplier] ([GrpIdSupplier], [GroupSupplierName], [childOf], [Display], [ClosingBalance]) VALUES (25, N'Stock-In-Hand', 7, 1, 0)
INSERT [dbo].[GroupBySupplier] ([GrpIdSupplier], [GroupSupplierName], [childOf], [Display], [ClosingBalance]) VALUES (26, N'Sundry Debtors', 7, 1, 0)
INSERT [dbo].[GroupBySupplier] ([GrpIdSupplier], [GroupSupplierName], [childOf], [Display], [ClosingBalance]) VALUES (27, N'Sundry Creditors', 8, 1, 0)
INSERT [dbo].[GroupBySupplier] ([GrpIdSupplier], [GroupSupplierName], [childOf], [Display], [ClosingBalance]) VALUES (28, N'Suspense A/c', 30, 0, 0)
INSERT [dbo].[GroupBySupplier] ([GrpIdSupplier], [GroupSupplierName], [childOf], [Display], [ClosingBalance]) VALUES (29, N'Unsecured Loans', 18, 1, 0)
INSERT [dbo].[GroupBySupplier] ([GrpIdSupplier], [GroupSupplierName], [childOf], [Display], [ClosingBalance]) VALUES (30, N'LIABILITIES', 1, 0, 0)
INSERT [dbo].[GroupBySupplier] ([GrpIdSupplier], [GroupSupplierName], [childOf], [Display], [ClosingBalance]) VALUES (31, N'ASSETS', 1, 0, 0)
INSERT [dbo].[GroupBySupplier] ([GrpIdSupplier], [GroupSupplierName], [childOf], [Display], [ClosingBalance]) VALUES (32, N'EXPENSES', 1, 0, 0)
INSERT [dbo].[GroupBySupplier] ([GrpIdSupplier], [GroupSupplierName], [childOf], [Display], [ClosingBalance]) VALUES (33, N'INCOME', 1, 0, 0)
INSERT [dbo].[GroupBySupplier] ([GrpIdSupplier], [GroupSupplierName], [childOf], [Display], [ClosingBalance]) VALUES (34, N'Members Ledger', 7, 1, 0)
INSERT [dbo].[GroupBySupplier] ([GrpIdSupplier], [GroupSupplierName], [childOf], [Display], [ClosingBalance]) VALUES (35, N'Branch Div', 4, 1, 0)
INSERT [dbo].[GroupBySupplier] ([GrpIdSupplier], [GroupSupplierName], [childOf], [Display], [ClosingBalance]) VALUES (36, N'Suspence A/c', 28, 1, 0)
INSERT [dbo].[GroupBySupplier] ([GrpIdSupplier], [GroupSupplierName], [childOf], [Display], [ClosingBalance]) VALUES (37, N'Fixed assets', 13, 1, 0)
INSERT [dbo].[GroupBySupplier] ([GrpIdSupplier], [GroupSupplierName], [childOf], [Display], [ClosingBalance]) VALUES (38, N'Current Liability', 8, 1, 0)
INSERT [dbo].[GroupBySupplier] ([GrpIdSupplier], [GroupSupplierName], [childOf], [Display], [ClosingBalance]) VALUES (39, N'Current Assets', 7, 1, 0)
INSERT [dbo].[GroupBySupplier] ([GrpIdSupplier], [GroupSupplierName], [childOf], [Display], [ClosingBalance]) VALUES (40, N'Capital', 5, 1, 0)
INSERT [dbo].[GroupBySupplier] ([GrpIdSupplier], [GroupSupplierName], [childOf], [Display], [ClosingBalance]) VALUES (41, N'Drawings', 1, 0, 0)
INSERT [dbo].[GroupBySupplier] ([GrpIdSupplier], [GroupSupplierName], [childOf], [Display], [ClosingBalance]) VALUES (42, N'Closing Stock', 1, 0, 0)
INSERT [dbo].[GroupBySupplier] ([GrpIdSupplier], [GroupSupplierName], [childOf], [Display], [ClosingBalance]) VALUES (43, N'Profit and Loss', 1, 0, 0)
INSERT [dbo].[GroupBySupplier] ([GrpIdSupplier], [GroupSupplierName], [childOf], [Display], [ClosingBalance]) VALUES (44, N'Profit and loss A/c', 43, 1, 0)
INSERT [dbo].[GroupBySupplier] ([GrpIdSupplier], [GroupSupplierName], [childOf], [Display], [ClosingBalance]) VALUES (45, N'Petty Cash', 7, 1, 0)
INSERT [dbo].[GroupBySupplier] ([GrpIdSupplier], [GroupSupplierName], [childOf], [Display], [ClosingBalance]) VALUES (46, N'Land and Building', 13, 1, 0)
INSERT [dbo].[GroupBySupplier] ([GrpIdSupplier], [GroupSupplierName], [childOf], [Display], [ClosingBalance]) VALUES (47, N'Expance Asset', 19, 1, 0)
/****** Object:  Table [dbo].[GroupByItem]    Script Date: 03/10/2015 09:49:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GroupByItem](
	[GrpIdItem] [nvarchar](255) NOT NULL,
	[GroupItemName] [nvarchar](255) NULL,
	[GuIdGroup] [nvarchar](255) NULL,
	[ChildOF] [nvarchar](255) NULL,
 CONSTRAINT [GroupByItem_PrimaryKey] PRIMARY KEY NONCLUSTERED 
(
	[GrpIdItem] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[GroupByItem] ([GrpIdItem], [GroupItemName], [GuIdGroup], [ChildOF]) VALUES (N'0001', N'Steel', N'', N'')
INSERT [dbo].[GroupByItem] ([GrpIdItem], [GroupItemName], [GuIdGroup], [ChildOF]) VALUES (N'0002', N'Row Material', N'', N'')
INSERT [dbo].[GroupByItem] ([GrpIdItem], [GroupItemName], [GuIdGroup], [ChildOF]) VALUES (N'0003', N'Cement', N'', N'')
INSERT [dbo].[GroupByItem] ([GrpIdItem], [GroupItemName], [GuIdGroup], [ChildOF]) VALUES (N'0004', N'Flooring', N'', N'')
INSERT [dbo].[GroupByItem] ([GrpIdItem], [GroupItemName], [GuIdGroup], [ChildOF]) VALUES (N'0005', N'Plumbing', N'', N'')
INSERT [dbo].[GroupByItem] ([GrpIdItem], [GroupItemName], [GuIdGroup], [ChildOF]) VALUES (N'0006', N'Hardwere', N'', N'')
INSERT [dbo].[GroupByItem] ([GrpIdItem], [GroupItemName], [GuIdGroup], [ChildOF]) VALUES (N'0007', N'Toilet Fixture', N'', N'')
INSERT [dbo].[GroupByItem] ([GrpIdItem], [GroupItemName], [GuIdGroup], [ChildOF]) VALUES (N'0008', N'Electric Fitting', N'', N'')
/****** Object:  Table [dbo].[AccountGroup]    Script Date: 03/10/2015 09:49:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AccountGroup](
	[AcId] [int] NOT NULL,
	[AcGroup] [nvarchar](255) NULL,
	[CloBalance] [float] NULL,
 CONSTRAINT [AcoountGroup_PrimaryKey] PRIMARY KEY NONCLUSTERED 
(
	[AcId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[AccountGroup] ([AcId], [AcGroup], [CloBalance]) VALUES (1, N'_Primary', 0)
INSERT [dbo].[AccountGroup] ([AcId], [AcGroup], [CloBalance]) VALUES (2, N'Current Assets', 0)
INSERT [dbo].[AccountGroup] ([AcId], [AcGroup], [CloBalance]) VALUES (3, N'Loan (Liability)', 0)
INSERT [dbo].[AccountGroup] ([AcId], [AcGroup], [CloBalance]) VALUES (4, N'LIABILITIES', 0)
INSERT [dbo].[AccountGroup] ([AcId], [AcGroup], [CloBalance]) VALUES (5, N'ASSETS', 0)
INSERT [dbo].[AccountGroup] ([AcId], [AcGroup], [CloBalance]) VALUES (6, N'EXPENSES', 0)
INSERT [dbo].[AccountGroup] ([AcId], [AcGroup], [CloBalance]) VALUES (7, N'INCOME', 0)
INSERT [dbo].[AccountGroup] ([AcId], [AcGroup], [CloBalance]) VALUES (8, N'Current Liabilities', 0)
INSERT [dbo].[AccountGroup] ([AcId], [AcGroup], [CloBalance]) VALUES (9, N'MEMBERS LEDGER', 0)
INSERT [dbo].[AccountGroup] ([AcId], [AcGroup], [CloBalance]) VALUES (10, N'Capital Account', 0)
INSERT [dbo].[AccountGroup] ([AcId], [AcGroup], [CloBalance]) VALUES (11, N'Fixed Assets', 0)
INSERT [dbo].[AccountGroup] ([AcId], [AcGroup], [CloBalance]) VALUES (12, N'Branch / Divisions', 0)
INSERT [dbo].[AccountGroup] ([AcId], [AcGroup], [CloBalance]) VALUES (13, N'Suspense A/c', 0)
/****** Object:  Table [dbo].[del_Mat_AccountTwo]    Script Date: 03/10/2015 09:49:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[del_Mat_AccountTwo](
	[Ent_No] [nvarchar](255) NOT NULL,
	[VrNo] [int] NOT NULL,
	[Mode_Pay_Rec] [nvarchar](255) NULL,
	[Rec_Pay] [nvarchar](255) NULL,
	[Ammount] [float] NULL,
	[Ddate] [datetime] NULL,
	[Disp] [nvarchar](max) NULL,
	[From_Account] [nvarchar](255) NULL,
	[To_Account] [nvarchar](255) NULL,
	[Hand_Group] [nvarchar](255) NULL,
	[Kwat] [float] NULL,
	[Discount] [float] NULL,
	[Hand] [float] NULL,
	[SetViewOne] [nvarchar](255) NULL,
	[Freezed] [bit] NULL,
	[IsEntryOnly] [bit] NULL,
	[GuidAC] [nvarchar](max) NULL,
	[CurDate] [datetime] NULL,
	[Hide] [bit] NULL,
	[ChqNo] [nvarchar](255) NULL,
	[ChqDrawn] [nvarchar](255) NULL,
	[Userss] [nvarchar](255) NULL,
	[fy] [varchar](50) NULL,
 CONSTRAINT [del_Mat_AccountTwo_PrimaryKey] PRIMARY KEY NONCLUSTERED 
(
	[Ent_No] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[del_Mat_AccountTwo] ([Ent_No], [VrNo], [Mode_Pay_Rec], [Rec_Pay], [Ammount], [Ddate], [Disp], [From_Account], [To_Account], [Hand_Group], [Kwat], [Discount], [Hand], [SetViewOne], [Freezed], [IsEntryOnly], [GuidAC], [CurDate], [Hide], [ChqNo], [ChqDrawn], [Userss], [fy]) VALUES (N'D625-18BD', 43, N'CASH', N'PAYMENT', 1, CAST(0x0000A3D400000000 AS DateTime), N'', N'BHES-0002', N'81C3-0001', N'Deleted', 0, 0, 0, N'B', 0, 0, N'0043,D625-18BD,1,81C3-0001,BHES-0002,PAYMENT,CASH,10/30/2014,,B,0,0,0,10/30/2014 9:09:06 AM,,,chandresh,0,0,0,R,,14-15', CAST(0x0000A3D40096D098 AS DateTime), 0, N'', N'', N'chandresh', N'14-15')
INSERT [dbo].[del_Mat_AccountTwo] ([Ent_No], [VrNo], [Mode_Pay_Rec], [Rec_Pay], [Ammount], [Ddate], [Disp], [From_Account], [To_Account], [Hand_Group], [Kwat], [Discount], [Hand], [SetViewOne], [Freezed], [IsEntryOnly], [GuidAC], [CurDate], [Hide], [ChqNo], [ChqDrawn], [Userss], [fy]) VALUES (N'491A-79CD', 47, N'CASH', N'PAYMENT', 12, CAST(0x0000A3D400000000 AS DateTime), N'', N'BHES-0002', N'81C3-0001', N'Deleted', 0, 0, 0, N'B', 0, 0, N'0047,491A-79CD,12,81C3-0001,BHES-0002,PAYMENT,CASH,10/30/2014,,B,0,0,0,10/30/2014 9:13:19 AM,,,chandresh,0,0,0,R,,14-15', CAST(0x0000A3D40097F914 AS DateTime), 0, N'', N'', N'chandresh', N'14-15')
/****** Object:  Table [dbo].[CreditLimit]    Script Date: 03/10/2015 09:49:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CreditLimit](
	[Sup_id] [nvarchar](255) NOT NULL,
	[Balance] [float] NULL,
	[CreditDays] [int] NULL,
	[CreditAmmount] [float] NULL,
 CONSTRAINT [CreditLimit_PrimaryKey] PRIMARY KEY NONCLUSTERED 
(
	[Sup_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CompanyDetail]    Script Date: 03/10/2015 09:49:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CompanyDetail](
	[CompanyName] [nvarchar](255) NULL,
	[DataBaseName] [nvarchar](255) NULL,
	[SiteName] [nvarchar](255) NULL,
	[DateCreated] [nvarchar](255) NULL,
	[User] [nvarchar](255) NULL,
	[Password] [nvarchar](255) NULL,
	[GuIdSite] [nvarchar](255) NULL,
	[Alias] [nvarchar](255) NULL
) ON [PRIMARY]
GO
INSERT [dbo].[CompanyDetail] ([CompanyName], [DataBaseName], [SiteName], [DateCreated], [User], [Password], [GuIdSite], [Alias]) VALUES (N'kubeji industrial estate', N'site010.mdb', N'bhestan', N'4/17/2012', N'Chandresh', N'Chan2210', N'4663-2211', N'')
INSERT [dbo].[CompanyDetail] ([CompanyName], [DataBaseName], [SiteName], [DateCreated], [User], [Password], [GuIdSite], [Alias]) VALUES (N'kubeji industrial estate', N'site010.mdb', N'bhestan', N'4/17/2012', N'Chandresh', N'Chan2210', N'4663-2211', N'')
/****** Object:  StoredProcedure [dbo].[Add_Field_supplier]    Script Date: 03/10/2015 09:49:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Add_Field_supplier] 
as
IF NOT EXISTS(  SELECT TOP 1 1
  FROM INFORMATION_SCHEMA.COLUMNS
  WHERE 
    [TABLE_NAME] = 'Supplier'
    AND [COLUMN_NAME] = 'Balance')
BEGIN
alter table Supplier add  Balance float not null default(0)
END 
IF NOT EXISTS(  SELECT TOP 1 1
  FROM INFORMATION_SCHEMA.COLUMNS
  WHERE 
    [TABLE_NAME] = 'Supplier'
    AND [COLUMN_NAME] = 'CashBankBalance')
BEGIN
alter table Supplier add  CashBankBalance float not null default(0)
END
GO
/****** Object:  Table [dbo].[users]    Script Date: 03/10/2015 09:49:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[users](
	[Uids] [nvarchar](255) NOT NULL,
	[Passwords] [nvarchar](255) NULL,
	[Permit] [nvarchar](255) NULL,
 CONSTRAINT [users_PrimaryKey] PRIMARY KEY NONCLUSTERED 
(
	[Uids] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[users] ([Uids], [Passwords], [Permit]) VALUES (N'chandresh', N'YwGF9Wfa5/Xsx+xTsRJQ5A==', N'Full')
INSERT [dbo].[users] ([Uids], [Passwords], [Permit]) VALUES (N'kuberjis', N'q9hmAVBIrHg=', N'Entry')
/****** Object:  StoredProcedure [dbo].[UpdateSupplier]    Script Date: 03/10/2015 09:49:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE  [dbo].[UpdateSupplier] 
AS 
DECLARE @IDS VARCHAR(50) 
DECLARE @cramt FLOAT 
DECLARE @dramt FLOAT 
declare @amt as float 
DECLARE @cramt2 FLOAT 
DECLARE @dramt2 FLOAT 
declare @amt2 as float 
DECLARE db_cursor CURSOR FOR SELECT SUP_ID FROM SUPPLIER 
OPEN db_cursor 
FETCH NEXT FROM db_cursor INTO @IDS 
WHILE @@FETCH_STATUS = 0 
BEGIN 
set @cramt = (select  sum(Ammount) from Mat_AccountTwo where From_Account =@idS and hand_group='R') 
set @dramt =(select sum(Ammount) from Mat_AccountTwo where To_Account =@idS and hand_group='R') 
set @amt=round(isnull(@cramt,0) -isnull(@dramt,0),2)
set @cramt2 = (select  sum(Ammount) from Mat_AccountTwo where From_Account =@idS and hand_group='R' and (Mode_Pay_Rec ='CASH' OR Mode_Pay_Rec ='BANK' OR Mode_Pay_Rec ='JOURNAL' OR Mode_Pay_Rec ='CONTRA')) 
set @dramt2 =(select sum(Ammount) from Mat_AccountTwo where To_Account =@idS and hand_group='R' and (Mode_Pay_Rec ='CASH' OR Mode_Pay_Rec ='BANK' OR Mode_Pay_Rec ='JOURNAL' OR Mode_Pay_Rec ='CONTRA')) 
set @amt2=round(isnull(@cramt2,0) -isnull(@dramt2,0),2)
Update Supplier  set creditammount=@AMT,balance=@amt,cashbankbalance=@amt2,alias ='' WHERE Sup_id =@idS 
FETCH NEXT FROM db_cursor INTO @IDS  
End 
Close db_cursor 
DEALLOCATE db_cursor
GO
/****** Object:  StoredProcedure [dbo].[Add_Field]    Script Date: 03/10/2015 09:49:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[Add_Field] 
as
BEGIN
if not exists (select fy from Mat_AccountTwo ) alter table mat_accounttwo add  fy varchar(50) null

if not exists (select fy from del_mat_accounttwo) alter table del_mat_accounttwo add  fy varchar(50) null
END
GO
/****** Object:  StoredProcedure [dbo].[Add_Data]    Script Date: 03/10/2015 09:49:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Add_Data] 
as
DECLARE @ids varchar(50)
	DECLARE @fy varchar(50)
	declare @ddate date
  DECLARE db_cursor CURSOR FOR SELECT ent_no FROM mat_accounttwo

OPEN db_cursor   
FETCH NEXT FROM db_cursor INTO @ids

WHILE @@FETCH_STATUS = 0

BEGIN


	set @ddate = (select  ddate from Mat_AccountTwo where Ent_No =@ids)
	if @ddate > '4/1/2013' AND @DDATE < '3/31/2014'
	        set @fy ='13-14'
        
       
        if @ddate > '4/1/2012' AND @DDATE < '3/31/2013'
	        set @fy ='12-13'
       
        
        if @ddate > '4/1/2011' AND @DDATE < '3/31/2012'
	        set @fy ='11-12'
       
        
        if @ddate > '4/1/2010' AND @DDATE < '3/31/2011'
	        set @fy ='10-11'
        
        
        if @ddate > '4/1/2009' AND @DDATE < '3/31/2010'
	        set @fy ='09-10'
	         if @ddate > '4/1/2008' AND @DDATE < '3/31/2009'
	        set @fy ='08-09'
	         if @ddate > '4/1/2007' AND @DDATE < '3/31/2008'
	        set @fy ='07-08'
	         if @ddate > '4/1/2006' AND @DDATE < '3/31/2007'
	        set @fy ='06-07'
	        if @ddate > '4/1/2005' AND @DDATE < '3/31/2006'
	        set @fy ='05-06'
	        if @ddate > '4/1/2004' AND @DDATE < '3/31/2005'
	        set @fy ='04-05'
        update Mat_AccountTwo  set fy=@fy where Ent_No =@ids
        
         FETCH NEXT FROM db_cursor INTO @IDS 
     
END
CLOSE db_cursor   
DEALLOCATE db_cursor
GO
/****** Object:  StoredProcedure [dbo].[CashBankUpdateSupplier]    Script Date: 03/10/2015 09:49:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE  [dbo].[CashBankUpdateSupplier] 
  AS 
  DECLARE @IDS VARCHAR(50)
DECLARE @cramt FLOAT
DECLARE @dramt FLOAT
declare @amt as float
  DECLARE db_cursor CURSOR FOR SELECT SUP_ID FROM SUPPLIER

OPEN db_cursor   
FETCH NEXT FROM db_cursor INTO @IDS 
WHILE @@FETCH_STATUS = 0
             
BEGIN  

set @cramt = (select  sum(Ammount) from Mat_AccountTwo where From_Account =@idS and hand_group='R' and (Mode_Pay_Rec ='CASH' OR Mode_Pay_Rec ='BANK' OR Mode_Pay_Rec ='JOURNAL'))
set @dramt =(select sum(Ammount) from Mat_AccountTwo where To_Account =@idS and hand_group='R' and (Mode_Pay_Rec ='CASH' OR Mode_Pay_Rec ='BANK' OR Mode_Pay_Rec ='JOURNAL'))
 set @amt=isnull(@cramt,0) -isnull(@dramt,0)
      Update Supplier  set cashbankbalance=@amt,alias ='BHESTAN' WHERE Sup_id =@idS
     FETCH NEXT FROM db_cursor INTO @IDS 
END   

CLOSE db_cursor   
DEALLOCATE db_cursor
GO
/****** Object:  UserDefinedFunction [dbo].[GetVrNo]    Script Date: 03/10/2015 09:49:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE  FUNCTION [dbo].[GetVrNo]() 
RETURNS Int 
AS 
BEGIN 
Declare @SCOUNT int; 
SET @SCOUNT = 1; 
WHILE @SCOUNT < 10000 
if NOT exists( select VRNO from mat_accounttwo where vrno=CONVERT(VARCHAR(10),@SCOUNT)) and 
NOT exists( select VRNO from del_mat_accounttwo where vrno=CONVERT(VARCHAR(10),@SCOUNT)) 
break 
Else 
SET @SCOUNT = (@SCOUNT + 1) 
return @scount 
End
GO
/****** Object:  Default [DF__Supplier__childo__1A14E395]    Script Date: 03/10/2015 09:49:21 ******/
ALTER TABLE [dbo].[Supplier] ADD  DEFAULT ('0000-0001') FOR [childof]
GO
/****** Object:  Default [DF__Supplier__Balanc__1B0907CE]    Script Date: 03/10/2015 09:49:21 ******/
ALTER TABLE [dbo].[Supplier] ADD  DEFAULT ((0)) FOR [Balance]
GO
/****** Object:  Default [DF__Supplier__CashBa__1BFD2C07]    Script Date: 03/10/2015 09:49:21 ******/
ALTER TABLE [dbo].[Supplier] ADD  DEFAULT ((0)) FOR [CashBankBalance]
GO
