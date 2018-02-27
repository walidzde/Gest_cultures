using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gest_Cultures.Models
{
     public class Parcelle
    {
         public int _numparcelle { get; set; }
         public string _nomparcelle { get; set; }
         public float _surface { get; set; }
         public string _typesol { get; set; }
         public string _profondeur { get; set; }
         public string _adress { get; set; }

         public  Parcelle() {}
         public  Parcelle(int numparcelle, string nomparcelle, float surface, string typesol, string profondeur, string adress) 
         {
             _numparcelle = numparcelle;
             _nomparcelle = nomparcelle;
             _surface = surface;
             _typesol = typesol;
             _profondeur = profondeur;
             _adress= adress;
         }
    }
}
