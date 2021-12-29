using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Proiect_Master_E_Business_Irimies_Mircea;
using Proiect_Master_E_Business_Irimies_Mircea.Models;

namespace Proiect_Master_E_Business_Irimies_Mircea.Data
{
    public class DbInitializer
    {
        public static void Initialize(LibraryContext context)
        {
            context.Database.EnsureCreated();
            if (context.Jucatori.Any())
            {
                return; // BD a fost creata anterior
            }
            var jucatori = new Jucator[]
            {
 new Jucator{nume="Lebron",prenume="James", inaltime=(float)1.98, greutate=(int)98,
     data_nasterii=DateTime.Parse("1979-09-01"), pozitie="Power forward"},
  new Jucator{nume="Curry",prenume="Stephen", inaltime=(float)1.90, greutate=(int)85,
     data_nasterii=DateTime.Parse("1985-10-01"), pozitie="Shooting guard"},
  new Jucator{nume="Durant",prenume="Kevin", inaltime=(float)2.03, greutate=(int)95,
     data_nasterii=DateTime.Parse("1987-09-20"), pozitie="Small forward"},
            };
            foreach (Jucator j in jucatori)
            {
                context.Jucatori.Add(j);
            }
            context.SaveChanges();
            var antrenori = new Antrenor[]
            {
                new Antrenor{nume = "Popovici", prenume="Greg", data_nasterii=DateTime.Parse("1960-07-04"), statut="Head coach"},
                new Antrenor{nume = "Spoulstra", prenume="Eric", data_nasterii=DateTime.Parse("1975-06-02"), statut="Head coach"},
                new Antrenor{nume = "Reily", prenume="Pat", data_nasterii=DateTime.Parse("1955-05-10"), statut="Assistent coach"},

 };
            foreach (Antrenor a in antrenori)
            {
                context.Antrenori.Add(a);
            }
            context.SaveChanges();
            var echipe = new Echipa[]
            {
  new Echipa{nume_echipa="Los Angeles Lakers"},
  new Echipa{nume_echipa="Golden State Warriors"},
  new Echipa{nume_echipa="Miami Heat"},
            };
            foreach (Echipa e in echipe)
            {
                context.Echipe.Add(e);
            }
            context.SaveChanges();
            var divizi = new Divizie[]
            {
                new Divizie{nume_divizie="Eastern Conference"},
                new Divizie{nume_divizie="Western Conference"},
            };
            foreach (Divizie d in divizi)
            {
                context.Divizii.Add(d);
            }
        }

    }
}
