using AirLine.Application.Common;
using AirLine.Domain.Entities;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace AirLine.Application.Interfaces.Repository;

public interface IUnitOfWork : IDisposable
{
    public ChangeTracker ChangeTracker { get; }
    public DatabaseFacade Databasefacade { get; }
    public Task<SaveChangeResult> SaveChangesAsync(CancellationToken cancellationToken);

    public IGenericRepo<User> Users { get; }
    public IGenericRepo<Ticket> Tickets { get; }

}
