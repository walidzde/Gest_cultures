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
    public partial class Question_4 : Form
    {
        ProduitphytoMerier PM = new ProduitphytoMerier();
        Produitphyto p = new Produitphyto();
        DataTable dt;
        static int n = 0;

        public Question_4()
        {
            InitializeComponent();
        }
        
        public void navigation()
        {
            txt_ref.Text = dt.Rows[n][0].ToString();
            txt_ref.Text = dt.Rows[n][0].ToString();
            txt_ref.Text = dt.Rows[n][0].ToString();
        }
        private void btn_ajo_Click(object sender, EventArgs e)
        {
            p =new Produitphyto();
            p._RefProduitPhy = int.Parse(txt_ref.Text);
            p._NomCommercial = txt_nom.Text;
            p._Dose = float.Parse(txt_dose.Text);
            p._Cout = float.Parse(txt_cout.Text);
            p._stock = int.Parse(txt_stock.Text);
            p._PrixUnitaire = float.Parse(txt_prixuni.Text);
            PM.AjouterProduitP(p);
        }

        private void btn_mod_Click(object sender, EventArgs e)
        {
            p = new Produitphyto();
            p._RefProduitPhy = int.Parse(txt_ref.Text);
            p._NomCommercial = txt_nom.Text;
            p._Dose = float.Parse(txt_dose.Text);
            p._Cout = float.Parse(txt_cout.Text);
            p._stock = int.Parse(txt_stock.Text);
            p._PrixUnitaire = float.Parse(txt_prixuni.Text);
            bool x=PM.ModifierProduitP(p);
            if (x) { MessageBox.Show("bien modifier"); }
            else { MessageBox.Show("introuvable"); }
        }

        private void btn_sup_Click(object sender, EventArgs e)
        {
            p = new Produitphyto();
            p._RefProduitPhy = int.Parse(txt_ref.Text);
            bool x = PM.ModifierProduitP(p);
            if (x) { MessageBox.Show("bien modifier"); }
            else { MessageBox.Show("introuvable"); }
        }

        private void btn_qui_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("voulez vous vraiment quitter", "quitter", MessageBoxButtons.YesNo)) 
            {
                Close();
            }
        }

        private void Question_4_Load(object sender, EventArgs e)
        {
            dt = PM.Enregistrement();
        }

        private void t3_Click(object sender, EventArgs e)
        {
            n = 0;
            navigation();
        }

        private void t1_Click(object sender, EventArgs e)
        {
            n = PM.Enregistrement().Rows.Count-1;
            navigation();
        }

        private void t2_Click(object sender, EventArgs e)
        {
            if (n >= PM.Enregistrement().Rows.Count) n = 0;
            else n += 1;
            navigation();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            n = (n < 0) ? n = PM.Enregistrement().Rows.Count-1 : n = n - 1;
            navigation();
        }
    }
}
