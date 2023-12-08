using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Infrastructure.Persistence;

public class PeopleDbContextFactory : IDesignTimeDbContextFactory<PeopleDbContext>
{
    public PeopleDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<PeopleDbContext>();
        optionsBuilder.UseSqlite("Data Source=PeopleDb.sqlite");

        return new PeopleDbContext(optionsBuilder.Options);
    }
}

