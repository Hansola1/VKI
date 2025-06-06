USE [ElectricalProfiling]

INSERT INTO Customer (company_name, phone_number) VALUES
('�����������', '74951234567'),
('����������', '7812987543'),
('�������������', '73435551234'),
('���������', '73832223344');

INSERT INTO Project (name, customer_id, start_date, end_date) VALUES
('�������� ������������� X', 1, '2023-01-15', '2023-06-30'),
('������������ �������� Y', 2, '2023-03-01', '2023-07-15'),
('����� ������ ��� Z', 3, '2023-05-20', '2023-10-31'),
('�������� ��������� W', 4, '2023-07-01', '2023-12-31');

INSERT INTO Area (name, project_id) VALUES
('������� 1', 1),
('������� 2', 1),
('������� A', 2),
('������� B', 2);

INSERT INTO AreaCoordinate (area_id, X, Y) VALUES
(1, 55.75, 37.62),
(2, 55.76, 37.63),
(3, 60.00, 30.00),
(4, 60.01, 30.01);

INSERT INTO Profile (area_id, name) VALUES
(1, '������� AA'),
(1, '������� BB'),
(2, '������� CC'),
(2, '������� DD');

INSERT INTO ProfileCoordinate (profile_id, X, Y, point_type) VALUES
(1, 55.751, 37.621, 'start'),
(1, 55.752, 37.622, 'end'),
(2, 55.761, 37.631, 'start'),
(2, 55.762, 37.632, 'end');

INSERT INTO Station (profile_id, coordinates, elevation) VALUES
(1, '55.7515, 37.6215', 150.5),
(1, '55.7525, 37.6225', 152.0),
(2, '55.7615, 37.6315', 145.3),
(2, '55.7625, 37.6325', 148.7);

INSERT INTO Operator (full_name, organization, qualification) VALUES
('������ ���� ��������', '�����������', '��������'),
('������ ���� ��������', '����������', '�������'),
('�������� ���� ���������', '�������������', '������'),
('�������� ������� ���������', '���������', '������');

INSERT INTO Measurement (station_id, operator_id, date, measurement_type, value, units) VALUES
(1, 1, '2023-01-16 10:00:00', '������������� �������������', 120.5, '��'),
(1, 1, '2023-01-16 10:15:00', '��������� ����', 50.2, '���'),
(2, 2, '2023-03-02 14:30:00', '������������� �������������', 150.0, '��'),
(2, 2, '2023-03-02 14:45:00', '��������� �����������', 15.8, '��');
