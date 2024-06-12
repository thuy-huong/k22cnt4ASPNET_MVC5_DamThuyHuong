USE [DthK22CNT4Lesson07Db]
GO
/****** Object:  Table [dbo].[dthKhoa]    Script Date: 6/12/2024 3:56:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dthKhoa](
	[DthMaKhoa] [nchar](10) NOT NULL,
	[DthTenKhoa] [varchar](50) NULL,
	[DthTrangThai] [bit] NULL,
 CONSTRAINT [PK_dthKhoa] PRIMARY KEY CLUSTERED 
(
	[DthMaKhoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[dthSinhVien]    Script Date: 6/12/2024 3:56:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dthSinhVien](
	[DthMaSV] [nvarchar](50) NOT NULL,
	[DthHoSV] [nvarchar](50) NULL,
	[DthTenSV] [nvarchar](50) NULL,
	[DthNgaySinh] [date] NULL,
	[DthPhai] [bit] NULL,
	[DthPhone] [nchar](10) NULL,
	[DthEmail] [nvarchar](50) NULL,
	[DthMaKh] [nchar](10) NULL,
 CONSTRAINT [PK_dthSinhVien] PRIMARY KEY CLUSTERED 
(
	[DthMaSV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[dthKhoa] ([DthMaKhoa], [DthTenKhoa], [DthTrangThai]) VALUES (N'K22CNT4   ', N'K22CNT4', 1)
GO
INSERT [dbo].[dthSinhVien] ([DthMaSV], [DthHoSV], [DthTenSV], [DthNgaySinh], [DthPhai], [DthPhone], [DthEmail], [DthMaKh]) VALUES (N'2210900028', N'Đàm Thúy', N'Hường', CAST(N'2004-08-31' AS Date), 1, N'0962169464', N'thuyhuong31804@gmail.com', N'K22CNT4   ')
GO
