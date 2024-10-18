CREATE DATABASE RentalCarDB;
go

USE RentalCarDB;
go

CREATE TABLE Customers (
    CustomerID INT PRIMARY KEY IDENTITY(1,1),
    Name VARCHAR(255) NOT NULL,
    ContactInformation VARCHAR(255),
    Address VARCHAR(255)
);

CREATE TABLE Cars (
    CarID INT PRIMARY KEY IDENTITY(1,1),
    Make VARCHAR(255) NOT NULL,
    Model VARCHAR(255) NOT NULL,
    Year INT NOT NULL,
    RentalRatePerDay DECIMAL(10, 2) NOT NULL
);

CREATE TABLE Rentals (
    RentalID INT PRIMARY KEY IDENTITY(1,1),
    CustomerID INT FOREIGN KEY REFERENCES Customers(CustomerID),
    CarID INT FOREIGN KEY REFERENCES Cars(CarID),
    RentalStartDate DATE NOT NULL,
    RentalEndDate DATE NOT NULL,
    TotalCost DECIMAL(10, 2)
);
go

/*Añadiendo Registros*/

INSERT INTO Customers (Name, ContactInformation, Address)
VALUES
('John Doe', '555-1234', '123 Elm Street'),
('Jane Smith', '555-5678', '456 Oak Avenue'),
('Robert Brown', '555-8765', '789 Maple Lane'),
('Emily Davis', '555-2345', '321 Pine Road'),
('Michael Wilson', '555-3456', '654 Cedar Boulevard'),
('Sarah Johnson', '555-4567', '987 Birch Avenue'),
('David Lee', '555-5678', '159 Spruce Street'),
('Karen Garcia', '555-6789', '753 Walnut Avenue'),
('Paul Martinez', '555-7890', '951 Chestnut Road'),
('Lisa White', '555-8901', '258 Ash Street'),
('James Moore', '555-9012', '147 Elm Street'),
('Anna Taylor', '555-0123', '369 Pine Avenue'),
('Mark Anderson', '555-2345', '753 Oak Lane'),
('Sophia Thomas', '555-3456', '951 Maple Boulevard'),
('William Jackson', '555-4567', '159 Birch Road'),
('Olivia Harris', '555-5678', '753 Cedar Avenue'),
('Henry Clark', '555-6789', '951 Spruce Boulevard'),
('Isabella Rodriguez', '555-7890', '258 Walnut Street'),
('Lucas Lewis', '555-8901', '147 Ash Avenue'),
('Mia King', '555-9012', '369 Chestnut Street');
GO

INSERT INTO Cars (Make, Model, Year, RentalRatePerDay)
VALUES
('Toyota', 'Corolla', 2020, 35.00),
('Honda', 'Civic', 2021, 40.00),
('Ford', 'Fusion', 2019, 45.00),
('Chevrolet', 'Malibu', 2020, 50.00),
('Nissan', 'Altima', 2021, 55.00),
('Hyundai', 'Elantra', 2019, 38.00),
('BMW', '3 Series', 2021, 120.00),
('Mercedes-Benz', 'C-Class', 2020, 130.00),
('Audi', 'A4', 2019, 110.00),
('Tesla', 'Model 3', 2021, 150.00),
('Toyota', 'Camry', 2018, 48.00),
('Ford', 'Mustang', 2021, 75.00),
('Chevrolet', 'Tahoe', 2019, 80.00),
('Jeep', 'Wrangler', 2020, 85.00),
('Kia', 'Optima', 2021, 42.00),
('Subaru', 'Impreza', 2019, 39.00),
('Volkswagen', 'Passat', 2020, 44.00),
('Mazda', '6', 2021, 47.00),
('Dodge', 'Charger', 2021, 65.00),
('Honda', 'Accord', 2020, 50.00);
GO

INSERT INTO Rentals (CustomerID, CarID, RentalStartDate, RentalEndDate, TotalCost)
VALUES
(1, 3, '2024-10-01', '2024-10-07', 315.00),
(2, 5, '2024-09-15', '2024-09-20', 275.00),
(3, 2, '2024-09-05', '2024-09-12', 320.00),
(4, 1, '2024-10-10', '2024-10-13', 105.00),
(5, 8, '2024-09-01', '2024-09-05', 520.00),
(6, 10, '2024-09-25', '2024-09-30', 900.00),
(7, 9, '2024-10-05', '2024-10-10', 550.00),
(8, 6, '2024-08-15', '2024-08-20', 190.00),
(9, 4, '2024-09-20', '2024-09-25', 250.00),
(10, 7, '2024-10-03', '2024-10-10', 840.00),
(11, 12, '2024-09-28', '2024-10-03', 450.00),
(12, 11, '2024-08-05', '2024-08-10', 240.00),
(13, 13, '2024-09-10', '2024-09-15', 400.00),
(14, 14, '2024-07-20', '2024-07-25', 425.00),
(15, 15, '2024-08-10', '2024-08-14', 168.00),
(16, 16, '2024-09-01', '2024-09-06', 195.00),
(17, 17, '2024-10-01', '2024-10-07', 308.00),
(18, 18, '2024-08-18', '2024-08-24', 282.00),
(19, 19, '2024-09-15', '2024-09-20', 325.00),
(20, 20, '2024-09-01', '2024-09-05', 200.00);
GO

/*prueba*/
SELECT r.RentalID, r.CustomerID, c.Name, r.CarID, ca.Make, ca.Model, r.RentalStartDate, r.RentalEndDate, r.TotalCost 
FROM Rentals r
INNER JOIN Customers c ON r.CustomerID = c.CustomerID
INNER JOIN Cars ca ON r.CarID = ca.CarID