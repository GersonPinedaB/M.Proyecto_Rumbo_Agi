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
    public class D_Operacion
    {
        private SqlCommand mcm;
        private SqlDataReader mdr;
        private SqlDataAdapter mda;
        private DataSet mdd;

        SqlConnection conx = new SqlConnection(ConexionBD.CadenaConexion);



        public String insertOperacion(Dominio.E_Operacion Sol)
        {
            try
            {
                mcm = new SqlCommand("sp_InsertarOperacion", conx);
                mcm.CommandType = CommandType.StoredProcedure;
                mcm.Parameters.AddWithValue("@idUsuario", Sol.IdUsuario);
                mcm.Parameters.AddWithValue("@idEvento", Sol.IdEvento);
                mcm.Parameters.AddWithValue("@operacion", Sol.Operacion);
                mcm.Parameters.AddWithValue("@fechaOperacion", Sol.FechaOperacion);
                mcm.Parameters.AddWithValue("@motivo", Sol.Motivo);

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
        public DataSet SelectIdEvento()
        {
            SqlCommand cmd = new SqlCommand("sp_IdEvento", conx);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter ddl = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            ddl.Fill(ds);
            return ds;
        }
        public DataTable ConsultarTipoEvento()
        {
            try
            {
                mda = new SqlDataAdapter("sp_IdEvento", conx);
                mda.SelectCommand.CommandType = CommandType.StoredProcedure;
                mdd = new DataSet();
                mda.Fill(mdd);
                return mdd.Tables[0];
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
