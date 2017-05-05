using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace JobOverview
{
    public class Tache
    {
        #region propriétés

        [XmlIgnore]
        public Guid IdTache { get; set; }

        [XmlAttribute("Libelle")]
        public string Libelle { get; set; }

        [XmlIgnore]
        public bool Annexe { get; set; }

        [XmlAttribute("Activite")]
        public string CodeActivite { get; set; }

        [XmlAttribute("Personne")]
        public string Login { get; set; }

        [XmlIgnore]
        public string Description { get; set; }

        #endregion

    }

    public class TacheProd : Tache
    {

        #region Propriétés
        [XmlIgnore]
        public int Numero { get; set; }

        [XmlAttribute("DureePrev")]
        public float DureePrevue { get; set; }

        [XmlAttribute("DureeRest")]
        public float DureeRestanteEstimee { get; set; }

        [XmlAttribute("Module")]
        public string CodeModule { get; set; }

        [XmlAttribute("Logiciel")]
        public string CodeLogicieModule { get; set; }

        [XmlAttribute("Version")]
        public float NumeroVersion { get; set; }

        public List<Travail> ListTravail { get; set; }
        #endregion


    }


}
