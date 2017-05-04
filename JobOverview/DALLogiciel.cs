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

        public static BindingList<Version> listVersion(string NomLogiciel)
        {

            // Création d'une BindingList .
            var listDeVersion = new BindingList<Version>();

            // On défini la chaîne de connection.
            var connectString = Properties.Settings.Default.ProjetWinformsConnection;

            // On écrit la requête SQL à exécuter
            string queryString = @"select distinct v.NumeroVersion, v.Millesime, v.DateOuverture, v.DateSortiePrevue, v.DateSortieReelle, MAX(r.NumeroRelease) [Last release]
                                 from jo.Version v
                                 left outer join jo.Release r on r.NumeroVersion = v.NumeroVersion
                                 left outer join jo.Logiciel l on l.CodeLogiciel = v.CodeLogiciel
                                 where l.Nom = @parametre
                                 group by v.NumeroVersion, v.Millesime, v.DateOuverture, v.DateSortiePrevue, v.DateSortieReelle";

            var param = new SqlParameter("@parametre", DbType.String);
            param.Value = NomLogiciel;

            // On crée une connexion à partir de la chaîne de connexion.
            using (var connect = new SqlConnection(connectString))
            {
                // On créé une commande à partir de la requête et la connexion définies précédemment.
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


            // On ajout la version obtenue à la liste des versions.
            lstVersion.Add(ver);

        }

        public static List<string> nomlogiciel()
        {
            var listeNomLogiciel = new List<string>();

            var connectString = Properties.Settings.Default.ProjetWinformsConnection;

            // On écrit la requête SQL à exécuter
            string queryString = "select distinct Nom from jo.Logiciel order by 1";

            // On crée une connexion à partir de la chaîne de connexion
            using (var connect = new SqlConnection(connectString))
            {
                // On créé une commande à partir de la requête et la connexion définies précédemment
                var command = new SqlCommand(queryString, connect);

                // On ouvre la connexion
                connect.Open();

                // On exécute la requête en récupérant son résultat dans un objet SqlDataRedader
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    // On lit et on affiche les lignes de résultat en boucle
                    while (reader.Read())
                    {
                        listeNomLogiciel.Add((string)reader["Nom"]);
                    }
                }

            }
            // Le fait d'avoir créé la connexion dans une instruction using permet de la fermer automatiquement à la fin du bloc using

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

        private static void GetModuleFromDataReader(BindingList<Module> lstModule, SqlDataReader reader)
        {
            //on créé un nouveau Module, on lui renseigne ses propriétés grâce au DataReader et on l'ajoute à notre collection.
            var mod = new Module();

            if (reader["CodeModule"] != DBNull.Value)
                mod.CodeModule = (string)reader["CodeModule"];

            if (reader["Libelle"] != DBNull.Value)
                mod.LibelleModule = (string)reader["Libelle"];


            lstModule.Add(mod);

        }

        public static void AjoutVersion(Version vers)
        {
            var connectString = Properties.Settings.Default.ProjetWinformsConnection;

            string queryString = @"insert jo.Version (NumeroVersion, CodeLogiciel, Millesime, DateOuverture, DateSortiePrevue) 
                                              values (@param1, 'GENOMICA', @param2, @param3, @param4)";


            var param1 = new SqlParameter("@param1", DbType.Int64);
            param1.Value = vers.NumeroVersion;

            var param2 = new SqlParameter("@param2", DbType.Int16);
            param2.Value = vers.MillesimeVersion;

            var param3 = new SqlParameter("@param3", DbType.DateTime);
            param3.Value = vers.DateOuvertureVersion;

            var param4 = new SqlParameter("@param4", DbType.DateTime);
            param4.Value = vers.DateOuvertureVersion;

            using (var connect = new SqlConnection(connectString))
            {
                connect.Open();

                // On ouvre une transaction afin de s'assurer que tous les changements ont été correctement effectués avant de les appliquer définitivement
                // avec un commit. Si un problème survint, on fait un rollback.
                SqlTransaction tran = connect.BeginTransaction();

                // Création et execution de la commande.
                var command = new SqlCommand(queryString, connect, tran);
              
                command.Parameters.Add(param1);
                command.Parameters.Add(param2);
                command.Parameters.Add(param3);
                command.Parameters.Add(param4);
  
                try
                {
                  
                    command.ExecuteNonQuery();
                 
                    // On valide la transaction.
                    tran.Commit();
                }

                catch (Exception)

                {
                    // On ne valide pas la transaction (retour à l'état pré-transaction).
                    tran.Rollback();
                    throw;
                }


            }


        }
    }
}
