CREATE DATABASE CarRental;
go

USE CarRental;
go

CREATE TABLE Customers (
    CustomerID INT PRIMARY KEY IDENTITY(1,1),
    Name VARCHAR(255) NOT NULL,
    ContactInformation VARCHAR(255),
    Address VARCHAR(255)
);
GO

CREATE TABLE Cars (
    CarID INT PRIMARY KEY IDENTITY(1,1),
    Make VARCHAR(255) NOT NULL,
    Model VARCHAR(255) NOT NULL,
    Year INT NOT NULL,
    RentalRatePerDay DECIMAL(10, 2) NOT NULL
);
Go

CREATE TABLE Rentals (
    RentalID INT PRIMARY KEY IDENTITY(1,1),
    RentalStartDate DATE NOT NULL,
    RentalEndDate DATE NOT NULL,
    TotalCost DECIMAL(10, 2),
	CustomerID INT FOREIGN KEY REFERENCES Customers(CustomerID),
    CarID INT FOREIGN KEY REFERENCES Cars(CarID),
);
go

INSERT INTO Customers (Name, ContactInformation, Address) VALUES
('John Doe', 'john.doe@example.com', '123 Main St, Springfield'),
('Jane Smith', 'jane.smith@example.com', '456 Elm St, Springfield'),
('Alice Johnson', 'alice.j@example.com', '789 Oak St, Springfield'),
('Bob Brown', 'bob.brown@example.com', '135 Pine St, Springfield'),
('Charlie Green', 'charlie.green@example.com', '246 Maple St, Springfield'),
('Daniel White', 'daniel.white@example.com', '357 Birch St, Springfield'),
('Eva Black', 'eva.black@example.com', '468 Cedar St, Springfield'),
('Frank Blue', 'frank.blue@example.com', '579 Walnut St, Springfield'),
('Grace Pink', 'grace.pink@example.com', '680 Chestnut St, Springfield'),
('Hank Gray', 'hank.gray@example.com', '791 Ash St, Springfield'),
('Ivy Red', 'ivy.red@example.com', '902 Spruce St, Springfield'),
('Jack Silver', 'jack.silver@example.com', '213 Fir St, Springfield'),
('Kathy Gold', 'kathy.gold@example.com', '324 Hemlock St, Springfield'),
('Liam Yellow', 'liam.yellow@example.com', '435 Poplar St, Springfield'),
('Mia Purple', 'mia.purple@example.com', '546 Redwood St, Springfield'),
('Noah Orange', 'noah.orange@example.com', '657 Willow St, Springfield'),
('Olivia Teal', 'olivia.teal@example.com', '768 Sycamore St, Springfield'),
('Paul Aqua', 'paul.aqua@example.com', '879 Dogwood St, Springfield'),
('Quinn Brown', 'quinn.brown@example.com', '980 Birchwood St, Springfield'),
('Rita Indigo', 'rita.indigo@example.com', '1099 Blackberry St, Springfield');
GO

INSERT INTO Cars (Make, Model, Year, RentalRatePerDay) VALUES
('Toyota', 'Camry', 2020, 45.00),
('Honda', 'Accord', 2021, 50.00),
('Ford', 'Mustang', 2019, 60.00),
('Chevrolet', 'Impala', 2018, 55.00),
('Nissan', 'Altima', 2020, 48.00),
('Hyundai', 'Sonata', 2021, 49.00),
('Kia', 'Optima', 2019, 47.00),
('Volkswagen', 'Passat', 2020, 53.00),
('Subaru', 'Legacy', 2021, 54.00),
('Mazda', '6', 2020, 52.00),
('Dodge', 'Charger', 2019, 62.00),
('Chrysler', '300', 2018, 58.00),
('BMW', '3 Series', 2021, 70.00),
('Audi', 'A4', 2020, 72.00),
('Mercedes-Benz', 'C-Class', 2021, 75.00),
('Lexus', 'ES', 2020, 68.00),
('Porsche', 'Macan', 2021, 90.00),
('Land Rover', 'Range Rover', 2019, 85.00),
('Jaguar', 'XF', 2020, 80.00),
('Volvo', 'S60', 2021, 65.00);
GO

INSERT INTO Rentals (RentalStartDate, RentalEndDate, TotalCost, CustomerID, CarID) VALUES
('2024-10-01', '2024-10-05', 225.00, 1, 1),
('2024-10-02', '2024-10-06', 300.00, 2, 2),
('2024-10-03', '2024-10-07', 240.00, 3, 3),
('2024-10-04', '2024-10-08', 220.00, 4, 4),
('2024-10-05', '2024-10-09', 300.00, 5, 5),
('2024-10-06', '2024-10-10', 290.00, 6, 6),
('2024-10-07', '2024-10-11', 270.00, 7, 7),
('2024-10-08', '2024-10-12', 260.00, 8, 8),
('2024-10-09', '2024-10-13', 230.00, 9, 9),
('2024-10-10', '2024-10-14', 300.00, 10, 10),
('2024-10-11', '2024-10-15', 250.00, 11, 11),
('2024-10-12', '2024-10-16', 240.00, 12, 12),
('2024-10-13', '2024-10-17', 310.00, 13, 13),
('2024-10-14', '2024-10-18', 275.00, 14, 14),
('2024-10-15', '2024-10-19', 225.00, 15, 15),
('2024-10-16', '2024-10-20', 280.00, 16, 16),
('2024-10-17', '2024-10-21', 290.00, 17, 17),
('2024-10-18', '2024-10-22', 300.00, 18, 18),
('2024-10-19', '2024-10-23', 310.00, 19, 19),
('2024-10-20', '2024-10-24', 225.00, 20, 20),
('2024-10-21', '2024-10-25', 240.00, 1, 2);
GO


SELECT * FROM Rentals

/*prueba*/
SELECT r.RentalID, r.CustomerID, c.Name, r.CarID, ca.Make, ca.Model, r.RentalStartDate, r.RentalEndDate, r.TotalCost 
FROM Rentals r
INNER JOIN Customers c ON r.CustomerID = c.CustomerID
INNER JOIN Cars ca ON r.CarID = ca.CarID