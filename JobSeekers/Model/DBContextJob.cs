using Microsoft.EntityFrameworkCore;

namespace JobSeekers.Model;

public class DBContextJob : DbContext
{
    public DBContextJob(DbContextOptions<DBContextJob> options) : base(options)
    {

    }

    public DbSet<JSiteHome> jsiteHomes { get; set; }
    public IEnumerable<Controllers.JSiteHome> JSiteHomes { get; internal set; }
}
