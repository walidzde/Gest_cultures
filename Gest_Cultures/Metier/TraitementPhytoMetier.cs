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
    public class TraitementPhytoMetier
    {
        public SqlServerConnection conx = new SqlServerConnection();


        #region mes methodes
        public void AjouterTraitementPhytoMetier(Models.TraitementPhyto P)
        {
            conx.Query("insert into TraitementPhyto values (@1,@2,@3,@4,@5,@6)");
            conx.cmd.Parameters.AddWithValue("@1", P._RefProdPhy);
            conx.cmd.Parameters.AddWithValue("@2", P._NumParcelle);
            conx.cmd.Parameters.AddWithValue("@3", P._DatePrevue);
            conx.cmd.Parameters.AddWithValue("@4", P._DateRealisation);
            conx.cmd.Parameters.AddWithValue("@5", P._Quantite);
            conx.cmd.Parameters.AddWithValue("@6", P._Cout);
            conx.ExecuteNonQuery();
        }

        public List<TraitementPhyto> NotDoneTraitement()
        {

            List<TraitementPhyto> tlist = new List<TraitementPhyto>();
            conx.Query(@"select * from Traitement_Phyto where DateRealisation< '01\01\2010'");
            foreach (DataRow item in conx.DataTable().Rows)
	        {
		        tlist.Add(new TraitementPhyto((int) item[0],(int) item[1],(DateTime) item[2],(DateTime) item[3],(int) item[4],(float) item[5]));
	        }
            return tlist;
        }

        
        public DataTable ReturnEmergencyTraitement(){

            DateTime date=DateTime.Now.Date.AddDays(7);
            conx.Query("select * from Traitement_Phyto where DatePrevue <='" + date.ToShortDateString()+"'");
            return conx.DataTable();



        }
        #endregion

    }
}
