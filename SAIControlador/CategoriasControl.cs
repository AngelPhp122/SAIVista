using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAIControlador
{
    internal class CategoriasControl
    {
        SAIModelo.mainModelo model = new SAIModelo.mainModelo();

        public DataTable llenar_comboBoxIdUsrCat()
        {
            return model.llenar_comboBoxIdUsrCat();
        }
        public DataTable consulta_a_dgvCat()
        {
            return model.consulta_a_dgvCat();
        }

        public Boolean comprobarRegistroCat(string buscar)
        {
            return model.comprobarRegistroCat(buscar);
        }

        public Boolean instruccion_sqlCat(string opcion, string[] valores)
        {
            return model.instruccion_sqlCat(opcion, valores);
        }
    }
}
