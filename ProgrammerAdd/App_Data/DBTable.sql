USE [programmerAdd]
GO
/****** Object:  Table [dbo].[TBL_Shared]    Script Date: 05/24/2019 13:54:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TBL_Shared](
	[sid] [int] IDENTITY(1,1) NOT NULL,
	[file] [varchar](max) NULL,
	[type] [varchar](50) NULL,
	[suser] [varchar](100) NULL,
	[sdt] [varchar](50) NULL,
 CONSTRAINT [PK_TBL_Shared] PRIMARY KEY CLUSTERED 
(
	[sid] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[TBL_Shared] ON
INSERT [dbo].[TBL_Shared] ([sid], [file], [type], [suser], [sdt]) VALUES (1, N'New Doc 2018-10-07 08.49.30.pdf', N'pythan', N'shaktiuamr555@gmail.com', N'12/1/2018 3:40:36 PM')
SET IDENTITY_INSERT [dbo].[TBL_Shared] OFF
/****** Object:  Table [dbo].[TBL_Registration]    Script Date: 05/24/2019 13:54:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TBL_Registration](
	[name] [varchar](50) NULL,
	[lastname] [varchar](50) NULL,
	[mobile] [varchar](50) NULL,
	[currentadd] [varchar](150) NULL,
	[profession] [varchar](50) NULL,
	[email] [varchar](100) NOT NULL,
	[password] [varchar](20) NULL,
	[picture] [varchar](150) NULL,
	[cdt] [varchar](50) NULL,
 CONSTRAINT [PK_TBL_Registration] PRIMARY KEY CLUSTERED 
(
	[email] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[TBL_Registration] ([name], [lastname], [mobile], [currentadd], [profession], [email], [password], [picture], [cdt]) VALUES (N'manyank', N'Mishra', N'9005657759', N'vill- Digh bhadohi', N'cooder', N'mayankmishradigh20001@gmail.com', N'87654321', N'BeautyPlusMe_20180621210811_fast.jpg', N'12/1/2018 9:50:32 PM')
INSERT [dbo].[TBL_Registration] ([name], [lastname], [mobile], [currentadd], [profession], [email], [password], [picture], [cdt]) VALUES (N'parvez', N'ansari', N'8354021883', N'vill-ugapur bhadohi', N'programmer', N'parvez.ansari3677@gmail.com', N'87654321', N'IMG_20180430_144154.jpg', N'12/3/2018 1:18:26 AM')
INSERT [dbo].[TBL_Registration] ([name], [lastname], [mobile], [currentadd], [profession], [email], [password], [picture], [cdt]) VALUES (N'parvez ', N'ansari', N'8354021883', N'vill-pasiyahi, post-vidhyapur mirzapur', N'programmer', N'parvez.ansari4085@gmail.com', N'876', N'IMG_20180430_144048.jpg', N'12/1/2018 2:55:25 PM')
INSERT [dbo].[TBL_Registration] ([name], [lastname], [mobile], [currentadd], [profession], [email], [password], [picture], [cdt]) VALUES (N'pheroj', N'ansari', N'8475284759', N'Vill-pasiyahi, post- vidhyapur mirzapur', N'mobile repairing', N'pherojansari6644@gmail.com', N'87654321', N'IMG_20170817_202455_693.jpg', N'12/2/2018 7:56:00 PM')
INSERT [dbo].[TBL_Registration] ([name], [lastname], [mobile], [currentadd], [profession], [email], [password], [picture], [cdt]) VALUES (N'shakti ', N'9376473553', N'9376473553', N'', N'', N'shaktiumar555@gmail.com', N'876', N'IMG_20160103_171415.jpg', N'05-Feb-2019 5:47:00 PM')
INSERT [dbo].[TBL_Registration] ([name], [lastname], [mobile], [currentadd], [profession], [email], [password], [picture], [cdt]) VALUES (N'uday bhan', N'bind', N'9475764574', N'vill-suriyawa bhadohi', N'web developer', N'udaybhanb0@gamil.com', N'876', N'BeautyPlusMe_20180621210538_org.jpg', N'12/1/2018 6:59:19 PM')
/****** Object:  Table [dbo].[TBL_question]    Script Date: 05/24/2019 13:54:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TBL_question](
	[qid] [int] IDENTITY(1,1) NOT NULL,
	[Question] [varchar](400) NULL,
	[quesby] [varchar](120) NULL,
	[qdt] [varchar](50) NULL,
 CONSTRAINT [PK_TBL_question] PRIMARY KEY CLUSTERED 
(
	[qid] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[TBL_question] ON
INSERT [dbo].[TBL_question] ([qid], [Question], [quesby], [qdt]) VALUES (1, N'', N'shaktiuamr555@gmail.com', N'12/1/2018 3:11:00 PM')
INSERT [dbo].[TBL_question] ([qid], [Question], [quesby], [qdt]) VALUES (2, N'', N'shaktiuamr555@gmail.com', N'12/1/2018 3:12:22 PM')
INSERT [dbo].[TBL_question] ([qid], [Question], [quesby], [qdt]) VALUES (3, N'', N'mayankmishradigh20001@gmail.com', N'12/1/2018 9:52:23 PM')
INSERT [dbo].[TBL_question] ([qid], [Question], [quesby], [qdt]) VALUES (4, N'', N'shaktiumar555@gmail.com', N'05-Feb-2019 5:47:55 PM')
SET IDENTITY_INSERT [dbo].[TBL_question] OFF
/****** Object:  Table [dbo].[TBL_Notification]    Script Date: 05/24/2019 13:54:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TBL_Notification](
	[nid] [int] IDENTITY(1,1) NOT NULL,
	[msg] [varchar](max) NULL,
	[ndt] [varchar](50) NULL,
 CONSTRAINT [PK_TBL_Notification] PRIMARY KEY CLUSTERED 
(
	[nid] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[TBL_Notification] ON
INSERT [dbo].[TBL_Notification] ([nid], [msg], [ndt]) VALUES (1, N'You are most welcome in our comps. ', N'12/1/2018 3:06:09 PM')
SET IDENTITY_INSERT [dbo].[TBL_Notification] OFF
/****** Object:  Table [dbo].[TBL_Login]    Script Date: 05/24/2019 13:54:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TBL_Login](
	[email] [varchar](100) NULL,
	[pass] [varchar](50) NULL,
	[utype] [varchar](50) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[TBL_Login] ([email], [pass], [utype]) VALUES (N'parvez.ansari4085@gmail.com', N'87654', N'admin')
INSERT [dbo].[TBL_Login] ([email], [pass], [utype]) VALUES (N'shaktiuamr555@gmail.com', N'8765', N'user')
INSERT [dbo].[TBL_Login] ([email], [pass], [utype]) VALUES (N'shaktiumar555@gmail.com', N'876', N'user')
INSERT [dbo].[TBL_Login] ([email], [pass], [utype]) VALUES (N'udaybhanb0@gamil.com', N'876', N'user')
INSERT [dbo].[TBL_Login] ([email], [pass], [utype]) VALUES (N'mayankmishradigh20001@gmail.com', N'87654321', N'user')
INSERT [dbo].[TBL_Login] ([email], [pass], [utype]) VALUES (N'pherojansari6644@gmail.com', N'87654321', N'user')
INSERT [dbo].[TBL_Login] ([email], [pass], [utype]) VALUES (N'parvez.ansari3677@gmail.com', N'87654321', N'user')
INSERT [dbo].[TBL_Login] ([email], [pass], [utype]) VALUES (N'avvipandey333.ap@gmail.com', N'87654321', N'user')
/****** Object:  Table [dbo].[TBL_Feedback]    Script Date: 05/24/2019 13:54:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TBL_Feedback](
	[fid] [int] IDENTITY(1,1) NOT NULL,
	[msg] [varchar](max) NULL,
	[email] [varchar](100) NULL,
	[fdt] [varchar](50) NULL,
 CONSTRAINT [PK_TBL_Feedback] PRIMARY KEY CLUSTERED 
(
	[fid] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[TBL_Feedback] ON
INSERT [dbo].[TBL_Feedback] ([fid], [msg], [email], [fdt]) VALUES (1, N'This site is simple and best other then. but some error on this site. looking or best content is not available.  ', N'shaktiuamr555@gmail.com', N'12/1/2018 3:15:43 PM')
INSERT [dbo].[TBL_Feedback] ([fid], [msg], [email], [fdt]) VALUES (2, N'Hello sir, ', N'shaktiuamr555@gmail.com', N'12/1/2018 3:16:02 PM')
INSERT [dbo].[TBL_Feedback] ([fid], [msg], [email], [fdt]) VALUES (3, N'This site is simple and best other then. but some error on this site. looking or best content is not available.  ', N'mayankmishradigh20001@gmail.com', N'12/1/2018 9:52:36 PM')
SET IDENTITY_INSERT [dbo].[TBL_Feedback] OFF
/****** Object:  Table [dbo].[TBL_Enquiry]    Script Date: 05/24/2019 13:54:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TBL_Enquiry](
	[name] [varchar](50) NULL,
	[mobile] [varchar](50) NULL,
	[email] [varchar](100) NOT NULL,
	[currentadd] [varchar](150) NULL,
	[edt] [varchar](50) NULL,
 CONSTRAINT [PK_TBL_Enquiry] PRIMARY KEY CLUSTERED 
(
	[email] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[TBL_Enquiry] ([name], [mobile], [email], [currentadd], [edt]) VALUES (N'parvez ansari', N'8354021883', N'parvez.ansari4085@gmail.com', N'vill-pasiyahi, post vidhyapur mirzapur', N'12/1/2018 2:57:43 PM')
INSERT [dbo].[TBL_Enquiry] ([name], [mobile], [email], [currentadd], [edt]) VALUES (N'shakti umar', N'9621321462', N'shaktiumar555@gmail.com', N'vill-pasiyahi, post vidhyapur mirzapur', N'12/1/2018 2:58:26 PM')
/****** Object:  Table [dbo].[TBL_Download]    Script Date: 05/24/2019 13:54:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TBL_Download](
	[donwid] [int] IDENTITY(1,1) NOT NULL,
	[file] [varchar](max) NULL,
	[type] [varchar](50) NULL,
	[downdt] [varchar](50) NULL,
 CONSTRAINT [PK_TBL_Download] PRIMARY KEY CLUSTERED 
(
	[donwid] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TBL_Down]    Script Date: 05/24/2019 13:54:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TBL_Down](
	[downid] [int] IDENTITY(1,1) NOT NULL,
	[file] [varchar](max) NULL,
	[type] [varchar](50) NULL,
	[downdt] [varchar](50) NULL,
 CONSTRAINT [PK_TBL_Down] PRIMARY KEY CLUSTERED 
(
	[downid] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[TBL_Down] ON
INSERT [dbo].[TBL_Down] ([downid], [file], [type], [downdt]) VALUES (1, N'DCCN LAB MANUAL.pdf', N'Data Stracture', N'12/1/2018 3:17:47 PM')
INSERT [dbo].[TBL_Down] ([downid], [file], [type], [downdt]) VALUES (2, N'FileHandler (3).pdf', N'C++', N'12/1/2018 3:18:08 PM')
SET IDENTITY_INSERT [dbo].[TBL_Down] OFF
/****** Object:  Table [dbo].[TBL_answer]    Script Date: 05/24/2019 13:54:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TBL_answer](
	[aid] [int] IDENTITY(1,1) NOT NULL,
	[qid] [int] NULL,
	[answer] [varchar](max) NULL,
	[answerby] [varchar](120) NULL,
	[ansdt] [varchar](50) NULL,
 CONSTRAINT [PK_TBL_answer] PRIMARY KEY CLUSTERED 
(
	[aid] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
