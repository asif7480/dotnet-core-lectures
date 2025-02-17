using Microsoft.EntityFrameworkCore;

namespace session12Crud.Models
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
