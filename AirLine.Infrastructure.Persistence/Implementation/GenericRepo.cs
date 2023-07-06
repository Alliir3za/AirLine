using AirLine.Application.Interfaces.Repository;
using AirLine.Domain.Common.Interface;
using AirLine.Infrastructure.Persistence.AirLDbContext;

namespace AirLine.Infrastructure.Persistence.Implementation;

public class GenericRepo<TEntity> : IGenericRepo<TEntity> where TEntity : class, IEntity
{
    private AirLineDbContext _entity;

    public GenericRepo(AirLineDbContext dbContext)
    => _entity = dbContext;


    public void Add(TEntity entity) => _entity.Add(entity);

    public async Task AddAsync(TEntity entity, CancellationToken cancellationToken) => await _entity.AddAsync(entity, cancellationToken);

    public void Remove(TEntity entity) => _entity.Remove(entity);

    public void Update(TEntity entity) => _entity.Update(entity);
}
