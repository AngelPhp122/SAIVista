using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAIControlador
{
    internal class UsuariosControl
    {
        SAIModelo.mainModelo model = new SAIModelo.mainModelo();

        public DataTable llenar_comboBoxUsr()
        {
            return model.llenar_comboBoxUsr();
        }
        public DataTable consulta_a_dgvUsr()
        {
            return model.consulta_a_dgvUsr();
        }

        public Boolean comprobarRegistroUsr(string buscar)
        {
            return model.comprobarRegistroUsr(buscar);
        }

        public Boolean instruccion_sqlUsr(string opcion, string[] valores)
        {
            return model.instruccion_sqlUsr(opcion, valores);
        }
    }
}
