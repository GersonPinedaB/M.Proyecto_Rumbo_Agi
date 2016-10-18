using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class E_Lider
    {
        private int idLider;

        public int IdLider
        {
            get { return idLider; }
            set { idLider = value; }
        }
        private bool enActividad;

        public bool EnActividad
        {
            get { return enActividad; }
            set { enActividad = value; }
        }
        private string llamado;

        public string Llamado
        {
            get { return llamado; }
            set { llamado = value; }
        }

    }
}
