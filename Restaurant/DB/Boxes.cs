//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Restaurant.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Boxes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Boxes()
        {
            this.Accounts = new HashSet<Accounts>();
        }
    
        public int Id { get; set; }
        public int RestaurantId { get; set; }
        public Nullable<byte> Number { get; set; }
        public bool Status { get; set; }
        public System.DateTime CreatedAt { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Accounts> Accounts { get; set; }
        public virtual Restaurants Restaurants { get; set; }
    }
}
