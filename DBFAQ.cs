using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TogbilletterOblig3.Models;

namespace TogbilletterOblig3
{
    public class DBFAQ
    {

        private readonly DB db;

        public DBFAQ(DB dbContext)
        {
            db = dbContext;
            // _context = db
        }

        public DBSporsmal HentEttSpørsmål(int id)
        {
            var Sporsmal = db.Sporsmaler.
                Include(v => v.svar).
                FirstOrDefault(s => s.ID == id);
            if (Sporsmal != null)
            {
                Sporsmal.svar = Sporsmal.svar.OrderByDescending(f => f.poeng).ToList();
                return Sporsmal;
            }

            return null;
        }
    }
}
