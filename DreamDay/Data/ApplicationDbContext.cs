using DreamDay.Database.Core.Enum;
using DreamDay.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DreamDay.Data
{
    //  TUser, TRole, TKey, TUserClaim, TUserRole, TUserLogin, TRoleClaim, TUserToken
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<
        User,
        Role,
        Guid,
        UserClaim,
        UserRole,
        UserLogin,
        RoleClaim,
        UserToken>(options)
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // User - UserProfile (One-to-One)
            modelBuilder.Entity<User>()
                .HasOne(u => u.Profile)
                .WithOne(p => p.User)
                .HasForeignKey<UserProfile>(p => p.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            // User - Couple (One-to-One)
            modelBuilder.Entity<User>()
                .HasOne(u => u.Couple)
                .WithOne(c => c.User)
                .HasForeignKey<Couple>(c => c.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            // User - Planner (One-to-One)
            modelBuilder.Entity<User>()
                .HasOne(u => u.Planner)
                .WithOne(p => p.User)
                .HasForeignKey<Planner>(p => p.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            // User - Vendor (One-to-One)
            modelBuilder.Entity<User>()
                .HasOne(u => u.Vendor)
                .WithOne(v => v.User)
                .HasForeignKey<Vendor>(v => v.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            // Wedding - Couple (Many-to-One)
            modelBuilder.Entity<Wedding>()
                .HasOne(w => w.Couple)
                .WithMany(c => c.Weddings)
                .HasForeignKey(w => w.CoupleId)
                .OnDelete(DeleteBehavior.Cascade);

            // Wedding - Venue (Many-to-One, optional)
            modelBuilder.Entity<Wedding>()
                .HasOne(w => w.Venue)
                .WithMany(v => v.Weddings)
                .HasForeignKey(w => w.VenueId)
                .OnDelete(DeleteBehavior.SetNull);

            // WeddingVendor (Join Table: Many-to-Many between Weddings and Vendors)
            modelBuilder.Entity<WeddingVendor>()
                .HasOne(wv => wv.Wedding)
                .WithMany(w => w.WeddingVendors)
                .HasForeignKey(wv => wv.WeddingId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<WeddingVendor>()
                .HasOne(wv => wv.Vendor)
                .WithMany(v => v.WeddingVendors)
                .HasForeignKey(wv => wv.VendorId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<PlannerVendor>()
                .HasOne(pv => pv.Planner)
                .WithMany(p => p.PlannerVendors)
                .HasForeignKey(pv => pv.PlannerId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<PlannerVendor>()
                .HasOne(pv => pv.Vendor)
                .WithMany(v => v.PlannerVendors)
                .HasForeignKey(pv => pv.VendorId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<PlannerWedding>()
                .HasOne(pw => pw.Planner)
                .WithMany(p => p.PlannerWeddings)
                .HasForeignKey(pw => pw.PlannerId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<PlannerWedding>()
                .HasOne(pw => pw.Wedding)
                .WithMany(w => w.PlannerWeddings)
                .HasForeignKey(pw => pw.WeddingId)
                .OnDelete(DeleteBehavior.Cascade);

            // Vendor - VendorContactInfo (One-to-One)
            modelBuilder.Entity<Vendor>()
                .HasOne(v => v.ContactInfo)
                .WithOne(ci => ci.Vendor)
                .HasForeignKey<VendorContactInfo>(ci => ci.VendorId)
                .OnDelete(DeleteBehavior.Cascade);

            // Wedding - Guest (One-to-Many)
            modelBuilder.Entity<Guest>()
                .HasOne(g => g.Wedding)
                .WithMany(w => w.Guests)
                .HasForeignKey(g => g.WeddingId)
                .OnDelete(DeleteBehavior.Cascade);

            // Wedding - Budget (One-to-One)
            modelBuilder.Entity<Wedding>()
                .HasOne(w => w.Budget)
                .WithOne(b => b.Wedding)
                .HasForeignKey<Budget>(b => b.WeddingId)
                .OnDelete(DeleteBehavior.Cascade);

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<Role>().ToTable("Roles");

            // Seed data for roles and users
            var AdminUser = new User
            {
                Id = Guid.NewGuid(),
                Email = "admin@app.com",
                NormalizedEmail = "ADMIN@APP.COM",
                UserName = UserType.Admin.ToString(),
                NormalizedUserName = UserType.Admin.ToString().ToUpper(),
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "password"),
                EmailConfirmed = true,
                PhoneNumberConfirmed = false,
                TwoFactorEnabled = false,
                LockoutEnabled = false,
                AccessFailedCount = 0,
                RegistrationDate = DateTime.Now,
                SecurityStamp = Guid.NewGuid().ToString(),
                Status = UserStatus.Active,
            };
            var CoupleUser = new User
            {
                Id = Guid.NewGuid(),
                Email = "sam@app.com",
                NormalizedEmail = "SAM@APP.COM",
                UserName = UserType.Couple.ToString(),
                NormalizedUserName = UserType.Couple.ToString().ToUpper(),
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "password"),
                EmailConfirmed = true,
                PhoneNumberConfirmed = false,
                TwoFactorEnabled = false,
                LockoutEnabled = false,
                AccessFailedCount = 0,
                RegistrationDate = DateTime.Now,
                SecurityStamp = Guid.NewGuid().ToString(),
                Status = UserStatus.Active,
            };

            // Seed Data for roles
            var AdminRole = new Role
            {
                Id = Guid.NewGuid(),
                Name = UserType.Admin.ToString(),
                NormalizedName = UserType.Admin.ToString().ToUpper()
            };
            var CoupleRole = new Role
            {
                Id = Guid.NewGuid(),
                Name = UserType.Couple.ToString(),
                NormalizedName = UserType.Couple.ToString().ToUpper()
            };
            var VendorRole = new Role
            {
                Id = Guid.NewGuid(),
                Name = UserType.Vendor.ToString(),
                NormalizedName = UserType.Vendor.ToString().ToUpper()
            };

            // Seed Data for UserRole
            var AdminUserRole = new UserRole
            {
                UserId = AdminUser.Id,
                RoleId = AdminRole.Id
            };

            // Seed Data for CoupleUserRole
            var CoupleUserRole = new UserRole
            {
                UserId = CoupleUser.Id,
                RoleId = CoupleRole.Id
            };
            modelBuilder.Entity<Role>().HasData(
                AdminRole, CoupleRole, VendorRole
            );

            modelBuilder.Entity<User>().HasData(
                AdminUser, CoupleUser
            );

            modelBuilder.Entity<UserRole>().HasData(
                AdminUserRole, CoupleUserRole
            );
        }

        // public DbSet<User> User { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<Couple> Couples { get; set; }
        public DbSet<Planner> Planners { get; set; }
        public DbSet<VendorType> VendorTypes { get; set; }
        public DbSet<Vendor> Vendors { get; set; }
        public DbSet<PlannerVendor> PlannerVendors { get; set; }
        public DbSet<VendorContactInfo> VendorContactInfos { get; set; }
        public DbSet<Venue> Venues { get; set; }
        public DbSet<WeddingVendor> WeddingVendors { get; set; }
        public DbSet<Wedding> Weddings { get; set; }
        public DbSet<Guest> Guests { get; set; }
        public DbSet<Budget> Budgets { get; set; }
        public DbSet<PlannerWedding> PlannerWeddings { get; set; }
    }
}
