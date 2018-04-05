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
            var loginWindow = this;
            visiteurAccueil gotoAccueilVisi = new visiteurAccueil();
            gotoAccueilVisi.Show();
            loginWindow.Hide();
        }
    }
}
