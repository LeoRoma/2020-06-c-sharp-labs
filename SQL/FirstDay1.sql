--SELECT COUNT(column_name) AS "Any description" --> Aliases is with "Double quotes"
-- (FROM Employees)--> Doesn't retrieve all the details of columns
--WHERE City = 'London';
--4

--SELECT * FROM Employees
--WHERE TitleOfCourtesy = 'Dr.';

--SELECT COUNT (Discontinued) AS "Numbers of discontinued products"
--FROM Products 
--WHERE Discontinued = 1;
--8

--SELECT * FROM Suppliers
--WHERE Address = '29 King' 's Way';


--SELECT CompanyName, City, Country, Region
--FROM Customers
--WHERE Region = 'BC';

--ASC Ascending DESC descending

--SELECT CompanyName, ContactName
--FROM Customers
--WHERE Country = 'France'
--ORDER BY CompanyName ASC;

--SELECT Country, ContactName
--FROM Customers
--WHERE Country = 'France'
--ORDER BY Country, ContactName ASC;	--> Both of them are ordered ASCENDING

--SELECT TOP 5 CompanyName, City
--FROM Customers
--WHERE Country = 'France';  --> Selects only the top 5

--SELECT ProductName, UnitPrice 
--FROM Products
--WHERE CategoryID = 1 AND Discontinued = 0; --> AND

--SELECT ProductName, UnitPrice 
--FROM Products
--WHERE CategoryID = 1 OR Discontinued = 1; --> OR

--SELECT ProductName, UnitPrice 
--FROM Products
--WHERE UnitsInStock > 0 OR UnitPrice > 29.99;

--SELECT DISTINCT Country  
--FROM Customers 
--WHERE ContactTitle = 'Owner'; Return list of countries without duplicates

--SELECT CompanyName, ContactName, Phone
--INTO French_customers
--FROM Customers
--WHERE Country = 'France'; --> The result will be stored in a new table named "Frenc_customers".

--LIKE
--SELECT ProductName
--FROM Products 
--WHERE ProductNAme LIKE 'CH%';  --> It searches what is after % sign. OR %Ch it searches what is before %

--SELECT ProductName
--FROM Products 
--WHERE ProductName LIKE '%[AEIOU]'; ->> It searches value with ending 

--SELECT * 
--FROM Customers WHERE Region LIKE '_A'; --> _A rappresents only 1 character before A that we don't know. And it work the same way A__

--SELECT * 
--FROM Customers WHERE Region IN ('WA','SP'); IN is very similar to OR

--ORDER BY (ASC = Ascending, DESC = Descending)
--SELECT *
--FROM Customers
--WHERE Region = 'WA' OR Region = 'SP'
--ORDER BY Region ASC;

--BETWEEN
--SELECT * FROM EmployeeTerritories
--WHERE TerritoryID BETWEEN 06800 AND 09999;