
DROP TABLE student;
CREATE TABLE student(  
    id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
    first_name TEXT,
    last_name TEXT,
    middle_name TEXT,
    groupId INTEGER,
    FOREIGN KEY (groupId) REFERENCES class(id)
);
