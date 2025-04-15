-- ORDER BY (BY ONE COLUMN OR MULTIPLE COLUMNS)

SELECT DeptNo, FirstName +' '+ LastName AS eName, Age , Salary 
FROM EMP
ORDER BY DeptNo;

SELECT DeptNo, FirstName +' '+ LastName AS eName, Age , Salary 
FROM EMP
ORDER BY DeptNo DESC ;

SELECT DeptNo, FirstName +' '+ LastName AS eName, Age , Salary 
FROM EMP
ORDER BY DeptNo , AGE;

SELECT DeptNo, FirstName +' '+ LastName AS eName, Age , Salary 
FROM EMP
ORDER BY DeptNo DESC , AGE ;

SELECT DeptNo, FirstName +' '+ LastName AS eName, Age , Salary 
FROM EMP
ORDER BY DeptNo DESC , AGE DESC;

-- ORDER BY WITH WHERE CLAUSE

SELECT * FROM Emp
WHERE DeptNo = 5
ORDER BY firstName desc;

-- calculate yearly salary (No need to write as )
SELECT firstName+' '+Lastname ename,  Salary * 12 annualSal 
FROM EMP 
ORDER BY annualSal;

SELECT firstName+' '+Lastname ename,  Salary * 12 annualSal 
FROM EMP 
ORDER BY 2;

SELECT firstName+' '+Lastname ename,  Salary * 12 annualSal 
FROM EMP 
ORDER BY 2,3,4;