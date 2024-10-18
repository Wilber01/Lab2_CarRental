namespace PresentationLayer.Forms
{
	partial class RentalForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			label1 = new Label();
			label2 = new Label();
			cbxCliente = new ComboBox();
			label3 = new Label();
			cbxAuto = new ComboBox();
			label4 = new Label();
			dtpRentaInicial = new DateTimePicker();
			label5 = new Label();
			dtpRentaFinal = new DateTimePicker();
			btnGuardarRegistro = new Button();
			btnMostrarGenerarReporte = new Button();
			txtTotalCosto = new TextBox();
			label6 = new Label();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(171, 9);
			label1.Name = "label1";
			label1.Size = new Size(117, 15);
			label1.TabIndex = 0;
			label1.Text = "Crear Nuevo Alquiler";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(203, 44);
			label2.Name = "label2";
			label2.Size = new Size(44, 15);
			label2.TabIndex = 1;
			label2.Text = "Cliente";
			// 
			// cbxCliente
			// 
			cbxCliente.FormattingEnabled = true;
			cbxCliente.Location = new Point(119, 62);
			cbxCliente.Name = "cbxCliente";
			cbxCliente.Size = new Size(208, 23);
			cbxCliente.TabIndex = 2;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(209, 105);
			label3.Name = "label3";
			label3.Size = new Size(36, 15);
			label3.TabIndex = 3;
			label3.Text = "Auto:";
			// 
			// cbxAuto
			// 
			cbxAuto.FormattingEnabled = true;
			cbxAuto.Location = new Point(119, 123);
			cbxAuto.Name = "cbxAuto";
			cbxAuto.Size = new Size(208, 23);
			cbxAuto.TabIndex = 4;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(184, 163);
			label4.Name = "label4";
			label4.Size = new Size(87, 15);
			label4.TabIndex = 5;
			label4.Text = "Fecha de Renta";
			// 
			// dtpRentaInicial
			// 
			dtpRentaInicial.Location = new Point(119, 181);
			dtpRentaInicial.Name = "dtpRentaInicial";
			dtpRentaInicial.Size = new Size(208, 23);
			dtpRentaInicial.TabIndex = 6;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(161, 229);
			label5.Name = "label5";
			label5.Size = new Size(127, 15);
			label5.TabIndex = 7;
			label5.Text = "Fecha Final de la Renta";
			// 
			// dtpRentaFinal
			// 
			dtpRentaFinal.Location = new Point(119, 247);
			dtpRentaFinal.Name = "dtpRentaFinal";
			dtpRentaFinal.Size = new Size(208, 23);
			dtpRentaFinal.TabIndex = 8;
			dtpRentaFinal.ValueChanged += dtpRentaFinal_ValueChanged;
			// 
			// btnGuardarRegistro
			// 
			btnGuardarRegistro.Location = new Point(137, 370);
			btnGuardarRegistro.Name = "btnGuardarRegistro";
			btnGuardarRegistro.Size = new Size(169, 23);
			btnGuardarRegistro.TabIndex = 9;
			btnGuardarRegistro.Text = "Guardar Registro de Renta";
			btnGuardarRegistro.UseVisualStyleBackColor = true;
			btnGuardarRegistro.Click += btnGuardarRegistro_Click;
			// 
			// btnMostrarGenerarReporte
			// 
			btnMostrarGenerarReporte.Location = new Point(58, 418);
			btnMostrarGenerarReporte.Name = "btnMostrarGenerarReporte";
			btnMostrarGenerarReporte.Size = new Size(327, 23);
			btnMostrarGenerarReporte.TabIndex = 10;
			btnMostrarGenerarReporte.Text = "Generar Reporte de Rentas";
			btnMostrarGenerarReporte.UseVisualStyleBackColor = true;
			btnMostrarGenerarReporte.Click += btnMostrarGenerarReporte_Click;
			// 
			// txtTotalCosto
			// 
			txtTotalCosto.Location = new Point(119, 313);
			txtTotalCosto.Name = "txtTotalCosto";
			txtTotalCosto.ReadOnly = true;
			txtTotalCosto.Size = new Size(208, 23);
			txtTotalCosto.TabIndex = 11;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(184, 295);
			label6.Name = "label6";
			label6.Size = new Size(85, 15);
			label6.TabIndex = 12;
			label6.Text = "Total del Costo";
			// 
			// RentalForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(463, 465);
			Controls.Add(label6);
			Controls.Add(txtTotalCosto);
			Controls.Add(btnMostrarGenerarReporte);
			Controls.Add(btnGuardarRegistro);
			Controls.Add(dtpRentaFinal);
			Controls.Add(label5);
			Controls.Add(dtpRentaInicial);
			Controls.Add(label4);
			Controls.Add(cbxAuto);
			Controls.Add(label3);
			Controls.Add(cbxCliente);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "RentalForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "RentalForm";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private ComboBox cbxCliente;
		private Label label3;
		private ComboBox cbxAuto;
		private Label label4;
		private DateTimePicker dtpRentaInicial;
		private Label label5;
		private DateTimePicker dtpRentaFinal;
		private Button btnGuardarRegistro;
		private Button btnMostrarGenerarReporte;
		private TextBox txtTotalCosto;
		private Label label6;
	}
}