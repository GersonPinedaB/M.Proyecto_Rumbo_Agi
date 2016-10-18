using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace Presentacion
{
    public partial class W_Evaluar_Solicitud : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                llenarComboEventos();                
            }
        }

        public void llenarComboEventos()
        {
            List<string> eventos = N_Evaluar_Solicitud.obtenerNombreEventos();
            foreach(string tipo in eventos) 
            {
                ddEventos.Items.Add(tipo);
            }
        }

        protected void ddEventos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nombreEvento = ddEventos.Text;
            T_Evento evento = N_Evaluar_Solicitud.obtenerEventoPorNombre(nombreEvento);
            txtDescripcion.Text = evento.Descripcion;
            txtTipoEvento.Text = N_Solicitar_Evento.obtenerTipoPorId(evento.Id_TipoEvento).TipoEvento;
            txtLugar.Text = N_Solicitar_Evento.obtenerLugarPorId(evento.Id_Lugar).Lugar;
            txtHoraInicio.Text = evento.Hora_Inicio.ToString();
            txtFechaInicio.Text = evento.Fecha_Inicio.ToString("dd/MM/yyyy");
            txtHoraFin.Text = evento.Hora_fin.ToString();
            txtFechaFin.Text = evento.Fecha_fin.ToString("dd/MM/yyyy");
            txtLider.Text = N_Evaluar_Solicitud.obtenerPersonaPorId(evento.Id_Lider).Nombres;
        }

        protected void Aprobar_Click(object sender, EventArgs e)
        {
            if (N_Evaluar_Solicitud.actualizarEstadoAprobado(N_Evaluar_Solicitud.obtenerEventoPorNombre(ddEventos.Text))==false)
            {
                string display = "Error al aprobar el evento";
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + display + "');", true);
                return;
            }
            string display2 = "Evento Aprobado con exito";
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + display2 + "');", true);
            Response.Redirect("W_Evaluar_Solicitud.aspx");
        }

        protected void Rechazar_Click(object sender, EventArgs e)
        {
            if (N_Evaluar_Solicitud.actualizarEstadoRechazado(N_Evaluar_Solicitud.obtenerEventoPorNombre(ddEventos.Text)) == false)
            {
                string display = "Error al rechazar";
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + display + "');", true);
                return;
            }
            string display2 = "Evento Rechazado con exito";
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + display2 + "');", true);
            Response.Redirect("W_Evaluar_Solicitud.aspx");
        }
    }
}