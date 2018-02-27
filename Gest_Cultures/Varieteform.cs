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
    public partial class Variete : Form
    {
        VarieteMetier vm = new VarieteMetier();
        Models.Variete vari = new Models.Variete();
        CultureMetier cm = new CultureMetier();


        public Variete()
        {
            InitializeComponent();
        }

        private void Variete_Load(object sender, EventArgs e)
        {
            RemplirComboBox();
        }


        #region
        public void RemplirComboBox()
        {
            foreach (Culture item in cm.list())
            {
                CB_num.Items.Add(item._numCulture.ToString());
            }
        }
        #endregion

        private void btn_ajo_Click(object sender, EventArgs e)
        {
            vari = new Models.Variete();
            vari._num = int.Parse(txt_num.Text);
            vari._nomVariete = txt_nom.Text;
            vari._culture._numCulture = int.Parse(CB_num.Text);
            vm.AjouterVariete(vari);
            RemplirComboBox();
        }

        private void btn_mod_Click(object sender, EventArgs e)
        {
            vari = new Models.Variete();
            vari._num = int.Parse(txt_num.Text);
            vari._nomVariete = txt_nom.Text;
            vari._culture._numCulture = int.Parse(CB_num.Text);
            vm.ModifierVariete(vari);
            RemplirComboBox();
        }

        private void btn_sup_Click(object sender, EventArgs e)
        {
            vari = new Models.Variete();
            vari._num = int.Parse(txt_num.Text);
            vm.SupprimerVariete(vari);
            RemplirComboBox();
        }

    }
}
