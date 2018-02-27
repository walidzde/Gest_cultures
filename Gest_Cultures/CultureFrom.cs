using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gest_Cultures.Metier;
using Gest_Cultures.Models;

namespace Gest_Cultures
{
    public partial class CultureFrom : Form
    {

        CultureMetier cm = new CultureMetier();
        Culture c = new Culture();

        public CultureFrom()
        {
            InitializeComponent();
        }

        private void CultureFrom_Load(object sender, EventArgs e)
        {
            RemplirComboBox();
        }

        private void btn_ajo_Click(object sender, EventArgs e)
        {
            c = new Culture();
            c._numCulture = int.Parse(txt_num.Text);
            c._nomCulture = txt_nom.Text;
            c._coefExportGrain =int.Parse(txt_ceg.Text);
            c._coefExportPaille= int.Parse(txt_cef.Text);
            if(checkBox1.Checked==true)c._phytoSanitaire=true;
            else c._phytoSanitaire = false;
            cm.AjouterCulture(c);
            RemplirComboBox();
        }

        private void btn_mod_Click(object sender, EventArgs e)
        {
            c = new Culture();
            c._numCulture = int.Parse(txt_num.Text);
            c._nomCulture = txt_nom.Text;
            c._coefExportGrain = int.Parse(txt_ceg.Text);
            c._coefExportPaille = int.Parse(txt_cef.Text);
            if (checkBox1.Checked == true) c._phytoSanitaire = true;
            else c._phytoSanitaire = false;
            cm.ModifierCulture(c);
            RemplirComboBox();
        }

        private void btn_sup_Click(object sender, EventArgs e)
        {
            c = new Culture();
            c._numCulture = int.Parse(txt_num.Text);
            cm.SupprimerCulture(c);
            RemplirComboBox();
        }

        private void CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_num.Text = cm.list()[CB.SelectedIndex]._numCulture.ToString();
            txt_nom.Text = cm.list()[CB.SelectedIndex]._nomCulture.ToString();
            txt_ceg.Text = cm.list()[CB.SelectedIndex]._coefExportGrain.ToString();
            txt_cef.Text = cm.list()[CB.SelectedIndex]._coefExportPaille.ToString();
            if (cm.list()[CB.SelectedIndex]._phytoSanitaire == true) checkBox1.Checked = true;
            else checkBox1.Checked = false;
        }




        #region Les_Methodes_de_base

        public void RemplirComboBox()
        {
            foreach (Culture item in cm.list())
            {
                CB.Items.Add(item._numCulture.ToString() + " " + item._nomCulture.ToString() + " " + item._coefExportGrain.ToString() + " "
                    + item._coefExportPaille.ToString());
            }
        }


        #endregion
    }
}
