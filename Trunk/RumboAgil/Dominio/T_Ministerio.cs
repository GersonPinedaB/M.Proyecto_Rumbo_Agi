//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dominio
{
    using System;
    using System.Collections.Generic;
    
    public partial class T_Ministerio
    {
        public T_Ministerio()
        {
            this.T_Lider_Ministerio = new HashSet<T_Lider_Ministerio>();
            this.T_Miembro_Ministerio = new HashSet<T_Miembro_Ministerio>();
        }
    
        public byte Id_Ministerio { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
    
        public virtual ICollection<T_Lider_Ministerio> T_Lider_Ministerio { get; set; }
        public virtual ICollection<T_Miembro_Ministerio> T_Miembro_Ministerio { get; set; }
    }
}
