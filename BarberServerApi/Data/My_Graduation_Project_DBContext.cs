using BarberServerApi.Models;
using Microsoft.EntityFrameworkCore;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BarberServerApi.Data
{
    public partial class My_Graduation_Project_DBContext : DbContext
    {
        public My_Graduation_Project_DBContext()
        {
        }

        public My_Graduation_Project_DBContext(DbContextOptions<My_Graduation_Project_DBContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<ReservationBarber>(builder =>
            //{
            //    builder.HasMany(e => e.User).WithOne().OnDelete(DeleteBehavior.Restrict);
            //});
        }

        public DbSet<Barber> Barber { get; set; }
        public DbSet<Comments> Comments { get; set; }
        public DbSet<ContactInfo> ContactInfo { get; set; }
        public DbSet<District> District { get; set; }
        public DbSet<EntityPost> EntityPost { get; set; }
        public DbSet<Likes> Likes { get; set; }
        public DbSet<Neighborhood> Neighborhood { get; set; }
        public DbSet<PayingOff> PayingOff { get; set; }
        public DbSet<Personnel> Personnel { get; set; }
        public DbSet<Province> Province { get; set; }
        public DbSet<Reservation> Reservation { get; set; }
        public DbSet<ReservationBarber> ReservationBarber { get; set; }
        public DbSet<User> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("server=.;database=My_Graduation_Project_DB;trusted_connection=true;");
            }
        }

    }
}
