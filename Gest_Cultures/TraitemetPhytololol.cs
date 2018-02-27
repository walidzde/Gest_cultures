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
    public partial class TraitemetPhytololol : Form
    {
        public TraitemetPhytololol()
        {
            InitializeComponent();
        }
        TraitementPhytoMetier tpm = new TraitementPhytoMetier();
        private void TraitemetPhytololol_Load(object sender, EventArgs e)
        {
            foreach (TraitementPhyto item in tpm.NotDoneTraitement())
            {
                comboBox1.Items.Add(item);
            }
        }
    }
}
