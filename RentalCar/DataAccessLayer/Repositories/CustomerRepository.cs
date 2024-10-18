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
	public class CustomerRepository
	{
		private SqlDataAccess _dbConnection;

        public CustomerRepository()
        {
            _dbConnection = new SqlDataAccess();
        }

        public IEnumerable<Customers> GetAllCustomers()
		{
			using (var connection = _dbConnection.GetConnection())
			{
				string query = @"SELECT CustomerID, Name, ContactInformation, Address
								 FROM Customers";

				return connection.Query<Customers>(query);
			}
		}

		//public Customers? GetCustomersByID(int id)
		//{
		//	using (var connection = _dbConnection.GetConnection())
		//	{
		//		string query = @"SELECT CustomerID, Name, ContactInformation, Address
		//						 FROM Customers
		//						 WHERE CustomerID = @CustomerID";

		//		return connection.QueryFirstOrDefault<Customers>(query, new { CustomerID = id });
		//	}
		//}

		//public void Add(Customers customers)
		//{
		//	using (var connection = _dbConnection.GetConnection())
		//	{
		//		string query = "INSERT INTO Customers VALUES(@UniversityName, @Phone)";

		//		connection.Execute(query, new { customers.Name, customers.ContactInformation, customers.Address });
		//	}
		//}

		//public void Edit(Customers customers)
		//{
		//	using (var connection = _dbConnection.GetConnection())
		//	{
		//		string query = @"UPDATE Customers 
  //                              SET Name = @Name,
  //                                  ContactInformation = @ContactInformation,
		//							Address = @Address
  //                                  WHERE CustomerID = @CustomerID";

		//		connection.Execute(query, customers);
		//	}
		//}

		//public void Delete(int id)
		//{
		//	using (var connection = _dbConnection.GetConnection())
		//	{
		//		string query = "DELETE FROM Customers WHERE CustomerID = @CustomerID";

		//		connection.Execute(query, new { id });
		//	}
		//}
	}
}
