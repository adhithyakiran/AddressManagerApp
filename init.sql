
CREATE TABLE IF NOT EXISTS Organizations (
    Id INTEGER PRIMARY KEY AUTOINCREMENT,
    Name TEXT NOT NULL,
    Street TEXT NOT NULL,
    Zip TEXT NOT NULL,
    City TEXT NOT NULL,
    Country TEXT NOT NULL
);


CREATE TABLE IF NOT EXISTS Staff (
    Id INTEGER PRIMARY KEY AUTOINCREMENT,
    Title TEXT NOT NULL,
    FirstName TEXT NOT NULL,
    LastName TEXT NOT NULL,
    PhoneNumber TEXT NOT NULL,
    Email TEXT NOT NULL,
    OrganizationId INTEGER,
    FOREIGN KEY (OrganizationId) REFERENCES Organizations (Id)
);
