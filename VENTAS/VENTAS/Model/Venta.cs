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
    
    public partial class Venta
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Venta()
        {
            this.Detalle_Venta = new HashSet<Detalle_Venta>();
        }
    
        public int id_venta { get; set; }
        public int id_empleado { get; set; }
        public int id_cliente { get; set; }
        public int id_documento { get; set; }
        public Nullable<decimal> total_venta { get; set; }
        public Nullable<System.DateTime> fecha { get; set; }
    
        public virtual Cliente Cliente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Detalle_Venta> Detalle_Venta { get; set; }
        public virtual Empleado Empleado { get; set; }
        public virtual Tipo_Documentos Tipo_Documentos { get; set; }
    }
}