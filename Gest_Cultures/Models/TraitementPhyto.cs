using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gest_Cultures.Models
{
    public class TraitementPhyto
    {
        public int _RefProdPhy {get;set;}
            public int _NumParcelle {get;set;}
            public DateTime _DatePrevue{get;set;}
            public DateTime _DateRealisation{get;set;}
            public int _Quantite{get;set;}
            public float _Cout { get; set; }

            public TraitementPhyto() { }
            
        
            public TraitementPhyto(int RefProdPhy, int NomParcelle, DateTime DatePrevue, DateTime DateRealisation, int Quantite, float Cout)
            {
                _RefProdPhy = RefProdPhy;
                _NumParcelle = NomParcelle;
                _DatePrevue = DatePrevue;
                _DateRealisation = DateRealisation;
                _Quantite = Quantite;
                _Cout = Cout;
            }

    }
}
