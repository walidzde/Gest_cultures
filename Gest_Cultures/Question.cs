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

namespace Gest_Cultures
{
    public partial class Question : Form
    {
        public Question()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Parcellee p = new Parcellee();
            p.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Question_4 q = new Question_4();
            q.Show();
        }

        private void btn_q2A_Click(object sender, EventArgs e)
        {
            CultureFrom c = new CultureFrom();
            c.Show();
        }

        private void btn_q2B_Click(object sender, EventArgs e)
        {
            Variete v = new Variete();
            v.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            PhytoSanitaireForm ps = new PhytoSanitaireForm();
            ps.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Question_Load(object sender, EventArgs e)
        {
            TraitementPhytoMetier tmp=new TraitementPhytoMetier();
            dataGridView1.DataSource = tmp.ReturnEmergencyTraitement();
        }
    }
}
