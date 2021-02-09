using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace MyProject.Models
{
    public partial class MyProjectDBContext : DbContext
    {
        public MyProjectDBContext()
        {
        }

        public MyProjectDBContext(DbContextOptions<MyProjectDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Account { get; set; }
     
        public virtual DbSet<PAccView> PAccView { get; set; }       
        public virtual DbSet<Repport> Repport { get; set; }    
        public virtual DbSet<TAccount> TAccount { get; set; }                
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<ItemView> ItemView { get; set; }
        public virtual DbSet<Journal> Journals { get; set; }
        public virtual DbSet<Months> Months { get; set; }
        public virtual DbSet<Periods> Periods { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=localhost;Database=MyProjectDB;Uid=SA;Pwd=Debian19+");
                //var builder = new ConfigurationBuilder()
                //    .SetBasePath(Directory.GetCurrentDirectory())
                //    .AddJsonFile("appsettings.json");
                //var configuration = builder.Build();
                //optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Account>(entity =>
            {
                entity.HasKey(e => e.AccId)
                    .HasName("PK__Account__91CBC3787C9437F5");
            });
            modelBuilder.Entity<TAccount>(entity =>
            {
                entity.HasKey(e => e.AccId)
                    .HasName("PK__Account__91CBC3787C9437F5");
            }); 
            modelBuilder.Entity<Repport>(entity =>
            {
                entity.HasNoKey();
            });                        
            modelBuilder.Entity<PAccView>(entity =>
            {
                entity.HasNoKey();
            });            
            modelBuilder.Entity<Item>(entity =>
            {
                entity.HasKey(e => e.ItemId)
                    .HasName("PK__Account__91CBC3787C9437F5");

                entity.Property(e => e.ItemId);
                entity.Property(e => e.ItemDesc).HasMaxLength(255);

                entity.Property(e => e.ItemBudget);
            });
            modelBuilder.Entity<ItemView>(entity =>
            {
                entity.HasKey(e => e.ItemId)
                    .HasName("PK__Account__91CBC3787C9437F5");

                entity.Property(e => e.ItemId);
                entity.Property(e => e.ItemDesc).HasMaxLength(255);

                entity.Property(e => e.ItemBudget);
                entity.Property(e => e.ItemMoNam).HasMaxLength(255);
                entity.Property(e => e.ItemYMNam).HasMaxLength(255);
                
            });
            modelBuilder.Entity<Journal>(entity =>
            {
                entity.HasKey(e => e.JourId)
                    .HasName("PK__Journal__35D05AA2BD484B64");
            });
            modelBuilder.Entity<Months>(entity =>
            {
                entity.HasKey(e => e.MoId)
                    .HasName("PK__Account__91CBC3787C9437F5");

                entity.Property(e => e.MoId);

                entity.Property(e => e.MoNum);                
                entity.Property(e => e.MoNam).HasMaxLength(25);

            });
            modelBuilder.Entity<Periods>(entity =>
            {
                entity.HasKey(e => e.PerId)
                    .HasName("PK__Account__91CBC3787C9437F5");

                entity.Property(e => e.PerId);

                entity.Property(e => e.PerNum);                
                entity.Property(e => e.PerNam).HasMaxLength(25);

            });            
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
