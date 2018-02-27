using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gest_Cultures.Models
{
    class Variete
    {
        public int _num{get;set;}
        public string _nomVariete { get; set; }
        public Culture _culture { get; set; }

        public Variete() { }
        public Variete(int num, string nomVariete, Culture culture)
        {
            _num = num;
            _nomVariete = nomVariete;
            _culture = culture;
        }
    
    }
}
