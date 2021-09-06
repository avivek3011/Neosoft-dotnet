
--Create table Customer(id int IDENTITY(1,1)Primary key,Namee varchar(225),Zipcode Varchar(225),Email varchar(225));
--Select * from Customer;
--Create table Login(id int IDENTITY(1,1),CustomerId int,UserName varchar(225),Password varchar(225));
--Select * from Login;

--create PROCEDURE CustomerRegistration @Name varchar(max),@Zipcode varchar(max),@Email varchar(max)
--as 
--Insert into Customer (Namee,Zipcode,Email) values(@Name,@Zipcode,@Email);
--Go

--EXEC CustomerRegistration @Name="Kunal", @Zipcode="1234",@Email= "Kunal@gmail.com";

--create PROCEDURE CustomerLogin @CustomerId int,@UserName varchar(max),@Password varchar(max)
--as 
--Insert into Login (CustomerId,UserName,Password) values(@CustomerId,@UserName,@Password);
--Go

--EXEC CustomerLogin @CustomerID=1,@UserName="kunal123",@Password="12345"; 
