using Dapper;
using DataAccessLayer.DbConnection;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
	public class CarRepository
	{
		private SqlDataAccess _dbConnection;

        public CarRepository()
        {
            _dbConnection = new SqlDataAccess();
        }

		public IEnumerable<Cars> GetAllCars()
		{
			using (var connection = _dbConnection.GetConnection())
			{
				string query = @"SELECT CarID, Make, Model, Year, RentalRatePerDay
								 FROM Cars";

				return connection.Query<Cars>(query);
			}
		}

		//public Cars? GetCarsByID(int id)
		//{
		//	using (var connection = _dbConnection.GetConnection())
		//	{
		//		string query = @"SELECT CarID, Make, Model, Year, RentalRatePerDay
		//						 FROM Cars
		//						 WHERE CarID = @CarID";

		//		return connection.QueryFirstOrDefault<Cars>(query, new { CarID = id });
		//	}
		//}

		//public void Add(Cars cars)
		//{
		//	using (var connection = _dbConnection.GetConnection())
		//	{
		//		string query = "INSERT INTO Cars VALUES(@Make, @Model, @Year, @RentalRatePerDay)";

		//		connection.Execute(query, new { cars.Make, cars.Model, cars.Year, cars.RentalRatePerDay });
		//	}
		//}

		//public void Edit(Cars cars)
		//{
		//	using (var connection = _dbConnection.GetConnection())
		//	{
		//		string query = @"UPDATE Cars 
  //                              SET Make = @Make,
  //                                  Model = @Model,
		//							Year = @Year,
		//							RentalRatePerDay = @RentalRatePerDay
  //                                  WHERE CarID = @CarID";

		//		connection.Execute(query, cars);
		//	}
		//}

		//public void Delete(int id)
		//{
		//	using (var connection = _dbConnection.GetConnection())
		//	{
		//		string query = "DELETE FROM Cars WHERE CarID = @CarID";

		//		connection.Execute(query, new { id });
		//	}
		//}
	}
}
