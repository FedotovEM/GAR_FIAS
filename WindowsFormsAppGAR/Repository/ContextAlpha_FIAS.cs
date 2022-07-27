using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using WindowsFormsAppGAR.Repository.Models;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WindowsFormsAppGAR.Repository
{
    public partial class ContextAlpha_FIAS : DbContext
    {
        public ContextAlpha_FIAS()
        {
        }

        public ContextAlpha_FIAS(DbContextOptions<ContextAlpha_FIAS> options)
            : base(options)
        {
        }

        public virtual DbSet<AsAddrObj> AsAddrObj { get; set; }
        public virtual DbSet<AsAddrObjDivision> AsAddrObjDivision { get; set; }
        public virtual DbSet<AsAddrObjParams> AsAddrObjParams { get; set; }
        public virtual DbSet<AsAdmHierarchy> AsAdmHierarchy { get; set; }
        public virtual DbSet<AsApartments> AsApartments { get; set; }
        public virtual DbSet<AsApartmentsParams> AsApartmentsParams { get; set; }
        public virtual DbSet<AsCarplaces> AsCarplaces { get; set; }
        public virtual DbSet<AsCarplacesParams> AsCarplacesParams { get; set; }
        public virtual DbSet<AsChangeHistory> AsChangeHistory { get; set; }
        public virtual DbSet<AsHouses> AsHouses { get; set; }
        public virtual DbSet<AsHousesParams> AsHousesParams { get; set; }
        public virtual DbSet<AsMunHierarchy> AsMunHierarchy { get; set; }
        public virtual DbSet<AsNormativeDocs> AsNormativeDocs { get; set; }
        public virtual DbSet<AsReestrObjects> AsReestrObjects { get; set; }
        public virtual DbSet<AsRooms> AsRooms { get; set; }
        public virtual DbSet<AsRoomsParams> AsRoomsParams { get; set; }
        public virtual DbSet<AsSteads> AsSteads { get; set; }
        public virtual DbSet<AsSteadsParams> AsSteadsParams { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-F4DDTQQ\\SQLEXPRESS; Initial Catalog=Alpha_FIAS;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AsAddrObj>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Level).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Objectguid).IsUnicode(false);

                entity.Property(e => e.Opertypeid)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Typename).IsUnicode(false);
            });

            modelBuilder.Entity<AsAddrObjDivision>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<AsAddrObjParams>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Value).IsUnicode(false);
            });

            modelBuilder.Entity<AsAdmHierarchy>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Areacode).IsUnicode(false);

                entity.Property(e => e.Citycode).IsUnicode(false);

                entity.Property(e => e.Placecode).IsUnicode(false);

                entity.Property(e => e.Plancode).IsUnicode(false);

                entity.Property(e => e.Regioncode).IsUnicode(false);

                entity.Property(e => e.Streetcode).IsUnicode(false);
            });

            modelBuilder.Entity<AsApartments>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Number).IsUnicode(false);

                entity.Property(e => e.Objectguid).IsUnicode(false);
            });

            modelBuilder.Entity<AsApartmentsParams>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Value).IsUnicode(false);
            });

            modelBuilder.Entity<AsCarplaces>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Number).IsUnicode(false);

                entity.Property(e => e.Objectguid).IsUnicode(false);
            });

            modelBuilder.Entity<AsCarplacesParams>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Value).IsUnicode(false);
            });

            modelBuilder.Entity<AsChangeHistory>(entity =>
            {
                entity.HasKey(e => e.Changeid)
                    .HasName("PK__AS_CHANG__EAE0006CE4854E4F");

                entity.Property(e => e.Changeid).ValueGeneratedNever();

                entity.Property(e => e.Adrobjectid).IsUnicode(false);
            });

            modelBuilder.Entity<AsHouses>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Addnum1).IsUnicode(false);

                entity.Property(e => e.Addnum2).IsUnicode(false);

                entity.Property(e => e.Housenum).IsUnicode(false);

                entity.Property(e => e.Objectguid).IsUnicode(false);
            });

            modelBuilder.Entity<AsHousesParams>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Value).IsUnicode(false);
            });

            modelBuilder.Entity<AsMunHierarchy>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Oktmo).IsUnicode(false);
            });

            modelBuilder.Entity<AsNormativeDocs>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Number).IsUnicode(false);

                entity.Property(e => e.Orgname).IsUnicode(false);

                entity.Property(e => e.Regnum).IsUnicode(false);
            });

            modelBuilder.Entity<AsReestrObjects>(entity =>
            {
                entity.HasKey(e => e.Objectid)
                    .HasName("PK__AS_REEST__F4B70D85B7FB4DD8");

                entity.Property(e => e.Objectid).ValueGeneratedNever();

                entity.Property(e => e.Objectguid).IsUnicode(false);
            });

            modelBuilder.Entity<AsRooms>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Objectguid).IsUnicode(false);

                entity.Property(e => e.Roomnumber).IsUnicode(false);
            });

            modelBuilder.Entity<AsRoomsParams>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Value).IsUnicode(false);
            });

            modelBuilder.Entity<AsSteads>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Number).IsUnicode(false);

                entity.Property(e => e.Objectguid).IsUnicode(false);
            });

            modelBuilder.Entity<AsSteadsParams>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Value).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
