using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class E_Evento
    {
        private int estado;

        public int Estado
        {
            get { return estado; }
            set { estado = value; }
        }
        private string nombreEvento;

        public string NombreEvento
        {
            get { return nombreEvento; }
            set { nombreEvento = value; }
        }
        private string descripcion;

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        private string comentario;

        public string Comentario
        {
            get { return comentario; }
            set { comentario = value; }
        }
        private DateTime fechaInicio;

        public DateTime FechaInicio
        {
            get { return fechaInicio; }
            set { fechaInicio = value; }
        }
        private string horaInicio;

        public string HoraInicio
        {
            get { return horaInicio; }
            set { horaInicio = value; }
        }
        private DateTime fechaFin;

        public DateTime FechaFin
        {
            get { return fechaFin; }
            set { fechaFin = value; }
        }
        private string horaFin;

        public string HoraFin
        {
            get { return horaFin; }
            set { horaFin = value; }
        }
        private int idLider;

        public int IdLider
        {
            get { return idLider; }
            set { idLider = value; }
        }
        
        private string idLugar;

        public string IdLugar
        {
            get { return idLugar; }
            set { idLugar = value; }
        }

        private string idTipoEvento;

        public string IdTipoEvento
        {
            get { return idTipoEvento; }
            set { idTipoEvento = value; }
        }

}
    }