using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAIControlador
{
    internal class ClientesController
    {
            SAIModelo.mainModelo model = new SAIModelo.mainModelo();

            public DataTable consulta_a_dgvCli()
            {
                return model.consulta_a_dgvCli();
            }

            public Boolean comprobarRegistroCli(string buscar)
            {
                return model.comprobarRegistroCli(buscar);
            }

            public Boolean instruccion_sqlCli(string opcion, string[] valores)
            {
                return model.instruccion_sqlCli(opcion, valores);
            }
       
    }
}
