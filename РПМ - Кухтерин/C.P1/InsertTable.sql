USE Library
CREATE TABLE Readers 
(
    reader_id INT PRIMARY KEY IDENTITY(1,1),
    reader_name VARCHAR(100) NOT NULL,
);

CREATE TABLE Books 
(
    id INT PRIMARY KEY IDENTITY(1,1),
    article_number NVARCHAR(50) UNIQUE NOT NULL,
    title NVARCHAR(255) NOT NULL,
    genre NVARCHAR(100),
    description NVARCHAR(MAX),
    issue_date NVARCHAR(255),
    return_date NVARCHAR(255),
    status NVARCHAR(50) CHECK (status IN ('в наличии', 'выдана', 'на обслуживании')) DEFAULT 'в наличии',
    reader_id INT,
    FOREIGN KEY (reader_id) REFERENCES Readers(reader_id)
);