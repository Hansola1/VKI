USE EducationPlans;

INSERT INTO Groups (title)
VALUES ('2207');

INSERT INTO Student (name, login, password, groupID)
VALUES ('1', '1', '1', 1);

INSERT INTO Teacher (name, login, password, specialization)
VALUES ('1', '1', '1', '1');

INSERT INTO Groups (title) VALUES ('2207�1'), ('2207�3');

INSERT INTO Class (title, type) VALUES ('���. 101', '� ��'), ('���. 102', '��� ��');

INSERT INTO [Subject] (title, hourAll, ending) VALUES ('����������', 60, '�������'), ('����������������', 60, '�����');

INSERT INTO Teacher (name, login, password, specialization) VALUES 
('������ �.�.', 'ivanov', '12345', '����������'), 
('������� �.�.', 'petrova', '12345', '����������������');

INSERT INTO SpecializationSubject (subjectID, teacherID) VALUES (1, 1), (2, 2);

INSERT INTO Schedule (timeStart, timeEnd, classID, groupID, specializationSubjectID) 
VALUES 
('20250422 08:30:00', '20250422 10:00:00', 1, 1, 1),
('20250422 10:10:00', '20250422 11:40:00', 2, 2, 2);
