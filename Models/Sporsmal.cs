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
        public int ID { get; set; }
        [Required]
        [RegularExpression("^[a-zA-ZøæåØÆÅ\\-. ?]{1,100}$")]
        public string sp { get; set; }
        [Required]
        [RegularExpression("^[a-zA-ZøæåØÆÅ\\-. ?]{1,100}$")]
        public string svar { get; set; }
        public int totalOppStemmer { get; set; }
        public int totalStemmer { get; set; }
        public int sporsmalNr { get; set; }
    }
}
