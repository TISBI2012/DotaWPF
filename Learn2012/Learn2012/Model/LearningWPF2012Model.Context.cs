﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Learn2012.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class LearningWPF2012Entities : DbContext
    {
        public LearningWPF2012Entities()
            : base("name=LearningWPF2012Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AttackType> AttackType { get; set; }
        public virtual DbSet<Hero> Hero { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}