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
    class VarieteMetier
    {
        public SqlServerConnection conx { get; set; }

        #region mes methodes
        /* ajout*/
        public void AjouterVariete(Models.Variete V)
        {
            conx.Query("insert into Variete values (@1,@2,@3,@4,@5)");
            conx.cmd.Parameters.AddWithValue("@1", V._num);
            conx.cmd.Parameters.AddWithValue("@2", V._nomVariete);
            conx.cmd.Parameters.AddWithValue("@3", V._culture._numCulture);
            
            conx.ExecuteNonQuery();

        }
        //pour retourner tous les variete 
        public List<Models.Variete> list()
        {
            List<Models.Variete> list = new List<Models.Variete>();
            conx.Query("select * from variete");
            Culture c=new Culture();
            foreach (DataRow data in conx.DataTable().Rows)
                
            {
                c._numCulture=((int)data[2]);
               list.Add(new Models.Variete((int)data[0], (string)data[1],c) );
            }
            return list;
        }
        public void ModifierVariete(Models.Variete V)
        {
            conx.Query(@"update Variete set nomVariete=@2,numCulture=@3
                        where num=@1 ");
            conx.cmd.Parameters.AddWithValue("@2", V._nomVariete);
            conx.cmd.Parameters.AddWithValue("@3", V._culture._numCulture);
            conx.cmd.Parameters.AddWithValue("@1", V._num);
            conx.ExecuteNonQuery();

        }
        public void SupprimerVariete(Models.Variete V)
        {
            conx.Query(@"delete from culture where  num=@1 ");
            conx.cmd.Parameters.AddWithValue("@1", V._num);
            conx.ExecuteNonQuery();
        }
        #endregion
    }
}
