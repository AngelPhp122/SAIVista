using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SAIControlador
{
    internal class TiposUsuarioController
    {
        SAIModelo.mainModelo model = new SAIModelo.mainModelo();

        public DataTable consulta_a_dgv()
        {
            return model.consulta_a_dgv();
        }

        public Boolean comprobarRegistro(string buscar)
        {
            return model.comprobarRegistro(buscar);
        }

        public Boolean instruccion_sql(string opcion, string[] valores)
        {
            return model.instruccion_sql(opcion, valores);
        }
    }
}
