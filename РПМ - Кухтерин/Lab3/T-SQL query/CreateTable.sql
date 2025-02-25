USE [EduTech Solutions];

CREATE TABLE Roles (
    id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    roleName VARCHAR(50) NOT NULL UNIQUE -- 'Admin', 'Teacher', 'Student'
);

CREATE TABLE Users (
    id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    name VARCHAR(255) NOT NULL,
    login VARCHAR(255) NOT NULL UNIQUE,
    password VARCHAR(255) NOT NULL,  
    roleID INT NOT NULL,           
    FOREIGN KEY (roleID) REFERENCES Roles(id)
);

CREATE TABLE Teachers (
    id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    userID INT NOT NULL,
    FOREIGN KEY (userID) REFERENCES Users(id)
);
CREATE TABLE Students (
    id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    userID INT NOT NULL,
    FOREIGN KEY (userID) REFERENCES Users(id)
);

CREATE TABLE Courses (
    id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    titleCourse VARCHAR(255) NOT NULL,
    teacherID INT NOT NULL,        
    time VARCHAR(255) NOT NULL,             
    maxStudents INT NOT NULL,        
    class VARCHAR(255) NOT NULL,       
    FOREIGN KEY (teacherID) REFERENCES Teachers(id),
);

CREATE TABLE CourseEnrollments (
    id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    courseID INT NOT NULL,
    studentID INT NOT NULL,
    FOREIGN KEY (courseID) REFERENCES Courses(id),
    FOREIGN KEY (studentID) REFERENCES Students(id),
    UNIQUE(courseID, studentID) -- предотвращение дублирования записей
);

