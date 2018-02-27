using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Gest_Cultures.DAO;
using Gest_Cultures.Models;

namespace Gest_Cultures.Metier
{
    public  class ProduitphytoMerier
    {
        public SqlConnectionOffline connex = new SqlConnectionOffline("select * from Produit_Phyto");

        public void AjouterProduitP(Produitphyto C)
        {

            DataRow dr = connex.ds.Tables["Produit_Phyto"].NewRow();
            dr[0] = C._RefProduitPhy;
            dr[1] = C._NomCommercial;
            dr[2] = C._Dose;
            dr[3] = C._Cout;
            dr[4] = C._stock;
            dr[5] = C._PrixUnitaire;
            connex.ds.Tables["Produit_Phyto"].Rows.Add(dr);
            connex.enregistrer("Produit_Phyto");
        }

        public bool ModifierProduitP(Produitphyto C)
        {
            bool test = false;
            foreach (DataRow item in connex.ds.Tables["Produit_Phyto"].Rows)
            {
                if (C._RefProduitPhy == int.Parse(item[0].ToString()))
                {
                    test = true;
                    item[1] = C._NomCommercial;
                    item[2] = C._Dose;
                    item[3] = C._Cout;
                    item[4] = C._stock;
                    item[5] = C._PrixUnitaire;
                }
            }
            connex.enregistrer("Produit_Phyto");
            return test;
        }

        public bool SupprimerProduitP(Produitphyto C)
        {
            bool test = false;
            foreach (DataRow item in connex.ds.Tables["Produit_Phyto"].Rows)
            {
                if (C._RefProduitPhy == int.Parse(item[0].ToString()))
                {
                    test = true;
                    item.Delete();
                }
            }
            connex.enregistrer("Produit_Phyto");
            return test;
        }
        public float Found(int s)
        {
            float f = 0;
            
             foreach (DataRow item in connex.ds.Tables["Produit_Phyto"].Rows)
            {
                 if ( s== int.Parse(item[0].ToString()))
                {

                    f = (float)item[2];
                }
             }

             return f;
        }
        public DataTable Enregistrement()
        {
            return connex.ds.Tables["Produit_Phyto"];
        }




    }
}
