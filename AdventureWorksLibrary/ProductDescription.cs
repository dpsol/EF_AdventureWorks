//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AdventureWorksLibrary
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProductDescription
    {
        public ProductDescription()
        {
            this.ProductModelProductDescription = new HashSet<ProductModelProductDescription>();
        }
    
        public int ProductDescriptionID { get; set; }
        public string Description { get; set; }
        public System.Guid rowguid { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    
        public virtual ICollection<ProductModelProductDescription> ProductModelProductDescription { get; set; }
    }
}
