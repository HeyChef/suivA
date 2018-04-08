using System;
using System.Data;
using System.Windows.Forms;

namespace suivA
{
    public partial class Statistiques : Form
    {
        public Statistiques()
        {
            InitializeComponent();
            BddRequest requestStat = new BddRequest();
            DataTable dtMedecin = requestStat.FillComboBox("Select nom, id from medecin order by nom");
            medecinBox.ValueMember = "id";
            medecinBox.DisplayMember = "nom";
            medecinBox.DataSource = dtMedecin;

            DataTable dtVisiteur = requestStat.FillComboBox("Select nom, id from utilisateur where id_role=1 order by nom");
            visiteurBox.ValueMember = "id";
            visiteurBox.DisplayMember = "nom";
            visiteurBox.DataSource = dtVisiteur;

            string[] statTemps = requestStat.GetStatTempsMoy();
            resultTempsEntretienLabel.Text = statTemps[1];
            resultTpsAttenteLabel.Text = statTemps[0];
        }

        private void paramChangeMedecin(object sender, System.EventArgs e)
        {
            string dp = dPPicker.Value.ToString("yyyy-MM-dd");
            string fp = fPPicker.Value.ToString("yyyy-MM-dd");
            BddRequest getStat = new BddRequest();
            statMedecinResultLabel.Text = getStat.GetStatMedecin(medecinBox.SelectedValue.ToString(), dp, fp);

        }

        private void paramChangeVisiteur(object sender, System.EventArgs e)
        {
            string date = dVisiteVis.Value.ToString("yyyy-MM-dd");
            BddRequest getStat = new BddRequest();
            string[] result = getStat.GetStatVisiteur(visiteurBox.SelectedValue.ToString(), date);
            statVisiteurJourResultLabel.Text = result[0];
            statVisiteurHeurePResultLabel.Text = result[1];

        }
    }
}
