using ASP.NETCore6WebAPICRUDWithEntityFramework_CodeFirstApproach_.Models;
using Microsoft.EntityFrameworkCore;

namespace ASP.NETCore6WebAPICRUDWithEntityFramework_CodeFirstApproach_.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Employee> Employees { get; set; }
    }
}
