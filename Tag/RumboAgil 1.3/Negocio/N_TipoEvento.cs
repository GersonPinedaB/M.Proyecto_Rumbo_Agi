using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Negocio
{
    public class N_TipoEvento
    {
        Dominio.E_TipoEvento objTipEv = new Dominio.E_TipoEvento();
        GestionDatos.D_TipoEvento objTip = new GestionDatos.D_TipoEvento();
         public DataSet SelectTipoEvento()
        {

            try
            {
                return objTip.SelectTipoEvento();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataTable ConsultarTipoEvento()
        {
            try
            {
                return objTip.ConsultarTipoEvento();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
    

