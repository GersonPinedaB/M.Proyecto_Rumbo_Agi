using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class E_Lugar
    {
        private int idLugar;

        public int IdLugar
        {
            get { return idLugar; }
            set { idLugar = value; }
        }
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private int aforo;

        public int Aforo
        {
            get { return aforo; }
            set { aforo = value; }
        }
        private string varchar;

        public string Varchar
        {
            get { return varchar; }
            set { varchar = value; }
        }
        private string descripcion;

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }


    }
}
