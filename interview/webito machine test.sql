CREATE DATABASE EmployeeDB;

use EmployeeDB;

CREATE TABLE Employee
(
	EmployeeId INT PRIMARY KEY IDENTITY(1,1),
	EmployeeName NVARCHAR(100),
	DateOfJoining DATETIME2,
	Salary DECIMAL(18,2) CHECK (SALARY >= 0),
);

INSERT INTO Employee( EmployeeName, DateOfJoining,Salary)
VALUES 
('Harshal','2023-07-10', 100000.00),
('Sachin','2023-07-10', 200000.00),
('Suraj','2023-07-10', 300000.00),
('Priya','2023-07-10', 400000.00);


CREATE TABLE Department
(
	DepartmentId INT PRIMARY KEY IDENTITY(1,1),
	DepartmentName NVARCHAR(100)
);

INSERT INTO Department(DepartmentName)
VALUES
('IT'),
('HR'),
('Support'),
('Admin'),
('sales');

SELECT * FROM Employee;
SELECT * FROM Department;

--Join : 

SELECT e.EmployeeId,e.EmployeeName,e.DateOfJoining,e.Salary,e.DepartmentName
FROM Employee e
Join Department d
on e.DepartmentName = d.DepartmentName;


--parameterised Query
--1. fetch all employees working in a specific department
CREATE PROCEDURE getAllEmployeeDeptWise
	@DepartmentName nVARCHAR(100) 
as 
BEGIN	
	SELECT * FROM Employee where DepartmentId = (select DepartmentId from Department where DepartmentName=@DepartmentName)
	group by dept;
END;

EXEC getAllEmployeeDeptWise @DepartmentName in ;


-- 2. calculate total salary of all employees working in each department
create procedure TotalSalaryDeptWise
	@TotalSalary 
as TotalSalary out
BEGIN
	SELECT DepartmentName , Sum(Salary)
	from Employees 
	Group By Department;
END;

EXEC TotalSalaryDeptWise @TotalSalary OUT;

-- Stored procedures to 
--1. Insert or update an employee based on the presence of EmployeeId.
create procedure InsertOrUpdate
@Employee in
as 
begin 
	if 
		WHEN @Employee.EmployeeId EXIST
		THEN UPDATE EMPLOYEE SET Employee = @Employee where EmployeeId = @Employee.EmployeeId;
	ELSE
		INSERT INTO Employee (EmployeeName, DateOfJoining,Salary)
		value (@Employee.EmployeeName, @Employee.DateOfJoining , @Employee.DateOfJoining)	
end;

EXEC InsertOrUpdate @Employee in;


--2. Delete an employee by EmployeeId and handle foreign key constraints.
create procedure DeleteEmployee
	@EmployeeId 
as 
begin
	Delete from Employee
	where EmployeeId= @EmployeeId;
end;

EXEC DeleteEmployee @EmployeeId;

-- 3. Retrieve employee details (name, department, joining date, and salary) by filtering on EmployeeName or DepartmentName.

EXEC GetEmployeeDetailEmpNameOrDeptNameWise @EmployeeName in, @DepartmentName in, @Employee out;

create procedure GetEmployeeDetailEmpNameOrDeptNameWise 
 @EmployeeName in, @DepartmentName in, @Employee out

 as 
 begin 
	Select EmployeeName, DateOfJoining,Salary, DepartmentId
	from Employee
	where EmployeeName = @EmployeeName OR DepartmentId = (select DepartmentId where DepartmentName = @DepartmentName);
 end; 













