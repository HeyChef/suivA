using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace suivA
{
    public partial class Login : Form
    {
        private string domain;
        private string username;
        private string password;
        private string UserType;
        public Login()
        {
            InitializeComponent();
            domain = "172.16.8.10";
        }
        

        private void validerbutton_Click(object sender, EventArgs e)
        {
            BddRequest loginRequest = new BddRequest();
            username = identifiantbox.Text;
            password = passwordbox.Text;
            Boolean result = ActiveDirectoryConnexion();

            if (result == true)
            {
                var loginWindow = this;
                if(UserType == "Admin")
                {
                    utilisateurAccueil gotoAccueilUti = new utilisateurAccueil();
                    gotoAccueilUti.Show();
                }
                else
                {
                    String Idvisiteur = loginRequest.loginRequest(username);
                    visiteurAccueil gotoAccueilVisi = new visiteurAccueil(Idvisiteur);
                    gotoAccueilVisi.Show();
                }
                loginWindow.Hide();
            }
            else
            {
                MessageBox.Show("Mot de passe ou identifiant incorrect");
                identifiantbox.Text = null;
                passwordbox.Text = null;
            }
        }

        // Fonction qui permet d'appuyer sur entrée au lieu du bouton validé
        private void passwordbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)

            {
                validerbutton_Click(sender, e);
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        public bool ActiveDirectoryConnexion()
        {
            try
            {
                DirectoryEntry ActiveDirectoryConnexionPath = new DirectoryEntry("LDAP://" + domain, username, password, AuthenticationTypes.Secure);
                DirectorySearcher Search = new DirectorySearcher(ActiveDirectoryConnexionPath);
                Search.PropertiesToLoad.Add("cn");
                Search.PropertiesToLoad.Add("givenname");
                Search.PropertiesToLoad.Add("sn");
                Search.PropertiesToLoad.Add("memberof");
                Search.Filter = "(&(objectClass=user)(SAMAccountName=" + username + "))";
                SearchResult ResultSearch = Search.FindOne();
                return GetGroup(ResultSearch);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        //Fonction permettant de récupérer le groupe LDAP de l'utilisateur
        //Retourne False s'il n'appartient à un des groupes LDÄP
        public bool GetGroup(SearchResult ResultSearch)
        {
            if (ResultSearch != null)
            {
                if (ResultSearch.Properties["memberof"] != null)
                {
                    ResultPropertyValueCollection groups = ResultSearch.Properties["memberof"];

                    foreach (string group in groups)
                    {
                        if (group.Contains("CN=" + "VisiteurGSBS8"))
                        {
                            UserType = "Visiteur";
                            return true;
                        }
                        if (group.Contains("CN=" + "AdminGSBS8"))
                        {
                            UserType = "Admin";
                            return true;
                        }
                    }
                }
            }
            return false;
        }
    }
}
