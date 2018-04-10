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
    public partial class AddMedecin : Form
    {
        public AddMedecin()
        {
            InitializeComponent();
            BddRequest requestCabinet = new BddRequest();
            DataTable dtAdresse = requestCabinet.FillComboBox("Select adresse,id from cabinet");
            adresseBox.ValueMember = "id";
            adresseBox.DisplayMember = "adresse";
            adresseBox.DataSource = dtAdresse;
        }

        private void validerbutton_Click(object sender, EventArgs e)
        {
            BddRequest addVisite = new BddRequest();
            string request = "INSERT INTO medecin (nom,prenom,id_cabinet) values (\"" + nomBox.Text + "\",\"" + prenomBox.Text + "\",\"" + adresseBox.SelectedValue.ToString() + "\")";
            addVisite.DataRequest(request);
            MessageBox.Show("Vos informations ont été enregistrées avec succès");
            utilisateurAccueil accueil = Application.OpenForms["utilisateurAccueil"] as utilisateurAccueil;
            utilisateurAccueil newaccueil = new utilisateurAccueil();
            var upt = this;
            accueil.willCloseduti = false;
            accueil.Close();
            newaccueil.Show();
            upt.Close();
        }
    }
}
