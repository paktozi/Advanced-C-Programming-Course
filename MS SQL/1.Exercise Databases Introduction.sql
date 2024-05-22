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
DirectorName VARCHAR(40)NOT NULL,
Notes VARCHAR(MAX)
);


CREATE TABLE Genres
(
Id INT PRIMARY KEY IDENTITY,
GenreName VARCHAR(40)NOT NULL,
Notes VARCHAR(MAX)
);

CREATE TABLE Categories
(
Id INT PRIMARY KEY IDENTITY,
CategoryName VARCHAR(40)NOT NULL,
Notes VARCHAR(MAX)
);

CREATE TABLE Movies
(
   Id INT PRIMARY KEY IDENTITY,
   Title VARCHAR(40)NOT NULL,
   DirectorId INT FOREIGN KEY REFERENCES Directors(Id),
   CopyrightYear DATETIME2,
   Length INT,
   GenreId INT FOREIGN KEY REFERENCES Genres(Id),
   CategoryId INT FOREIGN KEY REFERENCES Categories(Id),
   Rating INT,
   Notes VARCHAR(MAX)
);


INSERT INTO Categories(CategoryName)
VALUES
('Comedy')
,('Action')
,('Biography')
,('Thriller')
,('Sci-Fi')

INSERT INTO Genres(GenreName)
VALUES
('Childrens Films')
,('Teen Films')
,('Adult Films')
,('Blockbuster')
,('Independent ')


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
,('Blade Runner',1,'02-02-2020',1150,2,5)
,('The Good, the Bad and the Ugly',2,'01-03-1990',127,1,1)



--14. Car Rental Database

CREATE DATABASE CarRental


CREATE TABLE Categories
(
Id INT PRIMARY KEY IDENTITY,
CategoryName VARCHAR(30)NOT NULL,
DailyRate VARCHAR(MAX),
WeeklyRate VARCHAR(MAX),
MonthlyRate VARCHAR(MAX),
WeekendRate VARCHAR(MAX)
);


CREATE TABLE Employees
(
Id INT PRIMARY KEY IDENTITY,
FirstName VARCHAR(25) NOT NULL,
LastName VARCHAR(25) NOT NULL,
Title VARCHAR(30),
Notes VARCHAR(MAX)
);



CREATE TABLE Customers
(
Id INT PRIMARY KEY IDENTITY,
DriverLicenceNumber VARCHAR(20) UNIQUE NOT NULL,
FullName VARCHAR(40) NOT NULL,
[Address] VARCHAR(100),
City VARCHAR(40),
ZIPCode INT,
Notes VARCHAR(MAX)
);



CREATE TABLE Cars
(
Id INT PRIMARY KEY IDENTITY,
PlateNumber VARCHAR(20)NOT NULL UNIQUE,
Manufacturer VARCHAR(30)NOT NULL,
Model VARCHAR(30) NOT NULL,
CarYear DATETIME2,
CategoryId INT FOREIGN KEY REFERENCES Categories(Id)NOT NULL,
Door TINYINT,
Picture VARBINARY(MAX),
Condition VARCHAR(20),
Available BIT
);

CREATE TABLE RentalOrders
(
Id INT PRIMARY KEY IDENTITY,
EmployeeId INT FOREIGN KEY REFERENCES Employees(Id) NOT NULL,  
CustomerId INT FOREIGN KEY REFERENCES Customers(Id) NOT NULL,
CarId INT FOREIGN KEY REFERENCES Cars(Id) NOT NULL,
TankLevel INT,
KilometrageStart INT,
KilometrageEnd INT,
TotalKilometrage INT,
StartDate DATETIME2,
EndDate DATETIME2,
TotalDays INT,
RateApplied INT,
TaxRate DECIMAL,
OrderStatus BIT,
Notes VARCHAR(MAX),
);

INSERT INTO Categories(CategoryName)
VALUES
('A')
,('C')
,('B+E')

INSERT INTO Employees(FirstName,LastName)
VALUES
('IVO','IVOV')
,('ICO','ICOV')
,('GOSHO','GOSHOV')

INSERT INTO Customers(DriverLicenceNumber,FullName)
VALUES
('88DF5GG','MANOL I')
,('3EW5GG','GORAN V')
,('67DF5RF','KRUM U')

INSERT INTO Cars(PlateNumber,Manufacturer,Model,CategoryId)
VALUES
('IE 346 DF','NISSAN','QASHQAI',1)
,('DD 236 DE','MAZDA','PRIMACY',2)
,('YT 2D6 WQF','NISSAN','ROGUE',3)


INSERT INTO RentalOrders(EmployeeId,CustomerId,CarId)
VALUES
(2,1,3)
,(3,3,2)
,(1,2,1)

--15. Hotel Database

CREATE TABLE Employees(
Id INT PRIMARY KEY IDENTITY NOT NULL,
FirstName VARCHAR(50),
LastName VARCHAR(50),
Title VARCHAR(50),
Notes VARCHAR(MAX)
)
 
INSERT INTO Employees
VALUES
('Velizar', 'Velikov', 'Receptionist', 'Nice customer'),
('Ivan', 'Ivanov', 'Concierge', 'Nice one'),
('Elisaveta', 'Bagriana', 'Cleaner', 'Poetesa')
 
CREATE TABLE Customers(
Id INT PRIMARY KEY IDENTITY NOT NULL,
AccountNumber BIGINT,
FirstName VARCHAR(50),
LastName VARCHAR(50),
PhoneNumber VARCHAR(15),
EmergencyName VARCHAR(150),
EmergencyNumber VARCHAR(15),
Notes VARCHAR(100)
)
 
INSERT INTO Customers
VALUES
(123456789, 'Ginka', 'Shikerova', '359888777888', 'Sistry mi', '7708315342', 'Kinky'),
(123480933, 'Chaika', 'Stavreva', '359888777888', 'Sistry mi', '7708315342', 'Lawer'),
(123454432, 'Mladen', 'Isaev', '359888777888', 'Sistry mi', '7708315342', 'Wants a call girl')
 
CREATE TABLE RoomStatus(
Id INT PRIMARY KEY IDENTITY NOT NULL,
RoomStatus BIT,
Notes VARCHAR(MAX)
)
 
INSERT INTO RoomStatus(RoomStatus, Notes)
VALUES
(1,'Refill the minibar'),
(2,'Check the towels'),
(3,'Move the bed for couple')
 
CREATE TABLE RoomTypes(
RoomType VARCHAR(50) PRIMARY KEY,
Notes VARCHAR(MAX)
)
 
INSERT INTO RoomTypes (RoomType, Notes)
VALUES
('Suite', 'Two beds'),
('Wedding suite', 'One king size bed'),
('Apartment', 'Up to 3 adults and 2 children')
 
CREATE TABLE BedTypes(
BedType VARCHAR(50) PRIMARY KEY,
Notes VARCHAR(MAX)
)
 
INSERT INTO BedTypes
VALUES
('Double', 'One adult and one child'),
('King size', 'Two adults'),
('Couch', 'One child')
 
CREATE TABLE Rooms (
RoomNumber INT PRIMARY KEY IDENTITY NOT NULL,
RoomType VARCHAR(50) FOREIGN KEY REFERENCES RoomTypes(RoomType),
BedType VARCHAR(50) FOREIGN KEY REFERENCES BedTypes(BedType),
Rate DECIMAL(6,2),
RoomStatus NVARCHAR(50),
Notes NVARCHAR(MAX)
)
 
INSERT INTO Rooms (Rate, Notes)
VALUES
(12,'Free'),
(15, 'Free'),
(23, 'Clean it')
 
CREATE TABLE Payments(
Id INT PRIMARY KEY IDENTITY NOT NULL,
EmployeeId INT FOREIGN KEY REFERENCES Employees(Id),
PaymentDate DATE,
AccountNumber BIGINT,
FirstDateOccupied DATE,
LastDateOccupied DATE,
TotalDays AS DATEDIFF(DAY, FirstDateOccupied, LastDateOccupied),
AmountCharged DECIMAL(14,2),
TaxRate DECIMAL(8, 2),
TaxAmount DECIMAL(8, 2),
PaymentTotal DECIMAL(15, 2),
Notes VARCHAR(MAX)
)
 
INSERT INTO Payments (EmployeeId, PaymentDate, AmountCharged)
VALUES
(1, '12/12/2018', 2000.40),
(2, '12/12/2018', 1500.40),
(3, '12/12/2018', 1000.40)
 
CREATE TABLE Occupancies(
Id  INT PRIMARY KEY IDENTITY NOT NULL,
EmployeeId INT FOREIGN KEY REFERENCES Employees(Id),
DateOccupied DATE,
AccountNumber BIGINT,
RoomNumber INT FOREIGN KEY REFERENCES Rooms(RoomNumber),
RateApplied DECIMAL(6,2),
PhoneCharge DECIMAL(6,2),
Notes VARCHAR(MAX)
)
 
INSERT INTO Occupancies (EmployeeId, RateApplied, Notes) VALUES
(1, 55.55, 'too'),
(2, 15.55, 'much'),
(3, 35.55, 'typing')



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
LastName VARCHAR(30),
JobTitle VARCHAR(30) NOT NULL,
DepartmentId INT NOT NULL FOREIGN KEY REFERENCES Departments(Id),
HireDate DATETIME2,
Salary DECIMAL(8,2),
AddressId INT  FOREIGN KEY REFERENCES Addresses(Id)
);


INSERT INTO Towns
VALUES
('Sofia')
,('Plovdiv')
,('Varna')
,('Burgas')

INSERT INTO Departments
VALUES
('Engineering')
,('Sales')
,('Marketing')
,('Software Developmen')
,('Quality Assurance')


INSERT INTO Employees(FirstName,JobTitle,DepartmentId,HireDate,Salary)
VALUES
('IVAN','.NET Developer','Software Development','01/02/2013',3500.00)
,('Petar','Senior Engineer','Engineering','02/03/2004',4000.00)
,('Maria','Intern','Quality Assurance','28/08/2016',525.25)
,('Georgi','CEO','Sales','02/03/2004',4000.00)
,('Peter','Senior Engineer','Engineering','02/03/2004',4000.00)


--19. Basic Select All Fields

SELECT*FROM  Towns
SELECT*FROM  Departments
SELECT*FROM  Employees


--20. Basic Select All Fields and Order Them

SELECT*FROM  Towns ORDER BY [NAME]
SELECT*FROM  Departments ORDER BY [NAME]
SELECT*FROM  Employees ORDER BY Salary DESC

--21. Basic Select Some Fields

SELECT [NAME] FROM  Towns ORDER BY [NAME]
SELECT [NAME] FROM  Departments ORDER BY [NAME]
SELECT FirstName, LastName, JobTitle, Salary  FROM  Employees ORDER BY Salary DESC

--22. Increase Employees Salary

UPDATE Employees
SET Salary*=1.10

SELECT Salary FROM Employees

--23. Decrease Tax Rate

UPDATE Payments
SET TaxRate*=0.97
SELECT TaxRate FROM Payments

--24. Delete All Records

DELETE FROM Occupancies

