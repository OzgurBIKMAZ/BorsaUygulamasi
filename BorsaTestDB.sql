USE [master]
GO
/****** Object:  Database [Borsa]    Script Date: 7.01.2020 23:50:34 ******/
CREATE DATABASE [Borsa]

GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Borsa].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Borsa] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Borsa] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Borsa] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Borsa] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Borsa] SET ARITHABORT OFF 
GO
ALTER DATABASE [Borsa] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Borsa] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Borsa] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Borsa] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Borsa] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Borsa] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Borsa] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Borsa] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Borsa] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Borsa] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Borsa] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Borsa] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Borsa] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Borsa] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Borsa] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Borsa] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Borsa] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Borsa] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Borsa] SET  MULTI_USER 
GO
ALTER DATABASE [Borsa] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Borsa] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Borsa] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Borsa] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Borsa] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Borsa] SET QUERY_STORE = OFF
GO
USE [Borsa]
GO
/****** Object:  Table [dbo].[Borsa]    Script Date: 7.01.2020 23:50:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Borsa](
	[BorsaID] [int] IDENTITY(1,1) NOT NULL,
	[Tur] [int] NOT NULL,
	[Adi] [nvarchar](50) NOT NULL,
	[isDeleted] [bit] NOT NULL,
	[Tarih] [datetime] NOT NULL,
 CONSTRAINT [PK_BorsaCanli] PRIMARY KEY CLUSTERED 
(
	[BorsaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BorsaIslem]    Script Date: 7.01.2020 23:50:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BorsaIslem](
	[IslemID] [int] IDENTITY(1,1) NOT NULL,
	[BorsaID] [int] NOT NULL,
	[Alis] [float] NOT NULL,
	[Satis] [float] NOT NULL,
	[Degisim] [float] NOT NULL,
	[Tarih] [datetime] NOT NULL,
 CONSTRAINT [PK_Table_1] PRIMARY KEY CLUSTERED 
(
	[IslemID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BorsaKullanici]    Script Date: 7.01.2020 23:50:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BorsaKullanici](
	[KullaniciID] [int] IDENTITY(1,1) NOT NULL,
	[Tur] [int] NOT NULL,
	[KullaniciAdi] [nvarchar](50) NOT NULL,
	[Sifre] [nvarchar](50) NOT NULL,
	[TcKimlikNo] [nvarchar](11) NOT NULL,
	[Adi] [nvarchar](50) NOT NULL,
	[Soyadi] [nvarchar](50) NOT NULL,
	[DogumTarihi] [datetime] NOT NULL,
	[Telefon] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[Adres] [nvarchar](50) NULL,
	[KayitTarihi] [datetime] NOT NULL,
	[isDeleted] [bit] NOT NULL,
 CONSTRAINT [PK_BorsaKullanici] PRIMARY KEY CLUSTERED 
(
	[KullaniciID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BorsaKullaniciIslem]    Script Date: 7.01.2020 23:50:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BorsaKullaniciIslem](
	[KullaniciIslemID] [int] IDENTITY(1,1) NOT NULL,
	[KullaniciID] [int] NOT NULL,
	[BorsaID] [int] NOT NULL,
	[Miktar] [float] NOT NULL,
	[CuzdanEkle] [bit] NOT NULL,
	[Tarih] [datetime] NOT NULL,
	[isDeleted] [bit] NOT NULL,
 CONSTRAINT [PK_BorsaKullaniciIslem] PRIMARY KEY CLUSTERED 
(
	[KullaniciIslemID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Borsa] ON 

INSERT [dbo].[Borsa] ([BorsaID], [Tur], [Adi], [isDeleted], [Tarih]) VALUES (1, 0, N'Nakit', 0, CAST(N'2019-12-18T00:00:00.000' AS DateTime))
INSERT [dbo].[Borsa] ([BorsaID], [Tur], [Adi], [isDeleted], [Tarih]) VALUES (2, 1, N'Dolar', 0, CAST(N'2019-12-18T00:00:00.000' AS DateTime))
INSERT [dbo].[Borsa] ([BorsaID], [Tur], [Adi], [isDeleted], [Tarih]) VALUES (3, 1, N'Euro', 0, CAST(N'2019-12-18T00:00:00.000' AS DateTime))
INSERT [dbo].[Borsa] ([BorsaID], [Tur], [Adi], [isDeleted], [Tarih]) VALUES (4, 1, N'Sterlin', 0, CAST(N'2019-12-18T00:00:00.000' AS DateTime))
INSERT [dbo].[Borsa] ([BorsaID], [Tur], [Adi], [isDeleted], [Tarih]) VALUES (5, 1, N'Frank', 0, CAST(N'2019-12-18T00:00:00.000' AS DateTime))
INSERT [dbo].[Borsa] ([BorsaID], [Tur], [Adi], [isDeleted], [Tarih]) VALUES (6, 1, N'Yen', 0, CAST(N'2019-12-18T00:00:00.000' AS DateTime))
INSERT [dbo].[Borsa] ([BorsaID], [Tur], [Adi], [isDeleted], [Tarih]) VALUES (7, 2, N'Altın(Gr)', 0, CAST(N'2019-12-18T00:00:00.000' AS DateTime))
INSERT [dbo].[Borsa] ([BorsaID], [Tur], [Adi], [isDeleted], [Tarih]) VALUES (8, 2, N'Çeyrek Altın', 0, CAST(N'2019-12-18T00:00:00.000' AS DateTime))
INSERT [dbo].[Borsa] ([BorsaID], [Tur], [Adi], [isDeleted], [Tarih]) VALUES (9, 3, N'AFYON', 0, CAST(N'2019-12-18T00:00:00.000' AS DateTime))
INSERT [dbo].[Borsa] ([BorsaID], [Tur], [Adi], [isDeleted], [Tarih]) VALUES (10, 3, N'AKSA', 0, CAST(N'2019-12-18T00:00:00.000' AS DateTime))
INSERT [dbo].[Borsa] ([BorsaID], [Tur], [Adi], [isDeleted], [Tarih]) VALUES (11, 3, N'BIT', 1, CAST(N'2019-12-19T00:00:00.000' AS DateTime))
INSERT [dbo].[Borsa] ([BorsaID], [Tur], [Adi], [isDeleted], [Tarih]) VALUES (12, 2, N'Odas', 1, CAST(N'2019-12-20T01:52:51.647' AS DateTime))
INSERT [dbo].[Borsa] ([BorsaID], [Tur], [Adi], [isDeleted], [Tarih]) VALUES (16, 3, N'deneme', 1, CAST(N'2019-12-20T02:12:47.720' AS DateTime))
INSERT [dbo].[Borsa] ([BorsaID], [Tur], [Adi], [isDeleted], [Tarih]) VALUES (17, 3, N'TCELL', 1, CAST(N'2019-12-20T02:16:17.827' AS DateTime))
INSERT [dbo].[Borsa] ([BorsaID], [Tur], [Adi], [isDeleted], [Tarih]) VALUES (18, 3, N'Yatas', 0, CAST(N'2019-12-20T02:19:12.463' AS DateTime))
INSERT [dbo].[Borsa] ([BorsaID], [Tur], [Adi], [isDeleted], [Tarih]) VALUES (19, 3, N'Metro', 0, CAST(N'2019-12-20T02:20:01.447' AS DateTime))
INSERT [dbo].[Borsa] ([BorsaID], [Tur], [Adi], [isDeleted], [Tarih]) VALUES (20, 3, N'Mavi', 0, CAST(N'2019-12-20T02:20:39.567' AS DateTime))
SET IDENTITY_INSERT [dbo].[Borsa] OFF
SET IDENTITY_INSERT [dbo].[BorsaIslem] ON 

INSERT [dbo].[BorsaIslem] ([IslemID], [BorsaID], [Alis], [Satis], [Degisim], [Tarih]) VALUES (1, 2, 2.23, 2.46, 0, CAST(N'2019-12-19T09:32:09.823' AS DateTime))
INSERT [dbo].[BorsaIslem] ([IslemID], [BorsaID], [Alis], [Satis], [Degisim], [Tarih]) VALUES (2, 3, 3.33, 4.43, 0, CAST(N'2019-12-19T09:32:10.917' AS DateTime))
INSERT [dbo].[BorsaIslem] ([IslemID], [BorsaID], [Alis], [Satis], [Degisim], [Tarih]) VALUES (3, 4, 4.49, 4.61, 0, CAST(N'2019-12-19T09:32:12.010' AS DateTime))
INSERT [dbo].[BorsaIslem] ([IslemID], [BorsaID], [Alis], [Satis], [Degisim], [Tarih]) VALUES (4, 5, 5.98, 7.01, 0, CAST(N'2019-12-19T09:32:13.107' AS DateTime))
INSERT [dbo].[BorsaIslem] ([IslemID], [BorsaID], [Alis], [Satis], [Degisim], [Tarih]) VALUES (5, 6, 6.65, 7.12, 0, CAST(N'2019-12-19T09:32:14.197' AS DateTime))
INSERT [dbo].[BorsaIslem] ([IslemID], [BorsaID], [Alis], [Satis], [Degisim], [Tarih]) VALUES (6, 7, 7.78, 7.81, 0, CAST(N'2019-12-19T09:32:15.293' AS DateTime))
INSERT [dbo].[BorsaIslem] ([IslemID], [BorsaID], [Alis], [Satis], [Degisim], [Tarih]) VALUES (7, 8, 10.12, 11.12, 0, CAST(N'2019-12-19T09:32:16.387' AS DateTime))
INSERT [dbo].[BorsaIslem] ([IslemID], [BorsaID], [Alis], [Satis], [Degisim], [Tarih]) VALUES (8, 9, 200.65, 205.78, 0, CAST(N'2019-12-19T09:32:17.480' AS DateTime))
INSERT [dbo].[BorsaIslem] ([IslemID], [BorsaID], [Alis], [Satis], [Degisim], [Tarih]) VALUES (9, 10, 151.51, 130.4, 0, CAST(N'2019-12-19T09:32:18.570' AS DateTime))
INSERT [dbo].[BorsaIslem] ([IslemID], [BorsaID], [Alis], [Satis], [Degisim], [Tarih]) VALUES (10, 12, 5.53, 6, 0, CAST(N'2019-12-19T09:32:08.733' AS DateTime))
INSERT [dbo].[BorsaIslem] ([IslemID], [BorsaID], [Alis], [Satis], [Degisim], [Tarih]) VALUES (13, 18, 52.23, 52.7, 0, CAST(N'2019-12-19T09:32:08.733' AS DateTime))
INSERT [dbo].[BorsaIslem] ([IslemID], [BorsaID], [Alis], [Satis], [Degisim], [Tarih]) VALUES (14, 19, 6.53, 6.58, 0, CAST(N'2019-12-19T09:32:08.733' AS DateTime))
INSERT [dbo].[BorsaIslem] ([IslemID], [BorsaID], [Alis], [Satis], [Degisim], [Tarih]) VALUES (15, 20, 1.53, 1.55, 0, CAST(N'2019-12-19T09:32:08.733' AS DateTime))
SET IDENTITY_INSERT [dbo].[BorsaIslem] OFF
SET IDENTITY_INSERT [dbo].[BorsaKullanici] ON 

INSERT [dbo].[BorsaKullanici] ([KullaniciID], [Tur], [KullaniciAdi], [Sifre], [TcKimlikNo], [Adi], [Soyadi], [DogumTarihi], [Telefon], [Email], [Adres], [KayitTarihi], [isDeleted]) VALUES (1, 0, N'admin', N'1234', N'12345321312', N'admin', N'ADMİN', CAST(N'2019-12-17T00:00:00.000' AS DateTime), N'(344) 566-4564', N'admin@admin.com', N'Administator', CAST(N'2019-12-17T00:00:00.000' AS DateTime), 0)
INSERT [dbo].[BorsaKullanici] ([KullaniciID], [Tur], [KullaniciAdi], [Sifre], [TcKimlikNo], [Adi], [Soyadi], [DogumTarihi], [Telefon], [Email], [Adres], [KayitTarihi], [isDeleted]) VALUES (3, 1, N'user', N'was123', N'312321', N'Ali', N'KOÇ', CAST(N'2000-12-17T00:00:00.000' AS DateTime), NULL, NULL, NULL, CAST(N'2019-12-17T00:00:00.000' AS DateTime), 0)
INSERT [dbo].[BorsaKullanici] ([KullaniciID], [Tur], [KullaniciAdi], [Sifre], [TcKimlikNo], [Adi], [Soyadi], [DogumTarihi], [Telefon], [Email], [Adres], [KayitTarihi], [isDeleted]) VALUES (4, 1, N'broker', N'1234', N'12346456442', N'ali', N'ÇAVUŞ', CAST(N'2000-12-17T22:31:02.000' AS DateTime), N'(123) 123-4534', N'ali@deneme.com', N'Bakırköy', CAST(N'2019-12-17T22:31:46.870' AS DateTime), 0)
INSERT [dbo].[BorsaKullanici] ([KullaniciID], [Tur], [KullaniciAdi], [Sifre], [TcKimlikNo], [Adi], [Soyadi], [DogumTarihi], [Telefon], [Email], [Adres], [KayitTarihi], [isDeleted]) VALUES (5, 2, N'Hasan24', N'was12', N'12123', N'hasan', N'MERT', CAST(N'1995-06-11T23:24:17.000' AS DateTime), N'(123) 123-1234', N'hasan.mert@deneme.com', N'Kadıköy', CAST(N'2019-12-17T23:25:24.110' AS DateTime), 0)
INSERT [dbo].[BorsaKullanici] ([KullaniciID], [Tur], [KullaniciAdi], [Sifre], [TcKimlikNo], [Adi], [Soyadi], [DogumTarihi], [Telefon], [Email], [Adres], [KayitTarihi], [isDeleted]) VALUES (6, 3, N'WissenAnonim', N'1234', N'12331231312', N'wissen', N'WİSSEN', CAST(N'2000-12-19T18:36:15.000' AS DateTime), N'(   )    -', N'', N'', CAST(N'2019-12-19T18:37:22.623' AS DateTime), 1)
INSERT [dbo].[BorsaKullanici] ([KullaniciID], [Tur], [KullaniciAdi], [Sifre], [TcKimlikNo], [Adi], [Soyadi], [DogumTarihi], [Telefon], [Email], [Adres], [KayitTarihi], [isDeleted]) VALUES (7, 1, N'Normal', N'1234', N'23123312312', N'normal', N'KULLANICI', CAST(N'1999-12-20T00:02:06.000' AS DateTime), N'(   )    -', N'', N'', CAST(N'2019-12-20T00:02:47.737' AS DateTime), 0)
INSERT [dbo].[BorsaKullanici] ([KullaniciID], [Tur], [KullaniciAdi], [Sifre], [TcKimlikNo], [Adi], [Soyadi], [DogumTarihi], [Telefon], [Email], [Adres], [KayitTarihi], [isDeleted]) VALUES (8, 2, N'Broker12', N'broker12', N'12312312321', N'broker', N'ONİKİ', CAST(N'1999-12-20T01:20:29.000' AS DateTime), N'(123) 135-3453', N'', N'', CAST(N'2019-12-20T01:21:05.083' AS DateTime), 0)
SET IDENTITY_INSERT [dbo].[BorsaKullanici] OFF
SET IDENTITY_INSERT [dbo].[BorsaKullaniciIslem] ON 

INSERT [dbo].[BorsaKullaniciIslem] ([KullaniciIslemID], [KullaniciID], [BorsaID], [Miktar], [CuzdanEkle], [Tarih], [isDeleted]) VALUES (1, 1, 1, 15000, 1, CAST(N'2019-12-16T00:00:00.000' AS DateTime), 0)
INSERT [dbo].[BorsaKullaniciIslem] ([KullaniciIslemID], [KullaniciID], [BorsaID], [Miktar], [CuzdanEkle], [Tarih], [isDeleted]) VALUES (2, 1, 1, 3000, 0, CAST(N'2019-12-16T00:00:00.000' AS DateTime), 0)
INSERT [dbo].[BorsaKullaniciIslem] ([KullaniciIslemID], [KullaniciID], [BorsaID], [Miktar], [CuzdanEkle], [Tarih], [isDeleted]) VALUES (3, 1, 2, 300, 1, CAST(N'2019-12-16T00:00:00.000' AS DateTime), 0)
INSERT [dbo].[BorsaKullaniciIslem] ([KullaniciIslemID], [KullaniciID], [BorsaID], [Miktar], [CuzdanEkle], [Tarih], [isDeleted]) VALUES (4, 1, 2, 500, 1, CAST(N'2019-12-05T00:00:00.000' AS DateTime), 0)
INSERT [dbo].[BorsaKullaniciIslem] ([KullaniciIslemID], [KullaniciID], [BorsaID], [Miktar], [CuzdanEkle], [Tarih], [isDeleted]) VALUES (5, 1, 4, 112.5, 1, CAST(N'2019-12-18T00:00:00.000' AS DateTime), 0)
INSERT [dbo].[BorsaKullaniciIslem] ([KullaniciIslemID], [KullaniciID], [BorsaID], [Miktar], [CuzdanEkle], [Tarih], [isDeleted]) VALUES (6, 1, 4, 10, 0, CAST(N'2019-12-17T00:00:00.000' AS DateTime), 0)
INSERT [dbo].[BorsaKullaniciIslem] ([KullaniciIslemID], [KullaniciID], [BorsaID], [Miktar], [CuzdanEkle], [Tarih], [isDeleted]) VALUES (8, 3, 1, 1000, 1, CAST(N'2019-12-15T00:00:00.000' AS DateTime), 0)
INSERT [dbo].[BorsaKullaniciIslem] ([KullaniciIslemID], [KullaniciID], [BorsaID], [Miktar], [CuzdanEkle], [Tarih], [isDeleted]) VALUES (9, 3, 2, 375, 0, CAST(N'2019-12-15T00:00:00.000' AS DateTime), 0)
INSERT [dbo].[BorsaKullaniciIslem] ([KullaniciIslemID], [KullaniciID], [BorsaID], [Miktar], [CuzdanEkle], [Tarih], [isDeleted]) VALUES (10, 1, 1, 1205, 1, CAST(N'2019-12-18T21:48:55.177' AS DateTime), 0)
INSERT [dbo].[BorsaKullaniciIslem] ([KullaniciIslemID], [KullaniciID], [BorsaID], [Miktar], [CuzdanEkle], [Tarih], [isDeleted]) VALUES (11, 3, 1, 55, 1, CAST(N'2019-12-19T20:08:47.363' AS DateTime), 0)
INSERT [dbo].[BorsaKullaniciIslem] ([KullaniciIslemID], [KullaniciID], [BorsaID], [Miktar], [CuzdanEkle], [Tarih], [isDeleted]) VALUES (12, 3, 2, 1, 1, CAST(N'2019-12-19T20:09:04.607' AS DateTime), 0)
INSERT [dbo].[BorsaKullaniciIslem] ([KullaniciIslemID], [KullaniciID], [BorsaID], [Miktar], [CuzdanEkle], [Tarih], [isDeleted]) VALUES (13, 3, 1, 585, 0, CAST(N'2019-12-19T20:09:04.623' AS DateTime), 0)
INSERT [dbo].[BorsaKullaniciIslem] ([KullaniciIslemID], [KullaniciID], [BorsaID], [Miktar], [CuzdanEkle], [Tarih], [isDeleted]) VALUES (14, 1, 2, 1, 0, CAST(N'2019-12-19T20:13:58.380' AS DateTime), 0)
INSERT [dbo].[BorsaKullaniciIslem] ([KullaniciIslemID], [KullaniciID], [BorsaID], [Miktar], [CuzdanEkle], [Tarih], [isDeleted]) VALUES (15, 1, 1, 585, 1, CAST(N'2019-12-19T20:13:58.420' AS DateTime), 0)
INSERT [dbo].[BorsaKullaniciIslem] ([KullaniciIslemID], [KullaniciID], [BorsaID], [Miktar], [CuzdanEkle], [Tarih], [isDeleted]) VALUES (16, 1, 1, 100000, 1, CAST(N'2019-12-19T23:54:01.510' AS DateTime), 0)
INSERT [dbo].[BorsaKullaniciIslem] ([KullaniciIslemID], [KullaniciID], [BorsaID], [Miktar], [CuzdanEkle], [Tarih], [isDeleted]) VALUES (17, 1, 1, 125120, 1, CAST(N'2019-12-19T23:55:35.260' AS DateTime), 0)
INSERT [dbo].[BorsaKullaniciIslem] ([KullaniciIslemID], [KullaniciID], [BorsaID], [Miktar], [CuzdanEkle], [Tarih], [isDeleted]) VALUES (18, 1, 8, 2, 1, CAST(N'2019-12-19T23:55:44.793' AS DateTime), 0)
INSERT [dbo].[BorsaKullaniciIslem] ([KullaniciIslemID], [KullaniciID], [BorsaID], [Miktar], [CuzdanEkle], [Tarih], [isDeleted]) VALUES (19, 1, 1, 780, 0, CAST(N'2019-12-19T23:55:44.800' AS DateTime), 0)
INSERT [dbo].[BorsaKullaniciIslem] ([KullaniciIslemID], [KullaniciID], [BorsaID], [Miktar], [CuzdanEkle], [Tarih], [isDeleted]) VALUES (20, 1, 8, 10, 1, CAST(N'2019-12-19T23:55:57.873' AS DateTime), 0)
INSERT [dbo].[BorsaKullaniciIslem] ([KullaniciIslemID], [KullaniciID], [BorsaID], [Miktar], [CuzdanEkle], [Tarih], [isDeleted]) VALUES (21, 1, 1, 3900, 0, CAST(N'2019-12-19T23:55:57.877' AS DateTime), 0)
INSERT [dbo].[BorsaKullaniciIslem] ([KullaniciIslemID], [KullaniciID], [BorsaID], [Miktar], [CuzdanEkle], [Tarih], [isDeleted]) VALUES (22, 1, 10, 200, 1, CAST(N'2019-12-19T23:57:20.453' AS DateTime), 0)
INSERT [dbo].[BorsaKullaniciIslem] ([KullaniciIslemID], [KullaniciID], [BorsaID], [Miktar], [CuzdanEkle], [Tarih], [isDeleted]) VALUES (23, 1, 1, 99000, 0, CAST(N'2019-12-19T23:57:20.483' AS DateTime), 0)
INSERT [dbo].[BorsaKullaniciIslem] ([KullaniciIslemID], [KullaniciID], [BorsaID], [Miktar], [CuzdanEkle], [Tarih], [isDeleted]) VALUES (24, 1, 8, 2, 0, CAST(N'2019-12-19T23:57:32.760' AS DateTime), 0)
INSERT [dbo].[BorsaKullaniciIslem] ([KullaniciIslemID], [KullaniciID], [BorsaID], [Miktar], [CuzdanEkle], [Tarih], [isDeleted]) VALUES (25, 1, 1, 780, 1, CAST(N'2019-12-19T23:57:32.767' AS DateTime), 0)
INSERT [dbo].[BorsaKullaniciIslem] ([KullaniciIslemID], [KullaniciID], [BorsaID], [Miktar], [CuzdanEkle], [Tarih], [isDeleted]) VALUES (26, 1, 2, 2, 0, CAST(N'2019-12-19T23:57:37.810' AS DateTime), 0)
INSERT [dbo].[BorsaKullaniciIslem] ([KullaniciIslemID], [KullaniciID], [BorsaID], [Miktar], [CuzdanEkle], [Tarih], [isDeleted]) VALUES (27, 1, 1, 1170, 1, CAST(N'2019-12-19T23:57:37.813' AS DateTime), 0)
INSERT [dbo].[BorsaKullaniciIslem] ([KullaniciIslemID], [KullaniciID], [BorsaID], [Miktar], [CuzdanEkle], [Tarih], [isDeleted]) VALUES (28, 3, 1, 100000, 1, CAST(N'2019-12-20T07:41:52.680' AS DateTime), 0)
INSERT [dbo].[BorsaKullaniciIslem] ([KullaniciIslemID], [KullaniciID], [BorsaID], [Miktar], [CuzdanEkle], [Tarih], [isDeleted]) VALUES (29, 3, 20, 100, 1, CAST(N'2019-12-20T07:42:09.563' AS DateTime), 0)
INSERT [dbo].[BorsaKullaniciIslem] ([KullaniciIslemID], [KullaniciID], [BorsaID], [Miktar], [CuzdanEkle], [Tarih], [isDeleted]) VALUES (30, 3, 1, 57.3672313631112, 0, CAST(N'2019-12-20T07:42:09.570' AS DateTime), 0)
INSERT [dbo].[BorsaKullaniciIslem] ([KullaniciIslemID], [KullaniciID], [BorsaID], [Miktar], [CuzdanEkle], [Tarih], [isDeleted]) VALUES (31, 3, 12, 250, 1, CAST(N'2019-12-20T07:42:29.877' AS DateTime), 0)
INSERT [dbo].[BorsaKullaniciIslem] ([KullaniciIslemID], [KullaniciID], [BorsaID], [Miktar], [CuzdanEkle], [Tarih], [isDeleted]) VALUES (32, 3, 1, 925.77854005213692, 0, CAST(N'2019-12-20T07:42:29.883' AS DateTime), 0)
INSERT [dbo].[BorsaKullaniciIslem] ([KullaniciIslemID], [KullaniciID], [BorsaID], [Miktar], [CuzdanEkle], [Tarih], [isDeleted]) VALUES (33, 3, 5, 500, 1, CAST(N'2019-12-20T07:42:52.197' AS DateTime), 0)
INSERT [dbo].[BorsaKullaniciIslem] ([KullaniciIslemID], [KullaniciID], [BorsaID], [Miktar], [CuzdanEkle], [Tarih], [isDeleted]) VALUES (34, 3, 1, 2686.9028033299919, 0, CAST(N'2019-12-20T07:42:52.203' AS DateTime), 0)
INSERT [dbo].[BorsaKullaniciIslem] ([KullaniciIslemID], [KullaniciID], [BorsaID], [Miktar], [CuzdanEkle], [Tarih], [isDeleted]) VALUES (35, 3, 20, 2, 0, CAST(N'2019-12-20T07:43:25.140' AS DateTime), 0)
INSERT [dbo].[BorsaKullaniciIslem] ([KullaniciIslemID], [KullaniciID], [BorsaID], [Miktar], [CuzdanEkle], [Tarih], [isDeleted]) VALUES (36, 3, 1, 1.5744053354648673, 1, CAST(N'2019-12-20T07:43:25.143' AS DateTime), 0)
INSERT [dbo].[BorsaKullaniciIslem] ([KullaniciIslemID], [KullaniciID], [BorsaID], [Miktar], [CuzdanEkle], [Tarih], [isDeleted]) VALUES (37, 3, 12, 100, 0, CAST(N'2019-12-20T07:43:36.637' AS DateTime), 0)
INSERT [dbo].[BorsaKullaniciIslem] ([KullaniciIslemID], [KullaniciID], [BorsaID], [Miktar], [CuzdanEkle], [Tarih], [isDeleted]) VALUES (38, 3, 1, 375.39550646790792, 1, CAST(N'2019-12-20T07:43:36.640' AS DateTime), 0)
INSERT [dbo].[BorsaKullaniciIslem] ([KullaniciIslemID], [KullaniciID], [BorsaID], [Miktar], [CuzdanEkle], [Tarih], [isDeleted]) VALUES (39, 3, 2, 222, 1, CAST(N'2019-12-21T20:07:09.047' AS DateTime), 0)
INSERT [dbo].[BorsaKullaniciIslem] ([KullaniciIslemID], [KullaniciID], [BorsaID], [Miktar], [CuzdanEkle], [Tarih], [isDeleted]) VALUES (40, 3, 1, 102.83272389734853, 0, CAST(N'2019-12-21T20:07:09.057' AS DateTime), 0)
INSERT [dbo].[BorsaKullaniciIslem] ([KullaniciIslemID], [KullaniciID], [BorsaID], [Miktar], [CuzdanEkle], [Tarih], [isDeleted]) VALUES (41, 3, 2, 221, 1, CAST(N'2019-12-21T20:07:14.257' AS DateTime), 0)
INSERT [dbo].[BorsaKullaniciIslem] ([KullaniciIslemID], [KullaniciID], [BorsaID], [Miktar], [CuzdanEkle], [Tarih], [isDeleted]) VALUES (42, 3, 1, 106.69808862388832, 0, CAST(N'2019-12-21T20:07:14.263' AS DateTime), 0)
INSERT [dbo].[BorsaKullaniciIslem] ([KullaniciIslemID], [KullaniciID], [BorsaID], [Miktar], [CuzdanEkle], [Tarih], [isDeleted]) VALUES (43, 3, 2, 11, 1, CAST(N'2019-12-21T20:30:06.730' AS DateTime), 0)
INSERT [dbo].[BorsaKullaniciIslem] ([KullaniciIslemID], [KullaniciID], [BorsaID], [Miktar], [CuzdanEkle], [Tarih], [isDeleted]) VALUES (44, 3, 1, 22.715559989239374, 0, CAST(N'2019-12-21T20:30:06.743' AS DateTime), 0)
INSERT [dbo].[BorsaKullaniciIslem] ([KullaniciIslemID], [KullaniciID], [BorsaID], [Miktar], [CuzdanEkle], [Tarih], [isDeleted]) VALUES (46, 1, 1, 1166.3346511565089, 0, CAST(N'2019-12-21T20:36:23.230' AS DateTime), 0)
INSERT [dbo].[BorsaKullaniciIslem] ([KullaniciIslemID], [KullaniciID], [BorsaID], [Miktar], [CuzdanEkle], [Tarih], [isDeleted]) VALUES (48, 1, 1, 1189.8962128380272, 0, CAST(N'2019-12-21T20:36:30.553' AS DateTime), 0)
INSERT [dbo].[BorsaKullaniciIslem] ([KullaniciIslemID], [KullaniciID], [BorsaID], [Miktar], [CuzdanEkle], [Tarih], [isDeleted]) VALUES (49, 4, 1, 111111, 1, CAST(N'2019-12-21T20:38:56.847' AS DateTime), 0)
INSERT [dbo].[BorsaKullaniciIslem] ([KullaniciIslemID], [KullaniciID], [BorsaID], [Miktar], [CuzdanEkle], [Tarih], [isDeleted]) VALUES (51, 4, 1, 1756.1621665613868, 0, CAST(N'2019-12-21T20:39:02.790' AS DateTime), 0)
INSERT [dbo].[BorsaKullaniciIslem] ([KullaniciIslemID], [KullaniciID], [BorsaID], [Miktar], [CuzdanEkle], [Tarih], [isDeleted]) VALUES (52, 4, 2, 1, 1, CAST(N'2019-12-21T20:52:46.370' AS DateTime), 0)
INSERT [dbo].[BorsaKullaniciIslem] ([KullaniciIslemID], [KullaniciID], [BorsaID], [Miktar], [CuzdanEkle], [Tarih], [isDeleted]) VALUES (53, 4, 1, 2.2542457080930882, 0, CAST(N'2019-12-21T20:52:46.380' AS DateTime), 0)
SET IDENTITY_INSERT [dbo].[BorsaKullaniciIslem] OFF
ALTER TABLE [dbo].[BorsaIslem]  WITH CHECK ADD  CONSTRAINT [FK_BorsaIslem_Borsa] FOREIGN KEY([BorsaID])
REFERENCES [dbo].[Borsa] ([BorsaID])
GO
ALTER TABLE [dbo].[BorsaIslem] CHECK CONSTRAINT [FK_BorsaIslem_Borsa]
GO
ALTER TABLE [dbo].[BorsaKullaniciIslem]  WITH CHECK ADD  CONSTRAINT [FK_BorsaKullaniciIslem_Borsa] FOREIGN KEY([BorsaID])
REFERENCES [dbo].[Borsa] ([BorsaID])
GO
ALTER TABLE [dbo].[BorsaKullaniciIslem] CHECK CONSTRAINT [FK_BorsaKullaniciIslem_Borsa]
GO
ALTER TABLE [dbo].[BorsaKullaniciIslem]  WITH CHECK ADD  CONSTRAINT [FK_BorsaKullaniciIslem_BorsaKullanici] FOREIGN KEY([KullaniciID])
REFERENCES [dbo].[BorsaKullanici] ([KullaniciID])
GO
ALTER TABLE [dbo].[BorsaKullaniciIslem] CHECK CONSTRAINT [FK_BorsaKullaniciIslem_BorsaKullanici]
GO
USE [master]
GO
ALTER DATABASE [Borsa] SET  READ_WRITE 
GO
