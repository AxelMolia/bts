using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    class LogicielInstalles
    {
        private string Nom;
        private string Id;
        private string Version;

        public string Nom1 { get => Nom; set => Nom = value; }
        public string Id1 { get => Id; set => Id = value; }
        public string Version1 { get => Version; set => Version = value; }

        public LogicielInstalles (String unNom, String unId, String uneVersion)
        {
            Nom = unNom;
            Id = unId;
            Version = uneVersion;
        }
    }
}