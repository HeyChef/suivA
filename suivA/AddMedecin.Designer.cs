namespace suivA
{
    partial class AddMedecin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMedecin));
            this.prenomBox = new System.Windows.Forms.TextBox();
            this.nomBox = new System.Windows.Forms.TextBox();
            this.adresseBox = new System.Windows.Forms.ComboBox();
            this.medecinSelect = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.validerbutton = new System.Windows.Forms.Button();
            this.prenomLabel = new System.Windows.Forms.Label();
            this.nomLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // prenomBox
            // 
            this.prenomBox.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prenomBox.Location = new System.Drawing.Point(274, 269);
            this.prenomBox.Name = "prenomBox";
            this.prenomBox.Size = new System.Drawing.Size(354, 40);
            this.prenomBox.TabIndex = 71;
            // 
            // nomBox
            // 
            this.nomBox.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomBox.Location = new System.Drawing.Point(274, 172);
            this.nomBox.Name = "nomBox";
            this.nomBox.Size = new System.Drawing.Size(354, 40);
            this.nomBox.TabIndex = 70;
            // 
            // adresseBox
            // 
            this.adresseBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.adresseBox.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adresseBox.FormattingEnabled = true;
            this.adresseBox.Location = new System.Drawing.Point(274, 370);
            this.adresseBox.Name = "adresseBox";
            this.adresseBox.Size = new System.Drawing.Size(354, 41);
            this.adresseBox.TabIndex = 69;
            // 
            // medecinSelect
            // 
            this.medecinSelect.AutoSize = true;
            this.medecinSelect.BackColor = System.Drawing.Color.Transparent;
            this.medecinSelect.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medecinSelect.Location = new System.Drawing.Point(110, 373);
            this.medecinSelect.Name = "medecinSelect";
            this.medecinSelect.Size = new System.Drawing.Size(111, 33);
            this.medecinSelect.TabIndex = 68;
            this.medecinSelect.Text = "Cabinet :";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Calibri", 25F);
            this.titleLabel.ForeColor = System.Drawing.Color.Red;
            this.titleLabel.Location = new System.Drawing.Point(18, 16);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(249, 41);
            this.titleLabel.TabIndex = 67;
            this.titleLabel.Text = "Ajouter médecin";
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
            this.validerbutton.TabIndex = 66;
            this.validerbutton.Text = "Valider";
            this.validerbutton.UseVisualStyleBackColor = false;
            this.validerbutton.Click += new System.EventHandler(this.validerbutton_Click);
            // 
            // prenomLabel
            // 
            this.prenomLabel.AutoSize = true;
            this.prenomLabel.BackColor = System.Drawing.Color.Transparent;
            this.prenomLabel.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prenomLabel.Location = new System.Drawing.Point(110, 276);
            this.prenomLabel.Name = "prenomLabel";
            this.prenomLabel.Size = new System.Drawing.Size(114, 33);
            this.prenomLabel.TabIndex = 65;
            this.prenomLabel.Text = "Prénom :";
            // 
            // nomLabel
            // 
            this.nomLabel.AutoSize = true;
            this.nomLabel.BackColor = System.Drawing.Color.Transparent;
            this.nomLabel.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomLabel.Location = new System.Drawing.Point(110, 179);
            this.nomLabel.Name = "nomLabel";
            this.nomLabel.Size = new System.Drawing.Size(81, 33);
            this.nomLabel.TabIndex = 64;
            this.nomLabel.Text = "Nom :";
            // 
            // AddMedecin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(944, 681);
            this.Controls.Add(this.prenomBox);
            this.Controls.Add(this.nomBox);
            this.Controls.Add(this.adresseBox);
            this.Controls.Add(this.medecinSelect);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.validerbutton);
            this.Controls.Add(this.prenomLabel);
            this.Controls.Add(this.nomLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(960, 720);
            this.MinimumSize = new System.Drawing.Size(960, 720);
            this.Name = "AddMedecin";
            this.Text = "AddMedecin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox prenomBox;
        private System.Windows.Forms.TextBox nomBox;
        private System.Windows.Forms.ComboBox adresseBox;
        private System.Windows.Forms.Label medecinSelect;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button validerbutton;
        private System.Windows.Forms.Label prenomLabel;
        private System.Windows.Forms.Label nomLabel;
    }
}