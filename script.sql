USE [FilmDB]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 28.02.2021 21:07:03 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 28.02.2021 21:07:04 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 28.02.2021 21:07:04 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 28.02.2021 21:07:04 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 28.02.2021 21:07:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](450) NOT NULL,
	[ProviderKey] [nvarchar](450) NOT NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
	[UserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 28.02.2021 21:07:04 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 28.02.2021 21:07:04 ******/
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
	[FirstName] [nvarchar](max) NULL,
	[LastName] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 28.02.2021 21:07:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserTokens](
	[UserId] [nvarchar](450) NOT NULL,
	[LoginProvider] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](450) NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[LoginProvider] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 28.02.2021 21:07:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[CategoryId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Url] [nvarchar](100) NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FilmCategory]    Script Date: 28.02.2021 21:07:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FilmCategory](
	[CategoryId] [int] NOT NULL,
	[FilmId] [int] NOT NULL,
 CONSTRAINT [PK_FilmCategory] PRIMARY KEY CLUSTERED 
(
	[CategoryId] ASC,
	[FilmId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Films]    Script Date: 28.02.2021 21:07:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Films](
	[FilmId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Url] [nvarchar](100) NULL,
	[PlayerDescription] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
	[IsApproved] [bit] NOT NULL,
	[IsHome] [bit] NOT NULL,
 CONSTRAINT [PK_Films] PRIMARY KEY CLUSTERED 
(
	[FilmId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210228143623_MyFirstMigration', N'3.1.3')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210228143803_MyFirstMigration', N'3.1.3')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'eb5dfc52-ec2d-478b-9387-1a4b41794800', N'Editör', N'EDITÖR', N'cabef43d-ba26-4db1-8cbe-726572659d92')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'edf4df17-3b5e-497f-9b9a-ff0ededf036c', N'Admin', N'ADMIN', N'8d81327f-158d-4abf-bf0a-13c027de0900')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'82c36cea-861b-4d8a-af5e-ef15f16a5268', N'edf4df17-3b5e-497f-9b9a-ff0ededf036c')
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [FirstName], [LastName]) VALUES (N'82c36cea-861b-4d8a-af5e-ef15f16a5268', N'aliveli', N'ALIVELI', N'sdy51493@cuoly.com', N'SDY51493@CUOLY.COM', 1, N'AQAAAAEAACcQAAAAEIcjCnyUZSYhVTgun0c+ZTNKZVRTDE9VXTd2HdmMpKpT+fGMbPLRUvhyrlGpqTCguQ==', N'YNNLZTHQLOCS77WMYE76I5L6UIN476YN', N'9aa46cb6-bdab-464d-9bfd-16439a5e075f', NULL, 0, 0, NULL, 1, 0, N'Ali', N'Veli')
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [FirstName], [LastName]) VALUES (N'c67a891b-790f-40d4-9094-32455826b3fe', N'cemcan', N'CEMCAN', N'cuo69499@cuoly.com', N'CUO69499@CUOLY.COM', 1, N'AQAAAAEAACcQAAAAEP9JbMTr+CwrHnFy6YVQzBffS7v7V2i0EL7Vaq6qyD4VAUJw4CLNrRimxbajD4/1wQ==', N'MVNSI5THS7LI7IUH5VDC5422P2CLRHUV', N'0f1e09ab-0168-4dd7-b2be-45f160257506', NULL, 0, 0, NULL, 1, 0, N'Cem', N'Can')
SET IDENTITY_INSERT [dbo].[Categories] ON 

INSERT [dbo].[Categories] ([CategoryId], [Name], [Url]) VALUES (1, N'Aksiyon', N'aksiyon')
INSERT [dbo].[Categories] ([CategoryId], [Name], [Url]) VALUES (3, N'Gerilim', N'gerilim')
INSERT [dbo].[Categories] ([CategoryId], [Name], [Url]) VALUES (4, N'Bilimkurgu', N'bilimkurgu')
SET IDENTITY_INSERT [dbo].[Categories] OFF
INSERT [dbo].[FilmCategory] ([CategoryId], [FilmId]) VALUES (1, 1)
INSERT [dbo].[FilmCategory] ([CategoryId], [FilmId]) VALUES (3, 1)
INSERT [dbo].[FilmCategory] ([CategoryId], [FilmId]) VALUES (4, 1)
INSERT [dbo].[FilmCategory] ([CategoryId], [FilmId]) VALUES (1, 3)
INSERT [dbo].[FilmCategory] ([CategoryId], [FilmId]) VALUES (1, 5)
INSERT [dbo].[FilmCategory] ([CategoryId], [FilmId]) VALUES (1, 6)
INSERT [dbo].[FilmCategory] ([CategoryId], [FilmId]) VALUES (1, 7)
INSERT [dbo].[FilmCategory] ([CategoryId], [FilmId]) VALUES (3, 7)
INSERT [dbo].[FilmCategory] ([CategoryId], [FilmId]) VALUES (1, 8)
INSERT [dbo].[FilmCategory] ([CategoryId], [FilmId]) VALUES (3, 8)
SET IDENTITY_INSERT [dbo].[Films] ON 

INSERT [dbo].[Films] ([FilmId], [Name], [Url], [PlayerDescription], [Description], [IsApproved], [IsHome]) VALUES (1, N'Terminatör 2', N'terminator2', N'Arnold Strong', N'bilimkurgu aksiyon filmi', 1, 1)
INSERT [dbo].[Films] ([FilmId], [Name], [Url], [PlayerDescription], [Description], [IsApproved], [IsHome]) VALUES (3, N'Rambo 1', N'rambo1', N'Syvester Stallone', N'rambo filmi açıklama', 1, 1)
INSERT [dbo].[Films] ([FilmId], [Name], [Url], [PlayerDescription], [Description], [IsApproved], [IsHome]) VALUES (5, N'Rambo 2', N'rambo2', N'Sylvester Stallone', N'rambo 2 filmi açıklama', 1, 1)
INSERT [dbo].[Films] ([FilmId], [Name], [Url], [PlayerDescription], [Description], [IsApproved], [IsHome]) VALUES (6, N'Rambo 3', N'rambo3', N'Sylvester Stallone', N'rambo 3 filmi açıklama', 0, 0)
INSERT [dbo].[Films] ([FilmId], [Name], [Url], [PlayerDescription], [Description], [IsApproved], [IsHome]) VALUES (7, N'Zor Ölüm', N'zorolum', N'Bruce Willis', N'zor ölüm filmi açıklama', 1, 1)
INSERT [dbo].[Films] ([FilmId], [Name], [Url], [PlayerDescription], [Description], [IsApproved], [IsHome]) VALUES (8, N'Zor Ölüm 2', N'zorolum2', N'Bruce Willis', N'zor ölüm 2 filmi açıklma', 0, 0)
SET IDENTITY_INSERT [dbo].[Films] OFF
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
ALTER TABLE [dbo].[FilmCategory]  WITH CHECK ADD  CONSTRAINT [FK_FilmCategory_Categories_CategoryId] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Categories] ([CategoryId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[FilmCategory] CHECK CONSTRAINT [FK_FilmCategory_Categories_CategoryId]
GO
ALTER TABLE [dbo].[FilmCategory]  WITH CHECK ADD  CONSTRAINT [FK_FilmCategory_Films_FilmId] FOREIGN KEY([FilmId])
REFERENCES [dbo].[Films] ([FilmId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[FilmCategory] CHECK CONSTRAINT [FK_FilmCategory_Films_FilmId]
GO
