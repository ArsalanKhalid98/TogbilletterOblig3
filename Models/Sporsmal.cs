using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TogbilletterOblig3.Models
{
    public class Sporsmal
    {
        [Key]
        public int ID { get; set; }
        public string sp { get; set; }
    }
}
