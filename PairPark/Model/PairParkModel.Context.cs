﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class pairparkEntities : DbContext
    {
        public pairparkEntities()
            : base("name=pairparkEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<car_types> car_types { get; set; }
        public virtual DbSet<cars> cars { get; set; }
        public virtual DbSet<drivers> drivers { get; set; }
        public virtual DbSet<clients> clients { get; set; }
        public virtual DbSet<refresh_tokens> refresh_tokens { get; set; }
    }
}
