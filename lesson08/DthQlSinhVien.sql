USE [Dth_qlSinhVien]
GO
/****** Object:  Table [dbo].[DthketQua]    Script Date: 6/26/2024 2:26:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DthketQua](
	[MaSV] [nchar](10) NULL,
	[MaMH] [nchar](10) NULL,
	[Diem] [float] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DthKhoa]    Script Date: 6/26/2024 2:26:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DthKhoa](
	[MaKH] [nchar](10) NOT NULL,
	[TenKH] [nvarchar](100) NULL,
 CONSTRAINT [PK_Khoa] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DthMonHoc]    Script Date: 6/26/2024 2:26:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DthMonHoc](
	[MaMH] [nchar](10) NOT NULL,
	[TenMh] [nvarchar](100) NULL,
	[SoTiet] [int] NULL,
 CONSTRAINT [PK_DthMonHoc] PRIMARY KEY CLUSTERED 
(
	[MaMH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DthSinhVien]    Script Date: 6/26/2024 2:26:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DthSinhVien](
	[MaSV] [nchar](10) NOT NULL,
	[HoSV] [nvarchar](100) NULL,
	[TenSV] [nvarchar](100) NULL,
	[Phai] [bit] NULL,
	[NgaySinh] [date] NULL,
	[NoiSinh] [nvarchar](200) NULL,
	[MaKH] [nchar](10) NULL,
	[HocBong] [decimal](18, 0) NULL,
	[DiemTrungBinh] [float] NULL,
 CONSTRAINT [PK_DthSinhVien] PRIMARY KEY CLUSTERED 
(
	[MaSV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[DthketQua] ([MaSV], [MaMH], [Diem]) VALUES (N'2210900028', N'CSN28     ', 9.9)
INSERT [dbo].[DthketQua] ([MaSV], [MaMH], [Diem]) VALUES (N'2210900028', N'CN39      ', 10)
GO
INSERT [dbo].[DthKhoa] ([MaKH], [TenKH]) VALUES (N'CNTT      ', N'Công nghệ thồn tin')
INSERT [dbo].[DthKhoa] ([MaKH], [TenKH]) VALUES (N'QTKD      ', N'Quản trị kinh doanh')
GO
INSERT [dbo].[DthMonHoc] ([MaMH], [TenMh], [SoTiet]) VALUES (N'CN39      ', N'Phát triển ứng dụng WEB với công nghệ .NET', 11)
INSERT [dbo].[DthMonHoc] ([MaMH], [TenMh], [SoTiet]) VALUES (N'CSN28     ', N'Lập trình ứng dụng với Windows Forms C#', 11)
GO
INSERT [dbo].[DthSinhVien] ([MaSV], [HoSV], [TenSV], [Phai], [NgaySinh], [NoiSinh], [MaKH], [HocBong], [DiemTrungBinh]) VALUES (N'2210900028', N'Đàm Thúy', N'Hường', 0, CAST(N'2004-08-31' AS Date), N'Hà Nội', N'CNTT      ', CAST(0 AS Decimal(18, 0)), 0)
INSERT [dbo].[DthSinhVien] ([MaSV], [HoSV], [TenSV], [Phai], [NgaySinh], [NoiSinh], [MaKH], [HocBong], [DiemTrungBinh]) VALUES (N'2210900031', N'Nguyễn Minh ', N'Phương', 0, CAST(N'2004-12-03' AS Date), N'Phú Thọ ', N'CNTT      ', CAST(0 AS Decimal(18, 0)), 0)
GO
ALTER TABLE [dbo].[DthketQua]  WITH CHECK ADD  CONSTRAINT [FK_DthketQua_DthMonHoc] FOREIGN KEY([MaMH])
REFERENCES [dbo].[DthMonHoc] ([MaMH])
GO
ALTER TABLE [dbo].[DthketQua] CHECK CONSTRAINT [FK_DthketQua_DthMonHoc]
GO
ALTER TABLE [dbo].[DthketQua]  WITH CHECK ADD  CONSTRAINT [FK_DthketQua_DthSinhVien] FOREIGN KEY([MaSV])
REFERENCES [dbo].[DthSinhVien] ([MaSV])
GO
ALTER TABLE [dbo].[DthketQua] CHECK CONSTRAINT [FK_DthketQua_DthSinhVien]
GO
ALTER TABLE [dbo].[DthSinhVien]  WITH CHECK ADD  CONSTRAINT [FK_DthSinhVien_DthKhoa] FOREIGN KEY([MaKH])
REFERENCES [dbo].[DthKhoa] ([MaKH])
GO
ALTER TABLE [dbo].[DthSinhVien] CHECK CONSTRAINT [FK_DthSinhVien_DthKhoa]
GO
