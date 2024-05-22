--Exercises: Table Relations


--1. One-To-One Relationship

CREATE TABLE Passports
(
PassportID INT PRIMARY KEY IDENTITY(101,1),
PassportNumber VARCHAR(15)NOT NULL
);

CREATE TABLE Persons
(
PersonID INT PRIMARY KEY IDENTITY,
FirstName VARCHAR(50)NOT NULL,
Sallary DECIMAL(7,2)NOT NULL,
PassportID INT UNIQUE FOREIGN KEY REFERENCES Passports(PassportID)
);

INSERT INTO Passports
VALUES
('4S5ER8YU')
,('DF84F5TY')
,('85TYH1L9')

INSERT INTO Persons
VALUES
('IVO',5214.12,101)
,('VALQ',5000.10,102)
,('ICO',4214.17,103)

SELECT*FROM Persons
SELECT*FROM Passports

--2. One-To-Many Relationship

CREATE TABLE Manufacturers(
ManufacturesID INT PRIMARY KEY IDENTITY,
[Name]VARCHAR(30) NOT NULL,
EstablishedOn DATE
);

CREATE TABLE Models(
ModelID INT PRIMARY KEY IDENTITY(101,1),
[Name] VARCHAR(30) NOT NULL,
ManufacturerID INT FOREIGN KEY REFERENCES Manufacturers(ManufacturesID)
);

INSERT INTO Manufacturers
VALUES
('BMW','07/03/1916')
,('Tesla','01/01/2003')
,('Lada','01/05/1966')

INSERT INTO Models
VALUES
('X1',1)
,('i6',1)
,('Model S',2)
,('Model X',2)
,('Model 3',2)
,('NOVA',3)

--3. Many-To-Many Relationship

CREATE TABLE Students
(
StudentID INT PRIMARY KEY IDENTITY,
[Name] VARCHAR(30) NOT NULL,
);

CREATE TABLE Exams
(
ExamID INT PRIMARY KEY IDENTITY(101,1),
[Name] VARCHAR(30)NOT NULL
);

CREATE TABLE StudentsExams
(
StudentID INT FOREIGN KEY REFERENCES Students(StudentID),
ExamID INT FOREIGN KEY REFERENCES Exams(ExamID),
PRIMARY KEY(StudentID,ExamID)
);

INSERT INTO Students
VALUES
('Mila')
,('Toni')
,('Ron')

INSERT INTO Exams
VALUES
('C#')
,('JAVA')
,('DB')

INSERT INTO StudentsExams
VALUES
(1,101)
,(1,102)
,(2,101)

--4. Self-Referencing

CREATE TABLE Teachers
(
TeacherID INT PRIMARY KEY,
[Name]VARCHAR(30) NOT NULL,
ManagerID INT REFERENCES Teachers(TeacherID)
);

INSERT INTO Teachers
VALUES
(101,'John',NULL)
,(102,'Maya',106)
,(103,'Silvia',106)
,(104,'Ted',105)
,(105,'Mark',101)
,(106,'Greta',101)

--5. Online Store Database

CREATE TABLE ItemTypes
(
ItemTypeID INT PRIMARY KEY IDENTITY,
[Name]VARCHAR(30)NOT NULL
);

CREATE TABLE Items
(
ItemID INT PRIMARY KEY IDENTITY,
[Name] VARCHAR(30) NOT NULL,
ItemTypeID INT FOREIGN KEY REFERENCES ItemTypes(ItemTypeID)
);


CREATE TABLE Cities
(
CityID INT PRIMARY KEY IDENTITY,
[Name]VARCHAR(30)NOT NULL
);


CREATE TABLE Customers
(
CustomerID INT PRIMARY KEY IDENTITY,
[Name]VARCHAR(30)NOT NULL,
Birthday DATE,
CityID INT FOREIGN KEY REFERENCES Cities(CityID)
);

CREATE TABLE Orders
(
OrderID INT PRIMARY KEY IDENTITY,
CustomerID INT FOREIGN KEY REFERENCES Customers(CustomerID)
);

CREATE TABLE OrderItems
(
OrderID INT FOREIGN KEY REFERENCES Orders(OrderID),
ItemID INT FOREIGN KEY REFERENCES Items(ItemID),
PRIMARY KEY (OrderID,ItemID)
);


--6. University Database

CREATE TABLE Majors
(
MajorID INT PRIMARY KEY IDENTITY,
[Name] VARCHAR(35)NOT NULL
);



CREATE TABLE Subjects
(
SubjectID INT PRIMARY KEY IDENTITY,
SubjectName VARCHAR(30) NOT NULL,
);

CREATE TABLE Students
(
  StudentID INT PRIMARY KEY IDENTITY,
  StudentNumber INT NOT NULL,
  StudentName VARCHAR(30)NOT NULL,
  MajorID INT FOREIGN KEY REFERENCES Majors(MajorID)
);


CREATE TABLE Payments
(
PaymentID INT PRIMARY KEY IDENTITY,
PaymentDate DATETIME2,
PaymentAmount INT,
StudentID INT FOREIGN KEY REFERENCES Students(StudentID)

);

CREATE TABLE Agenda
(
   StudentID INT FOREIGN KEY REFERENCES Students(StudentID),
   SubjectID INT FOREIGN KEY REFERENCES Subjects(SubjectID),
   PRIMARY KEY(StudentID,SubjectID)
);


--9. *Peaks in Rila

SELECT m.MountainRange, p.PeakName,p.Elevation FROM Peaks AS p
JOIN Mountains AS m ON
p.MountainId=m.Id
WHERE MountainRange='Rila'
ORDER BY Elevation DESC

