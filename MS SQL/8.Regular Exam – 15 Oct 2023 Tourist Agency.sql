﻿
--Database Basics MS SQL Regular Exam – 15 Oct 2023
           --Tourist Agency
            
CREATE DATABASE TouristAgency

USE TouristAgency

CREATE TABLE Countries
(
Id INT PRIMARY KEY IDENTITY,
[Name]NVARCHAR(50) NOT NULL,
);


CREATE TABLE Destinations
(
Id INT PRIMARY KEY IDENTITY,
[Name] VARCHAR(50) NOT NULL,
CountryId INT NOT NULL FOREIGN KEY REFERENCES Countries(Id)
);


CREATE TABLE Rooms
(
Id INT PRIMARY KEY IDENTITY,
[Type] VARCHAR(40) NOT NULL,
Price DECIMAL(18,2) NOT NULL,
BedCount INT NOT NULL CHECK(BedCount>0 AND BedCount<=10) 
);


CREATE TABLE Hotels
(
Id INT PRIMARY KEY IDENTITY,
[Name]VARCHAR(50) NOT NULL,
DestinationId INT NOT NULL FOREIGN KEY REFERENCES Destinations(Id)
);

 CREATE TABLE Tourists
 (
 Id INT PRIMARY KEY IDENTITY,
 [Name]NVARCHAR(80) NOT NULL,
 PhoneNumber VARCHAR(20) NOT NULL,
 Email VARCHAR(80),
 CountryId INT NOT NULL FOREIGN KEY REFERENCES Countries(Id)
 );

 CREATE TABLE Bookings
 (
  Id INT PRIMARY KEY IDENTITY,
  ArrivalDate DATETIME2 NOT NULL,
  DepartureDate DATETIME2 NOT NULL,
  AdultsCount INT NOT NULL CHECK(AdultsCount>=1 AND AdultsCount<=10),
 ChildrenCount INT NOT NULL CHECK(ChildrenCount>=0 AND ChildrenCount<=9),
 TouristId INT NOT NULL FOREIGN KEY REFERENCES Tourists(Id),
 HotelId INT NOT NULL FOREIGN KEY REFERENCES Hotels(Id),
 RoomId INT NOT NULL FOREIGN KEY REFERENCES Rooms(Id),
 );

 CREATE TABLE HotelsRooms
 (
 HotelId INT NOT NULL FOREIGN KEY REFERENCES Hotels(Id),
 RoomId INT NOT NULL FOREIGN KEY REFERENCES Rooms(Id),
 PRIMARY KEY(HotelId,RoomId)
 );


-----------------------------------------------------

INSERT INTO Tourists
VALUES
('John Rivers','653-551-1555','john.rivers@example.com',6),
('Adeline Aglaé','122-654-8726','adeline.aglae@example.com',2),
('Sergio Ramirez','233-465-2876','s.ramirez@example.com',3),
('Johan Müller','322-876-9826','j.muller@example.com',7),
('Eden Smith','551-874-2234','eden.smith@example.com',6)

INSERT INTO Bookings
VALUES
('2024-03-01','2024-03-11',1,0,21,3,5 ),
('2023-12-28','2024-01-06',2,1,22,13,3),
('2023-11-15','2023-11-20',1,2,23,19,7),
('2023-12-05','2023-12-09',4,0,24,6,4 ),
('2024-05-01','2024-05-07',6,0,25,14,6)

------------------------------------------------------

UPDATE Bookings
SET DepartureDate=DATEADD(DAY,1,DepartureDate)
WHERE ArrivalDate >= '2023-12-01' AND ArrivalDate < '2024-01-01';

UPDATE Tourists
SET Email=NULL
WHERE [Name] LIKE '%MA%';

-------------------------------------


BEGIN TRANSACTION

DECLARE @TouristToDelete TABLE (Id INT)   --  CREATE TABLE WITH TOURIST ID WHO MUST DELETE
INSERT INTO @TouristToDelete (Id)
SELECT Id
FROM Tourists
WHERE [NAME] LIKE '%Smith%'

DELETE FROM Bookings
WHERE TouristId IN (SELECT Id FROM @TouristToDelete)

DELETE FROM Tourists
WHERE Id IN (SELECT Id FROM @TouristToDelete)

COMMIT


   --VAR 2

   DELETE FROM Bookings
   WHERE TouristId IN (SELECT Id FROM Tourists WHERE [NAME] LIKE '%Smith%')

   DELETE FROM Tourists WHERE [NAME] LIKE '%Smith%'



------------------------


DROP DATABASE TouristAgency

USE TouristAgency

	SELECT
	 FORMAT( b.ArrivalDate,'yyyy-MM-dd'),
	b.AdultsCount,
	ChildrenCount
	FROM Bookings AS b
	JOIN Rooms AS r ON b.RoomId=r.Id
	ORDER BY Price DESC,ArrivalDate

	----

		SELECT
		 h.Id,
		 h.[Name]
		FROM Hotels AS h
		 JOIN HotelsRooms AS hr ON hr.HotelId=h.Id
		 JOIN Rooms AS r ON r.Id=hr.RoomId
		JOIN Bookings AS b ON b.HotelId=h.Id AND r.Type='VIP Apartment'
		GROUP BY h.[Name],h.Id
		ORDER BY COUNT(*) DESC
	
	---------------


	SELECT
	Id,
	[Name],
	PhoneNumber
	FROM Tourists 
	WHERE Id  NOT IN (SELECT TouristId FROM Bookings)
	ORDER BY [Name]

	-------------

	SELECT TOP(10)
	   h.[Name] AS 'HotelName',
	   d.[Name] AS 'DestinationName',
	   c.[Name] AS 'CountryName'	
	FROM Bookings AS b
	JOIN Hotels AS h ON h.Id=b.HotelId
	JOIN Destinations AS d ON d.Id=h.DestinationId
	JOIN Countries AS c ON c.Id=d.CountryId
	WHERE ArrivalDate <'2023-12-31' AND  h.Id%2!=0
	ORDER BY c.[Name],b.ArrivalDate


	--------------------
	SELECT 
	H.[Name],
	r.Price
	FROM Bookings AS b 
	JOIN Tourists AS t ON b.TouristId=t.Id
	JOIN Hotels AS h ON h.Id=b.HotelId
	JOIN Rooms AS r ON r.Id=b.RoomId
	WHERE t.[Name]  NOT LIKE '%EZ' AND t.Id IN (B.TouristId)
	ORDER BY r.Price DESC


	-------



	SELECT
	h.[Name] AS HotelName, 
	SUM((DATEDIFF(DAY,b.ArrivalDate,b.DepartureDate))*r.Price) AS HotelRevenue
	FROM Bookings AS b 
	JOIN Hotels AS h ON  b.HotelId=h.Id
    JOIN Rooms AS r ON b.RoomId=r.Id
    GROUP BY h.[Name]
	ORDER BY HotelRevenue DESC

	------------------

	CREATE FUNCTION udf_RoomsWithTourists(@name VARCHAR(50))
	RETURNS INT
	AS 
	
	BEGIN
	RETURN
	  (SELECT
	     SUM(AdultsCount+ChildrenCount)
	     FROM Bookings AS b
	     JOIN Rooms AS r ON r.id=b.RoomId
	     WHERE Type=@name)
	END

	SELECT dbo.udf_RoomsWithTourists('Double Room')

	-------------------------

CREATE PROCEDURE usp_SearchByCountry(@country NVARCHAR(50))
AS	
BEGIN
	SELECT
	t.[Name],
	t.PhoneNumber,
	t.Email,
	COUNT(B.Id) AS BookingsCount	
	FROM Bookings AS b
	JOIN Tourists AS t ON t.Id=b.TouristId
	JOIN Countries AS c ON c.Id=t.CountryId
	WHERE C.Name=@country
	GROUP BY T.Name,T.PhoneNumber,T.Email
	ORDER BY t.[Name],BookingsCount	DESC
END	

EXECUTE dbo.usp_SearchByCountry 'Greece'