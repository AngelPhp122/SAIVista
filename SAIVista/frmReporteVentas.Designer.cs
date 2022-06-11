namespace SAIVista
{
    partial class frmReporteVentas
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
            this.btnGenerarExcel = new System.Windows.Forms.Button();
            this.dtgReportesCompras = new System.Windows.Forms.DataGridView();
            this.btnReporteCompras = new System.Windows.Forms.Button();
            this.lbFechafinal = new System.Windows.Forms.Label();
            this.lbFechaInicio = new System.Windows.Forms.Label();
            this.tbxFechaFinal = new System.Windows.Forms.TextBox();
            this.tbxFechaInicial = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgReportesCompras)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerarExcel
            // 
            this.btnGenerarExcel.Location = new System.Drawing.Point(604, 499);
            this.btnGenerarExcel.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenerarExcel.Name = "btnGenerarExcel";
            this.btnGenerarExcel.Size = new System.Drawing.Size(217, 28);
            this.btnGenerarExcel.TabIndex = 13;
            this.btnGenerarExcel.Text = "Generar Excel";
            this.btnGenerarExcel.UseVisualStyleBackColor = true;
            this.btnGenerarExcel.Click += new System.EventHandler(this.btnGenerarExcel_Click);
            // 
            // dtgReportesCompras
            // 
            this.dtgReportesCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgReportesCompras.Location = new System.Drawing.Point(-5, 68);
            this.dtgReportesCompras.Margin = new System.Windows.Forms.Padding(4);
            this.dtgReportesCompras.Name = "dtgReportesCompras";
            this.dtgReportesCompras.RowHeadersWidth = 51;
            this.dtgReportesCompras.Size = new System.Drawing.Size(1465, 402);
            this.dtgReportesCompras.TabIndex = 12;
            // 
            // btnReporteCompras
            // 
            this.btnReporteCompras.Location = new System.Drawing.Point(593, -1);
            this.btnReporteCompras.Margin = new System.Windows.Forms.Padding(4);
            this.btnReporteCompras.Name = "btnReporteCompras";
            this.btnReporteCompras.Size = new System.Drawing.Size(100, 28);
            this.btnReporteCompras.TabIndex = 11;
            this.btnReporteCompras.Text = "Generar";
            this.btnReporteCompras.UseVisualStyleBackColor = true;
            this.btnReporteCompras.Click += new System.EventHandler(this.btnReporteVentas_Click);
            // 
            // lbFechafinal
            // 
            this.lbFechafinal.AutoSize = true;
            this.lbFechafinal.Location = new System.Drawing.Point(290, 11);
            this.lbFechafinal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFechafinal.Name = "lbFechafinal";
            this.lbFechafinal.Size = new System.Drawing.Size(90, 16);
            this.lbFechafinal.TabIndex = 10;
            this.lbFechafinal.Text = "hasta la fecha";
            // 
            // lbFechaInicio
            // 
            this.lbFechaInicio.AutoSize = true;
            this.lbFechaInicio.Location = new System.Drawing.Point(3, 7);
            this.lbFechaInicio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFechaInicio.Name = "lbFechaInicio";
            this.lbFechaInicio.Size = new System.Drawing.Size(96, 16);
            this.lbFechaInicio.TabIndex = 9;
            this.lbFechaInicio.Text = "desde la fecha";
            // 
            // tbxFechaFinal
            // 
            this.tbxFechaFinal.Location = new System.Drawing.Point(397, 4);
            this.tbxFechaFinal.Margin = new System.Windows.Forms.Padding(4);
            this.tbxFechaFinal.Name = "tbxFechaFinal";
            this.tbxFechaFinal.Size = new System.Drawing.Size(132, 22);
            this.tbxFechaFinal.TabIndex = 8;
            // 
            // tbxFechaInicial
            // 
            this.tbxFechaInicial.Location = new System.Drawing.Point(114, 4);
            this.tbxFechaInicial.Margin = new System.Windows.Forms.Padding(4);
            this.tbxFechaInicial.Name = "tbxFechaInicial";
            this.tbxFechaInicial.Size = new System.Drawing.Size(132, 22);
            this.tbxFechaInicial.TabIndex = 7;
            // 
            // frmReporteVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1455, 540);
            this.Controls.Add(this.btnGenerarExcel);
            this.Controls.Add(this.dtgReportesCompras);
            this.Controls.Add(this.btnReporteCompras);
            this.Controls.Add(this.lbFechafinal);
            this.Controls.Add(this.lbFechaInicio);
            this.Controls.Add(this.tbxFechaFinal);
            this.Controls.Add(this.tbxFechaInicial);
            this.Name = "frmReporteVentas";
            this.Text = "Reporte de Ventas";
            this.Load += new System.EventHandler(this.frmReporteVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgReportesCompras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerarExcel;
        private System.Windows.Forms.DataGridView dtgReportesCompras;
        private System.Windows.Forms.Button btnReporteCompras;
        private System.Windows.Forms.Label lbFechafinal;
        private System.Windows.Forms.Label lbFechaInicio;
        private System.Windows.Forms.TextBox tbxFechaFinal;
        private System.Windows.Forms.TextBox tbxFechaInicial;
    }
}