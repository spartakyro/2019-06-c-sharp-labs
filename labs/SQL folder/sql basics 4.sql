drop database if exists collegeDB
drop table if exists Students
drop table if exists Courses


create database collegeDB
go


create table Courses
( 
	CourseID int IDENTITY PRIMARY KEY,
	CourseName nvarchar(50)
	

)
create table Students
( StudentID int identity primary key,
	StudentName nvarchar(50),
	CourseID int foreign key(CourseID) REFERENCES Courses(CourseID)
)

SET IDENTITY_INSERT Courses ON 
INSERT INTO Courses(CourseID,CourseName) Values (1,'Maths')
INSERT INTO Courses(CourseID,CourseName) Values (2,'Science')
INSERT INTO Courses(CourseID,CourseName) Values (3,'Economics')
INSERT INTO Courses(CourseID,CourseName) Values (4,'Spanish')
Set IDENTITY_INSERT Courses OFF

SET IDENTITY_INSERT Students ON 
INSERT INTO Students(StudentID,StudentName,CourseID) Values (,'gbenge',1)
INSERT INTO Students(StudentID,StudentName,CourseID) Values (2,'koffi',2)
INSERT INTO Students(StudentID,StudentName,CourseID) Values (3,'opra',3)
INSERT INTO Students(StudentID,StudentName,CourseID) Values (4,'ehiuwa',4)
Set IDENTITY_INSERT Students OFF

select * from Courses
select * from Students
