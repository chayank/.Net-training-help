//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Capstone.Model.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Stock
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Stock()
        {
            this.StocksPrice = new HashSet<StocksPrice>();
        }
    
        public int stockId { get; set; }
        public string stockName { get; set; }
        public Nullable<int> quantity { get; set; }
        public Nullable<int> quantity_remaining { get; set; }
        public Nullable<int> addedBy { get; set; }
        public string status { get; set; }
    
        public virtual User User { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StocksPrice> StocksPrice { get; set; }
    }
}