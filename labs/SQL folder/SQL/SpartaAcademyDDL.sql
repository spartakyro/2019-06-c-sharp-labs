/* This script will create all the tables required for the Sparta Global Course Scheduling Database */
/* See separate scripts for INSERT statements */
USE SpartaAcademy;
DROP TABLE CourseScheduleTrainers;
DROP TABLE CourseScheduleAttendees;
DROP TABLE CourseSchedule;
DROP TABLE Rooms;
DROP TABLE Academies;
DROP TABLE CourseCatalog;
DROP TABLE Employees;
CREATE TABLE Employees 
(
EmployeeID int IDENTITY PRIMARY KEY NOT NULL,
FirstName VARCHAR (30) NOT NULL,
LastName VARCHAR(30) NOT NULL,
EmployeeType CHAR(1) NOT NULL,
StartDate DATETIME,
EndDate DATETIME
);

CREATE TABLE CourseCatalog 
(
CourseID int IDENTITY PRIMARY KEY NOT NULL,
CourseName VARCHAR (30) NOT NULL,
Duration SMALLINT NOT NULL
);

CREATE TABLE Academies
(
AcademyID int IDENTITY PRIMARY KEY NOT NULL,
AcademyName VARCHAR(30) NOT NULL
);

CREATE TABLE Rooms
(
RoomID int IDENTITY PRIMARY KEY NOT NULL,
AcademyID int NOT NULL,
RoomName VARCHAR(30) NOT NULL,
Description VARCHAR(MAX),
Capacity SMALLINT
);


CREATE TABLE CourseSchedule
( 
CourseScheduleID int IDENTITY PRIMARY KEY NOT NULL,
AcademyID int NOT NULL,
RoomID int NOT NULL,
CourseID int NOT NULL,
StartDate DATE NOT NULL,
EndDate DATE NOT NULL
);


CREATE TABLE CourseScheduleTrainers
(
CourseScheduleID int NOT NULL,
TrainerID int NOT NULL,
TrainerType CHAR(1)
);


CREATE TABLE CourseScheduleAttendees
(
CourseScheduleID int NOT NULL,
AttendeeID int NOT NULL,
Active BIT NOT NULL
);