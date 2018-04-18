using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace suivA
{
    public partial class utilisateurAccueil : Form
    {
        public bool willCloseduti { get; set; }

        // Constructeur qui initialise la page Accueil
        public utilisateurAccueil()
        {
            InitializeComponent();
            loadingPanel.Show();
            willCloseduti = true;
            BddRequest request = new BddRequest();
            DataTable dtMedecin = request.FillComboBox("Select nom, id from medecin order by nom");
            medecinBox.ValueMember = "id";
            medecinBox.DisplayMember = "nom";
            medecinBox.DataSource = dtMedecin;

            DataTable dtVisiteur = request.FillComboBox("Select nom, id from utilisateur where id_role=1 order by nom");
            visiteurBox.ValueMember = "id";
            visiteurBox.DisplayMember = "nom";
            visiteurBox.DataSource = dtVisiteur;

            loadingData();
        }

        // Fonction qui affiche les statistiques 
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
        // Fonction qui qui affiche le panel selon le bouton cliqué
        private void medecinLabel_Click(object sender, EventArgs e)
        {
            medecinPanel.Visible = true;
            panelCabinet.Visible = false;
            affectationPanel.Visible = false;
        }
        // Fonction qui qui affiche le panel selon le bouton cliqué
        private void cabinetLabel_Click(object sender, EventArgs e)
        {
            medecinPanel.Visible = false;
            panelCabinet.Visible = true;
            affectationPanel.Visible = false;
        }
        // Fonction qui qui affiche le panel selon le bouton cliqué
        private void affectationLabel_Click(object sender, EventArgs e)
        {
            medecinPanel.Visible = false;
            panelCabinet.Visible = false;
            affectationPanel.Visible = true;
        }

        // Fonction qui récupère les data de tout les médecins et qui les affiche
        public async Task<DataSet> getData()
        {
            DataSet data = new DataSet();
            BddRequest getData = new BddRequest();
            await Task.Run(() => { data = getData.SelectMedecin(); Thread.Sleep(2000); });
            setMedecinForm(data);
            return data;
        }

        // Fonction qui génère le tableau des médecins
        private void setMedecinForm(DataSet data)
        {
            int y = 0;
            int i = 0;
            foreach (DataTable table in data.Tables)
            {
                foreach (DataRow medecin in table.Rows)
                {
                    formMedecin(i, y, medecin);
                    i++;
                    y += 55;
                }
            }
        }

        // Fonction qui affiche la fenetre de modification de médecin 
        private void updateMedecin(object sender, EventArgs e, DataRow medecin)
        {
            FormCollection fc = Application.OpenForms;
            foreach (Form form in fc)
            {
                if (form.Text == "UpdateMedecin")
                {
                    form.Close();
                    break;
                }
            }
            UpdateMedecin upt = new UpdateMedecin(medecin);
            upt.Show();
        }

        // Fonction qui ouvre la fenetre pour ajouter un médecin
        private void addMedecin_Click(object sender, EventArgs e)
        {
            FormCollection fc = Application.OpenForms;
            bool isValid = true;
            foreach (Form form in fc)
            {
                if (form.Text == "AddMedecin")
                {
                    isValid = false;
                    form.Focus();
                }
            }
            if (isValid == true)
            {
                AddMedecin addMedecinWindow = new AddMedecin();
                addMedecinWindow.Show();
            }
        }

        // Fonction qui récupère les data de tout les cabinets et qui les affiche
        public async Task<DataSet> getDataCabinet()
        {
            DataSet data = new DataSet();
            BddRequest getData = new BddRequest();
            await Task.Run(() => { data = getData.SelectCabinet(); Thread.Sleep(2000); });
            setCabinetForm(data);
            return data;
        }

        // Fonction qui génère le tableau des cabinets
        private void setCabinetForm(DataSet data)
        {
            int y = 0;
            int i = 0;
            foreach (DataTable table in data.Tables)
            {
                foreach (DataRow cabinet in table.Rows)
                {
                    formCabinet(i, y, cabinet);
                    i++;
                    y += 55;
                }
            }
        }

        // Fonction qui affiche la fenetre de modification de cabinet
        private void updateCabinet(object sender, EventArgs e, DataRow cabinet)
        {
            FormCollection fc = Application.OpenForms;
            foreach (Form form in fc)
            {
                if (form.Text == "UpdateCabinet")
                {
                    form.Close();
                    break;
                }
            }
            UpdateCabinet upt = new UpdateCabinet(cabinet);
            upt.Show();
        }

        // Fonction qui verfie la fermerture de l'application
        private void utilisateurAccueil_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (willCloseduti == true)
            {
                Application.Exit();
            }
        }

        // Fonction qui ouvre la fenetre pour ajouter un cabinet
        private void addCabinet_Click(object sender, EventArgs e)
        {
            FormCollection fc = Application.OpenForms;
            bool isValid = true;
            foreach (Form form in fc)
            {
                if (form.Text == "AddCabinet")
                {
                    isValid = false;
                    form.Focus();
                }
            }
            if (isValid == true)
            {
                AddCabinet addCabinetWindow = new AddCabinet();
                addCabinetWindow.Show();

            }
        }

        private void validerbutton_Click(object sender, EventArgs e)
        {
            BddRequest updateMedecin = new BddRequest();
            updateMedecin.DataRequest("UPDATE utilisateur set id_medecin=" + medecinBox.SelectedValue.ToString() + " where id="+visiteurBox.SelectedValue.ToString());
            MessageBox.Show("Les informations ont été modifiées");
        }

        private async void loadingData()
        {
            try
            {
                var data = await getData();
                var dataCabinet = await getDataCabinet();

                loadingPanel.Hide();
            }
            catch
            {

            }
        }
    }
}
