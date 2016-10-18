using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using GestionDatos;

namespace Negocio
{
    public class N_Evaluar_Solicitud
    {
                
        public static bool actualizarEstadoAprobado(T_Evento evento)
        {            
            bool aux = true;
            try
            {
                D_Evento dEvento = new D_Evento();                
                dEvento.updpateEstadoAceptado(evento);
            }
            catch (Exception ex)
            {
                aux = false;
            }
            return aux;
        }
        public static bool actualizarEstadoRechazado(T_Evento evento)
        {
            bool aux = true;
            try
            {
                D_Evento dEvento = new D_Evento();                
                dEvento.updpateEstadoRechazado(evento);
            }
            catch (Exception ex)
            {               
                aux = false;
            }
            return aux;
        }
        public static T_Evento obtenerEventoPorNombre(string nombre)
        {
            D_Evento dEvento = new D_Evento();
            return dEvento.getEventoByNombre(nombre);
        }
        public static List<string> obtenerNombreEventos()
        {
            D_Evento dEvento = new D_Evento();
            return dEvento.getNombreEventos();
        }
        public static T_Persona obtenerPersonaPorId(short idPersona)
        {
            D_Persona dPersona = new D_Persona();
            return dPersona.getPersonaById(idPersona);
        }
    }
}