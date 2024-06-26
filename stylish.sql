CREATE DATABASE stylish
USE [stylish]
GO
/****** Object:  Schema [stylish]    Script Date: 2024/4/22 下午 09:19:20 ******/
CREATE SCHEMA [stylish]
GO
/****** Object:  Table [stylish].[campaign]    Script Date: 2024/4/22 下午 09:19:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [stylish].[campaign](
	[product_id] [bigint] NOT NULL,
	[picture] [nvarchar](255) NULL,
	[story] [nvarchar](255) NULL,
 CONSTRAINT [PK_campaign_product_id] PRIMARY KEY CLUSTERED 
(
	[product_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [stylish].[hots]    Script Date: 2024/4/22 下午 09:19:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [stylish].[hots](
	[title] [nvarchar](255) NOT NULL,
	[products] [nvarchar](max) NULL,
 CONSTRAINT [PK_hots_title] PRIMARY KEY CLUSTERED 
(
	[title] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [stylish].[orders]    Script Date: 2024/4/22 下午 09:19:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [stylish].[orders](
	[user_id] [int] NULL,
	[time] [nvarchar](255) NULL,
	[total] [int] NULL,
	[user_orders] [nvarchar](255) NULL,
	[order_id] [int] IDENTITY(1,1) NOT NULL,
	[pay_orders] [nvarchar](255) NULL,
	[payment] [nvarchar](255) NULL,
	[shipping] [nvarchar](255) NULL,
	[pay] [smallint] NULL,
	[order_products] [nvarchar](255) NULL,
	[user] [nvarchar](255) NULL,
	[last_four] [nvarchar](45) NULL,
 CONSTRAINT [PK_orders_order_id] PRIMARY KEY CLUSTERED 
(
	[order_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [stylish].[otherimages]    Script Date: 2024/4/22 下午 09:19:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [stylish].[otherimages](
	[images_url] [nvarchar](255) NULL,
	[id] [bigint] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [stylish].[product]    Script Date: 2024/4/22 下午 09:19:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [stylish].[product](
	[id] [bigint] IDENTITY(7375395917593195,1) NOT NULL,
	[title] [nvarchar](255) NOT NULL,
	[description] [nvarchar](255) NULL,
	[price] [int] NULL,
	[texture] [nvarchar](255) NULL,
	[wash] [nvarchar](45) NULL,
	[place] [nvarchar](45) NULL,
	[note] [nvarchar](255) NULL,
	[story] [nvarchar](255) NULL,
	[main_image] [nvarchar](255) NULL,
	[category] [nvarchar](255) NULL,
 CONSTRAINT [PK_product_id] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [stylish].[user]    Script Date: 2024/4/22 下午 09:19:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [stylish].[user](
	[id] [int] IDENTITY(58,1) NOT NULL,
	[provider] [nvarchar](255) NULL,
	[name] [nvarchar](255) NULL,
	[email] [nvarchar](255) NULL,
	[picture] [nvarchar](255) NULL,
	[password] [nvarchar](255) NULL,
 CONSTRAINT [PK_user_id] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [stylish].[variant]    Script Date: 2024/4/22 下午 09:19:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [stylish].[variant](
	[color_code] [nvarchar](255) NULL,
	[size] [nvarchar](45) NULL,
	[stock] [int] NULL,
	[id] [bigint] NULL,
	[color_name] [nvarchar](255) NULL
) ON [PRIMARY]
GO
INSERT [stylish].[campaign] ([product_id], [picture], [story]) VALUES (201807202140, N'/img/campain_201807202140.jpg', N'瞬間
在城市的角落
找到失落多時的記憶。
印象《都會故事集》')
INSERT [stylish].[campaign] ([product_id], [picture], [story]) VALUES (201807242222, N'/img/campain_201807242222.jpg', N'永遠
展現自信與專業
無法抵擋的男人魅力。
復古《再一次經典》')
INSERT [stylish].[campaign] ([product_id], [picture], [story]) VALUES (201807242228, N'/img/campain_201807242228.jpg', N'於是
我也想要給你
一個那麼美好的自己。
不朽《與自己和好如初》')
GO
INSERT [stylish].[otherimages] ([images_url], [id]) VALUES (N'https://d38p3ocem7m9yt.cloudfront.net/products/201807201824/other_images-0.jpg', 201807201824)
INSERT [stylish].[otherimages] ([images_url], [id]) VALUES (N'https://d38p3ocem7m9yt.cloudfront.net/products/201807201824/other_images-1.jpg', 201807201824)
INSERT [stylish].[otherimages] ([images_url], [id]) VALUES (N'https://d38p3ocem7m9yt.cloudfront.net/products/201807202140/other_images-0.jpg', 201807202140)
INSERT [stylish].[otherimages] ([images_url], [id]) VALUES (N'https://d38p3ocem7m9yt.cloudfront.net/products/201807202140/other_images-1.jpg', 201807202140)
INSERT [stylish].[otherimages] ([images_url], [id]) VALUES (N'https://d38p3ocem7m9yt.cloudfront.net/products/201807202150/other_images-0.jpg', 201807202150)
INSERT [stylish].[otherimages] ([images_url], [id]) VALUES (N'https://d38p3ocem7m9yt.cloudfront.net/products/201807202150/other_images-1.jpg', 201807202150)
INSERT [stylish].[otherimages] ([images_url], [id]) VALUES (N'https://d38p3ocem7m9yt.cloudfront.net/products/201807202157/other_images-0.jpg', 201807202157)
INSERT [stylish].[otherimages] ([images_url], [id]) VALUES (N'https://d38p3ocem7m9yt.cloudfront.net/products/201807202157/other_images-1.jpg', 201807202157)
INSERT [stylish].[otherimages] ([images_url], [id]) VALUES (N'https://d38p3ocem7m9yt.cloudfront.net/products/201807242211/other_images-0.jpg', 201807242211)
INSERT [stylish].[otherimages] ([images_url], [id]) VALUES (N'https://d38p3ocem7m9yt.cloudfront.net/products/201807242211/other_images-1.jpg', 201807242211)
INSERT [stylish].[otherimages] ([images_url], [id]) VALUES (N'https://d38p3ocem7m9yt.cloudfront.net/products/201807242216/other_images-0.jpg', 201807242216)
INSERT [stylish].[otherimages] ([images_url], [id]) VALUES (N'https://d38p3ocem7m9yt.cloudfront.net/products/201807242216/other_images-1.jpg', 201807242216)
INSERT [stylish].[otherimages] ([images_url], [id]) VALUES (N'https://d38p3ocem7m9yt.cloudfront.net/products/201807242222/other_images-0.jpg', 201807242222)
INSERT [stylish].[otherimages] ([images_url], [id]) VALUES (N'https://d38p3ocem7m9yt.cloudfront.net/products/201807242222/other_images-1.jpg', 201807242222)
INSERT [stylish].[otherimages] ([images_url], [id]) VALUES (N'https://d38p3ocem7m9yt.cloudfront.net/products/201807242228/other_images-0.jpg', 201807242228)
INSERT [stylish].[otherimages] ([images_url], [id]) VALUES (N'https://d38p3ocem7m9yt.cloudfront.net/products/201807242228/other_images-1.jpg', 201807242228)
INSERT [stylish].[otherimages] ([images_url], [id]) VALUES (N'https://d38p3ocem7m9yt.cloudfront.net/products/201807242230/other_images-0.jpg', 201807242230)
INSERT [stylish].[otherimages] ([images_url], [id]) VALUES (N'https://d38p3ocem7m9yt.cloudfront.net/products/201807242230/other_images-1.jpg', 201807242230)
INSERT [stylish].[otherimages] ([images_url], [id]) VALUES (N'https://d38p3ocem7m9yt.cloudfront.net/products/201807242232/other_images-0.jpg', 201807242232)
INSERT [stylish].[otherimages] ([images_url], [id]) VALUES (N'https://d38p3ocem7m9yt.cloudfront.net/products/201807242232/other_images-1.jpg', 201807242232)
INSERT [stylish].[otherimages] ([images_url], [id]) VALUES (N'https://d38p3ocem7m9yt.cloudfront.net/products/201807242234/other_images-0.jpg', 201807242234)
INSERT [stylish].[otherimages] ([images_url], [id]) VALUES (N'https://d38p3ocem7m9yt.cloudfront.net/products/201807242234/other_images-1.jpg', 201807242234)
INSERT [stylish].[otherimages] ([images_url], [id]) VALUES (N'https://d38p3ocem7m9yt.cloudfront.net/products/201902191210/other_images-0.jpg', 201902191210)
INSERT [stylish].[otherimages] ([images_url], [id]) VALUES (N'https://d38p3ocem7m9yt.cloudfront.net/products/201902191210/other_images-1.jpg', 201902191210)
GO
SET IDENTITY_INSERT [stylish].[product] ON 

INSERT [stylish].[product] ([id], [title], [description], [price], [texture], [wash], [place], [note], [story], [main_image], [category]) VALUES (201807201824, N'前開衩扭結洋裝', N'厚薄：薄\r\n彈性：無', 799, N'棉 100%', N'手洗，溫水', N'中國', N'實品顏色依單品照為主', N'O.N.S is all about options, which is why we took our staple polo shirt and upgraded it with slubby linen jersey, making it even lighter for those who prefer their summer style extra-breezy.', N'https://d38p3ocem7m9yt.cloudfront.net/products/201807201824/main_image.jpg', N'women')
INSERT [stylish].[product] ([id], [title], [description], [price], [texture], [wash], [place], [note], [story], [main_image], [category]) VALUES (201807202140, N'透肌澎澎防曬襯衫', N'厚薄：薄\r\n彈性：無', 599, N'棉 100%', N'手洗，溫水', N'中國', N'實品顏色依單品照為主', N'O.N.S is all about options, which is why we took our staple polo shirt and upgraded it with slubby linen jersey, making it even lighter for those who prefer their summer style extra-breezy.', N'https://d38p3ocem7m9yt.cloudfront.net/products/201807202140/main_image.jpg', N'women')
INSERT [stylish].[product] ([id], [title], [description], [price], [texture], [wash], [place], [note], [story], [main_image], [category]) VALUES (201807202150, N' 小扇紋細織上衣', N'厚薄：薄\r\n彈性：無', 599, N'棉 100%', N'手洗，溫水', N'中國', N'實品顏色依單品照為主', N'O.N.S is all about options, which is why we took our staple polo shirt and upgraded it with slubby linen jersey, making it even lighter for those who prefer their summer style extra-breezy.', N'https://d38p3ocem7m9yt.cloudfront.net/products/201807202150/main_image.jpg', N'women')
INSERT [stylish].[product] ([id], [title], [description], [price], [texture], [wash], [place], [note], [story], [main_image], [category]) VALUES (201807202157, N' 活力花紋長筒牛仔褲', N'厚薄：薄\r\n彈性：無', 1299, N'棉 100%', N'手洗，溫水', N'中國', N'實品顏色依單品照為主', N'O.N.S is all about options, which is why we took our staple polo shirt and upgraded it with slubby linen jersey, making it even lighter for those who prefer their summer style extra-breezy.', N'https://d38p3ocem7m9yt.cloudfront.net/products/201807202157/main_image.jpg', N'women')
INSERT [stylish].[product] ([id], [title], [description], [price], [texture], [wash], [place], [note], [story], [main_image], [category]) VALUES (201807242211, N' 純色輕薄百搭襯衫', N'厚薄：薄\r\n彈性：無', 799, N'棉 100%', N'手洗，溫水', N'中國', N'實品顏色依單品照為主', N'O.N.S is all about options, which is why we took our staple polo shirt and upgraded it with slubby linen jersey, making it even lighter for those who prefer their summer style extra-breezy.', N'https://d38p3ocem7m9yt.cloudfront.net/products/201807242211/main_image.jp', N'men')
INSERT [stylish].[product] ([id], [title], [description], [price], [texture], [wash], [place], [note], [story], [main_image], [category]) VALUES (201807242216, N'時尚輕鬆休閒西裝', N'厚薄：薄\r\n彈性：無', 2399, N'棉 100%', N'手洗，溫水', N'中國', N'實品顏色依單品照為主', N'O.N.S is all about options, which is why we took our staple polo shirt and upgraded it with slubby linen jersey, making it even lighter for those who prefer their summer style extra-breezy.', N'https://d38p3ocem7m9yt.cloudfront.net/products/201807242216/main_image.jpg', N'men')
INSERT [stylish].[product] ([id], [title], [description], [price], [texture], [wash], [place], [note], [story], [main_image], [category]) VALUES (201807242222, N'經典商務西裝', N'厚薄：薄\r\n彈性：無', 3999, N'棉 100%', N'手洗，溫水', N'中國', N'實品顏色依單品照為主', N'O.N.S is all about options, which is why we took our staple polo shirt and upgraded it with slubby linen jersey, making it even lighter for those who prefer their summer style extra-breezy.', N'https://d38p3ocem7m9yt.cloudfront.net/products/201807242222/main_image.jpg', N'men')
INSERT [stylish].[product] ([id], [title], [description], [price], [texture], [wash], [place], [note], [story], [main_image], [category]) VALUES (201807242228, N'夏日海灘戶外遮陽帽', N'厚薄：薄\r\n彈性：無', 1499, N'棉 100%', N'手洗，溫水', N'中國', N'實品顏色依單品照為主', N'O.N.S is all about options, which is why we took our staple polo shirt and upgraded it with slubby linen jersey, making it even lighter for those who prefer their summer style extra-breezy.', N'https://d38p3ocem7m9yt.cloudfront.net/products/201807242228/main_image.jpg', N'accessories')
INSERT [stylish].[product] ([id], [title], [description], [price], [texture], [wash], [place], [note], [story], [main_image], [category]) VALUES (201807242230, N'經典牛仔帽', N'厚薄：薄\r\n彈性：無', 799, N'棉 100%', N'手洗，溫水', N'中國', N'實品顏色依單品照為主', N'O.N.S is all about options, which is why we took our staple polo shirt and upgraded it with slubby linen jersey, making it even lighter for those who prefer their summer style extra-breezy.', N'https://d38p3ocem7m9yt.cloudfront.net/products/201807242230/main_image.jpg', N'accessories')
INSERT [stylish].[product] ([id], [title], [description], [price], [texture], [wash], [place], [note], [story], [main_image], [category]) VALUES (201807242232, N'卡哇伊多功能隨身包', N'厚薄：薄\r\n彈性：無', 1299, N'牛皮', N'手洗，溫水', N'中國', N'實品顏色依單品照為主', N'O.N.S is all about options, which is why we took our staple polo shirt and upgraded it with slubby linen jersey, making it even lighter for those who prefer their summer style extra-breezy.', N'https://d38p3ocem7m9yt.cloudfront.net/products/201807242232/main_image.jpg', N'accessories')
INSERT [stylish].[product] ([id], [title], [description], [price], [texture], [wash], [place], [note], [story], [main_image], [category]) VALUES (201807242234, N'柔軟氣質羊毛圍巾', N'厚薄：薄\r\n彈性：無', 1799, N'羊毛', N'乾洗', N'英國', N'實品顏色依單品照為主', N'O.N.S is all about options, which is why we took our staple polo shirt and upgraded it with slubby linen jersey, making it even lighter for those who prefer their summer style extra-breezy.', N'https://d38p3ocem7m9yt.cloudfront.net/products/201807242234/main_image.jpg', N'accessories')
INSERT [stylish].[product] ([id], [title], [description], [price], [texture], [wash], [place], [note], [story], [main_image], [category]) VALUES (201902191210, N'精緻扭結洋裝', N'厚薄：薄\r\n彈性：無', 999, N'棉 100%', N'手洗', N'越南', N'實品顏色依單品照為主', N'O.N.S is all about options, which is why we took our staple polo shirt and upgraded it with slubby linen jersey, making it even lighter for those who prefer their summer style extra-breezy.', N'https://d38p3ocem7m9yt.cloudfront.net/products/201902191210/main_image.jpg', N'women')
INSERT [stylish].[product] ([id], [title], [description], [price], [texture], [wash], [place], [note], [story], [main_image], [category]) VALUES (201902191242, N'透肌澎澎薄紗襯衫', N'厚薄：薄\r\n彈性：無', 999, N'棉 100%', N'手洗', N'越南', N'實品顏色依單品照為主', N'O.N.S is all about options, which is why we took our staple polo shirt and upgraded it with slubby linen jersey, making it even lighter for those who prefer their summer style extra-breezy.', N'products/201902191242_main.jpg', N'women')
INSERT [stylish].[product] ([id], [title], [description], [price], [texture], [wash], [place], [note], [story], [main_image], [category]) VALUES (201902191245, N'小扇紋質感上衣', N'厚薄：薄\r\n彈性：無', 999, N'棉 100%', N'手洗', N'越南', N'實品顏色依單品照為主', N'O.N.S is all about options, which is why we took our staple polo shirt and upgraded it with slubby linen jersey, making it even lighter for those who prefer their summer style extra-breezy.', N'products/201902191245_main.jpg', N'women')
INSERT [stylish].[product] ([id], [title], [description], [price], [texture], [wash], [place], [note], [story], [main_image], [category]) VALUES (201902191247, N'經典修身長筒牛仔褲', N'厚薄：薄\r\n彈性：無', 1999, N'棉 100%', N'手洗', N'越南', N'實品顏色依單品照為主', N'O.N.S is all about options, which is why we took our staple polo shirt and upgraded it with slubby linen jersey, making it even lighter for those who prefer their summer style extra-breezy.', N'products/201902191247_main.jpg', N'women')
SET IDENTITY_INSERT [stylish].[product] OFF
GO
SET IDENTITY_INSERT [stylish].[user] ON 

INSERT [stylish].[user] ([id], [provider], [name], [email], [picture], [password]) VALUES (38, N'facebook', N'test', N'test@gmail.com', N'http', N'90e2cd6afaf9cdef6eb243188c6d09247658dfc06feb2ca784c67a4220bbd4e4')
INSERT [stylish].[user] ([id], [provider], [name], [email], [picture], [password]) VALUES (39, N'native', N'test', N'test2@gmail.com', N'http', N'90e2cd6afaf9cdef6eb243188c6d09247658dfc06feb2ca784c67a4220bbd4e4')
INSERT [stylish].[user] ([id], [provider], [name], [email], [picture], [password]) VALUES (40, N'facebook', N'Open Graph Test User', N'open_ezpvakg_user@tfbnw.net', N'http', N'90e2cd6afaf9cdef6eb243188c6d09247658dfc06feb2ca784c67a4220bbd4e4')
INSERT [stylish].[user] ([id], [provider], [name], [email], [picture], [password]) VALUES (41, N'native', N'Open Graph Test User', N'test3@gmail.com', N'http', N'90e2cd6afaf9cdef6eb243188c6d09247658dfc06feb2ca784c67a4220bbd4e4')
INSERT [stylish].[user] ([id], [provider], [name], [email], [picture], [password]) VALUES (44, N'native', N'18286', N'222@37469', N'http', N'76b38eac12212bcd7fa20412c058c39d98e6f0a098b9113e3f2763c7629a4c3a')
INSERT [stylish].[user] ([id], [provider], [name], [email], [picture], [password]) VALUES (45, N'native', N'hihi ', N'ash@klck', N'http', N'c8ebeaba9f4007544e7e99d7e82419796b4ad269b60688d1377a715d656e8c18')
INSERT [stylish].[user] ([id], [provider], [name], [email], [picture], [password]) VALUES (46, N'native', N'233', N'22@wwe', N'http', N'06d9f7d61e2aa01b4cfa08f1b3f3f2c157d715038bb3b78ccca04e9e11c0ea2f')
INSERT [stylish].[user] ([id], [provider], [name], [email], [picture], [password]) VALUES (47, N'native', N'wwd', N'12@233', N'http', N'90e2cd6afaf9cdef6eb243188c6d09247658dfc06feb2ca784c67a4220bbd4e4')
INSERT [stylish].[user] ([id], [provider], [name], [email], [picture], [password]) VALUES (48, N'native', N'www', N'wuuofu@186383', N'http', N'03b8866878bc75bb7766aca3d0b3b760084c6cde57fa281e3789b50a8f060481')
INSERT [stylish].[user] ([id], [provider], [name], [email], [picture], [password]) VALUES (49, N'native', N'ss', N'ww@3ewf', N'http', N'fa947b79a53bfe756cadc213a1057b2c58aaedaa06148071c66d5257bd29935f')
INSERT [stylish].[user] ([id], [provider], [name], [email], [picture], [password]) VALUES (50, N'native', N'24', N'2dwsf@1313', N'http', N'8039ca309b682ac27cf03b044734c16a22320e22f638a5bc0503e6afcd70c897')
INSERT [stylish].[user] ([id], [provider], [name], [email], [picture], [password]) VALUES (51, N'native', N'23f2v', N'2rr3@rsggs', N'http', N'a42a431fe77d0458a935a9592ca9b418dcd7dfb148b3b01da0498e990822e36e')
INSERT [stylish].[user] ([id], [provider], [name], [email], [picture], [password]) VALUES (52, N'native', N'gjkgiugi897', N'agsg@cncj', N'http', N'2838b63493d9cb47276551aaa0f931a1ac3d94f630791057fd5fa6d3c6c893ff')
INSERT [stylish].[user] ([id], [provider], [name], [email], [picture], [password]) VALUES (53, N'native', N'hE', N'test5@123', NULL, N'90e2cd6afaf9cdef6eb243188c6d09247658dfc06feb2ca784c67a4220bbd4e4')
INSERT [stylish].[user] ([id], [provider], [name], [email], [picture], [password]) VALUES (54, N'native', N'大帥哥', N'test6@123', N'', N'90e2cd6afaf9cdef6eb243188c6d09247658dfc06feb2ca784c67a4220bbd4e4')
INSERT [stylish].[user] ([id], [provider], [name], [email], [picture], [password]) VALUES (55, N'native', N'帥哥二號', N'test7@123', N'', N'90e2cd6afaf9cdef6eb243188c6d09247658dfc06feb2ca784c67a4220bbd4e4')
INSERT [stylish].[user] ([id], [provider], [name], [email], [picture], [password]) VALUES (56, N'native', N'大帥哥', N'test8@123', N'', N'90e2cd6afaf9cdef6eb243188c6d09247658dfc06feb2ca784c67a4220bbd4e4')
INSERT [stylish].[user] ([id], [provider], [name], [email], [picture], [password]) VALUES (57, N'facebook', N'陳胤錡', N'ashin1207@gmail.com', N'', N'')
SET IDENTITY_INSERT [stylish].[user] OFF
GO
INSERT [stylish].[variant] ([color_code], [size], [stock], [id], [color_name]) VALUES (N'FFDDDD', N'L', 6, 201902191242, N'粉紅')
INSERT [stylish].[variant] ([color_code], [size], [stock], [id], [color_name]) VALUES (N'FFFFFF', N'L', 12, 201902191242, N'白色')
INSERT [stylish].[variant] ([color_code], [size], [stock], [id], [color_name]) VALUES (N'FFFFFF', N'XL', 10, 201902191242, N'白色')
INSERT [stylish].[variant] ([color_code], [size], [stock], [id], [color_name]) VALUES (N'FFFFFF', N'L', 10, 201902191243, N'白色')
INSERT [stylish].[variant] ([color_code], [size], [stock], [id], [color_name]) VALUES (N'FFFFFF', N'L', 13, 201902191244, N'白色')
INSERT [stylish].[variant] ([color_code], [size], [stock], [id], [color_name]) VALUES (N'FFFFFF', N'L', 15, 201902191245, N'白色')
INSERT [stylish].[variant] ([color_code], [size], [stock], [id], [color_name]) VALUES (N'FFFFFF', N'L', 15, 201902191246, N'白色')
INSERT [stylish].[variant] ([color_code], [size], [stock], [id], [color_name]) VALUES (N'FFFFFF', N'S', 15, 201902191247, N'白色')
INSERT [stylish].[variant] ([color_code], [size], [stock], [id], [color_name]) VALUES (N'FFFFFF', N'S', 15, 201902191248, N'白色')
INSERT [stylish].[variant] ([color_code], [size], [stock], [id], [color_name]) VALUES (N'FFFFFF', N'S', 25, 201902191249, N'白色')
INSERT [stylish].[variant] ([color_code], [size], [stock], [id], [color_name]) VALUES (N'FFFFFF', N'S', 5, 201902191250, N'白色')
INSERT [stylish].[variant] ([color_code], [size], [stock], [id], [color_name]) VALUES (N'334455', N'S', 3, 201807242222, N'深藍')
INSERT [stylish].[variant] ([color_code], [size], [stock], [id], [color_name]) VALUES (N'334455', N'M', 5, 201807242222, N'深藍')
INSERT [stylish].[variant] ([color_code], [size], [stock], [id], [color_name]) VALUES (N'334455', N'L', 6, 201807242222, N'深藍')
INSERT [stylish].[variant] ([color_code], [size], [stock], [id], [color_name]) VALUES (N'334455', N'L', 6, 201807242223, N'深藍')
INSERT [stylish].[variant] ([color_code], [size], [stock], [id], [color_name]) VALUES (N'334455', N'L', 6, 201807242224, N'深藍')
INSERT [stylish].[variant] ([color_code], [size], [stock], [id], [color_name]) VALUES (N'334455', N'L', 6, 201807242225, N'深藍')
INSERT [stylish].[variant] ([color_code], [size], [stock], [id], [color_name]) VALUES (N'334455', N'L', 6, 201807242226, N'深藍')
INSERT [stylish].[variant] ([color_code], [size], [stock], [id], [color_name]) VALUES (N'334455', N'L', 6, 201807242227, N'深藍')
INSERT [stylish].[variant] ([color_code], [size], [stock], [id], [color_name]) VALUES (N'334455', N'L', 6, 201807242228, N'深藍')
INSERT [stylish].[variant] ([color_code], [size], [stock], [id], [color_name]) VALUES (N'334455', N'L', 6, 201807242229, N'深藍')
INSERT [stylish].[variant] ([color_code], [size], [stock], [id], [color_name]) VALUES (N'FFFFFF', N'S', 3, 201807242231, N'白色')
INSERT [stylish].[variant] ([color_code], [size], [stock], [id], [color_name]) VALUES (N'FFFFFF', N'S', 33, 12382, N'白色')
INSERT [stylish].[variant] ([color_code], [size], [stock], [id], [color_name]) VALUES (N'FFFFFF', N'S', 333, 12333, N'白色')
INSERT [stylish].[variant] ([color_code], [size], [stock], [id], [color_name]) VALUES (N'FFFFFF', N'L', 30, 201807242290, N'白色')
INSERT [stylish].[variant] ([color_code], [size], [stock], [id], [color_name]) VALUES (N'FFDDDD', N'L', 30, 201807242291, N'粉紅')
INSERT [stylish].[variant] ([color_code], [size], [stock], [id], [color_name]) VALUES (N'FFDDDD', N'M', 30, 201807242291, N'粉紅')
INSERT [stylish].[variant] ([color_code], [size], [stock], [id], [color_name]) VALUES (N'FFDDDD', N'M', 30, 201807242292, N'粉紅')
INSERT [stylish].[variant] ([color_code], [size], [stock], [id], [color_name]) VALUES (N'FFDDDD', N'M', 30, 201807242293, N'粉紅')
INSERT [stylish].[variant] ([color_code], [size], [stock], [id], [color_name]) VALUES (N'FFDDDD', N'M', 30, 201807242294, N'粉紅')
INSERT [stylish].[variant] ([color_code], [size], [stock], [id], [color_name]) VALUES (N'FFDDDD', N'M', 30, 201807242295, N'粉紅')
INSERT [stylish].[variant] ([color_code], [size], [stock], [id], [color_name]) VALUES (N'FFDDDD', N'M', 30, 201807242296, N'粉紅')
INSERT [stylish].[variant] ([color_code], [size], [stock], [id], [color_name]) VALUES (N'FFDDDD', N'M', 30, 201807242298, N'粉紅')
INSERT [stylish].[variant] ([color_code], [size], [stock], [id], [color_name]) VALUES (N'FFDDDD', N'M', 30, 201807242299, N'粉紅')
INSERT [stylish].[variant] ([color_code], [size], [stock], [id], [color_name]) VALUES (N'FFDDDD', N'M', 30, 201807242300, N'粉紅')
INSERT [stylish].[variant] ([color_code], [size], [stock], [id], [color_name]) VALUES (N'FFDDDD', N'S', 30, 201807242301, N'粉紅')
INSERT [stylish].[variant] ([color_code], [size], [stock], [id], [color_name]) VALUES (N'FFFFFF', N'S', 23, 2222222, N'亮綠')
INSERT [stylish].[variant] ([color_code], [size], [stock], [id], [color_name]) VALUES (N'DDF0FF', N'S', 23, 2222222, N'淺藍')
INSERT [stylish].[variant] ([color_code], [size], [stock], [id], [color_name]) VALUES (N'334455', N'S', 25, 2222222, N'深藍')
INSERT [stylish].[variant] ([color_code], [size], [stock], [id], [color_name]) VALUES (N'FFDDDD', N'S', 24, 2222225, N'粉紅')
INSERT [stylish].[variant] ([color_code], [size], [stock], [id], [color_name]) VALUES (N'FFDDDD', N'L', 24, 2222225, N'粉紅')
INSERT [stylish].[variant] ([color_code], [size], [stock], [id], [color_name]) VALUES (N'FFFFFF', N'S', 233, 12382, N'白色')
INSERT [stylish].[variant] ([color_code], [size], [stock], [id], [color_name]) VALUES (N'FFFFFF', N'L', 233, 12382, N'白色')
INSERT [stylish].[variant] ([color_code], [size], [stock], [id], [color_name]) VALUES (N'FFFFFF', N'S', 23, 2222225, N'白色')
INSERT [stylish].[variant] ([color_code], [size], [stock], [id], [color_name]) VALUES (N'FFFFFF', N'S', 87, 2222225, N'白色')
INSERT [stylish].[variant] ([color_code], [size], [stock], [id], [color_name]) VALUES (N'DDFFBB', N'S', 12, 201807202140, N'亮綠')
INSERT [stylish].[variant] ([color_code], [size], [stock], [id], [color_name]) VALUES (N'DDFFBB', N'M', 10, 201807202140, N'亮綠')
INSERT [stylish].[variant] ([color_code], [size], [stock], [id], [color_name]) VALUES (N'DDFFBB', N'L', 10, 201807202140, N'亮綠')
INSERT [stylish].[variant] ([color_code], [size], [stock], [id], [color_name]) VALUES (N'CCCCCC', N'S', 10, 201807202140, N'淺灰')
INSERT [stylish].[variant] ([color_code], [size], [stock], [id], [color_name]) VALUES (N'CCCCCC', N'M', 5, 201807202140, N'淺灰')
INSERT [stylish].[variant] ([color_code], [size], [stock], [id], [color_name]) VALUES (N'CCCCCC', N'L', 8, 201807202140, N'淺灰')
INSERT [stylish].[variant] ([color_code], [size], [stock], [id], [color_name]) VALUES (N'334455', N'S', 5, 201807242222, N'深藍')
INSERT [stylish].[variant] ([color_code], [size], [stock], [id], [color_name]) VALUES (N'334455', N'M', 3, 201807242222, N'深藍')
INSERT [stylish].[variant] ([color_code], [size], [stock], [id], [color_name]) VALUES (N'334455', N'L', 3, 201807242222, N'深藍')
INSERT [stylish].[variant] ([color_code], [size], [stock], [id], [color_name]) VALUES (N'334455', N'XL', 4, 201807242222, N'深藍')
INSERT [stylish].[variant] ([color_code], [size], [stock], [id], [color_name]) VALUES (N'DDF0FF', N'M', 3, 201807242228, N'淺藍')
INSERT [stylish].[variant] ([color_code], [size], [stock], [id], [color_name]) VALUES (N'DDF0FF', N'L', 2, 201807242228, N'淺藍')
INSERT [stylish].[variant] ([color_code], [size], [stock], [id], [color_name]) VALUES (N'FFFFFF', N'S', 2, 201807201824, N'白色')
INSERT [stylish].[variant] ([color_code], [size], [stock], [id], [color_name]) VALUES (N'FFFFFF', N'M', 2, 201807201824, N'白色')
INSERT [stylish].[variant] ([color_code], [size], [stock], [id], [color_name]) VALUES (N'FFFFFF', N'L', 2, 201807201824, N'白色')
INSERT [stylish].[variant] ([color_code], [size], [stock], [id], [color_name]) VALUES (N'DDFFBB', N'S', 2, 201807201824, N'亮綠')
INSERT [stylish].[variant] ([color_code], [size], [stock], [id], [color_name]) VALUES (N'DDFFBB', N'L', 2, 201807201824, N'亮綠')
INSERT [stylish].[variant] ([color_code], [size], [stock], [id], [color_name]) VALUES (N'CCCCCC', N'L', 2, 201807201824, N'淺灰')
INSERT [stylish].[variant] ([color_code], [size], [stock], [id], [color_name]) VALUES (N'DDFFBB', N'S', 2, 201807202150, N'亮綠')
INSERT [stylish].[variant] ([color_code], [size], [stock], [id], [color_name]) VALUES (N'DDFFBB', N'M', 2, 201807202150, N'亮綠')
INSERT [stylish].[variant] ([color_code], [size], [stock], [id], [color_name]) VALUES (N'CCCCCC', N'M', 7, 201807202150, N'淺灰')
INSERT [stylish].[variant] ([color_code], [size], [stock], [id], [color_name]) VALUES (N'CCCCCC', N'S', 7, 201807202150, N'淺灰')
INSERT [stylish].[variant] ([color_code], [size], [stock], [id], [color_name]) VALUES (N'BB7744', N'S', 7, 201807202150, N'淺棕')
INSERT [stylish].[variant] ([color_code], [size], [stock], [id], [color_name]) VALUES (N'BB7744', N'M', 7, 201807202150, N'淺棕')
INSERT [stylish].[variant] ([color_code], [size], [stock], [id], [color_name]) VALUES (N'DDF0FF', N'S', 3, 201807202157, N'淺藍')
INSERT [stylish].[variant] ([color_code], [size], [stock], [id], [color_name]) VALUES (N'DDF0FF', N'M', 3, 201807202157, N'淺藍')
INSERT [stylish].[variant] ([color_code], [size], [stock], [id], [color_name]) VALUES (N'DDF0FF', N'L', 34, 201807202157, N'淺藍')
INSERT [stylish].[variant] ([color_code], [size], [stock], [id], [color_name]) VALUES (N'334455', N'M', 3, 201807202157, N'深藍')
INSERT [stylish].[variant] ([color_code], [size], [stock], [id], [color_name]) VALUES (N'CCCCCC', N'S', 23, 201807202157, N'淺灰')
INSERT [stylish].[variant] ([color_code], [size], [stock], [id], [color_name]) VALUES (N'CCCCCC', N'M', 23, 201807202157, N'淺灰')
INSERT [stylish].[variant] ([color_code], [size], [stock], [id], [color_name]) VALUES (N'FFFFFF', N'M', 5, 201807242211, N'白色')
INSERT [stylish].[variant] ([color_code], [size], [stock], [id], [color_name]) VALUES (N'FFFFFF', N'L', 5, 201807242211, N'白色')
INSERT [stylish].[variant] ([color_code], [size], [stock], [id], [color_name]) VALUES (N'FFFFFF', N'XL', 5, 201807242211, N'白色')
INSERT [stylish].[variant] ([color_code], [size], [stock], [id], [color_name]) VALUES (N'DDF0FF', N'XL', 5, 201807242211, N'淺藍')
INSERT [stylish].[variant] ([color_code], [size], [stock], [id], [color_name]) VALUES (N'DDF0FF', N'L', 5, 201807242211, N'淺藍')
INSERT [stylish].[variant] ([color_code], [size], [stock], [id], [color_name]) VALUES (N'FFFFFF', N'S', 2, 201807242216, N'白色')
INSERT [stylish].[variant] ([color_code], [size], [stock], [id], [color_name]) VALUES (N'FFFFFF', N'M', 2, 201807242216, N'白色')
INSERT [stylish].[variant] ([color_code], [size], [stock], [id], [color_name]) VALUES (N'FFFFFF', N'L', 2, 201807242216, N'白色')
INSERT [stylish].[variant] ([color_code], [size], [stock], [id], [color_name]) VALUES (N'CCCCCC', N'S', 2, 201807242216, N'淺灰')
INSERT [stylish].[variant] ([color_code], [size], [stock], [id], [color_name]) VALUES (N'CCCCCC', N'M', 2, 201807242216, N'淺灰')
INSERT [stylish].[variant] ([color_code], [size], [stock], [id], [color_name]) VALUES (N'CCCCCC', N'L', 2, 201807242216, N'淺灰')
INSERT [stylish].[variant] ([color_code], [size], [stock], [id], [color_name]) VALUES (N'BB7744', N'M', 2, 201807242230, N'淺棕')
INSERT [stylish].[variant] ([color_code], [size], [stock], [id], [color_name]) VALUES (N'BB7744', N'L', 2, 201807242230, N'淺棕')
INSERT [stylish].[variant] ([color_code], [size], [stock], [id], [color_name]) VALUES (N'334455', N'L', 2, 201807242230, N'深藍')
INSERT [stylish].[variant] ([color_code], [size], [stock], [id], [color_name]) VALUES (N'FFFFFF', N'F', 5, 201807242232, N'白色')
INSERT [stylish].[variant] ([color_code], [size], [stock], [id], [color_name]) VALUES (N'FFDDDD', N'F', 3, 201807242232, N'粉紅')
INSERT [stylish].[variant] ([color_code], [size], [stock], [id], [color_name]) VALUES (N'FFFFFF', N'F', 4, 201807242234, N'白色')
INSERT [stylish].[variant] ([color_code], [size], [stock], [id], [color_name]) VALUES (N'DDF0FF', N'F', 3, 201807242234, N'淺藍')
INSERT [stylish].[variant] ([color_code], [size], [stock], [id], [color_name]) VALUES (N'FFFFFF', N'M', 3, 201902191210, N'白色')
INSERT [stylish].[variant] ([color_code], [size], [stock], [id], [color_name]) VALUES (N'FFDDDD', N'M', 3, 201902191210, N'粉紅')
INSERT [stylish].[variant] ([color_code], [size], [stock], [id], [color_name]) VALUES (N'FFDDDD', N'S', 3, 201902191210, N'粉紅')
INSERT [stylish].[variant] ([color_code], [size], [stock], [id], [color_name]) VALUES (N'FFDDDD', N'S', 0, 201807201824, N'粉紅')
GO
INSERT [stylish].[variant] ([color_code], [size], [stock], [id], [color_name]) VALUES (N'FFDDDD', N'M', 2, 201807201824, N'粉紅')
INSERT [stylish].[variant] ([color_code], [size], [stock], [id], [color_name]) VALUES (N'FFFFFF', N'F', 23, 24162482, N'白色')
INSERT [stylish].[variant] ([color_code], [size], [stock], [id], [color_name]) VALUES (N'FFDDDD', N'F', 23, 24162482, N'粉紅')
INSERT [stylish].[variant] ([color_code], [size], [stock], [id], [color_name]) VALUES (N'FFDDDD', N'S', 12, 202006242230, N'粉紅')
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [user$email_UNIQUE]    Script Date: 2024/4/22 下午 09:19:21 ******/
ALTER TABLE [stylish].[user] ADD  CONSTRAINT [user$email_UNIQUE] UNIQUE NONCLUSTERED 
(
	[email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [stylish].[campaign] ADD  DEFAULT (NULL) FOR [picture]
GO
ALTER TABLE [stylish].[campaign] ADD  DEFAULT (NULL) FOR [story]
GO
ALTER TABLE [stylish].[hots] ADD  DEFAULT (NULL) FOR [products]
GO
ALTER TABLE [stylish].[orders] ADD  DEFAULT (NULL) FOR [user_id]
GO
ALTER TABLE [stylish].[orders] ADD  DEFAULT (NULL) FOR [time]
GO
ALTER TABLE [stylish].[orders] ADD  DEFAULT (NULL) FOR [total]
GO
ALTER TABLE [stylish].[orders] ADD  DEFAULT (NULL) FOR [user_orders]
GO
ALTER TABLE [stylish].[orders] ADD  DEFAULT (NULL) FOR [pay_orders]
GO
ALTER TABLE [stylish].[orders] ADD  DEFAULT (NULL) FOR [payment]
GO
ALTER TABLE [stylish].[orders] ADD  DEFAULT (NULL) FOR [shipping]
GO
ALTER TABLE [stylish].[orders] ADD  DEFAULT (NULL) FOR [pay]
GO
ALTER TABLE [stylish].[orders] ADD  DEFAULT (NULL) FOR [order_products]
GO
ALTER TABLE [stylish].[orders] ADD  DEFAULT (NULL) FOR [user]
GO
ALTER TABLE [stylish].[orders] ADD  DEFAULT (NULL) FOR [last_four]
GO
ALTER TABLE [stylish].[otherimages] ADD  DEFAULT (NULL) FOR [images_url]
GO
ALTER TABLE [stylish].[otherimages] ADD  DEFAULT (NULL) FOR [id]
GO
ALTER TABLE [stylish].[product] ADD  DEFAULT (NULL) FOR [description]
GO
ALTER TABLE [stylish].[product] ADD  DEFAULT (NULL) FOR [price]
GO
ALTER TABLE [stylish].[product] ADD  DEFAULT (NULL) FOR [texture]
GO
ALTER TABLE [stylish].[product] ADD  DEFAULT (NULL) FOR [wash]
GO
ALTER TABLE [stylish].[product] ADD  DEFAULT (NULL) FOR [place]
GO
ALTER TABLE [stylish].[product] ADD  DEFAULT (NULL) FOR [note]
GO
ALTER TABLE [stylish].[product] ADD  DEFAULT (NULL) FOR [story]
GO
ALTER TABLE [stylish].[product] ADD  DEFAULT (NULL) FOR [main_image]
GO
ALTER TABLE [stylish].[product] ADD  DEFAULT (NULL) FOR [category]
GO
ALTER TABLE [stylish].[user] ADD  DEFAULT (NULL) FOR [provider]
GO
ALTER TABLE [stylish].[user] ADD  DEFAULT (NULL) FOR [name]
GO
ALTER TABLE [stylish].[user] ADD  DEFAULT (NULL) FOR [email]
GO
ALTER TABLE [stylish].[user] ADD  DEFAULT (NULL) FOR [picture]
GO
ALTER TABLE [stylish].[user] ADD  DEFAULT (NULL) FOR [password]
GO
ALTER TABLE [stylish].[variant] ADD  DEFAULT (NULL) FOR [color_code]
GO
ALTER TABLE [stylish].[variant] ADD  DEFAULT (NULL) FOR [size]
GO
ALTER TABLE [stylish].[variant] ADD  DEFAULT (NULL) FOR [stock]
GO
ALTER TABLE [stylish].[variant] ADD  DEFAULT (NULL) FOR [id]
GO
ALTER TABLE [stylish].[variant] ADD  DEFAULT (NULL) FOR [color_name]
GO
ALTER TABLE [stylish].[otherimages]  WITH NOCHECK ADD  CONSTRAINT [otherimages$otherimages_ibfk_1] FOREIGN KEY([id])
REFERENCES [stylish].[product] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [stylish].[otherimages] CHECK CONSTRAINT [otherimages$otherimages_ibfk_1]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'stylish.campaign' , @level0type=N'SCHEMA',@level0name=N'stylish', @level1type=N'TABLE',@level1name=N'campaign'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'stylish.hots' , @level0type=N'SCHEMA',@level0name=N'stylish', @level1type=N'TABLE',@level1name=N'hots'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'stylish.orders' , @level0type=N'SCHEMA',@level0name=N'stylish', @level1type=N'TABLE',@level1name=N'orders'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'stylish.otherimages' , @level0type=N'SCHEMA',@level0name=N'stylish', @level1type=N'TABLE',@level1name=N'otherimages'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'stylish.product' , @level0type=N'SCHEMA',@level0name=N'stylish', @level1type=N'TABLE',@level1name=N'product'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'stylish.`user`' , @level0type=N'SCHEMA',@level0name=N'stylish', @level1type=N'TABLE',@level1name=N'user'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'stylish.variant' , @level0type=N'SCHEMA',@level0name=N'stylish', @level1type=N'TABLE',@level1name=N'variant'
GO
