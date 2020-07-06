--CREATE TABLE customers 
--(
--	CustomerID INT IDENTITY (1,1) NOT NULL PRIMARY KEY
--	, First_Name VARCHAR (255)
--	, Last_Name VARCHAR (255)
--	, Address VARCHAR (255)
--);

--CREATE TABLE orders 
--(
--	OrderID INT IDENTITY (1,1) NOT NULL PRIMARY KEY
--	, Order_Date DATE
--	, Order_Description VARCHAR (255)
--	, Order_Amount INT
--	, CustomerID INT FOREIGN KEY REFERENCES customers(CustomerID)
--	, ItemID INT FOREIGN KEY REFERENCES items(ItemID)
--);

--CREATE TABLE items 
--(
--	ItemID INT IDENTITY (1,1) NOT NULL PRIMARY KEY
--	, Item_Name VARCHAR (255)
--);

--INSERT INTO customers 
--(
--	First_Name
--	, Last_Name
--	, Address
--)
--VALUES 
--(
--	'Leo'
--	, 'Xia'
--	, '175 Greyhound Rd'
--),
--(
--	'John'
--	, 'Doe'
--	, 'Piccadilly Circus'
--);

--INSERT INTO orders
--(
	
--	 Order_Date
--	, Order_Description
--	, Order_Amount
--	, CustomerID
--	, ItemId
--)
--VALUES 
--(
	
--	 '2010-10-11'
--	, 'Broken'
--	, 2
--	, 1
--	, 1
--),
--(
	
--	 '2020-10-11'
--	, 'Good condition'
--	, 3
--	, 2
--	, 2
--);

--INSERT INTO items 
--(
--	Item_Name
--)
--VALUES 
--(
--	'Playstation4'
--),
--(
--	'Hoover'
--);

--SELECT First_Name, Order_Date, Item_Name
--FROM customers
--JOIN orders ON customers.CustomerID = orders.CustomerID
--JOIN items ON items.ItemID = orders.ItemId;

--SELECT First_Name, Order_Date, Item_Name
--FROM customers
--JOIN orders ON customers.CustomerID = orders.CustomerID
--JOIN items ON items.ItemID = orders.ItemId
--WHERE customers.CustomerID = 1;


--SELECT * FROM customers;
--SELECT * FROM orders;
