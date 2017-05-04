using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobOverview
{
    public static class DALTache
    {
        ////////////////////////////////////////////////////////////////////////
        ///récupération des personnes de l'équipe Dev Bio humaine
        /////////////////////////////////////////////////////////////////////////
        public static List<Personne> GetPers()
        {
            List<Personne> listPers = new List<Personne>();

            var connectString = Properties.Settings.Default.ProjetWinformsConnection;
            string queryString = @"select * from jo.Personne p
                                inner join jo.Equipe e on p.CodeEquipe=e.CodeEquipe where e.Nom='Dev Bio humaine'";

            using (var connect = new SqlConnection(connectString))
            {
                var command = new SqlCommand(queryString, connect);

                connect.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        GetCommandeFromDataReader(listPers, reader);
                    }
                }
            }

            return listPers;


        }
        private static void GetCommandeFromDataReader(List<Personne> listCom, SqlDataReader reader)
        {

            //todo controle valeurs null à finir
            var pers = new Personne();

            pers.Login = (string)reader["Login"];

            pers.Nom = (string)reader["Nom"];

            pers.Prenom = (string)reader["Prenom"];

            pers.CodeEquipe = (string)reader["CodeEquipe"];

            pers.CodeMetier = (string)reader["CodeMetier"];

            if (reader["Manager"] != DBNull.Value)
                pers.Manager = (string)reader["Manager"];

            pers.TauxProductivite = (float)reader["TauxProductivite"];

            listCom.Add(pers);

        }

        
    }
}
