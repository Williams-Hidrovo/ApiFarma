using Microsoft.EntityFrameworkCore;

namespace ApiFarma.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
    }
}
