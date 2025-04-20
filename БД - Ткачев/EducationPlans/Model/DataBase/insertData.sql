USE EducationPlans;

INSERT INTO Groups (title)
VALUES ('2207');

INSERT INTO Student (name, login, password, groupID)
VALUES ('1', '1', '1', 1);

INSERT INTO Teacher (name, login, password, specialization)
VALUES ('1', '1', '1', '1');

INSERT INTO Groups (title) VALUES ('2207д1'), ('2207д3');

INSERT INTO Class (title, type) VALUES ('Ауд. 101', 'С ПК'), ('Ауд. 102', 'Без ПК');

INSERT INTO [Subject] (title, hourAll, ending) VALUES ('Математика', 60, 'Экзамен'), ('Программирование', 60, 'Зачет');

INSERT INTO Teacher (name, login, password, specialization) VALUES 
('Иванов И.И.', 'ivanov', '12345', 'Математика'), 
('Петрова А.А.', 'petrova', '12345', 'Программирование');

INSERT INTO SpecializationSubject (subjectID, teacherID) VALUES (1, 1), (2, 2);

INSERT INTO Schedule (timeStart, timeEnd, classID, groupID, specializationSubjectID) 
VALUES 
('20250422 08:30:00', '20250422 10:00:00', 1, 1, 1),
('20250422 10:10:00', '20250422 11:40:00', 2, 2, 2);
