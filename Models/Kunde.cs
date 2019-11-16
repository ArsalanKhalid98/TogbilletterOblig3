using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TogbilletterOblig3.Models
{
    public class Kunde
    {
        public int ID { get; set; }
        [Required]
        public string Navn { get; set; }
        [Required]
        public string Epost { get; set; }
        [Required]
        public string Sporsmal { get; set; }
    }
}
