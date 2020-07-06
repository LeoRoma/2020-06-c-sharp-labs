
--COMPARISONS OPERATOR
--SELECT productid, productname
--FROM products
--WHERE unitprice < 5.00;

--OR
--SELECT categoryname 
--FROM categories 
--WHERE categoryname LIKE 'B%' OR categoryname LIKE 'S%';  --> Wildcard


--IN
--SELECT COUNT(*) AS "Numbers of order"
--FROM orders
--WHERE employeeid IN (7,5);

--WILDCARD
--SELECT CategoryName 
--FROM Categories 
--WHERE CategoryName LIKE ('[A-P]%'); --> Wildcard with LIKE

--CONCATENATION

--SELECT CompanyName AS "Company Name"
--, City + ', ' + Country AS "City"
--FROM Customers;

--SELECT FirstName + ' ' + LastName + ': ' + HomePhone AS "Employee Name and Contact Number"
--FROM Employees;

--ARITHMETIC OPERATORS

--SELECT CompanyName AS 'Company Name'
--, City + ', ' + Country AS 'City'
--FROM Customers 
--WHERE Region IS NULL;

--SELECT * FROM Customers;

--SELECT DISTINCT Country FROM Customers WHERE Region IS NOT NULL;

--SELECT UnitPrice, Quantity, Discount, UnitPrice * Quantity AS "Gross Total"
--FROM [Order Details]; --> Square Bracket is for Table or Column name with Space. Best practice to avoid space

--SELECT UnitPrice, Quantity, Discount, UnitPrice * Quantity AS "Gross Total"
--, UnitPrice * Quantity * (1-Discount) AS "Gross Total with Discount"
--FROM [Order Details]
--ORDER BY "Gross Total with Discount" ASC; --> Alias can be used as a column

--SELECT TOP 2 UnitPrice, Quantity, Discount, UnitPrice * Quantity AS "Gross Total"
--FROM [Order Details]
--ORDER BY "Gross Total" ASC;

--STRING MANIPULATION:
	
--SELECT SUBSTRING ('Alex',2,3); --> Returns 'lex'
--SELECT CHARINDEX ('h', 'Harry'); --> Starts from 1 => Returns 1
--SELECT LEFT ('Chen', 2); --> Returns 'Ch'
--SELECT RIGHT ('Christian', 3) --> Returns Ian
--SELECT LTRIM('        Bruno'); --> Removes all spaces from left hand side
--SELECT TRIM('        Bruno              '); --> Removes all spaces from right and left side
--SELECT REPLACE('Nishint', 'i', 'a'); --> Replaces 'i' with 'a'
--SELECT UPPER('leo'); --> CAPITALIZE
--SELECT LOWER('LEO'); --> lowcase
--SELECT LEN('Sparta'); --> Length of the 'string'

--SELECT PostalCode AS "Post Code",
--LEFT(PostalCode, CHARINDEX(' ', PostalCode)-1) AS "Post Code Region"
--, CHARINDEX(' ', PostalCode) AS 'Space Found'
--, Country
--FROM Customers 
--WHERE Country = 'UK';

--SELECT ProductName AS "Name with '"
--FROM Products
--WHERE CHARINDEX('''', ProductNAme) > 0; --> Checking the apostrophes when they are more than 0. To escape the apostrophe "''''"

--DATE, FORMAT, ADD, DIFF, GETDATE():

--SELECT GETDATE();
--SELECT SYSDATETIME(); --> Both of them return date and time
--SELECT DATEADD(YYYY, 5, GETDATE()); --> Add time of 5 at Years 'yyyy'
--SELECT DATEDIFF(dd, '2020-05-05', '2020-05-06'); --> Difference between days

--SELECT DISTINCT 
--OrderDate
--, YEAR (OrderDate)
--, MONTH (OrderDate)
--, DAY (OrderDate)
--FROM Orders;

--SELECT FORMAT(GETDATE(), 'dd/MM/yyyy'); --> Format date

--SELECT FORMAT(o.OrderDate, 'dd/MM/yyyy') AS 'Order Date'
--, FORMAT((od.UnitPrice * od.Quantity) * (1 - od.Discount), 'C', 'en-GB') AS 'Net total'
--, c.CompanyName
--FROM Orders o 
--INNER JOIN [Order Details] od ON o.OrderID=od.OrderID
--INNER JOIN Customers c ON c.CustomerID=o.CustomerId;

--SELECT LastName + ' ' + FirstName AS "Employee Name"
--, FLOOR(DATEDIFF(dd, BirthDate, GETDATE())/ 365.25) AS "Employee Birthday"
--FROM Employees;  --> Calculates Birthday of a Employee

--CASE:

--SELECT 
--CASE 
--WHEN DATEDIFF(dd, OrderDate, ShippedDate) < 10 THEN 'On time' --> IF WHEN(Condition)THEN(Statement) ELSE(Statement)
--ELSE 'Overdue' 
--END
--AS "Status" 
--FROM Orders 

--SELECT  LastName + ' ' + FirstName AS "Employee Name"
--, FLOOR(DATEDIFF(dd, BirthDate, GETDATE())/ 365.25) AS "Employee Birthday",
--CASE 
--WHEN FLOOR(DATEDIFF(dd, BirthDate, GETDATE())/365.25) > 65 THEN 'Retired' 
--WHEN FLOOR(DATEDIFF(dd, BirthDate, GETDATE())/365.25) > 60 THEN 'Retirement Due'
--ELSE 'More than 5 years to go'
--END
--AS "Retirement Status"
--FROM Employees;
--Employees