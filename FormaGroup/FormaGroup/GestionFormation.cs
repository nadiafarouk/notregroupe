using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormaGroup
{
    public partial class GestionFormation : Form
    {
        public GestionFormation()
        {
            InitializeComponent();
        }

        private void btAfficher_Click(object sender, EventArgs e)
        {
            FormationServices fs = new FormationServices();
            dataGridView1.DataSource = fs.GetListeFormation();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormationServices fs = new FormationServices();
            Formation f = new Formation();

            f = fs.ModifierFormation(int.Parse(txtIdFormation.Text), txtIntitule2.Text, txtDescription2.Text);
        }

        private void btCreer_Click(object sender, EventArgs e)
        {

            FormationServices fc = new FormationServices();
            Formation f = new Formation();
            f = fc.CreerFormation(txtIntitule.Text, txtDescription.Text);


        }

        private void btGestionCandidature_Click(object sender, EventArgs e)
        {
            GestionCandidatures gc = new GestionCandidatures();
            this.Hide();
            gc.ShowDialog();
        }

        private void btGestionSession_Click(object sender, EventArgs e)
        {
            GestionSession gs = new GestionSession();
            this.Hide();
            gs.ShowDialog();
        }

        private void btTrombinoscope_Click(object sender, EventArgs e)
        {
            Trombinoscope tr = new Trombinoscope();
            this.Hide();
            tr.ShowDialog();
        }

        private void btGestionFormateur_Click(object sender, EventArgs e)
        {
            GestionFormateur gfr = new GestionFormateur();
            this.Hide();
            gfr.ShowDialog();
        }
    }
}
