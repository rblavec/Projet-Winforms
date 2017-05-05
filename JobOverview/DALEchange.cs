using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace JobOverview
{
    class DALEchange
    {


        public static void ExporterXml(List<TacheProd> listTache)
        {
            // On crée un sérialiseur, en spécifiant le type de l'objet à sérialiser, ici une list de commande et le nom de l'élément xml racine
            XmlSerializer serializer = new XmlSerializer(typeof(List<TacheProd>), new XmlRootAttribute("TachesProduction"));

            using (StreamWriter streamW = new StreamWriter(@"TachesProd.xml"))
            {
                serializer.Serialize(streamW, listTache);
            }
        }
        

        public static List<TacheProd> ImporterXml()
        {
            List<TacheProd> listTache = null;
            
            // On specifie le type d'objet qu'on va utiliser et le fichier racine.
            XmlSerializer deserializer = new XmlSerializer(typeof(List<TacheProd>), new XmlRootAttribute("TachesProduction"));

            using (StreamReader streamW = new StreamReader(@"TacheProduction.xml"))
            {
                // Deserialize renvoie un type object, qu'il faut transtyper. 
                listTache = (List<TacheProd>)deserializer.Deserialize(streamW);
            }

            return listTache;
        }



    }
}
