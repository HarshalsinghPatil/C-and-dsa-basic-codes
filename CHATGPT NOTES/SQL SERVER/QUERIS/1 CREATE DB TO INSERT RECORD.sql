-- Here we will learn how to create db ,use that db, create table , insert data in that table , 
-- how we can insert calculated columns



CREATE DATABASE HarshalTestDb;

USE HarshalTestDb;

CREATE TABLE Employees (
	EmployeeId INT PRIMARY KEY IDENTITY(1,1),
	FirstName NVARCHAR(30) NOT NULL ,
	LastName NVARCHAR(30) NOT NULL ,
	DOB DATETIME2 NOT NULL,
	Age AS (
		DATEDIFF(YEAR, DOB , GETDATE()) -
			CASE
				WHEN MONTH(DOB) > MONTH(GETDATE())
				OR (MONTH(DOB) = MONTH(GETDATE()) AND DAY(DOB) > DAY(GETDATE()))
				THEN 1
				ELSE 0 
			END
	),
	Salary DECIMAL(10,2),CHECK(Salary >= 0),
	ProfilePic VARBINARY(MAX),
	Email NVARCHAR(100) UNIQUE,
	PhoneNumber NVARCHAR(10) UNIQUE,
	HireDate DATE DEFAULT GETDATE(),
	IsActive BIT DEFAULT 1
);

INSERT INTO Employees(FirstName, LastName,  DOB, Salary, Email, PhoneNumber)
VALUES ('Harshal', 'Patil', '1995-12-10', 28000, 'harshalsinghrajput@stspl.com','1234567890');

SELECT * FROM Employees;

-- restrict data 
--1. use selected columns only
SELECT FirstName, age, salary FROM Employees ;

-- 2. use where column 
SELECT * FROM Employees WHERE SALARY<2000;
SELECT FIRSTNAME, LASTNAME ,Salary FROM Employees WHERE SALARY >= 28000 AND SALARY <30000;

SELECT * FROM EMP;

-- UPDATE 
UPDATE Emp 
set Salary = 1000000
where EmployeeId = 1;
-- or do arithmatic
UPDATE Emp 
set Salary = Salary + 0.4 * Salary
where EmployeeId = 1;





