namespace PresentationLayer.Forms
{
	partial class GenerateReports
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
			dgvRentas = new DataGridView();
			label1 = new Label();
			txtSearch = new TextBox();
			dtpFechaInicialReporte = new DateTimePicker();
			dtpFechaFinalReporte = new DateTimePicker();
			label2 = new Label();
			label3 = new Label();
			btnFiltrar = new Button();
			btnLimpiar = new Button();
			btnPDF = new Button();
			btnExcel = new Button();
			((System.ComponentModel.ISupportInitialize)dgvRentas).BeginInit();
			SuspendLayout();
			// 
			// dgvRentas
			// 
			dgvRentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvRentas.EditMode = DataGridViewEditMode.EditProgrammatically;
			dgvRentas.Location = new Point(106, 53);
			dgvRentas.Name = "dgvRentas";
			dgvRentas.ReadOnly = true;
			dgvRentas.Size = new Size(411, 213);
			dgvRentas.TabIndex = 0;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(106, 25);
			label1.Name = "label1";
			label1.Size = new Size(45, 15);
			label1.TabIndex = 1;
			label1.Text = "Buscar:";
			// 
			// txtSearch
			// 
			txtSearch.Location = new Point(157, 22);
			txtSearch.Name = "txtSearch";
			txtSearch.Size = new Size(360, 23);
			txtSearch.TabIndex = 2;
			txtSearch.KeyUp += txtSearch_KeyUp;
			// 
			// dtpFechaInicialReporte
			// 
			dtpFechaInicialReporte.Location = new Point(12, 305);
			dtpFechaInicialReporte.Name = "dtpFechaInicialReporte";
			dtpFechaInicialReporte.Size = new Size(200, 23);
			dtpFechaInicialReporte.TabIndex = 3;
			// 
			// dtpFechaFinalReporte
			// 
			dtpFechaFinalReporte.Location = new Point(378, 305);
			dtpFechaFinalReporte.Name = "dtpFechaFinalReporte";
			dtpFechaFinalReporte.Size = new Size(200, 23);
			dtpFechaFinalReporte.TabIndex = 4;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(36, 287);
			label2.Name = "label2";
			label2.Size = new Size(149, 15);
			label2.TabIndex = 5;
			label2.Text = "Fecha de Inicio del Reporte";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(416, 287);
			label3.Name = "label3";
			label3.Size = new Size(129, 15);
			label3.TabIndex = 6;
			label3.Text = "Fecha Final del Reporte";
			// 
			// btnFiltrar
			// 
			btnFiltrar.Location = new Point(210, 348);
			btnFiltrar.Name = "btnFiltrar";
			btnFiltrar.Size = new Size(75, 23);
			btnFiltrar.TabIndex = 7;
			btnFiltrar.Text = "Filtrar";
			btnFiltrar.UseVisualStyleBackColor = true;
			btnFiltrar.Click += btnFiltrar_Click;
			// 
			// btnLimpiar
			// 
			btnLimpiar.Location = new Point(304, 348);
			btnLimpiar.Name = "btnLimpiar";
			btnLimpiar.Size = new Size(75, 23);
			btnLimpiar.TabIndex = 8;
			btnLimpiar.Text = "Limpiar";
			btnLimpiar.UseVisualStyleBackColor = true;
			btnLimpiar.Click += btnLimpiar_Click;
			// 
			// btnPDF
			// 
			btnPDF.Location = new Point(64, 396);
			btnPDF.Name = "btnPDF";
			btnPDF.Size = new Size(200, 23);
			btnPDF.TabIndex = 9;
			btnPDF.Text = "Generar Reporte en PDF";
			btnPDF.UseVisualStyleBackColor = true;
			btnPDF.Click += btnPDF_Click;
			// 
			// btnExcel
			// 
			btnExcel.Location = new Point(345, 396);
			btnExcel.Name = "btnExcel";
			btnExcel.Size = new Size(200, 23);
			btnExcel.TabIndex = 10;
			btnExcel.Text = "Generar Reporte en Excel";
			btnExcel.UseVisualStyleBackColor = true;
			btnExcel.Click += btnExcel_Click;
			// 
			// GenerateReports
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(622, 436);
			Controls.Add(btnExcel);
			Controls.Add(btnPDF);
			Controls.Add(btnLimpiar);
			Controls.Add(btnFiltrar);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(dtpFechaFinalReporte);
			Controls.Add(dtpFechaInicialReporte);
			Controls.Add(txtSearch);
			Controls.Add(label1);
			Controls.Add(dgvRentas);
			Name = "GenerateReports";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "GenerateReports";
			((System.ComponentModel.ISupportInitialize)dgvRentas).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView dgvRentas;
		private Label label1;
		private TextBox txtSearch;
		private DateTimePicker dtpFechaInicialReporte;
		private DateTimePicker dtpFechaFinalReporte;
		private Label label2;
		private Label label3;
		private Button btnFiltrar;
		private Button btnLimpiar;
		private Button btnPDF;
		private Button btnExcel;
	}
}