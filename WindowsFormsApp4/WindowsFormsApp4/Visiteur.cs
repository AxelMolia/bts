using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Visiteur : Form
    {
        public Visiteur()
        {
            InitializeComponent();
        }


        private void buttonAjt_Click(object sender, EventArgs e)
        {
            Demande laDemande = new Demande(Convert.ToInt32(textBoxIdD.Text), textBoxMatConsern.Text, textBoxObjet.Text, dateTimePickerDemande.Value, textBoxNiv.Text);
            BD.enregistrerDemande(laDemande);
        }

        private void buttonRefreshD_Click(object sender, EventArgs e)
        {
            dataGridViewD.DataSource = bindingSource;
            bindingSource.DataSource = BD.selectDemande();
        }

        List<Demande> LesDemandes;
        BindingSource bindingSource, binding2, binding3;

        private void Visiteur_Load_1(object sender, EventArgs e)
        {
            LesDemandes = new List<Demande>();
            bindingSource = new BindingSource();
            binding2 = new BindingSource();
            binding3 = new BindingSource();
        }

        private void buttonSuppr_Click(object sender, EventArgs e)
        {
            BD.supprimerDemande(textBoxIdD.Text);
        }
    }
}      