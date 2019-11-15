using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TogbilletterOblig3.Models
{
    public class Sporsmal
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string sp { get; set; }
        public int poeng { get; set; }
        public int antallStemmer { get; set; }
        public List<Svar> svar { get; set; }
    }
}
