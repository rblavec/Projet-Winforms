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

        public static BindingList<Version> listVersion (string NomLogiciel)
        {
            var listDeVersion = new BindingList<Version>();

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
                        GetVersionFromDataReader(listDeVersion, reader);
                    }
                }
            }
            // Le fait d'avoir créé la connexion dans une instruction using permet de la fermer automatiquement à la fin du bloc using

            return listDeVersion;
        }

        private static void GetVersionFromDataReader(BindingList<Version> lstVersion, SqlDataReader reader)
        {
            //on créé une nouvelle Version, on lui renseigne ses propriétés grâce au DataReader et on l'ajoute à notre collection.
            var ver = new Version();

            if (reader["NumeroVersion"] != DBNull.Value)
                ver.NumeroVersion = (float)reader["NumeroVersion"];

            if (reader["Millesime"] != DBNull.Value)
                ver.MillesimeVersion = (Int16)reader["Millesime"];

            if (reader["DateOuverture"] != DBNull.Value)
                ver.DateOuvertureVersion = (DateTime)reader["DateOuverture"];

            if (reader["DateSortiePrevue"] != DBNull.Value)
                ver.DateSortiePrevueVersion = (DateTime)reader["DateSortiePrevue"];

            if (reader["Last release"] != DBNull.Value)
               ver.NumeroRelease = (Int16)reader["Last release"];



            lstVersion.Add(ver);

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


        public static BindingList<Module> listModule(string NomLogiciel)
        {
            var listDeModule = new BindingList<Module>();

            var connectString = Properties.Settings.Default.ProjetWinformsConnection;

            // On écrit la requête SQL à exécuter
            string queryString = @"select distinct m.CodeModule, m.Libelle
                                 from jo.Module m
                                 inner join jo.Logiciel l on l.CodeLogiciel = m.CodeLogiciel
                                 where l.Nom = @parametre";

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
                        GetModuleFromDataReader(listDeModule, reader);
                    }
                }
            }
            // Le fait d'avoir créé la connexion dans une instruction using permet de la fermer automatiquement à la fin du bloc using

            return listDeModule;
        }

        private static void GetModuleFromDataReader(BindingList<Module> lstVersion, SqlDataReader reader)
        {
            //on créé une nouvelle Version, on lui renseigne ses propriétés grâce au DataReader et on l'ajoute à notre collection.
            var mod = new Module();

            if (reader["CodeModule"] != DBNull.Value)
                mod.CodeModule = (string)reader["CodeModule"];

            if (reader["Libelle"] != DBNull.Value)
                mod.LibelleModule = (string)reader["Libelle"];




            lstVersion.Add(mod);

        }


    }
}
