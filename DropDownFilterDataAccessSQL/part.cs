//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DropDownFilterDataAccessSQL
{
    using System;
    using System.Collections.Generic;
    
    public partial class part
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public part()
        {
            this.orderproducts = new HashSet<orderproduct>();
        }
    
        public string partno { get; set; }
        public string part_description { get; set; }
        public string partclass { get; set; }
        public Nullable<decimal> unitprice { get; set; }
        public string loc { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<orderproduct> orderproducts { get; set; }
    }
}
