//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Celibate_Music_API_MAIN.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Customer2177
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customer2177()
        {
            this.Sale2177 = new HashSet<Sale2177>();
        }
    
        public int CUSTOMERID { get; set; }
        public string NAME { get; set; }
        public string ADDRESS { get; set; }
        public Nullable<int> POSTCODE { get; set; }
        public string INTERESTCODE { get; set; }
    
        public virtual Interest2177 Interest2177 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sale2177> Sale2177 { get; set; }
    }
}
