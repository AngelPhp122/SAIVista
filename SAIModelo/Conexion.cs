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

       // Coexion Angel
        private const string servidor = "SAIDataBase.mssql.somee.com";

        //Coexion Moris
         //private const string servidor = "DESKTOP-D8EPUG8";

        //Conexion Violeta
      //  private const string servidor = "DESKTOP-8SBOFT9";

        private const string DBName = "SAIDataBase";

        public void setConexionDB(SqlConnection conexionBD) { 
        
            conexionDB = conexionBD;

        }

        public SqlConnection getConexionDB() { 
        
            return conexionDB;
        }

       

        public Conexion() {

            cadenaConexion = "Data Source=" + servidor + ";" + "Initial Catalog=" + DBName + ";" + "user id=Gramirez_SQLLogin_1; pwd=dr5yknohfs";//.\\SQLSERVER
            conexionDB = new SqlConnection(cadenaConexion);   

        }

    }
}
