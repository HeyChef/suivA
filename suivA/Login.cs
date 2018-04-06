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
            bool result = loginRequest.loginRequest(identifiantbox.Text, passwordbox.Text);
            if (result == true)
            {
                var loginWindow = this;
                visiteurAccueil gotoAccueilVisi = new visiteurAccueil();
                gotoAccueilVisi.Show();
                loginWindow.Hide();
            }
            else
            {
                MessageBox.Show("Mot de passe ou identifiant incorrect");
            }
        }
    }
}
