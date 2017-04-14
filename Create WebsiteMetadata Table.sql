CREATE TABLE WebsiteMetadata
(
ID int IDENTITY(1,1) PRIMARY KEY,
Title varchar(255) NOT NULL,
DefaultTheme varchar(255) NOT NULL,
AdminEmail varchar(255) NOT NULL,
LogErrors BIT NOT NULL	
)