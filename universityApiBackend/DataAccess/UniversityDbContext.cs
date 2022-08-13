using Microsoft.EntityFrameworkCore;
using universityApiBackend.Models.DataModels;

namespace universityApiBackend.DataAccess
{
    public class UniversityDbContext:DbContext
    {
        public UniversityDbContext(DbContextOptions<UniversityDbContext>options):base(options)
        {

        }

        //TODO: Add DbSet (Tables)
        public DbSet<User>?Users { get; set; }
    }
}
