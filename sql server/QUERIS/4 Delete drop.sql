-- ===================== Delete ==================================================
CREATE TABLE DemoEmployees (
    EmployeeID INT PRIMARY KEY IDENTITY(1,1),
    FirstName NVARCHAR(50) NOT NULL,
    LastName NVARCHAR(50) NOT NULL,
    Age INT CHECK (Age > 18), -- Ensures age is above 18
    Salary DECIMAL(10,2) CHECK (Salary >= 0),
    DeptNo INT
);

INSERT INTO DemoEmployees (FirstName, LastName, Age, Salary, DeptNo)
VALUES
('John', 'Doe', 28, 50000, 1),
('Jane', 'Smith', 34, 60000, 2),
('Mike', 'Johnson', 26, 45000, 3),
('Emily', 'Davis', 40, 70000, 1),
('Robert', 'Brown', 30, 55000, 4),
('Sophia', 'Wilson', 29, 52000, 2),
('David', 'Anderson', 45, 75000, 3);


-- Delete individual row
DELETE FROM DemoEmployees 
WHERE EmployeeId = 2;
-- DELETE FROM DEPT 2 
DELETE FROM DemoEmployees WHERE DeptNo = 2;
-- DELETE SALARY <50000
DELETE FROM DemoEmployees WHERE Salary < 50000;


-- delete all rows of a table 
DELETE FROM DemoEmployees;

-- NOTE : Even, if we delete table still we are getting employeeId from the last record we have created.
-- because We have used identity so it keeps track of employeeId so if we want to reset it we need to TRUNCATE Table

							-- VS Truncate(removes everything) --

TRUNCATE TABLE FRUITS;
							-- Drop tables ---
DROP TABLE DemoEmployees;
DROP TABLE FRUITS, FLOWERS, CUSTOMERS;-- DELETE multiple tables

select * from DemoEmployees ;

use HarshalTestDb;