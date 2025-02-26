INSERT INTO Roles (roleName) VALUES ('Admin'), ('Teacher'), ('Student');

INSERT INTO Users (name, login, password, roleID) VALUES
('Nastya', 'Hansola', '12345', 1),
('Teacher1', 'teacher1', '12345', 2),
('Student1', 'student1', '12345', 3),
('Student2', 'student2', '12345', 3),
('Student3', 'student3', '12345', 3),
('Student4', 'student4', '12345', 3);

INSERT INTO Courses (titleCourse, teacherID, time, maxStudents, class) VALUES
('Russian lang', 2, '120', 10, '101A'),
('DataBase', 2, '14:00-15:30', 15, '202D');

INSERT INTO CourseEnrollments (courseID, studentID) VALUES
(1, 3), (1, 4), (2, 3), (2,4);

INSERT INTO ListRequest (StudentName, ApplicationDate, Status) VALUES ('Student1', '2023-10-01', 'Рассматривается');
INSERT INTO ListRequest (StudentName, ApplicationDate, Status) VALUES ('Student2', '2023-10-03', 'Принята');
INSERT INTO ListRequest (StudentName, ApplicationDate, Status) VALUES ('Student2', '2023-10-02', 'Отклонена');
INSERT INTO ListRequest (StudentName, ApplicationDate, Status) VALUES ('Student3', '2023-10-04', 'Рассматривается');
INSERT INTO ListRequest (StudentName, ApplicationDate, Status) VALUES ('Student4', '2023-10-05', 'Принята');



