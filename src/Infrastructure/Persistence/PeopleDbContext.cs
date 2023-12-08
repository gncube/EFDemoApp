using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence;

public class PeopleDbContext : DbContext
{
    public PeopleDbContext(DbContextOptions<PeopleDbContext> options) : base(options) { }

    public DbSet<Person> People { get; set; } = default!;
    public DbSet<Address> Addresses { get; set; } = default!;
    public DbSet<Email> Emails { get; set; } = default!;
}

