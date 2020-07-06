--1.1
--SELECT CustomerID, CompanyName, Address + ', ' + City + ', ' + ', ' + PostalCode + ', ' + Country AS "Address Detail"
--FROM Customers
--WHERE City IN ('London', 'Paris')

--1.2
--SELECT * 
--FROM Products
--WHERE QuantityPerUnit LIKE '%bottle%'

--1.3
--SELECT s.CompanyName, s.Country, p.ProductName, p.QuantityPerUnit
--FROM Suppliers s
--INNER JOIN Products p ON s.SupplierID = p.SupplierID
--WHERE QuantityPerUnit LIKE '%bottle%'

--1.4
--SELECT c.CategoryName, COUNT(*) AS "No product"
--FROM Categories c
--INNER JOIN Products p ON c.CategoryID = p.CategoryID
--GROUP BY c.CategoryName
--ORDER BY "No product" DESC;

--1.5
--SELECT TitleOfCourtesy + '. ' + FirstName + ' ' + LastName AS " Employee Name"
--, City
--FROM Employees;

--1.6
--SELECT * FROM [Order Details]
--SELECT * FROM Orders
--SELECT * FROM EmployeeTerritories
--SELECT * FROM Territories


--SELECT  r.RegionDescription AS "Region", FORMAT(SUM(od.Quantity * od.UnitPrice * (1-o.Discount)), 'c', 'en-GB') AS "Total Sales"
--FROM [Order Details] od
--INNER JOIN Orders o ON od.OrderID = o.OrderID
--INNER JOIN EmployeeTerritories et ON o.EmployeeID = et.EmployeeID
--INNER JOIN Territories t ON et.TerritoryID = t.TerritoryID
--INNER JOIN Region r ON r.RegionID = t.RegionID
--GROUP BY r.RegionDescription 
--HAVING SUM(od.Quantity * od.UnitPrice * (1-o.Discount)) > 1000000

--SELECT * FROM Orders

--SELECT ShipCountry, Freight
--FROM Orders
--WHERE ShipCountry IN ('USA', 'UK')
--AND Freight > 100
--ORDER BY Freight ASC

SELECT * FROM [Order Details]
SELECT top 1 OrderID ,SUM(UnitPrice * Discount * Quantity)
FROM [Order Details]
GROUP BY OrderID
ORDER BY SUM(UnitPrice * Discount * Quantity) DESC