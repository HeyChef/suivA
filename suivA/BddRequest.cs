using System.Data;
using System.Windows.Forms;

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
            // Création de la chaîne de connexion S8
            string connectionString = "SERVER=172.16.8.22; DATABASE=assistance_situation; UID=K.crinon; PASSWORD=AzertY59000!";
            this.connection = new MySqlConnection(connectionString);
        }
        // Fonction qui récupère l'ID grace au Login/MDP 
        public string loginRequest(string identifiant)
        {
            this.connection.Open();
            MySqlCommand cmd = this.connection.CreateCommand();
            cmd.CommandText = "Select id from utilisateur where login ='" + identifiant + "'";
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
        // Fonction qui renvoi les détails sur un visiteur (Nom medecin / Cabinet etc ... ) 
        public Visiteur getVisiteur(string id)
        {
            this.connection.Open();
            MySqlCommand cmd = this.connection.CreateCommand();
            cmd.CommandText = "select u.nom,u.prenom,u.id,u.id_medecin,u.id_role from utilisateur u inner join medecin m on m.id=u.id_medecin where u.id=@id";
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
        // Fonction pour envoyer un Insert/Delete/update, pas de retour , donc pas de test
        public void DataRequest(string request)
        {
            this.connection.Open();
            MySqlCommand cmd = this.connection.CreateCommand();
            cmd.CommandText = request;
            cmd.ExecuteNonQuery();
            this.connection.Close();
        }

        // Fonction qui permet de faire des SELECT et remplir les combo box 
        public DataTable FillComboBox(string request)
        {
            this.connection.Open();
            MySqlCommand cmd = this.connection.CreateCommand();
            cmd.CommandText = request;
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            this.connection.Close();
            return dt;
        }

        // Fonction qui renvoi les statistique des medecins
        public string GetStatMedecin(string id_medecin, string date_d, string date_f)
        {
            this.connection.Open();
            MySqlCommand cmd = this.connection.CreateCommand();
            cmd.CommandText = "Select count(*) from visite where id_medecin=@id_medecin and date_visite between @date_d and @date_f";
            cmd.Parameters.AddWithValue("@id_medecin", id_medecin);
            cmd.Parameters.AddWithValue("@date_d", date_d);
            cmd.Parameters.AddWithValue("@date_f", date_f);
            string result = cmd.ExecuteScalar().ToString();
            this.connection.Close();
            return result;
        }


        // Fonction qui renvoie les statistiques du visiteur
        public string[] GetStatVisiteur(string id_utilisateur, string date)
        {
            this.connection.Open();
            MySqlCommand cmd = this.connection.CreateCommand();
            cmd.CommandText = "Select count(*) as count, timediff(SEC_TO_TIME( SUM( TIME_TO_SEC(`heure_depart`) ) ),SEC_TO_TIME( SUM( TIME_TO_SEC(`heure_debut_entretien`) ) )) as tps from visite where id_utilisateur=@id_utilisateur and date_visite=@date";
            cmd.Parameters.AddWithValue("@id_utilisateur", id_utilisateur);
            cmd.Parameters.AddWithValue("@date", date);
            MySqlDataReader data = cmd.ExecuteReader();
            string[] result = new string[2];
            while (data.Read())
            {
                result[0] = data["count"].ToString();
                result[1] = data["tps"].ToString();
            }
            this.connection.Close();
            return result;
        }

        //Fonction qui renvoie les statistique de Temps moyen par consultation et par temps d'attente
        public string[] GetStatTempsMoy()
        {
            this.connection.Open();
            MySqlCommand cmd = this.connection.CreateCommand();
            cmd.CommandText = "SELECT SEC_TO_TIME(timediff(SEC_TO_TIME( SUM( TIME_TO_SEC(`heure_debut_entretien`) ) ),SEC_TO_TIME( SUM( TIME_TO_SEC(`heure_arrivee`) ) ))/count(*)) as tpsatt,SEC_TO_TIME(timediff(SEC_TO_TIME( SUM( TIME_TO_SEC(`heure_depart`) ) ),SEC_TO_TIME( SUM( TIME_TO_SEC(`heure_debut_entretien`) ) ))/count(*)) as tps FROM visite";
            MySqlDataReader data = cmd.ExecuteReader();
            string[] result = new string[2];
            while (data.Read())
            {
                result[0] = data["tpsatt"].ToString();
                result[1] = data["tps"].ToString();
            }
            this.connection.Close();
            return result;
        }
        // Fonction qui selectionne toutes les visite saisi par 1 utilisateur
        public DataSet SelectVisite(string id_utilisateur)
        {
            this.connection.Open();
            MySqlCommand cmd = this.connection.CreateCommand();
            cmd.CommandText = "Select id_utilisateur,rendez_vous,heure_arrivee,heure_depart,heure_debut_entretien,v.id,adresse,nom,date_format(date_visite,\"%d/%m/%Y\") as date_visite from visite v inner join medecin m on m.id=v.id_medecin inner join cabinet c on c.id=m.id_cabinet where id_utilisateur=@id_utilisateur";
            cmd.Parameters.AddWithValue("@id_utilisateur", id_utilisateur);
            MySqlDataAdapter data = new MySqlDataAdapter();
            data.SelectCommand = cmd;
            DataSet result = new DataSet();
            data.Fill(result);
            this.connection.Close();
            return result;
        }

        // Fonction qui affiche tout les medecins
        public DataSet SelectMedecin()
        {
            this.connection.Open();
            MySqlCommand cmd = this.connection.CreateCommand();
            cmd.CommandText = "Select m.id,nom,prenom,adresse from medecin m inner join cabinet c on c.id=m.id_cabinet order by nom";
            MySqlDataAdapter data = new MySqlDataAdapter();
            data.SelectCommand = cmd;
            DataSet result = new DataSet();
            data.Fill(result);
            this.connection.Close();
            return result;
        }

        // Fonction qui affiche tout les cabinets
        public DataSet SelectCabinet()
        {
            this.connection.Open();
            MySqlCommand cmd = this.connection.CreateCommand();
            cmd.CommandText = "Select * from cabinet order by id";
            MySqlDataAdapter data = new MySqlDataAdapter();
            data.SelectCommand = cmd;
            DataSet result = new DataSet();
            data.Fill(result);
            this.connection.Close();
            return result;
        }

        // Fonctions qui permet de supprimer les visite
        public void deleteVisite(string id)
        {
            this.connection.Open();
            MySqlCommand cmd = this.connection.CreateCommand();
            cmd.CommandText = "Delete from visite where id=@id";
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            this.connection.Close();
        }
    }
}
