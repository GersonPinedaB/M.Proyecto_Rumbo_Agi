using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Script.Serialization;
using System.Web.Services;
using System.Data;
using Negocio;

namespace Presentacion
{
    public partial class RA_Sistema : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblJason.Text = convertirDataTableToJson();
        }

        [WebMethod]
        public string convertirDataTableToJson()
        {
            N_MostrarEvento mostrarEv = new N_MostrarEvento();
            DataTable data = mostrarEv.getTablaEvento();
            JavaScriptSerializer serializador = new JavaScriptSerializer();
            List<Dictionary<string, object>> filas = new List<Dictionary<string, object>>();
            Dictionary<string, object> fila;
            foreach (DataRow dr in data.Rows)
            {
                fila = new Dictionary<string, object>();
                foreach (DataColumn col in data.Columns)
                {
                    fila.Add(col.ColumnName, dr[col]);
                }
                filas.Add(fila);
            }
            return serializador.Serialize(filas);
        }
    }
}