using System.Diagnostics.Metrics;
using Microsoft.EntityFrameworkCore;
using Reservation.Models;

namespace Reservation.Infrastructure
{
    public class ReservationDbContext(DbContextOptions<ReservationDbContext> dbContextOptions) : DbContext(dbContextOptions)
    {
        public DbSet<Counter> Counters { get; set; }
    }
}
