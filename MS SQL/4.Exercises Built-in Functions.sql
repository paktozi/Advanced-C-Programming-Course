
--Exercises: Built-in Functions


--01. Find Names of All Employees by First Name

SELECT FirstName,LastName FROM Employees
WHERE FirstName LIKE 'Sa%'

           --VAR.2
SELECT FirstName,LastName FROM Employees
WHERE LEFT(FirstName,2)='SA'

          --VAR.3
SELECT FirstName,LastName FROM Employees
WHERE SUBSTRING(FirstName, 1,2)='SA'

--2. Find Names of All Employees by Last Name

SELECT FirstName,LastName  FROM Employees
WHERE LastName LIKE '%ei%'


--03. Find First Names of All Employees

SELECT FirstName FROM Employees
WHERE DepartmentID IN(3,10) AND 
DATEPART(YEAR,HireDate) BETWEEN '1995' AND '2005'


          --VAR.2
SELECT FirstName FROM Employees
WHERE DepartmentID IN(3,10) AND 
YEAR(HireDate) BETWEEN '1995' AND '2005'

    
	  -- SELECT DATEPART(DAY,'2024/03/03')    GET DAY FROM DATE
		 -- SELECT DATENAME(WEEKDAY,'2024/03/03')

--4. Find All Employees Except Engineers

SELECT FirstName,LastName FROM Employees
WHERE JobTitle  NOT LIKE '%engineer%'


--5. Find Towns with Name Length

SELECT [Name]  FROM Towns
WHERE  LEN([Name]) IN (5,6)
ORDER BY [Name]

--6. Find Towns Starting With

SELECT TownID, [Name]FROM Towns
WHERE LEFT([NAME],1) IN ('M','K','B','E')
ORDER BY [Name]

              --VAR2

   SELECT TownID,[Name]  FROM Towns
   WHERE SUBSTRING([Name],1,1) IN ('M','K','B','E')
   ORDER BY [Name]

              --VAR3

   SELECT TownID,[Name]  FROM Towns
   WHERE [Name] LIKE '[MKBE]%'
   ORDER BY [Name]

   --7. Find Towns Not Starting With

   SELECT TownID,[Name] FROM Towns
   WHERE [Name] NOT LIKE '[RBD]%'
   ORDER BY [Name]
      
	  ---VAR2
	   
	   SELECT TownID,[Name] FROM Towns
   WHERE [Name]  LIKE '[^RBD]%'
   ORDER BY [Name]

   --8. Create View Employees Hired After 2000 Year

   CREATE VIEW  V_EmployeesHiredAfter2000 
   AS SELECT FirstName,LastName 
   FROM Employees
   WHERE DATEPART(YEAR,HireDate)>2000

   SELECT* FROM V_EmployeesHiredAfter2000 

   --9. Length of Last Name

   SELECT FirstName,LastName FROM Employees
   WHERE LEN(LastName)=5

   --10. Rank Employees by Salary

   SELECT EmployeeID,FirstName,LastName,Salary, 
   DENSE_RANK() OVER 
   (PARTITION BY Salary ORDER BY EmployeeID) AS [Rank]
   FROM Employees
   WHERE Salary BETWEEN 10000 AND 50000
   ORDER BY Salary DESC

   --11. Find All Employees with Rank 2

   WITH CTE_RankedEmployees AS
   (
   SELECT EmployeeID,FirstName,LastName,Salary, 
   DENSE_RANK() OVER 
   (PARTITION BY Salary ORDER BY EmployeeID) AS [Rank]
   FROM Employees
   WHERE Salary BETWEEN 10000 AND 50000
   
   )

   SELECT*FROM CTE_RankedEmployees WHERE [RANK]=2
   ORDER BY Salary DESC

   --12. Countries Holding 'A' 3 or More Times


   SELECT CountryName,IsoCode FROM Countries
   WHERE CountryName LIKE '%a%a%a%'
   ORDER BY IsoCode


   --13. Mix of Peak and River Names

   SELECT PeakName,RiverName,
   LOWER(CONCAT(PeakName, SUBSTRING(RiverName,2,LEN(RiverName)))) AS Mix
   FROM Peaks,Rivers 
   WHERE RIGHT(PeakName,1)=LEFT(RiverName,1)
   ORDER BY Mix
     
	 ---VAR2

	 SELECT PeakName,RiverName,
    LOWER(CONCAT( SUBSTRING(PeakName,1,LEN(PeakName)-1), RiverName)) AS Mix
    FROM Peaks,Rivers 
    WHERE RIGHT(PeakName,1)=LEFT(RiverName,1)
    ORDER BY Mix

	--14. Games from 2011 and 2012 Year

SELECT TOP(50) [Name],FORMAT([Start],'yyyy-MM-dd') AS [Start] FROM Games
WHERE  DATEPART(YEAR,[Start])  BETWEEN '2011' AND '2012'
ORDER BY [Start],[Name]


--15. User Email Providers

  SELECT Username, SUBSTRING(Email,CHARINDEX('@',Email)+1,LEN(Email)) AS [Email Provider]  FROM Users
  ORDER BY [Email Provider],Username

  --16. Get Users with IP Address Like Pattern

  SELECT Username,IpAddress FROM Users
  WHERE IpAddress LIKE '___.1_%._%.___'
  ORDER BY Username