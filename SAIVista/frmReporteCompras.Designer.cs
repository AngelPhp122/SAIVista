namespace SAIVista
{
    partial class frmReporteCompras
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
            this.tbxFechaInicial = new System.Windows.Forms.TextBox();
            this.tbxFechaFinal = new System.Windows.Forms.TextBox();
            this.lbFechaInicio = new System.Windows.Forms.Label();
            this.lbFechafinal = new System.Windows.Forms.Label();
            this.btnReporteCompras = new System.Windows.Forms.Button();
            this.dtgReportesCompras = new System.Windows.Forms.DataGridView();
            this.btnGenerarExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgReportesCompras)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxFechaInicial
            // 
            this.tbxFechaInicial.Location = new System.Drawing.Point(102, 59);
            this.tbxFechaInicial.Name = "tbxFechaInicial";
            this.tbxFechaInicial.Size = new System.Drawing.Size(100, 20);
            this.tbxFechaInicial.TabIndex = 0;
            // 
            // tbxFechaFinal
            // 
            this.tbxFechaFinal.Location = new System.Drawing.Point(314, 59);
            this.tbxFechaFinal.Name = "tbxFechaFinal";
            this.tbxFechaFinal.Size = new System.Drawing.Size(100, 20);
            this.tbxFechaFinal.TabIndex = 1;
            // 
            // lbFechaInicio
            // 
            this.lbFechaInicio.AutoSize = true;
            this.lbFechaInicio.Location = new System.Drawing.Point(19, 62);
            this.lbFechaInicio.Name = "lbFechaInicio";
            this.lbFechaInicio.Size = new System.Drawing.Size(77, 13);
            this.lbFechaInicio.TabIndex = 2;
            this.lbFechaInicio.Text = "desde la fecha";
            // 
            // lbFechafinal
            // 
            this.lbFechafinal.AutoSize = true;
            this.lbFechafinal.Location = new System.Drawing.Point(234, 65);
            this.lbFechafinal.Name = "lbFechafinal";
            this.lbFechafinal.Size = new System.Drawing.Size(74, 13);
            this.lbFechafinal.TabIndex = 3;
            this.lbFechafinal.Text = "hasta la fecha";
            // 
            // btnReporteCompras
            // 
            this.btnReporteCompras.Location = new System.Drawing.Point(461, 55);
            this.btnReporteCompras.Name = "btnReporteCompras";
            this.btnReporteCompras.Size = new System.Drawing.Size(75, 23);
            this.btnReporteCompras.TabIndex = 4;
            this.btnReporteCompras.Text = "Generar";
            this.btnReporteCompras.UseVisualStyleBackColor = true;
            this.btnReporteCompras.Click += new System.EventHandler(this.btnReporteCompras_Click);
            // 
            // dtgReportesCompras
            // 
            this.dtgReportesCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgReportesCompras.Location = new System.Drawing.Point(13, 111);
            this.dtgReportesCompras.Name = "dtgReportesCompras";
            this.dtgReportesCompras.Size = new System.Drawing.Size(1099, 327);
            this.dtgReportesCompras.TabIndex = 5;
            // 
            // btnGenerarExcel
            // 
            this.btnGenerarExcel.Location = new System.Drawing.Point(471, 474);
            this.btnGenerarExcel.Name = "btnGenerarExcel";
            this.btnGenerarExcel.Size = new System.Drawing.Size(163, 23);
            this.btnGenerarExcel.TabIndex = 6;
            this.btnGenerarExcel.Text = "Generar Excel";
            this.btnGenerarExcel.UseVisualStyleBackColor = true;
            this.btnGenerarExcel.Click += new System.EventHandler(this.btnGenerarExcel_Click);
            // 
            // frmReporteCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 527);
            this.Controls.Add(this.btnGenerarExcel);
            this.Controls.Add(this.dtgReportesCompras);
            this.Controls.Add(this.btnReporteCompras);
            this.Controls.Add(this.lbFechafinal);
            this.Controls.Add(this.lbFechaInicio);
            this.Controls.Add(this.tbxFechaFinal);
            this.Controls.Add(this.tbxFechaInicial);
            this.Name = "frmReporteCompras";
            this.Text = "frmReporteCompras";
            this.Load += new System.EventHandler(this.frmReporteCompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgReportesCompras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxFechaInicial;
        private System.Windows.Forms.TextBox tbxFechaFinal;
        private System.Windows.Forms.Label lbFechaInicio;
        private System.Windows.Forms.Label lbFechafinal;
        private System.Windows.Forms.Button btnReporteCompras;
        private System.Windows.Forms.DataGridView dtgReportesCompras;
        private System.Windows.Forms.Button btnGenerarExcel;
    }
}