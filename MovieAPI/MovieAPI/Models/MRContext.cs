using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MovieAPI.Models
{
    public partial class MRContext : DbContext
    {
        public MRContext()
        {
        }

        public MRContext(DbContextOptions<MRContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Actors> Actors { get; set; }
        public virtual DbSet<ActorsMovie> ActorsMovie { get; set; }
        public virtual DbSet<Movies> Movies { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("server=127.0.0.1;database=MR;user id=root;password=nzec3ecz", x => x.ServerVersion("8.0.15-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actors>(entity =>
            {
                entity.HasIndex(e => e.Cnp)
                    .HasName("CNP_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Age).HasColumnType("int(11)");

                entity.Property(e => e.Cnp)
                    .IsRequired()
                    .HasColumnName("CNP")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            modelBuilder.Entity<ActorsMovie>(entity =>
            {
                entity.HasKey(e => new { e.MovieFkId, e.AcotorFkId })
                    .HasName("PRIMARY");

                entity.ToTable("Actors-Movie");

                entity.HasIndex(e => e.AcotorFkId)
                    .HasName("ActorFK_idx");

                entity.Property(e => e.MovieFkId)
                    .HasColumnName("Movie_FK_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AcotorFkId)
                    .HasColumnName("Acotor_FK_ID")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Movies>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("Name_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Crew)
                    .IsRequired()
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Location)
                    .IsRequired()
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.IsAdmin)
                    .IsRequired()
                    .HasColumnName("isAdmin")
                    .HasColumnType("varchar(2)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
