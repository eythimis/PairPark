//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PairPark.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class drivers
    {
        public drivers()
        {
            this.cars = new HashSet<cars>();
            this.refresh_tokens = new HashSet<refresh_tokens>();
        }
    
        public int id { get; set; }
        public string nickname { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public Nullable<sbyte> active { get; set; }
        public Nullable<System.DateTime> inactive_until { get; set; }
        public Nullable<int> fault_points { get; set; }
        public Nullable<sbyte> deleted { get; set; }
        public string tes { get; set; }
    
        public virtual ICollection<cars> cars { get; set; }
        public virtual ICollection<refresh_tokens> refresh_tokens { get; set; }
    }
}
