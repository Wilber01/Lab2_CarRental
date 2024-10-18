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

		public DateTime RentalStartDate { get; set; }
		public DateTime RentalEndDate { get; set; }
		public decimal TotalCost { get; set; }

		public string? Name { get; set; } // Para el nombre del cliente
		public string? Make { get; set; }      // Para la marca del auto
		public string? Model { get; set; }     // Para el modelo del auto

		public int CustomerID { get; set; }
		public int CarID { get; set; }

		public Customers Customer { get; set; }
		public Cars Car { get; set; }
	}
}
