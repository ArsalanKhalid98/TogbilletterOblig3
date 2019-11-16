using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TogbilletterOblig3.Models
{
    /*
    public class DBSporsmal
    {
        [Key]
        public int ID { get; set; }
        public string sp { get; set; }
        public int poeng { get; set; }
        public int antallStemmer { get; set; }
        public virtual List<DBSvar> svar { get; set; }
    }

    public class DBSvar
    {
        public int ID { get; set; }
        public string svar { get; set; }
        public int poeng { get; set; }
        public int antallStemmer { get; set; }
    }
    */

    public class DB : DbContext
    {
        public DB(DbContextOptions options)
        : base(options) { }

        //public DbSet<Kunde> Kunder { get; set; }
        //public DbSet<Poststed> Poststeder { get; set; }

        public DbSet<Sporsmal> Sporsmaler { get; set; }
        //public DbSet<SporsmalOgSvar> SporsmalOgSvar { get; set; }
        public DbSet<Kunde> Kunde { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sporsmal>().HasData(new Sporsmal
            {
                ID = 1,
                sp = "Hvorfor går ikke toget fra stasjonen min?",
                svar = "Vi jobber hele tiden med å utvide tilbudet vårt. Beklager for eventuelle problemer.",
                totalOppStemmer = 0,
                totalStemmer = 0,
                sporsmalNr = 1
            }, new Sporsmal
            {
                ID = 2,
                sp = "Hvordan kjøper jeg billett?",
                svar = "Du kan gå inn på nettsiden vår og kjøpe billetter.",
                totalOppStemmer = 0,
                totalStemmer = 0,
                sporsmalNr = 2

            }, new Sporsmal
            {
                ID = 3,
                sp = "Noe gikk galt med bestillingen min. Hva gjør jeg?",
                svar = "Du kan sende epost til oss på Togbillett@Kundeservice.no",
                totalOppStemmer = 0,
                totalStemmer = 0,
                sporsmalNr = 3

            }, new Sporsmal
            {
                ID = 4,
                sp = "Kan jeg ta med barnevogn?",
                svar = "Ja alle togene våres har mulighet for barnevogn.",
                totalOppStemmer = 0,
                totalStemmer = 0,
                sporsmalNr = 4

            }, new Sporsmal
            {
                ID = 5,
                sp = "Jeg ble trukket penger, men fikk ingen billett?",
                svar = "Send oss bilde av betalingen på epost, så skal vi fikse det.",
                totalOppStemmer = 0,
                totalStemmer = 0,
                sporsmalNr = 5

            });

        }


    }


}
