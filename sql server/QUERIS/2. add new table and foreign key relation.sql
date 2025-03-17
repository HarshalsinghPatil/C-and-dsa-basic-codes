-- Before we have create employee table and leart to insert data 
-- add new table and insert data update data 
CREATE TABLE DEPT (
	DeptNo INT PRIMARY KEY IDENTITY(1,1),
	DeptName VARCHAR(20) NOT NULL UNIQUE
);

INSERT INTO DEPT (DeptName)
VALUES 
('HR'),
('Finance'),
('IT'),
('Marketing'),
('Operations');

SELECT * FROM DEPT;

-- add foreign key constraint and update existing data 
ALTER TABLE Employees
ADD DeptNo INT CONSTRAINT FK_DEPT_EMPLOYEES FOREIGN KEY REFERENCES DEPT(DeptNo);


UPDATE Employees
SET DeptNo = 3
WHERE EmployeeId = 1;

select * from employees;

-- Rename table 
EXEC sp_rename 'Employees','Emp'; 

select * from emp;

-- Insert data in bulk for data analysis
INSERT INTO Emp (FirstName, LastName, DOB, Salary, ProfilePic, Email, PhoneNumber, HireDate, IsActive, DeptNo)
VALUES
('John', 'Doe', '1990-05-15', 60000.00, NULL, 'john.doe@example.com', '9876543210', '2023-06-01', 1, 1),
('Jane', 'Smith', '1985-12-22', 75000.50, NULL, 'jane.smith@example.com', '9123456789', '2022-09-15', 1, 2),
('Michael', 'Johnson', '1992-08-10', 58000.75, NULL, 'michael.johnson@example.com', '9988776655', '2021-11-20', 1, 3),
('Emily', 'Davis', '1988-03-25', 82000.00, NULL, 'emily.davis@example.com', '9871234567', '2020-04-10', 1, 1),
('Robert', 'Brown', '1995-07-05', 45000.25, NULL, 'robert.brown@example.com', '9654321876', '2023-12-01', 1, 4),
('Sophia', 'Wilson', '1997-09-30', 55000.00, NULL, 'sophia.wilson@example.com', '9543218765', '2023-01-15', 1, 2),
('David', 'Anderson', '1983-11-18', 90000.00, NULL, 'david.anderson@example.com', '9456781234', '2019-06-20', 1, 3),
('Olivia', 'Martinez', '1994-04-02', 48000.50, NULL, 'olivia.martinez@example.com', '9876541200', '2023-07-05', 1, 4),
('James', 'Taylor', '1996-06-12', 51000.00, NULL, 'james.taylor@example.com', '9234567890', '2022-05-10', 1, 1),
('Isabella', 'Harris', '1993-02-28', 73000.75, NULL, 'isabella.harris@example.com', '9345678901', '2021-08-25', 1, 2),
('Ethan', 'Clark', '1987-09-14', 82000.00, NULL, 'ethan.clark@example.com', '9876543222', '2020-02-18', 1, 3),
('Mia', 'Rodriguez', '1991-07-08', 56000.50, NULL, 'mia.rodriguez@example.com', '9123456777', '2023-06-20', 1, 4),
('Liam', 'Walker', '1989-11-05', 67000.25, NULL, 'liam.walker@example.com', '9988776633', '2022-09-10', 1, 1),
('Charlotte', 'Lee', '1998-03-20', 47000.00, NULL, 'charlotte.lee@example.com', '9654321888', '2023-01-05', 1, 2),
('Benjamin', 'Hall', '1990-05-25', 59000.75, NULL, 'benjamin.hall@example.com', '9543218799', '2021-10-15', 1, 3),
('Aarav', 'Sharma', '1991-06-15', 62000.00, NULL, 'aarav.sharma@example.com', '9876543201', '2023-06-05', 1, 5),
('Neha', 'Verma', '1986-10-12', 78000.50, NULL, 'neha.verma@example.com', '9123456798', '2022-08-12', 1, 5),
('Rohan', 'Kapoor', '1993-04-22', 59000.75, NULL, 'rohan.kapoor@example.com', '9988776643', '2021-10-25', 1, 5),
('Simran', 'Singh', '1989-02-18', 84000.00, NULL, 'simran.singh@example.com', '9871234556', '2020-03-15', 1, 5),
('Vikram', 'Malhotra', '1997-07-30', 47000.25, NULL, 'vikram.malhotra@example.com', '9654321887', '2023-11-18', 1, 5);

--- UPDATE TWO VALUES AT SAME TIME 
UPDATE Emp
SET Salary = 28000, LastName = 'Patil'
where EmployeeId = 3;

-- AT A TIME ONLY ONE TABLE WILL BE UPDATE  but You can update MULTIPLE ROWS AND COLUMNS SIMULTANEOUSLY in same table . 
-- if you want to update MULTIPLE TABLES then you will require a sapreate update for each table





