using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dominio;
using GestionDatos;

namespace Negocio
{
    public class N_MostrarEvento
    {
        public DataTable getTablaEvento()
        {
            D_Evento ev = new D_Evento();
            return ev.getEventosCalendario();
        }
    }
}
