using System.Collections.Generic;
using Gest_Cultures.DAO;
using Gest_Cultures.Models;
using System.Data;

namespace Gest_Cultures.Metier
{
    public class CultureMetier
    {
        //private Culture _culture { get; set; }
        public SqlServerConnection conx = new SqlServerConnection();

        

        #region mes methodes
        /* ajout*/
        public void AjouterCulture(Culture C)
        {
            conx.Query("insert into Culture values (@1,@2,@3,@4,@5)");
            conx.cmd.Parameters.AddWithValue("@1", C._numCulture);
            conx.cmd.Parameters.AddWithValue("@2", C._nomCulture);
            conx.cmd.Parameters.AddWithValue("@3", C._coefExportGrain);
            conx.cmd.Parameters.AddWithValue("@4", C._coefExportPaille);
            conx.cmd.Parameters.AddWithValue("@5", C._phytoSanitaire);
            conx.ExecuteNonQuery();
       
        }
        //pour retourner tous les culture 
        public List<Culture> list()
        {
            List<Culture> list = new List<Culture>();
            conx.Query("select * from culture");
            foreach (DataRow data in conx.DataTable().Rows)
            {
                list.Add(new Culture((int)data[0], (string)data[1], (int)data[2], (int)data[3], (bool)data[4]));
            }
            return list;
        }
        public void ModifierCulture(Culture C)
        {
            conx.Query(@"update Culture set numCulture=@2,coefExportGrain=@3,coefExportPaille=@4,phytoSanitaire=@5 
                        where numCulture=@1 ");
            conx.cmd.Parameters.AddWithValue("@1", C._numCulture);
            conx.cmd.Parameters.AddWithValue("@2", C._nomCulture);
            conx.cmd.Parameters.AddWithValue("@3", C._coefExportGrain);
            conx.cmd.Parameters.AddWithValue("@4", C._coefExportPaille);
            conx.cmd.Parameters.AddWithValue("@5", C._phytoSanitaire);
            conx.ExecuteNonQuery();

        }
        public void SupprimerCulture(Culture C)
        {
            conx.Query(@"delete from culture where  numCulture=@1 ");
            conx.cmd.Parameters.AddWithValue("@1", C._numCulture);
            conx.ExecuteNonQuery();
        }
        #endregion
    }
}

