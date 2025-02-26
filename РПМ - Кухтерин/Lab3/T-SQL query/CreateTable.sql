USE [EduTech Solutions]

CREATE TABLE Roles (
    id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    roleName VARCHAR(50) NOT NULL UNIQUE -- 'Admin 1', 'Teacher 2', 'Student 3'
);

CREATE TABLE Users (
    id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    name VARCHAR(255) NOT NULL,
    login VARCHAR(255) NOT NULL UNIQUE,
    password VARCHAR(255) NOT NULL,  
    roleID INT NOT NULL,           
    FOREIGN KEY (roleID) REFERENCES Roles(id)
);

CREATE TABLE Courses (
    id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    titleCourse VARCHAR(255) NOT NULL,
    teacherID INT NOT NULL,        
    time VARCHAR(255) NOT NULL,             
    maxStudents INT NOT NULL,        
    class VARCHAR(255) NOT NULL,       
    FOREIGN KEY (teacherID) REFERENCES Users(id) 
);

CREATE TABLE CourseEnrollments (
    id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    courseID INT NOT NULL,
    studentID INT NOT NULL,
    FOREIGN KEY (courseID) REFERENCES Courses(id),
    FOREIGN KEY (studentID) REFERENCES Users(id),
    UNIQUE(courseID, studentID) 
);

CREATE TABLE ListRequest (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    StudentName VARCHAR(100) NOT NULL,
    ApplicationDate DATE NOT NULL,
    Status VARCHAR(50) NOT NULL
);

