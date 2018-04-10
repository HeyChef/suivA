using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace suivA
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void validerbutton_Click(object sender, EventArgs e)
        {
            BddRequest loginRequest = new BddRequest();
            string result = loginRequest.loginRequest(identifiantbox.Text, passwordbox.Text);
            if (result != "invalid")
            {
                var loginWindow = this;
                Visiteur visiteur = loginRequest.getVisiteur(result);
                if(visiteur.id_role.ToString() == "1")
                {
                    visiteurAccueil gotoAccueilVisi = new visiteurAccueil(result);
                    gotoAccueilVisi.Show();
                }
                else
                {
                    utilisateurAccueil gotoAccueilUti = new utilisateurAccueil();
                    gotoAccueilUti.Show();
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

        private void passwordbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)

            {
                validerbutton_Click(sender, e);
            }
        }
    }
}
