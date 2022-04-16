using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;

namespace SAIModelo
{
    internal class Conexion
    {
        private SqlConnection conexionDB;
        private string cadenaConexion;

        //Conexion Carlos 
        //private const string servidor = "DESKTOP-LVOSUC0";

        //Coexion Angel
        private const string servidor = "DESKTOP-37CLJ35";

        //Coexion Moris
       // private const string servidor = "DESKTOP-D8EPUG8";
        

        private const string DBName = "SAIDB";

        public void setConexionDB(SqlConnection conexionBD) { 
        
            conexionDB = conexionBD;

        }

        public SqlConnection getConexionDB() { 
        
            return conexionDB;
        }

       

        public Conexion() {

            cadenaConexion = "Data Source=" + servidor + ";" + "Initial Catalog=" + DBName + ";" + "Integrated Security = True";//.\\SQLSERVER
            conexionDB = new SqlConnection(cadenaConexion);   

        }

    }
}
