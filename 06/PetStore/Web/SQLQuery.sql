CREATE TABLE Customers(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Name VARCHAR(20) not null,
    Zipcode INT,
    Email VARCHAR(20) not null,
)

CREATE TABLE Logins(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    CustomerId INT FOREIGN KEY REFERENCES Customers(Id)
,
    Username VARCHAR(20) not null,
    Password VARCHAR(30) not null,
)

CREATE PROCEDURE InsertCustomer
(
@Name VARCHAR(20),
@Zipcode INT,
@Email VARCHAR(20)
)
AS
BEGIN
INSERT INTO Customers(Name,Email,Zipcode) VALUES (@Name,@Email,@Zipcode)
END
GO


CREATE PROCEDURE InsertLogin
(
@Email VARCHAR(20),
@Username VARCHAR(20),
@Password VARCHAR(30)
)
AS
BEGIN
INSERT INTO Logins(CustomerId,Username,Password) VALUES ((select id from Customers where Email = @Email),@Username,@Password)
END
GO

select * from Customers
select * from Logins