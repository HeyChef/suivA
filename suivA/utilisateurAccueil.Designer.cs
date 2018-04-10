using System;
using System.Data;

namespace suivA
{
    partial class utilisateurAccueil
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(utilisateurAccueil));
            this.navPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.statLabel = new System.Windows.Forms.Label();
            this.pipe3 = new System.Windows.Forms.Label();
            this.affectationLabel = new System.Windows.Forms.Label();
            this.pipe2 = new System.Windows.Forms.Label();
            this.cabinetLabel = new System.Windows.Forms.Label();
            this.pipe1 = new System.Windows.Forms.Label();
            this.medecinLabel = new System.Windows.Forms.Label();
            this.medecinPanel = new System.Windows.Forms.Panel();
            this.addMedecin = new System.Windows.Forms.Button();
            this.medecinTitlePanel = new System.Windows.Forms.Panel();
            this.prenomTitleLabel = new System.Windows.Forms.Label();
            this.lineTitleLabel1 = new System.Windows.Forms.Label();
            this.nomTitleLabel = new System.Windows.Forms.Label();
            this.lineTitleLabel2 = new System.Windows.Forms.Label();
            this.cabinetTitleLabel = new System.Windows.Forms.Label();
            this.medecinRowPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelCabinet = new System.Windows.Forms.Panel();
            this.addCabinet = new System.Windows.Forms.Button();
            this.cabinetTitlePanel = new System.Windows.Forms.Panel();
            this.cabinetLatitudeTitleLabel = new System.Windows.Forms.Label();
            this.cabinetLongitudeTitleLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cabinetCpTitleLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cabinetAdresseTitleLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cabinetVilleTitleLabel = new System.Windows.Forms.Label();
            this.cabinetRowPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.affectationPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.navPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.medecinPanel.SuspendLayout();
            this.medecinTitlePanel.SuspendLayout();
            this.panelCabinet.SuspendLayout();
            this.cabinetTitlePanel.SuspendLayout();
            this.affectationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // navPanel
            // 
            this.navPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.navPanel.Controls.Add(this.panel1);
            this.navPanel.Controls.Add(this.statLabel);
            this.navPanel.Controls.Add(this.pipe3);
            this.navPanel.Controls.Add(this.affectationLabel);
            this.navPanel.Controls.Add(this.pipe2);
            this.navPanel.Controls.Add(this.cabinetLabel);
            this.navPanel.Controls.Add(this.pipe1);
            this.navPanel.Controls.Add(this.medecinLabel);
            this.navPanel.Location = new System.Drawing.Point(0, 0);
            this.navPanel.Name = "navPanel";
            this.navPanel.Size = new System.Drawing.Size(1185, 50);
            this.navPanel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(0, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1185, 803);
            this.panel1.TabIndex = 4;
            this.panel1.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(12, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 33);
            this.label3.TabIndex = 1;
            this.label3.Text = "Cabinets";
            // 
            // statLabel
            // 
            this.statLabel.AutoSize = true;
            this.statLabel.BackColor = System.Drawing.Color.Transparent;
            this.statLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.statLabel.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statLabel.ForeColor = System.Drawing.Color.White;
            this.statLabel.Location = new System.Drawing.Point(510, 9);
            this.statLabel.Name = "statLabel";
            this.statLabel.Size = new System.Drawing.Size(142, 33);
            this.statLabel.TabIndex = 4;
            this.statLabel.Text = "Statistiques";
            this.statLabel.Click += new System.EventHandler(this.statLabel_Click);
            // 
            // pipe3
            // 
            this.pipe3.AutoSize = true;
            this.pipe3.BackColor = System.Drawing.Color.Transparent;
            this.pipe3.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pipe3.ForeColor = System.Drawing.Color.White;
            this.pipe3.Location = new System.Drawing.Point(476, 9);
            this.pipe3.Name = "pipe3";
            this.pipe3.Size = new System.Drawing.Size(27, 33);
            this.pipe3.TabIndex = 5;
            this.pipe3.Text = "|";
            // 
            // affectationLabel
            // 
            this.affectationLabel.AutoSize = true;
            this.affectationLabel.BackColor = System.Drawing.Color.Transparent;
            this.affectationLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.affectationLabel.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.affectationLabel.ForeColor = System.Drawing.Color.White;
            this.affectationLabel.Location = new System.Drawing.Point(323, 9);
            this.affectationLabel.Name = "affectationLabel";
            this.affectationLabel.Size = new System.Drawing.Size(146, 33);
            this.affectationLabel.TabIndex = 2;
            this.affectationLabel.Text = "Affectations";
            this.affectationLabel.Click += new System.EventHandler(this.affectationLabel_Click);
            // 
            // pipe2
            // 
            this.pipe2.AutoSize = true;
            this.pipe2.BackColor = System.Drawing.Color.Transparent;
            this.pipe2.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pipe2.ForeColor = System.Drawing.Color.White;
            this.pipe2.Location = new System.Drawing.Point(289, 9);
            this.pipe2.Name = "pipe2";
            this.pipe2.Size = new System.Drawing.Size(27, 33);
            this.pipe2.TabIndex = 3;
            this.pipe2.Text = "|";
            // 
            // cabinetLabel
            // 
            this.cabinetLabel.AutoSize = true;
            this.cabinetLabel.BackColor = System.Drawing.Color.Transparent;
            this.cabinetLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cabinetLabel.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cabinetLabel.ForeColor = System.Drawing.Color.White;
            this.cabinetLabel.Location = new System.Drawing.Point(173, 9);
            this.cabinetLabel.Name = "cabinetLabel";
            this.cabinetLabel.Size = new System.Drawing.Size(109, 33);
            this.cabinetLabel.TabIndex = 1;
            this.cabinetLabel.Text = "Cabinets";
            this.cabinetLabel.Click += new System.EventHandler(this.cabinetLabel_Click);
            // 
            // pipe1
            // 
            this.pipe1.AutoSize = true;
            this.pipe1.BackColor = System.Drawing.Color.Transparent;
            this.pipe1.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pipe1.ForeColor = System.Drawing.Color.White;
            this.pipe1.Location = new System.Drawing.Point(139, 9);
            this.pipe1.Name = "pipe1";
            this.pipe1.Size = new System.Drawing.Size(27, 33);
            this.pipe1.TabIndex = 1;
            this.pipe1.Text = "|";
            // 
            // medecinLabel
            // 
            this.medecinLabel.AutoSize = true;
            this.medecinLabel.BackColor = System.Drawing.Color.Transparent;
            this.medecinLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.medecinLabel.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medecinLabel.ForeColor = System.Drawing.Color.White;
            this.medecinLabel.Location = new System.Drawing.Point(12, 9);
            this.medecinLabel.Name = "medecinLabel";
            this.medecinLabel.Size = new System.Drawing.Size(120, 33);
            this.medecinLabel.TabIndex = 0;
            this.medecinLabel.Text = "Médecins";
            this.medecinLabel.Click += new System.EventHandler(this.medecinLabel_Click);
            // 
            // medecinPanel
            // 
            this.medecinPanel.BackColor = System.Drawing.Color.Transparent;
            this.medecinPanel.Controls.Add(this.addMedecin);
            this.medecinPanel.Controls.Add(this.medecinTitlePanel);
            this.medecinPanel.Controls.Add(this.medecinRowPanel);
            this.medecinPanel.Controls.Add(this.label1);
            this.medecinPanel.Location = new System.Drawing.Point(0, 56);
            this.medecinPanel.Name = "medecinPanel";
            this.medecinPanel.Size = new System.Drawing.Size(1185, 803);
            this.medecinPanel.TabIndex = 2;
            // 
            // addMedecin
            // 
            this.addMedecin.BackColor = System.Drawing.Color.Transparent;
            this.addMedecin.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMedecin.ForeColor = System.Drawing.Color.Black;
            this.addMedecin.Location = new System.Drawing.Point(836, 15);
            this.addMedecin.Name = "addMedecin";
            this.addMedecin.Size = new System.Drawing.Size(274, 54);
            this.addMedecin.TabIndex = 6;
            this.addMedecin.Text = "Ajouter Médecin";
            this.addMedecin.UseVisualStyleBackColor = false;
            this.addMedecin.Click += new System.EventHandler(this.addMedecin_Click);
            // 
            // medecinTitlePanel
            // 
            this.medecinTitlePanel.AutoScroll = true;
            this.medecinTitlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.medecinTitlePanel.Controls.Add(this.prenomTitleLabel);
            this.medecinTitlePanel.Controls.Add(this.lineTitleLabel1);
            this.medecinTitlePanel.Controls.Add(this.nomTitleLabel);
            this.medecinTitlePanel.Controls.Add(this.lineTitleLabel2);
            this.medecinTitlePanel.Controls.Add(this.cabinetTitleLabel);
            this.medecinTitlePanel.Location = new System.Drawing.Point(70, 132);
            this.medecinTitlePanel.MaximumSize = new System.Drawing.Size(1040, 540);
            this.medecinTitlePanel.Name = "medecinTitlePanel";
            this.medecinTitlePanel.Size = new System.Drawing.Size(1040, 59);
            this.medecinTitlePanel.TabIndex = 5;
            // 
            // prenomTitleLabel
            // 
            this.prenomTitleLabel.AutoSize = true;
            this.prenomTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.prenomTitleLabel.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prenomTitleLabel.ForeColor = System.Drawing.Color.White;
            this.prenomTitleLabel.Location = new System.Drawing.Point(309, 9);
            this.prenomTitleLabel.Name = "prenomTitleLabel";
            this.prenomTitleLabel.Size = new System.Drawing.Size(75, 24);
            this.prenomTitleLabel.TabIndex = 1;
            this.prenomTitleLabel.Text = "Prénom";
            this.prenomTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lineTitleLabel1
            // 
            this.lineTitleLabel1.AutoSize = true;
            this.lineTitleLabel1.BackColor = System.Drawing.Color.Transparent;
            this.lineTitleLabel1.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lineTitleLabel1.ForeColor = System.Drawing.Color.White;
            this.lineTitleLabel1.Location = new System.Drawing.Point(210, 9);
            this.lineTitleLabel1.Name = "lineTitleLabel1";
            this.lineTitleLabel1.Size = new System.Drawing.Size(19, 24);
            this.lineTitleLabel1.TabIndex = 1;
            this.lineTitleLabel1.Text = "|";
            // 
            // nomTitleLabel
            // 
            this.nomTitleLabel.AutoSize = true;
            this.nomTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.nomTitleLabel.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomTitleLabel.ForeColor = System.Drawing.Color.White;
            this.nomTitleLabel.Location = new System.Drawing.Point(80, 9);
            this.nomTitleLabel.Name = "nomTitleLabel";
            this.nomTitleLabel.Size = new System.Drawing.Size(50, 24);
            this.nomTitleLabel.TabIndex = 0;
            this.nomTitleLabel.Text = "Nom";
            this.nomTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lineTitleLabel2
            // 
            this.lineTitleLabel2.AutoSize = true;
            this.lineTitleLabel2.BackColor = System.Drawing.Color.Transparent;
            this.lineTitleLabel2.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lineTitleLabel2.ForeColor = System.Drawing.Color.White;
            this.lineTitleLabel2.Location = new System.Drawing.Point(464, 9);
            this.lineTitleLabel2.Name = "lineTitleLabel2";
            this.lineTitleLabel2.Size = new System.Drawing.Size(19, 24);
            this.lineTitleLabel2.TabIndex = 1;
            this.lineTitleLabel2.Text = "|";
            // 
            // cabinetTitleLabel
            // 
            this.cabinetTitleLabel.AutoSize = true;
            this.cabinetTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.cabinetTitleLabel.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cabinetTitleLabel.ForeColor = System.Drawing.Color.White;
            this.cabinetTitleLabel.Location = new System.Drawing.Point(563, 9);
            this.cabinetTitleLabel.Name = "cabinetTitleLabel";
            this.cabinetTitleLabel.Size = new System.Drawing.Size(75, 24);
            this.cabinetTitleLabel.TabIndex = 0;
            this.cabinetTitleLabel.Text = "Cabinet";
            this.cabinetTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // medecinRowPanel
            // 
            this.medecinRowPanel.AutoScroll = true;
            this.medecinRowPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.medecinRowPanel.Location = new System.Drawing.Point(70, 189);
            this.medecinRowPanel.MaximumSize = new System.Drawing.Size(1040, 550);
            this.medecinRowPanel.Name = "medecinRowPanel";
            this.medecinRowPanel.Size = new System.Drawing.Size(1040, 100);
            this.medecinRowPanel.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Médecins";
            // 
            // panelCabinet
            // 
            this.panelCabinet.BackColor = System.Drawing.Color.Transparent;
            this.panelCabinet.Controls.Add(this.addCabinet);
            this.panelCabinet.Controls.Add(this.cabinetTitlePanel);
            this.panelCabinet.Controls.Add(this.cabinetRowPanel);
            this.panelCabinet.Controls.Add(this.label2);
            this.panelCabinet.Location = new System.Drawing.Point(0, 56);
            this.panelCabinet.Name = "panelCabinet";
            this.panelCabinet.Size = new System.Drawing.Size(1185, 803);
            this.panelCabinet.TabIndex = 3;
            this.panelCabinet.Visible = false;
            // 
            // addCabinet
            // 
            this.addCabinet.BackColor = System.Drawing.Color.Transparent;
            this.addCabinet.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCabinet.ForeColor = System.Drawing.Color.Black;
            this.addCabinet.Location = new System.Drawing.Point(836, 15);
            this.addCabinet.Name = "addCabinet";
            this.addCabinet.Size = new System.Drawing.Size(274, 54);
            this.addCabinet.TabIndex = 9;
            this.addCabinet.Text = "Ajouter Cabinet";
            this.addCabinet.UseVisualStyleBackColor = false;
            // 
            // cabinetTitlePanel
            // 
            this.cabinetTitlePanel.AutoScroll = true;
            this.cabinetTitlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cabinetTitlePanel.Controls.Add(this.cabinetLatitudeTitleLabel);
            this.cabinetTitlePanel.Controls.Add(this.cabinetLongitudeTitleLabel);
            this.cabinetTitlePanel.Controls.Add(this.label12);
            this.cabinetTitlePanel.Controls.Add(this.label10);
            this.cabinetTitlePanel.Controls.Add(this.cabinetCpTitleLabel);
            this.cabinetTitlePanel.Controls.Add(this.label6);
            this.cabinetTitlePanel.Controls.Add(this.cabinetAdresseTitleLabel);
            this.cabinetTitlePanel.Controls.Add(this.label8);
            this.cabinetTitlePanel.Controls.Add(this.cabinetVilleTitleLabel);
            this.cabinetTitlePanel.Location = new System.Drawing.Point(72, 132);
            this.cabinetTitlePanel.MaximumSize = new System.Drawing.Size(1040, 540);
            this.cabinetTitlePanel.Name = "cabinetTitlePanel";
            this.cabinetTitlePanel.Size = new System.Drawing.Size(1040, 59);
            this.cabinetTitlePanel.TabIndex = 8;
            // 
            // cabinetLatitudeTitleLabel
            // 
            this.cabinetLatitudeTitleLabel.AutoSize = true;
            this.cabinetLatitudeTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.cabinetLatitudeTitleLabel.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cabinetLatitudeTitleLabel.ForeColor = System.Drawing.Color.White;
            this.cabinetLatitudeTitleLabel.Location = new System.Drawing.Point(860, 9);
            this.cabinetLatitudeTitleLabel.Name = "cabinetLatitudeTitleLabel";
            this.cabinetLatitudeTitleLabel.Size = new System.Drawing.Size(78, 24);
            this.cabinetLatitudeTitleLabel.TabIndex = 6;
            this.cabinetLatitudeTitleLabel.Text = "Latitude";
            this.cabinetLatitudeTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cabinetLongitudeTitleLabel
            // 
            this.cabinetLongitudeTitleLabel.AutoSize = true;
            this.cabinetLongitudeTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.cabinetLongitudeTitleLabel.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cabinetLongitudeTitleLabel.ForeColor = System.Drawing.Color.White;
            this.cabinetLongitudeTitleLabel.Location = new System.Drawing.Point(679, 9);
            this.cabinetLongitudeTitleLabel.Name = "cabinetLongitudeTitleLabel";
            this.cabinetLongitudeTitleLabel.Size = new System.Drawing.Size(93, 24);
            this.cabinetLongitudeTitleLabel.TabIndex = 5;
            this.cabinetLongitudeTitleLabel.Text = "Longitude";
            this.cabinetLongitudeTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(812, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(19, 24);
            this.label12.TabIndex = 4;
            this.label12.Text = "|";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(642, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 24);
            this.label10.TabIndex = 2;
            this.label10.Text = "|";
            // 
            // cabinetCpTitleLabel
            // 
            this.cabinetCpTitleLabel.AutoSize = true;
            this.cabinetCpTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.cabinetCpTitleLabel.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cabinetCpTitleLabel.ForeColor = System.Drawing.Color.White;
            this.cabinetCpTitleLabel.Location = new System.Drawing.Point(338, 9);
            this.cabinetCpTitleLabel.Name = "cabinetCpTitleLabel";
            this.cabinetCpTitleLabel.Size = new System.Drawing.Size(109, 24);
            this.cabinetCpTitleLabel.TabIndex = 1;
            this.cabinetCpTitleLabel.Text = "Code Postal";
            this.cabinetCpTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(303, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 24);
            this.label6.TabIndex = 1;
            this.label6.Text = "|";
            // 
            // cabinetAdresseTitleLabel
            // 
            this.cabinetAdresseTitleLabel.AutoSize = true;
            this.cabinetAdresseTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.cabinetAdresseTitleLabel.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cabinetAdresseTitleLabel.ForeColor = System.Drawing.Color.White;
            this.cabinetAdresseTitleLabel.Location = new System.Drawing.Point(134, 9);
            this.cabinetAdresseTitleLabel.Name = "cabinetAdresseTitleLabel";
            this.cabinetAdresseTitleLabel.Size = new System.Drawing.Size(76, 24);
            this.cabinetAdresseTitleLabel.TabIndex = 0;
            this.cabinetAdresseTitleLabel.Text = "Adresse";
            this.cabinetAdresseTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(464, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 24);
            this.label8.TabIndex = 1;
            this.label8.Text = "|";
            // 
            // cabinetVilleTitleLabel
            // 
            this.cabinetVilleTitleLabel.AutoSize = true;
            this.cabinetVilleTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.cabinetVilleTitleLabel.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cabinetVilleTitleLabel.ForeColor = System.Drawing.Color.White;
            this.cabinetVilleTitleLabel.Location = new System.Drawing.Point(534, 9);
            this.cabinetVilleTitleLabel.Name = "cabinetVilleTitleLabel";
            this.cabinetVilleTitleLabel.Size = new System.Drawing.Size(46, 24);
            this.cabinetVilleTitleLabel.TabIndex = 0;
            this.cabinetVilleTitleLabel.Text = "Ville";
            this.cabinetVilleTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cabinetRowPanel
            // 
            this.cabinetRowPanel.AutoScroll = true;
            this.cabinetRowPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cabinetRowPanel.Location = new System.Drawing.Point(72, 189);
            this.cabinetRowPanel.MaximumSize = new System.Drawing.Size(1040, 550);
            this.cabinetRowPanel.Name = "cabinetRowPanel";
            this.cabinetRowPanel.Size = new System.Drawing.Size(1040, 100);
            this.cabinetRowPanel.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cabinets";
            // 
            // affectationPanel
            // 
            this.affectationPanel.Controls.Add(this.label4);
            this.affectationPanel.Location = new System.Drawing.Point(0, 56);
            this.affectationPanel.Name = "affectationPanel";
            this.affectationPanel.Size = new System.Drawing.Size(1185, 803);
            this.affectationPanel.TabIndex = 4;
            this.affectationPanel.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(12, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 33);
            this.label4.TabIndex = 1;
            this.label4.Text = "Affectations";
            // 
            // utilisateurAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1184, 861);
            this.Controls.Add(this.navPanel);
            this.Controls.Add(this.panelCabinet);
            this.Controls.Add(this.medecinPanel);
            this.Controls.Add(this.affectationPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1200, 900);
            this.MinimumSize = new System.Drawing.Size(1200, 900);
            this.Name = "utilisateurAccueil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "utilisateurAccueil";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.utilisateurAccueil_FormClosing);
            this.navPanel.ResumeLayout(false);
            this.navPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.medecinPanel.ResumeLayout(false);
            this.medecinPanel.PerformLayout();
            this.medecinTitlePanel.ResumeLayout(false);
            this.medecinTitlePanel.PerformLayout();
            this.panelCabinet.ResumeLayout(false);
            this.panelCabinet.PerformLayout();
            this.cabinetTitlePanel.ResumeLayout(false);
            this.cabinetTitlePanel.PerformLayout();
            this.affectationPanel.ResumeLayout(false);
            this.affectationPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        private void formMedecin(int i, int y, DataRow medecin)
        {
            this.prenomLabel = new System.Windows.Forms.Label();
            this.lineLabel1 = new System.Windows.Forms.Label();
            this.lineLabel2 = new System.Windows.Forms.Label();
            this.nomLabel = new System.Windows.Forms.Label();
            this.cabinetMedecinLabel = new System.Windows.Forms.Label();
            this.editPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.editPicture)).BeginInit();
            // 
            // prenomLabel
            // 
            this.prenomLabel.AutoSize = true;
            this.prenomLabel.BackColor = System.Drawing.Color.Transparent;
            this.prenomLabel.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prenomLabel.ForeColor = System.Drawing.Color.White;
            this.prenomLabel.Location = new System.Drawing.Point(309, 9 + y);
            this.prenomLabel.Name = "prenomLabel" + i;
            this.prenomLabel.Size = new System.Drawing.Size(75, 24);
            this.prenomLabel.TabIndex = 1;
            this.prenomLabel.Text = medecin["prenom"].ToString();
            this.prenomLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lineLabel1
            // 
            this.lineLabel1.AutoSize = true;
            this.lineLabel1.BackColor = System.Drawing.Color.Transparent;
            this.lineLabel1.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lineLabel1.ForeColor = System.Drawing.Color.White;
            this.lineLabel1.Location = new System.Drawing.Point(210, 9 + y);
            this.lineLabel1.Name = "lineLabel1" + i;
            this.lineLabel1.Size = new System.Drawing.Size(19, 24);
            this.lineLabel1.TabIndex = 1;
            this.lineLabel1.Text = "|";
            // 
            // nomLabel
            // 
            this.nomLabel.AutoSize = true;
            this.nomLabel.BackColor = System.Drawing.Color.Transparent;
            this.nomLabel.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomLabel.ForeColor = System.Drawing.Color.White;
            this.nomLabel.Location = new System.Drawing.Point(80, 9 + y);
            this.nomLabel.Name = "nomLabel" + i;
            this.nomLabel.Size = new System.Drawing.Size(50, 24);
            this.nomLabel.TabIndex = 0;
            this.nomLabel.Text = medecin["nom"].ToString();
            this.nomLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lineLabel2
            // 
            this.lineLabel2.AutoSize = true;
            this.lineLabel2.BackColor = System.Drawing.Color.Transparent;
            this.lineLabel2.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lineLabel2.ForeColor = System.Drawing.Color.White;
            this.lineLabel2.Location = new System.Drawing.Point(464, 9 + y);
            this.lineLabel2.Name = "lineLabel2" + i;
            this.lineLabel2.Size = new System.Drawing.Size(19, 24);
            this.lineLabel2.TabIndex = 1;
            this.lineLabel2.Text = "|";
            // 
            // editPicture
            // 
            this.editPicture.BackColor = System.Drawing.Color.Transparent;
            this.editPicture.Image = ((System.Drawing.Image)(Properties.Resources.editPicture));
            this.editPicture.Location = new System.Drawing.Point(900, 9 + y);
            this.editPicture.Name = "editPicture" + i;
            this.editPicture.Size = new System.Drawing.Size(24, 24);
            this.editPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.editPicture.TabIndex = 4;
            this.editPicture.TabStop = false;
            this.editPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editPicture.Click += new System.EventHandler(delegate (object sender, EventArgs e)
            {
                updateMedecin(sender, e, medecin);
            });
            // 
            // cabinetMedecinLabel
            // 
            this.cabinetMedecinLabel.AutoSize = true;
            this.cabinetMedecinLabel.BackColor = System.Drawing.Color.Transparent;
            this.cabinetMedecinLabel.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cabinetMedecinLabel.ForeColor = System.Drawing.Color.White;
            this.cabinetMedecinLabel.Location = new System.Drawing.Point(563, 9 + y);
            this.cabinetMedecinLabel.Name = "cabinetMedecinLabel" + i;
            this.cabinetMedecinLabel.Size = new System.Drawing.Size(75, 24);
            this.cabinetMedecinLabel.TabIndex = 0;
            this.cabinetMedecinLabel.Text = medecin["adresse"].ToString();
            this.cabinetMedecinLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            medecinRowPanel.Size = new System.Drawing.Size(1040, 100 * i);
            medecinRowPanel.Controls.Add(this.cabinetMedecinLabel);
            medecinRowPanel.Controls.Add(this.prenomLabel);
            medecinRowPanel.Controls.Add(this.nomLabel);
            medecinRowPanel.Controls.Add(this.lineLabel1);
            medecinRowPanel.Controls.Add(this.lineLabel2);
            medecinRowPanel.Controls.Add(this.editPicture);

            ((System.ComponentModel.ISupportInitialize)(this.editPicture)).EndInit();
        }

        private void formCabinet(int i, int y, DataRow cabinet)
        {
            this.adresseLabel = new System.Windows.Forms.Label();
            this.cabinetLineLabel1 = new System.Windows.Forms.Label();
            this.cabinetLineLabel2 = new System.Windows.Forms.Label();
            this.cabinetLineLabel3 = new System.Windows.Forms.Label();
            this.cabinetLineLabel4 = new System.Windows.Forms.Label();
            this.cabinetCodePostalLabel = new System.Windows.Forms.Label();
            this.cabinetVilleLabel = new System.Windows.Forms.Label();
            this.cabinetLongitudeLabel = new System.Windows.Forms.Label();
            this.cabinetLatitudeLabel = new System.Windows.Forms.Label();
            this.editPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.editPicture)).BeginInit();

            // 
            // adresseLabel
            // 
            this.adresseLabel.AutoSize = true;
            this.adresseLabel.BackColor = System.Drawing.Color.Transparent;
            this.adresseLabel.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adresseLabel.ForeColor = System.Drawing.Color.White;
            this.adresseLabel.Location = new System.Drawing.Point(35, 9 + y);
            this.adresseLabel.Name = "adresseLabel" + i;
            this.adresseLabel.Size = new System.Drawing.Size(75, 24);
            this.adresseLabel.TabIndex = 1;
            this.adresseLabel.Text = cabinet["adresse"].ToString();
            this.adresseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // cabinetLineLabel1
            // 
            this.cabinetLineLabel1.AutoSize = true;
            this.cabinetLineLabel1.BackColor = System.Drawing.Color.Transparent;
            this.cabinetLineLabel1.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cabinetLineLabel1.ForeColor = System.Drawing.Color.White;
            this.cabinetLineLabel1.Location = new System.Drawing.Point(303, 9 + y);
            this.cabinetLineLabel1.Name = "cabinetLineLabel1" + i;
            this.cabinetLineLabel1.Size = new System.Drawing.Size(19, 24);
            this.cabinetLineLabel1.TabIndex = 1;
            this.cabinetLineLabel1.Text = "|";


            // 
            // cabinetLineLabel2
            // 
            this.cabinetLineLabel2.AutoSize = true;
            this.cabinetLineLabel2.BackColor = System.Drawing.Color.Transparent;
            this.cabinetLineLabel2.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cabinetLineLabel2.ForeColor = System.Drawing.Color.White;
            this.cabinetLineLabel2.Location = new System.Drawing.Point(464, 9 + y);
            this.cabinetLineLabel2.Name = "cabinetLineLabel2" + i;
            this.cabinetLineLabel2.Size = new System.Drawing.Size(19, 24);
            this.cabinetLineLabel2.TabIndex = 1;
            this.cabinetLineLabel2.Text = "|";

            // 
            // cabinetLineLabel3
            // 
            this.cabinetLineLabel3.AutoSize = true;
            this.cabinetLineLabel3.BackColor = System.Drawing.Color.Transparent;
            this.cabinetLineLabel3.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cabinetLineLabel3.ForeColor = System.Drawing.Color.White;
            this.cabinetLineLabel3.Location = new System.Drawing.Point(642, 9 + y);
            this.cabinetLineLabel3.Name = "cabinetLineLabel3" + i;
            this.cabinetLineLabel3.Size = new System.Drawing.Size(19, 24);
            this.cabinetLineLabel3.TabIndex = 1;
            this.cabinetLineLabel3.Text = "|";

            // 
            // cabinetLineLabel4
            // 
            this.cabinetLineLabel4.AutoSize = true;
            this.cabinetLineLabel4.BackColor = System.Drawing.Color.Transparent;
            this.cabinetLineLabel4.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cabinetLineLabel4.ForeColor = System.Drawing.Color.White;
            this.cabinetLineLabel4.Location = new System.Drawing.Point(812, 9 + y);
            this.cabinetLineLabel4.Name = "cabinetLineLabel4" + i;
            this.cabinetLineLabel4.Size = new System.Drawing.Size(19, 24);
            this.cabinetLineLabel4.TabIndex = 1;
            this.cabinetLineLabel4.Text = "|";

            // 
            // cabinetCodePostalLabel
            // 
            this.cabinetCodePostalLabel.AutoSize = true;
            this.cabinetCodePostalLabel.BackColor = System.Drawing.Color.Transparent;
            this.cabinetCodePostalLabel.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cabinetCodePostalLabel.ForeColor = System.Drawing.Color.White;
            this.cabinetCodePostalLabel.Location = new System.Drawing.Point(335, 9 + y);
            this.cabinetCodePostalLabel.Name = "cabinetCodePostalLabel" + i;
            this.cabinetCodePostalLabel.Size = new System.Drawing.Size(75, 24);
            this.cabinetCodePostalLabel.TabIndex = 1;
            this.cabinetCodePostalLabel.Text = cabinet["code_postal"].ToString();
            this.cabinetCodePostalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // cabinetVilleLabel
            // 
            this.cabinetVilleLabel.AutoSize = true;
            this.cabinetVilleLabel.BackColor = System.Drawing.Color.Transparent;
            this.cabinetVilleLabel.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cabinetVilleLabel.ForeColor = System.Drawing.Color.White;
            this.cabinetVilleLabel.Location = new System.Drawing.Point(490, 9 + y);
            this.cabinetVilleLabel.Name = "cabinetVilleLabel" + i;
            this.cabinetVilleLabel.Size = new System.Drawing.Size(75, 24);
            this.cabinetVilleLabel.TabIndex = 1;
            this.cabinetVilleLabel.Text = cabinet["ville"].ToString();
            this.cabinetVilleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // cabinetLongitudeLabel
            // 
            this.cabinetLongitudeLabel.AutoSize = true;
            this.cabinetLongitudeLabel.BackColor = System.Drawing.Color.Transparent;
            this.cabinetLongitudeLabel.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cabinetLongitudeLabel.ForeColor = System.Drawing.Color.White;
            this.cabinetLongitudeLabel.Location = new System.Drawing.Point(670, 9 + y);
            this.cabinetLongitudeLabel.Name = "cabinetLongitudeLabel" + i;
            this.cabinetLongitudeLabel.Size = new System.Drawing.Size(75, 24);
            this.cabinetLongitudeLabel.TabIndex = 1;
            this.cabinetLongitudeLabel.Text = cabinet["longitude"].ToString();
            this.cabinetLongitudeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // cabinetLatitudeLabel
            // 
            this.cabinetLatitudeLabel.AutoSize = true;
            this.cabinetLatitudeLabel.BackColor = System.Drawing.Color.Transparent;
            this.cabinetLatitudeLabel.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cabinetLatitudeLabel.ForeColor = System.Drawing.Color.White;
            this.cabinetLatitudeLabel.Location = new System.Drawing.Point(855, 9 + y);
            this.cabinetLatitudeLabel.Name = "cabinetLatitudeLabel" + i;
            this.cabinetLatitudeLabel.Size = new System.Drawing.Size(75, 24);
            this.cabinetLatitudeLabel.TabIndex = 1;
            this.cabinetLatitudeLabel.Text = cabinet["latitude"].ToString();
            this.cabinetLatitudeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // editPicture
            // 
            this.editPicture.BackColor = System.Drawing.Color.Transparent;
            this.editPicture.Image = ((System.Drawing.Image)(Properties.Resources.editPicture));
            this.editPicture.Location = new System.Drawing.Point(970, 9 + y);
            this.editPicture.Name = "editPicture" + i;
            this.editPicture.Size = new System.Drawing.Size(24, 24);
            this.editPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.editPicture.TabIndex = 4;
            this.editPicture.TabStop = false;
            this.editPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editPicture.Click += new System.EventHandler(delegate (object sender, EventArgs e)
            {
                updateCabinet(sender, e, cabinet);
            });

            cabinetRowPanel.Size = new System.Drawing.Size(1040, 100 * i);
            cabinetRowPanel.Controls.Add(this.adresseLabel);
            cabinetRowPanel.Controls.Add(this.cabinetLineLabel1);
            cabinetRowPanel.Controls.Add(this.cabinetLineLabel2);
            cabinetRowPanel.Controls.Add(this.cabinetLineLabel3);
            cabinetRowPanel.Controls.Add(this.cabinetLineLabel4);
            cabinetRowPanel.Controls.Add(this.cabinetCodePostalLabel);
            cabinetRowPanel.Controls.Add(this.cabinetVilleLabel);
            cabinetRowPanel.Controls.Add(this.cabinetLongitudeLabel);
            cabinetRowPanel.Controls.Add(this.cabinetLatitudeLabel);
            cabinetRowPanel.Controls.Add(this.editPicture);

            ((System.ComponentModel.ISupportInitialize)(this.editPicture)).EndInit();

        }

        #endregion
        private System.Windows.Forms.Label adresseLabel;
        private System.Windows.Forms.Label cabinetLineLabel1;
        private System.Windows.Forms.Label cabinetLineLabel2;
        private System.Windows.Forms.Label cabinetLineLabel3;
        private System.Windows.Forms.Label cabinetLineLabel4;
        private System.Windows.Forms.Label cabinetCodePostalLabel;
        private System.Windows.Forms.Label cabinetVilleLabel;
        private System.Windows.Forms.Label cabinetLongitudeLabel;
        private System.Windows.Forms.Label cabinetLatitudeLabel;
        private System.Windows.Forms.Panel navPanel;
        private System.Windows.Forms.Label cabinetLabel;
        private System.Windows.Forms.Label pipe1;
        private System.Windows.Forms.Label medecinLabel;
        private System.Windows.Forms.Label statLabel;
        private System.Windows.Forms.Label pipe3;
        private System.Windows.Forms.Label affectationLabel;
        private System.Windows.Forms.Label pipe2;
        private System.Windows.Forms.Panel medecinPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelCabinet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel affectationPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel medecinTitlePanel;
        private System.Windows.Forms.Label prenomTitleLabel;
        private System.Windows.Forms.Label lineTitleLabel1;
        private System.Windows.Forms.Label nomTitleLabel;
        private System.Windows.Forms.Label lineTitleLabel2;
        private System.Windows.Forms.Label cabinetTitleLabel;
        private System.Windows.Forms.Label prenomLabel;
        private System.Windows.Forms.Label lineLabel1;
        private System.Windows.Forms.Label nomLabel;
        private System.Windows.Forms.Label lineLabel2;
        private System.Windows.Forms.Label cabinetMedecinLabel;
        private System.Windows.Forms.Panel medecinRowPanel;
        private System.Windows.Forms.PictureBox editPicture;
        private System.Windows.Forms.Button addMedecin;
        private System.Windows.Forms.Button addCabinet;
        private System.Windows.Forms.Panel cabinetTitlePanel;
        private System.Windows.Forms.Label cabinetCpTitleLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label cabinetAdresseTitleLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label cabinetVilleTitleLabel;
        private System.Windows.Forms.Panel cabinetRowPanel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label cabinetLatitudeTitleLabel;
        private System.Windows.Forms.Label cabinetLongitudeTitleLabel;
    }
}