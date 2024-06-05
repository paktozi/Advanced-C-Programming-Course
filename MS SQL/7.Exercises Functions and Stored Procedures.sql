
--Exercises: Functions and Stored Procedures
 


CREATE PROCEDURE usp_GetEmployeesSalaryAboveNumber @Salary DECIMAL(18,4)
AS
BEGIN
  SELECT FirstName, LastName
  FROM Employees
  WHERE Salary >= @Salary;
END;

EXEC usp_GetEmployeesSalaryAboveNumber 48100

--3. Town Names Starting With

CREATE PROCEDURE usp_GetTownsStartingWith(@StartingString VARCHAR(255))
AS
BEGIN
  SELECT
    [Name]
  FROM Towns
  WHERE [Name] LIKE @StartingString + '%';   --CONCAT( @StartingString,'%')
END;

EXEC usp_GetTownsStartingWith 'b'


--4. Employees from Town

CREATE PROCEDURE usp_GetEmployeesFromTown(@TownName VARCHAR(50))
AS
BEGIN
SELECT
FirstName,
LastName
FROM Employees AS e
JOIN Addresses AS a ON e.AddressID=a.AddressID
JOIN Towns AS t ON t.TownID=a.TownID
WHERE t.[Name]=@TownName
END;


EXEC usp_GetEmployeesFromTown 'Sofia'


--5. Salary Level Function

CREATE  FUNCTION ufn_GetSalaryLevel(@Salary DECIMAL(18,4)) 
RETURNS VARCHAR(10) AS 
BEGIN 
	DECLARE @SalaryLevel VARCHAR(10) 
	
	IF(@Salary < 30000)	
	 SET @SalaryLevel = 'Low'
	
	ELSE IF(@Salary >= 30000 AND @Salary <= 50000)	--(@Salary BETWEEN 30000 AND  50000)
	 SET @SalaryLevel = 'Average'
	
	ELSE 	
	 SET @SalaryLevel = 'High'
	
RETURN @SalaryLevel
END

SELECT
Salary,
dbo.ufn_GetSalaryLevel(Salary)
FROM Employees


--6. Employees by Salary Level

CREATE PROCEDURE usp_EmployeesBySalaryLevel @SalaryLevel VARCHAR(30)
AS 
BEGIN 

SELECT
FirstName AS 'First Name',
LastName AS  'Last Name'
FROM Employees
WHERE dbo.ufn_GetSalaryLevel(Salary)=@SalaryLevel

END


EXECUTE usp_EmployeesBySalaryLevel 'Low'


--7. Define Function

CREATE FUNCTION ufn_IsWordComprised(@setOfLetters VARCHAR(MAX),@word VARCHAR(MAX))
RETURNS BIT
AS

BEGIN 
    DECLARE @WordLingth INT =LEN(@word)
	DECLARE @Iterator INT=1

	WHILE(@Iterator<=@WordLingth)
	BEGIN
	    
		IF(CHARINDEX( SUBSTRING(@word,@Iterator,1),@setOfLetters)=0)		 
		RETURN 0
		SET @Iterator+=1
	END

	RETURN 1
END


--8. Delete Employees and Departments


CREATE PROCEDURE usp_DeleteEmployeesFromDepartment @departmentId INT
AS 
BEGIN




END


--9. Find Full Name


CREATE PROCEDURE usp_GetHoldersFullName
AS

BEGIN

SELECT
CONCAT_WS(' ',FirstName,LastName) AS 'Full Name'
FROM AccountHolders

END

EXECUTE usp_GetHoldersFullName


--10. People with Balance Higher Than


CREATE PROCEDURE usp_GetHoldersWithBalanceHigherThan @amount MONEY
AS
BEGIN 
SELECT
FirstName,
LastName
FROM AccountHolders AS ah
JOIN Accounts AS ac ON ah.Id=ac.AccountHolderId
GROUP BY FirstName,LastName
HAVING SUM(ac.Balance)>@amount
ORDER BY FirstName,LastName
END

EXECUTE usp_GetHoldersWithBalanceHigherThan 50000


--11. Future Value Function


CREATE FUNCTION ufn_CalculateFutureValue (@sum DECIMAL(10,4),@interestrate FLOAT,@term INT)
RETURNS DECIMAL(10,4)
AS

BEGIN
RETURN @sum*(POWER((1+@interestrate),@term))
END


--12. Calculating Interest


CREATE PROCEDURE usp_CalculateFutureValueForAccount(@accountId INT ,@interestRate FLOAT)
AS 
DECLARE @term INT=5 
BEGIN 
SELECT
ah.Id,
FirstName AS [First Name],
LastName AS [Last Name],
a.Balance AS [Current Balance],
dbo.ufn_CalculateFutureValue(Balance,@interestrate,@term) AS [Balance in 5 years]
FROM AccountHolders AS ah
JOIN Accounts AS a ON ah.Id=a.Id
WHERE a.Id=@accountId
END

EXECUTE usp_CalculateFutureValueForAccount 1,0.05 



