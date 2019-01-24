using LinqBuilder.Core;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyBeerApp.Domain.Shared
{
    public interface IRepository<TEntity>
        where TEntity : BaseEntity
    {
        Task<List<TEntity>> GetItemsAsync(ISpecification<TEntity> specification);

        Task<TEntity> GetSingleItemAsync(ISpecification<TEntity> specification);

        Task<TEntity> GetFirstItemAsync(ISpecification<TEntity> specification);

        Task UpdateAsync(TEntity updatedItem);
    }
}