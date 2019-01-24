using LinqBuilder.Core;
using Microsoft.EntityFrameworkCore;
using MyBeerApp.Domain.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyBeerApp.Infrastructure.Shared
{
    public class EfRepository<TEntity> : IRepository<TEntity>
         where TEntity : BaseEntity
    {
        private readonly MyBeerAppContext _dbContext;

        public EfRepository(MyBeerAppContext myBeerAppContext) =>
            _dbContext = myBeerAppContext;

        public async Task<List<TEntity>> GetItemsAsync(ISpecification<TEntity> specification) =>
            await _dbContext.Set<TEntity>().ExeSpec(specification).ToListAsync().ConfigureAwait(false);

        public async Task<TEntity> GetSingleItemAsync(ISpecification<TEntity> specification) =>
            await _dbContext.Set<TEntity>().ExeSpec(specification).SingleOrDefaultAsync().ConfigureAwait(false);

        public async Task<TEntity> GetFirstItemAsync(ISpecification<TEntity> specification) =>
            await _dbContext.Set<TEntity>().ExeSpec(specification).FirstOrDefaultAsync().ConfigureAwait(false);

        public async Task UpdateAsync(TEntity updatedItem)
        {
            throw new System.NotImplementedException();
        }
    }
}