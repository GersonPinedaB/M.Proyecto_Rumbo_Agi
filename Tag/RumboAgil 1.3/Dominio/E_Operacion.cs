using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class E_Operacion
    {
        private int idUsuario;

        public int IdUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }
        private int idEvento;

        public int IdEvento
        {
            get { return idEvento; }
            set { idEvento = value; }
        }
        private string operacion;

        public string Operacion
        {
            get { return operacion; }
            set { operacion = value; }
        }
        private DateTime fechaOperacion;

        public DateTime FechaOperacion
        {
            get { return fechaOperacion; }
            set { fechaOperacion = value; }
        }
        private string motivo;

        public string Motivo
        {
            get { return motivo; }
            set { motivo = value; }
        }

    }
}
