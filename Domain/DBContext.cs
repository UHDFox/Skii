using Domain.Entities.SkipassEntity;
using Domain.Entities.Tariff;
using Domain.Entities.Visitor;
using Microsoft.EntityFrameworkCore;

namespace Domain;

public class DBContext : DbContext, IDBContext
{
    public DBContext(DbContextOptions opts) : base(opts)
    {
    }

    public DbSet<Visitor> Visitors { get; set; }
    public DbSet<Tariff> Tariffs { get; }
    public DbSet<SkipassRecord> Skipasses { get; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
    }
}