using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Application.Interfaces;

public interface IDataBaseContext
{
    DbSet<SampleEntity_Person> SampleEntity_Persons { get; set; }
    int SaveChanges(); 
    Task<int> SaveChangesAsync(CancellationToken cancellationToken);

}