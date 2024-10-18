using ClosedXML.Excel;
using DataAccessLayer.Models;
using DataAccessLayer.Repositories;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.Forms
{
	public partial class GenerateReports : Form
	{
		private readonly RentalRepository _rentalRepository;

		public GenerateReports()
		{
			InitializeComponent();
			QuestPDF.Settings.License = QuestPDF.Infrastructure.LicenseType.Community;
			_rentalRepository = new RentalRepository();
			CargarDatos();
			txtSearch.Focus();
		}

		public void CargarDatos()
		{
			dgvRentas.DataSource = _rentalRepository.GetAllRentals(txtSearch.Text, dtpFechaInicialReporte.Value, dtpFechaFinalReporte.Value);
			dgvRentas.Columns["Customer"].Visible = false;
			dgvRentas.Columns["Car"].Visible = false;
			dgvRentas.Columns["CustomerID"].Visible = false;
			dgvRentas.Columns["CarID"].Visible = false;
		}

		private void txtSearch_KeyUp(object sender, KeyEventArgs e)
		{
			CargarDatos();
		}

		private void btnFiltrar_Click(object sender, EventArgs e)
		{
			CargarDatos();
		}

		private void btnLimpiar_Click(object sender, EventArgs e)
		{
			txtSearch.Clear();
			dtpFechaInicialReporte.Value = DateTime.Now;
			dtpFechaFinalReporte.Value = DateTime.Now;
			txtSearch.Focus();
			CargarDatos();
		}

		private void btnPDF_Click(object sender, EventArgs e)
		{
			var rentals = new List<Rentals>();

			foreach (DataGridViewRow row in dgvRentas.Rows)
			{
				if (row.IsNewRow) continue;

				var rental = new Rentals
				{
					RentalID = Convert.ToInt32(row.Cells["RentalID"].Value),
					RentalStartDate = Convert.ToDateTime(row.Cells["RentalStartDate"].Value),
					RentalEndDate = Convert.ToDateTime(row.Cells["RentalEndDate"].Value),
					TotalCost = Convert.ToDecimal(row.Cells["TotalCost"].Value),
					Name = row.Cells["Name"].Value.ToString(),
					Make = row.Cells["Make"].Value.ToString(),
					Model = row.Cells["Model"].Value.ToString()
				};

				rentals.Add(rental);
			}

			Document.Create(container =>
			{
				container.Page(page =>
				{
					page.Margin(1, Unit.Centimetre);

					page.Header().Height(35).Background(Colors.Green.Accent4).Text("Reporte de Rentas de Autos")
					.Bold().AlignCenter().FontSize(20).FontColor(Colors.White);

					page.Content()
						.Column(column =>
						{
						
							column.Item().PaddingLeft(1, Unit.Centimetre).PaddingTop(1, Unit.Centimetre).Table(table =>
							{
								table.ColumnsDefinition(columns =>
								{
									columns.RelativeColumn();
									columns.RelativeColumn();
									columns.RelativeColumn();
									columns.RelativeColumn();
									columns.RelativeColumn();
									columns.RelativeColumn();
									columns.RelativeColumn();
								});

								foreach (var rental in rentals)
								{
									table.Cell().Text(rental.RentalID);
									table.Cell().Text(rental.Name);
									table.Cell().Text(rental.Make);
									table.Cell().Text(rental.Model);
									table.Cell().Text(rental.RentalStartDate.ToShortDateString());
									table.Cell().Text(rental.RentalEndDate.ToShortDateString());
									table.Cell().Text(rental.TotalCost.ToString("C", CultureInfo.CurrentCulture));
								}
							});
						});
				});
			}).GeneratePdfAndShow();
			MessageBox.Show("Reporte PDF generado exitosamente!");
		}

		private void btnExcel_Click(object sender, EventArgs e)
		{
			var rentals = new List<Rentals>();

			foreach (DataGridViewRow row in dgvRentas.Rows)
			{
				if (row.IsNewRow) continue;

				var rental = new Rentals
				{
					RentalID = Convert.ToInt32(row.Cells["RentalID"].Value),
					RentalStartDate = Convert.ToDateTime(row.Cells["RentalStartDate"].Value),
					RentalEndDate = Convert.ToDateTime(row.Cells["RentalEndDate"].Value),
					TotalCost = Convert.ToDecimal(row.Cells["TotalCost"].Value),
					Name = row.Cells["Name"].Value.ToString(),
					Make = row.Cells["Make"].Value.ToString(),
					Model = row.Cells["Model"].Value.ToString()
				};

				rentals.Add(rental);
			}

			using (var workbook = new XLWorkbook())
			{
				
				var worksheet = workbook.Worksheets.Add("Reporte de Rentas de Autos");

				
				worksheet.Cell(1, 1).Value = "ID";
				worksheet.Cell(1, 2).Value = "Nombre del Cliente";
				worksheet.Cell(1, 3).Value = "Marca del Auto";
				worksheet.Cell(1, 4).Value = "Modelo del Auto";
				worksheet.Cell(1, 5).Value = "Fecha de Inicio";
				worksheet.Cell(1, 6).Value = "Fecha de Fin";
				worksheet.Cell(1, 7).Value = "Costo Total";

				
				int row = 2;
				foreach (var rental in rentals)
				{
					worksheet.Cell(row, 1).Value = rental.RentalID;
					worksheet.Cell(row, 2).Value = rental.Name;
					worksheet.Cell(row, 3).Value = rental.Make;
					worksheet.Cell(row, 4).Value = rental.Model;
					worksheet.Cell(row, 5).Value = rental.RentalStartDate.ToShortDateString();
					worksheet.Cell(row, 6).Value = rental.RentalEndDate.ToShortDateString();
					worksheet.Cell(row, 7).Value = rental.TotalCost;
					row++;
				}

				
				worksheet.RangeUsed().Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
				worksheet.RangeUsed().Style.Border.InsideBorder = XLBorderStyleValues.Thin;

				
				worksheet.Columns().AdjustToContents();

				
				string filePath = @"DigitarDireccionParaGuardarElExcel";
				workbook.SaveAs(filePath);
			}

			MessageBox.Show("Reporte Excel generado exitosamente!");
		}
	}
}
