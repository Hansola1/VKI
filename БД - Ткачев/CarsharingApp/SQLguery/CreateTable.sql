USE Carsharing;

CREATE TABLE users (
    ID INT PRIMARY KEY IDENTITY(1,1),
    login VARCHAR(255) UNIQUE NOT NULL,
    password VARCHAR(255) NOT NULL,
    lastname VARCHAR(255) NOT NULL,
    firstname VARCHAR(255) NOT NULL,
    surname VARCHAR(255),
    telephone VARCHAR(20) NOT NULL,
    email VARCHAR(255)
);

CREATE TABLE transports (
    id INT PRIMARY KEY IDENTITY(1,1),
    type VARCHAR(255) NOT NULL,
    capacity VARCHAR(255) NOT NULL, 
    maxspeed FLOAT NOT NULL,
    modelname VARCHAR(255) NOT NULL
);

CREATE TABLE trips (
    id INT PRIMARY KEY IDENTITY(1,1),
    transportid INT NOT NULL REFERENCES transports(id),
    userid INT NOT NULL REFERENCES users(id),
    startdt VARCHAR(255) NOT NULL, 
    duration INT NOT NULL, 
    costvalue FLOAT NOT NULL,
    ispaid Bit NOT NULL  
);
