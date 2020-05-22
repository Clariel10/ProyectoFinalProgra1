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
    
    public partial class Producto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Producto()
        {
            this.Creditos_Fiscales = new HashSet<Creditos_Fiscales>();
            this.facturas = new HashSet<factura>();
            this.Facturas_Compras = new HashSet<Facturas_Compras>();
            this.Tickets = new HashSet<Ticket>();
        }
    
        public int id_producto { get; set; }
        public Nullable<int> id_categoria { get; set; }
        public Nullable<int> id_proveedor { get; set; }
        public string nombre_producto { get; set; }
        public Nullable<int> cantidad { get; set; }
        public Nullable<decimal> costo { get; set; }
        public Nullable<decimal> precio_venta { get; set; }
    
        public virtual Categoria Categoria { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Creditos_Fiscales> Creditos_Fiscales { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<factura> facturas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Facturas_Compras> Facturas_Compras { get; set; }
        public virtual Proveedore Proveedore { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
