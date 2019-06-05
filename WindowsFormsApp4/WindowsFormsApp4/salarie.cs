using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    class salarie
    {
        private string Matricule;
        private string Nom;
        private string Prenom;
        private string DateEmbauche;

        public string Matricule1 { get => Matricule; set => Matricule = value; }
        public string Nom1 { get => Nom; set => Nom = value; }
        public string Prenom1 { get => Prenom; set => Prenom = value; }
        public string DateEmbauche1 { get => DateEmbauche; set => DateEmbauche = value; }

        public salarie (String unMatricule, String unNom, String unPrenom, String uneDateEmbauche)
        {
            Matricule = unMatricule;
            Nom = unNom;
            Prenom = unPrenom;
            DateEmbauche = uneDateEmbauche;
        }
    }
}