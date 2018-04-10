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
            this.panel2 = new System.Windows.Forms.Panel();
            this.prenomTitleLabel = new System.Windows.Forms.Label();
            this.lineTitleLabel1 = new System.Windows.Forms.Label();
            this.nomTitleLabel = new System.Windows.Forms.Label();
            this.lineTitleLabel2 = new System.Windows.Forms.Label();
            this.cabinetTitleLabel = new System.Windows.Forms.Label();
            this.medecinRowPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelCabinet = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.affectationPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.navPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.medecinPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelCabinet.SuspendLayout();
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
            this.medecinPanel.Controls.Add(this.panel2);
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
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.prenomTitleLabel);
            this.panel2.Controls.Add(this.lineTitleLabel1);
            this.panel2.Controls.Add(this.nomTitleLabel);
            this.panel2.Controls.Add(this.lineTitleLabel2);
            this.panel2.Controls.Add(this.cabinetTitleLabel);
            this.panel2.Location = new System.Drawing.Point(70, 132);
            this.panel2.MaximumSize = new System.Drawing.Size(1040, 540);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1040, 59);
            this.panel2.TabIndex = 5;
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
            this.panelCabinet.Controls.Add(this.label2);
            this.panelCabinet.Location = new System.Drawing.Point(0, 56);
            this.panelCabinet.Name = "panelCabinet";
            this.panelCabinet.Size = new System.Drawing.Size(1185, 803);
            this.panelCabinet.TabIndex = 3;
            this.panelCabinet.Visible = false;
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
            this.Controls.Add(this.medecinPanel);
            this.Controls.Add(this.navPanel);
            this.Controls.Add(this.affectationPanel);
            this.Controls.Add(this.panelCabinet);
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
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelCabinet.ResumeLayout(false);
            this.panelCabinet.PerformLayout();
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

        #endregion

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
        private System.Windows.Forms.Panel panel2;
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
    }
}