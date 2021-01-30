Select count(ContactName)  from Customers

Select * from Customers where City = 'London'
--case insensitive
Select * from Products where CategoryID = 1 and UnitPrice  >=10 order by UnitPrice asc

select * from Products  order by UnitPrice asc --ascending(default)  --descending desc

select count(*) Adet from Product

select CategoryID ,count(*) from Products where UnitPrice>20 group by CategoryID having count(*)<10

select Products.ProductID ,Products.ProductName,Products.UnitPrice, Categories.CategoryName 
from Products inner join Categories on Products.CategoryID = Categories.CategoryID
where Products.UnitPrice>=10 
--DTO Data Transformation object

Select * FROM products p left join [Order Details] AS od on p.ProductID= od.ProductID 

select * from customers c left join Orders o on c.CustomerID = o.CustomerID  where  o.CustomerID is null
 
 Select Products.ProductName as ürün ,SUM([Order Details].UnitPrice*[Order Details].Quantity) as  [kazanılan para] from Products inner join [Order Details] on Products.ProductID = [Order Details].ProductID group by ProductName

 select * from Products inner join [Order Details] on Products.ProductID=[Order Details].ProductID


