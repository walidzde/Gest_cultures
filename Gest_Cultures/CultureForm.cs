using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Gest_Cultures.Metier;
using Gest_Cultures.Models;

namespace Gest_Cultures
{
    public partial class CultureForm : Form
    {
        CultureForm C=new CultureForm();
        CultureMetier CM=new CultureMetier();
        public object _numCulture;

        public CultureForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Culture CC in CM.list())
            {
                CB.Items.Add(CC._numCulture+" "+ CC._nomCulture+" "+ CC._coefExportGrain+" "+ CC._coefExportPaille+" "+ CC._phytoSanitaire);

            }
        }

        private void btn_ajo_Click(object sender, EventArgs e)
        {
            C = new Culture();
            C._numCulture = int.Parse(txt_num.Text);
            C._nomCulture = txt_nom.Text;
            C._coefExportGrain = int.Parse(txt_grain.Text);
            C._coefExportPaille = int.Parse(txt_pailles.Text);
            if (check_phyto.CheckState == CheckState.Checked) C._phytoSanitaire = true;
            if (check_phyto.CheckState == CheckState.Unchecked) C._phytoSanitaire = false;
            CM.AjouterCulture(C);
        }
    }
}
