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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        /*


List<salarie> LesSalaries;
BindingSource bindingSource, binding2, binding3;

private void Form1_Load(object sender, EventArgs e)
{
   LesSalaries = new List<salarie>();
   bindingSource = new BindingSource();
   binding2 = new BindingSource();
   binding3 = new BindingSource();
}



private void buttonRefreshD_Click(object sender, EventArgs e)
{
   dataGridView1.DataSource = binding2;
   binding2.DataSource = BD.selectDemande();
}

private void buttonSupprD_Click(object sender, EventArgs e)
{
   BD.supprimerDemande(textBoxId.Text);
}

private void buttonRefreshT_Click(object sender, EventArgs e)
{
   dataGridViewD2.DataSource = binding3;
   binding3.DataSource = BD.selectTechnicien();
}

private void buttonModifS_Click(object sender, EventArgs e)
{
   if (checkBoxNom.Checked)
   {
       BD.modifNom(IdComboBox.Text, textBoxNomMS.Text);
   }
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

private void buttonAffectT_Click(object sender, EventArgs e)
{
   BD.AffecterUnTech(Convert.ToInt16(textBoxTech.Text), Convert.ToInt16(textBoxId.Text));
}

private void buttonFinD_Click(object sender, EventArgs e)
{
   BD.FinTravail (textBoxTE.Text, Convert.ToInt16(textBoxId.Text));
}
*/
    }
}