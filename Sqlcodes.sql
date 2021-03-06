USE [Otopark]
GO
/****** Object:  Table [dbo].[AboneBilgileri]    Script Date: 4.11.2021 15:07:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AboneBilgileri](
	[AboneId] [int] NOT NULL,
	[Ad] [varchar](20) NULL,
	[Soyad] [varchar](20) NULL,
	[Adres] [text] NULL,
	[Ilce] [varchar](20) NULL,
	[Il] [varchar](20) NULL,
	[Telefon] [char](11) NULL,
	[KayitTarihi] [datetime] NULL,
 CONSTRAINT [PK_AboneBilgileri] PRIMARY KEY CLUSTERED 
(
	[AboneId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Abonelikler]    Script Date: 4.11.2021 15:07:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Abonelikler](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[AboneId] [int] NOT NULL,
	[BaslangicTarihi] [datetime] NULL,
	[BitisTarihi] [datetime] NULL,
	[AboneUcreti] [money] NULL,
	[KayitTarihi] [nchar](10) NULL,
 CONSTRAINT [PK_Abonelikler] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GirisCikisKayitlari]    Script Date: 4.11.2021 15:07:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GirisCikisKayitlari](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[AboneId] [int] NOT NULL,
	[AracPlaka] [varchar](10) NULL,
	[GirisTarihi] [datetime] NULL,
	[CikisTarihi] [datetime] NULL,
	[Sure] [int] NULL,
	[Ucret] [money] NULL,
	[KayitTarihi] [datetime] NULL,
 CONSTRAINT [PK_GirisCikisKayitlari] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tarifeler]    Script Date: 4.11.2021 15:07:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tarifeler](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IlkSaat] [datetime] NULL,
	[SonSaat] [datetime] NULL,
	[Ucret] [money] NULL,
	[Aktif] [nvarchar](50) NULL,
	[KayitTarihi] [datetime] NULL,
 CONSTRAINT [PK_Tarifeler] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[AboneBilgileri] ([AboneId], [Ad], [Soyad], [Adres], [Ilce], [Il], [Telefon], [KayitTarihi]) VALUES (1, N'Ali', N'Yılmaz', N'İnönü Mahallesi', N'Ortahisar', N'Trabzon', N'05433452331', CAST(N'2021-11-04T00:00:00.000' AS DateTime))
INSERT [dbo].[AboneBilgileri] ([AboneId], [Ad], [Soyad], [Adres], [Ilce], [Il], [Telefon], [KayitTarihi]) VALUES (2, N'Gazme', N'Ak', N'Boztepe', N'Boztepe', N'Trabzon', N'045334553  ', CAST(N'2021-11-04T00:00:00.000' AS DateTime))
INSERT [dbo].[AboneBilgileri] ([AboneId], [Ad], [Soyad], [Adres], [Ilce], [Il], [Telefon], [KayitTarihi]) VALUES (3, N'Yeliz', N'Gül', N'Fatih Mahallesi', N'Ortahisar', N'Trabzon', N'0456543455 ', CAST(N'2021-11-04T00:00:00.000' AS DateTime))
INSERT [dbo].[AboneBilgileri] ([AboneId], [Ad], [Soyad], [Adres], [Ilce], [Il], [Telefon], [KayitTarihi]) VALUES (10, N'Kemal', N'Akyol', N'Yenimahalle', N'Ortahisar', N'Trabzon', N'05432344567', CAST(N'2021-11-04T00:00:00.000' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[Abonelikler] ON 

INSERT [dbo].[Abonelikler] ([Id], [AboneId], [BaslangicTarihi], [BitisTarihi], [AboneUcreti], [KayitTarihi]) VALUES (5, 1, CAST(N'2021-11-04T00:00:00.000' AS DateTime), CAST(N'2021-11-19T00:00:00.000' AS DateTime), 10.0000, N'Nov  4 202')
INSERT [dbo].[Abonelikler] ([Id], [AboneId], [BaslangicTarihi], [BitisTarihi], [AboneUcreti], [KayitTarihi]) VALUES (6, 2, CAST(N'2021-11-04T00:00:00.000' AS DateTime), CAST(N'2021-11-04T00:00:00.000' AS DateTime), 20.0000, N'Nov  4 202')
INSERT [dbo].[Abonelikler] ([Id], [AboneId], [BaslangicTarihi], [BitisTarihi], [AboneUcreti], [KayitTarihi]) VALUES (7, 3, CAST(N'2021-11-04T00:00:00.000' AS DateTime), CAST(N'2021-11-12T00:00:00.000' AS DateTime), 22.0000, N'Nov  4 202')
INSERT [dbo].[Abonelikler] ([Id], [AboneId], [BaslangicTarihi], [BitisTarihi], [AboneUcreti], [KayitTarihi]) VALUES (8, 10, CAST(N'2021-11-04T00:00:00.000' AS DateTime), CAST(N'2021-11-04T00:00:00.000' AS DateTime), 10.0000, N'Nov  4 202')
SET IDENTITY_INSERT [dbo].[Abonelikler] OFF
GO
SET IDENTITY_INSERT [dbo].[GirisCikisKayitlari] ON 

INSERT [dbo].[GirisCikisKayitlari] ([Id], [AboneId], [AracPlaka], [GirisTarihi], [CikisTarihi], [Sure], [Ucret], [KayitTarihi]) VALUES (4, 5, N'61tr334   ', CAST(N'2021-11-04T14:01:46.000' AS DateTime), NULL, NULL, NULL, CAST(N'2021-11-04T00:00:00.000' AS DateTime))
INSERT [dbo].[GirisCikisKayitlari] ([Id], [AboneId], [AracPlaka], [GirisTarihi], [CikisTarihi], [Sure], [Ucret], [KayitTarihi]) VALUES (5, 6, N'61aa543   ', CAST(N'2021-11-04T14:03:29.000' AS DateTime), CAST(N'2021-11-04T14:03:51.000' AS DateTime), 0, 20.0000, CAST(N'2021-11-04T00:00:00.000' AS DateTime))
INSERT [dbo].[GirisCikisKayitlari] ([Id], [AboneId], [AracPlaka], [GirisTarihi], [CikisTarihi], [Sure], [Ucret], [KayitTarihi]) VALUES (6, 7, N'27yl234   ', CAST(N'2021-11-04T14:20:05.000' AS DateTime), NULL, NULL, NULL, CAST(N'2021-11-04T00:00:00.000' AS DateTime))
INSERT [dbo].[GirisCikisKayitlari] ([Id], [AboneId], [AracPlaka], [GirisTarihi], [CikisTarihi], [Sure], [Ucret], [KayitTarihi]) VALUES (7, 8, N'34ft234   ', CAST(N'2021-11-04T14:23:36.000' AS DateTime), CAST(N'2021-11-04T14:24:01.000' AS DateTime), 0, 11.0000, CAST(N'2021-11-04T00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[GirisCikisKayitlari] OFF
GO
SET IDENTITY_INSERT [dbo].[Tarifeler] ON 

INSERT [dbo].[Tarifeler] ([Id], [IlkSaat], [SonSaat], [Ucret], [Aktif], [KayitTarihi]) VALUES (4, CAST(N'2021-11-04T14:01:10.000' AS DateTime), CAST(N'2021-11-04T15:01:10.000' AS DateTime), 10.0000, N'Aktif', CAST(N'2021-11-04T00:00:00.000' AS DateTime))
INSERT [dbo].[Tarifeler] ([Id], [IlkSaat], [SonSaat], [Ucret], [Aktif], [KayitTarihi]) VALUES (5, CAST(N'2021-11-04T14:03:16.000' AS DateTime), CAST(N'2021-11-04T14:03:16.000' AS DateTime), 20.0000, N'Aktif', CAST(N'2021-11-04T00:00:00.000' AS DateTime))
INSERT [dbo].[Tarifeler] ([Id], [IlkSaat], [SonSaat], [Ucret], [Aktif], [KayitTarihi]) VALUES (6, CAST(N'2021-11-04T14:18:12.000' AS DateTime), CAST(N'2021-11-04T14:18:12.000' AS DateTime), 20.0000, N'Pasif', CAST(N'2021-11-04T00:00:00.000' AS DateTime))
INSERT [dbo].[Tarifeler] ([Id], [IlkSaat], [SonSaat], [Ucret], [Aktif], [KayitTarihi]) VALUES (7, CAST(N'2021-11-04T14:19:10.000' AS DateTime), CAST(N'2021-11-04T14:19:10.000' AS DateTime), 22.0000, N'Pasif', CAST(N'2021-11-04T00:00:00.000' AS DateTime))
INSERT [dbo].[Tarifeler] ([Id], [IlkSaat], [SonSaat], [Ucret], [Aktif], [KayitTarihi]) VALUES (8, CAST(N'2021-11-04T14:19:24.000' AS DateTime), CAST(N'2021-11-04T14:19:24.000' AS DateTime), 22.0000, N'Aktif', CAST(N'2021-11-04T00:00:00.000' AS DateTime))
INSERT [dbo].[Tarifeler] ([Id], [IlkSaat], [SonSaat], [Ucret], [Aktif], [KayitTarihi]) VALUES (9, CAST(N'2021-11-04T14:23:25.000' AS DateTime), CAST(N'2021-11-04T14:23:25.000' AS DateTime), 10.0000, N'Aktif', CAST(N'2021-11-04T00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[Tarifeler] OFF
GO
/****** Object:  StoredProcedure [dbo].[Goster]    Script Date: 4.11.2021 15:07:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Goster]
as

select * from AboneBilgileri
GO
/****** Object:  StoredProcedure [dbo].[spInsertAbonelikler]    Script Date: 4.11.2021 15:07:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spInsertAbonelikler]
@AboneId int,
@BaslangicTarihi DateTime,
@BitisTarihi DateTime,
@AboneUcreti Money,
@KayitTarihi DateTime
AS
INSERT INTO Abonelikler (AboneId,BaslangicTarihi,BitisTarihi,AboneUcreti,KayitTarihi)
VALUES (@AboneId,@BaslangicTarihi,@BitisTarihi,@AboneUcreti,@KayitTarihi)
GO
/****** Object:  StoredProcedure [dbo].[spInsertAracGirisCikis]    Script Date: 4.11.2021 15:07:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[spInsertAracGirisCikis]
@AboneId int,
@AracPlaka varchar(10),
@GirisTarihi datetime,
@CikisTarihi datetime,
@Sure int,
@Ucret money,
@KayitTarihi datetime
As 
begin 
insert into GirisCikisKayitlari (AboneId, AracPlaka,GirisTarihi,CikisTarihi,Sure,Ucret,KayitTarihi)
Values ( @AboneId,@AracPlaka,@GirisTarihi,@CikisTarihi,@Sure,@Ucret,@KayitTarihi)
End
GO
/****** Object:  StoredProcedure [dbo].[spInsertTarife]    Script Date: 4.11.2021 15:07:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spInsertTarife]
	@IlkSaat datetime,
	@SonSaat datetime,
	@Ucret money,
	@Aktif nvarchar(50),
	@KayitTarihi datetime
As
INSERT INTO Tarifeler (IlkSaat,SonSaat,Ucret,Aktif,KayitTarihi)
VALUES (@IlkSaat,@SonSaat,@Ucret,@Aktif,@KayitTarihi)
GO
/****** Object:  StoredProcedure [dbo].[spInsertUser]    Script Date: 4.11.2021 15:07:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[spInsertUser]
(
	@AboneId Int,
	@Ad VARCHAR(20),
	@Soyad VARCHAR(20),
	@Adres TEXT,
	@Ilce VARCHAR(20),
	@Il VARCHAR(20),
	@Telefon CHAR(11),
	@KayitTarihi Datetime
)
As
Begin
	Insert Into AboneBilgileri (AboneId,Ad,Soyad,Adres,Ilce,Il,Telefon,KayitTarihi)
	VALUES (@AboneId,@Ad,@Soyad,@Adres,@Ilce,@Il,@Telefon,@KayitTarihi)
End
GO
/****** Object:  StoredProcedure [dbo].[spUpdadteTarife]    Script Date: 4.11.2021 15:07:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spUpdadteTarife]
@IlkSaat datetime,
@SonSaat datetime,
@Ucret money,
@Aktif nvarchar(50),
@KayitTarihi datetime
as 
begin
Update Tarifeler set IlkSaat=@IlkSaat,SonSaat=@SonSaat,Ucret=@Ucret,Aktif=@Aktif,KayitTarihi=@KayitTarihi
End
GO
/****** Object:  StoredProcedure [dbo].[spUpdateGirisCikis]    Script Date: 4.11.2021 15:07:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[spUpdateGirisCikis]
@AboneId int,
@AracPlaka varchar(10),
@GirisTarihi datetime,
@CikisTarihi datetime,
@Sure int,
@Ucret money,
@KayitTarihi datetime
AS 
UPDATE GirisCikisKayitlari SET CikisTarihi=@CikisTarihi,Sure=@Sure,Ucret=@Ucret
WHERE AboneId=@AboneId
GO
/****** Object:  StoredProcedure [dbo].[spUpdateUsers]    Script Date: 4.11.2021 15:07:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[spUpdateUsers]
(
	@AboneId INT,
	@Ad VARCHAR(20),
	@Soyad VARCHAR(20),
	@Adres TEXT,
	@Ilce VARCHAR(20),
	@Il VARCHAR(20),
	@Telefon CHAR(11),
	@KayitTarihi DATETIME

)
AS 
BEGIN
UPDATE AboneBilgileri
SET Ad = @Ad, Soyad = @Soyad,Adres=@Adres, Ilce=@Ilce, Il=@Il,Telefon=@Telefon, KayitTarihi=@KayitTarihi
WHERE AboneId = @AboneId
END
GO
/****** Object:  StoredProcedure [dbo].[TarifeleriGoster]    Script Date: 4.11.2021 15:07:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TarifeleriGoster]
AS

Select * From Tarifeler
GO
