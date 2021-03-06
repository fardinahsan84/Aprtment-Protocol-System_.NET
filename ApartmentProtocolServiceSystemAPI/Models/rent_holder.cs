//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ApartmentProtocolServiceSystemAPI.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class rent_holder
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public rent_holder()
        {
            this.rentHolders_member = new HashSet<rentHolders_member>();
            this.rentHolders_servant = new HashSet<rentHolders_servant>();
        }
    
        public int id { get; set; }
        public string fullname { get; set; }
        public string fathersname { get; set; }
        public string flat_no { get; set; }
        public string type { get; set; }
        public string phonenumber { get; set; }
        public string nidnumber { get; set; }
        public System.DateTime dateofbirth { get; set; }
        public string email { get; set; }
        public bool isemailveryfied { get; set; }
        public System.Guid activationcode { get; set; }
        public string password { get; set; }
        public string photo { get; set; }
        public int user_id { get; set; }
        public string status { get; set; }
    
        public virtual user user { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<rentHolders_member> rentHolders_member { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<rentHolders_servant> rentHolders_servant { get; set; }
    }
}
