using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAIControlador
{
    public class VentaController
    {
        SAIModelo.VentaModel oModelo = new SAIModelo.VentaModel();


        public DataTable GetSales()
        {
            return oModelo.GetSales();
        }

        public DataTable GetProducts()
        {
            return oModelo.GetProducts();
        }

        public void SaveSale(DataTable data, int totalProductos, double totalValor, int IdCliente)
        {
            oModelo.SaveSale(data,totalProductos,totalValor,IdCliente);
        }
        
        public DataTable GetUsers()
        {
            return oModelo.GetUsers();
        }
        
    }
}
