using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TogbilletterOblig3.Models.Repository
{
    public interface IDataRepository<TEntity>
    {
        IEnumerable<TEntity> GetAll();
        TEntity Get(int id);
        void Add(TEntity entity);
        int Update(TEntity dbEntity, TEntity entity);
        void Delete(TEntity entity);
    }
}
