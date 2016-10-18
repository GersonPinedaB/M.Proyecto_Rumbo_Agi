using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace GestionDatos
{
    public class D_Operacion
    {
        public bool insertOperacion(T_Operacion operacion)
        {
            bool aux = true;
            using(BD_RumboAgilEntities rumboAgil = new BD_RumboAgilEntities())
            {
                try
                {
                    rumboAgil.T_Operacion.Add(operacion);
                    rumboAgil.SaveChanges();
                }
                catch (Exception ex)
                {
                    aux = false;
                }
                return aux;
            }
        }
    }
}
