using Microsoft.EntityFrameworkCore;
using AppointSysWeb.Data.Entities;

namespace AppointSysWeb.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
    {
        public DbSet<Shift> Shifts { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<TypeOfService> TypeOfServices { get; set; }
        public DbSet<Affiliate> Affiliates { get; set; }

    }
    
    
}
