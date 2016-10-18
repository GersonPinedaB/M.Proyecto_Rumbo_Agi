using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace Negocio
{
    public class N_Lugar
    {
         Dominio.E_Lugar objLugEv = new Dominio.E_Lugar();
        GestionDatos.D_Lugar objLug = new GestionDatos.D_Lugar();
         public DataSet SelectLugar()
        {

            try
            {
                return objLug.SelectLugar();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataTable ConsultarLugar()
        {
            try
            {
                return objLug.ConsultarLugar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
    

