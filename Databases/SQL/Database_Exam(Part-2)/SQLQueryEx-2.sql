	Use Library

	/*
	1. Write a query that displays Full name of an employee who has more than
	3 letters in his/her First Name.
	*/

	SELECT Fname + ' ' + Lname As FullName

	FROM Employee
	WHERE LEN(Fname) > 3

	/*
	2. Write a query to display the total number of Programming books
	available in the library with alias name ‘NO OF PROGRAMMING
	BOOKS’
	*/

	SELECT COUNT(*) AS [NO OF PROGRAMMINGBOOKS]
	FROM Book B Cross join Category C
	WHERE Cat_Name = 'Programming'

	/*
	3. Write a query to display the number of books published by
	(HarperCollins) with the alias name 'NO_OF_BOOKS'.
	*/

	SELECT COUNT(*) AS NO_OF_BOOK
	FROM Book B Cross join Publisher 
	WHERE [Name] = 'HarperCollins'

	/*
	4. Write a
	query to display the User SSN and name, date of borrowing and due date of
	the User whose due date is before July 2022.
	*/

	SELECT U.SSN, U.User_Name, B.Borrow_Date, B.Due_Date
	FROM Users U INNER JOIN Borrowing B ON U.SSN = B.User_SSN
	WHERE B.Due_Date < '2022-07-01'

	/*
	5. Write a query to display book title, author name and display in the
	following format,
	' [Book Title] is written by [Author Name].
	*/

	SELECT CONCAT('(', B.Title, ')   is written by -', A.Name, '-') AS BookDetails
	FROM Book B INNER JOIN Book_Author BA ON B.Id = BA.Book_Id
	INNER JOIN Author A ON BA.Author_Id = A.Id

	/*
	6. Write a query to display the name of users who have letter 'A' in their names.
	*/

	SELECT [User_Name] 
	FROM Users
	WHERE [User_Name] LIKE '%A%'

	/*
		7. Write a query that display user SSN who makes the most borrowing
	*/
	SELECT TOP 1 User_SSN 
	FROM Borrowing 
	GROUP BY User_SSN
	ORDER BY COUNT(*) DESC

	/*
	8. Write a query that displays the total amount of money that each user paid
	for borrowing books. 
	*/

	SELECT U.User_Name , SUM(B.Amount) AS [Total_Amount]
	FROM Borrowing B
	INNER JOIN Users U ON B.User_SSN = U.SSN
	WHERE B.Amount > 0
	GROUP BY U.User_Name 


	/*
	9. write a query that displays the category which has the book that has the
	minimum amount of money for borrowing 
	*/

	SELECT C.Cat_name
	FROM Category C
	INNER JOIN Book B ON C.Id = B.Cat_Id
	WHERE B.Id = (
		SELECT TOP 1 Book_Id
		FROM Borrowing
		ORDER BY Amount ASC
	)

	/*
	10.write a query that displays the email of an employee if it's not found,
	display address if it's not found, display date of birthday.
	*/

	SELECT 
		CASE 
			WHEN Email IS NOT NULL THEN Email
			WHEN [Address] IS NOT NULL THEN [Address]
			ELSE CONVERT(VARCHAR, DOB, 103) 
		END AS Employee_Contact
	FROM Employee

	/*
		11.Write a query to list the category and number of books in each category
		with the alias name 'Count Of Books'.
	*/

	SELECT C.Cat_name AS Category, COUNT(B.Id) AS [Count Of Books]
	FROM Category C
	INNER JOIN Book B ON C.Id = B.Cat_Id
	GROUP BY C.Cat_name

	/*
	12.Write a query that display books id which is not found in floor num = 1
	and shelf-code = A1
	*/

	SELECT B.id AS BookId
	FROM Book B
	WHERE NOT EXISTS (
		SELECT 1 
		FROM Floor F 
		WHERE F.Number = 1  AND B.Shelf_Code = 'A1' 
	)

	/*
	13.Write a query that displays the floor number , Number of Blocks and
	number of employees working on that floor.{
	*/

	SELECT F.Number AS FloorNumber, 
		   F.Num_Blocks AS NumberOfBlocks, 
		   COUNT(E.Id) AS NumberOfEmployees
	FROM Floor F
	LEFT JOIN Employee E ON F.Number = E.id
	GROUP BY F.Number, F.Num_Blocks

	/*
	14.Display Book Title and User Name to designate Borrowing that occurred
	within the period ‘3/1/2022’ and ‘10/1/2022’.
	*/

	SELECT B.title AS BookTitle, U.User_Name AS UserName
	FROM Borrowing Br
	INNER JOIN Book B ON Br.Book_Id = B.id
	INNER JOIN Users U ON Br.User_SSN = U.SSN
	WHERE Br.Borrow_Date BETWEEN '2022-03-01' AND '2022-10-01'

	/*
	15.Display Employee Full Name and Name Of his/her Supervisor as
	Supervisor Name.
	*/

	SELECT 
	E.Fname + ' ' + E.Lname AS Employee_Name, 
	S.Fname + ' ' + S.Lname AS Supervisor_Name
	FROM Employee E LEFT JOIN Employee S ON E.Super_id = S.id

	/*
	16.Select Employee name and his/her salary but if there is no salary display
	Employee bonus.
	*/

	SELECT E.Fname + ' ' + E.Lname AS EmployeeName,
	CASE 
	WHEN E.Salary IS NOT NULL THEN E.Salary
	ELSE E.Bouns END AS SalaryOrBonus
	FROM Employee E

	/*
	17.Display max and min salary for Employees 
	*/

	SELECT MAX(Salary) AS MaxSalary, MIN(Salary) AS MinSalary
	FROM Employee

	/*
	18.Write a function that take Number and display if it is even or odd
	*/

	CREATE FUNCTION CheckEvenOdd (@Number INT)
	RETURNS VARCHAR(10)
	AS
	BEGIN
		DECLARE @Result VARCHAR(10)
		IF @Number % 2 = 0 SET @Result = 'Even'
		ELSE SET @Result = 'Odd'  
		RETURN @Result
	END
	SELECT dbo.CheckEvenOdd(2) --Ex
	SELECT dbo.CheckEvenOdd(5)	--Ex

	/*
	19.write a function that take category name and display Title of books in that
	category 
	*/

	CREATE FUNCTION GetBooksByCategory (@CategoryName VARCHAR(100))
	RETURNS TABLE
	AS
	RETURN
		SELECT B.Title
		FROM Book B
		INNER JOIN Category C ON B.Cat_Id = C.Id
		WHERE C.Cat_name = @CategoryName
	GO
	SELECT * FROM dbo.GetBooksByCategory('Programming')

	/*
	20. write a function that takes the phone of the user and displays Book Title ,
	user-name, amount of money and due-date. 
	*/
	CREATE FUNCTION GetBookDetailsByPhone (@Phone VARCHAR(15))
	RETURNS TABLE
	AS
	RETURN
		SELECT 
			B.Title AS BookTitle, 
			U.User_Name AS UserName,  
			Br.Amount AS AmountPaid, 
			Br.Due_date AS DueDate 
		FROM Borrowing Br
		INNER JOIN Book B ON Br.Book_id = B.id  
		INNER JOIN Users U ON Br.User_SSN = U.SSN  
		INNER JOIN User_phones UP ON U.SSN = UP.User_SSN 
		WHERE UP.Phone_num = @Phone  
	GO

	SELECT * FROM dbo.GetBookDetailsByPhone('0123654122') -- Test
	SELECT * FROM dbo.GetBookDetailsByPhone('0125055151') --Test


/*
21.Write a function that take user name and check if it's duplicated
return Message in the following format ([User Name] is Repeated
[Count] times) if it's not duplicated display msg with this format [username] 
is not duplicated,if it's not Found Return [User Name] is Not
Found {
*/

CREATE FUNCTION CheckUserNameDuplication (@UserName VARCHAR(255))
RETURNS VARCHAR(255)
AS
BEGIN
    DECLARE @ResultMessage VARCHAR(255)
    DECLARE @UserCount INT
    SELECT @UserCount = COUNT(*)
    FROM Users
    WHERE User_Name = @UserName
    IF @UserCount = 0
    BEGIN
        SET @ResultMessage = @UserName + ' is Not Found'
    END
    ELSE IF @UserCount > 1
    BEGIN
        SET @ResultMessage = @UserName + ' is Repeated ' + CAST(@UserCount AS VARCHAR) + ' times'
    END
	ELSE
	BEGIN
		SET @ResultMessage = @UserName + ' is not duplicated'
	END
	RETURN @ResultMessage
	END;
	GO

	SELECT dbo.CheckUserNameDuplication('Ahmed') --Test

/*
29.In the Floor table insert new Floor With Number of blocks 2 , employee
with SSN = 20 as a manager for this Floor,The start date for this manager
is Now. Do what is required if you know that : Mr.Omar Amr(SSN=5)
moved to be the manager of the new Floor (id = 7), and they give Mr. Ali
Mohamed(his SSN =12) His position .
*/

INSERT INTO Floor (Number, Num_Blocks, MG_id, Hiring_Date)
VALUES (7, 2, 20, GETDATE());
UPDATE Floor
SET MG_id = 5
WHERE Number = 7;
UPDATE Floor
SET MG_id = 12 
WHERE MG_id = 5; 
