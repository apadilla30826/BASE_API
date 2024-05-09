using BASE_API.Models;
using Microsoft.EntityFrameworkCore;

namespace BASE_API.Context
{
    public class AppDBContext:DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options): base(options)
        {
            
        }
        public DbSet<Client> Clients { get; set; }
    }
}
