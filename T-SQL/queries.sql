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

-- Ürünlerin fotoğraf arama linklerini gösteren result set:
SELECT 
  'https://www.google.com/search?q='+ProductName+'&source=lnms&tbm=isch'
FROM Products

--View---
CREATE VIEW AktifUrunler
AS
SELECT
   ProductName, UnitPrice
FROM Products
WHERE Discontinued = 0


SELECT * FROM AktifUrunler

CREATE VIEW KategoriMenusu
AS
SELECT
   CategoryName, COUNT(Distinct ProductName) as Quantity
FROM Categories LEFT JOIN Products 
ON Categories.CategoryID = Products.CategoryID
GROUP BY CategoryName



SELECT * FROM KategoriMenusu WHERE Quantity > 5
order by Quantity desc

-- 
CREATE VIEW DetailedOrders
AS
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

SELECT 
   CategoryName, COUNT(OrderID) as TotalOrder
FROM DetailedOrders
GROUP BY CategoryName
ORDER BY TotalOrder DESC

CREATE VIEW CategorySales_1996
AS
SELECT 
   CategoryName, SUM(Ödenen) as TotalPrice
FROM DetailedOrders
WHERE OrderDate BETWEEN '1996-08-01' AND '1996-08-31'
GROUP BY CategoryName

SELECT * FROM CategorySales_1996

SELECT ProductName, SUM(Quantity) TotalQuantity  FROM DetailedOrders
GROUP BY ProductName ORDER BY TotalQuantity DESC

SELECT ProductName, SUM(Ödenen)  TotalPrice  FROM DetailedOrders
GROUP BY ProductName ORDER BY TotalPrice DESC


SELECT *
FROM Products WHERE ProductName LIKE '%Cha%'

/*Nonclustered index:*/
CREATE NONCLUSTERED INDEX ProductName ON Products
(
	[ProductName] ASC
)
GO

DBCC INDEXDEFRAG (Northwind, 'Products', ProductName);
GO

--Stored Procedure: Parametrik olarak, sorgu üretebilen nesneler:

CREATE PROC AddNewProduct
  @name nvarchar(40),
  @price money
AS
Insert into Products (ProductName, UnitPrice)
            values (@name,@price)
			
AddNewProduct 'Domates',40


CREATE PROC GetOrdersByDate
  @start datetime,
  @finish datetime
AS
SELECT *
FROM Orders WHERE OrderDate BETWEEN @start AND @finish


GetOrdersByDate '1997-12-01', '1997-12-31'

-- Bu ürünü alanlar bunu da aldılar (5 ÜRÜN).
-- 1. O ürünü alan tüm siparişleri bul.
-- 2. O ürün hariç, diğer ürünlere bak.
CREATE PROC BunuAlanlarBunudaAldi
  @productId int
AS
SELECT TOP 5 ProductName, Sum(Quantity) as TotalQuantity
FROM Products JOIN [Order Details] 
ON Products.ProductID = [Order Details].ProductID
WHERE [Order Details].OrderID IN (
			SELECT OrderID FROM [Order Details] WHERE ProductID =@productId
	   )
AND [Order Details].ProductID !=@productId
GROUP BY ProductName
ORDER BY TotalQuantity desc

BunuAlanlarBunudaAldi 4

--Transaction: Bir eylemin, belirli bir durumda geri alınabilir olmasını sağlayan kurallı akış
BEGIN TRY
	BEGIN TRAN T1
	   --Çalışması gereken ilk sorgu 
	    BEGIN TRAN T2
		 -- T1'in çalışmasına bağlı ikinci
		COMMIT TRAN T2
	COMMIT TRAN T1    
END TRY
BEGIN CATCH
    ROLLBACK TRAN T1
END CATCH
------  Yeni sipariş ekleme prosedürü

CREATE PROC AddNewOrderDetail
  @customerId nchar(5),
  @productId int,
  @quantity int
as
  BEGIN TRY
    BEGIN TRAN CreateOrder
	   --1. Önce Orders tablosunda sipariş oluştur.
	   DECLARE @lastOrderId int
	   INSERT into Orders (CustomerID, OrderDate) values (@customerId, GETDATE())
	   SET @lastOrderId = SCOPE_IDENTITY()
	   BEGIN TRAN Create_Order_Details
	      --2. 1. İşlemin sonunda elde ettiğin yeni OrderId ile sipariş detayı (Order Details) (ürün ve adet) ekle
		  INSERT into [Order Details] (OrderID, ProductID, Quantity) values (@lastOrderId, @productId,@quantity)
		  BEGIN TRAN UpdateProduct
		    --3 Sipariş edilen adeti ürün stoğundan düş.
			UPDATE Products SET UnitsInStock = UnitsInStock - @quantity WHERE ProductID = @productId
		  COMMIT TRAN UpdateProduct
	   COMMIT TRAN Create_Order_Details
	COMMIT TRAN CreateOrder
  END TRY
  BEGIN CATCH
     ROLLBACK TRAN CreateOrder
  END CATCH
   
   AddNewOrderDetail 'ALFKI',3,4



   SELECT TOP 1 * FROM Orders Order By OrderID Desc 
   SELECT OrderID, ProductID,Quantity FROM [Order Details] WHERE OrderID = 11078
   SELECT ProductName, UnitsInStock FROM Products WHERE ProductID = 3

   -- Kılavuzu Trigger olanın burnu BUG'dan kurtulmaz!

   -- ...yerine (instead of)
   -- ...den sonra (after)

   -- Ürün satın alındığında; o ürünün stoğundan satın alınan adet kadar düşen trigger:
   --AFTER
   CREATE TRIGGER stockUpdater
   ON [Order Details] FOR Insert
   AS
   --Hangi üründen kaç adet
   DECLARE @quantity int
   DECLARE @productId int
   SELECT @productId = ProductID, @quantity =Quantity  FROM inserted

   UPDATE Products SET UnitsInStock = UnitsInStock - @quantity WHERE ProductID = @productId

   SELECT ProductName, UnitsInStock FROM Products WHERE ProductID =2 

   --Instead of.
   SELECT ProductName, Discontinued FROM Products

   CREATE TRIGGER TR_DeleteProduct
   ON Products INSTEAD OF Delete
   AS
   DECLARE @id int
   SELECT @id = ProductID FROM deleted
   UPDATE Products SET Discontinued = 1 WHERE ProductId = @id 

   /*
    * Öğrenciler
	* OgrenciId  Ad  Soyad  Puan
	* 

	* Geçenler
	* OgrenciId  Ad  Soyad  Puan

	* Kalanlar
	* OgrenciId  Ad  Soyad  Puan

	-- Otomatik olarak 50'nin üzerinde alan öğrenciyi, Geçenlere; altındaysa Kalanlar tablosuna kaydedecek trigger.
	-- Geçenler tablosuna insert yapılmaya çalışıldığında INSTEAD OF ile kaydı Öğrencilere yönlendiren trigger

	*

	/