/*
Navicat SQL Server Data Transfer

Source Server         : sqlserver
Source Server Version : 105000
Source Host           : 192.168.174.129:1433
Source Database       : DBS
Source Schema         : dbo

Target Server Type    : SQL Server
Target Server Version : 105000
File Encoding         : 65001

Date: 2022-11-21 16:05:08
*/


-- ----------------------------
-- Table structure for Course
-- ----------------------------
DROP TABLE [dbo].[Course]
GO
CREATE TABLE [dbo].[Course] (
[Cno] int NOT NULL ,
[Cname] varchar(20) NULL ,
[CPno] int NULL ,
[Credit] int NULL 
)


GO

-- ----------------------------
-- Records of Course
-- ----------------------------
INSERT INTO [dbo].[Course] ([Cno], [Cname], [CPno], [Credit]) VALUES (N'1', N'数据库1', N'5', N'4')
GO
GO
INSERT INTO [dbo].[Course] ([Cno], [Cname], [CPno], [Credit]) VALUES (N'2', N'数学', null, N'2')
GO
GO
INSERT INTO [dbo].[Course] ([Cno], [Cname], [CPno], [Credit]) VALUES (N'3', N'信息系统', N'1', N'4')
GO
GO
INSERT INTO [dbo].[Course] ([Cno], [Cname], [CPno], [Credit]) VALUES (N'4', N'操作系统', N'6', N'3')
GO
GO
INSERT INTO [dbo].[Course] ([Cno], [Cname], [CPno], [Credit]) VALUES (N'5', N'数据结构', N'7', N'4')
GO
GO
INSERT INTO [dbo].[Course] ([Cno], [Cname], [CPno], [Credit]) VALUES (N'6', N'数据处理', null, N'2')
GO
GO
INSERT INTO [dbo].[Course] ([Cno], [Cname], [CPno], [Credit]) VALUES (N'7', N'PASCAL', N'6', N'4')
GO
GO

-- ----------------------------
-- Table structure for SC
-- ----------------------------
DROP TABLE [dbo].[SC]
GO
CREATE TABLE [dbo].[SC] (
[Sno] char(5) NOT NULL ,
[Cno] int NOT NULL ,
[Grade] int NULL 
)


GO

-- ----------------------------
-- Records of SC
-- ----------------------------
INSERT INTO [dbo].[SC] ([Sno], [Cno], [Grade]) VALUES (N'95001', N'1', N'92')
GO
GO
INSERT INTO [dbo].[SC] ([Sno], [Cno], [Grade]) VALUES (N'95001', N'2', N'85')
GO
GO
INSERT INTO [dbo].[SC] ([Sno], [Cno], [Grade]) VALUES (N'95001', N'3', N'88')
GO
GO
INSERT INTO [dbo].[SC] ([Sno], [Cno], [Grade]) VALUES (N'95002', N'2', N'90')
GO
GO
INSERT INTO [dbo].[SC] ([Sno], [Cno], [Grade]) VALUES (N'95002', N'3', N'80')
GO
GO

-- ----------------------------
-- Table structure for Student
-- ----------------------------
DROP TABLE [dbo].[Student]
GO
CREATE TABLE [dbo].[Student] (
[Sno] char(5) NOT NULL ,
[Sname] char(6) NULL ,
[Ssex] char(2) NULL ,
[Sbirthday] datetime NULL ,
[Sdept] char(2) NULL 
)


GO

-- ----------------------------
-- Records of Student
-- ----------------------------
INSERT INTO [dbo].[Student] ([Sno], [Sname], [Ssex], [Sbirthday], [Sdept]) VALUES (N'95001', N'李勇  ', N'男', N'2010-02-11 00:00:00.000', N'CS')
GO
GO
INSERT INTO [dbo].[Student] ([Sno], [Sname], [Ssex], [Sbirthday], [Sdept]) VALUES (N'95002', N'刘晨  ', N'女', N'1900-01-20 00:00:00.000', N'IS')
GO
GO
INSERT INTO [dbo].[Student] ([Sno], [Sname], [Ssex], [Sbirthday], [Sdept]) VALUES (N'95003', N'王敏  ', N'女', N'1900-01-19 00:00:00.000', N'MA')
GO
GO
INSERT INTO [dbo].[Student] ([Sno], [Sname], [Ssex], [Sbirthday], [Sdept]) VALUES (N'95004', N'张立  ', N'男', N'1900-01-20 00:00:00.000', N'IS')
GO
GO

-- ----------------------------
-- Indexes structure for table Course
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table Course
-- ----------------------------
ALTER TABLE [dbo].[Course] ADD PRIMARY KEY ([Cno])
GO

-- ----------------------------
-- Uniques structure for table Course
-- ----------------------------
ALTER TABLE [dbo].[Course] ADD UNIQUE ([Cname] ASC)
GO

-- ----------------------------
-- Indexes structure for table SC
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table SC
-- ----------------------------
ALTER TABLE [dbo].[SC] ADD PRIMARY KEY ([Sno], [Cno])
GO

-- ----------------------------
-- Checks structure for table SC
-- ----------------------------
ALTER TABLE [dbo].[SC] ADD CHECK (([Grade]>=(0) AND [Grade]<=(100)))
GO

-- ----------------------------
-- Indexes structure for table Student
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table Student
-- ----------------------------
ALTER TABLE [dbo].[Student] ADD PRIMARY KEY ([Sno])
GO

-- ----------------------------
-- Foreign Key structure for table [dbo].[SC]
-- ----------------------------
ALTER TABLE [dbo].[SC] ADD FOREIGN KEY ([Sno]) REFERENCES [dbo].[Student] ([Sno]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO
ALTER TABLE [dbo].[SC] ADD FOREIGN KEY ([Cno]) REFERENCES [dbo].[Course] ([Cno]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO
