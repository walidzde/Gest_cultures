using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gest_Cultures.Models
{
    public class AchatPhytoSanitaire
    {
            public int _Numero {get;set;}
            public DateTime _DateAchat{get;set;}
            public string _CodePhytoSanitaire{get;set;}
            public int _QuantiteAchat{get;set;} 

            public AchatPhytoSanitaire() { }
            public AchatPhytoSanitaire(int Numero, DateTime DateAchat, string CodePhytoSanitaire, int QuantiteAchat)
            {
                _Numero = Numero;
                _DateAchat = DateAchat;
                _CodePhytoSanitaire = CodePhytoSanitaire;
                _QuantiteAchat = QuantiteAchat; 
            }
    }
}
