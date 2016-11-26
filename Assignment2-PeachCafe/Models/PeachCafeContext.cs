namespace Assignment2_PeachCafe.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class PeachCafeContext : DbContext
    {
        public PeachCafeContext()
            : base("name=PeachCafeConnect")
        {
        }

        public virtual DbSet<FoodItem> FoodItems { get; set; }
        public virtual DbSet<MenuCourse> MenuCourses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FoodItem>()
                .Property(e => e.Price)
                .HasPrecision(10, 2);

            modelBuilder.Entity<FoodItem>()
                .Property(e => e.ImageUrl)
                .IsUnicode(false);

            modelBuilder.Entity<MenuCourse>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<MenuCourse>()
                .HasMany(e => e.FoodItems)
                .WithRequired(e => e.MenuCourse)
                .WillCascadeOnDelete(false);
        }
    }
}
