drop database if exists taskDB
drop table if exists Tasks
drop table if exists categories



create database taskDB


create table Categories(
	categoryID int IDENTITY PRIMARY KEY,
	CategoryName nvarchar(50) not null
)

create table Tasks(
	taskid INT IDENTITY PRIMARY KEY,
	Description nvarchar (50) Null,
	Done Bit Null,
	CategoryID INT Null,
	Foreign KEY (categoryID) References categories (categoryID)

)