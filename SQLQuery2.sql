--select 
--ANSII
Select ContactName,CompanyName ,City  from Customers

Select * from Customers where City = 'London'
--case insensitive
Select * from Products where CategoryID = 1 and UnitPrice  >=10 order by UnitPrice asc

select * from Products  order by UnitPrice asc --ascending(default)  --descending dsc

select count(*) Adet from Product 
select CategoryID,  count(*) from products where UnitPrice >20
group by CategoryID having count(*)<10