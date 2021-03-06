USE [inventory]
GO
/****** Object:  Table [dbo].[products]    Script Date: 3/11/2020 8:38:24 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[products](
	[IDTable] [int] IDENTITY(1,1) NOT NULL,
	[IDProduct] [int] NOT NULL,
	[Product] [varchar](255) NOT NULL,
	[Quantity] [int] NOT NULL,
	[Modified_date] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IDTable] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[products] ON 

INSERT [dbo].[products] ([IDTable], [IDProduct], [Product], [Quantity], [Modified_date]) VALUES (6, 6, N'Product 6', 1500, CAST(N'2015-09-25' AS Date))
INSERT [dbo].[products] ([IDTable], [IDProduct], [Product], [Quantity], [Modified_date]) VALUES (7, 7, N'Product 7', 140, CAST(N'2015-08-04' AS Date))
INSERT [dbo].[products] ([IDTable], [IDProduct], [Product], [Quantity], [Modified_date]) VALUES (8, 8, N'Product 8', 445, CAST(N'2015-07-15' AS Date))
INSERT [dbo].[products] ([IDTable], [IDProduct], [Product], [Quantity], [Modified_date]) VALUES (9, 9, N'Product 9', 698, CAST(N'2015-06-30' AS Date))
INSERT [dbo].[products] ([IDTable], [IDProduct], [Product], [Quantity], [Modified_date]) VALUES (10, 10, N'Product 10', 440, CAST(N'2014-07-07' AS Date))
INSERT [dbo].[products] ([IDTable], [IDProduct], [Product], [Quantity], [Modified_date]) VALUES (11, 11, N'Product 11', 1000, CAST(N'2013-05-04' AS Date))
INSERT [dbo].[products] ([IDTable], [IDProduct], [Product], [Quantity], [Modified_date]) VALUES (13, 12, N'Product 12', 5000, CAST(N'2016-01-02' AS Date))
SET IDENTITY_INSERT [dbo].[products] OFF
GO
/****** Object:  Index [UQ__products__4290D1784AB84CB4]    Script Date: 3/11/2020 8:38:24 a. m. ******/
ALTER TABLE [dbo].[products] ADD UNIQUE NONCLUSTERED 
(
	[IDProduct] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
