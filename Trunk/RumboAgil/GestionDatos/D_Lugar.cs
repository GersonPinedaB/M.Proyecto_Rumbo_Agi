    using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace GestionDatos
{
    public class D_Lugar
    {
        public List<T_Lugar> getLugares()
        {
            using (BD_RumboAgilEntities rumboAgil = new BD_RumboAgilEntities())
            {
                return rumboAgil.T_Lugar.ToList();
            }
        }
        public T_Lugar getLugarByNombre(string nombre)
        {
            using (BD_RumboAgilEntities rumboAgil = new BD_RumboAgilEntities())
            {
                var lugar = rumboAgil.T_Lugar.Where(a => a.Lugar == nombre).FirstOrDefault();
                return lugar;
            }
        }
        public T_Lugar getLugarById(byte idLugar)
        {
            using (BD_RumboAgilEntities rumboAgil = new BD_RumboAgilEntities())
            {
                var lugar = rumboAgil.T_Lugar.Where(a => a.Id_Lugar == idLugar).FirstOrDefault();
                return lugar;
            }
        }
    }
}
