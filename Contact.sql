CREATE DATABASE Lesson7
GO
USE Lesson7
GO
CREATE TABLE Contact(
	ID INT IDENTITY(1,1) PRIMARY KEY,
	NAME VARCHAR(50)  NULL,
	Tel VARCHAR(15) NULL,
	Email VARCHAR(50) NULL,
	Address VARCHAR (255) NULL
)
GO
