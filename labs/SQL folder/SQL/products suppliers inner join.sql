select p.*, s.companyName, c.Categoryname from Products p
inner join Suppliers s on p.SupplierID = s.SupplierID
inner join Categories c on p.categoryid = c.CategoryID 