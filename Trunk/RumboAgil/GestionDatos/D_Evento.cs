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
        public DataTable getEventosCalendario()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("title");
            dt.Columns.Add("start");
            dt.Columns.Add("end");
            dt.Columns.Add("color");
            using (SqlConnection con = new SqlConnection("Data Source=FLEXY;Initial Catalog=BD_RumboAgil;Integrated Security=true"))
            {
                using (SqlCommand comando = new SqlCommand("select Nombre, Fecha_Inicio, Hora_Inicio, Fecha_Fin, Hora_Fin, Id_Estado from T_Evento", con))
                {
                    con.Open();
                    SqlDataReader dr = comando.ExecuteReader();
                    while (dr.Read())
                    {                        
                        DataRow fila = dt.NewRow();
                        fila["title"] = dr.GetString(0).ToString();
                        fila["start"] = dr.GetDateTime(1).ToString("yyyy/MM/dd");
                        fila["end"] = dr.GetDateTime(3).ToString("yyyy/MM/dd");
                        if (dr.GetByte(5) == 1) { fila["color"] = "#ffd800"; }
                        else if (dr.GetByte(5) == 3) { fila["color"] = "#0094ff"; }
                        else if (dr.GetByte(5) == 5) { fila["color"] = "#ff0000"; }
                        dt.Rows.Add(fila);
                    }
                    con.Close();
                }
            }
            return dt;
        }
        public List<string> getNombreEventos()
        {
            using (BD_RumboAgilEntities rumboAgil = new BD_RumboAgilEntities())
            {
                var nombres = (from c in rumboAgil.T_Evento select c.Nombre).ToList();
                return nombres;
            }
        }
        public bool updpateEstadoAceptado(T_Evento evento)
        {            
            using (BD_RumboAgilEntities rumboAgil = new BD_RumboAgilEntities())
            {
                bool aux = true;
                try
                {
                    var nuevoEvento = rumboAgil.T_Evento.Find(evento.Id_Evento);
                    nuevoEvento.Id_Estado = 3;
                    rumboAgil.SaveChanges();
                }catch(Exception ex){
                    aux = false;
                }
                return aux;
            }
        }
        public bool updpateEstadoRechazado(T_Evento evento)
        {
            using (BD_RumboAgilEntities rumboAgil = new BD_RumboAgilEntities())
            {
                bool aux = true;
                try
                {
                    var nuevoEvento = rumboAgil.T_Evento.Find(evento.Id_Evento);
                    nuevoEvento.Id_Estado = 5;
                    rumboAgil.SaveChanges();
                }
                catch (Exception ex)
                {
                    aux = false;
                }
                return aux;
            }
        }
        public bool insertEvento(T_Evento evento)
        {
            bool aux = true;
            using (BD_RumboAgilEntities rumboAgil = new BD_RumboAgilEntities())
            {
                try
                {
                    rumboAgil.T_Evento.Add(evento);
                    rumboAgil.SaveChanges();
                }
                catch (Exception ex)
                {
                    Console.Write(ex.Message);
                    aux = false;
                }                
            }
            return aux;
        }
        public short getUltimoIdEvento()
        {
            using (BD_RumboAgilEntities rumboAgil = new BD_RumboAgilEntities())
            {
                var evento = rumboAgil.T_Evento.OrderByDescending(c => c.Id_Evento).FirstOrDefault();
                return evento.Id_Evento;
            }
        }        
        public T_Evento getEventoByNombre(string nombre) 
        {
            using (BD_RumboAgilEntities rumboAgil = new BD_RumboAgilEntities())
            {
                var evento = rumboAgil.T_Evento.Where(c => c.Nombre == nombre).FirstOrDefault();
                return evento;
            }
        }
    }
}