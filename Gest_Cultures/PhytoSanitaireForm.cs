using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gest_Cultures.DAO;
using Gest_Cultures.Models;
using Gest_Cultures.Metier;

namespace Gest_Cultures
{
    public partial class PhytoSanitaireForm : Form
    {
        public PhytoSanitaireForm()
        {
            InitializeComponent();
        }
        ProduitphytoMerier ppm = new ProduitphytoMerier();
        Produitphyto p = new Produitphyto();
        ParcelleMetier pm = new ParcelleMetier();
        Parcelle pa = new Parcelle();
        TraitementPhyto tp = new TraitementPhyto();
        TraitementPhytoMetier tpm = new TraitementPhytoMetier();

        private void PhytoSanitaireForm_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gest_CulturesDataSet2.Parcelle'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.parcelleTableAdapter1.Fill(this.gest_CulturesDataSet2.Parcelle);
            // TODO: cette ligne de code charge les données dans la table 'gest_CulturesDataSet1.Parcelle'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            ////this.parcelleTableAdapter.Fill(this.gest_CulturesDataSet1.Parcelle);
            // TODO: cette ligne de code charge les données dans la table 'gest_CulturesDataSet.Produit_Phyto'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            //this.produit_PhytoTableAdapter.Fill(this.gest_CulturesDataSet.Produit_Phyto);
            

        }

        private void DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                int a = (int.Parse(DGV.Rows[e.RowIndex].Cells[1].Value.ToString()));
                DGV.Rows[e.RowIndex].Cells[3].Value = ppm.Found(a);
            }
        }

        private void btn_Enregistrer_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow item in DGV.Rows)
            {
                tpm.AjouterTraitementPhytoMetier(new TraitementPhyto
                    ((int)item.Cells[1].Value, (int)item.Cells[2].Value, (DateTime)item.Cells[0].Value, DateTime.Now.AddYears(-25), 0, (float)item.Cells[3].Value));

                



            }
        }
    }
}
