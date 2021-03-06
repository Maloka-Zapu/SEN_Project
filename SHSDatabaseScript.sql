USE [master]
GO
/****** Object:  Database [SmartHomeSystem]    Script Date: 2020/07/13 11:33:07 PM ******/
CREATE DATABASE [SmartHomeSystem]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SmartHomeSystem', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\SmartHomeSystem.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SmartHomeSystem_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\SmartHomeSystem_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [SmartHomeSystem] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SmartHomeSystem].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SmartHomeSystem] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SmartHomeSystem] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SmartHomeSystem] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SmartHomeSystem] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SmartHomeSystem] SET ARITHABORT OFF 
GO
ALTER DATABASE [SmartHomeSystem] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SmartHomeSystem] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SmartHomeSystem] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SmartHomeSystem] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SmartHomeSystem] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SmartHomeSystem] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SmartHomeSystem] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SmartHomeSystem] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SmartHomeSystem] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SmartHomeSystem] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SmartHomeSystem] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SmartHomeSystem] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SmartHomeSystem] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SmartHomeSystem] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SmartHomeSystem] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SmartHomeSystem] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SmartHomeSystem] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SmartHomeSystem] SET RECOVERY FULL 
GO
ALTER DATABASE [SmartHomeSystem] SET  MULTI_USER 
GO
ALTER DATABASE [SmartHomeSystem] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SmartHomeSystem] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SmartHomeSystem] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SmartHomeSystem] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SmartHomeSystem] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'SmartHomeSystem', N'ON'
GO
ALTER DATABASE [SmartHomeSystem] SET QUERY_STORE = OFF
GO
USE [SmartHomeSystem]
GO
/****** Object:  UserDefinedTableType [dbo].[udtComponentItem]    Script Date: 2020/07/13 11:33:07 PM ******/
CREATE TYPE [dbo].[udtComponentItem] AS TABLE(
	[IssueID] [nchar](15) NULL,
	[EmpID] [nchar](10) NULL,
	[SerialNo] [nchar](10) NULL,
	[Date] [varchar](50) NULL,
	[Quantity] [int] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[udtContractItem]    Script Date: 2020/07/13 11:33:07 PM ******/
CREATE TYPE [dbo].[udtContractItem] AS TABLE(
	[ConID] [nchar](10) NULL,
	[ProdID] [nchar](10) NULL,
	[Quantity] [int] NULL
)
GO
/****** Object:  Table [dbo].[Call]    Script Date: 2020/07/13 11:33:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Call](
	[CallID] [nchar](10) NOT NULL,
	[CusID] [nchar](10) NOT NULL,
	[Audio] [varchar](30) NULL,
	[CallLog] [varchar](300) NOT NULL,
	[Notes] [varchar](300) NULL,
 CONSTRAINT [PK_Call] PRIMARY KEY CLUSTERED 
(
	[CallID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CallCentre]    Script Date: 2020/07/13 11:33:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CallCentre](
	[EmpID] [nchar](10) NOT NULL,
	[CallID] [nchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Component]    Script Date: 2020/07/13 11:33:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Component](
	[SerialNo] [nchar](10) NOT NULL,
	[Type] [varchar](30) NOT NULL,
	[Name] [varchar](60) NOT NULL,
	[Quantity] [int] NULL,
 CONSTRAINT [PK_Component] PRIMARY KEY CLUSTERED 
(
	[SerialNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ComponetsIssued]    Script Date: 2020/07/13 11:33:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ComponetsIssued](
	[EmpID] [nchar](10) NOT NULL,
	[SerialNo] [nchar](10) NOT NULL,
	[Date] [varchar](50) NOT NULL,
	[Quantity] [int] NULL,
	[IssueId] [nchar](15) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Contract]    Script Date: 2020/07/13 11:33:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contract](
	[ConID] [nchar](10) NOT NULL,
	[CusID] [nchar](10) NOT NULL,
	[UpgradeOpt] [varchar](200) NOT NULL,
	[ServiceLvl] [varchar](200) NOT NULL,
 CONSTRAINT [PK_Contract_1] PRIMARY KEY CLUSTERED 
(
	[ConID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ContractItem]    Script Date: 2020/07/13 11:33:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ContractItem](
	[ConID] [nchar](10) NOT NULL,
	[ProdID] [nchar](10) NOT NULL,
	[Quantity] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ContractManagement]    Script Date: 2020/07/13 11:33:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ContractManagement](
	[EmpID] [nchar](10) NOT NULL,
	[ConID] [nchar](10) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 2020/07/13 11:33:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[cusID] [nchar](10) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Surname] [varchar](50) NOT NULL,
	[Address] [varchar](200) NOT NULL,
	[Cell] [varchar](15) NOT NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[cusID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 2020/07/13 11:33:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[EmpID] [nchar](10) NOT NULL,
	[FirstName] [varchar](50) NULL,
	[Surname] [varchar](50) NOT NULL,
	[Title] [varchar](60) NOT NULL,
	[Pass] [varchar](12) NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[EmpID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[JobAssignment]    Script Date: 2020/07/13 11:33:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[JobAssignment](
	[EmpID] [nchar](10) NOT NULL,
	[JobID] [nchar](10) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 2020/07/13 11:33:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[ProdID] [nchar](10) NOT NULL,
	[SuiteName] [varchar](60) NOT NULL,
	[Description] [varchar](250) NOT NULL,
	[UnitsAvailable] [int] NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[ProdID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductItem]    Script Date: 2020/07/13 11:33:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductItem](
	[ProdID] [nchar](10) NOT NULL,
	[SerialNo] [nchar](10) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductManagement]    Script Date: 2020/07/13 11:33:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductManagement](
	[EmpID] [nchar](10) NOT NULL,
	[ProdID] [nchar](10) NOT NULL,
	[IssueId] [nchar](15) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TechSupport]    Script Date: 2020/07/13 11:33:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TechSupport](
	[JobID] [nchar](10) NOT NULL,
	[EmpID] [nchar](10) NOT NULL,
	[JobType] [varchar](80) NOT NULL,
	[Status] [varchar](25) NOT NULL,
	[Description] [varchar](300) NULL,
	[Date] [varchar](30) NULL,
	[CompletionDate] [varchar](30) NULL,
 CONSTRAINT [PK_TechSupport] PRIMARY KEY CLUSTERED 
(
	[JobID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Call]  WITH CHECK ADD  CONSTRAINT [FK_Call_Customer] FOREIGN KEY([CusID])
REFERENCES [dbo].[Customer] ([cusID])
GO
ALTER TABLE [dbo].[Call] CHECK CONSTRAINT [FK_Call_Customer]
GO
ALTER TABLE [dbo].[CallCentre]  WITH CHECK ADD  CONSTRAINT [FK_CallCentre_Call] FOREIGN KEY([CallID])
REFERENCES [dbo].[Call] ([CallID])
GO
ALTER TABLE [dbo].[CallCentre] CHECK CONSTRAINT [FK_CallCentre_Call]
GO
ALTER TABLE [dbo].[CallCentre]  WITH CHECK ADD  CONSTRAINT [FK_CallCentre_Employee] FOREIGN KEY([EmpID])
REFERENCES [dbo].[Employee] ([EmpID])
GO
ALTER TABLE [dbo].[CallCentre] CHECK CONSTRAINT [FK_CallCentre_Employee]
GO
ALTER TABLE [dbo].[ComponetsIssued]  WITH CHECK ADD  CONSTRAINT [FK_ComponetsIssued_Component] FOREIGN KEY([SerialNo])
REFERENCES [dbo].[Component] ([SerialNo])
GO
ALTER TABLE [dbo].[ComponetsIssued] CHECK CONSTRAINT [FK_ComponetsIssued_Component]
GO
ALTER TABLE [dbo].[Contract]  WITH CHECK ADD  CONSTRAINT [FK_Contract_Customer] FOREIGN KEY([CusID])
REFERENCES [dbo].[Customer] ([cusID])
GO
ALTER TABLE [dbo].[Contract] CHECK CONSTRAINT [FK_Contract_Customer]
GO
ALTER TABLE [dbo].[ContractItem]  WITH CHECK ADD  CONSTRAINT [FK_ContractItem_Contract1] FOREIGN KEY([ConID])
REFERENCES [dbo].[Contract] ([ConID])
GO
ALTER TABLE [dbo].[ContractItem] CHECK CONSTRAINT [FK_ContractItem_Contract1]
GO
ALTER TABLE [dbo].[ContractItem]  WITH CHECK ADD  CONSTRAINT [FK_ContractItem_Product] FOREIGN KEY([ProdID])
REFERENCES [dbo].[Product] ([ProdID])
GO
ALTER TABLE [dbo].[ContractItem] CHECK CONSTRAINT [FK_ContractItem_Product]
GO
ALTER TABLE [dbo].[ContractManagement]  WITH CHECK ADD  CONSTRAINT [FK_ContractManagement_Employee] FOREIGN KEY([EmpID])
REFERENCES [dbo].[Employee] ([EmpID])
GO
ALTER TABLE [dbo].[ContractManagement] CHECK CONSTRAINT [FK_ContractManagement_Employee]
GO
ALTER TABLE [dbo].[JobAssignment]  WITH CHECK ADD  CONSTRAINT [FK_JobAssignment_Employee] FOREIGN KEY([EmpID])
REFERENCES [dbo].[Employee] ([EmpID])
GO
ALTER TABLE [dbo].[JobAssignment] CHECK CONSTRAINT [FK_JobAssignment_Employee]
GO
ALTER TABLE [dbo].[JobAssignment]  WITH CHECK ADD  CONSTRAINT [FK_JobAssignment_TechSupport] FOREIGN KEY([JobID])
REFERENCES [dbo].[TechSupport] ([JobID])
GO
ALTER TABLE [dbo].[JobAssignment] CHECK CONSTRAINT [FK_JobAssignment_TechSupport]
GO
ALTER TABLE [dbo].[ProductItem]  WITH CHECK ADD  CONSTRAINT [FK_ProductItem_Component] FOREIGN KEY([SerialNo])
REFERENCES [dbo].[Component] ([SerialNo])
GO
ALTER TABLE [dbo].[ProductItem] CHECK CONSTRAINT [FK_ProductItem_Component]
GO
ALTER TABLE [dbo].[ProductItem]  WITH CHECK ADD  CONSTRAINT [FK_ProductItem_Product] FOREIGN KEY([ProdID])
REFERENCES [dbo].[Product] ([ProdID])
GO
ALTER TABLE [dbo].[ProductItem] CHECK CONSTRAINT [FK_ProductItem_Product]
GO
ALTER TABLE [dbo].[ProductManagement]  WITH CHECK ADD  CONSTRAINT [FK_ProductManagement_Employee] FOREIGN KEY([EmpID])
REFERENCES [dbo].[Employee] ([EmpID])
GO
ALTER TABLE [dbo].[ProductManagement] CHECK CONSTRAINT [FK_ProductManagement_Employee]
GO
ALTER TABLE [dbo].[ProductManagement]  WITH CHECK ADD  CONSTRAINT [FK_ProductManagement_Product] FOREIGN KEY([ProdID])
REFERENCES [dbo].[Product] ([ProdID])
GO
ALTER TABLE [dbo].[ProductManagement] CHECK CONSTRAINT [FK_ProductManagement_Product]
GO
/****** Object:  StoredProcedure [dbo].[AddComItem]    Script Date: 2020/07/13 11:33:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddComItem]
@componentItems udtComponentItem readonly

AS
BEGIN
INSERT INTO ComponetsIssued
(EmpID, IssueId, Date, SerialNo,Quantity)
SELECT EmpID, IssueID,Date,SerialNo,Quantity
FROM @componentItems
END
GO
/****** Object:  StoredProcedure [dbo].[AddComponent]    Script Date: 2020/07/13 11:33:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddComponent]

@serialNo nchar(10),
@type varchar(30),
@name varchar(60),
@quantity int

AS

BEGIN

INSERT INTO Component
(SerialNo, Type, Name, Quantity)
VALUES
(@serialNo, @type, @name, @quantity)

END
GO
/****** Object:  StoredProcedure [dbo].[AddContractItem]    Script Date: 2020/07/13 11:33:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddContractItem]
@contractItems udtContractItem readonly

AS
BEGIN
INSERT INTO ContractItem
(ConID,ProdID,Quantity)
SELECT ConID, ProdID,Quantity
FROM @contractItems
END
GO
/****** Object:  StoredProcedure [dbo].[AddCus]    Script Date: 2020/07/13 11:33:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddCus]
@cus_ID nchar(10),
@name varchar(50),
@surname varchar(50),
@address varchar(200),
@cell nchar(15)

AS

BEGIN

INSERT INTO Customer
(cusID,Name,Surname,Address, Cell)
VALUES
(@cus_ID,@name,@surname,@address,@cell)

END

GO
/****** Object:  StoredProcedure [dbo].[AddEmp]    Script Date: 2020/07/13 11:33:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddEmp]
@emp_ID nchar(10),
@name varchar(50),
@surname varchar(50),
@title varchar(60),
@password varchar(12)

AS

BEGIN

INSERT INTO Employee
(EmpID,FirstName,Surname,Title,Pass)
VALUES
(@emp_ID,@name,@surname,@title,@password)

END
GO
/****** Object:  StoredProcedure [dbo].[AddProduct]    Script Date: 2020/07/13 11:33:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddProduct]

@prod_ID nchar(10),
@suiteName varchar(60),
@description varchar(250),
@unitsAvailable int

AS

BEGIN

INSERT INTO Product
(ProdID, SuiteName, Description, UnitsAvailable)
VALUES
(@prod_ID, @suiteName, @description,@unitsAvailable)

END
GO
/****** Object:  StoredProcedure [dbo].[DeleteCus]    Script Date: 2020/07/13 11:33:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteCus]

@cus_ID nchar(10)

AS

BEGIN
DELETE FROM Customer WHERE cusID = @cus_ID
END
GO
/****** Object:  StoredProcedure [dbo].[DeleteEmp]    Script Date: 2020/07/13 11:33:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteEmp]

@emp_ID nchar(10)

AS

BEGIN
DELETE FROM Employee WHERE EmpID = @emp_ID
END
GO
/****** Object:  StoredProcedure [dbo].[Emp_Call]    Script Date: 2020/07/13 11:33:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Emp_Call]

@emp_ID nchar(10),
@call_ID nchar(10)
AS

BEGIN

INSERT INTO CallCentre
(EmpID,CallID)
VALUES
(@emp_ID,@call_ID)

END
GO
/****** Object:  StoredProcedure [dbo].[Emp_Com]    Script Date: 2020/07/13 11:33:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Emp_Com]

@empID nchar(10),
@prodID nchar(10),
@issueID nchar(15)
AS

BEGIN

INSERT INTO ProductManagement
(EmpID,ProdID,IssueId)
VALUES
(@empID,@prodID,@issueID)

END
GO
/****** Object:  StoredProcedure [dbo].[Emp_Con]    Script Date: 2020/07/13 11:33:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Emp_Con]

@emp_ID nchar(10),
@con_ID nchar(10)
AS

BEGIN

INSERT INTO ContractManagement
(EmpID,ConID)
VALUES
(@emp_ID,@con_ID)

END
GO
/****** Object:  StoredProcedure [dbo].[Emp_Job]    Script Date: 2020/07/13 11:33:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Emp_Job]

@emp_ID nchar(10),
@job_ID nchar(10)
AS

BEGIN

INSERT INTO JobAssignment
(EmpID,JobID)
VALUES
(@emp_ID,@job_ID)

END
GO
/****** Object:  StoredProcedure [dbo].[IncreaseComponents]    Script Date: 2020/07/13 11:33:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[IncreaseComponents]
@c1 nchar(10),@c3 nchar(10),@c6 nchar(10),@c7 nchar(10),@c9 nchar(10),
@c2 nchar(10),@c4 nchar(10),@c5 nchar(10),@c8 nchar(10),
@q1 int, @q2 int,@q3 int,@q4 int,@q5 int,@q6 int,@q7 int,@q8 int,@q9 int

AS
BEGIN

UPDATE Component
SET
Quantity=Quantity+@q1
WHERE SerialNo=@c1

UPDATE Component
SET
Quantity=Quantity+@q2
WHERE SerialNo=@c2

UPDATE Component
SET
Quantity=Quantity+@q3
WHERE SerialNo=@c3

UPDATE Component
SET
Quantity=Quantity+@q4
WHERE SerialNo=@c4

UPDATE Component
SET
Quantity=Quantity+@q5
WHERE SerialNo=@c5

UPDATE Component
SET
Quantity=Quantity+@q6
WHERE SerialNo=@c6

UPDATE Component
SET
Quantity=Quantity+@q7
WHERE SerialNo=@c7

UPDATE Component
SET
Quantity=Quantity+@q8
WHERE SerialNo=@c8

UPDATE Component
SET
Quantity=Quantity+@q9
WHERE SerialNo=@c9
END
GO
/****** Object:  StoredProcedure [dbo].[NewCont]    Script Date: 2020/07/13 11:33:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[NewCont]
@con_ID nchar(10),
@cus_ID nchar(10),
@upgradeOpt varchar(200),
@serviceLvl varchar(200)

AS

BEGIN

INSERT INTO Contract
(ConID,CusID,UpgradeOpt,ServiceLvl)
VALUES
(@con_ID,@cus_ID,@upgradeOpt,@serviceLvl)

END
GO
/****** Object:  StoredProcedure [dbo].[NewJob]    Script Date: 2020/07/13 11:33:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[NewJob]
@job_ID nchar(10),
@emp_ID nchar(10),
@jobType varchar(80),
@status varchar(25),
@description varchar(300),
@date varchar(30)

AS

BEGIN

UPDATE TechSupport
SET
EmpID =@emp_ID, JobType=@jobType, Status=@status,Description=@description,Date=@date
WHERE
JobID=@job_ID
END
GO
/****** Object:  StoredProcedure [dbo].[ReduceComponents]    Script Date: 2020/07/13 11:33:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ReduceComponents]
@c1 nchar(10),@c3 nchar(10),@c6 nchar(10),@c7 nchar(10),@c9 nchar(10),
@c2 nchar(10),@c4 nchar(10),@c5 nchar(10),@c8 nchar(10),
@q1 int, @q2 int,@q3 int,@q4 int,@q5 int,@q6 int,@q7 int,@q8 int,@q9 int

AS
BEGIN

UPDATE Component
SET
Quantity=Quantity-@q1
WHERE SerialNo=@c1

UPDATE Component
SET
Quantity=Quantity-@q2
WHERE SerialNo=@c2

UPDATE Component
SET
Quantity=Quantity-@q3
WHERE SerialNo=@c3

UPDATE Component
SET
Quantity=Quantity-@q4
WHERE SerialNo=@c4

UPDATE Component
SET
Quantity=Quantity-@q5
WHERE SerialNo=@c5

UPDATE Component
SET
Quantity=Quantity-@q6
WHERE SerialNo=@c6

UPDATE Component
SET
Quantity=Quantity-@q7
WHERE SerialNo=@c7

UPDATE Component
SET
Quantity=Quantity-@q8
WHERE SerialNo=@c8

UPDATE Component
SET
Quantity=Quantity-@q9
WHERE SerialNo=@c9
END
GO
/****** Object:  StoredProcedure [dbo].[ReduceQuantity]    Script Date: 2020/07/13 11:33:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ReduceQuantity]
@prod_ID1 nchar(10),
@unitsAvailable1 int,
@prod_ID2 nchar(10),
@unitsAvailable2 int,
@prod_ID3 nchar(10),
@unitsAvailable3 int

AS

BEGIN

UPDATE Product

SET 
UnitsAvailable= UnitsAvailable-@unitsAvailable1
WHERE ProdID=@prod_ID1

UPDATE Product
SET 
UnitsAvailable = UnitsAvailable-@unitsAvailable2
WHERE ProdID=@prod_ID2

UPDATE Product
SET 
UnitsAvailable = UnitsAvailable-@unitsAvailable3
WHERE ProdID=@prod_ID3

END
GO
/****** Object:  StoredProcedure [dbo].[Request]    Script Date: 2020/07/13 11:33:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Request]
@job_ID nchar(10),
@emp_ID nchar(10),
@jobType varchar(80),
@status varchar(25),
@description varchar(300),
@date varchar(30)

AS

BEGIN

INSERT INTO TechSupport

(JobID,EmpID,JobType, Status,Description,Date)
VALUES
(@job_ID,@emp_ID,@jobType,@status,@description,@date)
END
GO
/****** Object:  StoredProcedure [dbo].[SaveLog]    Script Date: 2020/07/13 11:33:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SaveLog]

@cus_ID nchar(10),
@call_ID nchar(10), 
@audio varchar(30),
@callLog varchar(30),
@notes varchar(300)

AS

BEGIN

INSERT INTO Call
(CallID,CusID,Audio,CallLog,Notes)
VALUES
(@call_ID,@cus_ID,@audio,@callLog,@notes)

END
GO
/****** Object:  StoredProcedure [dbo].[UpdateComponent]    Script Date: 2020/07/13 11:33:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateComponent]
@serialNo nchar(10),
@quantity int

AS

BEGIN

UPDATE Component

SET 
Quantity=@quantity

WHERE SerialNo=@serialNo

END
GO
/****** Object:  StoredProcedure [dbo].[UpdateConItems]    Script Date: 2020/07/13 11:33:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[UpdateConItems]
@con_ID nchar(10),
@prod_ID1 nchar(10),
@unitsAvailable1 int,
@prod_ID2 nchar(10),
@unitsAvailable2 int,
@prod_ID3 nchar(10),
@unitsAvailable3 int

AS

BEGIN

UPDATE ContractItem

SET 
Quantity=@unitsAvailable1
WHERE ProdID=@prod_ID1 AND ConID=@con_ID

UPDATE ContractItem
SET 
Quantity=@unitsAvailable2
WHERE ProdID=@prod_ID2 AND ConID=@con_ID

UPDATE ContractItem
SET 
Quantity= @unitsAvailable3
WHERE ProdID=@prod_ID3 AND ConID=@con_ID

END
GO
/****** Object:  StoredProcedure [dbo].[UpdateCont]    Script Date: 2020/07/13 11:33:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateCont]
@cus_ID nchar(10),
@upgradeOpt varchar(200),
@serviceLvl varchar(200)

AS

BEGIN

UPDATE Contract

SET 
UpgradeOpt=@upgradeOpt,
ServiceLvl=@serviceLvl

WHERE CusID=@cus_ID;

END
GO
/****** Object:  StoredProcedure [dbo].[UpdateCusInfo]    Script Date: 2020/07/13 11:33:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateCusInfo]
@cus_ID nchar(10),
@name varchar(50),
@surname varchar(50),
@address varchar(200),
@cell nchar(15)

AS

BEGIN
UPDATE Customer
SET 
Name = @name,
Surname =@surname,
Address =@address,
Cell = @cell

WHERE cusID =@cus_ID

END
GO
/****** Object:  StoredProcedure [dbo].[UpdateEmpInfo]    Script Date: 2020/07/13 11:33:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateEmpInfo]
@emp_ID nchar(10),
@name varchar(50),
@surname varchar(50),
@title varchar(60),
@password varchar(12)

AS


BEGIN

UPDATE Employee

SET 
FirstName=@name,
Surname=@surname,
Title=@title,
Pass=@password


WHERE EmpID =@emp_ID

END
GO
/****** Object:  StoredProcedure [dbo].[UpdateJob]    Script Date: 2020/07/13 11:33:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateJob]
@job_ID nchar(10),
@status varchar(25),
@completionDate varchar(30)

AS

BEGIN

UPDATE TechSupport

SET 
Status=@status,
CompletionDate=@completionDate

WHERE JobID=@job_ID

END
GO
/****** Object:  StoredProcedure [dbo].[UpdateProduct]    Script Date: 2020/07/13 11:33:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateProduct]
@prod_ID nchar(10),
@unitsAvailable int
AS

BEGIN

UPDATE Product

SET 
UnitsAvailable=@unitsAvailable

WHERE ProdID=@prod_ID

END
GO
USE [master]
GO
ALTER DATABASE [SmartHomeSystem] SET  READ_WRITE 
GO
