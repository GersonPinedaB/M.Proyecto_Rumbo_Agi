using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Dominio;
using GestionDatos;

namespace Negocio
{
    public class N_Operacion
    {
        Dominio.E_Operacion objSolE = new Dominio.E_Operacion();
        GestionDatos.D_Operacion objSol = new GestionDatos.D_Operacion();


        public DataTable ConsultarIdEvento()
        {
            try
            {
                return objSol.ConsultarTipoEvento();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet SelectIdevento()
        {

            try
            {
                return objSol.SelectIdEvento();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public String CrearOperacion(int idusuario, int idevento, string operacion, DateTime Fecha,String motivo)
        {
            try
            {
                objSolE.IdUsuario = idusuario;
                objSolE.IdEvento = idevento;
                objSolE.Operacion = operacion;
                objSolE.FechaOperacion = Fecha;
                objSolE.Motivo = motivo;
        
                return objSol.insertOperacion(objSolE);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
}
        }
    
    
    
    

