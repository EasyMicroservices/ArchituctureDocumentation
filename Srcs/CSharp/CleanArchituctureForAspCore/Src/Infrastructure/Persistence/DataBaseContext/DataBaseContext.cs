using Application.Interfaces;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Persistence.EntitiesConfigurations.SampleEntity_Person;

namespace Persistence.DataBaseContext;

public class DataBaseContext : DbContext, IDataBaseContext
{
    public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
    {
    }

    public DbSet<SampleEntity_Person> SampleEntity_Persons { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        new SampleEntity_PersonConfigurations().Configure(modelBuilder.Entity<SampleEntity_Person>());
        base.OnModelCreating(modelBuilder);
    }
}