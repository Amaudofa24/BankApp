using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace BankApp.Models.DB_Model
{
    public partial class BankDb : DbContext
    {
        public BankDb()
            : base("name=BankDb")
        {
        }

        public virtual DbSet<Customerprofile> Customerprofiles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customerprofile>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<Customerprofile>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<Customerprofile>()
                .Property(e => e.MiddleName)
                .IsUnicode(false);
        }
    }
}
