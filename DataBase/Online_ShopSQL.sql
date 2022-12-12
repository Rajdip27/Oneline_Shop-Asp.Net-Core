USE [OnlineShopDb]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 13-Dec-22 12:58:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 13-Dec-22 12:58:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoleClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 13-Dec-22 12:58:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](256) NULL,
	[NormalizedName] [nvarchar](256) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 13-Dec-22 12:58:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 13-Dec-22 12:58:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](128) NOT NULL,
	[ProviderKey] [nvarchar](128) NOT NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
	[UserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 13-Dec-22 12:58:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](450) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 13-Dec-22 12:58:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](450) NOT NULL,
	[UserName] [nvarchar](256) NULL,
	[NormalizedUserName] [nvarchar](256) NULL,
	[Email] [nvarchar](256) NULL,
	[NormalizedEmail] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
	[Discriminator] [nvarchar](max) NOT NULL,
	[FirstName] [nvarchar](max) NULL,
	[LastName] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 13-Dec-22 12:58:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserTokens](
	[UserId] [nvarchar](450) NOT NULL,
	[LoginProvider] [nvarchar](128) NOT NULL,
	[Name] [nvarchar](128) NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[LoginProvider] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[orderDetails]    Script Date: 13-Dec-22 12:58:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[orderDetails](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[OrderId] [int] NOT NULL,
	[ProductId] [int] NOT NULL,
 CONSTRAINT [PK_orderDetails] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[orders]    Script Date: 13-Dec-22 12:58:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[orders](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[OrderNo] [nvarchar](max) NULL,
	[Name] [nvarchar](max) NOT NULL,
	[PhoneNo] [nvarchar](max) NOT NULL,
	[Email] [nvarchar](max) NOT NULL,
	[Address] [nvarchar](max) NOT NULL,
	[OrderDate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_orders] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[products]    Script Date: 13-Dec-22 12:58:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[products](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Price] [decimal](18, 2) NOT NULL,
	[Image] [nvarchar](max) NULL,
	[ProductColor] [nvarchar](max) NULL,
	[IsAvailable] [bit] NOT NULL,
	[ProductTypeId] [int] NOT NULL,
	[SpcialTagId] [int] NOT NULL,
 CONSTRAINT [PK_products] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[productTypes]    Script Date: 13-Dec-22 12:58:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[productTypes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Producttype] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_productTypes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[specialTags]    Script Date: 13-Dec-22 12:58:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[specialTags](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[specialTageName] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_specialTags] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'00000000000000_CreateIdentitySchema', N'2.2.6-servicing-10079')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20221202190730_addProductTableIntoDatabse', N'2.2.6-servicing-10079')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20221203115442_SANTANU', N'2.2.6-servicing-10079')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20221204174958_addproductsmodel', N'2.2.6-servicing-10079')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20221207181249_addOrderandOrderDetailstable', N'2.2.6-servicing-10079')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20221208153556_addednewfeildintousertable', N'2.2.6-servicing-10079')
GO
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'14d81613-e06b-462b-9287-1e9094916558', N'Admin', N'ADMIN', N'3a063c6a-d489-4f3c-83dd-125f6fafbeae')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'8152872f-68da-4611-82c2-230169c84ec1', N'Super User', N'SUPER USER', N'8059735c-7d8c-48ee-b409-6aaf4b74cfe9')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'c1dbe634-f8f2-4a5d-95fa-32c40431ceac', N'User', N'USER', N'fbfb5902-1bb9-479d-8395-1494aa5cc084')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'cb39b59f-02b7-4423-9f0d-9c95bea062b2', N'14d81613-e06b-462b-9287-1e9094916558')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'1763f5bc-3139-46b6-9a17-4cddaabef10d', N'c1dbe634-f8f2-4a5d-95fa-32c40431ceac')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'9d8971e8-ae81-4265-8d5d-0793b2d905c0', N'c1dbe634-f8f2-4a5d-95fa-32c40431ceac')
GO
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Discriminator], [FirstName], [LastName]) VALUES (N'1763f5bc-3139-46b6-9a17-4cddaabef10d', N'Santanu@gmail.com', N'SANTANU@GMAIL.COM', NULL, NULL, 0, N'AQAAAAEAACcQAAAAEAuk8pbfCvZNOnhLn0imzQMHBFGuUgTms+VIILbaNl5ye5vCkVJBaklJKYbLWKkwvg==', N'RIC6RCHI7LME2D67QHOISXZE6X4QPRZS', N'b6152b25-4102-4eff-aac8-ebfb483ed8a0', NULL, 0, 0, NULL, 1, 0, N'ApplicationUser', N'Rajdip', N'Raja')
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Discriminator], [FirstName], [LastName]) VALUES (N'9d8971e8-ae81-4265-8d5d-0793b2d905c0', N'Abc@gmail.com', N'ABC@GMAIL.COM', NULL, NULL, 0, N'AQAAAAEAACcQAAAAENi12Adacd+vRfjRWwde3+KRuUOYM1mrDlS2uNnjiU+/CGgUalYCBbaMZRre94ygKA==', N'NVPH63APDKQSYSQVQEKU5LYQGMBMPANA', N'c72091ca-fcee-476a-bad6-53e2faca2cae', NULL, 0, 0, NULL, 1, 2, N'ApplicationUser', N'Rajdip', N'Raj')
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Discriminator], [FirstName], [LastName]) VALUES (N'cb39b59f-02b7-4423-9f0d-9c95bea062b2', N'srajdip920@gmail.com', N'SRAJDIP920@GMAIL.COM', N'srajdip920@gmail.com', N'SRAJDIP920@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEHndCnDIuA0hxZsSo+/jykuHvp5NJPnO435ENquLktTyhTX1t4+IsCmMRUkoGWZZbw==', N'SG4KLTEVEYQNQ7VVAIDLE6GGK7ZDVWLD', N'c755b2cc-3511-4351-a153-13016db1d059', NULL, 0, 0, CAST(N'2022-12-08T11:53:18.3937588+06:00' AS DateTimeOffset), 1, 0, N'ApplicationUser', N'Rajdip Raj', N'Santanu')
GO
SET IDENTITY_INSERT [dbo].[orderDetails] ON 

INSERT [dbo].[orderDetails] ([Id], [OrderId], [ProductId]) VALUES (1, 4, 2002)
INSERT [dbo].[orderDetails] ([Id], [OrderId], [ProductId]) VALUES (2, 5, 2002)
SET IDENTITY_INSERT [dbo].[orderDetails] OFF
GO
SET IDENTITY_INSERT [dbo].[orders] ON 

INSERT [dbo].[orders] ([Id], [OrderNo], [Name], [PhoneNo], [Email], [Address], [OrderDate]) VALUES (4, N'001', N'Rajdip raj', N'01701734627', N'srajdip920@gmail.com', N'dhaka, dhaka', CAST(N'2022-12-08T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[orders] ([Id], [OrderNo], [Name], [PhoneNo], [Email], [Address], [OrderDate]) VALUES (5, N'002', N'Ratna Halder', N'01730238856', N'ratnahalderrai@gmail.com', N'Patuakhali,City, Patuakhali,City', CAST(N'2022-12-08T01:36:00.0000000' AS DateTime2))
SET IDENTITY_INSERT [dbo].[orders] OFF
GO
SET IDENTITY_INSERT [dbo].[products] ON 

INSERT [dbo].[products] ([Id], [Name], [Price], [Image], [ProductColor], [IsAvailable], [ProductTypeId], [SpcialTagId]) VALUES (2002, N'Tv Smart', CAST(75000.00 AS Decimal(18, 2)), N'Images/Image_QLED_TV_2_QLED_354x202_desktop.jpg', N'Black', 1, 5, 1003)
INSERT [dbo].[products] ([Id], [Name], [Price], [Image], [ProductColor], [IsAvailable], [ProductTypeId], [SpcialTagId]) VALUES (2007, N'HP Laptop S521', CAST(80000.00 AS Decimal(18, 2)), N'Images/download.jpg', N'Black', 1, 3, 1005)
INSERT [dbo].[products] ([Id], [Name], [Price], [Image], [ProductColor], [IsAvailable], [ProductTypeId], [SpcialTagId]) VALUES (2009, N'I Phone', CAST(80000.00 AS Decimal(18, 2)), N'Images/download (7).jpg', N'white', 0, 4, 1002)
INSERT [dbo].[products] ([Id], [Name], [Price], [Image], [ProductColor], [IsAvailable], [ProductTypeId], [SpcialTagId]) VALUES (2010, N'Mac', CAST(150000.00 AS Decimal(18, 2)), N'Images/download (1).jpg', N'white', 1, 3, 1005)
INSERT [dbo].[products] ([Id], [Name], [Price], [Image], [ProductColor], [IsAvailable], [ProductTypeId], [SpcialTagId]) VALUES (2012, N'Tv LED', CAST(18000.00 AS Decimal(18, 2)), N'Images/images (3).jpg', N'Black', 1, 5, 1004)
INSERT [dbo].[products] ([Id], [Name], [Price], [Image], [ProductColor], [IsAvailable], [ProductTypeId], [SpcialTagId]) VALUES (2014, N'Dell Laptop', CAST(60000.00 AS Decimal(18, 2)), N'Images/images.jpg', N'white', 1, 3, 1005)
INSERT [dbo].[products] ([Id], [Name], [Price], [Image], [ProductColor], [IsAvailable], [ProductTypeId], [SpcialTagId]) VALUES (2016, N'Hp Laptop 890', CAST(70000.00 AS Decimal(18, 2)), N'Images/download (3).jpg', N'white', 1, 3, 1005)
INSERT [dbo].[products] ([Id], [Name], [Price], [Image], [ProductColor], [IsAvailable], [ProductTypeId], [SpcialTagId]) VALUES (2017, N'Tv Samrt 789', CAST(15000.00 AS Decimal(18, 2)), N'Images/images (2).jpg', N'Black', 1, 5, 1004)
INSERT [dbo].[products] ([Id], [Name], [Price], [Image], [ProductColor], [IsAvailable], [ProductTypeId], [SpcialTagId]) VALUES (3002, N'New Phone', CAST(15000.00 AS Decimal(18, 2)), N'Images/Android-Mobile-Download-Free-PNG.png', N'white', 1, 4, 2)
SET IDENTITY_INSERT [dbo].[products] OFF
GO
SET IDENTITY_INSERT [dbo].[productTypes] ON 

INSERT [dbo].[productTypes] ([Id], [Producttype]) VALUES (3, N'Computer')
INSERT [dbo].[productTypes] ([Id], [Producttype]) VALUES (4, N'Moblie')
INSERT [dbo].[productTypes] ([Id], [Producttype]) VALUES (5, N'TV')
INSERT [dbo].[productTypes] ([Id], [Producttype]) VALUES (6, N'AC')
SET IDENTITY_INSERT [dbo].[productTypes] OFF
GO
SET IDENTITY_INSERT [dbo].[specialTags] ON 

INSERT [dbo].[specialTags] ([Id], [specialTageName]) VALUES (2, N'Mobile')
INSERT [dbo].[specialTags] ([Id], [specialTageName]) VALUES (1002, N'I Phone')
INSERT [dbo].[specialTags] ([Id], [specialTageName]) VALUES (1003, N'PC')
INSERT [dbo].[specialTags] ([Id], [specialTageName]) VALUES (1004, N'Tv')
INSERT [dbo].[specialTags] ([Id], [specialTageName]) VALUES (1005, N'Laptop')
SET IDENTITY_INSERT [dbo].[specialTags] OFF
GO
ALTER TABLE [dbo].[AspNetUsers] ADD  DEFAULT (N'') FOR [Discriminator]
GO
ALTER TABLE [dbo].[AspNetRoleClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetRoleClaims] CHECK CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserTokens]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserTokens] CHECK CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[orderDetails]  WITH CHECK ADD  CONSTRAINT [FK_orderDetails_orders_OrderId] FOREIGN KEY([OrderId])
REFERENCES [dbo].[orders] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[orderDetails] CHECK CONSTRAINT [FK_orderDetails_orders_OrderId]
GO
ALTER TABLE [dbo].[orderDetails]  WITH CHECK ADD  CONSTRAINT [FK_orderDetails_products_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[products] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[orderDetails] CHECK CONSTRAINT [FK_orderDetails_products_ProductId]
GO
ALTER TABLE [dbo].[products]  WITH CHECK ADD  CONSTRAINT [FK_products_productTypes_ProductTypeId] FOREIGN KEY([ProductTypeId])
REFERENCES [dbo].[productTypes] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[products] CHECK CONSTRAINT [FK_products_productTypes_ProductTypeId]
GO
ALTER TABLE [dbo].[products]  WITH CHECK ADD  CONSTRAINT [FK_products_specialTags_SpcialTagId] FOREIGN KEY([SpcialTagId])
REFERENCES [dbo].[specialTags] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[products] CHECK CONSTRAINT [FK_products_specialTags_SpcialTagId]
GO
