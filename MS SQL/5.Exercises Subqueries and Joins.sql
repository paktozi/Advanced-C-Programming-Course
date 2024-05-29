

--Exercises: Subqueries and Joins


--1. Employee Address

SELECT TOP (5) e.EmployeeID,e.JobTitle,e.AddressID,a.AddressText 
FROM Employees AS e
JOIN Addresses AS a ON
e.AddressID=a.AddressID
ORDER BY a.AddressID

--2. Addresses with Towns

SELECT TOP (50) e.FirstName,e.LastName,t.[Name] AS Town,a.AddressText AddressText 
FROM Employees AS e
JOIN Addresses AS a ON e.AddressID=a.AddressID
JOIN Towns AS t ON a.TownID=t.TownID
ORDER BY e.FirstName,e.LastName

--3. Sales Employee

SELECT e.EmployeeID,e.FirstName,e.LastName,d.[Name]
FROM Employees AS e
JOIN Departments AS d 
ON e.DepartmentID=d.DepartmentID
WHERE  d.[Name]='Sales'
ORDER BY e.EmployeeID

--4. Employee Departments

SELECT TOP (5) e.EmployeeID,e.FirstName,e.Salary,d.[Name] 
FROM Employees AS e
JOIN Departments AS d 
ON e.DepartmentID=d.DepartmentID
WHERE e.Salary>15000
ORDER BY d.DepartmentID 


--5. Employees Without Project

        --VAR1

SELECT TOP(3) EmployeeID, FirstName 
FROM Employees
WHERE EmployeeID NOT IN (SELECT DISTINCT EmployeeID FROM EmployeesProjects )
ORDER BY EmployeeID

        --VAR2
SELECT TOP(3) e.EmployeeID,e.FirstName
FROM Employees AS e
 LEFT JOIN EmployeesProjects AS ep 
ON e.EmployeeID=ep.EmployeeID
 WHERE ep.EmployeeID IS NULL

     --VAR3


 --6. Employees Hired After


 SELECT FirstName,LastName,HireDate,d.[Name] AS DeptName FROM Employees AS e
 JOIN Departments AS d ON d.DepartmentID=e.DepartmentID
 WHERE HireDate>'1-1-1999' AND d.[Name] IN ('Finance','Sales')
 ORDER BY HireDate

 --7. Employees with Project

 SELECT TOP(5) e.EmployeeID,FirstName,p.[Name] AS ProjectName 
 FROM Employees AS e
 JOIN EmployeesProjects AS ep ON e.EmployeeID=ep.EmployeeID
 JOIN Projects AS p ON p.ProjectID=ep.ProjectID
 WHERE p.StartDate>'08-13-2002' AND p.EndDate IS NULL
 ORDER BY e.EmployeeID

 --8. Employee 24


 SELECT e.EmployeeID,FirstName,
   [Name] = CASE
   WHEN DATEPART(YEAR,StartDate)>2004  THEN  NULL
   ELSE[Name]
 END
 FROM Employees AS e
 JOIN EmployeesProjects AS ep ON e.EmployeeID=ep.EmployeeID
 JOIN Projects AS p ON p.ProjectID=ep.ProjectID
 WHERE e.EmployeeID=24
  
 --9. Employee Manager

SELECT  e.EmployeeID,e.FirstName,e.ManagerID,MGR.FirstName FROM Employees AS e
JOIN Employees AS mgr ON mgr.EmployeeID=e.ManagerID
WHERE E.ManagerID IN (3,7)
ORDER BY e.EmployeeID

--10. Employees Summary

SELECT TOP(50)
	emp.EmployeeID,
	CONCAT_WS(' ', emp.FirstName, emp.LastName) AS EmployeeName,
	CONCAT_WS(' ', mgr.FirstName, mgr.LastName) AS ManagerName,
	d.[Name] AS DepartmentName
FROM Employees AS emp
JOIN Employees AS mgr ON emp.ManagerID = mgr.EmployeeID
JOIN Departments AS d on d.DepartmentID = emp.DepartmentID
ORDER BY emp.EmployeeID

--11. Min Average Salary

SELECT TOP(1) AVG(Salary) AS MinAvrSalary 
FROM Employees
GROUP BY DepartmentID
ORDER BY MinAvrSalary
 

 --12. Highest Peaks in Bulgaria

SELECT
c.CountryCode,
m.MountainRange,
p.PeakName,
p.Elevation  
FROM Countries AS c
JOIN MountainsCountries AS mc ON c.CountryCode=mc.CountryCode
JOIN Mountains AS m ON m.Id=mc.MountainId
JOIN Peaks AS p ON p.MountainId=m.Id
WHERE C.CountryName='Bulgaria' AND P.Elevation>2835
ORDER BY P.Elevation DESC

--13. Count Mountain Ranges

SELECT 
c.CountryCode,
COUNT(DISTINCT m.MountainRange)  AS MountainRanges 
FROM Countries AS c
JOIN MountainsCountries AS ms ON c.CountryCode=ms.CountryCode
JOIN Mountains AS m ON m.Id=ms.MountainId
WHERE C.CountryCode IN ('US','BG','RU')
GROUP BY C.CountryCode

--14. Countries With or Without Rivers

SELECT TOP(5)
c.CountryName,
r.RiverName
FROM Countries AS c
LEFT JOIN CountriesRivers AS cr ON c.CountryCode=cr.CountryCode
LEFT JOIN Rivers AS r ON cr.RiverId=r.Id
LEFT JOIN Continents AS cn ON c.ContinentCode=cn.ContinentCode
WHERE cn.ContinentName='Africa'
 ORDER BY c.CountryName


	

 --15. *Continents and Currencies




--16. Countries Without Any Mountains
SELECT COUNT(*)  FROM  Countries
WHERE CountryCode NOT IN (SELECT DISTINCT CountryCode FROM MountainsCountries)

--17. Highest Peak and Longest River by Country

SELECT top(5) c.CountryName,
 MAX(p.Elevation) AS HighestPeakElevation,
  MAX( r.[Length])AS LongestRiverLength
FROM Countries AS c
LEFT JOIN MountainsCountries AS mc ON c.CountryCode=mc.CountryCode
LEFT JOIN Mountains AS m ON m.Id=mc.MountainId
LEFT JOIN Peaks AS p ON p.MountainId=m.Id
LEFT JOIN CountriesRivers AS cr ON cr.CountryCode=c.CountryCode
LEFT JOIN Rivers AS r ON r.Id=cr.RiverId
GROUP BY (c.CountryName)
ORDER BY HighestPeakElevation DESC,LongestRiverLength DESC,c.CountryName


--18. Highest Peak Name and Elevation by Country


WITH PeaksRankedByElevation AS 
(
	SELECT
		c.CountryName,
		p.PeakName,
		p.Elevation,
		m.MountainRange,
		DENSE_RANK() OVER
			(PARTITION BY c.CountryName ORDER BY Elevation DESC) AS PeakRank
	FROM Countries AS c
	LEFT JOIN MountainsCountries AS mc ON c.CountryCode = mc.CountryCode
	LEFT JOIN Mountains AS m ON m.Id = mc.MountainId
	LEFT JOIN Peaks AS p ON m.Id = p.MountainId
)

SELECT TOP(5)
	CountryName AS Country,
	ISNULL(PeakName, '(no highest peak)') AS [Highest Peak Name],
	ISNULL(Elevation, 0) AS [Highest Peak Elevation],
	ISNULL(MountainRange, '(no mountain)') AS Mountain
FROM PeaksRankedByElevation
WHERE PeakRank = 1
ORDER BY 
	CountryName, [Highest Peak Name]