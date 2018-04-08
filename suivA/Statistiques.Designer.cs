namespace suivA
{
    partial class Statistiques
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Statistiques));
            this.titleLabel = new System.Windows.Forms.Label();
            this.statMedecinLabel = new System.Windows.Forms.Label();
            this.medecinBox = new System.Windows.Forms.ComboBox();
            this.fPPicker = new System.Windows.Forms.DateTimePicker();
            this.dPPicker = new System.Windows.Forms.DateTimePicker();
            this.medecinLabel = new System.Windows.Forms.Label();
            this.pDebutLabel = new System.Windows.Forms.Label();
            this.pFinLabel = new System.Windows.Forms.Label();
            this.statMedecinResultLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.visiteurLabel = new System.Windows.Forms.Label();
            this.visiteurBox = new System.Windows.Forms.ComboBox();
            this.labelJour = new System.Windows.Forms.Label();
            this.dVisiteVis = new System.Windows.Forms.DateTimePicker();
            this.statVisiteurJourResultLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.statVisiteurHeurePResultLabel = new System.Windows.Forms.Label();
            this.resultTpsAttenteLabel = new System.Windows.Forms.Label();
            this.tpsAttenteLabel = new System.Windows.Forms.Label();
            this.resultTempsEntretienLabel = new System.Windows.Forms.Label();
            this.tpsEntretienLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Calibri", 25F);
            this.titleLabel.ForeColor = System.Drawing.Color.Red;
            this.titleLabel.Location = new System.Drawing.Point(12, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(178, 41);
            this.titleLabel.TabIndex = 22;
            this.titleLabel.Text = "Statistiques";
            // 
            // statMedecinLabel
            // 
            this.statMedecinLabel.AutoSize = true;
            this.statMedecinLabel.BackColor = System.Drawing.Color.Transparent;
            this.statMedecinLabel.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statMedecinLabel.Location = new System.Drawing.Point(13, 101);
            this.statMedecinLabel.Name = "statMedecinLabel";
            this.statMedecinLabel.Size = new System.Drawing.Size(496, 33);
            this.statMedecinLabel.TabIndex = 24;
            this.statMedecinLabel.Text = "Nombre de visites par médecin par période :";
            // 
            // medecinBox
            // 
            this.medecinBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.medecinBox.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medecinBox.FormattingEnabled = true;
            this.medecinBox.Location = new System.Drawing.Point(141, 166);
            this.medecinBox.Name = "medecinBox";
            this.medecinBox.Size = new System.Drawing.Size(210, 41);
            this.medecinBox.TabIndex = 25;
            this.medecinBox.SelectedIndexChanged += new System.EventHandler(this.paramChangeMedecin);
            // 
            // fPPicker
            // 
            this.fPPicker.CalendarFont = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fPPicker.CustomFormat = "dd/MM/yyyy";
            this.fPPicker.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fPPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fPPicker.Location = new System.Drawing.Point(666, 167);
            this.fPPicker.Name = "fPPicker";
            this.fPPicker.Size = new System.Drawing.Size(155, 40);
            this.fPPicker.TabIndex = 26;
            this.fPPicker.Value = new System.DateTime(2018, 4, 7, 0, 0, 0, 0);
            this.fPPicker.ValueChanged += new System.EventHandler(this.paramChangeMedecin);
            // 
            // dPPicker
            // 
            this.dPPicker.CalendarFont = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dPPicker.CustomFormat = "dd/MM/yyyy";
            this.dPPicker.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dPPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dPPicker.Location = new System.Drawing.Point(445, 167);
            this.dPPicker.Name = "dPPicker";
            this.dPPicker.Size = new System.Drawing.Size(155, 40);
            this.dPPicker.TabIndex = 27;
            this.dPPicker.Value = new System.DateTime(2018, 4, 7, 0, 0, 0, 0);
            this.dPPicker.ValueChanged += new System.EventHandler(this.paramChangeMedecin);
            // 
            // medecinLabel
            // 
            this.medecinLabel.AutoSize = true;
            this.medecinLabel.BackColor = System.Drawing.Color.Transparent;
            this.medecinLabel.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medecinLabel.Location = new System.Drawing.Point(13, 166);
            this.medecinLabel.Name = "medecinLabel";
            this.medecinLabel.Size = new System.Drawing.Size(109, 33);
            this.medecinLabel.TabIndex = 28;
            this.medecinLabel.Text = "Médecin";
            // 
            // pDebutLabel
            // 
            this.pDebutLabel.AutoSize = true;
            this.pDebutLabel.BackColor = System.Drawing.Color.Transparent;
            this.pDebutLabel.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pDebutLabel.Location = new System.Drawing.Point(357, 166);
            this.pDebutLabel.Name = "pDebutLabel";
            this.pDebutLabel.Size = new System.Drawing.Size(82, 33);
            this.pDebutLabel.TabIndex = 29;
            this.pDebutLabel.Text = "Début";
            // 
            // pFinLabel
            // 
            this.pFinLabel.AutoSize = true;
            this.pFinLabel.BackColor = System.Drawing.Color.Transparent;
            this.pFinLabel.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pFinLabel.Location = new System.Drawing.Point(613, 169);
            this.pFinLabel.Name = "pFinLabel";
            this.pFinLabel.Size = new System.Drawing.Size(47, 33);
            this.pFinLabel.TabIndex = 30;
            this.pFinLabel.Text = "Fin";
            // 
            // statMedecinResultLabel
            // 
            this.statMedecinResultLabel.AutoSize = true;
            this.statMedecinResultLabel.BackColor = System.Drawing.Color.Transparent;
            this.statMedecinResultLabel.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statMedecinResultLabel.Location = new System.Drawing.Point(531, 101);
            this.statMedecinResultLabel.Name = "statMedecinResultLabel";
            this.statMedecinResultLabel.Size = new System.Drawing.Size(0, 33);
            this.statMedecinResultLabel.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(443, 33);
            this.label1.TabIndex = 32;
            this.label1.Text = "Nombre de visites par visiteur par jour :";
            // 
            // visiteurLabel
            // 
            this.visiteurLabel.AutoSize = true;
            this.visiteurLabel.BackColor = System.Drawing.Color.Transparent;
            this.visiteurLabel.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visiteurLabel.Location = new System.Drawing.Point(13, 426);
            this.visiteurLabel.Name = "visiteurLabel";
            this.visiteurLabel.Size = new System.Drawing.Size(98, 33);
            this.visiteurLabel.TabIndex = 33;
            this.visiteurLabel.Text = "Visiteur";
            // 
            // visiteurBox
            // 
            this.visiteurBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.visiteurBox.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visiteurBox.FormattingEnabled = true;
            this.visiteurBox.Location = new System.Drawing.Point(141, 426);
            this.visiteurBox.Name = "visiteurBox";
            this.visiteurBox.Size = new System.Drawing.Size(210, 41);
            this.visiteurBox.TabIndex = 34;
            this.visiteurBox.SelectedIndexChanged += new System.EventHandler(this.paramChangeVisiteur);
            // 
            // labelJour
            // 
            this.labelJour.AutoSize = true;
            this.labelJour.BackColor = System.Drawing.Color.Transparent;
            this.labelJour.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJour.Location = new System.Drawing.Point(357, 426);
            this.labelJour.Name = "labelJour";
            this.labelJour.Size = new System.Drawing.Size(61, 33);
            this.labelJour.TabIndex = 35;
            this.labelJour.Text = "Jour";
            // 
            // dVisiteVis
            // 
            this.dVisiteVis.CalendarFont = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dVisiteVis.CustomFormat = "dd/MM/yyyy";
            this.dVisiteVis.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dVisiteVis.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dVisiteVis.Location = new System.Drawing.Point(445, 426);
            this.dVisiteVis.Name = "dVisiteVis";
            this.dVisiteVis.Size = new System.Drawing.Size(155, 40);
            this.dVisiteVis.TabIndex = 36;
            this.dVisiteVis.Value = new System.DateTime(2018, 4, 7, 0, 0, 0, 0);
            this.dVisiteVis.ValueChanged += new System.EventHandler(this.paramChangeVisiteur);
            // 
            // statVisiteurJourResultLabel
            // 
            this.statVisiteurJourResultLabel.AutoSize = true;
            this.statVisiteurJourResultLabel.BackColor = System.Drawing.Color.Transparent;
            this.statVisiteurJourResultLabel.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statVisiteurJourResultLabel.Location = new System.Drawing.Point(471, 268);
            this.statVisiteurJourResultLabel.Name = "statVisiteurJourResultLabel";
            this.statVisiteurJourResultLabel.Size = new System.Drawing.Size(0, 33);
            this.statVisiteurJourResultLabel.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(528, 33);
            this.label3.TabIndex = 38;
            this.label3.Text = "Nombre d\'heures passées par visiteur par jour :";
            // 
            // statVisiteurHeurePResultLabel
            // 
            this.statVisiteurHeurePResultLabel.AutoSize = true;
            this.statVisiteurHeurePResultLabel.BackColor = System.Drawing.Color.Transparent;
            this.statVisiteurHeurePResultLabel.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statVisiteurHeurePResultLabel.Location = new System.Drawing.Point(547, 327);
            this.statVisiteurHeurePResultLabel.Name = "statVisiteurHeurePResultLabel";
            this.statVisiteurHeurePResultLabel.Size = new System.Drawing.Size(0, 33);
            this.statVisiteurHeurePResultLabel.TabIndex = 40;
            // 
            // resultTpsAttenteLabel
            // 
            this.resultTpsAttenteLabel.AutoSize = true;
            this.resultTpsAttenteLabel.BackColor = System.Drawing.Color.Transparent;
            this.resultTpsAttenteLabel.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultTpsAttenteLabel.Location = new System.Drawing.Point(291, 628);
            this.resultTpsAttenteLabel.Name = "resultTpsAttenteLabel";
            this.resultTpsAttenteLabel.Size = new System.Drawing.Size(0, 33);
            this.resultTpsAttenteLabel.TabIndex = 42;
            // 
            // tpsAttenteLabel
            // 
            this.tpsAttenteLabel.AutoSize = true;
            this.tpsAttenteLabel.BackColor = System.Drawing.Color.Transparent;
            this.tpsAttenteLabel.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpsAttenteLabel.Location = new System.Drawing.Point(13, 628);
            this.tpsAttenteLabel.Name = "tpsAttenteLabel";
            this.tpsAttenteLabel.Size = new System.Drawing.Size(272, 33);
            this.tpsAttenteLabel.TabIndex = 41;
            this.tpsAttenteLabel.Text = "Temps d\'attente moyen";
            // 
            // resultTempsEntretienLabel
            // 
            this.resultTempsEntretienLabel.AutoSize = true;
            this.resultTempsEntretienLabel.BackColor = System.Drawing.Color.Transparent;
            this.resultTempsEntretienLabel.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultTempsEntretienLabel.Location = new System.Drawing.Point(346, 580);
            this.resultTempsEntretienLabel.Name = "resultTempsEntretienLabel";
            this.resultTempsEntretienLabel.Size = new System.Drawing.Size(0, 33);
            this.resultTempsEntretienLabel.TabIndex = 44;
            // 
            // tpsEntretienLabel
            // 
            this.tpsEntretienLabel.AutoSize = true;
            this.tpsEntretienLabel.BackColor = System.Drawing.Color.Transparent;
            this.tpsEntretienLabel.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpsEntretienLabel.Location = new System.Drawing.Point(13, 580);
            this.tpsEntretienLabel.Name = "tpsEntretienLabel";
            this.tpsEntretienLabel.Size = new System.Drawing.Size(327, 33);
            this.tpsEntretienLabel.TabIndex = 43;
            this.tpsEntretienLabel.Text = "Temps moyen d\'un entretien";
            // 
            // Statistiques
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(944, 681);
            this.Controls.Add(this.resultTempsEntretienLabel);
            this.Controls.Add(this.tpsEntretienLabel);
            this.Controls.Add(this.resultTpsAttenteLabel);
            this.Controls.Add(this.tpsAttenteLabel);
            this.Controls.Add(this.statVisiteurHeurePResultLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.statVisiteurJourResultLabel);
            this.Controls.Add(this.dVisiteVis);
            this.Controls.Add(this.labelJour);
            this.Controls.Add(this.visiteurBox);
            this.Controls.Add(this.visiteurLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statMedecinResultLabel);
            this.Controls.Add(this.pFinLabel);
            this.Controls.Add(this.pDebutLabel);
            this.Controls.Add(this.medecinLabel);
            this.Controls.Add(this.dPPicker);
            this.Controls.Add(this.fPPicker);
            this.Controls.Add(this.medecinBox);
            this.Controls.Add(this.statMedecinLabel);
            this.Controls.Add(this.titleLabel);
            this.MaximumSize = new System.Drawing.Size(960, 720);
            this.MinimumSize = new System.Drawing.Size(960, 720);
            this.Name = "Statistiques";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statistiques";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label statMedecinLabel;
        private System.Windows.Forms.ComboBox medecinBox;
        private System.Windows.Forms.DateTimePicker fPPicker;
        private System.Windows.Forms.DateTimePicker dPPicker;
        private System.Windows.Forms.Label medecinLabel;
        private System.Windows.Forms.Label pDebutLabel;
        private System.Windows.Forms.Label pFinLabel;
        private System.Windows.Forms.Label statMedecinResultLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label visiteurLabel;
        private System.Windows.Forms.ComboBox visiteurBox;
        private System.Windows.Forms.Label labelJour;
        private System.Windows.Forms.DateTimePicker dVisiteVis;
        private System.Windows.Forms.Label statVisiteurJourResultLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label statVisiteurHeurePResultLabel;
        private System.Windows.Forms.Label resultTpsAttenteLabel;
        private System.Windows.Forms.Label tpsAttenteLabel;
        private System.Windows.Forms.Label resultTempsEntretienLabel;
        private System.Windows.Forms.Label tpsEntretienLabel;
    }
}