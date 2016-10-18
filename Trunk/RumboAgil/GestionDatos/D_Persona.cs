using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace GestionDatos
{
    public class D_Persona
    {
        public T_Persona getPersonaById(short idPersona)
        {
            using (BD_RumboAgilEntities rumboAgil = new BD_RumboAgilEntities())
            {
                var persona = rumboAgil.T_Persona.Where(p => p.Id_Persona == idPersona).FirstOrDefault();
                return persona;
            }
        }
    }
}
