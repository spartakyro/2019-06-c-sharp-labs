drop database if exists students
drop table if exists spartans


create database students

create table spartans
(
	ID int PRIMARY KEY,
	SeperateTitle nvarchar (12),
	FirstName nvarchar(50),
	Lastname nvarchar(50),
	University nvarchar(50),
	Course nvarchar(50),
	MarkArchived nvarchar(50),
	

)



insert into spartans (ID, SeperateTitle, FirstName, LastName, University, Course, MarkArchived) values (1, 'miss', 'Ehiuwa', 'Oronsaye', 'this is long', 'zoning out', 'doesnt know...she zoned out')
insert into spartans (ID,SeperateTitle,FirstName,LastName,University,Course,MarkArchived) values (2,'Man like','Sanru','mathybalan','university of GTA', 'car theft', 'well....hes not in jail')
insert into spartans (ID,SeperateTitle,FirstName,LastName,University,Course,MarkArchived) values (3,'sir','Alexanderson','Johnsonder','UVN', 'cloud chasing', 'approved')
insert into spartans (ID,SeperateTitle,FirstName,LastName,University,Course,MarkArchived) values (4,'mr','wally','ige','now you see me', 'running', 'now you dont')
insert into spartans (ID,SeperateTitle,FirstName,LastName,University,Course,MarkArchived) values (5,'miss','New','York','nestle', 'college','nine-nine')
insert into spartans (ID,SeperateTitle,FirstName,LastName,University,Course,MarkArchived) values (6,'Avatar','tobias','soutar','earth bending', 'earth science','didnt finish, the fire nation attacked')
insert into spartans (ID,SeperateTitle,FirstName,LastName,University,Course,MarkArchived) values (7,'mr','liam','harris','northbrooke metro', 'game design', '2:1')
insert into spartans (ID,SeperateTitle,FirstName,LastName,University,Course,MarkArchived) values (8,'bishop','Phil','Anderson','geezer university', 'sick lessons', 'legitness')



select * from spartans


