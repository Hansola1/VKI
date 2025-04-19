USE EducationPlans;

CREATE TABLE Groups (
    id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    title VARCHAR(255) NOT NULL
);

CREATE TABLE Student (
    id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    name VARCHAR(255) NOT NULL,
    login VARCHAR(255) NOT NULL UNIQUE,
    password VARCHAR(255) NOT NULL,  
    groupID INT NOT NULL,           
    FOREIGN KEY (groupID) REFERENCES Groups(id)
);

CREATE TABLE Teacher (
    id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    name VARCHAR(255) NOT NULL,
    login VARCHAR(255) NOT NULL UNIQUE,
    password VARCHAR(255) NOT NULL,  
    specialization VARCHAR(255) NOT NULL
);

CREATE TABLE Class (
    id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    title VARCHAR(255) NOT NULL, 
    type VARCHAR(255) NOT NULL
);

CREATE TABLE [Subject] (
    id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    title VARCHAR(255) NOT NULL, 
    hourAll INT NOT NULL, -- уч. часы: 60ч, 20ч --
    ending VARCHAR(255) NOT NULL -- формат сдачи: к.р, зачет, экзамен --
);

CREATE TABLE SpecializationSubject (
    id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    subjectID INT NOT NULL,   
    teacherID INT NOT NULL,  
    FOREIGN KEY (subjectID) REFERENCES [Subject](id),       
    FOREIGN KEY (teacherID) REFERENCES Teacher(id)
);

CREATE TABLE Schedule (
    id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,    
    timeStart DATETIME NOT NULL,
    timeEnd DATETIME NOT NULL,
    classID INT NOT NULL,  
    groupID INT NOT NULL,
    specializationSubjectID INT NOT NULL, 
    FOREIGN KEY (classID) REFERENCES Class(id),
    FOREIGN KEY (groupID) REFERENCES Groups(id),
    FOREIGN KEY (specializationSubjectID) REFERENCES SpecializationSubject(id)
);

CREATE TABLE Journal (
    id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    subjectID INT NOT NULL,   
    teacherID INT NOT NULL,  
    scheduleID INT NOT NULL, 
    value VARCHAR(255) NOT NULL, -- оценка: N/A, 2-5 --
    FOREIGN KEY (subjectID) REFERENCES [Subject](id),       
    FOREIGN KEY (teacherID) REFERENCES Teacher(id),
    FOREIGN KEY (scheduleID) REFERENCES Schedule(id)
);

CREATE TABLE JournalHomework (
    id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    title VARCHAR(255) NOT NULL, 
    description VARCHAR(255) NOT NULL, 
    deadline DATETIME,
    subjectID INT NOT NULL,    
    scheduleID INT NOT NULL, 
    FOREIGN KEY (subjectID) REFERENCES [Subject](id),       
    FOREIGN KEY (scheduleID) REFERENCES Schedule(id)
);
