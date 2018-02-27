using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Gest_Cultures.Models
{
    public class Culture
    {
        public int _numCulture{get;set;}
        public string _nomCulture { get; set; }
        public int _coefExportGrain { get; set; }
        public int _coefExportPaille { get; set; }
        public bool _phytoSanitaire { get; set; }
        public Culture() { }
        public Culture(int numCulture, string nomCulture, int coefExportGrain, int coefExportPaille, bool phytoSanitaire)
        {
           _numCulture = numCulture;
           _nomCulture = nomCulture;
           _coefExportGrain = coefExportGrain;
           _coefExportPaille = coefExportPaille;
           _phytoSanitaire = phytoSanitaire;
        }
    }
}
