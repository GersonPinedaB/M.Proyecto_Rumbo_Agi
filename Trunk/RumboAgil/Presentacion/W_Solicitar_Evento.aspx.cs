using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace Presentacion
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        string soloUnaSemana = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                cargarComboTipoEvento();
                cargarComboLugares();
            }            
        }

        protected void Solicitar_Click(object sender, EventArgs e)
        {            
            T_Evento evento = new T_Evento();
            T_Operacion operacion = new T_Operacion();

            string msjvalidarVacios = validarVacios();
            if (msjvalidarVacios == "bien")
            {
                string msjvalidacion = validarcamposregistro(txtNombre.Text.Trim(), txtDescripcion.Text.Trim());
                if (msjvalidacion == "")
                {

                    evento.Nombre = Convert.ToString(this.txtNombre.Text.Trim());
                    evento.Descripcion = Convert.ToString(this.txtDescripcion.Text.Trim());
                    evento.Fecha_Inicio = Convert.ToDateTime(this.txtFechaInicio.Text.Trim());
                    evento.Fecha_fin = Convert.ToDateTime(this.txtFechaFin.Text.Trim());
                    evento.Hora_Inicio = TimeSpan.Parse(this.txtHoraInicio.Text.Trim());
                    evento.Hora_fin = TimeSpan.Parse(this.txtHoraFin.Text.Trim());
                    evento.Id_TipoEvento = byte.Parse(ddTipoEvento.Text);
                    evento.Comentario = "";
                    evento.Id_Estado = 1;
                    evento.Id_Lugar = byte.Parse(ddLugar.Text);
                    evento.Id_Lider = 9;

                    if(N_Solicitar_Evento.solicitarEvento(evento)==false)
                    {
                        ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('NO se pudo Registrar el evento');", true);
                        return;
                    }
                    operacion.Id_Evento = N_Solicitar_Evento.getUltimoIdEvento();
                    operacion.Id_Usuario = evento.Id_Lider;
                    operacion.Operacion = "Solicitar";
                    operacion.FechaOperacion = DateTime.Today.Date;
                    operacion.Motivo = "";
                    if (N_Solicitar_Evento.crearOperacionSolicitar(operacion) == false)
                    {
                        ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('No se pudo Registrar la operación');", true);
                        return;
                    }
                        
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Solicitud Enviada');", true);
                    Response.Redirect("W_Solicitar_Evento.aspx");
                }
                else ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + msjvalidacion + "');", true);

            }
            else ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + msjvalidarVacios + "');", true);
        }

        
        private void cargarComboTipoEvento()
        {
            List<T_TipoEvento> tiposEvento = N_Solicitar_Evento.listarTiposEvento();            
            //foreach(T_TipoEvento tipo in tiposEvento) 
            //{
            //    ddTipoEvento.Items.Add(tipo.TipoEvento);
            //}
            ddTipoEvento.DataSource = tiposEvento;
            ddTipoEvento.DataTextField = "TipoEvento";
            ddTipoEvento.DataValueField = "Id_TipoEvento";
            ddTipoEvento.DataBind();

        }
        private void cargarComboLugares()
        {

            List<T_Lugar> lugares = N_Solicitar_Evento.listarLugares();
            //foreach (T_Lugar lugar in lugares)
            //{
            //    ddLugar.Items.Add(lugar.Nombre);
            //}
            ddLugar.DataSource = lugares;
            ddLugar.DataTextField = "Lugar";
            ddLugar.DataValueField = "id_Lugar";
            ddLugar.DataBind();

        }
        public string validarVacios()
        {
            if (this.txtNombre.Text.Trim() == "")
            {
                return "Debe ingresar un nombre de evento";
            }
            else
                if (this.txtDescripcion.Text.Trim() == "")
                {
                    return "Hace falta una descripción";
                }
                else
                    if (txtFechaInicio.Text == "")
                    {
                        return "No ha ingresado la fecha inicio";
                    }
                    else
                        if (txtFechaFin.Text == "")
                        {

                            return "No ha ingresado la fecha fin";
                        }
                        else
                            if (txtHoraInicio.Text == "")
                            {

                                return "No ha ingresado la hora inicio";
                            }
                            else
                                if (txtHoraFin.Text == "")
                                {

                                    return "No ha ingresado la hora fin";
                                }
                                else
                                    if (DateTime.Parse(txtFechaInicio.Text) < DateTime.Today.Date)
                                    {
                                        return "Debe ingresar una fecha mayor al dia actual";
                                    }
                                    else if (DateTime.Parse(txtFechaFin.Text) < DateTime.Parse(txtFechaInicio.Text))
                                    {

                                        return "La fecha final debe ser mayor a la fecha de inicio";

                                    }
                                    else
                                        if (DateTime.Parse(txtFechaFin.Text) > DateTime.Parse(txtFechaInicio.Text))
                                        {
                                            TimeSpan semana = DateTime.Parse(txtFechaFin.Text).Subtract(DateTime.Parse(txtFechaInicio.Text));
                                            if (semana.TotalDays > 7)
                                            {
                                                soloUnaSemana = "Las fechas pueden tener como máximo una semana de duracion";
                                                return soloUnaSemana;

                                            }
                                            return "bien";
                                        }

                                        else
                                            return "bien";
        }
        public bool validarNombre(string input)
        {
            bool ver = true;
            char[] vec = input.ToCharArray();
            for (int i = 0; i < vec.Length; i++)
            {
                if (!Char.IsLetter(vec[i]) && vec[i] != ' ')
                {
                    ver = false;
                    break;
                }
            }
            return ver;
        }
        public string validarcamposregistro(string nombre, string descripcion)
        {

            string msjvalidacion = "";            
            if (!validarNombre(nombre)) msjvalidacion += "Debe ingresar solo letras en el nombre de evento\\n";
            return msjvalidacion;

        }
    }
}