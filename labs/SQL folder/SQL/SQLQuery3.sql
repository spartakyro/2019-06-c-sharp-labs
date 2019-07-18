/*select * from products where ProductName like '%ch%' 
select * from Products where ProductName like '[ABC]%'
select * from Products where ProductName like '[^ABC]%'

select * from Products where ProductName like 'ch_______'

/*	  IN	*/
select * from customers where country IN ('Germany','France','uk') order by city asc
/*  Between	*/
select * from products where UnitsInStock between 100 and 120 order by UnitsInStock asc
/* set quoted identifier - find items with single ' in string  */

SET QUOTED_IDENTIFIER OFF
SELECT * from Products where ProductName like "%'%"

select ProductName,ProductID from Products where UnitPrice < 5.00
select * from orders where employeeID in (5,7) 

/*as*/

Select CustomerID as ID, Address +', '+ City+ ', ' + Country as location From Customers*/

select * from Customers

select distinct Country from customers where Region is not null
select count (distinct Country) from customers where Region is not null
