using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TogbilletterOblig3.Models.Repository
{
    public interface IDataRepositoryKunde<TEntity>
    {
        IEnumerable<TEntity> GetAllKunde();
        TEntity GetKunde(int id);
        void AddKunde(TEntity entity);
        int UpdateKunde(TEntity dbEntity, TEntity entity);
        void DeleteKunde(TEntity entity);
    }
}
