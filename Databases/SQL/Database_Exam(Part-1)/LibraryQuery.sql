create database Library
USE Library
-- Implementation Step (Convert Schema into Real(DB))
CREATE TABLE Employee
(
	Emp_Id INT  Primary Key,
	Fname VARCHAR(30),
	Lname VARCHAR(30),
	Email VARCHAR(100),
	PhoneNumber NVARCHAR(100),
	DateOfBirth DATE,
	Salary DECIMAL(10,2),
	BOUNS DECIMAL(10,2),
	Supervisor_Id INT ,
	Floor_Id INT, -- Alter
	FOREIGN KEY (Supervisor_Id) REFERENCES Employee(Emp_Id)
)
CREATE TABLE Author
(
	Author_Id INT PRIMARY KEY,
	Name NVARCHAR(100)
)
CREATE TABLE Category (
    Category_Id INT PRIMARY KEY,
    Cat_Name NVARCHAR(50)
);

CREATE TABLE [Floor] (
    Floor_Id INT PRIMARY KEY,
    FloorNumber INT,
    NumOfBlocks INT,
    HiringDate DATE,
    Manager_Id INT,
    FOREIGN KEY (Manager_Id) REFERENCES Employee(Emp_Id)
);
CREATE TABLE [User](
	SSN NVARCHAR(15) PRIMARY KEY,
	[Name] NVARCHAR(30),
	Email VARCHAR(100),
	Phone VARCHAR(15),
	Recorded_By INT,
	FOREIGN KEY (Recorded_By) REFERENCES Employee(Emp_Id)
)
CREATE TABLE Publisher(
	Publisher_Id INT PRIMARY KEY,
	[Name] NVARCHAR(100)
)
CREATE TABLE Book
(
	Book_Id INT PRIMARY KEY,
	Title NVARCHAR(100),
	Shelf_Code INT,
	Category_Id INT,
	Publisher_Id INT,
	FOREIGN KEY (Shelf_Code) REFERENCES Employee(Emp_Id),
	FOREIGN KEY (Category_Id) REFERENCES Category(Category_Id),
	FOREIGN KEY (Publisher_Id) REFERENCES Publisher(Publisher_Id)
)
CREATE TABLE Shelf
(
	Shelf_Code INT	PRIMARY KEY,
	Floor_id INT,
	FOREIGN KEY (Floor_id) REFERENCES [Floor](Floor_id)
)
CREATE TABLE Borrow_Record
(
	Borrow_Id INT PRIMARY KEY,
	User_SSN NVARCHAR(15),
	Book_Id INT,
	Employee_Id INT,
	Date_Borrowed DATE,
	Due_Date DATE,
	Amount DECIMAL(10,2),
	FOREIGN KEY (User_SSN) REFERENCES [User](SSN),
	FOREIGN KEY (Book_Id) REFERENCES Book (Book_Id),
	FOREIGN KEY (Employee_Id) REFERENCES Employee(Emp_Id),
)

CREATE TABLE Supervises
(
	Supervisor_Id INT,
	Emp_Id INT,
	PRIMARY KEY (Supervisor_Id,Emp_Id), --Composite Key 
	FOREIGN KEY (Supervisor_Id) REFERENCES Employee(Emp_Id),
	FOREIGN KEY (Emp_Id) REFERENCES Employee(Emp_Id),
)
CREATE TABLE BORROW (
	User_SSN NVARCHAR(15),
	Book_Id INT,
	PRIMARY KEY(User_SSN , Book_Id),
	FOREIGN KEY (User_SSN) REFERENCES [User](SSN),
	FOREIGN KEY (Book_Id) REFERENCES Book (Book_Id),
)

CREATE TABLE isWritten
(
	Author_Id INT,
	Book_Id INT,
	PRIMARY KEY (Author_Id , Book_Id),
	FOREIGN KEY (Author_Id) REFERENCES Author (Author_Id),
	FOREIGN KEY (Book_Id) REFERENCES Book (Book_Id),
)
ALTER TABLE Employee
ADD FOREIGN KEY(Floor_Id) REFERENCES [Floor](Floor_Id)