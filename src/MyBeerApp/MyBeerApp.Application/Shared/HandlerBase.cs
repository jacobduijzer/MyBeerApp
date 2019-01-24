using MyBeerApp.Domain.Shared;

namespace MyBeerApp.Application.Shared
{
    public class HandlerBase<T>
        where T : BaseEntity
    {
        protected IRepository<T> Repository;

        public HandlerBase(IRepository<T> repository) =>
            Repository = repository;
    }
}