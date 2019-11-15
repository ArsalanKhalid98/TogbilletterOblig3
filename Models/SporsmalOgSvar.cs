using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TogbilletterOblig3.Models
{
    public class SporsmalOgSvar
    {
        [Key]
        public int id { get; set; }
        public virtual Svar svar { get; set; }
        public virtual Sporsmal sp { get; set; }

    }
}
