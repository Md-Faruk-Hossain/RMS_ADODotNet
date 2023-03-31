
CREATE DATABASE RestaurantManagmantSystem
GO

USE RestaurantManagmantSystem
GO



---------------------------1.CREATE TABLE Menugroup-----------------------------
CREATE TABLE Menugroup
(
	        CatagoryId INT PRIMARY KEY,
	        MenuName VARCHAR(100) NOT NULL
)
GO

SELECT * FROM Menugroup
GO

------------------------>1.INSERT INTO Menugroup VALUES<------------------------------

INSERT INTO Menugroup VALUES (2 , 'Burger')
GO

SELECT CatagoryId , MenuName FROM Menugroup
GO

DELETE FROM Menugroup WHERE CatagoryId=1
GO

----------------------------2.CREATE TABLE ItemDetails--------------------------
CREATE TABLE ItemDetails
(
	        [Image] VARBINARY(MAX)  NULL,
			ItemId INT PRIMARY KEY,
	        CatagoryId INT REFERENCES Menugroup(CatagoryId),
	        ItemName VARCHAR(100) NOT NULL,
	        UnitPrice MONEY NOT NULL
	
)
GO



INSERT INTO ItemDetails VALUES (NULL , 1, 1,'Thai Soup',70.00)
  
GO

SELECT *FROM ItemDetails
GO

SELECT  [Image] , ItemId , CatagoryId , ItemName , UnitPrice FROM ItemDetails
GO


GO


-------------------------------3.CREATE TABLE Designation-------------------------
CREATE TABLE Designation
(
	    DesignationId INT PRIMARY KEY,
	    Titlename VARCHAR(52) NOT NULL
)
GO



------------------------------3.INSERT INTO Designation VALUES---------------------------------

INSERT INTO Designation VALUES
                  --(1,'Manager')
                  (2,'Cashier')
                  --('Waiter'),
                  --('Chef')
                  
GO

SELECT *FROM Designation
GO

SELECT DesignationId , Titlename FROM Designation
GO

DELETE FROM Designation WHERE DesignationId=1
GO



-----------------------------4.CREATE TABLE Employees------------------------------
CREATE TABLE Employees
(
	    EmployeeId INT PRIMARY KEY,
	    [Name]VARCHAR(100) NOT NULL,
	    DesignationId INT REFERENCES Designation(DesignationId),
	    PhoneNo VARCHAR(17) NOT NULL,
	    Gender VARCHAR(50) NOT NULL,
	    DOB DATE NOT NULL,
	    NID CHAR(20) NOT NULL UNIQUE,
	    Email VARCHAR(50) NOT NULL,
	    Joindate DATE NOT NULL, 
	    [Address] VARCHAR(200) NOT NULL,
		[Image] VARBINARY(MAX)  NULL
)
GO

UPDATE Employees  SET EmployeeId='', [Name]='', DesignationId='',  PhoneNo='', Gender='',  DOB='', NID='', Email='',  Joindate='', [Address] ='', [Image]= NULL WHERE EmployeeId ='1';

GO

SELECT EmployeeId, [Name], DesignationId, PhoneNo, Gender, DOB, NID, Email, Joindate, [Address], [Image] FROM Employees WHERE EmployeeId =1 ;
GO

DELETE FROM Employees WHERE EmployeeId ='';

GO

SELECT EmployeeId FROM Employees
GO


-----------------------------4.INSERT INTO Employees VALUES-------------------------------------
INSERT INTO Employees VALUES

 ( 1 , 'Md Shaon Kholifa', 1 , '01748772199', 'Male' , '1996-03-08' , '7802461660' , 'shoan365@gmail.com' , '2020-05-01' , 'Dhaka' , Null)
                
	 
GO

SELECT *FROM Employees
GO