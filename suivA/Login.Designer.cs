namespace suivA
{
    partial class Login
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.validerbutton = new System.Windows.Forms.Button();
            this.passwordbox = new System.Windows.Forms.TextBox();
            this.identifiantbox = new System.Windows.Forms.TextBox();
            this.passwordlabel = new System.Windows.Forms.Label();
            this.identifiantlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // validerbutton
            // 
            this.validerbutton.BackColor = System.Drawing.Color.Transparent;
            this.validerbutton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.validerbutton.FlatAppearance.BorderSize = 10;
            this.validerbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validerbutton.ForeColor = System.Drawing.Color.Black;
            this.validerbutton.Location = new System.Drawing.Point(492, 560);
            this.validerbutton.Name = "validerbutton";
            this.validerbutton.Size = new System.Drawing.Size(111, 40);
            this.validerbutton.TabIndex = 14;
            this.validerbutton.Text = "Valider";
            this.validerbutton.UseVisualStyleBackColor = false;
            this.validerbutton.Click += new System.EventHandler(this.validerbutton_Click);
            // 
            // passwordbox
            // 
            this.passwordbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordbox.Location = new System.Drawing.Point(692, 410);
            this.passwordbox.Name = "passwordbox";
            this.passwordbox.Size = new System.Drawing.Size(200, 38);
            this.passwordbox.TabIndex = 13;
            // 
            // identifiantbox
            // 
            this.identifiantbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.identifiantbox.Location = new System.Drawing.Point(692, 260);
            this.identifiantbox.Name = "identifiantbox";
            this.identifiantbox.Size = new System.Drawing.Size(200, 38);
            this.identifiantbox.TabIndex = 12;
            // 
            // passwordlabel
            // 
            this.passwordlabel.AutoSize = true;
            this.passwordlabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordlabel.Location = new System.Drawing.Point(292, 410);
            this.passwordlabel.Name = "passwordlabel";
            this.passwordlabel.Size = new System.Drawing.Size(176, 31);
            this.passwordlabel.TabIndex = 11;
            this.passwordlabel.Text = "Mot de passe";
            // 
            // identifiantlabel
            // 
            this.identifiantlabel.AutoSize = true;
            this.identifiantlabel.BackColor = System.Drawing.Color.Transparent;
            this.identifiantlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.identifiantlabel.Location = new System.Drawing.Point(292, 260);
            this.identifiantlabel.Name = "identifiantlabel";
            this.identifiantlabel.Size = new System.Drawing.Size(133, 31);
            this.identifiantlabel.TabIndex = 10;
            this.identifiantlabel.Text = "Identifiant";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1184, 861);
            this.Controls.Add(this.validerbutton);
            this.Controls.Add(this.passwordbox);
            this.Controls.Add(this.identifiantbox);
            this.Controls.Add(this.passwordlabel);
            this.Controls.Add(this.identifiantlabel);
            this.MaximumSize = new System.Drawing.Size(1200, 900);
            this.MinimumSize = new System.Drawing.Size(1200, 900);
            this.Name = "Login";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button validerbutton;
        private System.Windows.Forms.TextBox passwordbox;
        private System.Windows.Forms.TextBox identifiantbox;
        private System.Windows.Forms.Label passwordlabel;
        private System.Windows.Forms.Label identifiantlabel;
    }
}

