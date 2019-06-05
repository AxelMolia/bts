using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    class Demande
    {
        private int Id;
        private string MatConserne;
        private string Objet;
        private DateTime Date;
        private string NivUrg;
        private string Etat;
        private int Technicien;

        public int Id1 { get => Id; set => Id = value; }
        public string Objet1 { get => Objet; set => Objet = value; }
        public DateTime Date1 { get => Date; set => Date = value; }
        public string NivUrg1 { get => NivUrg; set => NivUrg = value; }
        public string Etat1 { get => Etat; set => Etat = value; }
        public int Technicien1 { get => Technicien; set => Technicien = value; }
        public string MatConserne1 { get => MatConserne; set => MatConserne = value; }

        public Demande(int unId, String unMatConserne, String unObjet, DateTime uneDate, String unNivUrg)
        {
            Id = unId;
            MatConserne = unMatConserne;
            Objet = unObjet;
            Date = uneDate;
            NivUrg = unNivUrg;
            Etat = "declaré";
        }
    }
}