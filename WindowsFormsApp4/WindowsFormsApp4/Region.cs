using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    class Region
    {
        private string Nom;
        private string IdR;

        public string Nom1 { get => Nom; set => Nom = value; }
        public string idR { get => IdR; set => IdR = value; }

        public Region (String unNom, String unIdR)
        {
            Nom = unNom;
            idR = unIdR;
        }
    }
}