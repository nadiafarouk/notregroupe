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
    public partial class FenetreConnect : Form
    {
        FenetreAcceuil fa = new FenetreAcceuil();
        public FenetreConnect()
        {
            InitializeComponent();
        }

        private void btValider_Click(object sender, EventArgs e)
        {
            PersonneServices s = new PersonneServices();
            Personne p = null;
            p = s.GetPersonneByIdMdp(txtConnectMail.Text, txtConnectPass.Text);

            if (p == null)
            {
                MessageBox.Show("Id ou Mdp incorrect");
            }
            else
            {
                MessageBox.Show("vous ete connecté");
            }
            this.Hide();
            fa.ShowDialog();

        }
    }
}
