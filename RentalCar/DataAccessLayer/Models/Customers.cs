using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
	public class Customers
	{
		public int CustomerID { get; set; }
		public string Name { get; set; }
		public string ContactInformation { get; set; }
		public string Address { get; set; }
	}
}
