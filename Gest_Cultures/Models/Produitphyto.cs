using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gest_Cultures.Models
{
       public class Produitphyto
    {
            public int _RefProduitPhy {get;set;}
            public string _NomCommercial {get;set;}
            public float _Dose{get;set;}
            public float _Cout{get;set;}
            public int _stock{get;set;}
            public float _PrixUnitaire { get; set; }

            public Produitphyto() { }
            public Produitphyto(int RefProduitPhy, string NomCommercial, float Dose, float Cout, int stock, float PrixUnitaire)
            {
                _RefProduitPhy = RefProduitPhy;
                _NomCommercial = NomCommercial;
                _Dose = Dose;
                _Cout = Cout;
                _stock = stock;
                _PrixUnitaire = PrixUnitaire;
            }
    }
}
