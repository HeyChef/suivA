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
    public partial class utilisateurAccueil : Form
    {
        public utilisateurAccueil()
        {
            InitializeComponent();
        }

        private void statLabel_Click(object sender, EventArgs e)
        {
            FormCollection fc = Application.OpenForms;
            bool isValid = true;
            foreach (Form form in fc)
            {
                if (form.Text == "Statistiques")
                {
                    isValid = false;
                    form.Focus();
                }
            }
            if (isValid == true)
            {
                Statistiques StatistiquesWindow = new Statistiques();
                StatistiquesWindow.Show();
            }
        }

        private void medecinLabel_Click(object sender, EventArgs e)
        {
            medecinPanel.Visible = false;
            medecinPanel.Visible = true;
        }
    }
}
