SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[egyseg](
	[EgysegId] [int] IDENTITY (2000,1) NOT NULL,
	[Nev] [nvarchar](30) NOT NULL
 CONSTRAINT [PK_Egysegek] PRIMARY KEY CLUSTERED 
(
	[EgysegId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tetel](
	[TetelId] [int] IDENTITY(2000,1) NOT NULL,
	[Nev] [nvarchar](30) NOT NULL,
	[EgysegFK] [int] FOREIGN KEY REFERENCES egyseg(EgysegId) NOT NULL,
	[EgysegAr] [int] NOT NULL,
 CONSTRAINT [PK_Tetelek] PRIMARY KEY CLUSTERED 
(
	[TetelId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[vasarlas](
	[VasarlasId] [int] IDENTITY(2000,1) NOT NULL,
	[Datum] [Date] NOT NULL,
	[TetelFK] [int] FOREIGN KEY REFERENCES tetel(TetelId) NOT NULL,
	[Mennyiseg] [int] NOT NULL,
	PRIMARY KEY CLUSTERED 
(
	[VasarlasID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO



INSERT [dbo].[egyseg] ([Nev]) VALUES ('db')
GO

INSERT [dbo].[egyseg] ([Nev]) VALUES ('kg')
GO

INSERT [dbo].[egyseg] ([Nev]) VALUES ('Csomag')
GO

INSERT [dbo].[tetel] ([Nev], [EgysegFK], [EgysegAr]) VALUES ('Videókártya', 2000, 700)
GO
INSERT [dbo].[tetel] ([Nev], [EgysegFK], [EgysegAr]) VALUES ('Konzervbab', 2001, 70000)
GO
INSERT [dbo].[tetel] ([Nev], [EgysegFK], [EgysegAr]) VALUES ('Medvesajt', 2002, 70000)
GO

INSERT [dbo].[vasarlas] ([Datum], [TetelFK], [Mennyiseg]) VALUES ('2022-12-14', 2000, 5)
GO
INSERT [dbo].[vasarlas] ([Datum], [TetelFK], [Mennyiseg]) VALUES ('2022-12-14', 2001, 18)
GO
