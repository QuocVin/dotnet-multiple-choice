//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DotNetTest.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MULTIPLE_CHOICE_Entities : DbContext
    {
        public MULTIPLE_CHOICE_Entities()
            : base("name=MULTIPLE_CHOICE_Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<answer> answers { get; set; }
        public virtual DbSet<exam> exams { get; set; }
        public virtual DbSet<question> questions { get; set; }
        public virtual DbSet<subject> subjects { get; set; }
        public virtual DbSet<user> users { get; set; }
        public virtual DbSet<score> scores { get; set; }
    }
}
