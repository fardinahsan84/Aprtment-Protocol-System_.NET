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
    
    public partial class rentHolders_member
    {
        public int id { get; set; }
        public string fullname { get; set; }
        public string flat_no { get; set; }
        public string relation { get; set; }
        public string photo { get; set; }
        public int rentHolder_id { get; set; }
        public string status { get; set; }
    
        public virtual rent_holder rent_holder { get; set; }
    }
}
