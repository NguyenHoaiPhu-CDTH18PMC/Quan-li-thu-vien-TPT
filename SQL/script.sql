USE [QuanLiThuVienTPT]
GO
/****** Object:  Table [dbo].[CHITIETPHIEUMUON]    Script Date: 19/07/2020 9:15:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIETPHIEUMUON](
	[MaCTPM] [varchar](10) NOT NULL,
	[MaSach] [varchar](10) NOT NULL,
	[NgayMuon] [date] NOT NULL,
	[XoaCTPM] [bit] NOT NULL,
 CONSTRAINT [PK_CHITIETPHIEUMUON] PRIMARY KEY CLUSTERED 
(
	[MaCTPM] ASC,
	[MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CHITIETPHIEUTRA]    Script Date: 19/07/2020 9:15:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIETPHIEUTRA](
	[MaCTPT] [varchar](10) NOT NULL,
	[MaSach] [varchar](10) NOT NULL,
	[DaTra] [bit] NULL,
	[TinhTrang] [bit] NULL,
	[GhiChu] [nvarchar](50) NULL,
	[TienPhat] [money] NULL,
	[XoaCTPT] [bit] NOT NULL,
 CONSTRAINT [PK_CHITIETPHIEUTRA] PRIMARY KEY CLUSTERED 
(
	[MaCTPT] ASC,
	[MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DAUSACH]    Script Date: 19/07/2020 9:15:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DAUSACH](
	[MaDauSach] [varchar](10) NOT NULL,
	[TenDauSach] [varchar](50) NOT NULL,
	[MaTheLoai] [varchar](10) NOT NULL,
	[XoaDauSach] [bit] NOT NULL,
 CONSTRAINT [PK_DAUSACH] PRIMARY KEY CLUSTERED 
(
	[MaDauSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DOCGIA]    Script Date: 19/07/2020 9:15:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DOCGIA](
	[MaDocGia] [varchar](10) NOT NULL,
	[TenDocGia] [nvarchar](30) NOT NULL,
	[GioiTinh] [nvarchar](3) NOT NULL,
	[DiaChi] [nvarchar](30) NOT NULL,
	[Email] [varchar](30) NOT NULL,
	[Phone] [varchar](10) NOT NULL,
	[Khoa] [nvarchar](25) NOT NULL,
	[Lop] [nvarchar](15) NOT NULL,
	[XoaDocGia] [bit] NOT NULL,
 CONSTRAINT [PK_DOCGIA] PRIMARY KEY CLUSTERED 
(
	[MaDocGia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LICHSUDANGNHAP]    Script Date: 19/07/2020 9:15:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LICHSUDANGNHAP](
	[ID] [int] IDENTITY(1000,1) NOT NULL,
	[MaNV] [varchar](10) NOT NULL,
	[TGDangNhap] [datetime] NOT NULL,
	[XoaLS] [bit] NOT NULL,
 CONSTRAINT [PK_LICHSUDANGNHAP] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 19/07/2020 9:15:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[MaNV] [varchar](10) NOT NULL,
	[TenNV] [nvarchar](30) NOT NULL,
	[NgaySinh] [date] NOT NULL,
	[GioiTinh] [nvarchar](3) NOT NULL,
	[DiaChi] [nvarchar](30) NOT NULL,
	[Email] [varchar](30) NOT NULL,
	[Phone] [varchar](10) NOT NULL,
	[TK] [varchar](20) NOT NULL,
	[MK] [varchar](200) NULL,
	[Quyen] [nvarchar](20) NOT NULL,
	[AnhDaiDien] [varchar](40) NULL,
	[XoaNV] [bit] NOT NULL,
 CONSTRAINT [PK_NHANVIEN] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHAXUATBAN]    Script Date: 19/07/2020 9:15:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHAXUATBAN](
	[MaNXB] [varchar](10) NOT NULL,
	[TenNXB] [nvarchar](30) NOT NULL,
	[DiaChi] [nvarchar](30) NOT NULL,
	[Email] [varchar](30) NOT NULL,
	[XoaNXB] [bit] NOT NULL,
 CONSTRAINT [PK_NXB] PRIMARY KEY CLUSTERED 
(
	[MaNXB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHIEUMUON]    Script Date: 19/07/2020 9:15:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUMUON](
	[MaPM] [varchar](10) NOT NULL,
	[SoLuongMuon] [int] NOT NULL,
	[NgayMuon] [date] NOT NULL,
	[MaDocGia] [varchar](10) NOT NULL,
	[MaNV] [varchar](10) NOT NULL,
	[XoaPM] [bit] NOT NULL,
	[NgayTra] [date] NOT NULL,
 CONSTRAINT [PK_PHIEUMUON] PRIMARY KEY CLUSTERED 
(
	[MaPM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHIEUTRA]    Script Date: 19/07/2020 9:15:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUTRA](
	[MaPT] [varchar](10) NOT NULL,
	[SoLuongTra] [int] NOT NULL,
	[NgayTra] [date] NULL,
	[MaNV] [varchar](10) NOT NULL,
	[MaPM] [varchar](10) NOT NULL,
	[XoaPhieuTra] [bit] NOT NULL,
 CONSTRAINT [PK_PHIEUTRA] PRIMARY KEY CLUSTERED 
(
	[MaPT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SACH]    Script Date: 19/07/2020 9:15:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SACH](
	[MaSach] [varchar](10) NOT NULL,
	[TenSach] [nvarchar](50) NOT NULL,
	[MaTacGia] [varchar](10) NOT NULL,
	[MaDauSach] [varchar](10) NOT NULL,
	[MaNXB] [varchar](10) NOT NULL,
	[NamXB] [int] NOT NULL,
	[GiaTien] [money] NOT NULL,
	[SLTon] [int] NOT NULL,
	[XoaSach] [bit] NOT NULL,
 CONSTRAINT [PK_SACH] PRIMARY KEY CLUSTERED 
(
	[MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TACGIA]    Script Date: 19/07/2020 9:15:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TACGIA](
	[MaTacGia] [varchar](10) NOT NULL,
	[HoTen] [nvarchar](20) NOT NULL,
	[Email] [varchar](30) NOT NULL,
	[DiaChi] [nvarchar](30) NOT NULL,
	[XoaTacGia] [bit] NOT NULL,
 CONSTRAINT [PK_TACGIA] PRIMARY KEY CLUSTERED 
(
	[MaTacGia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[THELOAI]    Script Date: 19/07/2020 9:15:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[THELOAI](
	[MaTheLoai] [varchar](10) NOT NULL,
	[TenTheLoai] [nvarchar](25) NOT NULL,
	[XoaTheLoai] [bit] NOT NULL,
 CONSTRAINT [PK_THELOAI] PRIMARY KEY CLUSTERED 
(
	[MaTheLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[CHITIETPHIEUMUON] ([MaCTPM], [MaSach], [NgayMuon], [XoaCTPM]) VALUES (N'PM-01', N'BOOK-011', CAST(N'2020-07-10' AS Date), 1)
INSERT [dbo].[CHITIETPHIEUMUON] ([MaCTPM], [MaSach], [NgayMuon], [XoaCTPM]) VALUES (N'PM-01', N'BOOK-012', CAST(N'2020-07-10' AS Date), 1)
INSERT [dbo].[CHITIETPHIEUMUON] ([MaCTPM], [MaSach], [NgayMuon], [XoaCTPM]) VALUES (N'PM-01', N'BOOK-013', CAST(N'2020-07-10' AS Date), 1)
GO
INSERT [dbo].[CHITIETPHIEUTRA] ([MaCTPT], [MaSach], [DaTra], [TinhTrang], [GhiChu], [TienPhat], [XoaCTPT]) VALUES (N'PT-PM-01', N'BOOK-011', 1, 1, N'Hỏng sách', 5.0000, 1)
INSERT [dbo].[CHITIETPHIEUTRA] ([MaCTPT], [MaSach], [DaTra], [TinhTrang], [GhiChu], [TienPhat], [XoaCTPT]) VALUES (N'PT-PM-01', N'BOOK-012', 1, 1, N'Hỏng sách', 5.0000, 1)
INSERT [dbo].[CHITIETPHIEUTRA] ([MaCTPT], [MaSach], [DaTra], [TinhTrang], [GhiChu], [TienPhat], [XoaCTPT]) VALUES (N'PT-PM-01', N'BOOK-013', 1, 1, N'Hỏng sách', 5.0000, 1)
GO
INSERT [dbo].[DAUSACH] ([MaDauSach], [TenDauSach], [MaTheLoai], [XoaDauSach]) VALUES (N'DS-01', N'Doraemon', N'TL-01', 1)
INSERT [dbo].[DAUSACH] ([MaDauSach], [TenDauSach], [MaTheLoai], [XoaDauSach]) VALUES (N'DS-02', N'Conan', N'TL-02', 1)
INSERT [dbo].[DAUSACH] ([MaDauSach], [TenDauSach], [MaTheLoai], [XoaDauSach]) VALUES (N'DS-03', N'Naruto sua', N'TL-03', 1)
INSERT [dbo].[DAUSACH] ([MaDauSach], [TenDauSach], [MaTheLoai], [XoaDauSach]) VALUES (N'DS-04', N'Dragonball', N'TL-04', 1)
INSERT [dbo].[DAUSACH] ([MaDauSach], [TenDauSach], [MaTheLoai], [XoaDauSach]) VALUES (N'DS-05', N'Sai quai2', N'TL-03', 0)
INSERT [dbo].[DAUSACH] ([MaDauSach], [TenDauSach], [MaTheLoai], [XoaDauSach]) VALUES (N'DS-06', N'', N'TL-01', 0)
INSERT [dbo].[DAUSACH] ([MaDauSach], [TenDauSach], [MaTheLoai], [XoaDauSach]) VALUES (N'DS-07', N'', N'TL-01', 0)
GO
INSERT [dbo].[DOCGIA] ([MaDocGia], [TenDocGia], [GioiTinh], [DiaChi], [Email], [Phone], [Khoa], [Lop], [XoaDocGia]) VALUES (N'DG-01', N'Nguyễn Hoài Phú', N'Nam', N'Bến Tre', N'phunguyen@gmail.com', N'0163941205', N'Tin học', N'CĐTH18C', 1)
INSERT [dbo].[DOCGIA] ([MaDocGia], [TenDocGia], [GioiTinh], [DiaChi], [Email], [Phone], [Khoa], [Lop], [XoaDocGia]) VALUES (N'DG-02', N'Nguyễn Anh Tuấn', N'Nam', N'Vũng Tàu', N'tuannguyen@gmail.com', N'0163941201', N'Tin học', N'CĐTH18C', 1)
INSERT [dbo].[DOCGIA] ([MaDocGia], [TenDocGia], [GioiTinh], [DiaChi], [Email], [Phone], [Khoa], [Lop], [XoaDocGia]) VALUES (N'DG-03', N'Nguyễn Mai Phương Toàn', N'Nam', N'TP.HCM', N'toannguyen@gmail.com', N'0163941202', N'Tin học', N'CĐTH18C', 1)
INSERT [dbo].[DOCGIA] ([MaDocGia], [TenDocGia], [GioiTinh], [DiaChi], [Email], [Phone], [Khoa], [Lop], [XoaDocGia]) VALUES (N'DG-04', N'Phạm Văn Phúc', N'Nam', N'Vũng Tàu', N'tuannguyen@gmail.com', N'0163941201', N'Tin học', N'CĐTH18C', 1)
INSERT [dbo].[DOCGIA] ([MaDocGia], [TenDocGia], [GioiTinh], [DiaChi], [Email], [Phone], [Khoa], [Lop], [XoaDocGia]) VALUES (N'DG-05', N'Nguyễn Anh Tuấn', N'Nam', N'Vũng Tàu', N'tuannguyen@gmail.com', N'0163941201', N'Tin học', N'CĐTH18C', 1)
INSERT [dbo].[DOCGIA] ([MaDocGia], [TenDocGia], [GioiTinh], [DiaChi], [Email], [Phone], [Khoa], [Lop], [XoaDocGia]) VALUES (N'DG-06', N'Toàn', N'Nam', N'HCM', N'Toan123@gmail.com', N'0305962', N'Tin học', N'CĐTH18C', 1)
GO
SET IDENTITY_INSERT [dbo].[LICHSUDANGNHAP] ON 

INSERT [dbo].[LICHSUDANGNHAP] ([ID], [MaNV], [TGDangNhap], [XoaLS]) VALUES (1854, N'QL-01', CAST(N'2020-07-10T10:00:54.633' AS DateTime), 1)
INSERT [dbo].[LICHSUDANGNHAP] ([ID], [MaNV], [TGDangNhap], [XoaLS]) VALUES (1855, N'QL-01', CAST(N'2020-07-10T10:03:12.943' AS DateTime), 1)
INSERT [dbo].[LICHSUDANGNHAP] ([ID], [MaNV], [TGDangNhap], [XoaLS]) VALUES (1856, N'QL-01', CAST(N'2020-07-10T10:51:46.963' AS DateTime), 1)
INSERT [dbo].[LICHSUDANGNHAP] ([ID], [MaNV], [TGDangNhap], [XoaLS]) VALUES (1857, N'QL-01', CAST(N'2020-07-10T10:52:05.140' AS DateTime), 1)
INSERT [dbo].[LICHSUDANGNHAP] ([ID], [MaNV], [TGDangNhap], [XoaLS]) VALUES (1858, N'QL-01', CAST(N'2020-07-10T10:57:10.847' AS DateTime), 1)
INSERT [dbo].[LICHSUDANGNHAP] ([ID], [MaNV], [TGDangNhap], [XoaLS]) VALUES (1859, N'QL-01', CAST(N'2020-07-10T10:59:07.837' AS DateTime), 1)
INSERT [dbo].[LICHSUDANGNHAP] ([ID], [MaNV], [TGDangNhap], [XoaLS]) VALUES (1860, N'QL-01', CAST(N'2020-07-10T11:00:20.357' AS DateTime), 1)
INSERT [dbo].[LICHSUDANGNHAP] ([ID], [MaNV], [TGDangNhap], [XoaLS]) VALUES (1861, N'QL-01', CAST(N'2020-07-10T11:20:01.770' AS DateTime), 1)
INSERT [dbo].[LICHSUDANGNHAP] ([ID], [MaNV], [TGDangNhap], [XoaLS]) VALUES (1862, N'QL-01', CAST(N'2020-07-10T11:23:37.473' AS DateTime), 1)
INSERT [dbo].[LICHSUDANGNHAP] ([ID], [MaNV], [TGDangNhap], [XoaLS]) VALUES (1863, N'QL-01', CAST(N'2020-07-10T11:25:50.067' AS DateTime), 1)
INSERT [dbo].[LICHSUDANGNHAP] ([ID], [MaNV], [TGDangNhap], [XoaLS]) VALUES (1864, N'QL-01', CAST(N'2020-07-10T11:30:55.950' AS DateTime), 1)
INSERT [dbo].[LICHSUDANGNHAP] ([ID], [MaNV], [TGDangNhap], [XoaLS]) VALUES (1865, N'QL-01', CAST(N'2020-07-10T11:43:59.567' AS DateTime), 1)
INSERT [dbo].[LICHSUDANGNHAP] ([ID], [MaNV], [TGDangNhap], [XoaLS]) VALUES (1866, N'QL-01', CAST(N'2020-07-10T11:56:52.700' AS DateTime), 1)
INSERT [dbo].[LICHSUDANGNHAP] ([ID], [MaNV], [TGDangNhap], [XoaLS]) VALUES (1867, N'QL-01', CAST(N'2020-07-10T12:02:25.157' AS DateTime), 1)
INSERT [dbo].[LICHSUDANGNHAP] ([ID], [MaNV], [TGDangNhap], [XoaLS]) VALUES (1868, N'QL-01', CAST(N'2020-07-10T12:10:29.950' AS DateTime), 1)
INSERT [dbo].[LICHSUDANGNHAP] ([ID], [MaNV], [TGDangNhap], [XoaLS]) VALUES (1869, N'QL-01', CAST(N'2020-07-10T12:25:04.100' AS DateTime), 1)
INSERT [dbo].[LICHSUDANGNHAP] ([ID], [MaNV], [TGDangNhap], [XoaLS]) VALUES (1870, N'QL-01', CAST(N'2020-07-10T12:25:33.573' AS DateTime), 1)
INSERT [dbo].[LICHSUDANGNHAP] ([ID], [MaNV], [TGDangNhap], [XoaLS]) VALUES (1871, N'QL-01', CAST(N'2020-07-19T19:21:44.893' AS DateTime), 1)
SET IDENTITY_INSERT [dbo].[LICHSUDANGNHAP] OFF
GO
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [DiaChi], [Email], [Phone], [TK], [MK], [Quyen], [AnhDaiDien], [XoaNV]) VALUES (N'NV-02', N'Nguyễn Mai Phương Toàn', CAST(N'1995-09-01' AS Date), N'Nam', N'TP.HCM', N'dungnguyen@gmail.com', N'1', N'', N'f4cc399f0effd13c888e310ea2cf5399', N'Thủ thư', N'NV-02598.jpg', 1)
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [DiaChi], [Email], [Phone], [TK], [MK], [Quyen], [AnhDaiDien], [XoaNV]) VALUES (N'NV-03', N'Admin', CAST(N'1994-02-05' AS Date), N'Nam', N'TP.HCM', N'duynguyen@gmail.com', N'0163941201', N'Admin', N'e10adc3949ba59abbe56e057f20f883e', N'Thủ thư', N'NV-03562.jpg', 1)
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [DiaChi], [Email], [Phone], [TK], [MK], [Quyen], [AnhDaiDien], [XoaNV]) VALUES (N'NV-04', N'', CAST(N'1995-09-01' AS Date), N'Nam', N'', N'', N'', N'', N'd41d8cd98f00b204e9800998ecf8427e', N'Thủ thư', N'NV-04807.jpg', 0)
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [DiaChi], [Email], [Phone], [TK], [MK], [Quyen], [AnhDaiDien], [XoaNV]) VALUES (N'QL-01', N'Nguyễn Hoài Phú', CAST(N'2000-04-05' AS Date), N'Nam', N'TP.HCM', N'phunguyen@gmail.com', N'0163941201', N'NguyenHoaiPhu', N'e10adc3949ba59abbe56e057f20f883e', N'Quản trị', N'QL-01763.jpg', 1)
GO
INSERT [dbo].[NHAXUATBAN] ([MaNXB], [TenNXB], [DiaChi], [Email], [XoaNXB]) VALUES (N'NXB-01', N'NXB Phụ Nữ ', N'Hà Nội', N'nxbphunu@gmail.com', 1)
INSERT [dbo].[NHAXUATBAN] ([MaNXB], [TenNXB], [DiaChi], [Email], [XoaNXB]) VALUES (N'NXB-02', N'NXB Lao Động', N'Hà Nội', N'nxblaodong@gmail.com', 0)
INSERT [dbo].[NHAXUATBAN] ([MaNXB], [TenNXB], [DiaChi], [Email], [XoaNXB]) VALUES (N'NXB-03', N'NXB Hàng Hải', N'Hải Phòng', N'nxbhanghai@gmail.com', 1)
INSERT [dbo].[NHAXUATBAN] ([MaNXB], [TenNXB], [DiaChi], [Email], [XoaNXB]) VALUES (N'NXB-04', N'NXB Phương Đông', N'TP.HCM', N'nxbphuongdong@gmail.com', 1)
INSERT [dbo].[NHAXUATBAN] ([MaNXB], [TenNXB], [DiaChi], [Email], [XoaNXB]) VALUES (N'NXB-05', N'Bến Tre', N'Bne1 Tre', N'123', 0)
GO
INSERT [dbo].[PHIEUMUON] ([MaPM], [SoLuongMuon], [NgayMuon], [MaDocGia], [MaNV], [XoaPM], [NgayTra]) VALUES (N'PM-01', 3, CAST(N'2020-07-10' AS Date), N'DG-01', N'QL-01', 0, CAST(N'2020-07-12' AS Date))
GO
INSERT [dbo].[PHIEUTRA] ([MaPT], [SoLuongTra], [NgayTra], [MaNV], [MaPM], [XoaPhieuTra]) VALUES (N'PT-PM-01', 3, CAST(N'2020-07-10' AS Date), N'QL-01', N'PM-01', 1)
GO
INSERT [dbo].[SACH] ([MaSach], [TenSach], [MaTacGia], [MaDauSach], [MaNXB], [NamXB], [GiaTien], [SLTon], [XoaSach]) VALUES (N'BOOK-01', N'Lập trình Winform', N'TG-02', N'DS-01', N'NXB-01', 1990, 111.0000, 111, 0)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [MaTacGia], [MaDauSach], [MaNXB], [NamXB], [GiaTien], [SLTon], [XoaSach]) VALUES (N'BOOK-010', N'ASP.NET', N'TG-01', N'DS-01', N'NXB-01', 1989, 10000.0000, 1, 1)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [MaTacGia], [MaDauSach], [MaNXB], [NamXB], [GiaTien], [SLTon], [XoaSach]) VALUES (N'BOOK-011', N'Harry Potter', N'TG-01', N'DS-01', N'NXB-01', 1, 10000.0000, -1, 1)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [MaTacGia], [MaDauSach], [MaNXB], [NamXB], [GiaTien], [SLTon], [XoaSach]) VALUES (N'BOOK-012', N'Nếu thời gian dừng lại ở ngày hôm nay', N'TG-01', N'DS-01', N'NXB-01', 2000, 10000.0000, 0, 1)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [MaTacGia], [MaDauSach], [MaNXB], [NamXB], [GiaTien], [SLTon], [XoaSach]) VALUES (N'BOOK-013', N'Một ngày khác', N'TG-01', N'DS-01', N'NXB-01', 2015, 10000.0000, 2, 1)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [MaTacGia], [MaDauSach], [MaNXB], [NamXB], [GiaTien], [SLTon], [XoaSach]) VALUES (N'BOOK-014', N'Anh văn chuyên ngành', N'TG-01', N'DS-03', N'NXB-01', 2019, 10000.0000, 3, 1)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [MaTacGia], [MaDauSach], [MaNXB], [NamXB], [GiaTien], [SLTon], [XoaSach]) VALUES (N'BOOK-015', N'Toán học ', N'TG-01', N'DS-01', N'NXB-01', 2001, 10000.0000, 1, 1)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [MaTacGia], [MaDauSach], [MaNXB], [NamXB], [GiaTien], [SLTon], [XoaSach]) VALUES (N'BOOK-016', N'Văn học', N'TG-01', N'DS-01', N'NXB-01', 2001, 10000.0000, 0, 1)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [MaTacGia], [MaDauSach], [MaNXB], [NamXB], [GiaTien], [SLTon], [XoaSach]) VALUES (N'BOOK-017', N'Lịch sử', N'TG-01', N'DS-01', N'NXB-01', 1890, 10000.0000, 0, 0)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [MaTacGia], [MaDauSach], [MaNXB], [NamXB], [GiaTien], [SLTon], [XoaSach]) VALUES (N'BOOK-018', N'Tin học ứng dụng', N'TG-01', N'DS-01', N'NXB-01', 2002, 10000.0000, 1, 1)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [MaTacGia], [MaDauSach], [MaNXB], [NamXB], [GiaTien], [SLTon], [XoaSach]) VALUES (N'BOOK-019', N'Quản trị mạng', N'TG-01', N'DS-01', N'NXB-01', 2016, 10000.0000, 1, 1)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [MaTacGia], [MaDauSach], [MaNXB], [NamXB], [GiaTien], [SLTon], [XoaSach]) VALUES (N'BOOK-02', N'Lập trình Java', N'TG-02', N'DS-02', N'NXB-02', 1985, 155000.0000, 1, 1)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [MaTacGia], [MaDauSach], [MaNXB], [NamXB], [GiaTien], [SLTon], [XoaSach]) VALUES (N'BOOK-020', N'Vật lý đại cương', N'TG-01', N'DS-01', N'NXB-01', 1, 10000.0000, 1, 0)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [MaTacGia], [MaDauSach], [MaNXB], [NamXB], [GiaTien], [SLTon], [XoaSach]) VALUES (N'BOOK-021', N'Đừng sai nữa Phú mệt rồi', N'TG-01', N'DS-01', N'NXB-01', 2019, 10000.0000, 1, 1)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [MaTacGia], [MaDauSach], [MaNXB], [NamXB], [GiaTien], [SLTon], [XoaSach]) VALUES (N'BOOK-022', N'Tester', N'TG-01', N'DS-01', N'NXB-01', 2005, 15000.0000, 2, 1)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [MaTacGia], [MaDauSach], [MaNXB], [NamXB], [GiaTien], [SLTon], [XoaSach]) VALUES (N'BOOK-03', N'Lập trình PHP', N'TG-03', N'DS-03', N'NXB-03', 2000, 30000.0000, 1, 1)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [MaTacGia], [MaDauSach], [MaNXB], [NamXB], [GiaTien], [SLTon], [XoaSach]) VALUES (N'BOOK-04', N'CNPM', N'TG-01', N'DS-01', N'NXB-01', 1990, 10000.0000, 1, 1)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [MaTacGia], [MaDauSach], [MaNXB], [NamXB], [GiaTien], [SLTon], [XoaSach]) VALUES (N'BOOK-05', N'HTML', N'TG-01', N'DS-01', N'NXB-01', 2012, 10000.0000, 1, 1)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [MaTacGia], [MaDauSach], [MaNXB], [NamXB], [GiaTien], [SLTon], [XoaSach]) VALUES (N'BOOK-06', N'DVM', N'TG-01', N'DS-01', N'NXB-01', 1922, 10000.0000, 1, 1)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [MaTacGia], [MaDauSach], [MaNXB], [NamXB], [GiaTien], [SLTon], [XoaSach]) VALUES (N'BOOK-07', N'Phần cứng máy tính', N'TG-01', N'DS-01', N'NXB-01', 1990, 10000.0000, 1, 1)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [MaTacGia], [MaDauSach], [MaNXB], [NamXB], [GiaTien], [SLTon], [XoaSach]) VALUES (N'BOOK-08', N'Nhập môn lập trình C++', N'TG-01', N'DS-01', N'NXB-01', 2018, 15000.0000, 1, 1)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [MaTacGia], [MaDauSach], [MaNXB], [NamXB], [GiaTien], [SLTon], [XoaSach]) VALUES (N'BOOK-09', N'Python', N'TG-01', N'DS-01', N'NXB-01', 2015, 10000.0000, 1, 1)
GO
INSERT [dbo].[TACGIA] ([MaTacGia], [HoTen], [Email], [DiaChi], [XoaTacGia]) VALUES (N'TG-01', N'Meta Wagner', N'wagnermeta@gmail.com', N'Tokyo', 1)
INSERT [dbo].[TACGIA] ([MaTacGia], [HoTen], [Email], [DiaChi], [XoaTacGia]) VALUES (N'TG-02', N'Joanne Mattern', N'matternjoanne@gmail.com', N'London', 1)
INSERT [dbo].[TACGIA] ([MaTacGia], [HoTen], [Email], [DiaChi], [XoaTacGia]) VALUES (N'TG-03', N'Đới Nhật Cường', N'nhatcuong@gmail.com', N'TP.HCM', 1)
INSERT [dbo].[TACGIA] ([MaTacGia], [HoTen], [Email], [DiaChi], [XoaTacGia]) VALUES (N'TG-04', N'Đại Vũ', N'vudai@gmail.com', N'Ha Noi', 1)
INSERT [dbo].[TACGIA] ([MaTacGia], [HoTen], [Email], [DiaChi], [XoaTacGia]) VALUES (N'TG-05', N'Nguyễn Nhật Ánh', N'Không có thông tin', N'Không có thông tin', 0)
GO
INSERT [dbo].[THELOAI] ([MaTheLoai], [TenTheLoai], [XoaTheLoai]) VALUES (N'TL-01', N'Văn học', 1)
INSERT [dbo].[THELOAI] ([MaTheLoai], [TenTheLoai], [XoaTheLoai]) VALUES (N'TL-02', N'Sức khỏe', 1)
INSERT [dbo].[THELOAI] ([MaTheLoai], [TenTheLoai], [XoaTheLoai]) VALUES (N'TL-03', N'Giáo dục', 1)
INSERT [dbo].[THELOAI] ([MaTheLoai], [TenTheLoai], [XoaTheLoai]) VALUES (N'TL-04', N'Khoa học', 1)
GO
ALTER TABLE [dbo].[CHITIETPHIEUMUON]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETPHIEUMUON_SACH] FOREIGN KEY([MaSach])
REFERENCES [dbo].[SACH] ([MaSach])
GO
ALTER TABLE [dbo].[CHITIETPHIEUMUON] CHECK CONSTRAINT [FK_CHITIETPHIEUMUON_SACH]
GO
ALTER TABLE [dbo].[CHITIETPHIEUMUON]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETPHIEUTRA_PHIEUMUON] FOREIGN KEY([MaCTPM])
REFERENCES [dbo].[PHIEUMUON] ([MaPM])
GO
ALTER TABLE [dbo].[CHITIETPHIEUMUON] CHECK CONSTRAINT [FK_CHITIETPHIEUTRA_PHIEUMUON]
GO
ALTER TABLE [dbo].[CHITIETPHIEUTRA]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETPHIEUTRA_PHIEUTRA] FOREIGN KEY([MaCTPT])
REFERENCES [dbo].[PHIEUTRA] ([MaPT])
GO
ALTER TABLE [dbo].[CHITIETPHIEUTRA] CHECK CONSTRAINT [FK_CHITIETPHIEUTRA_PHIEUTRA]
GO
ALTER TABLE [dbo].[CHITIETPHIEUTRA]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETPHIEUTRA_SACH] FOREIGN KEY([MaSach])
REFERENCES [dbo].[SACH] ([MaSach])
GO
ALTER TABLE [dbo].[CHITIETPHIEUTRA] CHECK CONSTRAINT [FK_CHITIETPHIEUTRA_SACH]
GO
ALTER TABLE [dbo].[DAUSACH]  WITH CHECK ADD  CONSTRAINT [FK_DAUSACH_THELOAI] FOREIGN KEY([MaTheLoai])
REFERENCES [dbo].[THELOAI] ([MaTheLoai])
GO
ALTER TABLE [dbo].[DAUSACH] CHECK CONSTRAINT [FK_DAUSACH_THELOAI]
GO
ALTER TABLE [dbo].[LICHSUDANGNHAP]  WITH CHECK ADD  CONSTRAINT [FK_LICHSUDANGNHAP_NHANVIEN] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[LICHSUDANGNHAP] CHECK CONSTRAINT [FK_LICHSUDANGNHAP_NHANVIEN]
GO
ALTER TABLE [dbo].[PHIEUMUON]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUMUON_DOCGIA] FOREIGN KEY([MaDocGia])
REFERENCES [dbo].[DOCGIA] ([MaDocGia])
GO
ALTER TABLE [dbo].[PHIEUMUON] CHECK CONSTRAINT [FK_PHIEUMUON_DOCGIA]
GO
ALTER TABLE [dbo].[PHIEUMUON]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUMUON_NHANVIEN] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[PHIEUMUON] CHECK CONSTRAINT [FK_PHIEUMUON_NHANVIEN]
GO
ALTER TABLE [dbo].[PHIEUTRA]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUTRA_NHANVIEN] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[PHIEUTRA] CHECK CONSTRAINT [FK_PHIEUTRA_NHANVIEN]
GO
ALTER TABLE [dbo].[PHIEUTRA]  WITH CHECK ADD  CONSTRAINT [FK_PhieuTra_PhieuMuon] FOREIGN KEY([MaPM])
REFERENCES [dbo].[PHIEUMUON] ([MaPM])
GO
ALTER TABLE [dbo].[PHIEUTRA] CHECK CONSTRAINT [FK_PhieuTra_PhieuMuon]
GO
ALTER TABLE [dbo].[SACH]  WITH CHECK ADD  CONSTRAINT [FK_SACH_DAUSACH] FOREIGN KEY([MaDauSach])
REFERENCES [dbo].[DAUSACH] ([MaDauSach])
GO
ALTER TABLE [dbo].[SACH] CHECK CONSTRAINT [FK_SACH_DAUSACH]
GO
ALTER TABLE [dbo].[SACH]  WITH CHECK ADD  CONSTRAINT [FK_SACH_NXB] FOREIGN KEY([MaNXB])
REFERENCES [dbo].[NHAXUATBAN] ([MaNXB])
GO
ALTER TABLE [dbo].[SACH] CHECK CONSTRAINT [FK_SACH_NXB]
GO
ALTER TABLE [dbo].[SACH]  WITH CHECK ADD  CONSTRAINT [FK_SACH_TACGIA] FOREIGN KEY([MaTacGia])
REFERENCES [dbo].[TACGIA] ([MaTacGia])
GO
ALTER TABLE [dbo].[SACH] CHECK CONSTRAINT [FK_SACH_TACGIA]
GO
