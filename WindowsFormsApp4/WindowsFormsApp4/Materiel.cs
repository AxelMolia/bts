using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    class materiel
    {
        private string idM;
        private string processeur;
        private string disque;
        private string memoire;
        private DateTime dateAchat;
        private string garantie;
        private string prix;

        public string IdM { get => idM; set => idM = value; }
        public string Processeur { get => processeur; set => processeur = value; }
        public string Disque { get => disque; set => disque = value; }
        public string Memoire { get => memoire; set => memoire = value; }
        public DateTime DateAchat { get => dateAchat; set => dateAchat = value; }
        public string Garantie { get => garantie; set => garantie = value; }
        public string Prix { get => prix; set => prix = value; }

        public materiel(String unIdM, String unProcesseur, String unDisque, String uneMemoire, DateTime uneDateAchat, String uneGarantie, String unPrix)
        {
            idM = unIdM;
            processeur = unProcesseur;
            disque = unDisque;
            memoire = uneMemoire;
            dateAchat = uneDateAchat;
            Garantie = uneGarantie;
            prix = unPrix;
            
        }
    }
}