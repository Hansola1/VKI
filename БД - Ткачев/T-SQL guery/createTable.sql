USE BorodinaAV_2207d2;

CREATE TABLE Users (
  id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
  login VARCHAR(255) NOT NULL,
  password VARCHAR(255) NOT NULL,
  email VARCHAR(255) NOT NULL,
  age INT NOT NULL,
  sex VARCHAR(10) NOT NULL
);

CREATE TABLE Characters (
  id INT PRIMARY KEY NOT NULL,
  userID INT NOT NULL,
  species VARCHAR(255) NOT NULL,
  name VARCHAR(255) NOT NULL,
  level INT NOT NULL,
  class VARCHAR(255) NOT NULL,
  FOREIGN KEY (userID) REFERENCES Users(id)
);

CREATE TABLE Class (
  id INT PRIMARY KEY NOT NULL,
  title VARCHAR(255) NOT NULL,
  description VARCHAR(255) NOT NULL,
  mainFeatures VARCHAR(255) NOT NULL
);

CREATE TABLE List (
  classID INT NOT NULL,
  characterID INT NOT NULL,
  FOREIGN KEY (classID) REFERENCES Class(id),
  FOREIGN KEY (characterID) REFERENCES Characters(id),
  PRIMARY KEY (classID, characterID)
);

CREATE TABLE Inventory (
  characterID INT NOT NULL,
  objectID VARCHAR(255) NOT NULL,
  force INT NOT NULL,
  title VARCHAR(255) NOT NULL,
  FOREIGN KEY (characterID) REFERENCES Characters(id),
  PRIMARY KEY (characterID, objectID)
);

CREATE TABLE Skills (
  id INT PRIMARY KEY NOT NULL,
  description VARCHAR(255) NOT NULL,
  effect INT NOT NULL,
  force INT NOT NULL,
  classID INT NOT NULL,
  FOREIGN KEY (classID) REFERENCES Class(id)
);

CREATE TABLE Locations (
  id INT PRIMARY KEY NOT NULL,
  biome VARCHAR(255) NOT NULL,
  level INT NOT NULL,
  description VARCHAR(255) NOT NULL
);

CREATE TABLE Quests (
  id INT PRIMARY KEY NOT NULL,
  description VARCHAR(255) NOT NULL,
  locationID INT NOT NULL,
  level INT NOT NULL,
  type VARCHAR(50) NOT NULL,
  FOREIGN KEY (locationID) REFERENCES Locations(id)
);

CREATE TABLE NPCs (
  id INT PRIMARY KEY NOT NULL,
  name VARCHAR(255) NOT NULL,
  history VARCHAR(255) NOT NULL,
  locationID INT NOT NULL,
  FOREIGN KEY (locationID) REFERENCES Locations(id)
);

CREATE TABLE Enemies (
  id INT PRIMARY KEY NOT NULL,
  locationID INT NOT NULL,
  name VARCHAR(255) NOT NULL,
  history VARCHAR(255) NOT NULL,
  level INT NOT NULL,
  FOREIGN KEY (locationID) REFERENCES Locations(id)
);
