using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using GAR_FIAS_WorkerService.Repository.Models;
using GAR_FIAS_WorkerService.Helpers;

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
        public virtual DbSet<AsAddhouseType> AsAddhouseTypes { get; set; }
        public virtual DbSet<AsAddrObj> AsAddrObjs { get; set; }
        public virtual DbSet<AsAddrObjDivision> AsAddrObjDivisions { get; set; }
        public virtual DbSet<AsAddrObjParam> AsAddrObjParams { get; set; }
        public virtual DbSet<AsAddrObjType> AsAddrObjTypes { get; set; }
        public virtual DbSet<AsAdmHierarchy> AsAdmHierarchies { get; set; }
        public virtual DbSet<AsApartment> AsApartments { get; set; }
        public virtual DbSet<AsApartmentType> AsApartmentTypes { get; set; }
        public virtual DbSet<AsApartmentsParam> AsApartmentsParams { get; set; }
        public virtual DbSet<AsCarplace> AsCarplaces { get; set; }
        public virtual DbSet<AsCarplacesParam> AsCarplacesParams { get; set; }
        public virtual DbSet<AsChangeHistory> AsChangeHistories { get; set; }
        public virtual DbSet<AsHouse> AsHouses { get; set; }
        public virtual DbSet<AsHouseType> AsHouseTypes { get; set; }
        public virtual DbSet<AsHousesParam> AsHousesParams { get; set; }
        public virtual DbSet<AsHousesParamsOktmo> AsHousesParamsOktmos { get; set; }
        public virtual DbSet<AsHousesParamsPostalCode> AsHousesParamsPostalCodes { get; set; }
        public virtual DbSet<AsMunHierarchy> AsMunHierarchies { get; set; }
        public virtual DbSet<AsNormativeDoc> AsNormativeDocs { get; set; }
        public virtual DbSet<AsNormativeDocsKind> AsNormativeDocsKinds { get; set; }
        public virtual DbSet<AsNormativeDocsType> AsNormativeDocsTypes { get; set; }
        public virtual DbSet<AsObjectLevel> AsObjectLevels { get; set; }
        public virtual DbSet<AsOperationType> AsOperationTypes { get; set; }
        public virtual DbSet<AsParamType> AsParamTypes { get; set; }
        public virtual DbSet<AsReestrObject> AsReestrObjects { get; set; }
        public virtual DbSet<AsRoom> AsRooms { get; set; }
        public virtual DbSet<AsRoomType> AsRoomTypes { get; set; }
        public virtual DbSet<AsRoomsParam> AsRoomsParams { get; set; }
        public virtual DbSet<AsStead> AsSteads { get; set; }
        public virtual DbSet<AsSteadsParam> AsSteadsParams { get; set; }
        public virtual DbSet<HouseFia> HouseFias { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                string connectionString = ConfigurationHelper.GetSectionValue("ConnectionString");
                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AddressObjectLevel>(entity =>
            {
                entity.Property(e => e.AddressObjectLevelId).ValueGeneratedNever();
            });

            modelBuilder.Entity<AddressObjectLevelGar>(entity =>
            {
                entity.HasKey(e => e.GarLevelId)
                    .HasName("PK__AddressO__FC6866ADF5F5D745");

                entity.Property(e => e.GarLevelId).ValueGeneratedNever();
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

            modelBuilder.Entity<AsAddhouseType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<AsAddrObj>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Opertypeid).IsFixedLength();
            });

            modelBuilder.Entity<AsAddrObjDivision>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<AsAddrObjParam>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<AsAddrObjType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<AsApartment>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<AsApartmentType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<AsApartmentsParam>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<AsCarplace>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<AsCarplacesParam>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<AsChangeHistory>(entity =>
            {
                entity.HasKey(e => e.Changeid)
                    .HasName("PK__AS_CHANG__EAE0006CE4854E4F");

                entity.Property(e => e.Changeid).ValueGeneratedNever();
            });

            modelBuilder.Entity<AsHouse>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<AsHouseType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<AsHousesParam>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<AsHousesParamsOktmo>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<AsHousesParamsPostalCode>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<AsMunHierarchy>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<AsNormativeDoc>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<AsNormativeDocsKind>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<AsNormativeDocsType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<AsObjectLevel>(entity =>
            {
                entity.HasKey(e => e.Level)
                    .HasName("PK__AS_OBJEC__576DA3C1D025DA5F");

                entity.Property(e => e.Level).ValueGeneratedNever();
            });

            modelBuilder.Entity<AsOperationType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<AsParamType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<AsReestrObject>(entity =>
            {
                entity.HasKey(e => e.Objectid)
                    .HasName("PK__AS_REEST__F4B70D85B7FB4DD8");

                entity.Property(e => e.Objectid).ValueGeneratedNever();
            });

            modelBuilder.Entity<AsRoom>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<AsRoomType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<AsRoomsParam>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<AsStead>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<AsSteadsParam>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
