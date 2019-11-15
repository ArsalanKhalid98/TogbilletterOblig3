using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TogbilletterOblig3.Models
{
    public class DBSeed
    {

        public static void Initialize(IServiceProvider serviceProvider)
        {
            /*var dbContext = serviceProvider.GetRequiredService<DB>();
            dbContext.Database.EnsureCreated();


            if (dbContext.Sporsmaler.Any())
             {
                 return;
             }
            

            var sporsmal1 = new Sporsmal
            {
                sp = "Hvordan har du det?"
            };

            var sporsmal2 = new Sporsmal
            {
                sp = "Hvordan kjøper jeg billett?"
            };

            var svar1 = new Svar
            {
                svar = "Det går greit.",
            };

            var svar2 = new Svar
            {
                svar = "Gå til nettsiden vår og kjøp der.",
            };

            dbContext.Sporsmaler.Add(sporsmal1);
            dbContext.Sporsmaler.Add(sporsmal2);

            dbContext.Svarer.Add(svar1);
            dbContext.Svarer.Add(svar2);

            dbContext.SaveChanges();
            */
        }

    }
}
