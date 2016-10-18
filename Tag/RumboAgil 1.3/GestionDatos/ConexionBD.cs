using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDatos
{
    public class ConexionBD
    {
        public static string CadenaConexion {
            get {

                return "data source=(local);initial catalog=BD_RumboAgil;integrated security=SSPI;";
            
            }
        }
    }
}
