using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAIVista
{
    public partial class frmProductos : Form
    {
        SAIControlador.mainController oControlador = new SAIControlador.mainController();
        private string []datos2;

        public frmProductos()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbProductosTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbCategoria = new System.Windows.Forms.Label();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.lbNombre = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.lbDescripcion = new System.Windows.Forms.Label();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.lbCantidad = new System.Windows.Forms.Label();
            this.tbCantidad = new System.Windows.Forms.TextBox();
            this.lbPrecio = new System.Windows.Forms.Label();
            this.tbPrecio = new System.Windows.Forms.TextBox();
            this.lbImagen = new System.Windows.Forms.Label();
            this.btnImagen = new System.Windows.Forms.Button();
            this.dtgArticulos = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lbIndexCat = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtgArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbProductosTitulo
            // 
            this.lbProductosTitulo.AutoSize = true;
            this.lbProductosTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lbProductosTitulo.Location = new System.Drawing.Point(29, 42);
            this.lbProductosTitulo.Name = "lbProductosTitulo";
            this.lbProductosTitulo.Size = new System.Drawing.Size(170, 39);
            this.lbProductosTitulo.TabIndex = 0;
            this.lbProductosTitulo.Text = "Productos";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // lbCategoria
            // 
            this.lbCategoria.AutoSize = true;
            this.lbCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbCategoria.Location = new System.Drawing.Point(31, 126);
            this.lbCategoria.Name = "lbCategoria";
            this.lbCategoria.Size = new System.Drawing.Size(97, 25);
            this.lbCategoria.TabIndex = 1;
            this.lbCategoria.Text = "Categoria";
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Location = new System.Drawing.Point(36, 166);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(202, 21);
            this.cbxCategoria.TabIndex = 2;
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbNombre.Location = new System.Drawing.Point(31, 201);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(81, 25);
            this.lbNombre.TabIndex = 3;
            this.lbNombre.Text = "Nombre";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(36, 229);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(202, 20);
            this.tbNombre.TabIndex = 4;
            // 
            // lbDescripcion
            // 
            this.lbDescripcion.AutoSize = true;
            this.lbDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbDescripcion.Location = new System.Drawing.Point(31, 266);
            this.lbDescripcion.Name = "lbDescripcion";
            this.lbDescripcion.Size = new System.Drawing.Size(114, 25);
            this.lbDescripcion.TabIndex = 5;
            this.lbDescripcion.Text = "Descripcion";
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Location = new System.Drawing.Point(36, 294);
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(202, 20);
            this.tbDescripcion.TabIndex = 6;
            // 
            // lbCantidad
            // 
            this.lbCantidad.AutoSize = true;
            this.lbCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbCantidad.Location = new System.Drawing.Point(31, 335);
            this.lbCantidad.Name = "lbCantidad";
            this.lbCantidad.Size = new System.Drawing.Size(91, 25);
            this.lbCantidad.TabIndex = 7;
            this.lbCantidad.Text = "Cantidad";
            // 
            // tbCantidad
            // 
            this.tbCantidad.Location = new System.Drawing.Point(36, 363);
            this.tbCantidad.Name = "tbCantidad";
            this.tbCantidad.Size = new System.Drawing.Size(202, 20);
            this.tbCantidad.TabIndex = 8;
            // 
            // lbPrecio
            // 
            this.lbPrecio.AutoSize = true;
            this.lbPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbPrecio.Location = new System.Drawing.Point(31, 402);
            this.lbPrecio.Name = "lbPrecio";
            this.lbPrecio.Size = new System.Drawing.Size(67, 25);
            this.lbPrecio.TabIndex = 9;
            this.lbPrecio.Text = "Precio";
            // 
            // tbPrecio
            // 
            this.tbPrecio.Location = new System.Drawing.Point(36, 430);
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.Size = new System.Drawing.Size(202, 20);
            this.tbPrecio.TabIndex = 10;
            // 
            // lbImagen
            // 
            this.lbImagen.AutoSize = true;
            this.lbImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbImagen.Location = new System.Drawing.Point(31, 471);
            this.lbImagen.Name = "lbImagen";
            this.lbImagen.Size = new System.Drawing.Size(77, 25);
            this.lbImagen.TabIndex = 11;
            this.lbImagen.Text = "Imagen";
            // 
            // btnImagen
            // 
            this.btnImagen.Location = new System.Drawing.Point(36, 518);
            this.btnImagen.Name = "btnImagen";
            this.btnImagen.Size = new System.Drawing.Size(202, 23);
            this.btnImagen.TabIndex = 12;
            this.btnImagen.Text = "Agregar archivo";
            this.btnImagen.UseVisualStyleBackColor = true;
            // 
            // dtgArticulos
            // 
            this.dtgArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgArticulos.Location = new System.Drawing.Point(266, 126);
            this.dtgArticulos.Name = "dtgArticulos";
            this.dtgArticulos.Size = new System.Drawing.Size(801, 415);
            this.dtgArticulos.TabIndex = 13;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(266, 571);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(202, 23);
            this.btnAgregar.TabIndex = 14;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(552, 571);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(202, 23);
            this.btnEditar.TabIndex = 15;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(865, 571);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(202, 23);
            this.btnEliminar.TabIndex = 16;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // lbIndexCat
            // 
            this.lbIndexCat.AutoSize = true;
            this.lbIndexCat.Location = new System.Drawing.Point(12, 169);
            this.lbIndexCat.Name = "lbIndexCat";
            this.lbIndexCat.Size = new System.Drawing.Size(10, 13);
            this.lbIndexCat.TabIndex = 17;
            this.lbIndexCat.Text = ".";
            this.lbIndexCat.Visible = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmProductos
            // 
            this.ClientSize = new System.Drawing.Size(1079, 654);
            this.Controls.Add(this.lbIndexCat);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dtgArticulos);
            this.Controls.Add(this.btnImagen);
            this.Controls.Add(this.lbImagen);
            this.Controls.Add(this.tbPrecio);
            this.Controls.Add(this.lbPrecio);
            this.Controls.Add(this.tbCantidad);
            this.Controls.Add(this.lbCantidad);
            this.Controls.Add(this.tbDescripcion);
            this.Controls.Add(this.lbDescripcion);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.cbxCategoria);
            this.Controls.Add(this.lbCategoria);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbProductosTitulo);
            this.Name = "frmProductos";
            this.Load += new System.EventHandler(this.frmProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        //metodo del boton agregar para hacer una insercion en la tabla articulos
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string[] datos = new string[5];
            string[,] datosID;


            if (String.IsNullOrWhiteSpace(tbNombre.Text) || String.IsNullOrWhiteSpace(cbxCategoria.Text) || String.IsNullOrWhiteSpace(tbDescripcion.Text) || String.IsNullOrWhiteSpace(tbCantidad.Text) || String.IsNullOrWhiteSpace(tbPrecio.Text))
            {

                validarCampos();

            }
            else
            {



                //lleno el arreglo con los datos obtenidos en la vista para luego enviarlos al controlador  
                datosID = oControlador.datosCbxCategoria();

                //for que me ayuda a obtener el elemento correcto segun su id en la tabla y a su vez almacena los datos que se iran a guardar a la tabla
                for (int i = 0; i < (datosID.Length / 2); i++)
                    if (datosID[i, 1].Equals(cbxCategoria.Text))
                    {

                        datos[0] = datosID[i, 0];
                    }

                datos[1] = tbNombre.Text;
                datos[2] = tbDescripcion.Text;
                datos[3] = tbCantidad.Text;
                datos[4] = tbPrecio.Text;


                //envio los datos al controlador llamando el metodo por medio de la instancia (objeto)
                oControlador.recibeDatos(datos[0], datos[1], datos[2], datos[3], datos[4]);

                //limpiar cada elemento de la vista
                limpiarCajas();


                //se hace la llamada al load del formulario para actualizar los registros una vez presiones el boton agregar

                frmProductos_Load(sender, e);

            }
        
        }

        //metodo del combobox y del DatagrewView
        private void frmProductos_Load(object sender, EventArgs e)
        {
            string[,] d;



            int comprobar1;

            comprobar1 = cbxCategoria.Items.Count;
            MessageBox.Show(""+comprobar1);
            if (comprobar1 == 0)
            {
                d = oControlador.datosCbxCategoria();

                datos2 = new string[d.Length / 2];

                for (int i = 0; i < (d.Length / 2); i++)
                {

                    //cbxCategoria.DataSource = d;
                    cbxCategoria.Items.Add(d[i, 1]);
                    datos2[i] = d[i, 0];

                    //cbxCategoria.ValueMember = d[i, 0];


                }

            }


            //DatagrewView

            string[,] c;
            int comprobar;


            comprobar = dtgArticulos.Rows.Count;

            DataGridViewTextBoxColumn c1 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn c2 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn c3 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn c4 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn c5 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn c6 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn c7 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn c8 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn c9 = new DataGridViewTextBoxColumn();

            //estructura de control que no permite la duplicacion de la tabla
            if (comprobar <= 0) { 

            c1.HeaderText = "id producto";
            c2.HeaderText = "id categoria";
            c3.HeaderText = "id imagen";
            c4.HeaderText = "id usuario";
            c5.HeaderText = "nombre articulo";
            c6.HeaderText = "descripcion";
            c7.HeaderText = "cantidad";
            c8.HeaderText = "precio";
            c9.HeaderText = "fecha de ingreso";

            dtgArticulos.Columns.Add(c1);
            dtgArticulos.Columns.Add(c2);
            dtgArticulos.Columns.Add(c3);
            dtgArticulos.Columns.Add(c4);
            dtgArticulos.Columns.Add(c5);
            dtgArticulos.Columns.Add(c6);
            dtgArticulos.Columns.Add(c7);
            dtgArticulos.Columns.Add(c8);
            dtgArticulos.Columns.Add(c9);

        }

            c = oControlador.datosDtgArticulos();
            for (int i = 0; i < (c.Length / 9); i++) {

                dtgArticulos.Rows.Add(c[i,0], c[i,1], c[i, 2], c[i, 3], c[i, 4], c[i, 5], c[i, 6], c[i, 7], c[i, 8]);
                

            }


        }

        
        //metodo para limpiar cajas.
        public void limpiarCajas() {

            cbxCategoria.Text = "";
            tbNombre.Text = "";
            tbDescripcion.Text = "";
            tbCantidad.Text = "";
            tbPrecio.Text = "";

        }

        //metodo para validacion de campos nulos
        public void validarCampos() {

            


            if (String.IsNullOrWhiteSpace(tbNombre.Text) || String.IsNullOrWhiteSpace(cbxCategoria.Text) || String.IsNullOrWhiteSpace(tbDescripcion.Text) || String.IsNullOrWhiteSpace(tbCantidad.Text) || String.IsNullOrWhiteSpace(tbPrecio.Text))

            {
                if (String.IsNullOrWhiteSpace(tbNombre.Text)) { errorProvider1.SetError(this.tbNombre, "campos obligatorios"); }
                if (String.IsNullOrWhiteSpace(cbxCategoria.Text)) { errorProvider1.SetError(this.cbxCategoria, "campos obligatorios"); }
                if (String.IsNullOrWhiteSpace(tbDescripcion.Text)) { errorProvider1.SetError(this.tbDescripcion, "campos obligatorios"); }
                if (String.IsNullOrWhiteSpace(tbCantidad.Text)) { errorProvider1.SetError(this.tbCantidad, "campos obligatorios"); }
                if (String.IsNullOrWhiteSpace(tbPrecio.Text)) { errorProvider1.SetError(this.tbPrecio, "campos obligatorios"); }


            }
            else { errorProvider1.Clear(); }
            

            }



        }
       
    }

