using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobOverview
{
    public static class DALLogiciel
    {

        public static BindingList<Module> listModule(string NomLogiciel)
        {
            var listDeModule = new BindingList<Module>();

            var connectString = Properties.Settings.Default.ProjetWinformsConnection;

            // On écrit la requête SQL à exécuter
            string queryString = @"select distinct v.NumeroVersion, v.Millesime, v.DateOuverture, v.DateSortiePrevue, v.DateSortieReelle, MAX(r.NumeroRelease) [Last release]
                                 from jo.Version v
                                 inner join jo.Release r on r.NumeroVersion = v.NumeroVersion
                                 inner join jo.Logiciel l on l.CodeLogiciel = v.CodeLogiciel
                                 where l.Nom = @parametre
                                 group by v.NumeroVersion, v.Millesime, v.DateOuverture, v.DateSortiePrevue, v.DateSortieReelle";

            var param = new SqlParameter("@parametre", DbType.String);
            param.Value = NomLogiciel;

            // On crée une connexion à partir de la chaîne de connexion
            using (var connect = new SqlConnection(connectString))
            {
                // On créé une commande à partir de la requête et en utilisant la connexion définies précédemment
                var command = new SqlCommand(queryString, connect);
                command.Parameters.Add(param);

                // On ouvre la connexion
                connect.Open();

                // On exécute la requête en récupérant son résultat dans un objet SqlDataRedader
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    // On lit et on affiche les lignes de résultat en boucle
                    while (reader.Read())
                    {
                        GetModulesFromDataReader(listDeModule, reader);
                    }
                }
            }
            // Le fait d'avoir créé la connexion dans une instruction using permet de la fermer automatiquement à la fin du bloc using

            return listDeModule;
        }

        private static void GetModulesFromDataReader(BindingList<Module> lstModule, SqlDataReader reader)
        {
            //on créé un nouveau Logiciel, on lui renseigne ses propriétés grâce au DataReader et on l'ajoute à notre collection.
            var mod = new Module();


            if (reader["CodeLogiciel"] != DBNull.Value)
                mod.CodeLogiciel = (string)reader["CodeLogiciel"];


            if (reader["NumeroRelease"] != DBNull.Value)
                mod.NumeroRelease = (Int16)reader["NumeroRelease"];


            if (reader["Nom"] != DBNull.Value)
                mod.NomLogiciel = (string)reader["Nom"];


            if (reader["CodeModule"] != DBNull.Value)
                mod.CodeModule = (string)reader["CodeModule"];


            if (reader["Libelle"] != DBNull.Value)
                mod.LibelleModule = (string)reader["Libelle"];


            if (reader["NumeroVersion"] != DBNull.Value)
                mod.NumeroVersion = (float)reader["NumeroVersion"];


            if (reader["Millesime"] != DBNull.Value)
                mod.MillesimeVersion = (Int16)reader["Millesime"];


            if (reader["DateOuverture"] != DBNull.Value)
                mod.DateOuvertureVersion = (DateTime)reader["DateOuverture"];


            if (reader["DateSortiePrevue"] != DBNull.Value)
                mod.DateSortiePrevueVersion = (DateTime)reader["DateSortiePrevue"];
            

            if (reader["DateSortieReelle"] != DBNull.Value)
                mod.DateSortieReelleVersion = (DateTime)reader["DateSortieReelle"];


            lstModule.Add(mod);

        }

        public static List<string> nomlogiciel()
        {
            var listeNomLogiciel= new List<string>();

            var connectString = Properties.Settings.Default.ProjetWinformsConnection;

            // On écrit la requête SQL à exécuter
            string queryString = "select distinct Nom from jo.Logiciel order by 1";

            // On crée une connexion à partir de la chaîne de connexion
            using (var connect = new SqlConnection(connectString))
            {
                // On créé une commande à partir de la requête,
                // et en utilisant la connexion définies précédemment
                var command = new SqlCommand(queryString, connect);

                // On ouvre la connexion
                connect.Open();

                // On exécute la requête en récupérant son résultat 
                // dans un objet SqlDataRedader
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    // On lit et on affiche les lignes de résultat en boucle
                    while (reader.Read())
                    {
                        listeNomLogiciel.Add((string)reader["Nom"]);
                    }
                }

            }
            // Le fait d'avoir créé la connexion dans une instruction using
            // permet de la fermer automatiquement à la fin du bloc using

            return listeNomLogiciel;
        }


    }
}
