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

        public string loginRequest(string identifiant, string mdp)
        {
            this.connection.Open();
            MySqlCommand cmd = this.connection.CreateCommand();
            cmd.CommandText = "Select id from utilisateur where login ='" + identifiant + "' AND password ='" + mdp + "'";
            var resultRequest = cmd.ExecuteScalar();
            this.connection.Close();
            if (resultRequest != null)
            {
                return resultRequest.ToString();
            }
            else
            {
                return "invalid";
            }
        }

        public Visiteur getVisiteur(string id)
        {
            this.connection.Open();
            MySqlCommand cmd = this.connection.CreateCommand();
            cmd.CommandText = "select u.nom,u.prenom,u.id,u.id_medecin,u.id_role,m.nom,m.prenom from utilisateur u inner join medecin m on m.id=u.id_medecin where u.id=@id";
            cmd.Parameters.AddWithValue("@id", id);
            Visiteur visiteur = new Visiteur();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                visiteur.name = reader["nom"].ToString();
                visiteur.surname = reader["prenom"].ToString();
                visiteur.id = reader["id"].ToString();
                visiteur.id_medecin = reader["id_medecin"].ToString();
                visiteur.id_role = reader["id_role"].ToString();
            }
            reader.Close();
            cmd.CommandText = "select m.nom,m.prenom,c.adresse from utilisateur u inner join medecin m on m.id=u.id_medecin inner join cabinet c on c.id=m.id_cabinet where u.id=@id";
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                visiteur.medecin_surname = reader["prenom"].ToString();
                visiteur.medecin_name = reader["nom"].ToString();
                visiteur.medecin_cabinet = reader["adresse"].ToString();
            }
            reader.Close();
            this.connection.Close();
            return visiteur;
        }

        public void DataRequest(string request)
        {
            this.connection.Open();
            MySqlCommand cmd = this.connection.CreateCommand();
            cmd.CommandText = request;
            cmd.ExecuteNonQuery();
            this.connection.Close();
        }
    }
}
