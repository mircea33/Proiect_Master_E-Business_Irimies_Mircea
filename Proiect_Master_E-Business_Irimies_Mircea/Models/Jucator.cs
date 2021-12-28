using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect_Master_E_Business_Irimies_Mircea.Models
{
    public class Jucator
    {
        public int id { get; set;}
        public string nume { get; set; }
        public string prenume { get; set; }
        public string inaltime { get; set; }
        public float greutate { get; set; }
        public DateTime data_nasterii { get; set; }
        public string pozitie { get; set; }

        public Echipa Echipa { get; set; }
    }
}
