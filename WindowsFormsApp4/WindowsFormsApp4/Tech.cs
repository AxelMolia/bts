using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    class tech
    {
        private string MatriculeT;
        private string Nom;
        private string Prenom;
        private string NivInterv;
        private string Formation;
        private string Competence;

        public string matriculeT { get => MatriculeT; set => MatriculeT = value; }
        public string nom { get => Nom; set => Nom = value; }
        public string prenom { get => Prenom; set => Prenom = value; }
        public string nivInterv { get => NivInterv; set => NivInterv = value; }
        public string formation { get => Formation; set => Formation = value; }
        public string competence { get => Competence; set => Competence = value; }

        public tech(String unMatriculeT, String unNom, String unPrenom, String unNivInterv, String uneFormation, String uneCompetence)
        {
            MatriculeT = unMatriculeT;
            Nom = unNom;
            Prenom = unPrenom;
            NivInterv = unNivInterv;
            Formation = uneFormation;
            Competence = uneCompetence;
        }
    }
}
