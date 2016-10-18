using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Dominio;
using GestionDatos;


namespace Negocio
{
    public class N_Solicitar_Evento
    {
        Dominio.E_Evento objSolE = new Dominio.E_Evento();
        GestionDatos.D_Evento objSol = new GestionDatos.D_Evento();
         
        public String SolicitarEvento(string NombreEvento,string Descripcion, DateTime FechaInicio, string HoraInicio, DateTime Fechafin, string HoraFin, string comentario,int Estado, string TipoEvento ,string Lugar, int idlider)
        {
            try
            {
                objSolE.NombreEvento= NombreEvento;
                objSolE.Descripcion = Descripcion;
                objSolE.FechaInicio = FechaInicio;
                objSolE.HoraInicio = HoraInicio;
                objSolE.FechaFin = Fechafin;
                objSolE.HoraFin = HoraFin;
                objSolE.Comentario = comentario;
                objSolE.Estado = Estado;
                objSolE.IdTipoEvento = TipoEvento;
                objSolE.IdLugar = Lugar;
                objSolE.IdLider = idlider;
                return objSol.insertEvento(objSolE);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        }

    }




