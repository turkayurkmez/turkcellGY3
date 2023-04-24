-- INSERT into [Tablo Adi] ([Kolon Adı 1], [Kolon Adı 2], [Kolon Adı N])
--        values           ([Değer1],      [Değer2],      [DeğerN])

INSERT into Categories(CategoryName, Description)
                values('Tatlılar', 'Her türlü Türk tatlıları') 

--T-SQL: Transact - Structured Query Language
--UPDATE
-- UPDATE [TabloAdi] SET [Kolon Adı 1]=[Değer1], [Kolon Adı 2]=[Değer2]
-- WHERE [Koşul]

Update Categories SET Description='Türk mutfağında bulunan eşsiz tatlı lezzetler'
WHERE CategoryId = 9

Select * from Products
--DELETE FROM [TabloAdi] WHERE [Koşul]
DELETE FROM Categories WHERE CategoryId=9


DELETE FROM Products WHERE ProductID=1

SELECT 
  ProductName, UnitPrice, UnitsInStock
FROM Products
WHERE UnitPrice < 50
ORDER BY UnitPrice ASC, UnitsInStock DESC


SELECT 
  ProductName, UnitPrice, UnitsInStock
FROM Products
WHERE UnitPrice <> 100

SELECT
   CustomerID, 	CompanyName, Address, City, Country
FROM Customers
WHERE Country LIKE 'A%'

SELECT
   CustomerID, 	CompanyName, Address, City, Country
FROM Customers
WHERE Country LIKE '%A'

SELECT 
   FirstName, LastName, Title,  YEAR(GETDATE())- YEAR(BirthDate) as Age
FROM Employees
Order by Age

SELECT LOWER('BÜYÜK')
SELECT UPPER('küçük')


SELECT 
   FirstName + ' ' + UPPER( LastName) FullName, Title,  YEAR(GETDATE())- YEAR(BirthDate) as Age
FROM Employees
Order by Age, FullName 


SELECT 
 OrderID, CustomerID, Freight, OrderDate
FROM Orders
WHERE OrderDate BETWEEN '1996-07-04' AND '1996-08-01'

SELECT 
 *
FROM Customers 
WHERE CompanyName BETWEEN 'A' AND 'E'

--Almanya'daki veya Italyadaki müşterilerim kim?
SELECT 
   CustomerID, CompanyName, ContactName, Address, City, Country
FROM Customers
WHERE Country = 'Germany' OR Country='Italy' OR Country = 'UK'
Order by Country
--
SELECT 
   CustomerID, CompanyName, ContactName, Address, City, Country
FROM Customers
WHERE Country IN ('Germany','Spain','UK','Italy','France')
Order by Country

-- Fax numarası olan müşterilerimi bulun:
SELECT 
  CompanyName, Country, Fax
FROM Customers
WHERE Fax is NULL

-- Satış yaptığımız ülkeler:
SELECT 
  DISTINCT Country
FROM Customers

--Aggregate Functions:,

-- 10248 İD'Lİ siparişte ne kadar ödendi?
SELECT 
   SUM(UnitPrice * (1-Discount) * Quantity) 
FROM [Order Details] WHERE OrderID = 10248

-- UK'da kaç adet müşterim var?
select count(*) as TotalCustomerCount from Customers where country = 'UK'

--MAX, MIN, AVG, 
--Group By:
--SELECT Renk, Count(Pantolon) FROM Gardrop
--GROUP BY Renk
--
-- Hangi ülkede kaç adet müşterim var?
SELECT
    Country, Count(CustomerID) TotalCustomers
FROM Customers
GROUP BY Country
ORDER BY TotalCustomers desc

-- 5'den fazla müşterim olan ülkeler
SELECT
    Country, Count(CustomerID) TotalCustomers
FROM Customers
GROUP BY Country
HAVING Count(CustomerID) >= 5
ORDER BY TotalCustomers desc


-- Hangi Siparişte ne kadar ödendi?
SELECT 
   OrderId,  '$'+CAST(ROUND(SUM(UnitPrice * (1-Discount) * Quantity), 0) AS nvarchar(5))
FROM [Order Details]
GROUP BY OrderID


-- 1000 DOLARDAN Fazla olan siparişler
SELECT 
   OrderId,  '$'+CAST(ROUND(SUM(UnitPrice * (1-Discount) * Quantity), 0) AS nvarchar(5))
FROM [Order Details]
GROUP BY OrderID
HAVING ROUND(SUM(UnitPrice * (1-Discount) * Quantity),0) > 1000 



--1000 dolardan fazla tutan siparişler toplamı ne kadar?

SELECT
    SUM(UnitPrice * (1-Discount) * Quantity)
FROM [Order Details]
HAVING SUM(UnitPrice * (1-Discount) * Quantity)>1000


-- Hangi Siparişte ne kadar ödendi?
SELECT TOP 5 OrderId,  ROUND(SUM(UnitPrice * (1-Discount) * Quantity), 2) as Total
FROM [Order Details]
GROUP BY OrderID
ORDER BY Total Desc 

--JOIN
SELECT ProductName, UnitPrice, CategoryID FROM Products
SELECT CategoryID FROM Categories


INSERT into Categories (CategoryName) values ('Tatlılar')
INSERT into Products (ProductName,UnitPrice) values ('Gül reçeli',60)

SELECT 
  ProductName, UnitPrice, CategoryName
FROM Categories INNER JOIN Products 
ON Categories.CategoryID = Products.CategoryID
Order By CategoryName

--Hangi kategoride kaç adet ürün vardır?
--1. Ne yapmak istiyorsun?
--2. Hangi tablo veya tablolar ile çalışmak istiyorsun?
--3. Hangi kolonlar ve veri ile çalışmak istiyorsun?
--4. Eğer Gövdede Aggregate func. varsa Group by kullan.

SELECT
   CategoryName, COUNT(Distinct ProductName) as Quantity
FROM Categories JOIN Products 
ON Categories.CategoryID = Products.CategoryID
GROUP BY CategoryName
Order By CategoryName 

SELECT
   CategoryName, AVG(UnitPrice) as AveragePrice
FROM Categories JOIN Products 
ON Categories.CategoryID = Products.CategoryID
GROUP BY CategoryName
Order By AveragePrice DESC

--Hangi siparişi, hangi müşteri vermiş?
--Hangi kategoride kaç adet ürün vardır?
--1. Ne yapmak istiyorsun?
--2. Hangi tablo veya tablolar ile çalışmak istiyorsun?
--3. Hangi kolonlar ve veri ile çalışmak istiyorsun?
--4. Eğer Gövdede Aggregate func. varsa Group by kullan.
SELECT
   OrderId, CONVERT(NVARCHAR,OrderDate,103),  CompanyName
FROM Orders JOIN Customers
ON Customers.CustomerID = Orders.CustomerID
ORDER BY CompanyName

--Hangi siparişi hangi müşteri vermiş ve mu siparişi hangi çalışan onaylamış? 
SELECT
   OrderId, CONVERT(NVARCHAR,OrderDate,103),  CompanyName, FirstName + ' ' + LastName
FROM Orders JOIN Customers
ON Customers.CustomerID = Orders.CustomerID
            JOIN Employees
ON Orders.EmployeeID = Employees.EmployeeID
ORDER BY CompanyName

-- Hangi siparişi
-- hangi müşteri,ne zaman vermiş
-- hangi çalışan onaylamış
-- hangi kargo şirketiyle gönderilmiş
-- Bu siparişte
-- hangi tedarikçinin sağladığı 
-- hangi kategoriden 
-- kaç adet ürün alınmış
-- ve ne kadar ödenmiştir?

SELECT
  o.OrderID, 
  c.CompanyName, o.OrderDate,
  e.FirstName + ' ' + e.LastName 'Çalışan',
  s.CompanyName 'Kargo',
  sp.CompanyName 'Tedarikçi',
  ca.CategoryName,
  p.ProductName,
  od.Quantity,
  od.UnitPrice * od.Quantity 'Ödenen'
FROM Employees as e JOIN Orders o
ON e.EmployeeId = o.EmployeeID
JOIN Customers c 
ON o.CustomerID = c.CustomerID
JOIN Shippers s
ON s.ShipperID = o.ShipVia
JOIN [Order Details] od
ON od.OrderID = o.OrderID
JOIN Products p
ON p.ProductID = od.ProductID
JOIN Suppliers sp
ON p.SupplierID = sp.SupplierID
JOIN Categories ca
ON ca.CategoryID = p.CategoryID


-- OUTER JOIN:
-- Sadece eşleşen kayıtları değil eşleymenlerden de veri getiren join türü.
-- Kategoriler ve Ürünler
-- Tüm kategoriler gelsin ve yanlarında ürünler gelsini

SELECT 
  CategoryName, ProductName
FROM Categories LEFT JOIN Products
ON Products.CategoryID = Categories.CategoryID
WHERE ProductName is NULL

SELECT 
  CategoryName, ProductName
FROM Categories RIGHT JOIN Products
ON Products.CategoryID = Categories.CategoryID
WHERE CategoryName is NULL

SELECT 
  CategoryName, ProductName
FROM Categories FULL OUTER JOIN Products
ON Products.CategoryID = Categories.CategoryID
WHERE CategoryName is NULL Or ProductName is NULL

SELECT
   CategoryName, COUNT(Distinct ProductName) as Quantity
FROM Categories LEFT JOIN Products 
ON Categories.CategoryID = Products.CategoryID
GROUP BY CategoryName
Order By CategoryName 

--kim kimin müdürü?
SELECT
  Calisanlar.FirstName + ' ' + Calisanlar.LastName Calisan,
  Mudurler.FirstName + ' ' + Mudurler.LastName 'Müdür'
FROM Employees as Calisanlar LEFT JOIN Employees as Mudurler
ON Calisanlar.ReportsTo = Mudurler.EmployeeID
WHERE Mudurler.FirstName + ' ' + Mudurler.LastName is NULL
Order By Calisan


SELECT 
  * 
FROM Orders CROSS JOIN [Order Details]

SELECT 
   Count(*)
FROM [Order Details]

SELECT 
   ProductName, UnitPrice, Durum = CASE
                                      WHEN UnitsInStock =0 THEN 'Yok'
                                      WHEN UnitsInStock <20 THEN 'Kritik'
                                      WHEN UnitsInStock <50 THEN 'Normal'
                                      WHEN UnitsInStock >50 THEN 'Fazla'
                                   END 
FROM Products
ORDER BY Durum

--En pahalı ürünüm hangisi?
SELECT  MAX(UnitPrice)
FROM Products

SELECT 
*
FROM Products 
WHERE UnitPrice = 263.50

SELECT 
*
FROM Products 
WHERE UnitPrice = (
  SELECT  MAX(UnitPrice) FROM Products
   )

SELECT
   CategoryName, COUNT(Distinct ProductName) as Quantity
FROM Categories LEFT JOIN Products 
ON Categories.CategoryID = Products.CategoryID
GROUP BY CategoryName
Order By CategoryName 

SELECT 
 c.CategoryName, (SELECT COUNT(ProductId) FROM Products WHERE CategoryID=c.CategoryID)
FROM Categories as c         

--Aynı ülkede bulınan tedarikçi firmalar ve müşterilerimi istiyorum.

SELECT CompanyName, Address, City,Country, 'Müşteri' as Durum FROM Customers
UNION
SELECT CompanyName, Address, City,Country, 'Tedarikçi' FROM Suppliers
ORDER BY Country