CREATE DATABASE StudentManagementDb;
GO

USE StudentManagementDb;
GO

CREATE TABLE Students (
    Id          INT PRIMARY KEY IDENTITY(1,1),
    Name        NVARCHAR(100) NOT NULL,
    Email       NVARCHAR(150) NOT NULL,
    Age         INT NOT NULL,
    Course      NVARCHAR(100) NOT NULL,
    CreatedDate DATETIME2 NOT NULL DEFAULT GETUTCDATE()
);
