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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.tbxPrecioMod = new System.Windows.Forms.TextBox();
            this.btnAgregarImagenMod = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxNombreMod
            // 
            this.tbxNombreMod.Location = new System.Drawing.Point(88, 93);
            this.tbxNombreMod.Name = "tbxNombreMod";
            this.tbxNombreMod.Size = new System.Drawing.Size(185, 20);
            this.tbxNombreMod.TabIndex = 0;
            // 
            // tbxDescripcionMod
            // 
            this.tbxDescripcionMod.Location = new System.Drawing.Point(88, 151);
            this.tbxDescripcionMod.Name = "tbxDescripcionMod";
            this.tbxDescripcionMod.Size = new System.Drawing.Size(185, 20);
            this.tbxDescripcionMod.TabIndex = 1;
            // 
            // tbxCantidadMod
            // 
            this.tbxCantidadMod.Location = new System.Drawing.Point(88, 221);
            this.tbxCantidadMod.Name = "tbxCantidadMod";
            this.tbxCantidadMod.Size = new System.Drawing.Size(185, 20);
            this.tbxCantidadMod.TabIndex = 2;
            // 
            // cbxCategoriaModificar
            // 
            this.cbxCategoriaModificar.FormattingEnabled = true;
            this.cbxCategoriaModificar.Location = new System.Drawing.Point(88, 28);
            this.cbxCategoriaModificar.Name = "cbxCategoriaModificar";
            this.cbxCategoriaModificar.Size = new System.Drawing.Size(185, 21);
            this.cbxCategoriaModificar.TabIndex = 3;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(133, 416);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbxPrecioMod
            // 
            this.tbxPrecioMod.Location = new System.Drawing.Point(88, 283);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Categoria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "descripcion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "cantidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "precio";
            // 
            // frmModificarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 475);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAgregarImagenMod);
            this.Controls.Add(this.tbxPrecioMod);
            this.Controls.Add(this.btnGuardar);
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
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox tbxPrecioMod;
        private System.Windows.Forms.Button btnAgregarImagenMod;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}