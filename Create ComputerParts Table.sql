CREATE TABLE ComputerParts
(
ID int IDENTITY(1,1) PRIMARY KEY,
UseType varchar(255) NOT NULL,
Part varchar(255) NOT NULL,
PartCode varchar(255) NOT NULL
)