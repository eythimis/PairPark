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
    
    public partial class cars
    {
        public int id { get; set; }
        public string plate { get; set; }
        public string color { get; set; }
        public string brand { get; set; }
        public int cartype_id { get; set; }
        public int driver_id { get; set; }
    
        public virtual car_types car_types { get; set; }
        public virtual drivers drivers { get; set; }
    }
}
