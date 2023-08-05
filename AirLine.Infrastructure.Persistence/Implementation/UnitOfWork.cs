namespace AirLine.Infrastructure.Persistence.Implementation;

public class UnitOfWork : IUnitOfWork
{
    private readonly AirLineDbContext _dbContext;

    public ChangeTracker ChangeTracker => _dbContext.ChangeTracker;

    public DatabaseFacade Databasefacade => _dbContext.Database;

    public UnitOfWork(AirLineDbContext dbContext)
    => _dbContext = dbContext;

    public IGenericRepo<User> Users => _dbContext.GetService<IGenericRepo<User>>();

    public IGenericRepo<Ticket> Tickets => _dbContext.GetService<IGenericRepo<Ticket>>();

    public void Dispose()
    {
        _dbContext.Dispose();
        GC.SuppressFinalize(this);
    }

    public Task<SaveChangeResult> SaveChangesAsync(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
