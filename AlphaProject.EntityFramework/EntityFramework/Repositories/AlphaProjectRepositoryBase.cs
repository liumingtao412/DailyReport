using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace AlphaProject.EntityFramework.Repositories
{
    public abstract class AlphaProjectRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<AlphaProjectDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected AlphaProjectRepositoryBase(IDbContextProvider<AlphaProjectDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class AlphaProjectRepositoryBase<TEntity> : AlphaProjectRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected AlphaProjectRepositoryBase(IDbContextProvider<AlphaProjectDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
