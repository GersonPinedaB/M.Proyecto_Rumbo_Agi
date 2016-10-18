using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Dominio;

namespace GestionDatos
{
    public class D_Evento
    {
        private SqlCommand mcm;
        private SqlDataReader mdr;
        private SqlDataAdapter mda;
        private DataSet mdd;
        SqlConnection conx = new SqlConnection(ConexionBD.CadenaConexion);


        public String insertEvento(Dominio.E_Evento Sol)
        {
            try
            {
                mcm = new SqlCommand("sp_SolicitarEvento", conx);
                mcm.CommandType = CommandType.StoredProcedure;
                mcm.Parameters.AddWithValue("@nombreEvento", Sol.NombreEvento);
                mcm.Parameters.AddWithValue("@Descripcion", Sol.Descripcion);
                mcm.Parameters.AddWithValue("@fechaInicio", Sol.FechaInicio);
                mcm.Parameters.AddWithValue("@horaInicio", Sol.HoraInicio);
                mcm.Parameters.AddWithValue("@fechaFin", Sol.FechaFin);
                mcm.Parameters.AddWithValue("@horaFin", Sol.HoraFin);
                mcm.Parameters.AddWithValue("@comentario", Sol.Comentario);
                mcm.Parameters.AddWithValue("@idEstado", Sol.Estado);
                mcm.Parameters.AddWithValue("@idTipoE", Sol.IdTipoEvento);
                mcm.Parameters.AddWithValue("@idLugar", Sol.IdLugar);
                mcm.Parameters.AddWithValue("@idLider", Sol.IdLider);

                mcm.Parameters.Add("@Mensaje", SqlDbType.VarChar, 200);
                mcm.Parameters["@Mensaje"].Direction = ParameterDirection.Output;
                conx.Open();
                mcm.ExecuteNonQuery();
                conx.Close();
                return "Solicitud Enviada";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
 

    }


}
