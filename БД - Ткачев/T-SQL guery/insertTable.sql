USE BorodinaAV_2207d2;

INSERT INTO Characters (id, userID, species, name, level, class) VALUES
(1, 1, '����', 'Hani', 5, '�������'),
(2, 2, '�������', 'Pipo', 3, '����'),
(3, 3, '�����', 'Lilo', 4, '�����');

INSERT INTO Class (id, title, description, mainFeatures) VALUES
(1, '�������', '����� ������', '����'),
(2, '����', '����� ����� ������', '��������'),
(3, '�����', '����� ����� ����� ������', '��');

INSERT INTO List (classID, characterID) VALUES
(1, 1),
(2, 2),
(3, 3);

INSERT INTO Inventory (characterID, objectID, force, title) VALUES
(1, 'bow01', 10, '���'),
(2, 'sword01', 15, '���'),
(3, 'axe01', 12, '�����');

INSERT INTO Skills (id, description, effect, force, classID) VALUES
(1, '����������', 5, 10, 1),
(2, '��������', 7, 15, 2),
(3, '��������', 10, 20, 3);

INSERT INTO Locations (id, biome, level, description) VALUES
(1, '���', 1, '������� � �������'),
(2, '�������', 2, '��� ���� � �������'),
(3, '����', 3, '���� � �������'); 

INSERT INTO Quests (id, description, locationID, level, type) VALUES
(1, '�������� 50 ����', 1, 1, '�����'),
(2, '���������� 10 ��������', 2, 2, '��������'),
(3, '����� ������', 3, 3, '�����');

INSERT INTO NPCs (id, name, history, locationID) VALUES
(1, '������ �������', '������ ������', 1),
(2, '�������� �� �������', '��������, ������� ������������', 2),
(3, '��� �� �����', '������� ���������', 3);

INSERT INTO Enemies (id, locationID, name, history, level) VALUES
(1, 1, '������ ������', '������ ��� � ���', 2),
(2, 2, '�������� �������', '������ ��� � ���', 4),
(3, 3, '������ ������', '������ �� ��� � ���', 5);
