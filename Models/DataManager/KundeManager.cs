using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TogbilletterOblig3.Models.Repository;

namespace TogbilletterOblig3.Models.DataManager
{
    public class KundeManager : IDataRepositoryKunde<Kunde>
    {

        readonly DB db;

        public KundeManager(DB dbContext)
        {
            db = dbContext;
        }

        public IEnumerable<Kunde> GetAllKunde()
        {
            return db.Kunde.ToList();
        }


        public Kunde GetKunde(int id)
        {
            return db.Kunde.FirstOrDefault(e => e.KundeNr == id);
        }

        public void AddKunde(Kunde entity)
        {
            db.Kunde.Add(entity);
            db.SaveChanges();
        }

        public int UpdateKunde(Kunde kunde, Kunde entity)
        {
            kunde.Navn = entity.Navn;
            kunde.Epost = entity.Epost;
            kunde.Sporsmal = entity.Sporsmal;

            db.SaveChanges();
            return 1;
        }

        public void DeleteKunde(Kunde kunde)
        {
            db.Kunde.Remove(kunde);
            db.SaveChanges();
        }
    }
}
