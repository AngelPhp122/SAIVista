namespace SAIVista
{
    partial class frmModificarProducto
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
            this.tbxNombreMod = new System.Windows.Forms.TextBox();
            this.tbxDescripcionMod = new System.Windows.Forms.TextBox();
            this.tbxCantidadMod = new System.Windows.Forms.TextBox();
            this.cbxCategoriaModificar = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbxPrecioMod = new System.Windows.Forms.TextBox();
            this.btnAgregarImagenMod = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // tbxNombreMod
            // 
            this.tbxNombreMod.Location = new System.Drawing.Point(75, 93);
            this.tbxNombreMod.Name = "tbxNombreMod";
            this.tbxNombreMod.Size = new System.Drawing.Size(185, 20);
            this.tbxNombreMod.TabIndex = 0;
            // 
            // tbxDescripcionMod
            // 
            this.tbxDescripcionMod.Location = new System.Drawing.Point(75, 155);
            this.tbxDescripcionMod.Name = "tbxDescripcionMod";
            this.tbxDescripcionMod.Size = new System.Drawing.Size(185, 20);
            this.tbxDescripcionMod.TabIndex = 1;
            // 
            // tbxCantidadMod
            // 
            this.tbxCantidadMod.Location = new System.Drawing.Point(75, 221);
            this.tbxCantidadMod.Name = "tbxCantidadMod";
            this.tbxCantidadMod.Size = new System.Drawing.Size(185, 20);
            this.tbxCantidadMod.TabIndex = 2;
            // 
            // cbxCategoriaModificar
            // 
            this.cbxCategoriaModificar.FormattingEnabled = true;
            this.cbxCategoriaModificar.Location = new System.Drawing.Point(75, 28);
            this.cbxCategoriaModificar.Name = "cbxCategoriaModificar";
            this.cbxCategoriaModificar.Size = new System.Drawing.Size(185, 21);
            this.cbxCategoriaModificar.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(133, 416);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbxPrecioMod
            // 
            this.tbxPrecioMod.Location = new System.Drawing.Point(75, 283);
            this.tbxPrecioMod.Name = "tbxPrecioMod";
            this.tbxPrecioMod.Size = new System.Drawing.Size(185, 20);
            this.tbxPrecioMod.TabIndex = 5;
            // 
            // btnAgregarImagenMod
            // 
            this.btnAgregarImagenMod.Location = new System.Drawing.Point(110, 338);
            this.btnAgregarImagenMod.Name = "btnAgregarImagenMod";
            this.btnAgregarImagenMod.Size = new System.Drawing.Size(128, 23);
            this.btnAgregarImagenMod.TabIndex = 6;
            this.btnAgregarImagenMod.Text = "Agregar imagen";
            this.btnAgregarImagenMod.UseVisualStyleBackColor = true;
            this.btnAgregarImagenMod.Click += new System.EventHandler(this.btnAgregarImagenMod_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmModificarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 475);
            this.Controls.Add(this.btnAgregarImagenMod);
            this.Controls.Add(this.tbxPrecioMod);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbxCategoriaModificar);
            this.Controls.Add(this.tbxCantidadMod);
            this.Controls.Add(this.tbxDescripcionMod);
            this.Controls.Add(this.tbxNombreMod);
            this.Name = "frmModificarProducto";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmModificarProducto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxNombreMod;
        private System.Windows.Forms.TextBox tbxDescripcionMod;
        private System.Windows.Forms.TextBox tbxCantidadMod;
        private System.Windows.Forms.ComboBox cbxCategoriaModificar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbxPrecioMod;
        private System.Windows.Forms.Button btnAgregarImagenMod;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}