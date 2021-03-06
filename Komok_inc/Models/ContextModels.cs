namespace Komok_inc.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ContextModels : DbContext
    {
        public ContextModels()
            : base("name=ContextModels")
        {
        }

        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<ClothesData> ClothesData { get; set; }
        public virtual DbSet<Gender> Gender { get; set; }
        public virtual DbSet<Provider> Provider { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Provider>()
                .Property(e => e.Email)
                .IsUnicode(false);
        }
    }
}
