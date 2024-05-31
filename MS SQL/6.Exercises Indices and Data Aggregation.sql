
--Exercises: Indices and Data Aggregation


--1. Records' Count

SELECT COUNT(*)AS [Count] 
FROM WizzardDeposits 

--2. Longest Magic Wand


SELECT MAX(MagicWandSize) AS LongestMagicWand
FROM WizzardDeposits

--3. Longest Magic Wand Per Deposit Groups

SELECT DepositGroup,MAX(MagicWandSize) AS LongestMagicWand
FROM WizzardDeposits
GROUP BY DepositGroup


--4. Smallest Deposit Group Per Magic Wand Size

SELECT TOP(2)
DepositGroup
FROM WizzardDeposits
GROUP BY DepositGroup
ORDER BY AVG( MagicWandSize)

--5. Deposits Sum

SELECT DepositGroup,SUM(DepositAmount) AS TotalSum
FROM WizzardDeposits
GROUP BY DepositGroup


--6. Deposits Sum for Ollivander Family

SELECT DepositGroup,
SUM(DepositAmount) AS TotalSum
FROM WizzardDeposits
WHERE MagicWandCreator='Ollivander family'
GROUP BY DepositGroup

--7. Deposits Filter

SELECT 
DepositGroup,
SUM(DepositAmount) AS TotalSum
FROM WizzardDeposits
WHERE MagicWandCreator='Ollivander family'
GROUP BY DepositGroup
HAVING SUM(DepositAmount)<150000 
ORDER BY TotalSum DESC


--8. Deposit Charge

SELECT 
DepositGroup,
MagicWandCreator,
MIN(DepositCharge) AS MinDepositCharge
FROM WizzardDeposits 
GROUP BY DepositGroup,MagicWandCreator
ORDER BY MagicWandCreator,DepositGroup



--9. Age Groups
 SELECT 
 AgeCategory,COUNT(*) AS WizzartCount FROM

(SELECT 
CASE 
  WHEN Age BETWEEN 0 AND 10 THEN '[0-10]'
  WHEN Age BETWEEN 11 AND 20 THEN '[11-20]'
  WHEN Age BETWEEN 21 AND 30 THEN '[21-30]'
  WHEN Age BETWEEN 31 AND 40 THEN '[31-40]'
  WHEN Age BETWEEN 41 AND 50 THEN '[41-50]'
  WHEN Age BETWEEN 51 AND 60 THEN '[51-60]'
  ELSE '[61+]' 
END AS AgeCategory
FROM WizzardDeposits)  AS Query
GROUP BY AgeCategory


--10. First Letter
SELECT FirstLetter FROM

(SELECT
   SUBSTRING(FirstName,1,1) AS FirstLetter
FROM WizzardDeposits
WHERE DepositGroup='Troll Chest'
) AS Query

GROUP BY FirstLetter


--11. Average Interest

SELECT   
  DepositGroup,
 IsDepositExpired,
 AVG(DepositInterest) AS AverageInterest
FROM WizzardDeposits
WHERE DepositStartDate>'01-01-1985'
GROUP BY DepositGroup,IsDepositExpired
ORDER BY DepositGroup DESC,IsDepositExpired




--13. Departments Total Salaries

SELECT 
DepartmentID,
SUM(Salary) AS TotalSalary
FROM Employees
GROUP BY DepartmentID


--14. Employees Minimum Salaries

SELECT  
DepartmentID,
MIN(Salary) AS MinimumSalary
FROM Employees
WHERE HireDate>'01-01-2000'
GROUP BY DepartmentID
HAVING DepartmentID IN (2,5,7)

 
 --15. Employees Average Salaries

SELECT * INTO RichEmployees
 FROM Employees
 WHERE Salary>30000;

 DELETE FROM RichEmployees
 WHERE ManagerID=42

 UPDATE RichEmployees
 SET Salary+=5000
 WHERE DepartmentID=1

 SELECT 
 DepartmentID,
 AVG(Salary) AS AverageSalary

 FROM RichEmployees
 GROUP BY DepartmentID

 --16. Employees Maximum Salaries

 SELECT
 DepartmentID,
 MAX(Salary) AS MaxSalary
 FROM  Employees
 GROUP BY DepartmentID
 HAVING MAX(Salary) NOT  BETWEEN 30000 AND 70000

 --17. Employees Count Salaries


 SELECT  
 COUNT(Salary) AS [Count]
 FROM Employees
 WHERE ManagerID IS NULL