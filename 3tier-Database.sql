USE [suraj]
GO
/****** Object:  UserDefinedFunction [dbo].[emp_join]    Script Date: 3/2/2023 4:48:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Function [dbo].[emp_join](
@name varchar(50),
@mobile varchar(50),
@gender varchar(50)
)
returns varchar(100)
as
begin return(select @name+' '+@mobile+' ' +@gender)
end
GO
/****** Object:  Table [dbo].[register]    Script Date: 3/2/2023 4:48:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[register](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NOT NULL,
	[email] [varchar](50) NOT NULL,
	[password] [varchar](50) NOT NULL,
	[mobile] [varchar](50) NOT NULL,
	[gender] [varchar](50) NOT NULL,
	[usertype] [varchar](50) NOT NULL,
	[image] [varchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  UserDefinedFunction [dbo].[emp_register]    Script Date: 3/2/2023 4:48:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create function [dbo].[emp_register]()
returns table
as return(select * from register)
GO
/****** Object:  Table [dbo].[geolocation]    Script Date: 3/2/2023 4:48:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[geolocation](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NULL,
	[state] [varchar](50) NULL,
	[country] [varchar](50) NULL,
	[geolocation] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[mvc]    Script Date: 3/2/2023 4:48:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[mvc](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NOT NULL,
	[city] [varchar](50) NOT NULL,
	[address] [varchar](50) NOT NULL,
 CONSTRAINT [PK_mvc] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblFiles]    Script Date: 3/2/2023 4:48:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblFiles](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[ContentType] [nvarchar](200) NOT NULL,
	[Data] [varbinary](max) NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[uploadpdff]    Script Date: 3/2/2023 4:48:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[uploadpdff](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NULL,
	[type] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserRegister]    Script Date: 3/2/2023 4:48:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserRegister](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[First_Name] [varchar](50) NOT NULL,
	[Last_Name] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[Position] [varchar](50) NOT NULL,
	[Reference] [varchar](50) NULL,
	[Resume] [varchar](max) NULL,
	[Street_Near] [varchar](50) NULL,
	[Pin_Code] [int] NOT NULL,
	[Place] [varchar](50) NULL,
	[Country] [varchar](50) NOT NULL,
	[Mobile_No] [varchar](50) NOT NULL,
	[Email_Id] [varchar](50) NOT NULL,
	[UserType] [varchar](10) NULL,
	[Marks] [int] NULL,
	[Feed_R1] [varchar](max) NULL,
	[Status_R1] [varchar](10) NULL,
	[Feed_R2] [varchar](max) NULL,
	[Status_R2] [varchar](10) NULL,
	[Hr_Feed] [varchar](max) NULL,
	[Status_Hr] [varchar](10) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usertask]    Script Date: 3/2/2023 4:48:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usertask](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NULL,
	[email] [varchar](50) NULL,
	[password] [varchar](50) NULL,
	[mobile] [varchar](50) NULL,
	[gender] [varchar](50) NULL,
	[usertype] [varchar](50) NULL,
	[image] [varchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[emply]    Script Date: 3/2/2023 4:48:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[emply](
@id int=null ,
@name varchar(50)=null,
@city varchar(50)=null,
@address varchar(50)=null,
@Action varchar(50)=null)
as
begin
if @Action='insertmpl'
begin 
insert into mvc values(@name,@city,@address)
end
end
GO
/****** Object:  StoredProcedure [dbo].[login_pro]    Script Date: 3/2/2023 4:48:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[login_pro]

(

        @name varchar(50),

        @password varchar(50)

)

as
select * from register where name=@name and password=@password
GO
/****** Object:  StoredProcedure [dbo].[myprocedure]    Script Date: 3/2/2023 4:48:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[myprocedure] (
    @Id int=NULL ,
    @First_Name varchar(50)=NULL,
    @Last_Name varchar(50)=NULL,
    @Password varchar(50)=NULL,
    @Position varchar(50)=NULL,
    @Reference varchar(50)=NULL,
    @Resume varchar(50)=NULL,
    @Street_Near varchar(50)=NULL,
    @Pin_Code int=NULL,
    @Place varchar(50)=NULL,
	@Country varchar(50)=null,
	@Mobile_No varchar(50)=null,
	@Email_Id varchar(50)=null,
	@UserType varchar(50)=null,
	@Marks int=null,
	@Feed_R1 varchar(max)=null,
	@Status_R1 varchar(10)=null,
	@Feed_R2 varchar(max)=null,
	@Status_R2 varchar(10)=null,
	@Hr_Feed varchar(max)=null,
	@Status_Hr varchar(10)=null,
    @Action varchar(50)
    )
    as
    begin
    if @Action ='Insert'
    begin
    insert into UserRegister (First_Name,Last_Name,Password,Position,Reference,Resume,Street_Near,Pin_Code,Place,Country,Mobile_No,Email_Id,UserType,Marks) 
	values(@First_Name,@Last_Name,@Password,@Position,@Reference,@Resume,@Street_Near,@Pin_Code,@Place,@Country,@Mobile_No,@Email_Id,@UserType,@Marks)
    end
    if @Action ='Login'
    begin
    select * from UserRegister where Email_Id=@Email_Id and Password= @Password
    end
    if @Action='userCo' 
	begin
	select count(*) from UserRegister where Mobile_No=@Mobile_No and Email_Id=@Email_Id  
    end
	if @Action='Updatemarks'
	begin
	update  UserRegister set Marks=@Marks where Id=@Id
	end
	if @Action='HrPortalstatus'
	begin
	select * from UserRegister where Status_R1=@Status_R1 or Status_R2=@Status_R2 
	end
	if @Action='showAllData'
	begin
	select * from UserRegister 
	end
	if @Action='showR1Data'
	begin
	select * from UserRegister where Marks>4
	end
	if @Action='showR1Data'
	begin
	select * from UserRegister where Marks>4
	end
	if @Action='input_R1'
	begin
	update UserRegister set Feed_R1=@Feed_R1, Status_R1=@Status_R1 where Id=@Id
	end
	if @Action='input_R2'
	begin
	update UserRegister set Feed_R2=@Feed_R2, Status_R2=@Status_R2 where Id=@Id
	end
	if @Action='input_Hr'
	begin
	update UserRegister set Hr_Feed=@Hr_Feed, Status_Hr=@Status_Hr where Id=@Id
	end
	if @Action='changepswd'
	begin 
	update UserRegister set Password=@Password where Id=@Id
	end
	if @Action='resume'
	begin
	update UserRegister set Resume=@Resume where Id=@Id;
	end
	end
GO
/****** Object:  StoredProcedure [dbo].[reg]    Script Date: 3/2/2023 4:48:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[reg](
@id varchar(50)=null,
@name varchar(50)=null,
@email varchar(50)=null,
@password varchar(50)=null,
@mobile varchar(50)=null,
@gender varchar(50)=null,
@usertype varchar(50)=null,
@image varchar(max)=null,
@Action varchar(100))
as
begin if @Action='Insert' 
begin
insert into register values(@name,@email,@password,@mobile,@gender,@usertype,@image)
end
if @Action='upuser' 
begin
Update register set name=@name,email=@email,mobile=@mobile,gender=@gender where id=@id
end
if @Action='changepass' 
begin
update register set password=@password where name=@name
end
if @Action='imageup' 
begin
update register set image=@image where id=@id
end
if @Action='adminup'
begin
update register set register.name=@name,register.mobile=@mobile,register.gender=@gender,register.usertype=@usertype,image=@image where id=@id
end
end
GO
/****** Object:  StoredProcedure [dbo].[seleuser]    Script Date: 3/2/2023 4:48:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[seleuser](
--@email varchar(50),
--@mobile varchar(50),
--@gender varchar(50),
--@image varchar(max)
@id  varchar(50))
as
begin
Select name, register.email,register.mobile,register.gender,register.image from register where id!=@id and usertype='User'
end
GO
/****** Object:  StoredProcedure [dbo].[threetier]    Script Date: 3/2/2023 4:48:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[threetier] (
@id int=0,
@name varchar(50)=null,
@email varchar(50)=null,
@password varchar(50)=null,
@mobile varchar(50)=null,
@gender varchar(50)=null,
@usertype varchar(50)=null,
@image varchar(max)=null,
@Action varchar(100))
as
begin if @Action='Insert' 
begin
insert into usertask values(@name,@email,@password,@mobile,@gender,@usertype,@image)
end
if @Action='Userupdate' 
begin
Update usertask set name=@name,email=@email,mobile=@mobile,gender=@gender where id=@id
end
if @Action='get_user' 
begin
Select name,email,mobile,gender,usertype,image from usertask where id!=@id and usertype='User'
end
if @Action='login' 
begin 
select * from usertask where name=@name and password=@password
end
if @Action='admin'
begin
select * from usertask 
end
if @Action='change'
begin
update usertask set password=@password where id=@id
end
if @Action='show'
begin
select name,email,mobile,gender from usertask where id=@id
end
if @Action='image'
begin
select id,image from usertask where id=@id
end
if @Action='imageup'
begin 
update usertask set image=@image where id=@id
end
if @Action='admupdate'
begin
update usertask set name=@name,mobile=@mobile,gender=@gender,usertype=@usertype,image=@image where id=@id
end
end
GO
/****** Object:  StoredProcedure [dbo].[userupdate]    Script Date: 3/2/2023 4:48:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[userupdate](
@id varchar(50),
@name varchar(50),
@email varchar(50),
@mobile varchar(50),
@gender varchar(50))
as
begin
Update register set  
name=@name,
email=@email,
mobile=@mobile,
gender=@gender
where id=@id
end
RETURN 0
GO
