/*select * from [Order Details]
/*product. price. quantity. %discount*/
select *,unitprice * quantity as 'Gross Order' from [Order Details]
/*include discount*/
select *, unitprice*quantity as 'Gross Order',
UnitPrice*Quantity*(1-Discount) as 'Net Order'
from [Order Details] order by [Net Order] desc*/

/*min, max, sum ,avg, count*//*
select * from [Order Details]

select MIN(unitprice) as 'Cheapest Item' from [Order Details] 
/* max price*/
select MAX(unitprice) as 'Most Expensive Item' from [Order Details]
select Sum(unitprice) as 'sum of Item' from [Order Details]
select AVG(unitprice) as 'sum of average Item' from [Order Details]
select count(unitprice) as 'breh' from [Order Details]*/
/*select * from Products
select * from Products order by SupplierID
/*statistics (sum,avg, per supplier)*/

select supplierid, 
SUM(unitsinstock) as stock, 
SUM(unitsonorder) as ordered,
MAX(unitsonorder) as maxordered
from Products group by SupplierID order by maxordered desc

select * from products
select categoryid, avg(ReorderLevel) as relevel from products  group by CategoryID order by relevel desc*/

select avg (reorderlevel) as avgreorder,
CategoryID
from Products
where ProductID = 5 or CategoryID = 1
group by CategoryID
having AVG(ReorderLevel) > 10
order by avgreorder desc


select avg(UnitsInStock) as unitslol, ProductID from products group by ProductID having ProductID > 2





