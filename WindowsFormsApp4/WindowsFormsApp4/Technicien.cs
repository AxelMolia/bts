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
    public partial class Technicien : Form
    {
        public Technicien()
        {
            InitializeComponent();
        }

        private int MatriculeT;
        private string Nom;
        private string Prenom;
        private int NivInterv;
        private string Formation;
        private string Competence;

        public int MatriculeT1 { get => MatriculeT; set => MatriculeT = value; }
        public string Nom1 { get => Nom; set => Nom = value; }
        public string Prenom1 { get => Prenom; set => Prenom = value; }
        public int NivInterv1 { get => NivInterv; set => NivInterv = value; }
        public string Formation1 { get => Formation; set => Formation = value; }
        public string Competence1 { get => Competence; set => Competence = value; }

        public Technicien(int unMatriculeT, String unNom, String unPrenom, int unNivInterv, String uneFormation, String uneCompetence)
        {
            MatriculeT = unMatriculeT;
            Nom = unNom;
            Prenom = unPrenom;
            NivInterv = unNivInterv;
            Formation = uneFormation;
            Competence = uneCompetence;
        }

        private void buttonAjtM_Click(object sender, EventArgs e)
        {
            materiel unMateriel = new materiel(textBoxIdM.Text, textBoxProcesseur.Text, textBoxDisque.Text, textBoxMemoire.Text, dateTimePicker.Value, textBoxGarantie.Text, textBoxPrix.Text);
            BD.enregistrerMateriel(unMateriel);
        }

        private void buttonRefreshM_Click(object sender, EventArgs e)
        {
            dataGridViewM.DataSource = bindingSource;
            bindingSource.DataSource = BD.selectMateriel();
        }

        List<materiel> LesMateriels;
        BindingSource bindingSource, binding2, binding3;

        private void buttonRefreshD_Click(object sender, EventArgs e)
        {
            dataGridViewD.DataSource = binding2;
            binding2.DataSource = BD.selectDemande();
        }

        private void buttonRefreshT_Click(object sender, EventArgs e)
        {
            dataGridViewT.DataSource = binding3;
            binding3.DataSource = BD.selectTech();
        }

        private void buttonAffectT_Click(object sender, EventArgs e)
        {
            BD.AffecterUnTech(Convert.ToInt16(textBoxAffectTech.Text), Convert.ToInt16(textBoxIdD.Text));
        }

        private void buttonFinD_Click(object sender, EventArgs e)
        {
            BD.FinTravail(textBoxTE.Text, Convert.ToInt16(textBoxIdD.Text));
        }

        private void Technicien_Load(object sender, EventArgs e)
        {
            LesMateriels = new List<materiel>();
            bindingSource = new BindingSource();
            binding2 = new BindingSource();
            binding3 = new BindingSource();
        }

        private void buttonSpprM_Click(object sender, EventArgs e)
        {
            BD.supprimerMateriel(textBoxIdM.Text);
        }
    }
}
