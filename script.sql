USE [master]
GO
/****** Object:  Database [QLNHANSU]    Script Date: 27-5-2018 2:04:42 PM ******/
CREATE DATABASE [QLNHANSU]
GO
ALTER DATABASE [QLNHANSU] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLNHANSU].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLNHANSU] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLNHANSU] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLNHANSU] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLNHANSU] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLNHANSU] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLNHANSU] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [QLNHANSU] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLNHANSU] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLNHANSU] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLNHANSU] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLNHANSU] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLNHANSU] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLNHANSU] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLNHANSU] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLNHANSU] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QLNHANSU] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLNHANSU] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLNHANSU] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLNHANSU] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLNHANSU] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLNHANSU] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLNHANSU] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLNHANSU] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QLNHANSU] SET  MULTI_USER 
GO
ALTER DATABASE [QLNHANSU] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLNHANSU] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLNHANSU] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLNHANSU] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'QLNHANSU', N'ON'
GO
USE [QLNHANSU]
GO
/****** Object:  Table [ChamCong]    Script Date: 27-5-2018 2:04:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [ChamCong](
	[MaNV] [varchar](30) NOT NULL,
	[Thang] [int] NOT NULL,
	[Nam] [int] NOT NULL,
	[SoNgayLam] [int] NOT NULL,
	[PhuCapThang] [int] NULL CONSTRAINT [DF_ChamCong_PhuCapThang]  DEFAULT ((0)),
	[DaTraTruoc] [int] NULL CONSTRAINT [DF_ChamCong_DaTraTruoc]  DEFAULT ((0)),
	[HeSoLuong] [float] NULL,
	[LuongNhan] [int] NOT NULL,
	[NgayCham] [datetime] NOT NULL CONSTRAINT [DF_ChamCong_NgayCham]  DEFAULT (getdate()),
	[TaiKhoanCham] [varchar](50) NULL,
 CONSTRAINT [PK_ChamCong] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC,
	[Thang] ASC,
	[Nam] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [ChucVu]    Script Date: 27-5-2018 2:04:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [ChucVu](
	[MaCV] [varchar](10) NOT NULL,
	[TenCV] [nvarchar](50) NOT NULL,
	[LuongCoBan] [int] NULL,
	[HeSoLuong] [float] NULL,
 CONSTRAINT [PK_ChucVu] PRIMARY KEY CLUSTERED 
(
	[MaCV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [KhenThuong_KyLuat]    Script Date: 27-5-2018 2:04:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [KhenThuong_KyLuat](
	[MaSo] [int] IDENTITY(1,1) NOT NULL,
	[MaNV] [varchar](30) NOT NULL,
	[NoiDung] [nvarchar](max) NULL,
	[SoTien] [int] NOT NULL,
	[Thang] [int] NOT NULL,
	[Nam] [int] NOT NULL,
	[KhenThuong] [bit] NOT NULL,
	[ThucHienBoi] [varchar](50) NULL,
 CONSTRAINT [PK_KhenThuong] PRIMARY KEY CLUSTERED 
(
	[MaSo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [NhanVien]    Script Date: 27-5-2018 2:04:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [NhanVien](
	[MaNV] [varchar](30) NOT NULL,
	[MaPB] [varchar](30) NULL,
	[MaCV] [varchar](10) NULL,
	[MaTD] [varchar](10) NULL,
	[HoTen] [nvarchar](100) NOT NULL,
	[GioiTinh] [bit] NOT NULL CONSTRAINT [DF__NhanVien__GioiTi__164452B1]  DEFAULT ((1)),
	[NgaySinh] [date] NOT NULL,
	[NgayVaoLam] [date] NOT NULL CONSTRAINT [DF_NhanVien_NgayVaoLam]  DEFAULT (getdate()),
	[DiaChi] [nvarchar](500) NULL,
	[CMND] [char](12) NULL,
	[Hinh] [varchar](60) NULL,
	[Email] [varchar](256) NULL,
	[DienThoai] [varchar](15) NULL,
	[GhiChu] [nvarchar](max) NULL,
	[TaiKhoanTao] [varchar](50) NULL,
 CONSTRAINT [PK__NhanVien__2725D70A8CCCF383] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [PhongBan]    Script Date: 27-5-2018 2:04:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [PhongBan](
	[MaPB] [varchar](30) NOT NULL,
	[TenPB] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [QuanTri]    Script Date: 27-5-2018 2:04:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [QuanTri](
	[TaiKhoan] [varchar](50) NOT NULL,
	[MatKhau] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Admin] PRIMARY KEY CLUSTERED 
(
	[TaiKhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [TrinhDoHocVan]    Script Date: 27-5-2018 2:04:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [TrinhDoHocVan](
	[MaTD] [varchar](10) NOT NULL,
	[TenTD] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_TrinhDo] PRIMARY KEY CLUSTERED 
(
	[MaTD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [ChamCong] ([MaNV], [Thang], [Nam], [SoNgayLam], [PhuCapThang], [DaTraTruoc], [HeSoLuong], [LuongNhan], [NgayCham], [TaiKhoanCham]) VALUES (N'NV01', 1, 2018, 30, 0, 0, NULL, 6999990, CAST(N'2018-01-16 00:00:00.000' AS DateTime), N'admin')
INSERT [ChamCong] ([MaNV], [Thang], [Nam], [SoNgayLam], [PhuCapThang], [DaTraTruoc], [HeSoLuong], [LuongNhan], [NgayCham], [TaiKhoanCham]) VALUES (N'NV04', 1, 2018, 12, 0, 0, NULL, 1999992, CAST(N'2018-01-16 00:00:00.000' AS DateTime), N'admin')
INSERT [ChamCong] ([MaNV], [Thang], [Nam], [SoNgayLam], [PhuCapThang], [DaTraTruoc], [HeSoLuong], [LuongNhan], [NgayCham], [TaiKhoanCham]) VALUES (N'NV04', 5, 2018, 20, 0, 100000, 1.2, 4500020, CAST(N'2018-05-27 00:00:00.000' AS DateTime), N'admin')
INSERT [ChamCong] ([MaNV], [Thang], [Nam], [SoNgayLam], [PhuCapThang], [DaTraTruoc], [HeSoLuong], [LuongNhan], [NgayCham], [TaiKhoanCham]) VALUES (N'NV04', 12, 2017, 25, 0, 0, NULL, 4166650, CAST(N'2018-01-16 00:00:00.000' AS DateTime), N'admin')
INSERT [ChucVu] ([MaCV], [TenCV], [LuongCoBan], [HeSoLuong]) VALUES (N'BV', N'Bảo vệ', 5000000, 1)
INSERT [ChucVu] ([MaCV], [TenCV], [LuongCoBan], [HeSoLuong]) VALUES (N'NVKD', N'Nhân viên kinh doanh', 7000000, 1.1)
INSERT [ChucVu] ([MaCV], [TenCV], [LuongCoBan], [HeSoLuong]) VALUES (N'NVKT', N'Nhân viên kỹ thuật', 8000000, 1.2)
INSERT [ChucVu] ([MaCV], [TenCV], [LuongCoBan], [HeSoLuong]) VALUES (N'TK', N'Thư ký', 10000000, 1.2)
SET IDENTITY_INSERT [KhenThuong_KyLuat] ON 

INSERT [KhenThuong_KyLuat] ([MaSo], [MaNV], [NoiDung], [SoTien], [Thang], [Nam], [KhenThuong], [ThucHienBoi]) VALUES (1, N'NV04', N'Hoàn thành nhanh tiến độ công việc', 500000, 5, 2018, 1, N'admin')
INSERT [KhenThuong_KyLuat] ([MaSo], [MaNV], [NoiDung], [SoTien], [Thang], [Nam], [KhenThuong], [ThucHienBoi]) VALUES (2, N'NV04', N'Đi làm đầy đủ', 200000, 5, 2018, 1, N'admin')
INSERT [KhenThuong_KyLuat] ([MaSo], [MaNV], [NoiDung], [SoTien], [Thang], [Nam], [KhenThuong], [ThucHienBoi]) VALUES (3, N'NV04', N'Không đeo thẻ.', 100000, 5, 2018, 0, N'admin')
SET IDENTITY_INSERT [KhenThuong_KyLuat] OFF
INSERT [NhanVien] ([MaNV], [MaPB], [MaCV], [MaTD], [HoTen], [GioiTinh], [NgaySinh], [NgayVaoLam], [DiaChi], [CMND], [Hinh], [Email], [DienThoai], [GhiChu], [TaiKhoanTao]) VALUES (N'NV01', N'KD1', N'NVKD', N'DH', N'Ngô Thanh Danh', 1, CAST(N'1985-02-25' AS Date), CAST(N'2018-01-14' AS Date), N'Quận 12, TPHCM', N'025736875   ', N'nv01.bmp', N'ngothanhdanh@gmail.com', N'01863522575', NULL, N'admin')
INSERT [NhanVien] ([MaNV], [MaPB], [MaCV], [MaTD], [HoTen], [GioiTinh], [NgaySinh], [NgayVaoLam], [DiaChi], [CMND], [Hinh], [Email], [DienThoai], [GhiChu], [TaiKhoanTao]) VALUES (N'NV02', N'KD1', N'NVKD', N'DH', N'Lý Thị Mộng Cầm', 0, CAST(N'1976-04-13' AS Date), CAST(N'2018-01-14' AS Date), N'235 Ba Đình, Hà Nội', N'237573497   ', N'nv02.bmp', N'mongcamly@gmail.com', N'01669635632', NULL, N'admin')
INSERT [NhanVien] ([MaNV], [MaPB], [MaCV], [MaTD], [HoTen], [GioiTinh], [NgaySinh], [NgayVaoLam], [DiaChi], [CMND], [Hinh], [Email], [DienThoai], [GhiChu], [TaiKhoanTao]) VALUES (N'NV03', N'TK', N'TK', N'DH', N'Nông Văn Lúa', 1, CAST(N'1978-05-10' AS Date), CAST(N'2018-01-14' AS Date), N'Quận 1, TPHCM', N'048240135   ', N'nv03.bmp', N'nongvanlua@gmail.com', N'01253528595', NULL, NULL)
INSERT [NhanVien] ([MaNV], [MaPB], [MaCV], [MaTD], [HoTen], [GioiTinh], [NgaySinh], [NgayVaoLam], [DiaChi], [CMND], [Hinh], [Email], [DienThoai], [GhiChu], [TaiKhoanTao]) VALUES (N'NV04', N'BV', N'BV', N'CD', N'Nguyễn Ái Tuấn', 1, CAST(N'1995-08-01' AS Date), CAST(N'2018-01-14' AS Date), N'Đảo Jeju', N'723012932   ', N'nv04.bmp', N'nguyenaituan95@gmail.com', N'01648315269', NULL, NULL)
INSERT [PhongBan] ([MaPB], [TenPB]) VALUES (N'BV', N'Bảo vệ')
INSERT [PhongBan] ([MaPB], [TenPB]) VALUES (N'KD1', N'Kinh doanh 1')
INSERT [PhongBan] ([MaPB], [TenPB]) VALUES (N'KD2', N'Kinh doanh 2')
INSERT [PhongBan] ([MaPB], [TenPB]) VALUES (N'KT', N'Kỹ thuật')
INSERT [PhongBan] ([MaPB], [TenPB]) VALUES (N'KT2', N'Kỹ thuật 2')
INSERT [PhongBan] ([MaPB], [TenPB]) VALUES (N'KT3', N'Kỹ thuật 3')
INSERT [PhongBan] ([MaPB], [TenPB]) VALUES (N'TK', N'Thư ký')
INSERT [QuanTri] ([TaiKhoan], [MatKhau]) VALUES (N'admin', N'admin')
INSERT [TrinhDoHocVan] ([MaTD], [TenTD]) VALUES (N'CD', N'Cao đẳng')
INSERT [TrinhDoHocVan] ([MaTD], [TenTD]) VALUES (N'DH', N'Đại học')
INSERT [TrinhDoHocVan] ([MaTD], [TenTD]) VALUES (N'GD', N'Giáo sư')
INSERT [TrinhDoHocVan] ([MaTD], [TenTD]) VALUES (N'PGS', N'Phó giáo sư')
INSERT [TrinhDoHocVan] ([MaTD], [TenTD]) VALUES (N'TC', N'Trung cấp')
INSERT [TrinhDoHocVan] ([MaTD], [TenTD]) VALUES (N'ThS', N'Thạc sĩ')
INSERT [TrinhDoHocVan] ([MaTD], [TenTD]) VALUES (N'TS', N'Tiến sĩ')
ALTER TABLE [ChamCong]  WITH CHECK ADD  CONSTRAINT [FK_ChamCong_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [NhanVien] ([MaNV])
ON DELETE CASCADE
GO
ALTER TABLE [ChamCong] CHECK CONSTRAINT [FK_ChamCong_NhanVien]
GO
ALTER TABLE [ChamCong]  WITH CHECK ADD  CONSTRAINT [FK_ChamCong_QuanTri] FOREIGN KEY([TaiKhoanCham])
REFERENCES [QuanTri] ([TaiKhoan])
ON DELETE SET NULL
GO
ALTER TABLE [ChamCong] CHECK CONSTRAINT [FK_ChamCong_QuanTri]
GO
ALTER TABLE [KhenThuong_KyLuat]  WITH CHECK ADD  CONSTRAINT [FK_KhenThuong_QuanTri] FOREIGN KEY([ThucHienBoi])
REFERENCES [QuanTri] ([TaiKhoan])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [KhenThuong_KyLuat] CHECK CONSTRAINT [FK_KhenThuong_QuanTri]
GO
ALTER TABLE [NhanVien]  WITH CHECK ADD  CONSTRAINT [FK__NhanVien__MaPB__1B0907CE] FOREIGN KEY([MaPB])
REFERENCES [PhongBan] ([MaPB])
GO
ALTER TABLE [NhanVien] CHECK CONSTRAINT [FK__NhanVien__MaPB__1B0907CE]
GO
ALTER TABLE [NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_ChucVu] FOREIGN KEY([MaCV])
REFERENCES [ChucVu] ([MaCV])
GO
ALTER TABLE [NhanVien] CHECK CONSTRAINT [FK_NhanVien_ChucVu]
GO
ALTER TABLE [NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_QuanTri] FOREIGN KEY([TaiKhoanTao])
REFERENCES [QuanTri] ([TaiKhoan])
ON DELETE SET NULL
GO
ALTER TABLE [NhanVien] CHECK CONSTRAINT [FK_NhanVien_QuanTri]
GO
ALTER TABLE [NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_TrinhDo] FOREIGN KEY([MaTD])
REFERENCES [TrinhDoHocVan] ([MaTD])
GO
ALTER TABLE [NhanVien] CHECK CONSTRAINT [FK_NhanVien_TrinhDo]
GO
/****** Object:  StoredProcedure [sp_suanhanvien]    Script Date: 27-5-2018 2:04:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [sp_suanhanvien]
	@MaNV varchar(30),
	@MaPB varchar(30),
	@MaCV varchar(10),
	@MaTD varchar(10),
	@HoTen nvarchar(100),
	@GioiTinh bit,
	@NgaySinh date,
	@NgayVaoLam date,
	@DiaChi nvarchar(500),
	@CMND char(12),
	@Hinh varchar(60),
	@Email varchar(256),
	@DienThoai varchar(15),
	@GhiChu nvarchar(MAX)
AS
BEGIN
	update NhanVien
	set MaPB =  @MaPB, MaCV =  @MaCV, MaTD =  @MaTD, HoTen =  @HoTen, GioiTinh =  @GioiTinh, 
	NgaySinh =  @NgaySinh, NgayVaoLam =  @NgayVaoLam, DiaChi =  @DiaChi, CMND =  @CMND, Hinh =  @Hinh, Email =  @Email,
	DienThoai =  @DienThoai, GhiChu =  @GhiChu where MaNV = @MaNV
END
GO
/****** Object:  StoredProcedure [sp_themnhanvien]    Script Date: 27-5-2018 2:04:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [sp_themnhanvien]
	@MaNV varchar(30),
	@MaPB varchar(30),
	@MaCV varchar(10),
	@MaTD varchar(10),
	@HoTen nvarchar(100),
	@GioiTinh bit,
	@NgaySinh date,
	@NgayVaoLam date,
	@DiaChi nvarchar(500),
	@CMND char(12),
	@Hinh varchar(60),
	@Email varchar(256),
	@DienThoai varchar(15),
	@GhiChu nvarchar(MAX),
	@TaiKhoanTao varchar(50)
AS
BEGIN
	insert into NhanVien
	values (@MaNV,@MaPB, @MaCV, @MaTD, @HoTen, @GioiTinh, @NgaySinh, @NgayVaoLam, @DiaChi, @CMND, @Hinh, @Email, @DienThoai, @GhiChu, @TaiKhoanTao)
END

GO
USE [master]
GO
ALTER DATABASE [QLNHANSU] SET  READ_WRITE 
GO
