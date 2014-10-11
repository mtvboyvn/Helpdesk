USE [HelpDesk]
GO

/****** Object:  Table [dbo].[CAUHOI]    Script Date: 10/11/2014 10:40:35 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[CAUHOI](
	[CH_ID] [int] NOT NULL,
	[CH_GROUPID] [int] NULL,
	[CH_DOITUONGHOI] [nvarchar](255) NULL,
	[CH_DONVI_MST] [nvarchar](255) NULL,
	[CH_DONVI_TEN] [nvarchar](500) NULL,
	[CH_DONVI_DIENTHOAI] [nvarchar](255) NULL,
	[CH_NGUOIHOI_TAIKHOAN] [nvarchar](255) NULL,
	[CH_NGUOIHOI_TEN] [nvarchar](255) NULL,
	[CH_NGUOIHOI_DIENTHOAI] [nvarchar](255) NULL,
	[CH_NGUOIHOI_EMAIL] [nvarchar](255) NULL,
	[CH_NGUOIHOI_MAHQLIENQUAN] [nvarchar](255) NULL,
	[CH_NGUOIHOI_TENHQLIENQUAN] [nvarchar](255) NULL,
	[CH_CAUHOI_PHANLOAI] [nvarchar](255) NULL,
	[CH_CAUHOI_NOIDUNGCAUHOI] [nvarchar](4000) NULL,
	[CH_CAUHOI_NGAYHOI] [date] NULL,
	[CH_CAUHOI_NOIDUNGTRALOI] [nvarchar](4000) NULL,
	[CH_CAUHOI_NGAYTRALOI] [date] NULL,
	[CH_NGUOITRALOI_TAIKHOAN] [nvarchar](255) NULL,
	[CH_NGUOITRALOI_TEN] [nvarchar](255) NULL,
	[CH_FULLTEXT_SEARCH] [ntext] NULL,
 CONSTRAINT [PK_CAUHOI] PRIMARY KEY CLUSTERED 
(
	[CH_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ID câu hỏi' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CAUHOI', @level2type=N'COLUMN',@level2name=N'CH_ID'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'GROUP xác định nhóm câu hỏi liên quan với nhau, có thể để xem theo thread được' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CAUHOI', @level2type=N'COLUMN',@level2name=N'CH_GROUPID'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Đối tượng hỏi: Hải quan, Doanh Nghiệp' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CAUHOI', @level2type=N'COLUMN',@level2name=N'CH_DOITUONGHOI'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Mã số thuế đơn vị' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CAUHOI', @level2type=N'COLUMN',@level2name=N'CH_DONVI_MST'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Tên đơn vị' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CAUHOI', @level2type=N'COLUMN',@level2name=N'CH_DONVI_TEN'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Điện thoại đơn vị' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CAUHOI', @level2type=N'COLUMN',@level2name=N'CH_DONVI_DIENTHOAI'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Tài khoản người hỏi' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CAUHOI', @level2type=N'COLUMN',@level2name=N'CH_NGUOIHOI_TAIKHOAN'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Tên người hỏi' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CAUHOI', @level2type=N'COLUMN',@level2name=N'CH_NGUOIHOI_TEN'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Điện thoại người hỏi' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CAUHOI', @level2type=N'COLUMN',@level2name=N'CH_NGUOIHOI_DIENTHOAI'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Email người hỏi' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CAUHOI', @level2type=N'COLUMN',@level2name=N'CH_NGUOIHOI_EMAIL'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Mã Hải quan liên quan người hỏi' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CAUHOI', @level2type=N'COLUMN',@level2name=N'CH_NGUOIHOI_MAHQLIENQUAN'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Phân loại câu hỏi' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CAUHOI', @level2type=N'COLUMN',@level2name=N'CH_CAUHOI_PHANLOAI'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Nội dung câu hỏi' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CAUHOI', @level2type=N'COLUMN',@level2name=N'CH_CAUHOI_NOIDUNGCAUHOI'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Ngày hỏi' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CAUHOI', @level2type=N'COLUMN',@level2name=N'CH_CAUHOI_NGAYHOI'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Nội dung câu trả lời' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CAUHOI', @level2type=N'COLUMN',@level2name=N'CH_CAUHOI_NOIDUNGTRALOI'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Ngày trả lời' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CAUHOI', @level2type=N'COLUMN',@level2name=N'CH_CAUHOI_NGAYTRALOI'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Tài khoản người trả lời' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CAUHOI', @level2type=N'COLUMN',@level2name=N'CH_NGUOITRALOI_TAIKHOAN'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Tên người trả lời' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CAUHOI', @level2type=N'COLUMN',@level2name=N'CH_NGUOITRALOI_TEN'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Trường dữ liệu dùng để tìm kiếm, là nội dung ghép của tất cả các trường bên trên, bao gồm cả nội dung có dấu và nội dung không dấu để tìm kiếm tiếng việt không dấu' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CAUHOI', @level2type=N'COLUMN',@level2name=N'CH_FULLTEXT_SEARCH'
GO


