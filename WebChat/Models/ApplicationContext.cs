using Microsoft.EntityFrameworkCore;

namespace WebChat.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Message> Messages { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) => Database.EnsureCreated();
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
