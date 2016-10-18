using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;
using System.Data;
using System.Drawing;


namespace Presentacion
{
    public partial class SolicitarEvento : System.Web.UI.Page
    {
        string SoloUnaSemana = "";  

        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!Page.IsPostBack)
            {
                
                CargarComboTipoEvento();
                CargarLugar();


            } else
                CargarIdEvento();
        }

        private void CargarIdEvento()
        {
            N_Operacion cargarId = new N_Operacion();

            DataTable dtId = cargarId.ConsultarIdEvento();

            ddlidevento.DataSource = dtId;
            ddlidevento.DataTextField = "ID_Evento";
            ddlidevento.DataValueField = "ID_Evento";
            ddlidevento.DataBind();

        }
        private void CargarComboTipoEvento()
        {
            N_TipoEvento ctrol = new N_TipoEvento();

            DataTable dtPrioridad = ctrol.ConsultarTipoEvento();

            ddlTipoEvento.DataSource = dtPrioridad;
            ddlTipoEvento.DataTextField = "TipoEvento";
            ddlTipoEvento.DataValueField = "Id_TipoEvento";
            ddlTipoEvento.DataBind();

        }
        private void CargarLugar()
        {
            N_Lugar cargarL = new N_Lugar();

            DataTable dtLugar = cargarL.ConsultarLugar();

            ddlLugar.DataSource = dtLugar;
            ddlLugar.DataTextField = "Nombre";
            ddlLugar.DataValueField = "id_Lugar";
            ddlLugar.DataBind();

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Negocio.N_Solicitar_Evento objSolEv = new Negocio.N_Solicitar_Evento();
            Dominio.E_Evento objEnt = new Dominio.E_Evento();

            Negocio.N_Operacion objoperacion = new Negocio.N_Operacion();
            Dominio.E_Operacion objOp = new Dominio.E_Operacion();

            string msjvalidarVacios = validarVacios();
            if (msjvalidarVacios == "bien")
            {
                string msjvalidacion = validarcamposregistro(Nombre.Text.Trim(),Descripcion.Text.Trim());
                if (msjvalidacion == "")
                {

                    string nombreEvento = Convert.ToString(this.Nombre.Text.Trim());
                    string descripcion = Convert.ToString(this.Descripcion.Text.Trim());
                    DateTime fechainicio = Convert.ToDateTime(this.FechaInicio.Text.Trim());
                    DateTime fechafin = Convert.ToDateTime(this.FechaFin.Text.Trim());
                    string horainicio = Convert.ToString(this.HoraInicio.Text.Trim());
                    string horafin = Convert.ToString(this.HoraFin.Text.Trim());
                    string tipoEvento = ddlTipoEvento.Text;
                    string comentario = "";
                    int estado = 1;
                    string idlugar = ddlLugar.Text;
                    int idlider = 1;
                    
                    

                    objSolEv.SolicitarEvento(nombreEvento, descripcion, fechainicio, horainicio, fechafin, horafin, comentario, estado, tipoEvento, idlugar, idlider);
                    
                    string display = "Su solicitud ha sido enviada para su aprobación";
                    string idevento = ddlidevento.Text;
                    int Idevento = Convert.ToInt32(idevento);
                    objoperacion.CrearOperacion(idlider, Idevento+20, "SOLICITAR", DateTime.Today.Date,"");

                    
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + display + "');", true);

                }
                else ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + msjvalidacion + "');", true);

            }
            else ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + msjvalidarVacios + "');", true);

        }
        public string validarVacios()
        {
            if (this.Nombre.Text.Trim () == "")
            {
                return "Debe ingresar un nombre de evento";
            }
            else
                if (this.Descripcion.Text.Trim()== "")
                {
                    return "Hace falta una descripción";
                }
                else
                    if (FechaInicio.Text == "")
                    {
                        return "No ha ingresado la fecha inicio";
                    }
                    else
                        if (FechaFin.Text == "") {

                            return "No ha ingresado la fecha fin";
                        }
                        else
                            if (HoraInicio.Text == "") {

                                return "No ha ingresado la hora inicio";
                            }
                            else
                                if (HoraFin.Text == "") {

                                    return "No ha ingresado la hora fin";
                                }
                                else
                                    if (DateTime.Parse(FechaInicio.Text) < DateTime.Today.Date)
                                    {
                                        return "Debe ingresar una fecha mayor al dia actual";
                                    }
                                    else if (DateTime.Parse(FechaFin.Text) < DateTime.Parse(FechaInicio.Text))
                                    {

                                        return "La fecha final debe ser mayor a la fecha de inicio";

                                    }
                                    else
                                        if (DateTime.Parse(FechaFin.Text) > DateTime.Parse(FechaInicio.Text) )
                                        {
                                            TimeSpan semana = DateTime.Parse(FechaFin.Text).Subtract(DateTime.Parse(FechaInicio.Text));
                                            if (semana.TotalDays > 7) {
                                                SoloUnaSemana = "Las fechas pueden tener como máximo una semana de duracion";
                                                return SoloUnaSemana;
                                            
                                            }
                                            return "bien";
                                        }

                                        else
                                            return "bien";
        }

        public string validarcamposregistro(string nombre, string descripcion)
        {

            string msjvalidacion = "";
            Validation v = new Validation();

            if (!v.validarNombre(nombre)) msjvalidacion += "Debe ingresar solo letras en el nombre de evento\\n";

            return msjvalidacion;

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    
    
    }
}