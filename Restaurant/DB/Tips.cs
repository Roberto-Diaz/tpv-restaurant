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
    
    public partial class Tips
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public Nullable<decimal> Quantity { get; set; }
        public Nullable<System.DateTime> CreatedAt { get; set; }
    
        public virtual Accounts Accounts { get; set; }
    }
}
