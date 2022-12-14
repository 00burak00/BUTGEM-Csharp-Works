USE [E:\YAZıLıMPAYLAS\ASP_NET_UYGULAMALARI\VERITABANI_ETICARET\APP_DATA\VT_ETICARET.MDF]
GO
/****** Object:  Table [dbo].[active]    Script Date: 28.04.2022 12:19:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[active](
	[uyeid] [int] NULL,
	[akodu] [nchar](10) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[altkategoriler]    Script Date: 28.04.2022 12:19:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[altkategoriler](
	[altkateno] [smallint] IDENTITY(1,1) NOT NULL,
	[altkateadi] [nvarchar](50) NOT NULL,
	[anakateno] [tinyint] NOT NULL,
 CONSTRAINT [PK_altkategoriler] PRIMARY KEY CLUSTERED 
(
	[altkateno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[favoriler]    Script Date: 28.04.2022 12:19:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[favoriler](
	[favno] [bigint] IDENTITY(1,1) NOT NULL,
	[uyeid] [int] NOT NULL,
	[urunid] [int] NOT NULL,
 CONSTRAINT [PK_favoriler] PRIMARY KEY CLUSTERED 
(
	[favno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[kategoriler]    Script Date: 28.04.2022 12:19:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[kategoriler](
	[kateno] [tinyint] IDENTITY(1,1) NOT NULL,
	[kateadi] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_kategoriler] PRIMARY KEY CLUSTERED 
(
	[kateno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[meslek]    Script Date: 28.04.2022 12:19:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[meslek](
	[meslekid] [smallint] IDENTITY(1,1) NOT NULL,
	[meslekad] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_meslek] PRIMARY KEY CLUSTERED 
(
	[meslekid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[sehirler]    Script Date: 28.04.2022 12:19:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sehirler](
	[plaka] [tinyint] NOT NULL,
	[sehiradi] [nvarchar](15) NOT NULL,
 CONSTRAINT [PK_sehirler] PRIMARY KEY CLUSTERED 
(
	[plaka] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[siparisler]    Script Date: 28.04.2022 12:19:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[siparisler](
	[uyeid] [int] NOT NULL,
	[urunid] [int] NOT NULL,
	[adet] [smallint] NOT NULL,
	[sip_tarihi] [smalldatetime] NOT NULL,
	[sipno] [int] NOT NULL,
	[kayitno] [bigint] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_siparisler] PRIMARY KEY CLUSTERED 
(
	[kayitno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[toplam_kazan]    Script Date: 28.04.2022 12:19:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[toplam_kazan](
	[sipno] [int] NOT NULL,
	[toplamfiy] [float] NOT NULL,
	[sip_tarihi] [smalldatetime] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[urunler]    Script Date: 28.04.2022 12:19:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[urunler](
	[urunid] [int] IDENTITY(1,1) NOT NULL,
	[urunadi] [nvarchar](50) NOT NULL,
	[fiyat] [float] NOT NULL,
	[aciklama] [nvarchar](2000) NULL,
	[resim] [nvarchar](50) NULL,
	[kateno] [tinyint] NOT NULL,
 CONSTRAINT [PK_urunler] PRIMARY KEY CLUSTERED 
(
	[urunid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[uyeler]    Script Date: 28.04.2022 12:19:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[uyeler](
	[uyeid] [int] IDENTITY(1,1) NOT NULL,
	[kuladi] [nvarchar](30) NOT NULL,
	[sifre] [nvarchar](20) NOT NULL,
	[adsoyad] [nvarchar](50) NOT NULL,
	[dogtar] [smalldatetime] NOT NULL,
	[cinsiyet] [bit] NOT NULL,
	[adres] [nvarchar](400) NULL,
	[plaka] [tinyint] NOT NULL,
	[email] [nvarchar](50) NOT NULL,
	[meslekid] [smallint] NOT NULL,
	[onay] [bit] NULL CONSTRAINT [DF_uyeler_onay]  DEFAULT ((0)),
 CONSTRAINT [PK_uyeler] PRIMARY KEY CLUSTERED 
(
	[uyeid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[active] ([uyeid], [akodu]) VALUES (55, N'7055      ')
INSERT [dbo].[active] ([uyeid], [akodu]) VALUES (56, N'9706      ')
SET IDENTITY_INSERT [dbo].[altkategoriler] ON 

INSERT [dbo].[altkategoriler] ([altkateno], [altkateadi], [anakateno]) VALUES (1, N'gigabyte', 1)
INSERT [dbo].[altkategoriler] ([altkateno], [altkateadi], [anakateno]) VALUES (2, N'msi', 1)
INSERT [dbo].[altkategoriler] ([altkateno], [altkateadi], [anakateno]) VALUES (3, N'asus', 1)
INSERT [dbo].[altkategoriler] ([altkateno], [altkateadi], [anakateno]) VALUES (4, N'ssd', 3)
INSERT [dbo].[altkategoriler] ([altkateno], [altkateadi], [anakateno]) VALUES (5, N'sata', 3)
INSERT [dbo].[altkategoriler] ([altkateno], [altkateadi], [anakateno]) VALUES (6, N'ıde', 3)
INSERT [dbo].[altkategoriler] ([altkateno], [altkateadi], [anakateno]) VALUES (7, N'kablolu', 9)
INSERT [dbo].[altkategoriler] ([altkateno], [altkateadi], [anakateno]) VALUES (8, N'kablosuz', 9)
INSERT [dbo].[altkategoriler] ([altkateno], [altkateadi], [anakateno]) VALUES (9, N'lcd', 4)
INSERT [dbo].[altkategoriler] ([altkateno], [altkateadi], [anakateno]) VALUES (11, N'led', 4)
INSERT [dbo].[altkategoriler] ([altkateno], [altkateadi], [anakateno]) VALUES (12, N'plazma', 4)
SET IDENTITY_INSERT [dbo].[altkategoriler] OFF
SET IDENTITY_INSERT [dbo].[favoriler] ON 

INSERT [dbo].[favoriler] ([favno], [uyeid], [urunid]) VALUES (23, 18, 15)
INSERT [dbo].[favoriler] ([favno], [uyeid], [urunid]) VALUES (24, 18, 36)
INSERT [dbo].[favoriler] ([favno], [uyeid], [urunid]) VALUES (25, 18, 7)
INSERT [dbo].[favoriler] ([favno], [uyeid], [urunid]) VALUES (26, 18, 66)
SET IDENTITY_INSERT [dbo].[favoriler] OFF
SET IDENTITY_INSERT [dbo].[kategoriler] ON 

INSERT [dbo].[kategoriler] ([kateno], [kateadi]) VALUES (1, N'Anakart')
INSERT [dbo].[kategoriler] ([kateno], [kateadi]) VALUES (2, N'ram')
INSERT [dbo].[kategoriler] ([kateno], [kateadi]) VALUES (3, N'hd')
INSERT [dbo].[kategoriler] ([kateno], [kateadi]) VALUES (4, N'monitör')
INSERT [dbo].[kategoriler] ([kateno], [kateadi]) VALUES (5, N'ses kartı')
INSERT [dbo].[kategoriler] ([kateno], [kateadi]) VALUES (6, N'web cam')
INSERT [dbo].[kategoriler] ([kateno], [kateadi]) VALUES (7, N'hoparlör')
INSERT [dbo].[kategoriler] ([kateno], [kateadi]) VALUES (8, N'dv-cd yazici')
INSERT [dbo].[kategoriler] ([kateno], [kateadi]) VALUES (9, N'mouse')
SET IDENTITY_INSERT [dbo].[kategoriler] OFF
SET IDENTITY_INSERT [dbo].[meslek] ON 

INSERT [dbo].[meslek] ([meslekid], [meslekad]) VALUES (1, N'doktor')
INSERT [dbo].[meslek] ([meslekid], [meslekad]) VALUES (2, N'avukat')
INSERT [dbo].[meslek] ([meslekid], [meslekad]) VALUES (3, N'ogretmen')
INSERT [dbo].[meslek] ([meslekid], [meslekad]) VALUES (4, N'emekli')
INSERT [dbo].[meslek] ([meslekid], [meslekad]) VALUES (5, N'işçi')
INSERT [dbo].[meslek] ([meslekid], [meslekad]) VALUES (6, N'ogrenci')
INSERT [dbo].[meslek] ([meslekid], [meslekad]) VALUES (7, N'işsiz')
SET IDENTITY_INSERT [dbo].[meslek] OFF
INSERT [dbo].[sehirler] ([plaka], [sehiradi]) VALUES (1, N'Adana')
INSERT [dbo].[sehirler] ([plaka], [sehiradi]) VALUES (3, N'Afyon')
INSERT [dbo].[sehirler] ([plaka], [sehiradi]) VALUES (4, N'Ağrı')
INSERT [dbo].[sehirler] ([plaka], [sehiradi]) VALUES (6, N'ankara')
INSERT [dbo].[sehirler] ([plaka], [sehiradi]) VALUES (7, N'antalya')
INSERT [dbo].[sehirler] ([plaka], [sehiradi]) VALUES (10, N'Balıkesir')
INSERT [dbo].[sehirler] ([plaka], [sehiradi]) VALUES (11, N'bilecik')
INSERT [dbo].[sehirler] ([plaka], [sehiradi]) VALUES (16, N'BURSA')
INSERT [dbo].[sehirler] ([plaka], [sehiradi]) VALUES (23, N'Elazığ')
INSERT [dbo].[sehirler] ([plaka], [sehiradi]) VALUES (25, N'erzurum')
INSERT [dbo].[sehirler] ([plaka], [sehiradi]) VALUES (26, N'Eskişehir')
INSERT [dbo].[sehirler] ([plaka], [sehiradi]) VALUES (27, N'ANTEP')
INSERT [dbo].[sehirler] ([plaka], [sehiradi]) VALUES (34, N'İstanbul')
INSERT [dbo].[sehirler] ([plaka], [sehiradi]) VALUES (35, N'izmir')
INSERT [dbo].[sehirler] ([plaka], [sehiradi]) VALUES (53, N'Rize')
INSERT [dbo].[sehirler] ([plaka], [sehiradi]) VALUES (61, N'Trabzon')
INSERT [dbo].[sehirler] ([plaka], [sehiradi]) VALUES (63, N'mardin')
INSERT [dbo].[sehirler] ([plaka], [sehiradi]) VALUES (67, N'zonguldak')
INSERT [dbo].[sehirler] ([plaka], [sehiradi]) VALUES (77, N'yalova')
SET IDENTITY_INSERT [dbo].[siparisler] ON 

INSERT [dbo].[siparisler] ([uyeid], [urunid], [adet], [sip_tarihi], [sipno], [kayitno]) VALUES (20, 43, 1, CAST(N'2010-05-22 00:00:00' AS SmallDateTime), 1, 1)
INSERT [dbo].[siparisler] ([uyeid], [urunid], [adet], [sip_tarihi], [sipno], [kayitno]) VALUES (20, 15, 2, CAST(N'2010-05-22 00:00:00' AS SmallDateTime), 1, 2)
INSERT [dbo].[siparisler] ([uyeid], [urunid], [adet], [sip_tarihi], [sipno], [kayitno]) VALUES (22, 43, 1, CAST(N'2010-05-28 00:00:00' AS SmallDateTime), 2, 3)
INSERT [dbo].[siparisler] ([uyeid], [urunid], [adet], [sip_tarihi], [sipno], [kayitno]) VALUES (22, 15, 1, CAST(N'2010-05-28 00:00:00' AS SmallDateTime), 2, 4)
INSERT [dbo].[siparisler] ([uyeid], [urunid], [adet], [sip_tarihi], [sipno], [kayitno]) VALUES (22, 20, 1, CAST(N'2010-05-28 00:00:00' AS SmallDateTime), 2, 5)
INSERT [dbo].[siparisler] ([uyeid], [urunid], [adet], [sip_tarihi], [sipno], [kayitno]) VALUES (30, 43, 1, CAST(N'2010-05-28 00:00:00' AS SmallDateTime), 3, 6)
INSERT [dbo].[siparisler] ([uyeid], [urunid], [adet], [sip_tarihi], [sipno], [kayitno]) VALUES (30, 22, 3, CAST(N'2010-05-28 00:00:00' AS SmallDateTime), 3, 7)
INSERT [dbo].[siparisler] ([uyeid], [urunid], [adet], [sip_tarihi], [sipno], [kayitno]) VALUES (20, 43, 8, CAST(N'2010-05-29 00:00:00' AS SmallDateTime), 4, 8)
INSERT [dbo].[siparisler] ([uyeid], [urunid], [adet], [sip_tarihi], [sipno], [kayitno]) VALUES (20, 15, 2, CAST(N'2010-05-29 00:00:00' AS SmallDateTime), 4, 9)
INSERT [dbo].[siparisler] ([uyeid], [urunid], [adet], [sip_tarihi], [sipno], [kayitno]) VALUES (20, 12, 3, CAST(N'2010-05-29 00:00:00' AS SmallDateTime), 5, 10)
INSERT [dbo].[siparisler] ([uyeid], [urunid], [adet], [sip_tarihi], [sipno], [kayitno]) VALUES (20, 44, 2, CAST(N'2011-01-18 00:00:00' AS SmallDateTime), 7, 14)
INSERT [dbo].[siparisler] ([uyeid], [urunid], [adet], [sip_tarihi], [sipno], [kayitno]) VALUES (20, 29, 8, CAST(N'2011-01-18 00:00:00' AS SmallDateTime), 7, 15)
INSERT [dbo].[siparisler] ([uyeid], [urunid], [adet], [sip_tarihi], [sipno], [kayitno]) VALUES (18, 21, 1, CAST(N'2014-06-09 00:00:00' AS SmallDateTime), 8, 16)
INSERT [dbo].[siparisler] ([uyeid], [urunid], [adet], [sip_tarihi], [sipno], [kayitno]) VALUES (18, 21, 3, CAST(N'2014-06-09 00:00:00' AS SmallDateTime), 9, 17)
INSERT [dbo].[siparisler] ([uyeid], [urunid], [adet], [sip_tarihi], [sipno], [kayitno]) VALUES (18, 19, 1, CAST(N'2014-06-09 00:00:00' AS SmallDateTime), 9, 18)
INSERT [dbo].[siparisler] ([uyeid], [urunid], [adet], [sip_tarihi], [sipno], [kayitno]) VALUES (18, 21, 1, CAST(N'2014-06-09 00:00:00' AS SmallDateTime), 10, 19)
INSERT [dbo].[siparisler] ([uyeid], [urunid], [adet], [sip_tarihi], [sipno], [kayitno]) VALUES (18, 19, 2, CAST(N'2014-06-09 00:00:00' AS SmallDateTime), 10, 20)
INSERT [dbo].[siparisler] ([uyeid], [urunid], [adet], [sip_tarihi], [sipno], [kayitno]) VALUES (18, 51, 1, CAST(N'2014-06-09 00:00:00' AS SmallDateTime), 10, 21)
INSERT [dbo].[siparisler] ([uyeid], [urunid], [adet], [sip_tarihi], [sipno], [kayitno]) VALUES (18, 21, 1, CAST(N'2014-06-14 00:00:00' AS SmallDateTime), 11, 22)
INSERT [dbo].[siparisler] ([uyeid], [urunid], [adet], [sip_tarihi], [sipno], [kayitno]) VALUES (18, 51, 1, CAST(N'2014-06-14 00:00:00' AS SmallDateTime), 11, 23)
INSERT [dbo].[siparisler] ([uyeid], [urunid], [adet], [sip_tarihi], [sipno], [kayitno]) VALUES (18, 9, 1, CAST(N'2014-06-14 00:00:00' AS SmallDateTime), 11, 24)
INSERT [dbo].[siparisler] ([uyeid], [urunid], [adet], [sip_tarihi], [sipno], [kayitno]) VALUES (70, 51, 2, CAST(N'2016-12-31 00:00:00' AS SmallDateTime), 12, 25)
INSERT [dbo].[siparisler] ([uyeid], [urunid], [adet], [sip_tarihi], [sipno], [kayitno]) VALUES (70, 49, 1, CAST(N'2016-12-31 00:00:00' AS SmallDateTime), 12, 26)
INSERT [dbo].[siparisler] ([uyeid], [urunid], [adet], [sip_tarihi], [sipno], [kayitno]) VALUES (30, 37, 1, CAST(N'2010-05-28 00:00:00' AS SmallDateTime), 3, 27)
INSERT [dbo].[siparisler] ([uyeid], [urunid], [adet], [sip_tarihi], [sipno], [kayitno]) VALUES (18, 21, 1, CAST(N'2017-01-26 00:00:00' AS SmallDateTime), 13, 28)
INSERT [dbo].[siparisler] ([uyeid], [urunid], [adet], [sip_tarihi], [sipno], [kayitno]) VALUES (18, 52, 3, CAST(N'2017-01-26 00:00:00' AS SmallDateTime), 13, 29)
INSERT [dbo].[siparisler] ([uyeid], [urunid], [adet], [sip_tarihi], [sipno], [kayitno]) VALUES (18, 12, 2, CAST(N'2017-01-26 00:00:00' AS SmallDateTime), 14, 30)
INSERT [dbo].[siparisler] ([uyeid], [urunid], [adet], [sip_tarihi], [sipno], [kayitno]) VALUES (18, 20, 1, CAST(N'2017-01-26 00:00:00' AS SmallDateTime), 14, 31)
INSERT [dbo].[siparisler] ([uyeid], [urunid], [adet], [sip_tarihi], [sipno], [kayitno]) VALUES (18, 52, 1, CAST(N'2017-01-26 00:00:00' AS SmallDateTime), 14, 32)
INSERT [dbo].[siparisler] ([uyeid], [urunid], [adet], [sip_tarihi], [sipno], [kayitno]) VALUES (18, 19, 5, CAST(N'2017-01-27 00:00:00' AS SmallDateTime), 15, 34)
INSERT [dbo].[siparisler] ([uyeid], [urunid], [adet], [sip_tarihi], [sipno], [kayitno]) VALUES (18, 21, 1, CAST(N'2017-01-27 00:00:00' AS SmallDateTime), 16, 35)
INSERT [dbo].[siparisler] ([uyeid], [urunid], [adet], [sip_tarihi], [sipno], [kayitno]) VALUES (18, 51, 2, CAST(N'2017-01-27 00:00:00' AS SmallDateTime), 16, 36)
INSERT [dbo].[siparisler] ([uyeid], [urunid], [adet], [sip_tarihi], [sipno], [kayitno]) VALUES (18, 19, 1, CAST(N'2017-07-01 00:00:00' AS SmallDateTime), 17, 37)
INSERT [dbo].[siparisler] ([uyeid], [urunid], [adet], [sip_tarihi], [sipno], [kayitno]) VALUES (18, 52, 1, CAST(N'2017-07-01 00:00:00' AS SmallDateTime), 17, 38)
INSERT [dbo].[siparisler] ([uyeid], [urunid], [adet], [sip_tarihi], [sipno], [kayitno]) VALUES (30, 14, 1, CAST(N'2017-07-07 00:00:00' AS SmallDateTime), 18, 39)
INSERT [dbo].[siparisler] ([uyeid], [urunid], [adet], [sip_tarihi], [sipno], [kayitno]) VALUES (30, 12, 1, CAST(N'2017-07-07 00:00:00' AS SmallDateTime), 18, 40)
INSERT [dbo].[siparisler] ([uyeid], [urunid], [adet], [sip_tarihi], [sipno], [kayitno]) VALUES (18, 15, 3, CAST(N'2018-01-22 00:00:00' AS SmallDateTime), 19, 41)
INSERT [dbo].[siparisler] ([uyeid], [urunid], [adet], [sip_tarihi], [sipno], [kayitno]) VALUES (18, 43, 1, CAST(N'2018-01-22 00:00:00' AS SmallDateTime), 19, 42)
INSERT [dbo].[siparisler] ([uyeid], [urunid], [adet], [sip_tarihi], [sipno], [kayitno]) VALUES (18, 13, 1, CAST(N'2018-01-23 00:00:00' AS SmallDateTime), 20, 44)
INSERT [dbo].[siparisler] ([uyeid], [urunid], [adet], [sip_tarihi], [sipno], [kayitno]) VALUES (18, 37, 4, CAST(N'2018-06-18 00:00:00' AS SmallDateTime), 21, 45)
INSERT [dbo].[siparisler] ([uyeid], [urunid], [adet], [sip_tarihi], [sipno], [kayitno]) VALUES (18, 29, 1, CAST(N'2018-06-18 00:00:00' AS SmallDateTime), 21, 46)
INSERT [dbo].[siparisler] ([uyeid], [urunid], [adet], [sip_tarihi], [sipno], [kayitno]) VALUES (18, 12, 1, CAST(N'2018-06-19 00:00:00' AS SmallDateTime), 22, 47)
INSERT [dbo].[siparisler] ([uyeid], [urunid], [adet], [sip_tarihi], [sipno], [kayitno]) VALUES (18, 19, 2, CAST(N'2018-06-19 00:00:00' AS SmallDateTime), 23, 49)
INSERT [dbo].[siparisler] ([uyeid], [urunid], [adet], [sip_tarihi], [sipno], [kayitno]) VALUES (18, 14, 1, CAST(N'2018-12-29 00:00:00' AS SmallDateTime), 24, 50)
INSERT [dbo].[siparisler] ([uyeid], [urunid], [adet], [sip_tarihi], [sipno], [kayitno]) VALUES (18, 9, 2, CAST(N'2018-12-29 00:00:00' AS SmallDateTime), 25, 51)
INSERT [dbo].[siparisler] ([uyeid], [urunid], [adet], [sip_tarihi], [sipno], [kayitno]) VALUES (18, 16, 3, CAST(N'2018-12-29 00:00:00' AS SmallDateTime), 25, 52)
INSERT [dbo].[siparisler] ([uyeid], [urunid], [adet], [sip_tarihi], [sipno], [kayitno]) VALUES (18, 14, 1, CAST(N'2019-01-05 00:00:00' AS SmallDateTime), 26, 53)
INSERT [dbo].[siparisler] ([uyeid], [urunid], [adet], [sip_tarihi], [sipno], [kayitno]) VALUES (18, 51, 2, CAST(N'2019-01-05 00:00:00' AS SmallDateTime), 27, 54)
INSERT [dbo].[siparisler] ([uyeid], [urunid], [adet], [sip_tarihi], [sipno], [kayitno]) VALUES (18, 53, 1, CAST(N'2019-01-05 00:00:00' AS SmallDateTime), 27, 56)
INSERT [dbo].[siparisler] ([uyeid], [urunid], [adet], [sip_tarihi], [sipno], [kayitno]) VALUES (85, 50, 1, CAST(N'2019-05-09 00:00:00' AS SmallDateTime), 28, 57)
INSERT [dbo].[siparisler] ([uyeid], [urunid], [adet], [sip_tarihi], [sipno], [kayitno]) VALUES (18, 66, 1, CAST(N'2019-05-30 00:00:00' AS SmallDateTime), 29, 59)
INSERT [dbo].[siparisler] ([uyeid], [urunid], [adet], [sip_tarihi], [sipno], [kayitno]) VALUES (18, 51, 1, CAST(N'2020-01-02 00:00:00' AS SmallDateTime), 30, 60)
INSERT [dbo].[siparisler] ([uyeid], [urunid], [adet], [sip_tarihi], [sipno], [kayitno]) VALUES (18, 68, 2, CAST(N'2020-01-02 00:00:00' AS SmallDateTime), 30, 61)
INSERT [dbo].[siparisler] ([uyeid], [urunid], [adet], [sip_tarihi], [sipno], [kayitno]) VALUES (18, 13, 3, CAST(N'2020-01-02 00:00:00' AS SmallDateTime), 30, 62)
INSERT [dbo].[siparisler] ([uyeid], [urunid], [adet], [sip_tarihi], [sipno], [kayitno]) VALUES (18, 51, 1, CAST(N'2020-02-01 10:23:00' AS SmallDateTime), 31, 63)
INSERT [dbo].[siparisler] ([uyeid], [urunid], [adet], [sip_tarihi], [sipno], [kayitno]) VALUES (18, 51, 1, CAST(N'2020-02-01 11:39:00' AS SmallDateTime), 32, 64)
INSERT [dbo].[siparisler] ([uyeid], [urunid], [adet], [sip_tarihi], [sipno], [kayitno]) VALUES (18, 48, 3, CAST(N'2020-02-01 11:39:00' AS SmallDateTime), 32, 65)
INSERT [dbo].[siparisler] ([uyeid], [urunid], [adet], [sip_tarihi], [sipno], [kayitno]) VALUES (18, 51, 1, CAST(N'2020-02-06 10:14:00' AS SmallDateTime), 33, 66)
INSERT [dbo].[siparisler] ([uyeid], [urunid], [adet], [sip_tarihi], [sipno], [kayitno]) VALUES (18, 58, 1, CAST(N'2020-02-06 10:14:00' AS SmallDateTime), 33, 67)
INSERT [dbo].[siparisler] ([uyeid], [urunid], [adet], [sip_tarihi], [sipno], [kayitno]) VALUES (22, 22, 2, CAST(N'2021-02-12 00:00:00' AS SmallDateTime), 34, 69)
INSERT [dbo].[siparisler] ([uyeid], [urunid], [adet], [sip_tarihi], [sipno], [kayitno]) VALUES (22, 19, 3, CAST(N'2021-02-12 00:00:00' AS SmallDateTime), 34, 70)
INSERT [dbo].[siparisler] ([uyeid], [urunid], [adet], [sip_tarihi], [sipno], [kayitno]) VALUES (22, 67, 1, CAST(N'2021-02-12 00:00:00' AS SmallDateTime), 34, 71)
INSERT [dbo].[siparisler] ([uyeid], [urunid], [adet], [sip_tarihi], [sipno], [kayitno]) VALUES (18, 42, 1, CAST(N'2021-02-12 00:00:00' AS SmallDateTime), 35, 72)
INSERT [dbo].[siparisler] ([uyeid], [urunid], [adet], [sip_tarihi], [sipno], [kayitno]) VALUES (18, 53, 1, CAST(N'2021-02-12 00:00:00' AS SmallDateTime), 35, 73)
INSERT [dbo].[siparisler] ([uyeid], [urunid], [adet], [sip_tarihi], [sipno], [kayitno]) VALUES (18, 16, 1, CAST(N'2021-02-12 00:00:00' AS SmallDateTime), 35, 74)
INSERT [dbo].[siparisler] ([uyeid], [urunid], [adet], [sip_tarihi], [sipno], [kayitno]) VALUES (18, 42, 1, CAST(N'2021-02-12 11:28:00' AS SmallDateTime), 36, 75)
INSERT [dbo].[siparisler] ([uyeid], [urunid], [adet], [sip_tarihi], [sipno], [kayitno]) VALUES (18, 22, 1, CAST(N'2021-02-12 11:28:00' AS SmallDateTime), 36, 76)
INSERT [dbo].[siparisler] ([uyeid], [urunid], [adet], [sip_tarihi], [sipno], [kayitno]) VALUES (18, 42, 1, CAST(N'2021-02-18 11:26:00' AS SmallDateTime), 37, 77)
INSERT [dbo].[siparisler] ([uyeid], [urunid], [adet], [sip_tarihi], [sipno], [kayitno]) VALUES (18, 68, 1, CAST(N'2021-02-18 11:26:00' AS SmallDateTime), 37, 78)
SET IDENTITY_INSERT [dbo].[siparisler] OFF
INSERT [dbo].[toplam_kazan] ([sipno], [toplamfiy], [sip_tarihi]) VALUES (1, 107.05, CAST(N'2010-05-22 00:00:00' AS SmallDateTime))
INSERT [dbo].[toplam_kazan] ([sipno], [toplamfiy], [sip_tarihi]) VALUES (2, 107.05, CAST(N'2010-05-28 00:00:00' AS SmallDateTime))
INSERT [dbo].[toplam_kazan] ([sipno], [toplamfiy], [sip_tarihi]) VALUES (3, 235.45, CAST(N'2010-05-28 00:00:00' AS SmallDateTime))
INSERT [dbo].[toplam_kazan] ([sipno], [toplamfiy], [sip_tarihi]) VALUES (4, 215.2, CAST(N'2010-05-29 00:00:00' AS SmallDateTime))
INSERT [dbo].[toplam_kazan] ([sipno], [toplamfiy], [sip_tarihi]) VALUES (5, 300, CAST(N'2010-05-29 00:00:00' AS SmallDateTime))
INSERT [dbo].[toplam_kazan] ([sipno], [toplamfiy], [sip_tarihi]) VALUES (6, 946, CAST(N'2010-07-19 00:00:00' AS SmallDateTime))
INSERT [dbo].[toplam_kazan] ([sipno], [toplamfiy], [sip_tarihi]) VALUES (7, 913.55, CAST(N'2011-01-18 00:00:00' AS SmallDateTime))
SET IDENTITY_INSERT [dbo].[urunler] ON 

INSERT [dbo].[urunler] ([urunid], [urunadi], [fiyat], [aciklama], [resim], [kateno]) VALUES (7, N'gerdirmeli raf sistemi', 70, N'cxvxdv', N'7.jpg', 9)
INSERT [dbo].[urunler] ([urunid], [urunadi], [fiyat], [aciklama], [resim], [kateno]) VALUES (8, N'araba', 110, N'aa', N'Malz Dolabı.jpg', 3)
INSERT [dbo].[urunler] ([urunid], [urunadi], [fiyat], [aciklama], [resim], [kateno]) VALUES (9, N'taksi', 110, N'aa', N'PersonelDolabiDetay.jpg', 3)
INSERT [dbo].[urunler] ([urunid], [urunadi], [fiyat], [aciklama], [resim], [kateno]) VALUES (12, N'jeep', 110, N'3', N'PersonelDolabi1Gozlu.jpg', 3)
INSERT [dbo].[urunler] ([urunid], [urunadi], [fiyat], [aciklama], [resim], [kateno]) VALUES (13, N'bibiiip', 110, N'3', N'ali.jpg', 5)
INSERT [dbo].[urunler] ([urunid], [urunadi], [fiyat], [aciklama], [resim], [kateno]) VALUES (14, N'tuncay', 88, N'dsfdsfsdfdsfsdfdsfsdfsdf', N'Tek Tak Arb1.jpg', 3)
INSERT [dbo].[urunler] ([urunid], [urunadi], [fiyat], [aciklama], [resim], [kateno]) VALUES (15, N'metin', 50.38, N'erewrwer
ewrewr', N'Tek Tak Arb2.jpg', 4)
INSERT [dbo].[urunler] ([urunid], [urunadi], [fiyat], [aciklama], [resim], [kateno]) VALUES (16, N'sdd', 61.600000000000009, N'33', N'DosyaDolabiKucuk.jpg', 4)
INSERT [dbo].[urunler] ([urunid], [urunadi], [fiyat], [aciklama], [resim], [kateno]) VALUES (19, N'a4 tech web cam', 25.3, N'çok şş bşr ürün', N'CALIS MASA PA.jpg', 3)
INSERT [dbo].[urunler] ([urunid], [urunadi], [fiyat], [aciklama], [resim], [kateno]) VALUES (20, N'tyy', 50.38, N'', N'GerdirmeliRafSistemi.jpg', 3)
INSERT [dbo].[urunler] ([urunid], [urunadi], [fiyat], [aciklama], [resim], [kateno]) VALUES (21, N'kitap', 110, N'safew', N'GerdirmeliRafSistemi.jpg', 3)
INSERT [dbo].[urunler] ([urunid], [urunadi], [fiyat], [aciklama], [resim], [kateno]) VALUES (22, N'6443', 44, N'safew', N'PersonelDolabi1Gozlu.jpg', 3)
INSERT [dbo].[urunler] ([urunid], [urunadi], [fiyat], [aciklama], [resim], [kateno]) VALUES (24, N'inca mouse', 49.500000000000007, N'', N'adsız.JPG', 2)
INSERT [dbo].[urunler] ([urunid], [urunadi], [fiyat], [aciklama], [resim], [kateno]) VALUES (28, N'tyy', 24.200000000000003, N'', N'GerdirmeliRafSistemi.jpg', 5)
INSERT [dbo].[urunler] ([urunid], [urunadi], [fiyat], [aciklama], [resim], [kateno]) VALUES (29, N'silgi', 110, N'safew', N'GerdirmeliRafSistemi.jpg', 3)
INSERT [dbo].[urunler] ([urunid], [urunadi], [fiyat], [aciklama], [resim], [kateno]) VALUES (30, N'6443', 50.38, N'safew', N'PersonelDolabi1Gozlu.jpg', 2)
INSERT [dbo].[urunler] ([urunid], [urunadi], [fiyat], [aciklama], [resim], [kateno]) VALUES (31, N'tyy', 50.38, N'', N'GerdirmeliRafSistemi.jpg', 3)
INSERT [dbo].[urunler] ([urunid], [urunadi], [fiyat], [aciklama], [resim], [kateno]) VALUES (32, N'silgi', 110, N'safew', N'img2.jpg', 2)
INSERT [dbo].[urunler] ([urunid], [urunadi], [fiyat], [aciklama], [resim], [kateno]) VALUES (33, N'6443', 37.400000000000006, N'safew', N'PersonelDolabi1Gozlu.jpg', 2)
INSERT [dbo].[urunler] ([urunid], [urunadi], [fiyat], [aciklama], [resim], [kateno]) VALUES (34, N'ev', 50.38, N'', N'sat2.jpg', 3)
INSERT [dbo].[urunler] ([urunid], [urunadi], [fiyat], [aciklama], [resim], [kateno]) VALUES (35, N'samsung 320 gb hdd', 50.38, N'7200 rpm', N'hd1.jpg', 3)
INSERT [dbo].[urunler] ([urunid], [urunadi], [fiyat], [aciklama], [resim], [kateno]) VALUES (36, N'western dijital 200 gb hdd', 50.38, N'7200 rpm', N'hd2.jpg', 4)
INSERT [dbo].[urunler] ([urunid], [urunadi], [fiyat], [aciklama], [resim], [kateno]) VALUES (37, N'silgi', 110, N'wqewq', N'hd2.jpg', 3)
INSERT [dbo].[urunler] ([urunid], [urunadi], [fiyat], [aciklama], [resim], [kateno]) VALUES (39, N'kalem', 50.38, N'ii bir ürün', N'kal.jpg', 3)
INSERT [dbo].[urunler] ([urunid], [urunadi], [fiyat], [aciklama], [resim], [kateno]) VALUES (41, N'kalem', 23.1, N'ii bir ürün', N'kal.jpg', 5)
INSERT [dbo].[urunler] ([urunid], [urunadi], [fiyat], [aciklama], [resim], [kateno]) VALUES (42, N'', 47.3, N'ii bir ürün', N'PersonelDolabi1Gozlu.jpg', 3)
INSERT [dbo].[urunler] ([urunid], [urunadi], [fiyat], [aciklama], [resim], [kateno]) VALUES (43, N'cicek', 16.995, N'nilufer cicekleri', N'Nilüfer çiçekleri.jpg', 6)
INSERT [dbo].[urunler] ([urunid], [urunadi], [fiyat], [aciklama], [resim], [kateno]) VALUES (44, N'boya', 16.775000000000002, N'bilmiorm ilk kullanıcam', N'1683ya1.jpg', 3)
INSERT [dbo].[urunler] ([urunid], [urunadi], [fiyat], [aciklama], [resim], [kateno]) VALUES (45, N'ceviz', 50.358, N'ii bir ürün', N'cev.gif', 2)
INSERT [dbo].[urunler] ([urunid], [urunadi], [fiyat], [aciklama], [resim], [kateno]) VALUES (48, N'fındık', 107.8, N'ii bir ürün', N'fin.gif', 1)
INSERT [dbo].[urunler] ([urunid], [urunadi], [fiyat], [aciklama], [resim], [kateno]) VALUES (49, N'19mayıs portre', 23.56, N'edwrfdsjhflsdjlfjsldjmflds', N'19Mayis.jpg', 4)
INSERT [dbo].[urunler] ([urunid], [urunadi], [fiyat], [aciklama], [resim], [kateno]) VALUES (50, N'KAHVE fincanı', 22.9, N'bu ii bir ürün', N'allem13.png', 3)
INSERT [dbo].[urunler] ([urunid], [urunadi], [fiyat], [aciklama], [resim], [kateno]) VALUES (51, N'çiçek böcek', 22, N'sadsadas', N'n.jpg', 1)
INSERT [dbo].[urunler] ([urunid], [urunadi], [fiyat], [aciklama], [resim], [kateno]) VALUES (52, N'nissanjuke', 25, N'yok', N'IMG_20161120_163315.jpg', 7)
INSERT [dbo].[urunler] ([urunid], [urunadi], [fiyat], [aciklama], [resim], [kateno]) VALUES (53, N'bişiy olsun', 56, N'dsdsadas', N'Penguins.jpg', 4)
INSERT [dbo].[urunler] ([urunid], [urunadi], [fiyat], [aciklama], [resim], [kateno]) VALUES (56, N'pırasa', 1223, N'dsfsdf', N'Koala.jpg', 3)
INSERT [dbo].[urunler] ([urunid], [urunadi], [fiyat], [aciklama], [resim], [kateno]) VALUES (58, N'asus dvdrom', 150, N'çin malı', N'57.jpg', 8)
INSERT [dbo].[urunler] ([urunid], [urunadi], [fiyat], [aciklama], [resim], [kateno]) VALUES (63, N'asus dvdrom', 60, N'amaha Arius YDP-143 dijital piyano gercek akustik piyano duygusu ve tonlarini arayan piyanistler dogru
tercihtir.', N'59.jpg', 8)
INSERT [dbo].[urunler] ([urunid], [urunadi], [fiyat], [aciklama], [resim], [kateno]) VALUES (64, N'asus dvdrom', 70, N'Yamaha Arius YDP-143 dijital piyano gercek akustik piyano duygusu ve tonlarini arayan piyanistler dogrutercihtir. Derecelendirilmis Cekic Standardi klavyesi (The Graded Hammer Standard - GHS) dogru parmak tekniklerinin oturmasina yardimci olurken akustik piyanoya geciste kolaylik saglamaktadir.Gelistirilmis Pure CF sistemi, Yamaha CFIIIS modeli dahil bircok akustik piyanonun canli, yuksek kalitede seslerini size sunar.192 Nota polifoni degeri sayesinde en karmasIk kompozisyonlari bile hicbir nota kaybi olmadan calabilirken, sustain notalar dogru ve olmasi gerektigi uzunlukta duyulmaktadir.Arius YDP-143 rosewood yada black walnut renk secenekleri ve mobilya gorunumlu govdesi sayesinde bir dijital piyano olarak butun ihtiyaclarinizi karsilarken evinizdeki klasIk piyano goruntusunu de korumaktadir.', N'64.jpg', 8)
INSERT [dbo].[urunler] ([urunid], [urunadi], [fiyat], [aciklama], [resim], [kateno]) VALUES (65, N'asus dvdrom', 70, N'Yamaha Arius YDP-143 dijital piyano gercek akustik piyano duygusu ve tonlarini arayan piyanistler dogru
tercihtir. Derecelendirilmis Cekic Standardi klavyesi (The Graded Hammer Standard - GHS) dogru parmak tekniklerinin oturmasina yardimci olurken akustik piyanoya geciste kolaylik saglamaktadir.Gelistirilmis Pure CF sistemi, Yamaha CFIIIS modeli dahil bircok akustik piyanonun canli, yuksek kalitede seslerini size sunar.192 Nota polifoni degeri sayesinde en karmasIk kompozisyonlari bile hicbir nota kaybi olmadan calabilirken, sustain notalar dogru ve olmasi gerektigi uzunlukta duyulmaktadir.Arius YDP-143 rosewood yada black walnut renk secenekleri ve mobilya gorunumlu govdesi sayesinde bir dijital piyano olarak butun ihtiyaclarinizi karsilarken evinizdeki klasIk piyano goruntusunu de korumaktadir.', N'65.jpg', 8)
INSERT [dbo].[urunler] ([urunid], [urunadi], [fiyat], [aciklama], [resim], [kateno]) VALUES (66, N'testere', 56, N'açıklma', N'66.jpg', 9)
INSERT [dbo].[urunler] ([urunid], [urunadi], [fiyat], [aciklama], [resim], [kateno]) VALUES (67, N'bumblbee', 98, N'sadasd', N'67.jpg', 3)
INSERT [dbo].[urunler] ([urunid], [urunadi], [fiyat], [aciklama], [resim], [kateno]) VALUES (68, N'ıslak mendil', 8, N'ph asddADSA', N'68.jpg', 5)
INSERT [dbo].[urunler] ([urunid], [urunadi], [fiyat], [aciklama], [resim], [kateno]) VALUES (69, N'tivoliaraba', 120000, N'ASAsASasAS', N'69.jpg', 5)
SET IDENTITY_INSERT [dbo].[urunler] OFF
SET IDENTITY_INSERT [dbo].[uyeler] ON 

INSERT [dbo].[uyeler] ([uyeid], [kuladi], [sifre], [adsoyad], [dogtar], [cinsiyet], [adres], [plaka], [email], [meslekid], [onay]) VALUES (18, N'osman', N'1234567', N'osman tahinli', CAST(N'2017-10-05 00:00:00' AS SmallDateTime), 0, N'van', 67, N'osman@hotmail.com', 5, NULL)
INSERT [dbo].[uyeler] ([uyeid], [kuladi], [sifre], [adsoyad], [dogtar], [cinsiyet], [adres], [plaka], [email], [meslekid], [onay]) VALUES (20, N'metin', N'12345678', N'metin yalçın', CAST(N'1987-03-01 00:00:00' AS SmallDateTime), 0, N'ter', 27, N'met@hotmail.com', 6, NULL)
INSERT [dbo].[uyeler] ([uyeid], [kuladi], [sifre], [adsoyad], [dogtar], [cinsiyet], [adres], [plaka], [email], [meslekid], [onay]) VALUES (21, N'dincer', N'1234567', N'dinçer öxgür', CAST(N'1990-01-01 00:00:00' AS SmallDateTime), 1, N'', 1, N'dincer@hotmail.com', 4, NULL)
INSERT [dbo].[uyeler] ([uyeid], [kuladi], [sifre], [adsoyad], [dogtar], [cinsiyet], [adres], [plaka], [email], [meslekid], [onay]) VALUES (22, N'serpil', N'1234567', N'serpil x', CAST(N'1988-02-12 00:00:00' AS SmallDateTime), 0, N'rewrw', 16, N't@hotmail.com', 4, NULL)
INSERT [dbo].[uyeler] ([uyeid], [kuladi], [sifre], [adsoyad], [dogtar], [cinsiyet], [adres], [plaka], [email], [meslekid], [onay]) VALUES (30, N'feride', N'1234', N'feride çoban', CAST(N'2009-05-11 00:00:00' AS SmallDateTime), 0, N'dd', 16, N'dsd@hotmail.com', 2, NULL)
INSERT [dbo].[uyeler] ([uyeid], [kuladi], [sifre], [adsoyad], [dogtar], [cinsiyet], [adres], [plaka], [email], [meslekid], [onay]) VALUES (38, N'cer12', N'1234567', N'tuncaysalı', CAST(N'1987-09-01 00:00:00' AS SmallDateTime), 1, N'', 1, N'tun@gmail.com', 1, NULL)
INSERT [dbo].[uyeler] ([uyeid], [kuladi], [sifre], [adsoyad], [dogtar], [cinsiyet], [adres], [plaka], [email], [meslekid], [onay]) VALUES (46, N'memet', N'12345678', N'mehmet durak', CAST(N'2001-04-02 00:00:00' AS SmallDateTime), 1, NULL, 16, N'mehmet12@hotmail.com', 2, NULL)
INSERT [dbo].[uyeler] ([uyeid], [kuladi], [sifre], [adsoyad], [dogtar], [cinsiyet], [adres], [plaka], [email], [meslekid], [onay]) VALUES (55, N'mervetasin', N'12345678', N'merve tasin', CAST(N'1998-01-01 00:00:00' AS SmallDateTime), 0, N'', 16, N'mer@hotmail.com', 2, NULL)
INSERT [dbo].[uyeler] ([uyeid], [kuladi], [sifre], [adsoyad], [dogtar], [cinsiyet], [adres], [plaka], [email], [meslekid], [onay]) VALUES (56, N'mirac', N'12345678', N'mirac kara', CAST(N'1999-01-01 00:00:00' AS SmallDateTime), 0, N'dsf', 6, N'mir@yahoo.com', 3, NULL)
INSERT [dbo].[uyeler] ([uyeid], [kuladi], [sifre], [adsoyad], [dogtar], [cinsiyet], [adres], [plaka], [email], [meslekid], [onay]) VALUES (59, N'ahmetdemir3', N'123456', N'ahmet demirel', CAST(N'1997-09-02 00:00:00' AS SmallDateTime), 1, N'', 16, N'ahmet@yaho.com', 6, NULL)
INSERT [dbo].[uyeler] ([uyeid], [kuladi], [sifre], [adsoyad], [dogtar], [cinsiyet], [adres], [plaka], [email], [meslekid], [onay]) VALUES (61, N'aykut89', N'1234567', N'AYKUT VURUŞ', CAST(N'2001-08-09 00:00:00' AS SmallDateTime), 0, N'DFSFS', 16, N'AYKUT@YAhoo.com', 6, NULL)
INSERT [dbo].[uyeler] ([uyeid], [kuladi], [sifre], [adsoyad], [dogtar], [cinsiyet], [adres], [plaka], [email], [meslekid], [onay]) VALUES (67, N'kamil12', N'123456', N'kamil ok', CAST(N'2014-05-24 00:00:00' AS SmallDateTime), 1, N'salla', 27, N'tun@jmail.com', 1, NULL)
INSERT [dbo].[uyeler] ([uyeid], [kuladi], [sifre], [adsoyad], [dogtar], [cinsiyet], [adres], [plaka], [email], [meslekid], [onay]) VALUES (68, N'murat16', N'1234567', N'murat ogan', CAST(N'2014-05-24 00:00:00' AS SmallDateTime), 1, N'dsfdsfsdf', 11, N'mur@jmail.com', 4, NULL)
INSERT [dbo].[uyeler] ([uyeid], [kuladi], [sifre], [adsoyad], [dogtar], [cinsiyet], [adres], [plaka], [email], [meslekid], [onay]) VALUES (70, N'oguzhan', N'123456', N'oguzhan', CAST(N'2016-12-31 00:00:00' AS SmallDateTime), 1, N'dsafdsf', 16, N'oguz@gmail.com', 2, NULL)
INSERT [dbo].[uyeler] ([uyeid], [kuladi], [sifre], [adsoyad], [dogtar], [cinsiyet], [adres], [plaka], [email], [meslekid], [onay]) VALUES (74, N'furkan', N'123456', N'furkan tokuş', CAST(N'2017-12-14 00:00:00' AS SmallDateTime), 0, N'alaşar', 27, N'f@a.com', 4, NULL)
INSERT [dbo].[uyeler] ([uyeid], [kuladi], [sifre], [adsoyad], [dogtar], [cinsiyet], [adres], [plaka], [email], [meslekid], [onay]) VALUES (79, N'ozan', N'124563', N'ozan demir', CAST(N'1987-02-12 00:00:00' AS SmallDateTime), 0, N'yok', 7, N'ozan@gmail.com', 3, NULL)
INSERT [dbo].[uyeler] ([uyeid], [kuladi], [sifre], [adsoyad], [dogtar], [cinsiyet], [adres], [plaka], [email], [meslekid], [onay]) VALUES (85, N'osman2', N'123456', N'yunnd', CAST(N'2001-02-15 00:00:00' AS SmallDateTime), 0, N'dffdsf', 4, N'y@gmaail.com', 4, NULL)
INSERT [dbo].[uyeler] ([uyeid], [kuladi], [sifre], [adsoyad], [dogtar], [cinsiyet], [adres], [plaka], [email], [meslekid], [onay]) VALUES (87, N'cengizhan15', N'12345678', N'cengiz abi', CAST(N'2020-01-25 00:00:00' AS SmallDateTime), 0, N'sdfdsf', 23, N'cengiz@hotmail.com', 4, 0)
INSERT [dbo].[uyeler] ([uyeid], [kuladi], [sifre], [adsoyad], [dogtar], [cinsiyet], [adres], [plaka], [email], [meslekid], [onay]) VALUES (88, N'akın', N'1234567', N'akın abi', CAST(N'2020-01-14 00:00:00' AS SmallDateTime), 0, N'dsf', 34, N'ak@gmail.com', 1, 0)
INSERT [dbo].[uyeler] ([uyeid], [kuladi], [sifre], [adsoyad], [dogtar], [cinsiyet], [adres], [plaka], [email], [meslekid], [onay]) VALUES (89, N'rabia123', N'123456', N'rabia hn', CAST(N'2020-10-07 00:00:00' AS SmallDateTime), 1, N'sadasdas', 16, N'rabia@hotmail.com', 6, 0)
INSERT [dbo].[uyeler] ([uyeid], [kuladi], [sifre], [adsoyad], [dogtar], [cinsiyet], [adres], [plaka], [email], [meslekid], [onay]) VALUES (98, N'rabia1236', N'123456', N'wer', CAST(N'2021-02-24 00:00:00' AS SmallDateTime), 1, N'dsfsd', 16, N'rabia@gmail.com', 1, 0)
SET IDENTITY_INSERT [dbo].[uyeler] OFF
SET ANSI_PADDING ON

GO
/****** Object:  Index [uk_uyeler_email]    Script Date: 28.04.2022 12:19:24 ******/
ALTER TABLE [dbo].[uyeler] ADD  CONSTRAINT [uk_uyeler_email] UNIQUE NONCLUSTERED 
(
	[email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [uk_uyeler_kuladi]    Script Date: 28.04.2022 12:19:24 ******/
ALTER TABLE [dbo].[uyeler] ADD  CONSTRAINT [uk_uyeler_kuladi] UNIQUE NONCLUSTERED 
(
	[kuladi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[altkategoriler]  WITH CHECK ADD  CONSTRAINT [FK_altkategoriler_kategoriler] FOREIGN KEY([anakateno])
REFERENCES [dbo].[kategoriler] ([kateno])
GO
ALTER TABLE [dbo].[altkategoriler] CHECK CONSTRAINT [FK_altkategoriler_kategoriler]
GO
ALTER TABLE [dbo].[favoriler]  WITH CHECK ADD  CONSTRAINT [FK_favoriler_urunler] FOREIGN KEY([urunid])
REFERENCES [dbo].[urunler] ([urunid])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[favoriler] CHECK CONSTRAINT [FK_favoriler_urunler]
GO
ALTER TABLE [dbo].[favoriler]  WITH CHECK ADD  CONSTRAINT [FK_favoriler_uyeler] FOREIGN KEY([uyeid])
REFERENCES [dbo].[uyeler] ([uyeid])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[favoriler] CHECK CONSTRAINT [FK_favoriler_uyeler]
GO
ALTER TABLE [dbo].[siparisler]  WITH CHECK ADD  CONSTRAINT [FK_siparisler_urunler] FOREIGN KEY([urunid])
REFERENCES [dbo].[urunler] ([urunid])
GO
ALTER TABLE [dbo].[siparisler] CHECK CONSTRAINT [FK_siparisler_urunler]
GO
ALTER TABLE [dbo].[siparisler]  WITH CHECK ADD  CONSTRAINT [FK_siparisler_uyeler] FOREIGN KEY([uyeid])
REFERENCES [dbo].[uyeler] ([uyeid])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[siparisler] CHECK CONSTRAINT [FK_siparisler_uyeler]
GO
ALTER TABLE [dbo].[urunler]  WITH CHECK ADD  CONSTRAINT [FK_urunler_kategoriler] FOREIGN KEY([kateno])
REFERENCES [dbo].[kategoriler] ([kateno])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[urunler] CHECK CONSTRAINT [FK_urunler_kategoriler]
GO
ALTER TABLE [dbo].[uyeler]  WITH CHECK ADD  CONSTRAINT [FK_uyeler_meslek1] FOREIGN KEY([meslekid])
REFERENCES [dbo].[meslek] ([meslekid])
GO
ALTER TABLE [dbo].[uyeler] CHECK CONSTRAINT [FK_uyeler_meslek1]
GO
ALTER TABLE [dbo].[uyeler]  WITH CHECK ADD  CONSTRAINT [FK_uyeler_sehirler1] FOREIGN KEY([plaka])
REFERENCES [dbo].[sehirler] ([plaka])
GO
ALTER TABLE [dbo].[uyeler] CHECK CONSTRAINT [FK_uyeler_sehirler1]
GO
ALTER TABLE [dbo].[sehirler]  WITH CHECK ADD  CONSTRAINT [CK_sehirler] CHECK  (([plaka]>(0)))
GO
ALTER TABLE [dbo].[sehirler] CHECK CONSTRAINT [CK_sehirler]
GO
