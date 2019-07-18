drop database if exists students
drop table if exists spartans


create database students

create table spartans
(
	
	SeperateTitle nvarchar (12) PRIMARY KEY,
	FirstName nvarchar(50),
	LastName nvarchar(50),
	University nvarchar(50),
	Course nvarchar(50),
	MarkArchived nvarchar(50),
	

)



INSERT INTO spartans (SeperateTitle, FirstName, LastName, University, Course, MarkArchived) VALUES ( 'miss', 'Ehiuwa', 'Oronsaye', 'this is long', 'zoning out', 'doesnt know...she zoned out')
insert into spartans (SeperateTitle,FirstName,LastName,University,Course,MarkArchived) values ('Man like','Sanru','mathybalan','university of GTA', 'car theft', 'well....hes not in jail')
insert into spartans (SeperateTitle,FirstName,LastName,University,Course,MarkArchived) values ('sir','Alexanderson','Johnsonder','UVN', 'cloud chasing', 'approved')
insert into spartans (SeperateTitle,FirstName,LastName,University,Course,MarkArchived) values ('master','wally','ige','now you see me', 'running', 'now you dont')
insert into spartans (SeperateTitle,FirstName,LastName,University,Course,MarkArchived) values ('misses','New','York','nestle', 'college','nine-nine')
insert into spartans (SeperateTitle,FirstName,LastName,University,Course,MarkArchived) values ('Avatar','tobias','soutar','earth bending', 'earth science','didnt finish, the fire nation attacked')
insert into spartans (SeperateTitle,FirstName,LastName,University,Course,MarkArchived) values ('mr','liam','harris','northbrooke metro', 'game design', '2:1')
insert into spartans (SeperateTitle,FirstName,LastName,University,Course,MarkArchived) values ('bishop','Phil','Anderson','geezer university', 'sick lessons', 'legitness')

select * from spartans



