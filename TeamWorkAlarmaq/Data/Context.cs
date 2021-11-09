using Microsoft.EntityFrameworkCore;
using TeamWorkAlarmaq.Enum;
using TeamWorkAlarmaq.Models;

namespace TeamWorkAlarmaq.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
            
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Todo> Todos { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}