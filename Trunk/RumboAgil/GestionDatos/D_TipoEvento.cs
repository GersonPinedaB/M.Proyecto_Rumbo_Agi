    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace GestionDatos
{
    public class D_TipoEvento
    {
        public List<T_TipoEvento> getTiposEvento()
        {
            using (BD_RumboAgilEntities rumboAgil = new BD_RumboAgilEntities())
            {
                return rumboAgil.T_TipoEvento.ToList();
            }
        }
        public T_TipoEvento getTipoByNombre(string tipoEvento)
        {
            using (BD_RumboAgilEntities rumboAgil = new BD_RumboAgilEntities())
            {
                var tipo = rumboAgil.T_TipoEvento.Where(a => a.TipoEvento == tipoEvento).FirstOrDefault();
                return tipo;
            }
        }
        public T_TipoEvento getTipoById(byte idTipo)
        {
            using (BD_RumboAgilEntities rumboAgil = new BD_RumboAgilEntities())
            {
                var tipo = rumboAgil.T_TipoEvento.Where(a => a.Id_TipoEvento == idTipo).FirstOrDefault();
                return tipo;
            }
        }
    }
}
