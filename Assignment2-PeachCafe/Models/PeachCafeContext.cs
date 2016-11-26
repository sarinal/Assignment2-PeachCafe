namespace Assignment2_PeachCafe.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class PeachCafeContext : DbContext
    {
        public PeachCafeContext()
            : base("name=PeachCafeConnection")
        {
        }

        public virtual DbSet<Appetizer> Appetizers { get; set; }
        public virtual DbSet<Beverage> Beverages { get; set; }
        public virtual DbSet<Main> Mains { get; set; }
        public virtual DbSet<Sweet> Sweets { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Appetizer>()
                .Property(e => e.Price)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Beverage>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<Beverage>()
                .Property(e => e.Description)
                .IsFixedLength();

            modelBuilder.Entity<Beverage>()
                .Property(e => e.Price)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Main>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<Main>()
                .Property(e => e.Description)
                .IsFixedLength();

            modelBuilder.Entity<Main>()
                .Property(e => e.Price)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Sweet>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<Sweet>()
                .Property(e => e.Description)
                .IsFixedLength();

            modelBuilder.Entity<Sweet>()
                .Property(e => e.Price)
                .HasPrecision(10, 2);
        }
    }
}
