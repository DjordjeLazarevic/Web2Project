using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web2Project.Models
{
    public class KorpaProizvod
    {
        public int Id { get; set; }
        public int Kolicina { get; set; }
        public int ProizvodId { get; set; }
        public int KorpaId { get; set; }
        public Korpa Korpa { get; set; }
        public Proizvod Proizvod { get; set; }

        public KorpaProizvod()
        {
            Kolicina = 1;
        }

    }
}
