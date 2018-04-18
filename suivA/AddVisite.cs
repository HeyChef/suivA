using System;
using System.Data;
using System.Windows.Forms;

namespace suivA
{
    public partial class AddVisite : Form
    {
        public Visiteur visiteurData { get; set; }
        private DataTable data { get; set; }

        // Constructeur d'ajout de visite
        public AddVisite(Visiteur visiteur)
        {
            InitializeComponent();
            BddRequest requestCabinet = new BddRequest();
            data = requestCabinet.FillComboBox("Select m.prenom,nom,m.id,c.id,adresse from medecin m inner join cabinet c on c.id=m.id_cabinet order by nom");
            DataColumn display = new DataColumn("display");
            display.DataType = System.Type.GetType("System.String");
            data.Columns.Add(display);
            foreach (DataRow Rows in data.Rows)
            {
                Rows["display"] = Rows["nom"].ToString() + " " + Rows["prenom"].ToString();
            }
            medecinBox.ValueMember = "id";
            medecinBox.DisplayMember = "display";
            medecinBox.DataSource = data;
            cabinetSelect.Text = data.Rows[0]["adresse"].ToString();
            visiteurData = visiteur;
        }

        // Ajout de visite détaillé dans la BDD
        private void validerbutton_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            bool rdv;
            if(hArriveePicker.Text == "00:00")
            {
                isValid = false;
                MessageBox.Show("Veuillez remplir le champ d'heure d'arrivée");
            }
            if (hDebutPicker.Text == "00:00")
            {
                isValid = false;
                MessageBox.Show("Veuillez remplir le champ d'heure de début");
            }
            if (hDepartPicker.Text == "00:00")
            {
                isValid = false;
                MessageBox.Show("Veuillez remplir le champ d'heure de fin");
            }
            if(radioRdvTrue.Checked == false && radioRdvFalse.Checked == false)
            {
                isValid = false;
                MessageBox.Show("Veuillez cocher le type de visite");
            }
            if(isValid == true)
            {
                if (radioRdvTrue.Checked == true)
                {
                    rdv = true;
                }
                else
                {
                    rdv = false;
                }
                BddRequest addVisite = new BddRequest();
                string request = "INSERT INTO visite (rendez_vous, heure_arrivee, heure_debut_entretien, heure_depart, date_visite, id_medecin, id_utilisateur) VALUES ("+ rdv +", '"+ hArriveePicker.Text +"', '"+ hDebutPicker.Text +"', '"+ hDepartPicker.Text +"', '"+ visiteDatePicker.Text +"', "+ medecinBox.SelectedValue.ToString()  +", "+ cabinetSelect.Text +");";
                addVisite.DataRequest(request);
                MessageBox.Show("Vos informations ont été enregistrées avec succès");
                visiteurAccueil accueil = Application.OpenForms["visiteurAccueil"] as visiteurAccueil;
                visiteurAccueil newaccueil = new visiteurAccueil(visiteurData.id);
                var upt = this;
                accueil.willClosed = false;
                accueil.Close();
                newaccueil.Show();
                upt.Close();
            }
        }

        private void medecinBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cabinetSelect.Text = data.Rows[medecinBox.SelectedIndex]["adresse"].ToString();
        }
    }
}
