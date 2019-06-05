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
    public partial class Responsable : Form
    {
        public Responsable()
        {
            InitializeComponent();
        }

        List<salarie> LesSalaries;
        List<tech> LesTechs;
        BindingSource bindingSource, binding2, binding3;

        private void Responsable_Load(object sender, EventArgs e)
        {
            LesSalaries = new List<salarie>();
            LesTechs = new List<tech>();
            bindingSource = new BindingSource();
            binding2 = new BindingSource();
            binding3 = new BindingSource();
        }

        private void buttonAjtS_Click(object sender, EventArgs e)
        {
            salarie lesalarie = new salarie(textBoxMatriculeS.Text, textBoxNomS.Text, textBoxPrenomS.Text, textBoxDateS.Text);
            BD.enregistrerSalarie(lesalarie);
        }

        private void buttonSpprS_Click(object sender, EventArgs e)
        {
            BD.supprimerSalarie(textBoxMatriculeS.Text);
        }

        private void buttonRefreshMS_Click(object sender, EventArgs e)
        {
            IdComboBox.Items.Clear();
            LesSalaries = BD.selectSalarie();

            foreach (salarie lesalarie in LesSalaries)
            {
                IdComboBox.Items.Add(lesalarie.Matricule1);
            }
        }

        private void buttonModifS_Click(object sender, EventArgs e)
        {
            if (checkBoxNom.Checked)
            {
                BD.modifNom(IdComboBox.Text, textBoxNomMS.Text);
            }
            if (checkBoxPrenom.Checked)
            {
                BD.modifPrenom(IdComboBox.Text, textBoxPrenomMS.Text);
            }
            if (checkBoxDate.Checked)
            {
                BD.modifDate(IdComboBox.Text, textBoxDateMS.Text);
            }
        }

        private void buttonAjtT_Click(object sender, EventArgs e)
        {
            tech letech = new tech(textBoxMatriculeT.Text, textBoxNomT.Text, textBoxPrenomT.Text, textBoxNivUrgT.Text, textBoxFormationT.Text, textBoxComptT.Text);
            BD.enregistrerTech(letech);
        }

        private void buttonSupprT_Click(object sender, EventArgs e)
        {
            BD.supprimerTech(textBoxMatriculeT.Text);
        }

        private void buttonRefreshMT_Click(object sender, EventArgs e)
        {
            IdComboBoxT.Items.Clear();
            LesTechs = BD.selectTech();

            foreach (tech leTech in LesTechs)
            {
                IdComboBoxT.Items.Add(leTech.matriculeT);
            }
        }

        private void buttonModifT_Click(object sender, EventArgs e)
        {
            if (checkBoxNomT.Checked)
            {
                BD.modifNomT(IdComboBoxT.Text, textBoxNomMT.Text);
            }
            if (checkBoxPrenomT.Checked)
            {
                BD.modifPrenomT(IdComboBoxT.Text, textBoxPrenomMT.Text);
            }
            if (checkBoxNivIntervT.Checked)
            {
                BD.modifNivIntervT(IdComboBoxT.Text, checkBoxNivIntervT.Text);
            }
            if (checkBoxFormationT.Checked)
            {
                BD.modifFormationT(IdComboBoxT.Text, textBoxFormationMT.Text);
            }
            if (checkBoxComptT.Checked)
            {
                BD.modifComptT(IdComboBoxT.Text, textBoxComptMT.Text);
            }
        }
    }
}
