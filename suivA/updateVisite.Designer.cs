using System;

namespace suivA
{
    partial class UpdateVisite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateVisite));
            this.visiteDatePicker = new System.Windows.Forms.DateTimePicker();
            this.cabinetSelect = new System.Windows.Forms.Label();
            this.medecinSelect = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.validerbutton = new System.Windows.Forms.Button();
            this.hDepartPicker = new System.Windows.Forms.DateTimePicker();
            this.hDebutPicker = new System.Windows.Forms.DateTimePicker();
            this.hArriveePicker = new System.Windows.Forms.DateTimePicker();
            this.radioRdvFalse = new System.Windows.Forms.RadioButton();
            this.radioRdvTrue = new System.Windows.Forms.RadioButton();
            this.rdvFalseLabel = new System.Windows.Forms.Label();
            this.rdvTrueLabel = new System.Windows.Forms.Label();
            this.rdvLabel = new System.Windows.Forms.Label();
            this.hDepart = new System.Windows.Forms.Label();
            this.hDebutLabel = new System.Windows.Forms.Label();
            this.hArriveeLabel = new System.Windows.Forms.Label();
            this.dvisiteLabel = new System.Windows.Forms.Label();
            this.medecinLabel = new System.Windows.Forms.Label();
            this.cabinetLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // visiteDatePicker
            // 
            this.visiteDatePicker.CalendarFont = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visiteDatePicker.CustomFormat = "yyyy-MM-dd";
            this.visiteDatePicker.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visiteDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.visiteDatePicker.Location = new System.Drawing.Point(279, 271);
            this.visiteDatePicker.Name = "visiteDatePicker";
            this.visiteDatePicker.Size = new System.Drawing.Size(146, 40);
            this.visiteDatePicker.TabIndex = 43;
            this.visiteDatePicker.Value = new System.DateTime(2018, 4, 10, 10, 21, 9, 378);
            // 
            // cabinetSelect
            // 
            this.cabinetSelect.AutoSize = true;
            this.cabinetSelect.BackColor = System.Drawing.Color.Transparent;
            this.cabinetSelect.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cabinetSelect.Location = new System.Drawing.Point(213, 80);
            this.cabinetSelect.Name = "cabinetSelect";
            this.cabinetSelect.Size = new System.Drawing.Size(98, 33);
            this.cabinetSelect.TabIndex = 42;
            this.cabinetSelect.Text = "Cabinet";
            // 
            // medecinSelect
            // 
            this.medecinSelect.AutoSize = true;
            this.medecinSelect.BackColor = System.Drawing.Color.Transparent;
            this.medecinSelect.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medecinSelect.Location = new System.Drawing.Point(615, 80);
            this.medecinSelect.Name = "medecinSelect";
            this.medecinSelect.Size = new System.Drawing.Size(109, 33);
            this.medecinSelect.TabIndex = 41;
            this.medecinSelect.Text = "Médecin";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Calibri", 25F);
            this.titleLabel.ForeColor = System.Drawing.Color.Red;
            this.titleLabel.Location = new System.Drawing.Point(18, 16);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(218, 41);
            this.titleLabel.TabIndex = 40;
            this.titleLabel.Text = "Modifier visite";
            // 
            // validerbutton
            // 
            this.validerbutton.BackColor = System.Drawing.Color.White;
            this.validerbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.validerbutton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.validerbutton.FlatAppearance.BorderSize = 10;
            this.validerbutton.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validerbutton.ForeColor = System.Drawing.Color.Black;
            this.validerbutton.Location = new System.Drawing.Point(799, 619);
            this.validerbutton.Name = "validerbutton";
            this.validerbutton.Size = new System.Drawing.Size(128, 46);
            this.validerbutton.TabIndex = 39;
            this.validerbutton.Text = "Valider";
            this.validerbutton.UseVisualStyleBackColor = false;
            this.validerbutton.Click += new System.EventHandler(this.validerbutton_Click);
            // 
            // hDepartPicker
            // 
            this.hDepartPicker.CalendarFont = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hDepartPicker.CalendarForeColor = System.Drawing.Color.Black;
            this.hDepartPicker.CalendarMonthBackground = System.Drawing.SystemColors.InactiveCaptionText;
            this.hDepartPicker.CalendarTitleBackColor = System.Drawing.Color.Black;
            this.hDepartPicker.CalendarTrailingForeColor = System.Drawing.Color.Black;
            this.hDepartPicker.CustomFormat = "HH:mm";
            this.hDepartPicker.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hDepartPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.hDepartPicker.Location = new System.Drawing.Point(721, 424);
            this.hDepartPicker.Name = "hDepartPicker";
            this.hDepartPicker.ShowUpDown = true;
            this.hDepartPicker.Size = new System.Drawing.Size(97, 40);
            this.hDepartPicker.TabIndex = 38;
            this.hDepartPicker.Value = new System.DateTime(2018, 4, 7, 0, 0, 0, 0);
            // 
            // hDebutPicker
            // 
            this.hDebutPicker.CalendarFont = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hDebutPicker.CalendarForeColor = System.Drawing.Color.Black;
            this.hDebutPicker.CalendarMonthBackground = System.Drawing.SystemColors.InactiveCaptionText;
            this.hDebutPicker.CalendarTitleBackColor = System.Drawing.Color.Black;
            this.hDebutPicker.CalendarTrailingForeColor = System.Drawing.Color.Black;
            this.hDebutPicker.CustomFormat = "HH:mm";
            this.hDebutPicker.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hDebutPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.hDebutPicker.Location = new System.Drawing.Point(721, 346);
            this.hDebutPicker.Name = "hDebutPicker";
            this.hDebutPicker.ShowUpDown = true;
            this.hDebutPicker.Size = new System.Drawing.Size(97, 40);
            this.hDebutPicker.TabIndex = 37;
            this.hDebutPicker.Value = new System.DateTime(2018, 4, 7, 0, 0, 0, 0);
            // 
            // hArriveePicker
            // 
            this.hArriveePicker.CalendarFont = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hArriveePicker.CalendarForeColor = System.Drawing.Color.Black;
            this.hArriveePicker.CalendarMonthBackground = System.Drawing.SystemColors.InactiveCaptionText;
            this.hArriveePicker.CalendarTitleBackColor = System.Drawing.Color.Black;
            this.hArriveePicker.CalendarTrailingForeColor = System.Drawing.Color.Black;
            this.hArriveePicker.CustomFormat = "HH:mm";
            this.hArriveePicker.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hArriveePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.hArriveePicker.Location = new System.Drawing.Point(721, 253);
            this.hArriveePicker.Name = "hArriveePicker";
            this.hArriveePicker.ShowUpDown = true;
            this.hArriveePicker.Size = new System.Drawing.Size(97, 40);
            this.hArriveePicker.TabIndex = 36;
            this.hArriveePicker.Value = new System.DateTime(2018, 4, 7, 0, 0, 0, 0);
            // 
            // radioRdvFalse
            // 
            this.radioRdvFalse.AutoSize = true;
            this.radioRdvFalse.BackColor = System.Drawing.Color.Transparent;
            this.radioRdvFalse.ForeColor = System.Drawing.Color.Transparent;
            this.radioRdvFalse.Location = new System.Drawing.Point(279, 530);
            this.radioRdvFalse.Name = "radioRdvFalse";
            this.radioRdvFalse.Size = new System.Drawing.Size(14, 13);
            this.radioRdvFalse.TabIndex = 35;
            this.radioRdvFalse.TabStop = true;
            this.radioRdvFalse.UseVisualStyleBackColor = false;
            // 
            // radioRdvTrue
            // 
            this.radioRdvTrue.AutoSize = true;
            this.radioRdvTrue.BackColor = System.Drawing.Color.Transparent;
            this.radioRdvTrue.ForeColor = System.Drawing.Color.Transparent;
            this.radioRdvTrue.Location = new System.Drawing.Point(155, 530);
            this.radioRdvTrue.Name = "radioRdvTrue";
            this.radioRdvTrue.Size = new System.Drawing.Size(14, 13);
            this.radioRdvTrue.TabIndex = 34;
            this.radioRdvTrue.TabStop = true;
            this.radioRdvTrue.UseVisualStyleBackColor = false;
            // 
            // rdvFalseLabel
            // 
            this.rdvFalseLabel.AutoSize = true;
            this.rdvFalseLabel.BackColor = System.Drawing.Color.Transparent;
            this.rdvFalseLabel.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdvFalseLabel.Location = new System.Drawing.Point(213, 515);
            this.rdvFalseLabel.Name = "rdvFalseLabel";
            this.rdvFalseLabel.Size = new System.Drawing.Size(60, 33);
            this.rdvFalseLabel.TabIndex = 33;
            this.rdvFalseLabel.Text = "Non";
            // 
            // rdvTrueLabel
            // 
            this.rdvTrueLabel.AutoSize = true;
            this.rdvTrueLabel.BackColor = System.Drawing.Color.Transparent;
            this.rdvTrueLabel.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdvTrueLabel.Location = new System.Drawing.Point(96, 515);
            this.rdvTrueLabel.Name = "rdvTrueLabel";
            this.rdvTrueLabel.Size = new System.Drawing.Size(53, 33);
            this.rdvTrueLabel.TabIndex = 32;
            this.rdvTrueLabel.Text = "Oui";
            // 
            // rdvLabel
            // 
            this.rdvLabel.AutoSize = true;
            this.rdvLabel.BackColor = System.Drawing.Color.Transparent;
            this.rdvLabel.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdvLabel.Location = new System.Drawing.Point(96, 424);
            this.rdvLabel.Name = "rdvLabel";
            this.rdvLabel.Size = new System.Drawing.Size(273, 33);
            this.rdvLabel.TabIndex = 31;
            this.rdvLabel.Text = "Visite sur rendez-vous ?";
            // 
            // hDepart
            // 
            this.hDepart.AutoSize = true;
            this.hDepart.BackColor = System.Drawing.Color.Transparent;
            this.hDepart.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hDepart.Location = new System.Drawing.Point(494, 431);
            this.hDepart.Name = "hDepart";
            this.hDepart.Size = new System.Drawing.Size(192, 33);
            this.hDepart.TabIndex = 30;
            this.hDepart.Text = "Heure de départ";
            // 
            // hDebutLabel
            // 
            this.hDebutLabel.AutoSize = true;
            this.hDebutLabel.BackColor = System.Drawing.Color.Transparent;
            this.hDebutLabel.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hDebutLabel.Location = new System.Drawing.Point(494, 346);
            this.hDebutLabel.Name = "hDebutLabel";
            this.hDebutLabel.Size = new System.Drawing.Size(184, 33);
            this.hDebutLabel.TabIndex = 29;
            this.hDebutLabel.Text = "Heure de début";
            // 
            // hArriveeLabel
            // 
            this.hArriveeLabel.AutoSize = true;
            this.hArriveeLabel.BackColor = System.Drawing.Color.Transparent;
            this.hArriveeLabel.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hArriveeLabel.Location = new System.Drawing.Point(494, 259);
            this.hArriveeLabel.Name = "hArriveeLabel";
            this.hArriveeLabel.Size = new System.Drawing.Size(182, 33);
            this.hArriveeLabel.TabIndex = 28;
            this.hArriveeLabel.Text = "Heure d\'arrivée";
            // 
            // dvisiteLabel
            // 
            this.dvisiteLabel.AutoSize = true;
            this.dvisiteLabel.BackColor = System.Drawing.Color.Transparent;
            this.dvisiteLabel.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dvisiteLabel.Location = new System.Drawing.Point(96, 277);
            this.dvisiteLabel.Name = "dvisiteLabel";
            this.dvisiteLabel.Size = new System.Drawing.Size(163, 33);
            this.dvisiteLabel.TabIndex = 27;
            this.dvisiteLabel.Text = "Date de visite";
            // 
            // medecinLabel
            // 
            this.medecinLabel.AutoSize = true;
            this.medecinLabel.BackColor = System.Drawing.Color.Transparent;
            this.medecinLabel.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medecinLabel.Location = new System.Drawing.Point(487, 80);
            this.medecinLabel.Name = "medecinLabel";
            this.medecinLabel.Size = new System.Drawing.Size(122, 33);
            this.medecinLabel.TabIndex = 26;
            this.medecinLabel.Text = "Médecin :";
            // 
            // cabinetLabel
            // 
            this.cabinetLabel.AutoSize = true;
            this.cabinetLabel.BackColor = System.Drawing.Color.Transparent;
            this.cabinetLabel.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cabinetLabel.Location = new System.Drawing.Point(96, 80);
            this.cabinetLabel.Name = "cabinetLabel";
            this.cabinetLabel.Size = new System.Drawing.Size(111, 33);
            this.cabinetLabel.TabIndex = 25;
            this.cabinetLabel.Text = "Cabinet :";
            // 
            // UpdateVisite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(944, 681);
            this.Controls.Add(this.visiteDatePicker);
            this.Controls.Add(this.cabinetSelect);
            this.Controls.Add(this.medecinSelect);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.validerbutton);
            this.Controls.Add(this.hDepartPicker);
            this.Controls.Add(this.hDebutPicker);
            this.Controls.Add(this.hArriveePicker);
            this.Controls.Add(this.radioRdvFalse);
            this.Controls.Add(this.radioRdvTrue);
            this.Controls.Add(this.rdvFalseLabel);
            this.Controls.Add(this.rdvTrueLabel);
            this.Controls.Add(this.rdvLabel);
            this.Controls.Add(this.hDepart);
            this.Controls.Add(this.hDebutLabel);
            this.Controls.Add(this.hArriveeLabel);
            this.Controls.Add(this.dvisiteLabel);
            this.Controls.Add(this.medecinLabel);
            this.Controls.Add(this.cabinetLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(960, 720);
            this.MinimumSize = new System.Drawing.Size(960, 720);
            this.Name = "UpdateVisite";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "UpdateVisite";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker visiteDatePicker;
        private System.Windows.Forms.Label cabinetSelect;
        private System.Windows.Forms.Label medecinSelect;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button validerbutton;
        private System.Windows.Forms.DateTimePicker hDepartPicker;
        private System.Windows.Forms.DateTimePicker hDebutPicker;
        private System.Windows.Forms.DateTimePicker hArriveePicker;
        private System.Windows.Forms.RadioButton radioRdvFalse;
        private System.Windows.Forms.RadioButton radioRdvTrue;
        private System.Windows.Forms.Label rdvFalseLabel;
        private System.Windows.Forms.Label rdvTrueLabel;
        private System.Windows.Forms.Label rdvLabel;
        private System.Windows.Forms.Label hDepart;
        private System.Windows.Forms.Label hDebutLabel;
        private System.Windows.Forms.Label hArriveeLabel;
        private System.Windows.Forms.Label dvisiteLabel;
        private System.Windows.Forms.Label medecinLabel;
        private System.Windows.Forms.Label cabinetLabel;
    }
}