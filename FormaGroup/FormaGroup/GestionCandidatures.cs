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
    public partial class GestionCandidatures: Form
    {
        public GestionCandidatures()
        {
            InitializeComponent();
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

        private void btGestionFormation_Click(object sender, EventArgs e)
        {
            GestionFormation gf = new GestionFormation();
            this.Hide();
            gf.ShowDialog();
        }
    }
}
