//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjektDM_13185
{
    using System;
    using System.Collections.Generic;
    
    public partial class Dzial
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Dzial()
        {
            this.Pracownik = new HashSet<Pracownik>();
        }
    
        public int id { get; set; }
        public string dzial1 { get; set; }
        public string stanowisko { get; set; }
        public Nullable<decimal> wyplata { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pracownik> Pracownik { get; set; }
    }
}
