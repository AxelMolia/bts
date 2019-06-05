using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    class BD
    {
        
        public static void enregistrerSalarie(salarie unSalarie)
        {
            string connString = "Server = 127.0.0.1; Database = gsb_medic;Uid=dev;password=admin;SslMode=none;";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO salarie VALUES (@Matricule, @Nom, @Prenom, @DateEmbauche)";
            cmd.Parameters.AddWithValue("@Matricule", unSalarie.Matricule1);
            cmd.Parameters.AddWithValue("@Nom", unSalarie.Nom1);
            cmd.Parameters.AddWithValue("@Prenom", unSalarie.Prenom1);
            cmd.Parameters.AddWithValue("@DateEmbauche", unSalarie.DateEmbauche1);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Ajouter à la base !");
            conn.Close();
        }

        public static void supprimerSalarie (string supprimerSalarie)
        {
            string connString = "Server = 127.0.0.1; Database = gsb_medic;Uid=dev;password=admin;SslMode=none;";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM salarie WHERE Matricule='" + supprimerSalarie + "'";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Supprimer de la base !");
            conn.Close();
        }

        public static List<salarie> selectSalarie()
        {
            List<salarie> LesSalaries = new List<salarie>();

            string connString = "Server = 127.0.0.1; Database = gsb_medic;Uid=dev;password=admin;SslMode=none;";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT Matricule, Nom, Prenom, DateEmbauche FROM salarie";
            MySqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                salarie unSalarie = new salarie (Convert.ToString (dataReader["Matricule"]), Convert.ToString (dataReader["Nom"]), Convert.ToString (dataReader["Prenom"]), Convert.ToString (dataReader["DateEmbauche"]));

                LesSalaries.Add(unSalarie);
            }

            conn.Close();
            return LesSalaries;
        }

        public static void modifNom(string matriculeValue, string nomValue)
        {
            string connString = "Server = 127.0.0.1; Database = gsb_medic;Uid=dev;password=admin;SslMode=none;";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE salarie set Nom = '" + nomValue + "' where Matricule = '" + matriculeValue + "'";
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            MessageBox.Show("Salarie modifié !");
            conn.Close();
        }
        public static void modifPrenom(string matriculeValue, string prenomValue)
        {
            string connString = "Server = 127.0.0.1; Database = gsb_medic;Uid=dev;password=admin;SslMode=none;";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE salarie set Prenom = '" + prenomValue + "' where Matricule = '" + matriculeValue + "'";
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            MessageBox.Show("Salarie modifié !");
            conn.Close();
        }
        public static void modifDate(string matriculeValue, string dateValue)
        {
            string connString = "Server = 127.0.0.1; Database = gsb_medic;Uid=dev;password=admin;SslMode=none;";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE salarie set DateEmbauche = '" + dateValue + "' where Matricule = '" + matriculeValue + "'";
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            MessageBox.Show("Salarie modifié !");
            conn.Close();
        }


        public static void enregistrerDemande(Demande uneDemande)
        {
            string connString = "Server = 127.0.0.1; Database = gsb_medic;Uid=dev;password=admin;SslMode=none;";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO demande (Id, MatConserne, Objet, Date, NivUrg, Etat) VALUES (@Id, @MatConserne, @Objet, @Date, @NivUrg,'déclaré')";
            cmd.Parameters.AddWithValue("@Id", uneDemande.Id1);
            cmd.Parameters.AddWithValue("@MatConserne", uneDemande.MatConserne1);
            cmd.Parameters.AddWithValue("@Objet", uneDemande.Objet1);
            cmd.Parameters.AddWithValue("@Date", uneDemande.Date1);
            cmd.Parameters.AddWithValue("@NivUrg", uneDemande.NivUrg1);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Ajouter à la base !");
            conn.Close();
        }

        public static List<Demande> selectDemande()
        {
            List<Demande> LesDemandes = new List<Demande>();

            string connString = "Server = 127.0.0.1; Database = gsb_medic;Uid=dev;password=admin;SslMode=none;";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT Id, MatConserne, Objet, Date, NivUrg, Etat FROM Demande";
            MySqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                Demande laDemande = new Demande(Convert.ToInt32(dataReader["Id"]), Convert.ToString(dataReader["MatConserne"]), Convert.ToString(dataReader["Objet"]), Convert.ToDateTime(dataReader["Date"]), Convert.ToString(dataReader["NivUrg"]));
                LesDemandes.Add(laDemande);
            }

            conn.Close();
            return LesDemandes;
        }

        public static void supprimerDemande(string supprimerDemande)
        {
            string connString = "Server = 127.0.0.1; Database = gsb_medic;Uid=dev;password=admin;SslMode=none;";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM Demande WHERE Id='" + supprimerDemande + "'";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Supprimer de la base !");
            conn.Close();
        }

        public static void AffecterUnTech (int matricule, int idDemande )
        {
            string connString = "Server = 127.0.0.1; Database = gsb_medic;Uid=dev;password=admin;SslMode=none;";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE Demande set Technicien =@matricule, Etat = 'Affecter' WHERE Id =@id";
            cmd.Parameters.AddWithValue("@matricule", matricule);
            cmd.Parameters.AddWithValue("@id", idDemande);
            cmd.ExecuteNonQuery();
            MessageBox.Show("La demande a bien été affecter au technicien !");
            conn.Close();
        }

        public static void FinTravail (string FinTravail, int idDemande)
        {
            string connString = "Server = 127.0.0.1; Database = gsb_medic;Uid=dev;password=admin;SslMode=none;";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE Demande set Travail = @finTravail, Etat = 'Travail terminé' WHERE Id =@id";
            cmd.Parameters.AddWithValue("@finTravail", FinTravail);
            cmd.Parameters.AddWithValue("@id", idDemande);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Le travail sur la demande à bien été effctuer !");
            conn.Close();
        }

        public static void enregistrerMateriel(materiel unMateriel)
        {
            string connString = "Server = 127.0.0.1; Database = gsb_medic;Uid=dev;password=admin;SslMode=none;";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO materiel VALUES (@idM, @processeur, @disque, @memoire, @dateAchat, @garantie, @prix)";
            cmd.Parameters.AddWithValue("@idM", unMateriel.IdM);
            cmd.Parameters.AddWithValue("@processeur", unMateriel.Processeur);
            cmd.Parameters.AddWithValue("@disque", unMateriel.Disque);
            cmd.Parameters.AddWithValue("@memoire", unMateriel.Memoire);
            cmd.Parameters.AddWithValue("@dateAchat", unMateriel.DateAchat);
            cmd.Parameters.AddWithValue("@garantie", unMateriel.Garantie);
            cmd.Parameters.AddWithValue("@prix", unMateriel.Prix);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Ajouter à la base !");
            conn.Close();
        }

        public static List<materiel> selectMateriel()
        {
            List<materiel> LesMateriels = new List<materiel>();

            string connString = "Server = 127.0.0.1; Database = gsb_medic;Uid=dev;password=admin;SslMode=none;";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT idM, processeur, disque, memoire, dateAchat, garantie, prix FROM materiel";
            MySqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                materiel unMateriel = new materiel(Convert.ToString(dataReader["idM"]), Convert.ToString(dataReader["processeur"]), Convert.ToString(dataReader["disque"]), Convert.ToString(dataReader["memoire"]), Convert.ToDateTime(dataReader["dateAchat"]), Convert.ToString(dataReader["garantie"]), Convert.ToString(dataReader["prix"]));
                LesMateriels.Add(unMateriel);
            }

            conn.Close();
            return LesMateriels;
        }

        public static void supprimerMateriel(string supprimerMateriel)
        {
            string connString = "Server = 127.0.0.1; Database = gsb_medic;Uid=dev;password=admin;SslMode=none;";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM materiel WHERE idM='" + supprimerMateriel + "'";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Supprimer de la base !");
            conn.Close();
        }

        public static void enregistrerTech(tech unTech)
        {
            string connString = "Server = 127.0.0.1; Database = gsb_medic;Uid=dev;password=admin;SslMode=none;";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO technicien VALUES (@MatriculeT, @Nom, @Prenom, @NivInterv, @Formation, @Competence)";
            cmd.Parameters.AddWithValue("@MatriculeT", unTech.matriculeT);
            cmd.Parameters.AddWithValue("@Nom", unTech.nom);
            cmd.Parameters.AddWithValue("@Prenom", unTech.prenom);
            cmd.Parameters.AddWithValue("@NivInterv", unTech.nivInterv);
            cmd.Parameters.AddWithValue("@Formation", unTech.formation);
            cmd.Parameters.AddWithValue("@Competence", unTech.competence);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Ajouter à la base !");
            conn.Close();
        }

        public static void supprimerTech(string supprimerTech)
        {
            string connString = "Server = 127.0.0.1; Database = gsb_medic;Uid=dev;password=admin;SslMode=none;";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM technicien WHERE MatriculeT='" + supprimerTech + "'";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Supprimer de la base !");
            conn.Close();
        }

        public static List<tech> selectTech()
        {
            List<tech> LesTechs = new List<tech>();

            string connString = "Server = 127.0.0.1; Database = gsb_medic;Uid=dev;password=admin;SslMode=none;";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT MatriculeT, Nom, Prenom, NivInterv, Formation, Competence FROM technicien";
            MySqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                tech unTech = new tech(Convert.ToString(dataReader["MatriculeT"]), Convert.ToString(dataReader["Nom"]), Convert.ToString(dataReader["Prenom"]), Convert.ToString(dataReader["NivInterv"]), Convert.ToString(dataReader["Formation"]), Convert.ToString(dataReader["Competence"]));
                LesTechs.Add(unTech);
            }

            conn.Close();
            return LesTechs;
        }

        public static void modifNomT(string matriculeValue, string nomTValue)
        {
            string connString = "Server = 127.0.0.1; Database = gsb_medic;Uid=dev;password=admin;SslMode=none;";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE technicien set Nom = '" + nomTValue + "' where MatriculeT = '" + matriculeValue + "'";
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            MessageBox.Show("Technicien modifié !");
            conn.Close();
        }
        public static void modifPrenomT(string matriculeValue, string prenomTValue)
        {
            string connString = "Server = 127.0.0.1; Database = gsb_medic;Uid=dev;password=admin;SslMode=none;";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE technicien set Prenom = '" + prenomTValue + "' where MatriculeT = '" + matriculeValue + "'";
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            MessageBox.Show("Technicien modifié !");
            conn.Close();
        }
        public static void modifNivIntervT(string matriculeValue, string NivIntervTValue)
        {
            string connString = "Server = 127.0.0.1; Database = gsb_medic;Uid=dev;password=admin;SslMode=none;";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE technicien set NivInterv = '" + NivIntervTValue + "' where MatriculeT = '" + matriculeValue + "'";
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            MessageBox.Show("Technicien modifié !");
            conn.Close();
        }
        public static void modifFormationT(string matriculeValue, string FormationTValue)
        {
            string connString = "Server = 127.0.0.1; Database = gsb_medic;Uid=dev;password=admin;SslMode=none;";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE technicien set Formation = '" + FormationTValue + "' where MatriculeT = '" + matriculeValue + "'";
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            MessageBox.Show("Technicien modifié !");
            conn.Close();
        }
        public static void modifComptT(string matriculeValue, string ComptTValue)
        {
            string connString = "Server = 127.0.0.1; Database = gsb_medic;Uid=dev;password=admin;SslMode=none;";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE technicien set Competence = '" + ComptTValue + "' where MatriculeT = '" + matriculeValue + "'";
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            MessageBox.Show("Technicien modifié !");
            conn.Close();
        }
    }
}