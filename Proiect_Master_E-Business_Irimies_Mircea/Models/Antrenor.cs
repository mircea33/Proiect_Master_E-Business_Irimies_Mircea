using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect_Master_E_Business_Irimies_Mircea.Models
{
    public class Antrenor
    {
        public int id_antrenor { get; set; }
        public string nume { get; set; }
        public string prenume { get; set; }
        public DateTime data_nasterii { get; set; }
        public string statut { get; set; }

        public Echipa Echipa { get; set; }
    }
}
