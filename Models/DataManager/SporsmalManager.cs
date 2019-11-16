using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TogbilletterOblig3.Models.Repository;

namespace TogbilletterOblig3.Models.DataManager
{
    public class SporsmalManager : IDataRepository<Sporsmal>
    {

        readonly DB db;

        public SporsmalManager(DB dbContext)
        {
            db = dbContext;
        }

        public IEnumerable<Sporsmal> GetAll()
        {
            return db.Sporsmaler.ToList();
        }

        public Sporsmal Get(long id)
        {
            return db.Sporsmaler
                  .FirstOrDefault(e => e.ID == id);
        }

        public void Add(Sporsmal entity)
        {
            db.Sporsmaler.Add(entity);
            db.SaveChanges();
        }

        public void Update(Sporsmal sporsmal, Sporsmal entity)
        {
            sporsmal.sp = entity.sp;
            sporsmal.svar = entity.svar;
            sporsmal.poeng = entity.poeng;
            sporsmal.antallStemmer = entity.antallStemmer;

            db.SaveChanges();
        }

        public void Delete(Sporsmal sporsmal)
        {
            db.Sporsmaler.Remove(sporsmal);
            db.SaveChanges();
        }
    }
}
