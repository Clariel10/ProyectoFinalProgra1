//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VENTAS.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Compra
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Compra()
        {
            this.Detalle_Compra = new HashSet<Detalle_Compra>();
        }
    
        public int id_compra { get; set; }
        public int id_empleado { get; set; }
        public Nullable<decimal> total_compra { get; set; }
        public Nullable<System.DateTime> fecha { get; set; }
    
        public virtual Empleado Empleado { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Detalle_Compra> Detalle_Compra { get; set; }
    }
}
