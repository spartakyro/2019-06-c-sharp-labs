/*creating example*/
drop database test02
go
Create database test02
go
drop table table_02
go
create table table_02
(
	id int not null Identity primary key,
	name nvarchar(50) not null,
	date_of_birth DATETIME null,
	is_happy bit
)

INSERT INTO table_02 VALUES ('BOB','2019-01-01','true')

/*new record no name*/


INSERT INTO table_02 ( name, date_of_birth, is_happy) Values ('tim','2019-01-01','true')
INSERT INTO table_02 ( name,is_happy) Values ('dela','true')
select * From table_02
update table_02 set is_happy = 'false' where id = 3
select * from table_02
update table_02 set is_happy = 'false'
select * from table_02