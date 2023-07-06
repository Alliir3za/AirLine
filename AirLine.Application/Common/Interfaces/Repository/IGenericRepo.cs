using AirLine.Domain.Common.Interface;

namespace AirLine.Application.Interfaces.Repository;

public interface IGenericRepo<TEntity> where TEntity : class, IEntity
{
    public void Add(TEntity entity);
    public Task AddAsync(TEntity entity, CancellationToken cancellationToken);
    public void Remove(TEntity entity);
    public void Update(TEntity entity);
}
