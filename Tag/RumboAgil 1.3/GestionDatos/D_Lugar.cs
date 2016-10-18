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
    public class D_Lugar
    {

         private SqlCommand mcm;
        private SqlDataReader mdr;
        private SqlDataAdapter mda;
        private DataSet mdd;
        SqlConnection conx = new SqlConnection(ConexionBD.CadenaConexion);

        public DataSet SelectLugar()
        {
            SqlCommand cmd = new SqlCommand("sp_ListarLugar", conx);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter ddl = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            ddl.Fill(ds);
            return ds;
        }
        public DataTable ConsultarLugar()
        {
            try
            {
                mda = new SqlDataAdapter("sp_ListarLugar", conx);
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
    

