using Microsoft.EntityFrameworkCore;

namespace session11.Models
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions options): base(options)
        {

        }

        public DbSet<Student> Students { get; set; }
    }
}
