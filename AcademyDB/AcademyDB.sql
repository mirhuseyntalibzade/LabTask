create procedure InsertIntoStudents
@FirstName nvarchar(20), 
@LastName nvarchar(20), 
@DateOfBirth date, 
@UserName nvarchar(20),
@Password nvarchar(20), 
@EnrollmentDate date
AS
INSERT INTO Students
(firstname, 
lastname, 
dateofbirth, 
username,
password,
enrollmentdate)
VALUES(@FirstName, @LastName, @DateOfBirth,@UserName,@Password,@EnrollmentDate)
GO

exec InsertIntoStudents 'TEST', 'Something', '2000-05-15', 'alicej', 'password123', '2024-09-01'


create function ShowLessonSchedule(@Id int)
returns table
as
return(
select Students.Id, Students.FirstName,Students.LastName, Groups.GroupName, Classes.Schedule , Classes.RoomName
FROM Students
JOIN Enrollments ON Students.Id = Enrollments.StudentId
JOIN Groups ON Enrollments.GroupId = Groups.Id
JOIN Classes ON Groups.Id = Classes.GroupId
WHERE Students.Id = @Id
)

SELECT * FROM ShowLessonSchedule(3)



create table Students(
Id int IDENTITY PRIMARY KEY,
FirstName nvarchar(20),
LastName nvarchar(20),
DateOfBirth date,
UserName nvarchar(20),
Password nvarchar(20),
EnrollmentDate date
)

create table Departments(
Id int IDENTITY PRIMARY KEY,
DepartmentName nvarchar(20)
)

create table Instructors(
Id int IDENTITY PRIMARY KEY,
FirstName NVARCHAR(20),
LastName NVARCHAR(20),
HireDate DATE,
DepartmentId INT,
FOREIGN KEY (DepartmentId) REFERENCES Departments(Id),
Username NVARCHAR(20),
Password NVARCHAR(20),
PIN NVARCHAR(20)
)

create table Groups(
Id INT IDENTITY PRIMARY KEY,
GroupName NVARCHAR(20),
DepartmentId INT,
FOREIGN KEY (DepartmentId) REFERENCES Departments(Id),
StartDate DATE,
EndDate DATE
)

create table Enrollments(
Id int IDENTITY PRIMARY KEY,
StudentId int,
GroupId int,
FOREIGN KEY (StudentId) REFERENCES Students(Id),
FOREIGN KEY (GroupId) REFERENCES Groups(Id),
)

create table Classes(
Id int IDENTITY PRIMARY KEY,
GroupId int,
InstructorId int,
Schedule NVARCHAR(20),
RoomName NVARCHAR(20),
FOREIGN KEY (GroupId) REFERENCES Groups(Id),
FOREIGN KEY (InstructorId) REFERENCES Instructors(Id)
)