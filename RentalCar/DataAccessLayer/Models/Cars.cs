using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
	public class Cars
	{
		public int CarID { get; set; }
		public string Make {  get; set; }
		public string Model { get; set; }
		public int Year { get; set; }
		public decimal RentalRatePerDay { get; set; }
	}
}
