using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class E_TipoEvento
    {
        private int idTipoEvento;

        public int IdTipoEvento
        {
            get { return idTipoEvento; }
            set { idTipoEvento = value; }
        }
        private string tipoEvento;

        public string TipoEvento
        {
            get { return tipoEvento; }
            set { tipoEvento = value; }
        }
    }
}
