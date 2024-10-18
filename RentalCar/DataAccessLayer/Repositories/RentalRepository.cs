using Dapper;
using DataAccessLayer.DbConnection;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
	public class RentalRepository
	{
		private SqlDataAccess _dbConnection;

        public RentalRepository()
        {
            _dbConnection = new SqlDataAccess();
        }

		public IEnumerable<Rentals> GetAllRentals(string search, DateTime dateSearchInitial, DateTime dateSearchFinal)
		{
			using (var connection = _dbConnection.GetConnection())
			{
				DateTime date = DateTime.Now;
				if (dateSearchFinal.ToString("yyyy-MM-dd") != date.ToString("yyyy-MM-dd"))
				{
					string query = @"SELECT r.RentalID, r.RentalStartDate, r.RentalEndDate, r.TotalCost, c.Name, ca.Make, ca.Model, c.CustomerID, ca.CarID
								 FROM Rentals r
								 INNER JOIN Customers c ON r.CustomerID = c.CustomerID
								 INNER JOIN Cars ca ON r.CarID = ca.CarID
								 WHERE (c.Name LIKE @Search 
								 OR ca.Make LIKE @Search 
								 OR ca.Model LIKE @Search)
								 AND (r.RentalStartDate >= @DateSearchInitial) 
								 AND (r.RentalStartDate <= @DateSearchFinal)";

					var rentals = connection.Query<Rentals, Customers, Cars, Rentals>(query, (rental, customer, car) => {
						rental.Customer = customer;
						rental.Car = car;
						return rental;
					}, new { Search = "%" + search + "%", DateSearchInitial = dateSearchInitial, DateSearchFinal = dateSearchFinal },
					splitOn: "CustomerID, CarID");

					return rentals;
				}
				else
				{
					string query = @"SELECT r.RentalID, r.RentalStartDate, r.RentalEndDate, r.TotalCost, c.Name, ca.Make, ca.Model, r.CustomerID, r.CarID 
								 FROM Rentals r
								 INNER JOIN Customers c ON r.CustomerID = c.CustomerID
								 INNER JOIN Cars ca ON r.CarID = ca.CarID
								 WHERE (c.Name LIKE @Search 
								 OR ca.Make LIKE @Search 
								 OR ca.Model LIKE @Search)";

					var rentals = connection.Query<Rentals, Customers, Cars, Rentals>(query, (rental, customer, car) => {
						rental.Customer = customer;
						rental.Car = car;
						return rental;
					}, new { Search = "%" + search + "%" },
					splitOn: "CustomerID, CarID");

					return rentals;
				}
			}
		}

		public void Add(Rentals rentals)
		{
			using (var connection = _dbConnection.GetConnection())
			{
				string query = "INSERT INTO Rentals VALUES(@RentalStartDate, @RentalEndDate, @TotalCost, @CustomerID, @CarID)";

				connection.Execute(query, new { rentals.RentalStartDate, rentals.RentalEndDate, rentals.TotalCost, rentals.CustomerID, rentals.CarID });
			}
		}
	}
}
