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
    public partial class Parcellee : Form
    {
        ParcelleMetier PM = new ParcelleMetier();
        Models.Parcelle p = new Models.Parcelle();

        public Parcellee()
        {
            InitializeComponent();
        }

        private void btn_ajo_Click(object sender, EventArgs e)
        {
            p = new Models.Parcelle();
            p._numparcelle=int.Parse(txt_nump.Text);
            p._nomparcelle=txt_nomp.Text;
            p._surface=float.Parse(txt_surface.Text);
            p._typesol=txt_type.Text;
            p._profondeur = txt_profondeur.Text;
            p._adress = txt_adresse.Text;
            PM.AjouterParcelle(p);
        }

        private void Parcelle_Load(object sender, EventArgs e)
        {

        }
    }
}
