﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAIControlador
{
    internal class ReportesController
    {
       SAIModelo.mainModelo oReportesMainModel = new SAIModelo.mainModelo();


        private string [,] recibeDatosReportesController(string fechaInicial, string fechaFinal)
        {


            string[,] datos;

            datos = oReportesMainModel.reportesComprasMainModel(fechaInicial, fechaFinal);

            return datos;

        }

        private string[,] recibeDatosReportesVentasController(string fechaInicial, string fechaFinal)
        {


            string[,] datos;

            datos = oReportesMainModel.reportesVentasMainModel(fechaInicial, fechaFinal);

            return datos;

        }

        public string [,] getRecibeDatosReportesController(string fechaInicia, string fechaFinal) {
        
        
            return recibeDatosReportesController (fechaInicia, fechaFinal);
        
        }

        public string[,] getRecibeDatosReporteVentasController(string fechaInicia, string fechaFinal)
        {


            return recibeDatosReportesVentasController(fechaInicia, fechaFinal);

        }


    }
}
