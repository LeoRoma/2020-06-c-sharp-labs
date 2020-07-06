-- SQL MINI PROJECT

--1.1
--SELECT CustomerID
--, CompanyName
--, Address
--, City 
--, PostalCode
--, Country
--FROM Customers 
--WHERE City IN ('London', 'Paris');

--SELECT CustomerID AS CustomerID, CompanyName AS CustomerName, Address + ', ' + City + ', ' + PostalCode + ', ' + Country AS "Address"  

--FROM Customers 

--WHERE City IN ('Paris', 'London');

--1.2
--SELECT ProductName, QuantityPerUnit FROM Products
--WHERE QuantityPerUnit LIKE '%bottle%';

--1.3
--SELECT s.CompanyName, s.Country, p.QuantityPerUnity 
--FROM Products p 
--INNER JOIN Suppliers s ON s.SupplierID = p.SupplierID
--WHERE p.QuantityPerUnit LIKE '%bottle%';

--SELECT ProductName, QuantityPerUnit, CompanyName, Country 

--FROM Products p  

--    INNER JOIN Suppliers s ON p.SupplierID = s.SupplierID 

--WHERE QuantityPerUnit LIKE '%Bottle%'; 

--1.4
--SELECT c.CategoryName, COUNT(*) AS "Unit per Category"
--FROM Products p
--INNER JOIN Categories c ON c.CategoryID = p.CategoryID
--GROUP BY c.CategoryName
--ORDER BY "Unit per Category" DESC;

--1.5
--SELECT * FROM Employees
--SELECT TitleOfCourtesy + ' ' + FirstName + ' ' + LastName + ', ' + Address AS "Employee Information"
--FROM Employees
--WHERE Country = 'UK';

--1.6
--SELECT 
--r.RegionDescription
--, FORMAT (SUM(od.Quantity * od.UnitPrice*(1-od.Discount)), 'c','en-GB') AS "Sales"
--FROM [Order Details] od
--INNER JOIN Orders o ON od.OrderID = o.OrderID
--INNER JOIN EmployeeTerritories et ON o.EmployeeID = et.EmployeeID
--INNER JOIN Territories t ON et.TerritoryID = t.TerritoryID
--INNER JOIN Region r on r.RegionID = t.RegionID
--GROUP BY r.RegionDescription
--HAVING SUM(od.Quantity * od.UnitPrice*(1-od.Discount)) > 1000000 
--ORDER BY "Sales" DESC

--1.7
--SELECT COUNT(*) AS "No of Orders > 100 from US or UK"
--FROM Orders
--WHERE Freight > 100 AND (ShipCountry in ('USA', 'UK'));



--1.8
SELECT TOP 1 OrderID, SUM(UnitPrice * Quantity*Discount) AS "Discount Amount"
FROM [Order Details] 
GROUP BY OrderID
ORDER BY SUM(UnitPrice*Quantity*Discount) DESC

----Solution
--SELECT Orderid AS "Order ID",  
--FORMAT((UnitPrice * Quantity) * Discount,'C') AS "Total Discount" 
--FROM [Order Details] 
--WHERE ((UnitPrice * Quantity) * Discount) = 
--    ( SELECT MAX( (UnitPrice * Quantity) * Discount) -- AS 'Discount Amount' 
--    FROM [Order Details] ) 

--2.1
--CREATE TABLE Spartans
--(
--	SpartanID INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
--	Title VARCHAR (5),
--	FirstName VARCHAR (20),
--	LastName VARCHAR (20),
--	University VARCHAR (50),
--	Age INT
--);

--2.2
--INSERT INTO Spartans
--(
--	Title,
--	FirstName,
--	LastName,
--	University,
--	Age
--)
--VALUES
--(
--	'Mr.',
--	'Leo',
--	'Xia',
--	'Sapienza Universita di Roma',
--	'34'
--);

--3.1
--SELECT e.FirstName + ' ' + e.LastName AS "Employee Name"
--, m.FirstName + ' ' + m.LastName AS "Manager Name"
--FROM Employees e
--LEFT JOIN Employees m ON e.ReportsTo = m.EmployeeID;

--3.2
--SELECT s.CompanyName
--, FORMAT (SUM(od.Quantity * od.UnitPrice * (1 - od.Discount)), 'c', 'en-GB') AS "Total sales"
--FROM Products p
--INNER JOIN [Order Details] od ON p.ProductID = od.ProductID
--INNER JOIN Suppliers s ON p.SupplierID = s.SupplierID
--GROUP BY s.CompanyName
--HAVING SUM(od.Quantity * od.UnitPrice * (1 - od.Discount)) > 10000
--ORDER BY SUM(od.Quantity * od.UnitPrice * (1 - od.Discount)) DESC;

--3.3
SELECT TOP 10 
c.CompanyName
--, MAX(FORMAT(o.ShippedDate, 'dd/MM/yyyy')) AS "YTD"
, FORMAT (SUM(od.Quantity * od.UnitPrice * (1 - od.Discount)), 'c', 'en-GB') AS "Total sales"
FROM Customers c
INNER JOIN Orders o ON c.CustomerID = o.CustomerID
INNER JOIN [Order Details] od ON o.OrderID = od.OrderID
WHERE o.OrderDate > (SELECT DATEADD(year, -1, MAX(OrderDate)) FROM Orders)
GROUP BY c.CompanyName
ORDER BY SUM(od.Quantity * od.UnitPrice * (1 - od.Discount)) DESC;


--3.4
--SELECT MONTH(OrderDate) AS "Month", YEAR(OrderDate) AS "Year"
--, CAST(SUM(DATEDIFF(dd, OrderDate, ShippedDate)) AS DECIMAL(5,2)) / COUNT(FORMAT(OrderDate, 'MMM/yyyy'))  AS "Average Ship Time"
--FROM ORDERS
--WHERE OrderDate IS NOT NULL
--GROUP BY MONTH(OrderDate), YEAR(OrderDate)
--ORDER BY "Year" ASC, "Month" ASC; 

--Test
--SELECT FORMAT(OrderDate, 'MMM/yyyy') AS "Month And Year"
--, COUNT(FORMAT(OrderDate, 'MMM/yyyy')) AS "Total Shipped"
--FROM ORDERS
--WHERE OrderDate IS NOT NULL
--GROUP BY FORMAT(OrderDate, 'MMM/yyyy')
--ORDER BY "Year" ASC, "Month" ASC; 

