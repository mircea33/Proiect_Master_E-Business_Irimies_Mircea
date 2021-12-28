using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect_Master_E_Business_Irimies_Mircea.Models
{
    public class Echipa
    {
        public int id_echipa { get; set; }
        public string nume_echipa { get; set; }
        
        public Divizie Divizie { get; set; }

        public ICollection<Jucator> Jucatori { get; set; }
        public ICollection<Antrenor> Antrenori { get; set; }
    
    }
}