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
    public class ParcelleMetier
    {
        public SqlServerConnection conx = new SqlServerConnection();


        #region mes methodes
        public void AjouterParcelle(Models.Parcelle P)
        {
            conx.Query("insert into Parcelle values (@1,@2,@3,@4,@5,@6)");
            conx.cmd.Parameters.AddWithValue("@1", P._numparcelle);
            conx.cmd.Parameters.AddWithValue("@2", P._nomparcelle);
            conx.cmd.Parameters.AddWithValue("@3", P._surface);
            conx.cmd.Parameters.AddWithValue("@4", P._typesol);
            conx.cmd.Parameters.AddWithValue("@5", P._profondeur);
            conx.cmd.Parameters.AddWithValue("@6", P._adress); 
            conx.ExecuteNonQuery();
        }
        #endregion
    }
}
