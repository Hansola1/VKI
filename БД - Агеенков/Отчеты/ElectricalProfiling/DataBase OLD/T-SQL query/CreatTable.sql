use [ElectricalProfiling]

-- Таблица Заказчик (Customer)
CREATE TABLE Customer (
    ID INT PRIMARY KEY IDENTITY(1,1),
    company_name NVARCHAR(255) NOT NULL,
    phone_number NVARCHAR(50)
);

-- Таблица Проект (Project)
CREATE TABLE Project (
    ID INT PRIMARY KEY IDENTITY(1,1),
    name NVARCHAR(255) NOT NULL,
    customer_id INT FOREIGN KEY REFERENCES Customer(ID),
    start_date DATE,
    end_date DATE
);

-- Таблица Площадь исследований (Area)
CREATE TABLE Area (
    ID INT PRIMARY KEY IDENTITY(1,1),
    name NVARCHAR(255) NOT NULL,
    project_id INT FOREIGN KEY REFERENCES Project(ID)
);

-- Таблица Координаты площади (AreaCoordinate)
CREATE TABLE AreaCoordinate (
    ID INT PRIMARY KEY IDENTITY(1,1),
    area_id INT FOREIGN KEY REFERENCES Area(ID),
    X FLOAT NOT NULL,
    Y FLOAT NOT NULL
);

-- Таблица Профиль (Profile)
CREATE TABLE Profile (
    ID INT PRIMARY KEY IDENTITY(1,1),
    area_id INT FOREIGN KEY REFERENCES Area(ID),
    name NVARCHAR(255) NOT NULL
);

-- Таблица Координаты профиля (ProfileCoordinate)
CREATE TABLE ProfileCoordinate (
    ID INT PRIMARY KEY IDENTITY(1,1),
    profile_id INT FOREIGN KEY REFERENCES Profile(ID),
    X FLOAT NOT NULL,
    Y FLOAT NOT NULL,
    point_type NVARCHAR(50) CHECK (point_type IN ('start', 'end', 'breakpoint'))
);

-- Таблица Станция (Station)
CREATE TABLE Station (
    ID INT PRIMARY KEY IDENTITY(1,1),
    profile_id INT FOREIGN KEY REFERENCES Profile(ID),
    coordinates NVARCHAR(100), -- координаты местоположения станции
    elevation FLOAT -- высота станции над уровнем моря
);

-- Таблица Оператор (Operator) -- УДАЛЕН
CREATE TABLE Operator (
    ID INT PRIMARY KEY IDENTITY(1,1),
    full_name NVARCHAR(255) NOT NULL,
    organization NVARCHAR(255),
    qualification NVARCHAR(255) 
);

-- Таблица Измерения (Measurement)
CREATE TABLE Measurement (
    ID INT PRIMARY KEY IDENTITY(1,1),
    station_id INT FOREIGN KEY REFERENCES Station(ID),
    date DATETIME,
    measurement_type NVARCHAR(100),
    value FLOAT, --значение
    units NVARCHAR(50) --единица измерения
);
