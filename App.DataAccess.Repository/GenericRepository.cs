using App.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DataAccess.Repository
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity>
        where TEntity : class
    {
        protected readonly DbContext context;

        public GenericRepository(DbContext pContext)
        {
            this.context = pContext;
        }
        public void Add(TEntity entity)
        {
            this.context.Set<TEntity>().Add(entity);
        }
    }
}
