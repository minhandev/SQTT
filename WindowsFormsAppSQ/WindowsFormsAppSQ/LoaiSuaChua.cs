//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsAppSQ
{
    using System;
    using System.Collections.Generic;
    
    public partial class LoaiSuaChua
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LoaiSuaChua()
        {
            this.SuaChuas = new HashSet<SuaChua>();
        }
    
        public int MaLSC { get; set; }
        public string TenLoaiSuaChua { get; set; }
        public string LKThay { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SuaChua> SuaChuas { get; set; }
    }
}