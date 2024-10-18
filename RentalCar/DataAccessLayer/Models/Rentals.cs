using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DataAccessLayer.Models
{
	public class Rentals
	{
		public int RentalID { get; set; }
		public int CustomerID { get; set; }
		public int CarID { get; set; }
		public Date RentalStartDate { get; set; }
		public Date RentalEndDate { get; set; }
		public decimal TotalCost { get; set; }

		public Customers Customer { get; set; }
		public Cars Car { get; set; }
	}
}
