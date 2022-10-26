using System;
using System.Data.Entity;
using System.Linq;

namespace Code_first.Models
{
    public class Okul : DbContext
    {
        
        public Okul()
            : base("name=Okul")
        {
        }

       public virtual DbSet<Ogrenci> ogrenciler { get; set; }
       public virtual DbSet<Not> notlar { get; set; }  
       public virtual DbSet<Ders> dersler { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ogrenci>()
                 .HasMany(x => x.notlar)
                 .WithRequired(x => x.ogrenci)
                 .WillCascadeOnDelete(true);
            modelBuilder.Entity<Ogrenci>().Property(x => x.dog_tar).HasColumnType("smalldatetime");

            modelBuilder.Entity<Ders>()
                .HasMany(x => x.notlar)
                .WithRequired(x => x.Ders);
          
        }

    }




  
}