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
    
    public partial class T_TipoEvento
    {
        public T_TipoEvento()
        {
            this.T_Evento = new HashSet<T_Evento>();
        }
    
        public byte Id_TipoEvento { get; set; }
        public string TipoEvento { get; set; }
    
        public virtual ICollection<T_Evento> T_Evento { get; set; }
    }
}
