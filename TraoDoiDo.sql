USE [DoAnTraoDoiDo]
GO
/****** Object:  Table [dbo].[ĐăngBán]    Script Date: 5/13/2024 12:02:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ĐăngBán](
	[Tên_mặt_hàng] [varchar](100) NULL,
	[Loại_mặt_hàng] [varchar](100) NULL,
	[Giá_bán] [varchar](30) NULL,
	[Mô_tả_mặt_hàng] [varchar](500) NULL,
	[Hình_ảnh_1] [varchar](200) NULL,
	[Hình_ảnh_2] [varchar](200) NULL,
	[Hình_ảnh_3] [varchar](200) NULL,
	[Hình_ảnh_4] [varchar](200) NULL,
	[Mã_Voucher] [varchar](20) NULL,
	[Giảm_giá] [varchar](10) NULL,
	[Số_lượng_Voucher] [varchar](10) NULL,
	[Số_lượng] [varchar](10) NULL,
	[Địa_điểm] [varchar](300) NULL,
	[Phương_thức_giao_hàng] [varchar](200) NULL,
	[Tình_trạng_mặt_hàng] [varchar](500) NULL,
	[Mã_sản_phẩm] [varchar](20) NULL,
	[Ngày_đăng_bán] [nvarchar](200) NULL,
	[ID] [varchar](20) NULL,
	[Giá_gốc] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ĐăngKí]    Script Date: 5/13/2024 12:02:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ĐăngKí](
	[ID] [varchar](20) NULL,
	[Họ_tên] [varchar](100) NULL,
	[Ngày_tháng_năm_sinh] [varchar](100) NULL,
	[Giới_tính] [varchar](20) NULL,
	[Địa_chỉ_Email] [varchar](50) NULL,
	[Số_điện_thoại] [varchar](30) NULL,
	[Địa_chỉ] [varchar](200) NULL,
	[Ngày_đăng_kí] [varchar](50) NULL,
	[Tên_đăng_nhập] [varchar](100) NULL,
	[Mật_khẩu] [varchar](100) NULL,
	[Chức_vụ] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ĐánhGiá]    Script Date: 5/13/2024 12:02:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ĐánhGiá](
	[ID] [varchar](20) NULL,
	[Tên_người_dùng] [varchar](100) NULL,
	[Tên_sản_phẩm] [varchar](200) NULL,
	[Mã_sản_phẩm] [varchar](50) NULL,
	[Hình_ảnh] [varchar](300) NULL,
	[Viết_đánh_giá] [varchar](500) NULL,
	[Sao_đánh_giá] [varchar](30) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GiỏHàng]    Script Date: 5/13/2024 12:02:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GiỏHàng](
	[ID] [varchar](20) NULL,
	[Tên_mặt_hàng] [varchar](200) NULL,
	[Loại_mặt_hàng] [varchar](200) NULL,
	[Số_lượng] [varchar](50) NULL,
	[Hình_ảnh] [varchar](200) NULL,
	[Giá_cũ] [varchar](50) NULL,
	[Giá_mới] [varchar](50) NULL,
	[Số_lượng_chọn] [varchar](50) NULL,
	[Ngày_đăng_bán] [varchar](200) NULL,
	[Mã_sản_phẩm] [varchar](20) NULL,
	[Mã_kiểm_tra] [varchar](10) NULL,
	[Mã_Voucher] [varchar](20) NULL,
	[Giảm_giá] [varchar](20) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MuaHàng]    Script Date: 5/13/2024 12:02:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MuaHàng](
	[Số_điện_thoại] [varchar](20) NULL,
	[Địa_chỉ] [varchar](100) NULL,
	[Ngày_mua_hàng] [varchar](100) NULL,
	[ID] [varchar](20) NULL,
	[Tổng_thanh_toán] [varchar](50) NULL,
	[Mã_giao_dịch] [varchar](20) NULL,
	[Họ_tên] [varchar](200) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SảnPhẩm]    Script Date: 5/13/2024 12:02:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SảnPhẩm](
	[Tên_mặt_hàng] [varchar](100) NULL,
	[Mã_sản_phẩm] [varchar](20) NULL,
	[Lượt_xem] [varchar](20) NULL,
	[Yêu_thích] [varchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SựKiện]    Script Date: 5/13/2024 12:02:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SựKiện](
	[Tên_sự_kiện] [varchar](100) NULL,
	[Giảm_giá] [varchar](10) NULL,
	[Bắt_đầu] [varchar](50) NULL,
	[Kết_thúc] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ThanhToán]    Script Date: 5/13/2024 12:02:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThanhToán](
	[ID] [varchar](20) NULL,
	[Mã_sản_phẩm] [varchar](20) NULL,
	[Tên_mặt_hàng] [varchar](200) NULL,
	[Loại_mặt_hàng] [varchar](200) NULL,
	[Giá_mới] [varchar](100) NULL,
	[Hình_ảnh] [varchar](300) NULL,
	[Số_lượng_chọn] [varchar](50) NULL,
	[Mã_Voucher] [varchar](50) NULL,
	[Giảm_giá] [varchar](50) NULL,
	[Thành_tiền] [varchar](100) NULL
) ON [PRIMARY]
GO
INSERT [dbo].[ĐăngKí] ([ID], [Họ_tên], [Ngày_tháng_năm_sinh], [Giới_tính], [Địa_chỉ_Email], [Số_điện_thoại], [Địa_chỉ], [Ngày_đăng_kí], [Tên_đăng_nhập], [Mật_khẩu], [Chức_vụ]) VALUES (N'2ESOFMA', N'Nguyen Tuan Thanh', N'8/7/2004', N'Nam', N'tuanthanh07082004@gmail.com', N'0332967034', N'231 Le Van Chi Linh Trung Thu Duc', N'6/13/2024', N'tuanthanhAdmin', N'123456789', N'Quan tri vien')
INSERT [dbo].[ĐăngKí] ([ID], [Họ_tên], [Ngày_tháng_năm_sinh], [Giới_tính], [Địa_chỉ_Email], [Số_điện_thoại], [Địa_chỉ], [Ngày_đăng_kí], [Tên_đăng_nhập], [Mật_khẩu], [Chức_vụ]) VALUES (N'L5G0U6C', N'Nguyen Thi Khanh Huyen', N'8/6/2004', N'Nu', N'khanhhuyen0609@gmail.com', N'0326506807', N'thon 6 Loc Thanh  Bao Lam Lam Dong', N'6/14/2024', N'khanhhuyenTV', N'789456123', N'Thanh vien')
INSERT [dbo].[ĐăngKí] ([ID], [Họ_tên], [Ngày_tháng_năm_sinh], [Giới_tính], [Địa_chỉ_Email], [Số_điện_thoại], [Địa_chỉ], [Ngày_đăng_kí], [Tên_đăng_nhập], [Mật_khẩu], [Chức_vụ]) VALUES (N'H2FMREC', N'Tran Trinh Gia Bao', N'5/30/2004', N'Khac', N'baohip@gmail.com', N'0369258147', N'thon 3 Tan Lac Bao Lam Lam Dong', N'6/14/2024', N'baohipTV', N'789456123', N'Thanh vien')
INSERT [dbo].[ĐăngKí] ([ID], [Họ_tên], [Ngày_tháng_năm_sinh], [Giới_tính], [Địa_chỉ_Email], [Số_điện_thoại], [Địa_chỉ], [Ngày_đăng_kí], [Tên_đăng_nhập], [Mật_khẩu], [Chức_vụ]) VALUES (N'0QKYIM6', N'Tran Tien Dung', N'2/10/2004', N'Nam', N'tiendung@gmail.com', N'0369258148', N'Quan Long Bien Ha Noi', N'5/12/2024', N'tiendungTV', N'789456123', N'Thanh vien')
INSERT [dbo].[ĐăngKí] ([ID], [Họ_tên], [Ngày_tháng_năm_sinh], [Giới_tính], [Địa_chỉ_Email], [Số_điện_thoại], [Địa_chỉ], [Ngày_đăng_kí], [Tên_đăng_nhập], [Mật_khẩu], [Chức_vụ]) VALUES (N'VI37PI5', N'Nguyen Duc Toan', N'8/10/2004', N'Nam', N'ductoangk@gmail.com', N'0333444555', N'Thu Dau 1, Binh Duong', N'6/14/2024', N'ductoanTV', N'789456123', N'Thanh vien')
INSERT [dbo].[ĐăngKí] ([ID], [Họ_tên], [Ngày_tháng_năm_sinh], [Giới_tính], [Địa_chỉ_Email], [Số_điện_thoại], [Địa_chỉ], [Ngày_đăng_kí], [Tên_đăng_nhập], [Mật_khẩu], [Chức_vụ]) VALUES (N'0YPFS6Q', N'Vu Van Duc', N'8/3/2004', N'Nam', N'vanducss@gmail.com', N'0333444888', N'Quan 1 Tp Ho Chi Minh', N'6/22/2024', N'vanducTV', N'789456123', N'Thanh vien')
GO
