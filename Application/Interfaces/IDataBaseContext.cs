namespace Application.Interfaces;

public interface IDataBaseContext
{
    
    int SaveChanges(); 
    Task<int> SaveChangesAsync(CancellationToken cancellationToken);

}