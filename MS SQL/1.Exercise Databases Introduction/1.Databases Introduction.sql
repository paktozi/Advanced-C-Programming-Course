--1. Create Database

CREATE DATABASE Minions

--2. Create Tables

CREATE TABLE Minions
(
Id INT PRIMARY KEY,
[Name]VARCHAR(50) NOT NULL,
Age INT
);

 CREATE TABLE Towns
 (
   Id INT PRIMARY KEY,
   [Name] VARCHAR(50)
 );

 --3. Alter Minions Table

 ALTER TABLE Minions
 ADD TownId INT

 ALTER TABLE Minions
 --ADD CONSTRAINT FK_Minions_TownsId
 --FOREIGN KEY (TownId) REFERENCES Towns(Id)        SAME AS NEXT LINE
 ADD FOREIGN KEY (TownId) REFERENCES Towns(Id)


 --4. Insert Records in Both Tables

 INSERT INTO Towns
 VALUES
  (1,'Sofia')
 ,(2,'Plovdiv')
 ,(3,'Varna')

INSERT INTO Minions
VALUES
(1,'Kevin',22,1)
,(2,'Bob',15,3)
,(3,'Steward',NULL,2)

--5. Truncate Table Minions

TRUNCATE TABLE Minions


--SELECT m.[Name],Age,t.Name  FROM Minions
--AS m JOIN Towns AS t                        -- JOIN TABLE
--ON m.TownId=t.Id

--SELECT* FROM Minions
--JOIN Towns ON Towns.Id=Minions.TownId


--6. Drop All Tables
DROP TABLE Minions
DROP TABLE Towns


--7. Create Table People


CREATE TABLE People
(
Id INT PRIMARY KEY IDENTITY,
[Name] NVARCHAR(200) NOT NULL,
Picture VARBINARY(MAX),
Height DECIMAL(3,2),
[Weight] DECIMAL(5,2),
Gender CHAR(1)NOT NULL,
CHECK(Gender in ('m','f')),
Birthdate DATETIME2 NOT NULL,
Biography NVARCHAR(MAX)
);


INSERT INTO People ([Name],Gender,Birthdate)
VALUES
('Ivo','m','01-01-1982')
,('Georgi','m','01-01-1984')
,('Cvetan','m','01-01-1983')
,('Stoian','m','01-01-1985')
,('Stilian','m','01-01-1986');


 --8. Create Table Users

 CREATE TABLE Users(
 Id BIGINT PRIMARY KEY IDENTITY,
 UserName VARCHAR(30) UNIQUE NOT NULL,
 [Password] VARCHAR(26) NOT NULL,
 ProfilePictUre VARBINARY(MAX),
 LastLoginTime DATETIME2,
 IsDeleted BIT
 );

 INSERT INTO Users(UserName,[Password])
 VALUES
 ('Ivo','344R')
 , ('Ico','3544R')
  , ('Valq','df344R')
   , ('Aneliq','783i44R')
    , ('Dora','qw344tyR')



--9. Change Primary Key


	ALTER TABLE Users
	DROP CONSTRAINT PK__Users__3214EC07F4275BE4

	ALTER TABLE Users
	ADD PRIMARY KEY(Id,UserName)
	   --ADD CONSTRAINT PK_UserTable(Id,UserName)



--10. Add Check Constraint

ALTER TABLE Users
ADD CONSTRAINT CHECK_PASS_LENGTH
CHECK(LEN([Password])>=5  )

--11. Set Default Value of a Field


ALTER TABLE Users
ADD CONSTRAINT CHANGE_LASTLOGTIME_TO_CURRENT_TIME
DEFAULT GETDATE() FOR LastLoginTime

--12. Set Unique Field

ALTER TABLE Users
DROP CONSTRAINT UQ__Users__C9F28456B2172057

ALTER TABLE Users
ADD CONSTRAINT UserName UNIQUE(UserName)

ALTER TABLE Users
ADD CONSTRAINT Check_UserName_length_least_3symbols
CHECK(LEN(UserName)>=3)

--13. Movies Database

CREATE DATABASE Movies

CREATE TABLE Directors
(
Id INT PRIMARY KEY IDENTITY,
DirectorName VARCHAR(50)NOT NULL,
Notes VARCHAR(MAX)
);

CREATE TABLE Genres(
Id INT PRIMARY KEY IDENTITY,
GenreName VARCHAR(50)NOT NULL UNIQUE,
Notes VARCHAR(MAX)
);

CREATE TABLE Categories 
(
Id INT PRIMARY KEY IDENTITY,
CategoryName VARCHAR(50) NOT NULL UNIQUE,
Notes VARCHAR(MAX)
);

CREATE TABLE Movies(
Id INT PRIMARY KEY IDENTITY,
Title VARCHAR(50)NOT NULL UNIQUE,
DirectorId INT FOREIGN KEY REFERENCES Directors(Id) ,
CopyrightYear DATETIME2 NOT NULL,
[Length] INT NOT NULL,
GenreId INT NOT NULL,
CategoryId INT FOREIGN KEY REFERENCES Categories (Id) ,
Rating DECIMAL(2,1),
Notes VARCHAR(MAX));

INSERT INTO Categories 
VALUES
(1,'Comedy')
,(2,'Action')
,(3,'Biography')
,(4,'Thriller')
,(5,'Sci-Fi')

INSERT INTO Genres
VALUES
(1,'Childrens Films')
,(2,'Teen Films')
,(3,'Adult Films')
,(4,'Blockbuster')
,(5,'Independent ')


INSERT INTO Directors (DirectorName) 
VALUES 
('Steven Spielberg'),
('Martin Scorsese'),
('Christopher Nolan'),
('Quentin Tarantino'),
('Alfred Hitchcock');


INSERT INTO Movies(title,DirectorId,CopyrightYear,[Length],GenreId,CategoryId)
VALUES
('ScarFace',4,'01-02-1995',120,5,2)
,('Good Will Hunting',5,'01-02-1997',120,4,3)
,(' Shawshank Redemption',3,'01-03-1991',140,3,4)
,('Blade Runner',4,'02-02-2020',1150,2,5)
,('The Good, the Bad and the Ugly',4,'01-03-1990',127,1,1)


SELECT*FROM Movies


--14. Car Rental Database


CREATE DATABASE CarRental

CREATE TABLE Categories
(
   Id INT PRIMARY KEY IDENTITY,
   CategoryName VARCHAR(50)NOT NULL,
   DailyRate VARCHAR(30) DEFAULT '',
   WeeklyRate VARCHAR(30) DEFAULT '',
   MonthlyRate VARCHAR(30) DEFAULT '',
    WeekendRate VARCHAR(30) DEFAULT ''

);

CREATE TABLE Cars
(
Id INT PRIMARY KEY IDENTITY,
PlateNumber VARCHAR(20)NOT NULL UNIQUE,
Manufacturer VARCHAR(30)NOT NULL,
Model VARCHAR(30) NOT NULL,
CarYear DATETIME2,
CategoryId INT NOT NULL,
Doors TINYINT NOT NULL,
Picture VARBINARY(MAX),
Condition VARCHAR(20) NOT NULL,
Available BIT,
)


CREATE TABLE Employees(
Id INT PRIMARY KEY IDENTITY,
FirstName VARCHAR(30) NOT NULL,
LastName VARCHAR(30) NOT NULL,
Title VARCHAR(30),
Notes VARCHAR(MAX) DEFAULT '',
);


CREATE TABLE Customers
(
Id INT PRIMARY KEY IDENTITY,
DriverLicenceNumber VARCHAR(30) NOT NULL UNIQUE,
FullName VARCHAR(30)NOT NULL,
Address VARCHAR(200),
City VARCHAR(20),
ZIPCode VARCHAR(10),
Notes VARCHAR(MAX) DEFAULT ''
);


CREATE TABLE RentalOrders(
Id INT PRIMARY KEY IDENTITY,
EmployeeId INT NOT NULL,
CustomerId INT NOT NULL,
CarId INT NOT NULL,
TankLevel VARCHAR(10),
);


--16. Create SoftUni Database

CREATE DATABASE SoftUni

CREATE TABLE Towns
(
    Id INT PRIMARY KEY IDENTITY,
	[Name] VARCHAR(30)NOT NULL
);

CREATE TABLE Addresses(
  Id INT  PRIMARY KEY IDENTITY,
  AddressText VARCHAR(MAX),
  TownId INT NOT NULL FOREIGN KEY REFERENCES Towns(Id),

);


CREATE TABLE Departments(
Id INT PRIMARY KEY IDENTITY,
[Name] VARCHAR(40) NOT NULL
);

CREATE TABLE Employees(
Id INT PRIMARY KEY IDENTITY,
FirstName VARCHAR(30)NOT NULL,
MiddleName VARCHAR(30),
LastName VARCHAR(30) NOT NULL,
JobTitle VARCHAR(30) NOT NULL,
DepartmentId INT NOT NULL FOREIGN KEY REFERENCES Departments(Id),
HireDate DATETIME2,
Salary DECIMAL(8,2),
AddressId INT NOT NULL FOREIGN KEY REFERENCES Addresses(Id)
);

