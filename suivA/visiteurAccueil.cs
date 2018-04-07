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
    public partial class visiteurAccueil : Form
    {
        public Visiteur visiteur { get; set; }
        public visiteurAccueil(string id)
        {
            InitializeComponent();
            BddRequest infovisiteur = new BddRequest();
            visiteur = infovisiteur.getVisiteur(id);
        }

        private void visiteurAccueil_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void addVisite_Click(object sender, EventArgs e)
        {
            FormCollection fc = Application.OpenForms;
            bool isValid = true;
            foreach(Form form in fc)
            {
                if(form.Text == "AddVisite")
                {
                    isValid = false;
                    form.Focus();
                }
            }
            if(isValid == true)
            {
                AddVisite addVisiteWindow = new AddVisite(visiteur);
                addVisiteWindow.Show();
            }
        }

        private void getStat_Click(object sender, EventArgs e)
        {

        }
    }
}
