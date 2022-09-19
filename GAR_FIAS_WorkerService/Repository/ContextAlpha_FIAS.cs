using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using GAR_FIAS_WorkerService.Repository.Models;

#nullable disable

namespace GAR_FIAS_WorkerService.Repository
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

        public virtual DbSet<AddressObject> AddressObjects { get; set; }
        public virtual DbSet<AddressObjectLevel> AddressObjectLevels { get; set; }
        public virtual DbSet<AddressObjectLevelGar> AddressObjectLevelGars { get; set; }
        public virtual DbSet<AddressObjectLevelRecord> AddressObjectLevelRecords { get; set; }
        public virtual DbSet<AsAddrObj> AsAddrObjs { get; set; }
        public virtual DbSet<AsAddrObjDivision> AsAddrObjDivisions { get; set; }
        public virtual DbSet<AsAddrObjParam> AsAddrObjParams { get; set; }
        public virtual DbSet<AsAdmHierarchy> AsAdmHierarchies { get; set; }
        public virtual DbSet<AsApartment> AsApartments { get; set; }
        public virtual DbSet<AsApartmentsParam> AsApartmentsParams { get; set; }
        public virtual DbSet<AsCarplace> AsCarplaces { get; set; }
        public virtual DbSet<AsCarplacesParam> AsCarplacesParams { get; set; }
        public virtual DbSet<AsChangeHistory> AsChangeHistories { get; set; }
        public virtual DbSet<AsHouse> AsHouses { get; set; }
        public virtual DbSet<AsHousesParam> AsHousesParams { get; set; }
        public virtual DbSet<AsHousesParamsOktmo> AsHousesParamsOktmos { get; set; }
        public virtual DbSet<AsHousesParamsPostalCode> AsHousesParamsPostalCodes { get; set; }
        public virtual DbSet<AsMunHierarchy> AsMunHierarchies { get; set; }
        public virtual DbSet<AsNormativeDoc> AsNormativeDocs { get; set; }
        public virtual DbSet<AsReestrObject> AsReestrObjects { get; set; }
        public virtual DbSet<AsRoom> AsRooms { get; set; }
        public virtual DbSet<AsRoomsParam> AsRoomsParams { get; set; }
        public virtual DbSet<AsStead> AsSteads { get; set; }
        public virtual DbSet<AsSteadsParam> AsSteadsParams { get; set; }
        public virtual DbSet<HouseFia> HouseFias { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-F4DDTQQ\\SQLEXPRESS; Initial Catalog=Alpha_FIAS;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Cyrillic_General_CI_AS");

            modelBuilder.Entity<AddressObject>(entity =>
            {
                entity.Property(e => e.AddressObjectGuid).IsUnicode(false);

                entity.Property(e => e.Kladr).IsUnicode(false);

                entity.Property(e => e.Level).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.ParentAoguid).IsUnicode(false);

                entity.Property(e => e.TypeShortName).IsUnicode(false);
            });

            modelBuilder.Entity<AddressObjectLevel>(entity =>
            {
                entity.Property(e => e.AddressObjectLevelId).ValueGeneratedNever();

                entity.Property(e => e.AddressObjectLevelName).IsUnicode(false);
            });

            modelBuilder.Entity<AddressObjectLevelGar>(entity =>
            {
                entity.HasKey(e => e.GarLevelId)
                    .HasName("PK__AddressO__FC6866ADF5F5D745");

                entity.Property(e => e.GarLevelId).ValueGeneratedNever();

                entity.Property(e => e.GarLevelName).IsUnicode(false);
            });

            modelBuilder.Entity<AddressObjectLevelRecord>(entity =>
            {
                entity.HasKey(e => e.AddressObjectLevelId)
                    .HasName("PK__AddressO__0FF953B2924AC772");

                entity.Property(e => e.AddressObjectLevelId).ValueGeneratedNever();

                entity.HasOne(d => d.AddressObjectLevel)
                    .WithOne(p => p.AddressObjectLevelRecord)
                    .HasForeignKey<AddressObjectLevelRecord>(d => d.AddressObjectLevelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AddressObjectLevel_Record_AddressObjectLevel");

                entity.HasOne(d => d.GarLevel)
                    .WithMany(p => p.AddressObjectLevelRecords)
                    .HasForeignKey(d => d.GarLevelId)
                    .HasConstraintName("FK_AddressObjectLevel_AddressObjectLevelGar");
            });

            modelBuilder.Entity<AsAddrObj>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Level).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Objectguid).IsUnicode(false);

                entity.Property(e => e.Opertypeid)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Typename).IsUnicode(false);
            });

            modelBuilder.Entity<AsAddrObjDivision>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<AsAddrObjParam>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Value).IsUnicode(false);
            });

            modelBuilder.Entity<AsAdmHierarchy>(entity =>
            {
                entity.Property(e => e.Areacode).IsUnicode(false);

                entity.Property(e => e.Citycode).IsUnicode(false);

                entity.Property(e => e.Placecode).IsUnicode(false);

                entity.Property(e => e.Plancode).IsUnicode(false);

                entity.Property(e => e.Regioncode).IsUnicode(false);

                entity.Property(e => e.Streetcode).IsUnicode(false);
            });

            modelBuilder.Entity<AsApartment>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Number).IsUnicode(false);

                entity.Property(e => e.Objectguid).IsUnicode(false);
            });

            modelBuilder.Entity<AsApartmentsParam>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Value).IsUnicode(false);
            });

            modelBuilder.Entity<AsCarplace>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Number).IsUnicode(false);

                entity.Property(e => e.Objectguid).IsUnicode(false);
            });

            modelBuilder.Entity<AsCarplacesParam>(entity =>
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

            modelBuilder.Entity<AsHouse>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Addnum1).IsUnicode(false);

                entity.Property(e => e.Addnum2).IsUnicode(false);

                entity.Property(e => e.Housenum).IsUnicode(false);

                entity.Property(e => e.Objectguid).IsUnicode(false);
            });

            modelBuilder.Entity<AsHousesParam>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Value).IsUnicode(false);
            });

            modelBuilder.Entity<AsHousesParamsOktmo>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Value).IsUnicode(false);
            });

            modelBuilder.Entity<AsHousesParamsPostalCode>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Value).IsUnicode(false);
            });

            modelBuilder.Entity<AsMunHierarchy>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Oktmo).IsUnicode(false);
            });

            modelBuilder.Entity<AsNormativeDoc>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Number).IsUnicode(false);

                entity.Property(e => e.Orgname).IsUnicode(false);

                entity.Property(e => e.Regnum).IsUnicode(false);
            });

            modelBuilder.Entity<AsReestrObject>(entity =>
            {
                entity.HasKey(e => e.Objectid)
                    .HasName("PK__AS_REEST__F4B70D85B7FB4DD8");

                entity.Property(e => e.Objectid).ValueGeneratedNever();

                entity.Property(e => e.Objectguid).IsUnicode(false);
            });

            modelBuilder.Entity<AsRoom>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Objectguid).IsUnicode(false);

                entity.Property(e => e.Roomnumber).IsUnicode(false);
            });

            modelBuilder.Entity<AsRoomsParam>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Value).IsUnicode(false);
            });

            modelBuilder.Entity<AsStead>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Number).IsUnicode(false);

                entity.Property(e => e.Objectguid).IsUnicode(false);
            });

            modelBuilder.Entity<AsSteadsParam>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Value).IsUnicode(false);
            });

            modelBuilder.Entity<HouseFia>(entity =>
            {
                entity.Property(e => e.AoGuid).IsUnicode(false);

                entity.Property(e => e.BuildNum).IsUnicode(false);

                entity.Property(e => e.HouseFiasGuid).IsUnicode(false);

                entity.Property(e => e.HouseNum).IsUnicode(false);

                entity.Property(e => e.Oktmo).IsUnicode(false);

                entity.Property(e => e.PostalCode).IsUnicode(false);

                entity.Property(e => e.StrucNum).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
