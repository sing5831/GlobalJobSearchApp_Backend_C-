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
    
    public partial class orderproduct
    {
        public string orderno { get; set; }
        public string partno { get; set; }
        public Nullable<int> orderqty { get; set; }
        public Nullable<decimal> orderprice { get; set; }
    
        public virtual order order { get; set; }
        public virtual part part { get; set; }
    }
}
