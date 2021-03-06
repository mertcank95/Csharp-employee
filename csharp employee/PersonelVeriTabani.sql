USE [PersonelVeriTabani]
GO
/****** Object:  Table [dbo].[tblBolumler]    Script Date: 30.12.2018 17:01:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblBolumler](
	[Bolumid] [int] IDENTITY(1,1) NOT NULL,
	[Bolumad] [varchar](50) NULL,
	[Kontenjan] [int] NULL,
 CONSTRAINT [PK_tblBolumler] PRIMARY KEY CLUSTERED 
(
	[Bolumid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblPersonel]    Script Date: 30.12.2018 17:01:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPersonel](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Ad] [varchar](50) NULL,
	[Soyad] [varchar](50) NULL,
	[Tc] [varchar](11) NULL,
	[SicilNo] [varchar](10) NULL,
	[Yas] [varchar](50) NULL,
	[Pozisyon] [varchar](50) NULL,
	[Bolumid] [int] NULL,
	[Kayit_Durumu] [bit] NOT NULL,
 CONSTRAINT [PK_tblPersonel] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblYonetici]    Script Date: 30.12.2018 17:01:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblYonetici](
	[girid] [int] IDENTITY(1,1) NOT NULL,
	[Kulad] [varchar](50) NULL,
	[Sifre] [varchar](50) NULL,
 CONSTRAINT [PK_tblYonetici] PRIMARY KEY CLUSTERED 
(
	[girid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tblBolumler] ON 

INSERT [dbo].[tblBolumler] ([Bolumid], [Bolumad], [Kontenjan]) VALUES (1, N'Bilgisayar', 9)
INSERT [dbo].[tblBolumler] ([Bolumid], [Bolumad], [Kontenjan]) VALUES (2, N'Bilgi işlem', 14)
INSERT [dbo].[tblBolumler] ([Bolumid], [Bolumad], [Kontenjan]) VALUES (3, N'İnsan Kaynakları', 4)
SET IDENTITY_INSERT [dbo].[tblBolumler] OFF
SET IDENTITY_INSERT [dbo].[tblPersonel] ON 

INSERT [dbo].[tblPersonel] ([id], [Ad], [Soyad], [Tc], [SicilNo], [Yas], [Pozisyon], [Bolumid], [Kayit_Durumu]) VALUES (5, N'seda', N'ercan', N'58', N'12', N'22', N'hepsi', 1, 1)
INSERT [dbo].[tblPersonel] ([id], [Ad], [Soyad], [Tc], [SicilNo], [Yas], [Pozisyon], [Bolumid], [Kayit_Durumu]) VALUES (1007, N'mert', N'kıratlı', N'11', N'02', N'20', N'yönetici', 1, 1)
INSERT [dbo].[tblPersonel] ([id], [Ad], [Soyad], [Tc], [SicilNo], [Yas], [Pozisyon], [Bolumid], [Kayit_Durumu]) VALUES (1008, N'zahit', N'nuriler', N'1234', N'1', N'20', N'çaycı', 3, 0)
INSERT [dbo].[tblPersonel] ([id], [Ad], [Soyad], [Tc], [SicilNo], [Yas], [Pozisyon], [Bolumid], [Kayit_Durumu]) VALUES (1009, N'CC', N'AA', N'231', N'03', N'35', N'dsa', 2, 1)
INSERT [dbo].[tblPersonel] ([id], [Ad], [Soyad], [Tc], [SicilNo], [Yas], [Pozisyon], [Bolumid], [Kayit_Durumu]) VALUES (1011, N'Berkay', N'Çerci', N'555', N'123', N'22', N'Çaycı', 3, 1)
INSERT [dbo].[tblPersonel] ([id], [Ad], [Soyad], [Tc], [SicilNo], [Yas], [Pozisyon], [Bolumid], [Kayit_Durumu]) VALUES (1012, N'Aysa', N'kalay', N'987', N'08', N'22', N'temizlik', 3, 0)
INSERT [dbo].[tblPersonel] ([id], [Ad], [Soyad], [Tc], [SicilNo], [Yas], [Pozisyon], [Bolumid], [Kayit_Durumu]) VALUES (1013, N'AAAAA', N'BBBBB', N'252', N'09', N'38', N'Yazılımcı', 2, 0)
INSERT [dbo].[tblPersonel] ([id], [Ad], [Soyad], [Tc], [SicilNo], [Yas], [Pozisyon], [Bolumid], [Kayit_Durumu]) VALUES (1014, N'Zahit', N'Nuriler', N'7578', N'6598', N'22', N'Üye', 2, 0)
INSERT [dbo].[tblPersonel] ([id], [Ad], [Soyad], [Tc], [SicilNo], [Yas], [Pozisyon], [Bolumid], [Kayit_Durumu]) VALUES (2014, N'DDDD', N'XXXX', N'483', N'789', N'40', N'Üye', 1, 0)
INSERT [dbo].[tblPersonel] ([id], [Ad], [Soyad], [Tc], [SicilNo], [Yas], [Pozisyon], [Bolumid], [Kayit_Durumu]) VALUES (2015, N'dasd', N'qwer', N'8564', N'43', N'28', N'Muhasebe', 1, 1)
INSERT [dbo].[tblPersonel] ([id], [Ad], [Soyad], [Tc], [SicilNo], [Yas], [Pozisyon], [Bolumid], [Kayit_Durumu]) VALUES (2016, N'QQQ', N'WWW', N'9874', N'99', N'38', N'Üye', 2, 1)
INSERT [dbo].[tblPersonel] ([id], [Ad], [Soyad], [Tc], [SicilNo], [Yas], [Pozisyon], [Bolumid], [Kayit_Durumu]) VALUES (3016, N'chang', N'cong', N'987789', N'101', N'33', N'satış', 3, 1)
SET IDENTITY_INSERT [dbo].[tblPersonel] OFF
SET IDENTITY_INSERT [dbo].[tblYonetici] ON 

INSERT [dbo].[tblYonetici] ([girid], [Kulad], [Sifre]) VALUES (1, N'admin', N'123')
INSERT [dbo].[tblYonetici] ([girid], [Kulad], [Sifre]) VALUES (2, N'mert', N'321')
SET IDENTITY_INSERT [dbo].[tblYonetici] OFF
ALTER TABLE [dbo].[tblPersonel] ADD  CONSTRAINT [DF_tblPersonel_Kayit_Durumu]  DEFAULT ((1)) FOR [Kayit_Durumu]
GO
ALTER TABLE [dbo].[tblPersonel]  WITH CHECK ADD  CONSTRAINT [FK_tblPersonel_tblBolumler] FOREIGN KEY([Bolumid])
REFERENCES [dbo].[tblBolumler] ([Bolumid])
GO
ALTER TABLE [dbo].[tblPersonel] CHECK CONSTRAINT [FK_tblPersonel_tblBolumler]
GO
/****** Object:  StoredProcedure [dbo].[spBolumListe]    Script Date: 30.12.2018 17:01:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[spBolumListe]
 as

 select b.Bolumad,b.Bolumid,b.Kontenjan from tblBolumler b
GO
/****** Object:  StoredProcedure [dbo].[spKulGiris]    Script Date: 30.12.2018 17:01:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[spKulGiris]


@Kulad varchar(50),
@Sifre varchar(50)

as
select * from tblYonetici y where y.Kulad=@Kulad and y.Sifre=@Sifre
GO
/****** Object:  StoredProcedure [dbo].[spPersonelAra]    Script Date: 30.12.2018 17:01:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spPersonelAra]
@SicilNo varchar(10)
as
select * from tblPersonel where SicilNo=@SicilNo
GO
/****** Object:  StoredProcedure [dbo].[spPersonelEkle]    Script Date: 30.12.2018 17:01:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[spPersonelEkle]

@Ad varchar(50),
@Soyad varchar(50),
@Tc varchar(50),
@sicilNo varchar(50),
@Yas varchar(50),
@Pozisyon varchar(50),
@Bolumid int


as
insert into tblPersonel(Ad,Soyad,Tc,SicilNo,Yas,Pozisyon,Bolumid) values (@Ad,@Soyad,@Tc,@sicilNo,@Yas,@Pozisyon,@Bolumid)
GO
/****** Object:  StoredProcedure [dbo].[spPersonelGuncelle]    Script Date: 30.12.2018 17:01:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spPersonelGuncelle]
@id int,
@Ad varchar(50),
@Soyad varchar(50),
@Tc varchar(50),
@sicilNo varchar(50),
@Yas varchar(50),
@Pozisyon varchar(50),
@Bolumid int


as
update  tblPersonel set Ad=@Ad,Soyad=@Soyad,Tc=@Tc,SicilNo=@sicilNo,Yas=@Yas,Pozisyon=@Pozisyon,Bolumid=@Bolumid where id=@id
GO
/****** Object:  StoredProcedure [dbo].[spPersonelSil]    Script Date: 30.12.2018 17:01:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spPersonelSil]
@id int



as

delete tblPersonel where id=@id
GO
/****** Object:  StoredProcedure [dbo].[spPersonelTable]    Script Date: 30.12.2018 17:01:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE proc [dbo].[spPersonelTable]

as

select p.id,p.Ad,p.Soyad,p.Tc,p.SicilNo,p.Yas,p.Pozisyon,p.Bolumid from
tblPersonel p where Kayit_Durumu=1



GO
