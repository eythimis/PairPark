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
    
    public partial class clients
    {
        public clients()
        {
            this.refresh_tokens = new HashSet<refresh_tokens>();
        }
    
        public string id { get; set; }
        public string secret { get; set; }
        public string description { get; set; }
        public sbyte application_type { get; set; }
        public sbyte active { get; set; }
        public int refresh_token_lifetime_min { get; set; }
        public string allowed_origin { get; set; }
    
        public virtual ICollection<refresh_tokens> refresh_tokens { get; set; }
    }
}
