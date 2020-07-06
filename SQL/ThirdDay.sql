--AGGREGATE FUNCTIONS

--All the columns that you selecting in SELECT have to appear in GROUP BY

--COUNT 
--AVG
--MIN
--MAX
--SUM

--SELECT SUM(UnitsOnOrder) AS "Total On Order"
--AVG(UnitsOnOrder) AS "Avg On Order",
--MIN(UnitsOnOrder) AS "Min On Order",
--MAX(UnitsOnOrder) AS "Max On Order",
--SupplierId, ProductName                 --This two
--FROM Products
--GROUP BY SupplierID, ProductName;       --This two

--SELECT UnitsOnOrder FROM Products;

--SELECT CategoryID 
--, AVG(ReorderLevel) AS "AVG On Order"
--FROM Products 
--GROUP BY CategoryID 
--ORDER BY AVG(ReorderLevel) DESC

--SELECT Categoryid,ReorderLevel FROM Products;

--FILTERS

--SELECT SupplierID
--, SUM(UnitsOnOrder) AS "Total On Order"
--, AVG(UnitsOnOrder) AS "Avg on Order"
--FROM Products
--GROUP BY SupplierId
--HAVING AVG(UnitsOnOrder)>5; --> Where the Average is bigger than 5 -!!!HAVING can be used after and Needs GROUP BY, same functionality of WHERE 

--SELECT e.EmployeeID, e.FirstName, e.LastName,
--COUNT(TerritoryID) AS "Number of territories covered"
--FROM EmployeeTerritories et
--INNER JOIN Employees e
--ON e.EmployeeID = et.EmployeeID
--GROUP BY e.EmployeeID, e.FirstName, e.LastName
--HAVING COUNT(TerritoryID) > 5;

--JOIN

--SELECT s.SupplierID, s.CompanyName
--, AVG(p.UnitsOnOrder) AS "Avg On Order"
--FROM Products p
--INNER JOIN Suppliers s 
--ON s.SupplierID = p.SupplierId
--GROUP BY s.SupplierID, s.CompanyName
--HAVING AVG(p.UnitsOnOrder) > 0
--ORDER BY  AVG(p.UnitsOnOrder) ASC;

--MULTIPLE JOIN

--SELECT PRoductName, UnitPrice, CompanyName AS "Supplier"
--, CategoryName AS "Category"
--FROM Products p
--INNER JOIN Suppliers s ON p.SupplierID = s.SupplierID
--INNER JOIN Categories c ON p.CategoryID = c.CategoryID;


--SELECT * FROM Orders;
--SELECT * FROM Customers;
--SELECT * FROM Employees;


--SELECT o.OrderID, o.OrderDate, o.Freight 
--, cu.CompanyName AS "Customer Name"
--, e.FirstName + ' ' + e.LastName AS "First and Last Name"
--FROM Orders o 
--INNER JOIN  Customers cu ON cu.CustomerID = o.CustomerID
--INNER JOIN Employees e ON e.EmployeeID = o.EmployeeID
--ORDER BY OrderID ASC;

--SELF JOIN
--SELECT emp.EmployeeName, mgr.EmployeeName
--FROM employee emp
--LEFT JOIN employee mgr ON employeeID = ManagerId;

--SUBQUERY

--SELECT CompanyName AS "Customer"
--FROM Customers
--WHERE CustomerID NOT IN
--(SELECT CustomerID FROM Orders) --> Where the customer ID is not in Orders (NULL) !!(Subqueries needs brackets around)

--SELECT CompanyName AS "Customer"
--, o.OrderID
--FROM Customers c
--LEFT JOIN Orders o ON c.CustomerID = o.CustomerID
--WHERE o.OrderID IS NULL;


--SELECT 
--OrderID
--, ProductId
--, UnitPrice
--, Quantity
--, Discount
--, (SELECT MAX(UnitPrice) FROM [Order Details] od) AS "Max Price"
--FROM [Order Details];


--SELECT od.ProductID, sq1.totalamt AS "Total Sold for this Product", 
--UnitPrice, UnitPrice/totalamt*100 AS "% of Total"
--    FROM [Order Details] od
--    INNER JOIN 
--        (SELECT ProductID, SUM(UnitPrice*Quantity) AS totalamt
--        FROM [Order Details]
--        GROUP BY ProductID) sq1 ON sq1.ProductID=od.ProductID

--UNION ALL

--SELECT EmployeeID as "Employee/Supplier"
--FROM Employees
--UNION  --> If I write only UNION returns with not duplicate
--SELECT SupplierID
--FROM Suppliers
--ORDER BY EmployeeID ASC;

--SELECT 
--od.OrderID
--, od.ProductID
--, od.UnitPrice
--, od.Quantity
--, od.Discount
--FROM [Order Details] od
--INNER JOIN Products p ON od.ProductID = p.ProductID
--WHERE p.Discontinued = 1

--SELECT od.OrderID, od.ProductID, od.UnitPrice, od.Discount, od.Quantity
--FROM [Order Details] od
--WHERE od.ProductID IN
--    (SELECT p.productID FROM Products p WHERE p.Discontinued = 1)