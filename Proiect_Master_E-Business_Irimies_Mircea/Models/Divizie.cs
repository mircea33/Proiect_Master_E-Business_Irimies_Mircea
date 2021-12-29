using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect_Master_E_Business_Irimies_Mircea.Models
{
    public class Divizie
    {
        public int id_conferinta { get; set; }
        public string nume_divizie { get; set; }

        public ICollection<Echipa> Echipe { get; set; }
    }
}