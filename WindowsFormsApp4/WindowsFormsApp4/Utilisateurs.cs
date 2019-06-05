using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp4
{
    public partial class Utilisateurs : Form
    {
        public Utilisateurs()
        {
            InitializeComponent();
        }

        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSeCo_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("Server = 127.0.0.1; Database = gsb_medic;Uid=dev;password=admin;SslMode=none;");
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM utilisateurs WHERE Identifiant ='" + textBoxIdU.Text + "' AND MotDePasse = '" + textBoxMdpU.Text + "'", conn);
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            string cmbItemValue = comboBoxType.SelectedItem.ToString();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i]["TypeU"].ToString() == cmbItemValue)
                    {
                        MessageBox.Show("Vous êtes connecté en tant que" + dt.Rows[i][2]);
                        if (comboBoxType.SelectedIndex == 0)
                        {
                            Responsable res = new Responsable();
                            res.Show();
                            this.Hide();
                        }
                        else if (comboBoxType.SelectedIndex == 1)
                        {
                            Visiteur vis = new Visiteur();
                            vis.Show();
                            this.Hide();
                        }
                        else if (comboBoxType.SelectedIndex == 2)
                        {
                            Technicien tec = new Technicien();
                            tec.Show();
                            this.Hide();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Login ou Mot de passe incorrect");
            }
        }  
    }
}
