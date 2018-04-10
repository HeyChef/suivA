﻿using System;
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
        public bool willCloseduti { get; set; }
        public utilisateurAccueil()
        {
            InitializeComponent();
            getData();
            willCloseduti = true;
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
            medecinPanel.Visible = true;
            panelCabinet.Visible = false;
            affectationPanel.Visible = false;
        }

        private void cabinetLabel_Click(object sender, EventArgs e)
        {
            medecinPanel.Visible = false;
            panelCabinet.Visible = true;
            affectationPanel.Visible = false;
        }

        private void affectationLabel_Click(object sender, EventArgs e)
        {
            medecinPanel.Visible = false;
            panelCabinet.Visible = false;
            affectationPanel.Visible = true;
        }

        public void getData()
        {
            BddRequest getData = new BddRequest();

            DataSet data = getData.SelectMedecin();
            setMedecinForm(data);
        }

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

        private void utilisateurAccueil_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (willCloseduti == true)
            {
                Application.Exit();
            }
        }
    }
}