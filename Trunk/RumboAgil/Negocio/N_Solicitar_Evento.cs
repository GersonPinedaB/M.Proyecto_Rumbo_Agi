using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using GestionDatos;

namespace Negocio
{
    public class N_Solicitar_Evento
    {

        public static bool solicitarEvento(T_Evento evento)
        {
            D_Evento dEvento = new D_Evento();
            evento.Id_Estado = 1;
            return dEvento.insertEvento(evento);
        }

        public static List<T_Lugar> listarLugares()
        {
            D_Lugar dLugar = new D_Lugar();
            return dLugar.getLugares();
        }
        public static bool crearOperacionSolicitar(T_Operacion operacion){
            D_Operacion dOpe = new D_Operacion();
            return dOpe.insertOperacion(operacion);
        }
        public static List<T_TipoEvento> listarTiposEvento()
        {
            D_TipoEvento dTipoEv = new D_TipoEvento();
            return dTipoEv.getTiposEvento();
        }
        public static T_Lugar obtenerLugarPorNombre(string nombre)
        {
            D_Lugar lugar = new D_Lugar();
            return lugar.getLugarByNombre(nombre);
        }
        public static T_TipoEvento obtenerTipoPorNombre(string tipoEvento)
        {
            D_TipoEvento tipo = new D_TipoEvento();
            return tipo.getTipoByNombre(tipoEvento);
        }
        public static short getUltimoIdEvento()
        {
            D_Evento evento = new D_Evento();
            return evento.getUltimoIdEvento();
        }
        public static T_Lugar obtenerLugarPorId(byte idLugar)
        {
            D_Lugar lugar = new D_Lugar();
            return lugar.getLugarById(idLugar);
        }
        public static T_TipoEvento obtenerTipoPorId(byte idTipo)
        {
            D_TipoEvento tipo = new D_TipoEvento();
            return tipo.getTipoById(idTipo);
        }
    }
}
