using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RestaurantBookingSystemOfficial.Models;

namespace RestaurantBookingSystemOfficial.Data
{
    public class RestaurantContext : DbContext
    {
        public RestaurantContext (DbContextOptions<RestaurantContext> options)
            : base(options)
        {
        }

        public DbSet<Guest> Guests { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Payment> Payment { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Booking>().ToTable("Booking");
            modelBuilder.Entity<Booking>()
                .HasOne(b => b.Guest)
                .WithOne(g => g.Booking)
                .HasForeignKey<Guest>(b => b.BookingID);

            modelBuilder.Entity<Guest>().ToTable("Guest");
            modelBuilder.Entity<Payment>().ToTable("Payment");
        }
    }
}
