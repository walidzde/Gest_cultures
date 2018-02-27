using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Gest_Cultures.DAO
{
    public class SqlConnectionOffline
    {
        public SqlConnection connextion;
        public SqlCommandBuilder cmd;
        //private DataTable dt;
        public DataSet ds;
        public String Requete;
        private SqlDataAdapter da;




        public SqlConnectionOffline(String Requete)
        {

            connextion = new SqlConnection(@"Data Source=DELL\SQLEXPRESS;Initial Catalog=Gest_Cultures;Integrated Security=True");
            this.Requete = Requete;
            da = new SqlDataAdapter(Requete, connextion);
            ds = new DataSet();
            da.Fill(ds);

        }


        public void fillDs(string Requete)
        {
            
            ds = new DataSet();
            da.Fill(ds);


        }

        public void enregistrer(string SrcTable)
        {
            cmd = new SqlCommandBuilder(da);
            da.Update(ds, SrcTable);
        }
    }
}
