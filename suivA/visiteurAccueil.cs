using System;
using System.Windows.Forms;
using System.Data;

namespace suivA
{
    public partial class visiteurAccueil : Form
    {
        public Visiteur visiteur { get; set; }
        public bool willClosed { get; set; }
        public visiteurAccueil(string id)
        {
            InitializeComponent();

            willClosed = true;
            BddRequest infovisiteur = new BddRequest();
            visiteur = infovisiteur.getVisiteur(id);
            getData();
        }

        public void getData()
        {
            BddRequest infovisiteur = new BddRequest();

            DataSet data = infovisiteur.SelectVisite(visiteur.id);
            setVisiteForm(data);
        }

        private void setVisiteForm(DataSet data)
        {
            int y = 0;
            int i = 0;
            foreach(DataTable table in data.Tables)
            {
                DataColumn rdv = new DataColumn("rdv");
                rdv.DataType = System.Type.GetType("System.String");
                table.Columns.Add(rdv);
                foreach (DataRow visite in table.Rows)
                {
                    if(visite["rendez_vous"].ToString() == "True")
                    {
                        visite["rdv"] = "Oui";
                    }
                    else
                    {
                        visite["rdv"] = "Non";
                    }
                    SetForm(i, y, visite);
                    i++;
                    y += 55;
                }
            }
        }

        private void visiteurAccueil_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(willClosed == true)
            {
                Application.Exit();
            }
            
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

        private void updateVisite(object sender, EventArgs e, DataRow visite)
        {
            FormCollection fc = Application.OpenForms;
            foreach (Form form in fc)
            {
                if (form.Text == "UpdateVisite")
                {
                    form.Close();
                    break;
                }
            }
            UpdateVisite upt = new UpdateVisite(visite,visiteur);
            upt.Show();
        }

        private void deleteVisite(object sender, EventArgs e,DataRow visite)
        {
            DialogResult result = MessageBox.Show("Voulez-vous vraiment supprimer cette visite ?", "Supprimer la visite", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                BddRequest delete = new BddRequest();
                delete.deleteVisite(visite["id"].ToString());
                MessageBox.Show("Suppression effectué");
                visiteurAccueil newaccueil = new visiteurAccueil(visiteur.id);
                var upt = this;
                willClosed = false;
                newaccueil.Show();
                upt.Close();
            }
        }
    }
}
