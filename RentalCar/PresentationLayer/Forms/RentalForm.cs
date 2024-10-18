using DataAccessLayer.Models;
using DataAccessLayer.Repositories;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.Forms
{
	public partial class RentalForm : Form
	{
		private RentalRepository _rentalRepository;
		private CustomerRepository _customerRepository;
		private CarRepository _carRepository;

		public RentalForm()
		{
			InitializeComponent();
			_rentalRepository = new RentalRepository();
			_customerRepository = new CustomerRepository();
			_carRepository = new CarRepository();

			CargarDatosIniciales();
		}

		public void CargarDatosIniciales()
		{

			cbxAuto.DataSource = _carRepository.GetAllCars();
			cbxAuto.DisplayMember = "Make";
			cbxAuto.ValueMember = "CarID";

			cbxCliente.DataSource = _customerRepository.GetAllCustomers();
			cbxCliente.DisplayMember = "Name";
			cbxCliente.ValueMember = "CustomerID";
		}

		public void Limpiar()
		{
			cbxAuto.SelectedIndex = 0;
			cbxCliente.SelectedIndex = 0;
			dtpRentaInicial.Value = DateTime.Now;
			dtpRentaFinal.Value = DateTime.Now;
		}

		private void btnGuardarRegistro_Click(object sender, EventArgs e)
		{
			try
			{
				Rentals rentals = new Rentals();
				rentals.CustomerID = Convert.ToInt32(cbxCliente.SelectedValue);
				rentals.CarID = Convert.ToInt32(cbxAuto.SelectedValue);
				rentals.RentalStartDate = dtpRentaInicial.Value;
				rentals.RentalEndDate = dtpRentaFinal.Value;
				rentals.TotalCost = decimal.Parse(txtTotalCosto.Text.Replace("$", "").Trim());


				_rentalRepository.Add(rentals);

				MessageBox.Show("Registro Guardado con Exito");
			}
			catch (SqlException ex)
			{
				MessageBox.Show("Surgio un error: " + ex);
			}
		}

		private void dtpRentaFinal_ValueChanged(object sender, EventArgs e)
		{
			if (cbxAuto.SelectedValue != null && dtpRentaFinal.Value > dtpRentaInicial.Value)
			{
				var selectedCar = (Cars)cbxAuto.SelectedItem;
				var daysRented = (dtpRentaFinal.Value - dtpRentaInicial.Value).Days;
				var totalCost = daysRented * selectedCar.RentalRatePerDay;
				txtTotalCosto.Text = totalCost.ToString("C");
			}
		}

		private void btnMostrarGenerarReporte_Click(object sender, EventArgs e)
		{
			GenerateReports generateReports = new GenerateReports();
			generateReports.ShowDialog();
		}
	}
}
