using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gest_Cultures.Models
{
    public class CultureParParcelle
    {
        public int _NParcelle {get;set;}
            public int _RefCulture{get;set;}
            public int _Saison{get;set;}
            public float _RendementPrevue{get;set;}
            public float _RendementRealise { get; set; }

            public CultureParParcelle() { }
            public CultureParParcelle(int NParcelle, int RefCulture, int Saison, float RendementPrevue, float RendementRealise)
            {
                _NParcelle = NParcelle;
                _RefCulture = RefCulture;
                _Saison = Saison;
                _RendementPrevue = RendementPrevue;
                _RendementRealise = RendementRealise;
            }
    }
}
