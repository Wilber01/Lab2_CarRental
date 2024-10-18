using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.DbConnection
{
	public class SqlDataAccess
	{
		private readonly string _connectionString;

		public SqlDataAccess()
		{
			_connectionString = "Cadena de Conexion";
		}

		public IDbConnection GetConnection()
		{
			return new SqlConnection(_connectionString);
		}
	}
}
