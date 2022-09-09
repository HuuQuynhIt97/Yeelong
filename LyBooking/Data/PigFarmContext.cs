using System;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata;
using LyBooking.Helpers;
using LyBooking.Models;

#nullable disable

namespace LyBooking.Data
{
    public partial class PigFarmContext : DbContext
    {
        private readonly IHttpContextAccessor _contextAccessor;

        public PigFarmContext(DbContextOptions<PigFarmContext> options, IHttpContextAccessor contextAccessor = null) : base(options)
        {
            _contextAccessor = contextAccessor;
        }

        public virtual DbSet<Chemical> Chemicals { get; set; }
        public virtual DbSet<Glue> Glues { get; set; }
        public virtual DbSet<GlueChemical> GlueChemicals { get; set; }
        public virtual DbSet<Shoe> Shoes { get; set; }
        public virtual DbSet<ShoeGlue> ShoeGlues { get; set; }
        public virtual DbSet<HallTime> HallTimes { get; set; }
        public virtual DbSet<Hall> Halls { get; set; }
        public virtual DbSet<WorkOrder> WorkOrders { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<Site> Sites { get; set; }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<AccountGroup> AccountGroups { get; set; }
        public virtual DbSet<AccountPermission> AccountPermissions { get; set; }
        public virtual DbSet<AccountRole> AccountRoles { get; set; }
        public virtual DbSet<AccountType> AccountTypes { get; set; }
        public virtual DbSet<CodeHelp> CodeHelps { get; set; }
        public virtual DbSet<CodePermission> CodePermissions { get; set; }
        public virtual DbSet<CodePermission1> CodePermissions1 { get; set; }
        public virtual DbSet<CodeServiceType> CodeServiceTypes { get; set; }
        public virtual DbSet<CodeType> CodeTypes { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Dashboard> Dashboards { get; set; }
        public virtual DbSet<EmailPool> EmailPools { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Oc> Ocs { get; set; }
        public virtual DbSet<RefreshToken> RefreshTokens { get; set; }
        public virtual DbSet<SysConfig> SysConfigs { get; set; }
        public virtual DbSet<SysLogGp> SysLogGps { get; set; }
        public virtual DbSet<SysLogUser> SysLogUsers { get; set; }
        public virtual DbSet<SysMenu> SysMenus { get; set; }
        public virtual DbSet<SystemConfig> SystemConfigs { get; set; }
        public virtual DbSet<SystemLanguage> SystemLanguages { get; set; }
        public virtual DbSet<SystemLogUser> SystemLogUsers { get; set; }
        public virtual DbSet<UserConfig> UserConfigs { get; set; }
        public virtual DbSet<XAccount> XAccounts { get; set; }
        public virtual DbSet<XAccountGroup> XAccountGroups { get; set; }
        public virtual DbSet<XAccountPermission> XAccountPermissions { get; set; }
        public virtual DbSet<XAccountRole> XAccountRoles { get; set; }
        public virtual DbSet<XAccountSetting> XAccountSettings { get; set; }


        public virtual DbSet<StoredProcedure> StoredProcedures { get; set; }

        public virtual DbSet<Booking> Bookings { get; set; }
        public virtual DbSet<BookingDetail> BookingDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Chinese_Taiwan_Stroke_CI_AS");
            //modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");


            modelBuilder.Entity<Chemical>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.CreateBy)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("CREATE_BY");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.DeleteBy)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("DELETE_BY");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("datetime")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.Guid)
                    .HasMaxLength(40)
                    .HasColumnName("GUID");

                entity.Property(e => e.Status)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("STATUS");

                entity.Property(e => e.UpdateBy)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("UPDATE_BY");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UPDATE_DATE");
            });

            modelBuilder.Entity<Glue>(entity =>
            {
                entity.Property(e => e.Id)
                   .HasColumnType("numeric(18, 0)")
                   .ValueGeneratedOnAdd()
                   .HasColumnName("ID");

                entity.Property(e => e.CreateBy)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("CREATE_BY");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.DeleteBy)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("DELETE_BY");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("datetime")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.Guid)
                    .HasMaxLength(40)
                    .HasColumnName("GUID");
                entity.Property(e => e.Unit)
                    .HasMaxLength(50)
                    .HasColumnName("UNIT");

                entity.Property(e => e.Status)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("STATUS");

                entity.Property(e => e.UpdateBy)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("UPDATE_BY");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UPDATE_DATE");
            });

            modelBuilder.Entity<GlueChemical>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.ChemicalGuid)
                    .HasMaxLength(40)
                    .HasColumnName("Chemical_GUID");

                entity.Property(e => e.CreateBy)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("CREATE_BY");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.DeleteBy)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("DELETE_BY");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("datetime")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.GlueGuid)
                    .HasMaxLength(40)
                    .HasColumnName("Glue_GUID");

                entity.Property(e => e.Position)
                    .HasMaxLength(50)
                    .HasColumnName("Position");

                entity.Property(e => e.Guid)
                    .HasMaxLength(40)
                    .HasColumnName("GUID");

                entity.Property(e => e.Status)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("STATUS");

                entity.Property(e => e.UpdateBy)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("UPDATE_BY");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UPDATE_DATE");
            });

            modelBuilder.Entity<Shoe>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.CreateBy)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("CREATE_BY");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.DeleteBy)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("DELETE_BY");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("datetime")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.Version)
                    .HasMaxLength(40)
                    .HasColumnName("VERSION");

                entity.Property(e => e.Guid)
                    .HasMaxLength(40)
                    .HasColumnName("GUID");

                entity.Property(e => e.Status)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("STATUS");

                entity.Property(e => e.UpdateBy)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("UPDATE_BY");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UPDATE_DATE");
            });

            modelBuilder.Entity<ShoeGlue>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.GlueGuid)
                    .HasMaxLength(40)
                    .HasColumnName("Glue_GUID");

                entity.Property(e => e.CreateBy)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("CREATE_BY");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.DeleteBy)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("DELETE_BY");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("datetime")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.Guid)
                    .HasMaxLength(40)
                    .HasColumnName("GUID");

                entity.Property(e => e.Unit)
                    .HasMaxLength(50)
                    .HasColumnName("UNIT");

                entity.Property(e => e.ShoesGuid)
                    .HasMaxLength(40)
                    .HasColumnName("Shoes_GUID");

                entity.Property(e => e.Status)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("STATUS");

                entity.Property(e => e.UpdateBy)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("UPDATE_BY");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UPDATE_DATE");
            });

            modelBuilder.Entity<HallTime>(entity =>
            {
                entity.ToTable("Hall_Time");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.End).HasMaxLength(100);

                entity.Property(e => e.HallGuid)
                    .HasMaxLength(40)
                    .HasColumnName("Hall_GUID");

                entity.Property(e => e.SiteGuid)
                    .HasMaxLength(40)
                    .HasColumnName("Site_GUID");

                entity.Property(e => e.Start).HasMaxLength(100);
            });
            modelBuilder.Entity<WorkOrder>(entity =>
            {
                entity.ToTable("WorkOrder");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Comment)
                    .HasColumnType("ntext")
                    .HasColumnName("COMMENT");

                entity.Property(e => e.CreateBy)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("CREATE_BY");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.DeleteBy)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("DELETE_BY");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("datetime")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.Guid)
                    .HasMaxLength(40)
                    .HasColumnName("GUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.HallGuid)
                    .HasMaxLength(40)
                    .HasColumnName("Hall_GUID");

                entity.Property(e => e.Status)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("STATUS");

                entity.Property(e => e.UpdateBy)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("UPDATE_BY");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.WorkOrderName)
                    .HasMaxLength(20)
                    .HasColumnName("WorkOrder_Name");

                entity.Property(e => e.WorkOrderNo)
                    .HasMaxLength(40)
                    .HasColumnName("WorkOrder_NO");
            });
            modelBuilder.Entity<Booking>(entity =>
            {
                entity.ToTable("Booking");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.ChantingType)
                    .HasMaxLength(20)
                    .HasColumnName("Chanting_Type");

                entity.Property(e => e.Comment)
                    .HasColumnType("ntext")
                    .HasColumnName("COMMENT");

                entity.Property(e => e.CreateBy)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("CREATE_BY");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.DeleteBy)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("DELETE_BY");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("datetime")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.EndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("End_Date");

                entity.Property(e => e.FuneralDirector)
                    .HasMaxLength(40)
                    .HasColumnName("Funeral_Director");

                entity.Property(e => e.FuneralMemo)
                    .HasColumnType("ntext")
                    .HasColumnName("Funeral_Memo");

                entity.Property(e => e.Guid)
                    .HasMaxLength(40)
                    .HasColumnName("GUID");

                entity.Property(e => e.HallGuid)
                    .HasMaxLength(40)
                    .HasColumnName("Hall_GUID");

                entity.Property(e => e.HallType)
                    .HasMaxLength(20)
                    .HasColumnName("Hall_Type");

                entity.Property(e => e.HouseMonk).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.InOut).HasMaxLength(20);

                entity.Property(e => e.MageMemo).HasMaxLength(200);

                entity.Property(e => e.MageMoney).HasMaxLength(200);

                entity.Property(e => e.MageMonk).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Offerings).HasMaxLength(20);

                entity.Property(e => e.OrderDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Order_Date");

                entity.Property(e => e.OrderMeal).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.OrderName)
                    .HasMaxLength(100)
                    .HasColumnName("Order_Name");

                entity.Property(e => e.OrderNo)
                    .HasMaxLength(100)
                    .HasColumnName("Order_NO");

                entity.Property(e => e.PrepareFloral)
                    .HasMaxLength(20)
                    .HasColumnName("Prepare_Floral");

                entity.Property(e => e.PrepareFlower)
                    .HasMaxLength(20)
                    .HasColumnName("Prepare_Flower");

                entity.Property(e => e.PrepareFruit)
                    .HasMaxLength(20)
                    .HasColumnName("Prepare_Fruit");

                entity.Property(e => e.PrepareRice)
                    .HasMaxLength(20)
                    .HasColumnName("Prepare_Rice");

                entity.Property(e => e.PrepareTea)
                    .HasMaxLength(20)
                    .HasColumnName("Prepare_Tea");

                entity.Property(e => e.PrepareVegetarian)
                    .HasMaxLength(20)
                    .HasColumnName("Prepare_Vegetarian");

                entity.Property(e => e.RoomGuid)
                    .HasMaxLength(40)
                    .HasColumnName("Room_GUID");

                entity.Property(e => e.RoomType)
                    .HasMaxLength(20)
                    .HasColumnName("Room_Type");

                entity.Property(e => e.SiteGuid)
                    .HasMaxLength(40)
                    .HasColumnName("Site_GUID");

                entity.Property(e => e.StartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Start_Date");

                entity.Property(e => e.Status)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("STATUS");

                entity.Property(e => e.UpdateBy)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("UPDATE_BY");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.WorkOrderGuid)
                    .HasMaxLength(40)
                    .HasColumnName("WorkOrder_GUID");
            });

            modelBuilder.Entity<BookingDetail>(entity =>
            {
                entity.ToTable("BookingDetail");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Alternate).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.BookingDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Booking_Date");

                entity.Property(e => e.BookingGuid)
                    .HasMaxLength(40)
                    .HasColumnName("Booking_GUID");

                entity.Property(e => e.BookingTimeE)
                    .HasMaxLength(10)
                    .HasColumnName("Booking_TimeE");

                entity.Property(e => e.BookingTimeS)
                    .HasMaxLength(10)
                    .HasColumnName("Booking_TimeS");

                entity.Property(e => e.ChantingType)
                    .HasMaxLength(20)
                    .HasColumnName("Chanting_Type");

                entity.Property(e => e.Comment)
                    .HasColumnType("ntext")
                    .HasColumnName("COMMENT");

                entity.Property(e => e.CreateBy)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("CREATE_BY");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.DeleteBy)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("DELETE_BY");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("datetime")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.EndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("End_Date");

                entity.Property(e => e.FuneralDirector)
                    .HasMaxLength(40)
                    .HasColumnName("Funeral_Director");

                entity.Property(e => e.FuneralMemo)
                    .HasColumnType("ntext")
                    .HasColumnName("Funeral_Memo");

                entity.Property(e => e.Guid)
                    .HasMaxLength(40)
                    .HasColumnName("GUID");

                entity.Property(e => e.HallGuid)
                    .HasMaxLength(40)
                    .HasColumnName("Hall_GUID");

                entity.Property(e => e.HallType)
                    .HasMaxLength(20)
                    .HasColumnName("Hall_Type");

                entity.Property(e => e.HouseMonk).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.InOut).HasMaxLength(20);

                entity.Property(e => e.MageMemo).HasMaxLength(200);

                entity.Property(e => e.MageMoney).HasMaxLength(200);

                entity.Property(e => e.MageMonk).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Offerings).HasMaxLength(20);

                entity.Property(e => e.OrderDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Order_Date");

                entity.Property(e => e.OrderMeal).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.OrderName)
                    .HasMaxLength(100)
                    .HasColumnName("Order_Name");

                entity.Property(e => e.OrderNo)
                    .HasMaxLength(100)
                    .HasColumnName("Order_NO");

                entity.Property(e => e.PrepareFloral)
                    .HasMaxLength(20)
                    .HasColumnName("Prepare_Floral");

                entity.Property(e => e.PrepareFlower)
                    .HasMaxLength(20)
                    .HasColumnName("Prepare_Flower");

                entity.Property(e => e.PrepareFruit)
                    .HasMaxLength(20)
                    .HasColumnName("Prepare_Fruit");

                entity.Property(e => e.PrepareRice)
                    .HasMaxLength(20)
                    .HasColumnName("Prepare_Rice");

                entity.Property(e => e.PrepareTea)
                    .HasMaxLength(20)
                    .HasColumnName("Prepare_Tea");

                entity.Property(e => e.PrepareVegetarian)
                    .HasMaxLength(20)
                    .HasColumnName("Prepare_Vegetarian");

                entity.Property(e => e.RoomGuid)
                    .HasMaxLength(40)
                    .HasColumnName("Room_GUID");

                entity.Property(e => e.RoomType)
                    .HasMaxLength(20)
                    .HasColumnName("Room_Type");

                entity.Property(e => e.SiteGuid)
                    .HasMaxLength(40)
                    .HasColumnName("Site_GUID");

                entity.Property(e => e.StartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Start_Date");

                entity.Property(e => e.Status)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("STATUS");

                entity.Property(e => e.UpdateBy)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("UPDATE_BY");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.WorkOrderGuid)
                    .HasMaxLength(40)
                    .HasColumnName("WorkOrder_GUID");
            });

            modelBuilder.Entity<Hall>(entity =>
            {
                entity.ToTable("Hall");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Comment)
                    .HasColumnType("ntext")
                    .HasColumnName("COMMENT");

                entity.Property(e => e.CreateBy)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("CREATE_BY");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.DeleteBy)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("DELETE_BY");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("datetime")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.Guid)
                    .HasMaxLength(40)
                    .HasColumnName("GUID");

                entity.Property(e => e.HallName)
                    .HasMaxLength(200)
                    .HasColumnName("Hall_Name");

                entity.Property(e => e.HallNo)
                    .HasMaxLength(100)
                    .HasColumnName("Hall_NO");

                entity.Property(e => e.SiteGuid)
                    .HasMaxLength(40)
                    .HasColumnName("Site_GUID");

                entity.Property(e => e.Status)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("STATUS");

                entity.Property(e => e.Type).HasMaxLength(20);

                entity.Property(e => e.UpdateBy)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("UPDATE_BY");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UPDATE_DATE");
            });
            
            modelBuilder.Entity<Account>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountGroupId).HasColumnName("AccountGroupID");

                entity.Property(e => e.AccountRole)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.AccountTypeId).HasColumnName("AccountTypeID");

                entity.Property(e => e.Comment).HasColumnType("ntext");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.Guid).HasMaxLength(40);

                entity.Property(e => e.LicensePath).HasMaxLength(100);

                entity.Property(e => e.Name).HasMaxLength(10);

                entity.Property(e => e.No)
                    .HasMaxLength(20)
                    .HasColumnName("NO");

                entity.Property(e => e.Ocid).HasColumnName("OCID");

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.PhotoPath).HasMaxLength(100);

                entity.Property(e => e.Rfid)
                    .HasMaxLength(20)
                    .HasColumnName("RFID");

                entity.Property(e => e.Username).HasMaxLength(50);

                entity.HasOne(d => d.AccountType)
                    .WithMany(p => p.Accounts)
                    .HasForeignKey(d => d.AccountTypeId);

                entity.HasOne(d => d.Oc)
                    .WithMany(p => p.Accounts)
                    .HasForeignKey(d => d.Ocid);
            });

            modelBuilder.Entity<AccountGroup>(entity =>
            {
                entity.ToTable("AccountGroup");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BuildingId).HasColumnName("BuildingID");

                entity.Property(e => e.GroupName).HasMaxLength(200);

                entity.Property(e => e.GroupNo)
                    .HasMaxLength(100)
                    .HasColumnName("GroupNO");

                entity.Property(e => e.ZoneId).HasColumnName("ZoneID");
            });

            modelBuilder.Entity<AccountPermission>(entity =>
            {
                entity.ToTable("AccountPermission");

                entity.Property(e => e.Id).HasColumnName("ID");


            });

            modelBuilder.Entity<AccountRole>(entity =>
            {
                entity.ToTable("AccountRole");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountGuid).HasMaxLength(40);

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.CodeNo)
                    .HasMaxLength(25)
                    .HasColumnName("CodeNO");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.AccountRoles)
                    .HasForeignKey(d => d.AccountId);
            });

            modelBuilder.Entity<AccountType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Code).HasMaxLength(100);

                entity.Property(e => e.Name).HasMaxLength(100);
            });

            modelBuilder.Entity<CodeHelp>(entity =>
            {
                entity.ToTable("CODE_HELP");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.CodeNameCn)
                    .HasMaxLength(255)
                    .HasColumnName("CODE_NAME_CN");

                entity.Property(e => e.CodeNameEn)
                    .HasMaxLength(255)
                    .HasColumnName("CODE_NAME_EN");

                entity.Property(e => e.CodeNameVn)
                    .HasMaxLength(255)
                    .HasColumnName("CODE_NAME_VN");

                entity.Property(e => e.CodeNo)
                    .HasMaxLength(25)
                    .HasColumnName("CODE_NO");

                entity.Property(e => e.CodeType)
                    .HasMaxLength(25)
                    .HasColumnName("CODE_TYPE");

                entity.Property(e => e.Comment)
                    .HasColumnType("text")
                    .HasColumnName("COMMENT");

                entity.Property(e => e.CreateBy)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("CREATE_BY");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.FileName).HasMaxLength(255);

                entity.Property(e => e.Sort).HasColumnName("SORT");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .HasColumnName("STATUS");

                entity.Property(e => e.UpdateBy)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("UPDATE_BY");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UPDATE_DATE");
            });

            modelBuilder.Entity<CodePermission>(entity =>
            {
                entity.ToTable("CODE_Permission");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.CodeName)
                    .HasMaxLength(255)
                    .HasColumnName("CODE_NAME");

                entity.Property(e => e.CodeNameCn)
                    .HasMaxLength(255)
                    .HasColumnName("CODE_NAME_CN");

                entity.Property(e => e.CodeNameEn)
                    .HasMaxLength(255)
                    .HasColumnName("CODE_NAME_EN");

                entity.Property(e => e.CodeNameVn)
                    .HasMaxLength(255)
                    .HasColumnName("CODE_NAME_VN");

                entity.Property(e => e.CodeNo)
                    .HasMaxLength(25)
                    .HasColumnName("CODE_NO");

                entity.Property(e => e.CodeType)
                    .HasMaxLength(25)
                    .HasColumnName("CODE_TYPE");

                entity.Property(e => e.Comment)
                    .HasColumnType("text")
                    .HasColumnName("COMMENT");

                entity.Property(e => e.CreateBy)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("CREATE_BY");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.Sort).HasColumnName("SORT");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .HasColumnName("STATUS");

                entity.Property(e => e.UpdateBy)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("UPDATE_BY");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UPDATE_DATE");
            });

            modelBuilder.Entity<CodePermission1>(entity =>
            {
                entity.ToTable("CodePermission");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CodeNameCn)
                    .HasMaxLength(255)
                    .HasColumnName("CodeNameCN");

                entity.Property(e => e.CodeNameEn)
                    .HasMaxLength(255)
                    .HasColumnName("CodeNameEN");

                entity.Property(e => e.CodeNameVn)
                    .HasMaxLength(255)
                    .HasColumnName("CodeNameVN");

                entity.Property(e => e.Comment).HasColumnType("ntext");

                entity.Property(e => e.Name).HasMaxLength(20);

                entity.Property(e => e.No)
                    .HasMaxLength(20)
                    .HasColumnName("NO");

                entity.Property(e => e.Type).HasMaxLength(25);
            });

            modelBuilder.Entity<CodeServiceType>(entity =>
            {
                entity.ToTable("CODE_ServiceType");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.CodeName)
                    .HasMaxLength(255)
                    .HasColumnName("CODE_NAME");

                entity.Property(e => e.CodeNo)
                    .HasMaxLength(25)
                    .HasColumnName("CODE_NO");

                entity.Property(e => e.Comment)
                    .HasColumnType("text")
                    .HasColumnName("COMMENT");

                entity.Property(e => e.CreateBy)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("CREATE_BY");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.Sort).HasColumnName("SORT");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .HasColumnName("STATUS");

                entity.Property(e => e.UpdateBy)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("UPDATE_BY");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UPDATE_DATE");
            });

            modelBuilder.Entity<CodeType>(entity =>
            {
                entity.ToTable("CODE_TYPE");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.CodeName)
                    .HasMaxLength(255)
                    .HasColumnName("CODE_NAME");

                entity.Property(e => e.CodeNameCn)
                    .HasMaxLength(255)
                    .HasColumnName("CODE_NAME_CN");

                entity.Property(e => e.CodeNameEn)
                    .HasMaxLength(255)
                    .HasColumnName("CODE_NAME_EN");

                entity.Property(e => e.CodeNameVn)
                    .HasMaxLength(255)
                    .HasColumnName("CODE_NAME_VN");

                entity.Property(e => e.CodeNo)
                    .HasMaxLength(25)
                    .HasColumnName("CODE_NO");

                entity.Property(e => e.CodeType1)
                    .HasMaxLength(25)
                    .HasColumnName("CODE_TYPE");

                entity.Property(e => e.Comment)
                    .HasMaxLength(100)
                    .HasColumnName("COMMENT");

                entity.Property(e => e.CreateBy)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("CREATE_BY");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.Sort).HasColumnName("SORT");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .HasColumnName("STATUS");

                entity.Property(e => e.StoreId).HasColumnName("Store_id");

                entity.Property(e => e.UpdateBy)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("UPDATE_BY");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.WebSiteId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("WebSite_ID");
            });


            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("Customer");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.CancelFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CANCEL_FLAG")
                    .IsFixedLength(true);

                entity.Property(e => e.Comment)
                    .HasColumnType("ntext")
                    .HasColumnName("COMMENT");

                entity.Property(e => e.ContactEmail)
                    .HasMaxLength(100)
                    .HasColumnName("Contact_EMAIL");

                entity.Property(e => e.ContactMobile)
                    .HasMaxLength(20)
                    .HasColumnName("Contact_MOBILE");

                entity.Property(e => e.ContactName)
                    .HasMaxLength(20)
                    .HasColumnName("Contact_Name");

                entity.Property(e => e.ContactTel)
                    .HasMaxLength(20)
                    .HasColumnName("Contact_TEL");

                entity.Property(e => e.CreateBy)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("CREATE_BY");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.CustomerAddress)
                    .HasMaxLength(100)
                    .HasColumnName("Customer_ADDRESS");

                entity.Property(e => e.CustomerBirthday)
                    .HasColumnType("datetime")
                    .HasColumnName("Customer_BIRTHDAY");

                entity.Property(e => e.CustomerEmail)
                    .HasMaxLength(100)
                    .HasColumnName("Customer_EMAIL");

                entity.Property(e => e.CustomerIdcard)
                    .HasMaxLength(20)
                    .HasColumnName("Customer_IDCARD");

                entity.Property(e => e.CustomerMobile)
                    .HasMaxLength(20)
                    .HasColumnName("Customer_MOBILE");

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(100)
                    .HasColumnName("Customer_NAME");

                entity.Property(e => e.CustomerNickname)
                    .HasMaxLength(20)
                    .HasColumnName("Customer_NICKNAME");

                entity.Property(e => e.CustomerNo)
                    .HasMaxLength(100)
                    .HasColumnName("Customer_NO");

                entity.Property(e => e.CustomerSex)
                    .HasMaxLength(1)
                    .HasColumnName("Customer_SEX");

                entity.Property(e => e.CustomerTel)
                    .HasMaxLength(20)
                    .HasColumnName("Customer_TEL");

                entity.Property(e => e.Guid)
                    .HasMaxLength(40)
                    .HasColumnName("GUID").HasDefaultValueSql("(newid())");

                entity.Property(e => e.FarmGuid)
                    .HasMaxLength(40)
                    .HasColumnName("Farm_GUID");

                entity.Property(e => e.Status)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("STATUS");

                entity.Property(e => e.UpdateBy)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("UPDATE_BY");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UPDATE_DATE");
            });

            modelBuilder.Entity<Dashboard>(entity =>
            {
                entity.ToTable("Dashboard");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.AreaName)
                    .HasMaxLength(100)
                    .HasColumnName("Area_Name");
                entity.Property(e => e.LangID)
                                   .HasMaxLength(10)
                                   .HasColumnName("LangID");
                entity.Property(e => e.AreaNo)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("Area_No");

                entity.Property(e => e.BackGroundColor).HasMaxLength(100);

                entity.Property(e => e.CreateBy)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("CREATE_BY");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATE_DATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DashBoardName)
                    .HasMaxLength(100)
                    .HasColumnName("DashBoard_Name");

                entity.Property(e => e.DashBoardNo)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("DashBoard_No");

                entity.Property(e => e.FarmGuid)
                    .HasMaxLength(40)
                    .HasColumnName("Farm_GUID");

                entity.Property(e => e.Guid)
                    .HasMaxLength(40)
                    .HasColumnName("GUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ItemName)
                    .HasMaxLength(100)
                    .HasColumnName("Item_Name");

                entity.Property(e => e.ItemNo)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("Item_No");

                entity.Property(e => e.SortId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("Sort_ID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Status)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("STATUS")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Text01).HasMaxLength(100);

                entity.Property(e => e.Text02).HasMaxLength(100);

                entity.Property(e => e.Text03).HasMaxLength(100);

                entity.Property(e => e.Text04).HasMaxLength(100);

                entity.Property(e => e.Text05).HasMaxLength(100);

                entity.Property(e => e.Text06).HasMaxLength(100);

                entity.Property(e => e.Text07).HasMaxLength(100);

                entity.Property(e => e.Text08).HasMaxLength(100);

                entity.Property(e => e.Text09).HasMaxLength(100);

                entity.Property(e => e.Text10).HasMaxLength(100);

                entity.Property(e => e.TextColor01).HasMaxLength(100);

                entity.Property(e => e.TextColor02).HasMaxLength(100);

                entity.Property(e => e.TextColor03).HasMaxLength(100);

                entity.Property(e => e.TextColor04).HasMaxLength(100);

                entity.Property(e => e.TextColor05).HasMaxLength(100);

                entity.Property(e => e.TextColor06).HasMaxLength(100);

                entity.Property(e => e.TextColor07).HasMaxLength(100);

                entity.Property(e => e.TextColor08).HasMaxLength(100);

                entity.Property(e => e.TextColor09).HasMaxLength(100);

                entity.Property(e => e.TextColor10).HasMaxLength(100);
                entity.Property(e => e.ChartTitle).HasColumnName("Chart_Title").HasMaxLength(100);

                entity.Property(e => e.Type).HasMaxLength(100);

                entity.Property(e => e.UpperArea)
                    .HasMaxLength(40)
                    .HasColumnName("Upper_Area");

                entity.Property(e => e.UpperDashBoard)
                    .HasMaxLength(40)
                    .HasColumnName("Upper_DashBoard");

                entity.Property(e => e.Value01).HasMaxLength(100);

                entity.Property(e => e.Value02).HasMaxLength(100);

                entity.Property(e => e.Value03).HasMaxLength(100);

                entity.Property(e => e.Value04).HasMaxLength(100);

                entity.Property(e => e.Value05).HasMaxLength(100);

                entity.Property(e => e.Value06).HasMaxLength(100);

                entity.Property(e => e.Value07).HasMaxLength(100);

                entity.Property(e => e.Value08).HasMaxLength(100);

                entity.Property(e => e.Value09).HasMaxLength(100);

                entity.Property(e => e.Value10).HasMaxLength(100);

                entity.Property(e => e.ValueColor01).HasMaxLength(100);

                entity.Property(e => e.ValueColor02).HasMaxLength(100);

                entity.Property(e => e.ValueColor03).HasMaxLength(100);

                entity.Property(e => e.ValueColor04).HasMaxLength(100);

                entity.Property(e => e.ValueColor05).HasMaxLength(100);

                entity.Property(e => e.ValueColor06).HasMaxLength(100);

                entity.Property(e => e.ValueColor07).HasMaxLength(100);

                entity.Property(e => e.ValueColor08).HasMaxLength(100);

                entity.Property(e => e.ValueColor09).HasMaxLength(100);

                entity.Property(e => e.ValueColor10).HasMaxLength(100);
            });


            modelBuilder.Entity<EmailPool>(entity =>
            {
                entity.ToTable("Email_Pool");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Content).HasColumnType("ntext");

                entity.Property(e => e.CreateBy)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("CREATE_BY");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.FromEmail).HasMaxLength(200);

                entity.Property(e => e.FromName).HasMaxLength(200);

                entity.Property(e => e.SendBy)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("SEND_BY");

                entity.Property(e => e.SendDate1)
                    .HasColumnType("datetime")
                    .HasColumnName("SEND_DATE");

                entity.Property(e => e.Senddate)
                    .HasColumnType("datetime")
                    .HasColumnName("SENDDATE");

                entity.Property(e => e.Sendto)
                    .HasMaxLength(200)
                    .HasColumnName("SENDTO");

                entity.Property(e => e.Sendtobcc)
                    .HasMaxLength(200)
                    .HasColumnName("SENDTOBCC");

                entity.Property(e => e.Sendtocc)
                    .HasMaxLength(200)
                    .HasColumnName("SENDTOCC");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STATUS")
                    .IsFixedLength(true);

                entity.Property(e => e.Subject).HasMaxLength(200);
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd().HasColumnType("numeric(18, 0)").HasColumnName("ID");

                entity.Property(e => e.Address).HasMaxLength(100);

                entity.Property(e => e.AddressDomicile).HasMaxLength(100);

                entity.Property(e => e.Comment).HasColumnType("ntext");

                entity.Property(e => e.ContactName).HasMaxLength(100);

                entity.Property(e => e.ContactTel).HasMaxLength(20);

                entity.Property(e => e.Dept).HasMaxLength(100);

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.Idcard)
                    .HasMaxLength(20)
                    .HasColumnName("IDCard");

                entity.Property(e => e.Sex).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Level).HasMaxLength(20);

                entity.Property(e => e.Mobile).HasMaxLength(20);

                entity.Property(e => e.Name).HasMaxLength(10);

                entity.Property(e => e.NickName).HasMaxLength(20);

                entity.Property(e => e.No)
                    .HasMaxLength(20)
                    .HasColumnName("NO");
                entity.Property(e => e.FarmGuid)
                   .HasMaxLength(40)
                   .HasColumnName("Farm_GUID");
                entity.Property(e => e.Tel).HasMaxLength(20);

                entity.Property(e => e.Unit).HasMaxLength(100);
                entity.Property(e => e.Guid)
                   .HasMaxLength(40)
                   .HasColumnName("GUID")
                   .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreateBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("CreateBy");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CreateDate");

                entity.Property(e => e.Status)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("STATUS");

                entity.Property(e => e.UpdateBy)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("UpdateBy");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UpdateDate");
            });

            modelBuilder.Entity<Oc>(entity =>
            {
                entity.ToTable("OC");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Comment).HasColumnType("ntext");

                entity.Property(e => e.Ggp).HasColumnName("GGP");

                entity.Property(e => e.Gp).HasColumnName("GP");

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.No)
                    .HasMaxLength(100)
                    .HasColumnName("NO");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Pmpf).HasColumnName("PMPF");

                entity.Property(e => e.Principal).HasMaxLength(200);

                entity.Property(e => e.Type).HasMaxLength(20);
            });

            modelBuilder.Entity<Site>(entity =>
            {
                entity.ToTable("Site");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Comment)
                    .HasColumnType("ntext")
                    .HasColumnName("COMMENT");

                entity.Property(e => e.CreateBy)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("CREATE_BY");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.DeleteBy)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("DELETE_BY");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("datetime")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.Guid)
                    .HasMaxLength(40)
                    .HasColumnName("GUID");

                entity.Property(e => e.SiteLocation)
                    .HasMaxLength(20)
                    .HasColumnName("Site_Location");

                entity.Property(e => e.SiteName)
                    .HasMaxLength(200)
                    .HasColumnName("Site_Name");

                entity.Property(e => e.SiteNo)
                    .HasMaxLength(100)
                    .HasColumnName("Site_NO");

                entity.Property(e => e.SitePhoto)
                    .HasMaxLength(100)
                    .HasColumnName("Site_Photo");

                entity.Property(e => e.Status)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("STATUS");

                entity.Property(e => e.Type).HasMaxLength(20);

                entity.Property(e => e.UpdateBy)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("UPDATE_BY");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UPDATE_DATE");
            });

            modelBuilder.Entity<RefreshToken>(entity =>
            {
                entity.HasKey(e => e.Token);

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                //entity.HasOne(d => d.Account)
                //    .WithMany(p => p.RefreshTokens)
                //    .HasForeignKey(d => d.AccountId);
            });

            modelBuilder.Entity<Room>(entity =>
            {
                entity.ToTable("Room");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Comment)
                    .HasColumnType("ntext")
                    .HasColumnName("COMMENT");

                entity.Property(e => e.CreateBy)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("CREATE_BY");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.DeleteBy)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("DELETE_BY");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("datetime")
                    .HasColumnName("DELETE_DATE");

                entity.Property(e => e.Guid)
                    .HasMaxLength(40)
                    .HasColumnName("GUID");

                entity.Property(e => e.HallGuid)
                    .HasMaxLength(40)
                    .HasColumnName("Hall_GUID");

                entity.Property(e => e.Price).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.PriceMember)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("Price_Member");

                entity.Property(e => e.PriceSpecial)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("Price_Special");

                entity.Property(e => e.RoomDescript)
                    .HasMaxLength(2000)
                    .HasColumnName("Room_Descript");

                entity.Property(e => e.RoomLocation)
                    .HasMaxLength(20)
                    .HasColumnName("Room_Location");

                entity.Property(e => e.RoomName)
                    .HasMaxLength(200)
                    .HasColumnName("Room_Name");

                entity.Property(e => e.RoomNo)
                    .HasMaxLength(100)
                    .HasColumnName("Room_NO");

                entity.Property(e => e.RoomPhoto)
                    .HasMaxLength(200)
                    .HasColumnName("Room_Photo");

                entity.Property(e => e.RoomPhoto1)
                    .HasMaxLength(200)
                    .HasColumnName("Room_Photo1");

                entity.Property(e => e.RoomPhoto2)
                    .HasMaxLength(200)
                    .HasColumnName("Room_Photo2");

                entity.Property(e => e.RoomPhoto3)
                    .HasMaxLength(200)
                    .HasColumnName("Room_Photo3");

                entity.Property(e => e.RoomPhoto4)
                    .HasMaxLength(200)
                    .HasColumnName("Room_Photo4");

                entity.Property(e => e.RoomPhoto5)
                    .HasMaxLength(200)
                    .HasColumnName("Room_Photo5");

                entity.Property(e => e.RoomSize)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("Room_Size");

                entity.Property(e => e.SiteGuid)
                    .HasMaxLength(40)
                    .HasColumnName("Site_GUID");

                entity.Property(e => e.Status)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("STATUS");

                entity.Property(e => e.Type).HasMaxLength(20);

                entity.Property(e => e.UpdateBy)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("UPDATE_BY");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UPDATE_DATE");
            });

            modelBuilder.Entity<SysConfig>(entity =>
            {
                entity.ToTable("SYS_CONFIG");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Comment)
                    .HasColumnType("ntext")
                    .HasColumnName("COMMENT");

                entity.Property(e => e.ConfigNo)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("CONFIG_NO");

                entity.Property(e => e.ConfigType)
                    .HasMaxLength(25)
                    .HasColumnName("CONFIG_TYPE");

                entity.Property(e => e.ConfigValue)
                    .HasMaxLength(255)
                    .HasColumnName("CONFIG_VALUE");

                entity.Property(e => e.CreateBy)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("CREATE_BY");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.FarmGuid)
                    .HasMaxLength(40)
                    .HasColumnName("Farm_GUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Sort).HasColumnName("SORT");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .HasColumnName("STATUS");

                entity.Property(e => e.UpdateBy)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("UPDATE_BY");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UPDATE_DATE");
            });

            modelBuilder.Entity<SysLogGp>(entity =>
            {
                entity.ToTable("SYS_LOG_GPS");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Action)
                    .HasMaxLength(30)
                    .HasColumnName("ACTION")
                    .IsFixedLength(true);

                entity.Property(e => e.CallBy)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.Ip)
                    .HasMaxLength(16)
                    .HasColumnName("IP");

                entity.Property(e => e.Lat)
                    .HasMaxLength(20)
                    .HasColumnName("LAT");

                entity.Property(e => e.Lng)
                    .HasMaxLength(20)
                    .HasColumnName("LNG");

                entity.Property(e => e.Type)
                    .HasMaxLength(10)
                    .HasColumnName("TYPE");

                entity.Property(e => e.UpperGuid)
                    .HasMaxLength(40)
                    .HasColumnName("UPPER_GUID");

                entity.Property(e => e.Wip)
                    .HasMaxLength(16)
                    .HasColumnName("WIP");
            });

            modelBuilder.Entity<SysLogUser>(entity =>
            {
                entity.HasKey(e => e.SluId)
                    .HasName("PK__SYS_LOG_USER__22");

                entity.ToTable("SYS_LOG_USER");

                entity.Property(e => e.SluId)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("SLU_ID");


                entity.Property(e => e.SluDate)
                    .HasColumnType("datetime")
                    .HasColumnName("SLU_DATE");

                entity.Property(e => e.SluFid)
                    .HasMaxLength(10)
                    .HasColumnName("SLU_FID");

                entity.Property(e => e.SluFunction).HasColumnName("SLU_FUNCTION");

                entity.Property(e => e.SluIp)
                    .HasMaxLength(16)
                    .HasColumnName("SLU_IP");

                entity.Property(e => e.SluModule)
                    .HasMaxLength(50)
                    .HasColumnName("SLU_MODULE");

                entity.Property(e => e.SluPage)
                    .HasMaxLength(50)
                    .HasColumnName("SLU_PAGE");

                entity.Property(e => e.SluSql).HasColumnName("SLU_SQL");

                entity.Property(e => e.SluText).HasColumnName("SLU_TEXT");

                entity.Property(e => e.SluTime)
                    .HasMaxLength(10)
                    .HasColumnName("SLU_TIME");

                entity.Property(e => e.SluType)
                    .HasMaxLength(30)
                    .HasColumnName("SLU_TYPE");

                entity.Property(e => e.SluUid)
                    .HasMaxLength(10)
                    .HasColumnName("SLU_UID");

                entity.Property(e => e.SluUrl).HasColumnName("SLU_URL");

               
            });

            modelBuilder.Entity<SysMenu>(entity =>
            {
                entity.ToTable("SYS_MENU");

                entity.Property(e => e.FarmGgp)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("Farm_GGP");

                entity.Property(e => e.FarmGp)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("Farm_GP");

                entity.Property(e => e.FarmGrower)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("Farm_GROWER");
                entity.Property(e => e.FarmNursery)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("Farm_NURSERY");

                entity.Property(e => e.FarmPmpf)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("Farm_PMPF");

                entity.Property(e => e.FarmSemen)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("Farm_SEMEN");


                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.CancelFlag)
                    .HasMaxLength(1)
                    .HasColumnName("CANCEL_FLAG");

                entity.Property(e => e.Comment)
                    .HasColumnType("text")
                    .HasColumnName("COMMENT");

                entity.Property(e => e.CreateBy)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("CREATE_BY");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.EndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("END_DATE");

                entity.Property(e => e.Guid)
                    .HasMaxLength(40)
                    .HasColumnName("GUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.InFooter)
                    .HasMaxLength(1)
                    .HasColumnName("inFooter")
                    .IsFixedLength(true);

                entity.Property(e => e.InHeader)
                    .HasMaxLength(1)
                    .HasColumnName("inHeader")
                    .IsFixedLength(true);

                entity.Property(e => e.MenuIcon)
                    .HasMaxLength(200)
                    .HasColumnName("MenuICON");

                entity.Property(e => e.MenuIcon1)
                    .HasMaxLength(200)
                    .HasColumnName("MenuICON-1");

                entity.Property(e => e.MenuLink).HasMaxLength(200);

                entity.Property(e => e.MenuLinkEn)
                    .HasMaxLength(200)
                    .HasColumnName("MenuLink_EN");

                entity.Property(e => e.MenuName).HasMaxLength(200);

                entity.Property(e => e.MenuNameEn)
                    .HasMaxLength(200)
                    .HasColumnName("MenuName_EN");


                entity.Property(e => e.MenuNameCn)
                    .HasMaxLength(200)
                    .HasColumnName("MenuName_CN");

                entity.Property(e => e.MenuNameVn)
                    .HasMaxLength(200)
                    .HasColumnName("MenuName_VN");

                entity.Property(e => e.SortId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("SORT_ID");

                entity.Property(e => e.StartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("START_DATE");

                entity.Property(e => e.Status)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("STATUS");

                entity.Property(e => e.Type)
                    .HasMaxLength(20)
                    .HasColumnName("TYPE");

                entity.Property(e => e.UpdateBy)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("UPDATE_BY");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.UpperId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("UPPER_ID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.WebPageGuid)
                    .HasMaxLength(40)
                    .HasColumnName("WebPage_GUID");

                entity.Property(e => e.WebPageGuidEn)
                    .HasMaxLength(40)
                    .HasColumnName("WebPage_GUID_EN");
                entity.Property(e => e.StoredProceduresName)
                .HasMaxLength(200)
                .HasColumnName("StoredProceduresName");
                entity.Property(e => e.ReportType)
              .HasMaxLength(20)
              .HasColumnName("Report_Type");

                entity.Property(e => e.ChartName)
            .HasMaxLength(200)
            .HasColumnName("Chart_Name");

                entity.Property(e => e.ChartNameEn)
           .HasMaxLength(200)
           .HasColumnName("Chart_NameEn");

                entity.Property(e => e.ChartNameVn)
           .HasMaxLength(200)
           .HasColumnName("Chart_NameVn");

                entity.Property(e => e.ChartNameCn)
           .HasMaxLength(200)
           .HasColumnName("Chart_NameCn");

                entity.Property(e => e.ChartUnit)
         .HasMaxLength(20)
         .HasColumnName("Chart_Unit");

                entity.Property(e => e.ChartXAxisName)
       .HasMaxLength(200)
       .HasColumnName("Chart_XAxisName");

                entity.Property(e => e.ChartXAxisNameEn)
           .HasMaxLength(200)
           .HasColumnName("Chart_XAxisNameEn");

                entity.Property(e => e.ChartXAxisNameVn)
           .HasMaxLength(200)
           .HasColumnName("Chart_XAxisNameVn");

                entity.Property(e => e.ChartXAxisNameCn)
           .HasMaxLength(200)
           .HasColumnName("Chart_XAxisNameCn");


                entity.Property(e => e.ChartYAxisName)
        .HasMaxLength(200)
        .HasColumnName("Chart_YAxisName");

                entity.Property(e => e.ChartYAxisNameEn)
           .HasMaxLength(200)
           .HasColumnName("Chart_YAxisNameEn");

                entity.Property(e => e.ChartYAxisNameVn)
           .HasMaxLength(200)
           .HasColumnName("Chart_YAxisNameVn");

                entity.Property(e => e.ChartYAxisNameCn)
           .HasMaxLength(200)
           .HasColumnName("Chart_YAxisNameCn");

            });

            modelBuilder.Entity<SystemConfig>(entity =>
            {
                entity.ToTable("SystemConfig");

                 entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.AccountId)
                  .HasColumnType("numeric(18, 0)")
                  .HasColumnName("AccountID");

               

                entity.Property(e => e.Comment).HasColumnType("ntext");

                entity.Property(e => e.No)
                    .HasMaxLength(40)
                    .HasColumnName("NO");
                entity.Property(e => e.Link)
                    .HasMaxLength(200)
                    .HasColumnName("Link");

                entity.Property(e => e.Type).HasMaxLength(40);
                entity.Property(e => e.Value).HasMaxLength(40);
                entity.Property(e => e.Sort)
                 .HasColumnType("numeric(18, 0)")
                 .HasColumnName("Sort");


                entity.Property(e => e.WebBuildingId)
                  .HasColumnType("numeric(18, 0)")
                  .HasColumnName("WebBuildingID");

                entity.Property(e => e.CreateBy)
                .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateBy)
                     .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime");

                entity.Property(e => e.Status)
                   .HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<SystemLanguage>(entity =>
            {
                entity.ToTable("SystemLanguage");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Comment).HasMaxLength(100);

                entity.Property(e => e.Slcn)
                    .HasMaxLength(500)
                    .HasColumnName("SLCN");

                entity.Property(e => e.Slen)
                    .HasMaxLength(500)
                    .HasColumnName("SLEN");

                entity.Property(e => e.Slkey)
                    .HasMaxLength(50)
                    .HasColumnName("SLKey");

                entity.Property(e => e.Slpage)
                    .HasMaxLength(50)
                    .HasColumnName("SLPage");

                entity.Property(e => e.Sltw)
                    .HasMaxLength(500)
                    .HasColumnName("SLTW");

                entity.Property(e => e.Sltype)
                    .HasMaxLength(50)
                    .HasColumnName("SLType");

                entity.Property(e => e.Slvn)
                    .HasMaxLength(500)
                    .HasColumnName("SLVN");

                entity.Property(e => e.SystemMenuGuid)
                 .HasMaxLength(40)
                 .HasColumnName("SystemMenuGuid");

                entity.Property(e => e.CreateBy)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("CREATE_BY")
                .HasComment("建立人員");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATE_DATE")
                    .HasComment("建立日期");

                entity.Property(e => e.UpdateBy)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("UPDATE_BY")
                    .HasComment("更新人員");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UPDATE_DATE")
                    .HasComment("更新日期");
                entity.Property(e => e.Status)
                   .HasColumnType("numeric(18, 0)")
                   .HasColumnName("STATUS");

            });

            modelBuilder.Entity<SystemLogUser>(entity =>
            {
                entity.ToTable("SystemLogUser");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Cn)
                    .HasMaxLength(500)
                    .HasColumnName("CN");

                entity.Property(e => e.Comment).HasMaxLength(100);

                entity.Property(e => e.En)
                    .HasMaxLength(500)
                    .HasColumnName("EN");

                entity.Property(e => e.Key).HasMaxLength(50);

                entity.Property(e => e.Page).HasMaxLength(50);

                entity.Property(e => e.Tw)
                    .HasMaxLength(500)
                    .HasColumnName("TW");

                entity.Property(e => e.Type).HasMaxLength(50);

                entity.Property(e => e.Vn)
                    .HasMaxLength(500)
                    .HasColumnName("VN");
            });

            modelBuilder.Entity<UserConfig>(entity =>
            {
                entity.ToTable("USER_CONFIG");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Comment)
                    .HasColumnType("text")
                    .HasColumnName("COMMENT");

                entity.Property(e => e.ConfigNo)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("CONFIG_NO");

                entity.Property(e => e.ConfigType)
                    .HasMaxLength(25)
                    .HasColumnName("CONFIG_TYPE");

                entity.Property(e => e.ConfigValue)
                    .HasMaxLength(255)
                    .HasColumnName("CONFIG_VALUE");

                entity.Property(e => e.CreateBy)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("CREATE_BY");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.FarmGuid)
                    .HasMaxLength(40)
                    .HasColumnName("Farm_GUID");

                entity.Property(e => e.Sort).HasColumnName("SORT");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .HasColumnName("STATUS");

                entity.Property(e => e.UpdateBy)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("UPDATE_BY");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UPDATE_DATE");
            });

            modelBuilder.Entity<XAccount>(entity =>
            {
                entity.HasKey(e => e.AccountId)
                    .HasName("PK_Account_12");

                entity.ToTable("xAccount");

                entity.Property(e => e.AccountId)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("Account_ID");

                entity.Property(e => e.AccountAddress)
                    .HasMaxLength(100)
                    .HasColumnName("Account_ADDRESS");

                entity.Property(e => e.AccountBirthday)
                    .HasColumnType("datetime")
                    .HasColumnName("Account_BIRTHDAY");

                entity.Property(e => e.AccountDomicileAddress)
                    .HasMaxLength(100)
                    .HasColumnName("Account_Domicile_ADDRESS");

                entity.Property(e => e.AccountEmail)
                    .HasMaxLength(100)
                    .HasColumnName("Account_EMAIL");

                entity.Property(e => e.AccountGroup)
                    .HasMaxLength(100)
                    .HasColumnName("Account_Group");

                entity.Property(e => e.AccountIdcard)
                    .HasMaxLength(20)
                    .HasColumnName("Account_IDCARD");

                entity.Property(e => e.AccountMobile)
                    .HasMaxLength(20)
                    .HasColumnName("Account_MOBILE");

                entity.Property(e => e.AccountName)
                    .HasMaxLength(20)
                    .HasColumnName("Account_NAME");

                entity.Property(e => e.AccountNickname)
                    .HasMaxLength(20)
                    .HasColumnName("Account_NICKNAME");

                entity.Property(e => e.AccountNo)
                    .HasMaxLength(20)
                    .HasColumnName("Account_NO");

                entity.Property(e => e.AccountOrganization)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("Account_Organization");

                entity.Property(e => e.AccountRole)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Account_Role")
                    .IsFixedLength(true);

                entity.Property(e => e.AccountSex)
                    .HasMaxLength(20)
                    .HasColumnName("Account_SEX");

                entity.Property(e => e.AccountSite)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("Account_Site");

                entity.Property(e => e.AccountTel)
                    .HasMaxLength(20)
                    .HasColumnName("Account_TEL");

                entity.Property(e => e.AccountType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Account_Type")
                    .IsFixedLength(true);

                entity.Property(e => e.CancelFlag)
                    .HasMaxLength(1)
                    .HasColumnName("CANCEL_FLAG");

                entity.Property(e => e.ClinicId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("Clinic_ID");

                entity.Property(e => e.Comment).HasColumnType("text");

                entity.Property(e => e.CreateBy)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("CREATE_BY");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.EndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("End_Date");

                entity.Property(e => e.ErrorLogin)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("errorLogin");

                entity.Property(e => e.FarmGuid)
                    .HasMaxLength(40)
                    .HasColumnName("FARM_GUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.EmployeeGuid)
                   .HasMaxLength(40)
                   .HasColumnName("Employee_GUID");

                entity.Property(e => e.Guid)
                    .HasMaxLength(40)
                    .HasColumnName("GUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.LastLoginDate)
                    .HasColumnType("datetime")
                    .HasColumnName("LastLogin_Date");

                entity.Property(e => e.Lastlogin)
                    .HasColumnType("datetime")
                    .HasColumnName("lastlogin");

                entity.Property(e => e.Lastuse)
                    .HasColumnType("datetime")
                    .HasColumnName("lastuse");

                entity.Property(e => e.PAccount)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("P_Account")
                    .IsFixedLength(true);

                entity.Property(e => e.PAdmin)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("P_Admin")
                    .IsFixedLength(true);

                entity.Property(e => e.PClinic)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("P_Clinic")
                    .IsFixedLength(true);

                entity.Property(e => e.PCodeType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("P_CodeType")
                    .IsFixedLength(true);

                entity.Property(e => e.PEnquiry)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("P_Enquiry")
                    .IsFixedLength(true);

                entity.Property(e => e.PEnquiryResult)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("P_Enquiry_Result")
                    .IsFixedLength(true);

                entity.Property(e => e.PPatient)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("P_Patient")
                    .IsFixedLength(true);

                entity.Property(e => e.PPhotoComment)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("P_PhotoComment")
                    .IsFixedLength(true);

                entity.Property(e => e.PRequisitionConfirm)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("P_RequisitionConfirm")
                    .IsFixedLength(true);

                entity.Property(e => e.PhotoPath)
                    .HasMaxLength(100)
                    .HasColumnName("Photo_Path");

                entity.Property(e => e.RoleId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("Role_ID");

                entity.Property(e => e.StartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Start_Date");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Token)
                    .HasMaxLength(100)
                    .HasColumnName("token");

                entity.Property(e => e.TypeId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("Type_ID");

                entity.Property(e => e.Uid)
                    .HasMaxLength(50)
                    .HasColumnName("UID");

                entity.Property(e => e.UpdateBy)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("UPDATE_BY");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.Upwd)
                    .HasMaxLength(50)
                    .HasColumnName("UPWD");
                entity.Property(e => e.PageSizeSetting)
                   .HasMaxLength(10)
                   .HasColumnName("PageSize_Setting");
            });

            modelBuilder.Entity<XAccountGroup>(entity =>
            {
                entity.ToTable("xAccount_Group");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.CancelFlag)
                    .HasMaxLength(1)
                    .HasColumnName("CANCEL_FLAG");

                entity.Property(e => e.CreateBy)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("CREATE_BY");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.FarmGuid)
                    .HasMaxLength(40)
                    .HasColumnName("Farm_GUID");

                entity.Property(e => e.GroupName)
                    .HasMaxLength(200)
                    .HasColumnName("Group_Name");

                entity.Property(e => e.GroupNo)
                    .HasMaxLength(100)
                    .HasColumnName("Group_NO");

                entity.Property(e => e.Guid)
                    .HasMaxLength(40)
                    .HasColumnName("GUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Status)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("STATUS");

                entity.Property(e => e.UpdateBy)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("UPDATE_BY");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UPDATE_DATE");
            });

            modelBuilder.Entity<XAccountPermission>(entity =>
            {
                entity.ToTable("xAccount_Permission");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.CodeNo)
                    .HasMaxLength(25)
                    .HasColumnName("CODE_NO");

                entity.Property(e => e.UpperGuid)
                    .HasMaxLength(40)
                    .HasColumnName("UPPER_GUID");
            });

            modelBuilder.Entity<XAccountGroupPermission>(entity =>
            {
                entity.ToTable("xAccountGroup_Permission");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.CodeNo)
                    .HasMaxLength(25)
                    .HasColumnName("CODE_NO");

                entity.Property(e => e.UpperGuid)
                    .HasMaxLength(40)
                    .HasColumnName("UPPER_GUID");
            });

            modelBuilder.Entity<XAccountRole>(entity =>
            {
                entity.ToTable("xAccount_Role");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.AccountGuid)
                    .HasMaxLength(40)
                    .HasColumnName("Account_GUID");

                entity.Property(e => e.CodeNo)
                    .HasMaxLength(25)
                    .HasColumnName("CODE_NO");
            });

            modelBuilder.Entity<XAccountSetting>(entity =>
            {
                entity.ToTable("xAccount_Setting");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.AccountGuid)
                    .HasMaxLength(40)
                    .HasColumnName("Account_GUID");

                entity.Property(e => e.ControllerName)
                    .HasMaxLength(200)
                    .HasColumnName("Controller_Name");

                entity.Property(e => e.ControllerValue)
                    .HasMaxLength(200)
                    .HasColumnName("Controller_Value");

                entity.Property(e => e.Page).HasMaxLength(200);
            });

            modelBuilder.Entity<ReportConfig>(entity =>
            {
                entity.ToTable("Report_Config");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Comment).HasMaxLength(100);

                entity.Property(e => e.Slcn)
                    .HasMaxLength(500)
                    .HasColumnName("SLCN");

                entity.Property(e => e.Slen)
                    .HasMaxLength(500)
                    .HasColumnName("SLEN");

                entity.Property(e => e.Slkey)
                    .HasMaxLength(50)
                    .HasColumnName("SLKey");

                entity.Property(e => e.Slpage)
                    .HasMaxLength(50)
                    .HasColumnName("SLPage");

                entity.Property(e => e.Sltw)
                    .HasMaxLength(500)
                    .HasColumnName("SLTW");

                entity.Property(e => e.Sltype)
                    .HasMaxLength(50)
                    .HasColumnName("SLType");

                entity.Property(e => e.Slvn)
                    .HasMaxLength(500)
                    .HasColumnName("SLVN");

                entity.Property(e => e.Sequence)
                   .HasColumnType("numeric(18, 0)")
                    .HasColumnName("Sequence");

                entity.Property(e => e.ColumnWidth)
                   .HasColumnType("numeric(18, 0)")
                    .HasColumnName("ColumnWidth");

                entity.Property(e => e.SystemMenuGuid)
                 .HasMaxLength(40)
                 .HasColumnName("SystemMenuGuid");


            });

            modelBuilder.Entity<StoredProcedure>(entity =>
            {
                entity.ToTable("StoredProcedures");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");
                entity.Property(e => e.StoredName)
                    .HasMaxLength(100)
                    .HasColumnName("Stored_Name");
                entity.Property(e => e.Legend)
                 .HasMaxLength(200);

                entity.Property(e => e.StoredType)
                   .HasMaxLength(20)
                   .HasColumnName("Stored_Type");
                entity.Property(e => e.Color)
                 .HasMaxLength(20)
                 .HasColumnName("Color");

                entity.Property(e => e.Comment)
                    .HasColumnType("ntext")
                    .HasColumnName("COMMENT");

                entity.Property(e => e.CreateBy)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("CREATE_BY");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.Guid)
                    .HasMaxLength(40)
                    .HasColumnName("GUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Status)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("STATUS");

                entity.Property(e => e.UpdateBy)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("UPDATE_BY");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UPDATE_DATE");

                entity.Property(e => e.SystemMenuGuid)
                    .HasMaxLength(40)
                    .HasColumnName("SystemMenuGuid");
            });
            
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            //Tự động cập nhật ngày giờ thêm mới và chỉnh sửa
            AutoAddDateTracking();
            return (await base.SaveChangesAsync(true, cancellationToken));
        }
#if DEBUG
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.EnableSensitiveDataLogging().EnableDetailedErrors();
#endif
        public void AutoAddDateTracking()
        {
            var modified = ChangeTracker.Entries().Where(e => e.State == EntityState.Modified || e.State == EntityState.Added);
            foreach (EntityEntry item in modified)
            {
                var changedOrAddedItem = item.Entity;
                if (changedOrAddedItem != null)
                {
                    if (item.State == EntityState.Added)
                    {
                        SetValueProperty(ref changedOrAddedItem, "CreateDate", "CreateBy");
                    }
                    if (item.State == EntityState.Modified)
                    {
                        SetValueProperty(ref changedOrAddedItem, "UpdateDate", "UpdateBy");
                        SetDeleteValueProperty(ref changedOrAddedItem);


                    }
                }
            }
        }
        public decimal? GetPropValue(object src, string propName)
        {
            return (decimal?)src.GetType().GetProperty(propName).GetValue(src, null);
        }
        public void SetDeleteValueProperty(ref object changedOrAddedItem)
        {
            string deleteDate = "DeleteDate";
            string status = "Status";
            string deleteBy = "DeleteBy";
            Type type = changedOrAddedItem.GetType();
            PropertyInfo propAdd = type.GetProperty(deleteDate);
            PropertyInfo propStatus = type.GetProperty(status);


            if (propStatus != null && propStatus.PropertyType.Name == "Decimal")
            {
                var statusValue = (decimal?)propStatus.GetValue(changedOrAddedItem, null);
                if (statusValue == 0)
                {
                    if (propAdd != null)
                    {
                        propAdd.SetValue(changedOrAddedItem, DateTime.Now, null);
                    }
                    var httpContext = _contextAccessor.HttpContext;
                    if (httpContext != null)
                    {
                        var accessToken = httpContext.Request.Headers["Authorization"];
                        var accountID = JWTExtensions.GetDecodeTokenByID(accessToken).ToDecimal();
                        PropertyInfo propCreateBy = type.GetProperty(deleteBy);
                        if (propCreateBy != null)
                        {
                            if (accountID > 0)
                            {
                                propCreateBy.SetValue(changedOrAddedItem, accountID, null);
                            }
                        }
                    }
                }

            }

        }
        public void SetValueProperty(ref object changedOrAddedItem, string propDate, string propUser)
        {
            Type type = changedOrAddedItem.GetType();
            PropertyInfo propAdd = type.GetProperty(propDate);
            if (propAdd != null)
            {
                propAdd.SetValue(changedOrAddedItem, DateTime.Now, null);
            }
            var httpContext = _contextAccessor.HttpContext;
            if (httpContext != null)
            {
                var accessToken = httpContext.Request.Headers["Authorization"];
                var accountID = JWTExtensions.GetDecodeTokenByID(accessToken).ToDecimal();
                PropertyInfo propCreateBy = type.GetProperty(propUser);
                if (propCreateBy != null)
                {
                    if (accountID > 0)
                    {
                        propCreateBy.SetValue(changedOrAddedItem, accountID, null);
                    }
                }
            }
        }
    }
}
