using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace BookManagementSystem.EntityFramework.Repositories
{
    public abstract class BookManagementSystemRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<BookManagementSystemDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected BookManagementSystemRepositoryBase(IDbContextProvider<BookManagementSystemDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class BookManagementSystemRepositoryBase<TEntity> : BookManagementSystemRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected BookManagementSystemRepositoryBase(IDbContextProvider<BookManagementSystemDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
