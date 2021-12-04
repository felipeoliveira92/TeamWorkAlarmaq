using Microsoft.EntityFrameworkCore;
using TeamWorkAlarmaq.Enum;
using TeamWorkAlarmaq.Models;

namespace TeamWorkAlarmaq.Data
{
    public class AplicationContext : DbContext
    {
        public AplicationContext(DbContextOptions<AplicationContext> options) 
            : base(options)
        {
            
        }

        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        // {
        //     optionsBuilder.UseSqlServer();
        // }

        public DbSet<User> Users { get; set; }
        public DbSet<Todo> Todos { get; set; }
        public DbSet<Group> Groups { get; set; }
    }
}