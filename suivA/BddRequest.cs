using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Librairie MySQL ajoutée dans les références.
using MySql.Data.MySqlClient;

namespace suivA
{
    public class BddRequest
    {

        private MySqlConnection connection;

        // Constructeur
        public BddRequest()
        {
            this.InitConnexion();
        }

        // Méthode pour initialiser la connexion
        private void InitConnexion()
        {
            // Création de la chaîne de connexion
            string connectionString = "SERVER=127.0.0.1; DATABASE=suivia; UID=root; PASSWORD=";
            this.connection = new MySqlConnection(connectionString);
        }

        // Méthode pour ajouter un contact
        public bool loginRequest(string identifiant, string mdp)
        {
            // Ouverture de la connexion SQL
            this.connection.Open();

            // Création d'une commande SQL en fonction de l'objet connection
            MySqlCommand cmd = this.connection.CreateCommand();

            // Requête SQL
            cmd.CommandText = "Select id from utilisateur where login ='" + identifiant + "' AND password ='" + mdp + "'";

            // Exécution de la commande SQL
            var resultRequest = cmd.ExecuteScalar();
            bool result;

            if(resultRequest != null)
            {
                result = true;
            }
            else
            {
                result = false;
            }
            // Fermeture de la connexion
            this.connection.Close();

            return result;
        }
    }
}
