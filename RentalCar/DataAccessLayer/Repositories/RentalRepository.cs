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

		public IEnumerable<Rentals> GetAllRentals(string search)
		{
			using (var connection = _dbConnection.GetConnection())
			{
				string query = @"SELECT r.RentalID, r.CustomerID, c.Name, r.CarID, ca.Make, ca.Model, r.RentalStartDate, r.RentalEndDate, r.TotalCost 
								 FROM Rentals r
								 INNER JOIN Customers c ON r.CustomerID = c.CustomerID
								 INNER JOIN Cars ca ON r.CarID = ca.CarID
								 WHERE c.Name LIKE @Search OR ca.Make LIKE @Search OR ca.Model LIKE @Search";


				var rentals = connection.Query<Rentals, Customers, Cars, Rentals>(query, (rental, customer, car) => {
					rental.Customer = customer;
					rental.Car = car;
					return rental;
				}, new { Search = "%" + search + "%" },
				splitOn: "CustomerID, CarID") ;

				return rentals;
			}
		}

		//public Rentals? GetById(int id)
		//{
		//	using (var connection = _dbConnection.GetConnection())
		//	{
		//		string query = @"SELECT r.RentalID, r.CustomerID, c.Name, r.CarID, ca.Make, ca.Model, r.RentalStartDate, r.RentalEndDate, r.TotalCost 
		//						 FROM Rentals r
		//						 INNER JOIN Customers c ON r.CustomerID = c.CustomerID
		//						 INNER JOIN Cars ca ON r.CarID = ca.CarID
		//						 WHERE RentalID = @RentalID";

		//		return connection.QueryFirstOrDefault<Rentals>(query, new { RentalID = id});
		//	}
		//}

		public void Add(Rentals rentals)
		{
			using (var connection = _dbConnection.GetConnection())
			{
				string query = "INSERT INTO Rentals VALUES(@CustomerID, @CarID, @RentalStartDate, @RentalEndDate, @TotalCost)";

				connection.Execute(query, new { rentals.CustomerID, rentals.CarID, rentals.RentalStartDate, rentals.RentalEndDate, rentals.TotalCost });
			}
		}

		//public void Edit(Rentals rentals)
		//{
		//	using (var connection = _dbConnection.GetConnection())
		//	{
		//		string query = @"UPDATE Rentals 
  //                              SET CustomerID = @CustomerID,
  //                                  CarID = @CarID,
		//							RentalStartDate = @RentalStartDate,
		//							RentalEndDate = @RentalEndDate,
		//							TotalCost = @TotalCost,
  //                                  WHERE RentalID = @RentalID";

		//		connection.Execute(query, rentals);
		//	}
		//}

		//public void Delete(int id)
		//{
		//	using (var connection = _dbConnection.GetConnection())
		//	{
		//		string query = "DELETE FROM Rentals WHERE RentalID = @RentalID";

		//		connection.Execute(query, new { id });
		//	}
		//}
	}
}
