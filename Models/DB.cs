using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TogbilletterOblig3.Models
{

    /*public class DBSpørsmål
    {
        [Key]
        public int id { get; set; }
        public string sp { get; set; }
        public virtual List<DBSvar> svar { get; set; }
    }

    public class DBSvar
    {
        public int id { get; set; }
        public string svar { get; set; }
    }
    */

    public class DB : DbContext
    {
        public DB(DbContextOptions options)
        : base(options) { }

        //public DbSet<Kunde> Kunder { get; set; }
        //public DbSet<Poststed> Poststeder { get; set; }

        public DbSet<Sporsmal> Sporsmaler { get; set; }
        public DbSet<Svar> Svarer { get; set; }



    }


}
