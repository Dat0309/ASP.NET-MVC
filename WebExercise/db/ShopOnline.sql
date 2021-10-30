create table Accounts
(
AccountID int IDENTITY(1,1) primary key,
Phone varchar(12),
Email nvarchar(50),
Password nvarchar(50),
Salt nchar(10),
Active bit not null,
FullName nvarchar(150),
RoleID int references Role(RoleID),
LastLogin datetime,
CreateDate datetime,
)

create table Role
(
RoleID int IDENTITY(1,1) primary key,
RoleName nvarchar(50),
Description nvarchar(150)
)

create table Categories
(
CatID int identity(1,1) primary key,
CatName nvarchar(250),
Description nvarchar(MAX),
ParentID int,
Levels int,
Ordering int,
Published bit not null,
Thumb nvarchar(250),
Title nvarchar(250),
Alias nvarchar(250),
MetaDecs nvarchar(250),
MetaKey nvarchar(250),
Cover nvarchar(250),
SchemaMarkup nvarchar(MAX),
)

create table Locations(
LocationID int identity(1,1) primary key,
Name nvarchar(100),
Type nvarchar(20),
Slug nvarchar(100),
NameWithType nvarchar(255),
PathWithType nvarchar(255),
ParentCode int,
Levels int
)

create table Customers(
CustomerID int identity(1,1) primary key,
FullName nvarchar(255),
Birthday datetime,
Avatar nvarchar(255),
Address nvarchar(255),
Email nchar(250),
Phone varchar(12),
LocationID int references Locations(LocationID),
District int,
Ward int,
CreateDate datetime,
Password nvarchar(50),
Salt nchar(8),
LastLogin datetime,
Active bit not null
)

create table Products(
ProductID int identity(1,1) primary key,
ProductName nvarchar(255) not null,
ShortDecs nvarchar(255),
Description nvarchar(255),
CatID int references Categories(CatID),
Price int,
Discount int,
Thumb nvarchar(255),
Video nvarchar(255),
DateCreated datetime,
DateModified datetime,
BestSeller bit not null,
HomeFlag bit not null,
Active bit not null,
Tags nvarchar(MAX),
Title nvarchar(255),
Alias nvarchar(255),
MetaDesc nvarchar(255),
MetaKey nvarchar(255),
UnitslnStock int
)

create table Attributes(
AttributeID int identity(1,1) primary key,
Name nvarchar(50)
)

create table AttributesPrces(
AttributePriceID int identity(1,1) primary key,
AttributeID int references Attributes(AttributeID),
ProductID int references Products(ProductID),
Price int,
Active bit not null
)

create table TransactStatus(
TransacStatusID int identity(1,1) primary key,
Status nvarchar(50),
Description nvarchar(MAX)
)

create table Shippers(
ShipperID int identity(1,1) primary key,
ShipperName nvarchar(150),
Phone nchar(10),
Company nvarchar(150),
ShipDate datetime
)

create table Payments(
PaymentID int identity(1,1) primary key,
PaymentType nvarchar(50),
Allowed bit not null
)

create table Orders(
OrderID int identity(1,1) primary key,
CustomerID int references Customers(CustomerID),
OrderDate datetime,
ShipDate datetime,
TransactStatus int references TransactStatus(TransacStatusID),
Deleted bit not null,
Paid bit not null,
PaymentDate datetime,
PaymentID int references Payments(PaymentID),
Note nvarchar(MAX)
)

create table OrderDetails(
OrderDetailID int identity(1,1) primary key,
OrderID int references Orders(OrderID),
ProductID int references Products(ProductID),
OrderNumber int,
Quantity int,
Discount int,
Total int,
ShipDate datetime 
)

create table Pages(
PageID int identity(1,1) primary key,
PageName nvarchar(250),
Contents nvarchar(MAX),
Thumb nvarchar(250),
Published bit not null,
Title nvarchar(250),
MetaDecs nvarchar(250),
MetaKey nvarchar(250),
Alias nvarchar(250),
CreateAt datetime,
Ordering int
)

create table TinTucs(
PostID int identity(1,1) primary key,
Title nvarchar(255),
Scontents nvarchar(255),
Contents nvarchar(MAX),
Thumb nvarchar(255),
Published bit not null,
Alias nvarchar(255),
CreateDate datetime,
Author nvarchar(255),
AccountID int references Accounts(AccountID),
Tags nvarchar(MAX),
CatID int references Categories(CatID),
isHot bit,
isNewFeed bit,
MetaKey nvarchar(255),
MetaDesc nvarchar(255),
Views int
)