using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class E_Estado
    {
        private int id_Estado;

        public int Id_Estado
        {
            get { return id_Estado; }
            set { id_Estado = value; }
        }
        private string estado;

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

    }
}
