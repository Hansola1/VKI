USE Carsharing;


INSERT INTO users (login, password, lastname, firstname, surname, telephone, email) VALUES
('john.doe', 'hashed_password_1', 'Doe', 'John', 'Michael', '123-456-7890', 'john.doe@example.com'),
('jane.smith', 'hashed_password_2', 'Smith', 'Jane', 'Elizabeth', '987-654-3210', 'jane.smith@example.com'),
('peter.jones', 'hashed_password_3', 'Jones', 'Peter', 'David', '555-123-4567', 'peter.jones@example.com'),
('mary.brown', 'hashed_password_4', 'Brown', 'Mary', 'Ann', '111-222-3333', 'mary.brown@example.com'),
('david.wilson', 'hashed_password_5', 'Wilson', 'David', 'James', '444-555-6666', 'david.wilson@example.com');


INSERT INTO transports (type, capacity, maxspeed, modelname) VALUES
('Sedan', '5', 180.0, 'Toyota Camry'),
('SUV', '7', 200.0, 'Ford Explorer'),
('Hatchback', '5', 160.0, 'Honda Civic'),
('Electric', '4', 150.0, 'Tesla Model 3'),
('Minivan', '8', 170.0, 'Chrysler Pacifica');

INSERT INTO trips (transportid, userid, startdt, duration, costvalue, ispaid) VALUES
(1, 1, '2024-01-20', 30, 15.00, 1),
(2, 2, '2024-01-20', 45, 22.50, 1),
(3, 3, '2024-01-20', 60, 30.00, 0),
(4, 4, '2024-01-20', 20, 10.00, 1),
(5, 5, '2024-01-20', 90, 45.00, 0);

