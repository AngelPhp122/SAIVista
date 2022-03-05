using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAIControlador
{
    public class mainController
    {

        SAIModelo.mainModelo oModelo = new SAIModelo.mainModelo();

        

        public void recibeDatos(string a, string b, string c, string d, string e) {

            string[] datos = new string[5];
            datos[0] = a;
            datos[1] = b;
            datos[2] = c;
            datos[3] = d;
            datos[4] = e;
            Console.WriteLine(b + " estoy en el controlador");
            oModelo.insertarDatos(datos[0], datos[1], datos[2], datos[3], datos[4]);

        }

        //controlador para el llenado del comboBox
        public string[,] datosCbxCategoria() {

            string [,]datos;

            datos =  oModelo.datosCbxCategoria();

        

            return datos;

        }



        //controlador para el llenado del dataGriewView
        //
        public string[,] datosDtgArticulos() { 
        
        string[,]datos;
        
            datos = oModelo.datosDataGrieView();

            return datos;

        }
        
        

    }
}
