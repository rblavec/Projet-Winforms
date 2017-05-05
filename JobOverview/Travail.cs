using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace JobOverview
{
    public class Travail
    {
        // On decore les différentes propriétés pour permet l'importation du fichier XML en arborescence de fichier .NET.
        [XmlAttribute("Date")]
        public DateTime DateTravail { get; set; }

        [XmlAttribute("Heures")]
        public float Heures { get; set; }

        [XmlAttribute("TauxProduct")]
        public float TauxProductivite { get; set; }

    }
}
